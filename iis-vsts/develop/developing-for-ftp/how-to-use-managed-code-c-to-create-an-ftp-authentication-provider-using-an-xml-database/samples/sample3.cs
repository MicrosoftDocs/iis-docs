using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using Microsoft.Web.FtpServer;
using System.Xml.XPath;

// Define the XML authentication provider class.
public class FtpXmlAuthentication :
  BaseProvider,
  IFtpAuthenticationProvider,
  IFtpRoleProvider
{
  // Create a string to store the path to the XML file that stores the user data.
  private static string _xmlFileName;

  // Create a file system watcher object for change notifications.
  private static FileSystemWatcher _xmlFileWatch;

  // Create a dictionary to hold user data.
  private static Dictionary<string, XmlUserData> _XmlUserData =
    new Dictionary<string, XmlUserData>(
      StringComparer.InvariantCultureIgnoreCase);

  // Override the Initialize method to retrieve the configuration settings.
  protected override void Initialize(StringDictionary config)
  {
    // Retrieve the path to the XML file.
    _xmlFileName = config["xmlFileName"];

    // Test if the path is empty.
    if (string.IsNullOrEmpty(_xmlFileName))
    {
      // Throw an exception if the path is missing or empty.
      throw new ArgumentException("Missing xmlFileName value in configuration.");
    }

    // Test if the file exists.
    if (File.Exists(_xmlFileName) == false)
    {
      // Throw an exception if the file does not exist.
      throw new ArgumentException("The specified XML file does not exist.");
    }

    try
    {
      // Create a file system watcher object for the XML file.
      _xmlFileWatch = new FileSystemWatcher();
      // Specify the folder that contains the XML file to watch.
      _xmlFileWatch.Path = _xmlFileName.Substring(0, _xmlFileName.LastIndexOf(@"\"));
      // Filter events based on the XML file name.
      _xmlFileWatch.Filter = _xmlFileName.Substring(_xmlFileName.LastIndexOf(@"\") + 1);
      // Filter change notifications based on last write time and file size.
      _xmlFileWatch.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.Size;
      // Add the event handler.
      _xmlFileWatch.Changed += new FileSystemEventHandler(this.XmlFileChanged);
      // Enable change notification events.
      _xmlFileWatch.EnableRaisingEvents = true;
    }
    catch (Exception ex)
    {
      // Raise an exception if an error occurs.
      throw new ProviderException(ex.Message);
    }
   }

  // Define the event handler for changes to the XML file.
  public void XmlFileChanged(object sender, FileSystemEventArgs e)
  {
    // Verify that the changed file is the XML data file.
    if (e.Name.Equals(
      _xmlFileName.Substring(_xmlFileName.LastIndexOf(@"\") + 1),
      StringComparison.OrdinalIgnoreCase))
    {
      // Clear the contents of the existing user dictionary.
      _XmlUserData.Clear();
      // Repopulate the user dictionary.
      ReadXmlDataStore();
    }
  }

  // Define the AuthenticateUser method.
  bool IFtpAuthenticationProvider.AuthenticateUser(
         string sessionId,
         string siteName,
         string userName,
         string userPassword,
         out string canonicalUserName)
  {
    // Define the canonical user name.
    canonicalUserName = userName;

    // Validate that the user name and password are not empty.
    if (String.IsNullOrEmpty(userName) || String.IsNullOrEmpty(userPassword))
    {
      // Return false (authentication failed) if either are empty.
      return false;
    }
    else
    {
      try
      {
        // Retrieve the user/role data from the XML file.
        ReadXmlDataStore();
        // Create a user object.
        XmlUserData user;
        // Test if the user name is in the dictionary of users.
        if (_XmlUserData.TryGetValue(userName, out user))
        {
          // Perform a case-sensitive comparison on the password.
          if (String.Compare(user.Password, userPassword, false) == 0)
          {
            // Return true (authentication succeeded) if the passwords match.
            return true;
          }
        }
      }
      catch (Exception ex)
      {
        // Raise an exception if an error occurs.
        throw new ProviderException(ex.Message);
      }
    }
    // Return false (authentication failed) if authentication fails to this point.
    return false;
  }

  bool IFtpRoleProvider.IsUserInRole(
       string sessionId,
       string siteName,
       string userName,
       string userRole)
  {
    // Validate that the user and role names are not empty.
    if (String.IsNullOrEmpty(userName) || String.IsNullOrEmpty(userRole))
    {
      // Return false (role lookup failed) if either are empty.
      return false;
    }
    else
    {
      try
      {
        // Retrieve the user/role data from the XML file.
        ReadXmlDataStore();
        // Create a user object.
        XmlUserData user;
        // Test if the user name is in the dictionary of users.
        if (_XmlUserData.TryGetValue(userName, out user))
        {
          // Loop through the user's roles.
          foreach (string role in user.Roles)
          {
            // Perform a case-insensitive comparison on the role name.
            if (String.Compare(role, userRole, true) == 0)
            {
              // Return true (role lookup succeeded) if the role names match.
              return true;
            }
          }
        }
      }
      catch (Exception ex)
      {
        // Raise an exception if an error occurs.
        throw new ProviderException(ex.Message);
      }
    }
    // Return false (role lookup failed) if role lookup fails to this point.
    return false;
  }

  // Retrieve the user/role data from the XML file.
  private void ReadXmlDataStore()
  {
    // Lock the provider while the data is retrieved.
    lock (this)
    {
      try
      {
        // Test if the dictionary already has data.
        if (_XmlUserData.Count == 0)
        {
          // Create an XML document object and load the data XML file
          XPathDocument xmlDocument = new XPathDocument(_xmlFileName);
          // Create a navigator object to navigate through the XML file.
          XPathNavigator xmlNavigator = xmlDocument.CreateNavigator();
          // Loop through the users in the XML file.
          foreach (XPathNavigator node in xmlNavigator.Select("/Users/User"))
          {
            // Retrieve a user name.
            string userName = GetInnerText(node, "UserName");
            // Retrieve the user's password.
            string password = GetInnerText(node, "Password");
            // Test if the data is empty.
            if ((String.IsNullOrEmpty(userName) == false) && (String.IsNullOrEmpty(password) == false))
            {
              // Retrieve the user's roles.
              string xmlRoles = GetInnerText(node, "Roles");
              // Create a string array for the user roles.
              string[] userRoles = new string[0];
              // Test if the user has any roles defined.
              if (String.IsNullOrEmpty(xmlRoles) == false)
              {
                // Split the roles by comma.
                userRoles = xmlRoles.Split(',');
              }
              // Create a user data class.
              XmlUserData userData = new XmlUserData(password, userRoles);
              // Store the user data in the dictionary.
              _XmlUserData.Add(userName, userData);
            }
          }
        }
      }
      catch (Exception ex)
      {
        // Raise an exception if an error occurs.
        throw new ProviderException(ex.Message);
      }
    }
  }

  // Retrieve data from an XML element.
  private static string GetInnerText(XPathNavigator xmlNode, string xmlElement)
  {
    string xmlText = "";
    try
    {
      // Test if the XML element exists.
      if (xmlNode.SelectSingleNode(xmlElement) != null)
      {
        // Retrieve the text in the XML element.
        xmlText = xmlNode.SelectSingleNode(xmlElement).Value.ToString();
      }
    }
    catch (Exception ex)
    {
      // Raise an exception if an error occurs.
      throw new ProviderException(ex.Message);
    }
    // Return the element text.
    return xmlText;
  }  
}

// Define the user data class.
internal class XmlUserData
{
  // Create a private string to hold a user's password.
  private string _password = "";
  // Create a private string array to hold a user's roles.
  private string[] _roles = new string[0];

  // Define the class constructor  requiring a user's password and roles array.
  public XmlUserData(string Password,string[] Roles)
  {
    this.Password = Password;
    this.Roles = Roles;
  }

  // Define the password property.
  public string Password
  {
    get { return _password; }
    set
    {
      try { _password = value; }
      catch (Exception ex)
      {
        throw new ProviderException(ex.Message);
      }
    }
  }

  // Define the roles property.
  public string[] Roles
  {
    get { return _roles; }
    set {
      try { _roles = value; }
      catch (Exception ex)
      {
        throw new ProviderException(ex.Message);
      }
    }
  }
}