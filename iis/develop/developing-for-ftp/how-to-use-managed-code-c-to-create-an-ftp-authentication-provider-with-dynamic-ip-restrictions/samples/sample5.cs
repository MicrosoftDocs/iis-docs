using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration.Provider;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Microsoft.Web.FtpServer;

public class FtpAddressRestrictionAuthentication :
  BaseProvider,
  IFtpLogProvider,
  IFtpAuthenticationProvider
{
  // Define the default values - these are only
  // used if the configuration settings are not set.
  const int defaultLogonAttempts = 5;
  const int defaultFloodSeconds = 30;

  // Define a connection string with no default.
  private static string _connectionString;

  // Initialize the private variables with the default values.
  private static int _logonAttempts = defaultLogonAttempts;
  private static int _floodSeconds = defaultFloodSeconds;

  // Flag the application as uninitialized.
  private static bool _initialized = false;

  // Define a list that will contain the list of flagged sessions.
  private static List<string> _flaggedSessions;

  // Initialize the provider.
  protected override void Initialize(StringDictionary config)
  {
    // Test if the application has already been initialized.
    if (_initialized == false)
    {
      // Create the flagged sessions list.
      _flaggedSessions = new List<string>();

      // Retrieve the connection string for the database connection.
      _connectionString = config["connectionString"];
      if (string.IsNullOrEmpty(_connectionString))
      {
        // Raise an exception if the connection string is missing or empty.
        throw new ArgumentException(
          "Missing connectionString value in configuration.");
      }
      else
      {
        // Determine whether the database is a Microsoft Access database.
        if (_connectionString.Contains("Microsoft.Jet"))
        {
          // Throw an exception if the database is a Microsoft Access database.
          throw new ProviderException("Microsoft Access databases are not supported.");
        }
      }

      // Retrieve the number of failures before an IP
      // address is locked out - or use the default value.
      if (int.TryParse(config["logonAttempts"], out _logonAttempts) == false)
      {
        // Set to the default if the number of logon attempts is not valid.
        _logonAttempts = defaultLogonAttempts;
      }

      // Retrieve the number of seconds for flood
      // prevention - or use the default value.
      if (int.TryParse(config["floodSeconds"], out _floodSeconds) == false)
      {
        // Set to the default if the number of logon attempts is not valid.
        _floodSeconds = defaultFloodSeconds;
      }

      // Test if the number is a positive integer and less than 10 minutes.
      if ((_floodSeconds <= 0) || (_floodSeconds > 600))
      {
        // Set to the default if the number of logon attempts is not valid.
        _floodSeconds = defaultFloodSeconds;
      }

      // Initial garbage collection.
      GarbageCollection(true);
      // Flag the provider as initialized.
      _initialized = true;
    }
  }

  // Dispose of the provider.
  protected override void Dispose(bool disposing)
  {
    base.Dispose(disposing);

    // Test if the application has already been uninitialized.
    if (_initialized == true)
    {
      // Final garbage collection.
      GarbageCollection(true);
      // Flag the provider as uninitialized.
      _initialized = false;
    }
  }

  // Authenticate a user.
  bool IFtpAuthenticationProvider.AuthenticateUser(
    string sessionId,
    string siteName,
    string userName,
    string userPassword,
    out string canonicalUserName)
  {
    // Define the canonical user name.
    canonicalUserName = userName;

    // Check if the session is flagged.
    if (IsSessionFlagged(sessionId) == true)
    {
      // Return false (authentication failed) if the session is flagged.
      return false;
    }

    // Check the user credentials and return the status.
    return IsValidUser(userName, userPassword);
  }

  // Implement custom actions by using the Log() method.
  void IFtpLogProvider.Log(FtpLogEntry loggingParameters)
  {
    // Test if the control channel was opened or the USER command was sent.
    if ((String.Compare(loggingParameters.Command,
      "ControlChannelOpened", true) == 0)
      || (String.Compare(loggingParameters.Command,
      "USER", true) == 0))
    {
      // Check if the IP address is banned.
      if (IsAddressBanned(loggingParameters.RemoteIPAddress) == true)
      {
        // If the IP is banned, flag the session.
        FlagSession(loggingParameters.SessionId);
        return;
      }
    }
    // Test if the PASS command was sent.
    if (String.Compare(loggingParameters.Command,
      "PASS", true) == 0)
    {
      // Check for password failures (230 is a success).
      if (loggingParameters.FtpStatus != 230)
      {
        // Periodic garbage collection - remove authentication
        // failures that are older than the flood timeout.
        GarbageCollection(false);

        // Test if the existing number of failures exceeds the maximum logon attempts.
        if (GetRecordCountByCriteria("[Failures]",
          "[IPAddress]='" + loggingParameters.RemoteIPAddress +
          "'") < _logonAttempts)
        {
          // Add the failure to the list of failures.
          InsertDataIntoTable("[Failures]",
            "[IPAddress],[FailureDateTime]",
            "'" + loggingParameters.RemoteIPAddress +
            "','" + DateTime.Now.ToString() + "'");
        }
        else
        {
          // Ban the IP address if authentication has failed
          // from that IP more than the defined number of failures.
          BanAddress(loggingParameters.RemoteIPAddress);
          FlagSession(loggingParameters.SessionId);
        }
        return;
      }
    }
    // Test if the control channel was closed.
    if (String.Compare(loggingParameters.Command,
      "ControlChannelClosed", true) == 0)
    {
      // Session-based garbage collection - remove the
      // current session from the list of flagged sessions.
      _flaggedSessions.Remove(loggingParameters.SessionId);
      return;
    }
  }

  // Check for a valid username/password.
  private static bool IsValidUser(
    string userName,
    string userPassword)
  {
    // Define the initial status as the credentials are not valid.
    try
    {
      // Create a new SQL connection object.
      using (SqlConnection connection = new SqlConnection(_connectionString))
      {
        // Create a new SQL command object.
        using (SqlCommand command = new SqlCommand())
        {
          // Specify the connection for the command object.
          command.Connection = connection;
          // Specify a text command type.
          command.CommandType = CommandType.Text;

          // Specify the SQL text for the command object.
          command.CommandText = "SELECT COUNT(*) AS [NumRecords] " +
            "FROM [Users] WHERE [UID]=@UID AND [PWD]=@PWD AND [Locked]=0";

          // Add parameters for the user name and password.
          command.Parameters.Add("@UID", SqlDbType.NVarChar).Value = userName;
          command.Parameters.Add("@PWD", SqlDbType.NVarChar).Value = userPassword;

          // Open the database connection.
          connection.Open();
          // Return the valid status for the credentials.
          return ((int)command.ExecuteScalar() > 0);
        }
      }
    }
    catch (Exception ex)
    {
      // Raise an exception if an error occurs.
      throw new ProviderException(ex.Message);
    }
  }

  // Check if the IP is banned.
  private bool IsAddressBanned(string ipAddress)
  {
    // Return whether the IP address was found in the banned addresses table.
    return (GetRecordCountByCriteria("[BannedAddresses]",
      "[IPAddress]='" + ipAddress + "'") != 0);
  }

  // Check if the session is flagged.
  private bool IsSessionFlagged(string sessionId)
  {
    // Return whether the session ID was found in the flagged sessions table.
    return _flaggedSessions.Contains(sessionId);
  }

  // Mark a session as flagged.
  private void FlagSession(string sessionId)
  {
    // Check if the session is already flagged.
    if (IsSessionFlagged(sessionId) == false)
    {
      // Flag the session if it is not already flagged.
      _flaggedSessions.Add(sessionId);
    }
  }

  // Mark an IP address as banned.
  private void BanAddress(string ipAddress)
  {
    // Check if the IP address is already banned.
    if (IsAddressBanned(ipAddress) == false)
    {
      // Ban the IP address if it is not already banned.
      InsertDataIntoTable("[BannedAddresses]",
        "[IPAddress]", "'" + ipAddress + "'");
    }
  }

  // Perform garbage collection tasks.
  private void GarbageCollection(bool deleteSessions)
  {
    // Remove any authentication failures that are older than the flood timeout.
    DeleteRecordsByCriteria("[Failures]",
      String.Format("DATEDIFF(second,[FailureDateTime],'{0}')>{1}",
      DateTime.Now.ToString(),_floodSeconds.ToString()));

    // Test if flagged sessions should be deleted.
    if (deleteSessions == true)
    {
      // Remove any sessions from the list of flagged sessions.
      _flaggedSessions.Clear();
    }
  }

  // Retrieve the count of records based on definable criteria.
  private int GetRecordCountByCriteria(
    string tableName,
    string criteria)
  {
    // Create a SQL string to retrieve the count of records 
    // that are found in a table based on the criteria.
    StringBuilder sqlString = new StringBuilder();
    sqlString.Append("SELECT COUNT(*) AS [NumRecords]");
    sqlString.Append(String.Format(
      " FROM {0}",tableName));
    sqlString.Append(String.Format(
      " WHERE {0}",criteria));
    // Execute the query.
    return ExecuteQuery(true, sqlString.ToString());
  }

  // Insert records into a database table.
  private void InsertDataIntoTable(
    string tableName,
    string fieldNames,
    string fieldValues)
  {
    // Create a SQL string to insert data into a table.
    StringBuilder sqlString = new StringBuilder();
    sqlString.Append(String.Format(
      "INSERT INTO {0}",tableName));
    sqlString.Append(String.Format(
      "({0}) VALUES({1})",fieldNames, fieldValues));
    // Execute the query.
    ExecuteQuery(false, sqlString.ToString());
  }

  // Remove records from a table based on criteria.
  private void DeleteRecordsByCriteria(
    string tableName,
    string queryCriteria)
  {
    // Create a SQL string to delete data from a table.
    StringBuilder sqlString = new StringBuilder();
    sqlString.Append(String.Format(
      "DELETE FROM {0}",tableName));
    // Test if any criteria is specified.
    if (string.IsNullOrEmpty(queryCriteria) == false)
    {
      // Append the criteria to the SQL string.
      sqlString.Append(String.Format(
        " WHERE {0}",queryCriteria));
    }
    // Execute the query.
    ExecuteQuery(false, sqlString.ToString());
  }

  // Execute SQL queries.
  private int ExecuteQuery(bool returnRecordCount, string sqlQuery)
  {
    try
    {
      // Create a new SQL connection object.
      using (SqlConnection connection =
        new SqlConnection(_connectionString))
      {
        // Create a new SQL command object.
        using (SqlCommand command =
          new SqlCommand(sqlQuery, connection))
        {
          // Open the connection.
          connection.Open();
          // Test whether the method should return a record count.
          if (returnRecordCount == true)
          {
            // Run the database query.
            SqlDataReader dataReader = command.ExecuteReader();
            // Test if data reader has returned any rows.
            if (dataReader.HasRows)
            {
              // Read a single row.
              dataReader.Read();
              // Return the number of records.
              return ((int)dataReader["NumRecords"]);
            }
          }
          else
          {
            // Run the database query.
            command.ExecuteNonQuery();
          }
        }
      }
      // Return a zero record count.
      return 0;
    }
    catch (Exception ex)
    {
      // Raise an exception if an error occurs.
      throw new ProviderException(ex.Message);
    }
  }
}
