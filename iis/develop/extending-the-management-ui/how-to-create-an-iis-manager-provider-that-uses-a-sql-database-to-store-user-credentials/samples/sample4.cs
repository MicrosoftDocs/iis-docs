using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.Management.Server;
using System.Data.SqlClient;

namespace SqlIisManagerDemo
{
   public class IisManagerProvider : ManagementAuthenticationProvider
   {
      // Storage for the provider's SQL connection string.
      private string _connectionString;

      public override void Initialize(IDictionary<string, string> args)
      {
         // Initialize the argument list.
         base.Initialize(args);

         // Test if the arguments contain a connection string.
         if (args.ContainsKey("connectionString"))
         {
            // Configure the provider's connection string from the argument.
            _connectionString = args["connectionString"];
         }
         else
         {
            // Configure a default connection string.
            _connectionString = "Data Source=localhost;Initial Catalog=DemoDB;Trusted_Connection=yes";
         }
      }

      // Retrieve a SQL connection.
      private SqlConnection GetConnection()
      {
         // Create a new SQL connection using the provider's connection string.
         SqlConnection connection = new SqlConnection(_connectionString);
         // Open the SQL connection.
         connection.Open();
         // Return the connection to the 
         return connection;
      }

      // Authenticate a user.
      public override bool AuthenticateUser(string userName, string password)
      {
         // Open a SQL connection.
         using (SqlConnection connection = GetConnection())
         {
            // Create a command object.
            SqlCommand command = connection.CreateCommand();
            // Specify the SQL query to verify a username/password.
            command.CommandText = "SELECT Count(Username) FROM Authentication WHERE Enabled=1 and Username=@Username and Password=@Password";
            // Specify the username parameter.
            command.Parameters.Add(new SqlParameter("@Username", userName));
            // Specify the password parameter.
            command.Parameters.Add(new SqlParameter("@Password", password));
            // Retrieve the number of matching records.
            int rowCount = (int)command.ExecuteScalar();
            // Return whether the username/password are valid.
            return rowCount != 0;
         }
      }

      // Create a new user.
      public override ManagementUserInfo CreateUser(string userName, string password)
      {
         // Test whether the username already exists.
         if (GetUser(userName) != null)
         {
            // throw an exception if the user already exists.
            throw new InvalidOperationException("Username already exists");
         }

         // Open a SQL connection.
         using (SqlConnection connection = GetConnection())
         {
            // Create a command object.
            SqlCommand command = connection.CreateCommand();
            // Specify the SQL query to insert a username/password.
            command.CommandText = "INSERT INTO Authentication (Username, Password) Values(@Username, @Password)";
            // Specify the username parameter.
            command.Parameters.Add(new SqlParameter("@Username", userName));
            // Specify the password parameter.
            command.Parameters.Add(new SqlParameter("@Password", password));
            // Execute the SQL query.
            command.ExecuteNonQuery();
         }
         // Return whether the user was successfully created.
         return GetUser(userName);
      }

      // Delete a user.
      public override void DeleteUser(string userName)
      {
         // Open a SQL connection.
         using (SqlConnection connection = GetConnection())
         {
            // Create a command object.
            SqlCommand command = connection.CreateCommand();
            // Specify the SQL query to delete a user.
            command.CommandText = "DELETE FROM Authentication WHERE Username=@Username";
            // Specify the username parameter.
            command.Parameters.Add(new SqlParameter("@Username", userName));
            // Execute the SQL query.
            command.ExecuteNonQuery();
         }
      }

      // Disable a user.
      public override void DisableUser(string userName)
      {
         // Open a SQL connection.
         using (SqlConnection connection = GetConnection())
         {
            // Create a command object.
            SqlCommand command = connection.CreateCommand();
            // Specify the SQL query to disable the user.
            command.CommandText = "UPDATE Authentication SET Enabled=0 WHERE Username=@Username";
            // Specify the username parameter.
            command.Parameters.Add(new SqlParameter("@Username", userName));
            // Execute the SQL query.
            command.ExecuteNonQuery();
         }
      }

      // Enable a user.
      public override void EnableUser(string userName)
      {
         // Open a SQL connection.
         using (SqlConnection connection = GetConnection())
         {
            // Create a command object.
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE Authentication SET Enabled=1 WHERE Username=@Username";
            // Specify the username parameter.
            command.Parameters.Add(new SqlParameter("@Username", userName));
            // Execute the SQL query.
            command.ExecuteNonQuery();
         }
      }

      // Retrieve a specific username and status.
      public override ManagementUserInfo GetUser(string userName)
      {
         // Open a SQL connection.
         using (SqlConnection connection = GetConnection())
         {
            // Create a command object.
            SqlCommand command = connection.CreateCommand();
            // Specify the SQL query to retrieve a specific username and status.
            command.CommandText = "SELECT Username, Enabled FROM Authentication WHERE Username=@Username";
            // Specify the username parameter.
            command.Parameters.Add(new SqlParameter("@Username", userName));
            // Execute the SQL query and retrieve a SQL reader object.
            SqlDataReader reader = command.ExecuteReader();
            // Test if any data was retrieved.
            if (reader.HasRows)
            {
               // Retrieve a record from the database.
               reader.Read();
               // Retrieve the username.
               string username = reader.GetString(0);
               // Retrieve the status.
               bool enabled = reader.GetBoolean(1);
               // Close the SQL reader.
               reader.Close();
               // Return an IIS Manager user with the username/status.
               return new ManagementUserInfo(username, enabled);
            }
            else
            {
               // Return null if the username was not found.
               return null;
            }
         }
      }

      // Retrieve a collection of usernames and statuses.
      public override ManagementUserInfoCollection GetUsers(int itemIndex, int itemsPerPage)
      {
         // Open a SQL connection.
         using (SqlConnection connection = GetConnection())
         {
            // Create a command object.
            SqlCommand command = connection.CreateCommand();
            // Specify the SQL query to retrieve all usernames and statuses.
            command.CommandText = "SELECT Username, Enabled FROM Authentication";
            // Execute the SQL query and retrieve a SQL reader object.
            SqlDataReader reader = command.ExecuteReader();
            // Create a new collection of IIS Manager users.
            ManagementUserInfoCollection users = new ManagementUserInfoCollection();
            // Loop through the database records.
            while (reader.Read())
            {
               // Retrieve the username.
               string username = reader.GetString(0);
               // Retrieve the status.
               bool enabled = reader.GetBoolean(1);
               // Add a user object with the username/status to the collection.
               users.Add(new ManagementUserInfo(username, enabled));
            }
            // Return the collection.
            return users;
         }
      }

      // Test the password strength.
      public override InvalidPasswordReason IsPasswordStrongEnough(string password)
      {
         // NOTE: You could implement a custom password strength algorithm here.
         return InvalidPasswordReason.NoError;
      }

      // Update the password for a specific username.
      public override void SetPassword(string userName, string newPassword)
      {
         // Open a SQL connection.
         using (SqlConnection connection = GetConnection())
         {
            // Create a command object.
            SqlCommand command = connection.CreateCommand();
            // Specify the SQL query to update the password for a specific username.
            command.CommandText = "UPDATE Authentication SET Password=@Password WHERE Username=@Username";
            // Specify the username parameter.
            command.Parameters.Add(new SqlParameter("@Username", userName));
            // Specify the password parameter.
            command.Parameters.Add(new SqlParameter("@Password", newPassword));
            // Execute the SQL query.
            command.ExecuteNonQuery();
         }
      }
   }
}