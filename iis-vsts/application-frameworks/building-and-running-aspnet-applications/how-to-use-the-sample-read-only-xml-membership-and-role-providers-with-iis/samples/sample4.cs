using System;
using System.Web.Security;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration.Provider;
using System.Web.Hosting;
using System.Xml;
using System.Security.Permissions;
using System.Web;

public class ReadOnlyXmlRoleProvider : RoleProvider
{
   private Dictionary<string, string[]> _UsersAndRoles =
   new Dictionary<string, string[]>(16,
   StringComparer.InvariantCultureIgnoreCase);

   private Dictionary<string, string[]> _RolesAndUsers =
      new Dictionary<string, string[]>(16,
      StringComparer.InvariantCultureIgnoreCase);

   private string _XmlFileName;

   // RoleProvider properties
   public override string ApplicationName
   {
      get { throw new NotSupportedException(); }
      set { throw new NotSupportedException(); }
   }

   // RoleProvider methods
   public override void Initialize(string name,
   NameValueCollection config)
   {
      // Verify that config isn't null
      if (config == null)
         throw new ArgumentNullException("config");
      // Assign the provider a default name if it doesn't have one
      if (String.IsNullOrEmpty(name))
         name = "ReadOnlyXmlRoleProvider";
      // Add a default "description" attribute to config if the
      // attribute doesn't exist or is empty
      if (string.IsNullOrEmpty(config["description"]))
      {
         config.Remove("description");
         config.Add("description", "Read-only XML role provider");
      }
      // Call the base class's Initialize method
      base.Initialize(name, config);
      // Initialize _XmlFileName and make sure the path
      // is app-relative
      string path = config["xmlFileName"];
      if (String.IsNullOrEmpty(path))
         path = "~/App_Data/Users.xml";
      if (!VirtualPathUtility.IsAppRelative(path))
         throw new ArgumentException
            ("xmlFileName must be app-relative");
      string fullyQualifiedPath = VirtualPathUtility.Combine
         (VirtualPathUtility.AppendTrailingSlash
         (HttpRuntime.AppDomainAppVirtualPath), path);
      _XmlFileName = HostingEnvironment.MapPath(fullyQualifiedPath);
      config.Remove("xmlFileName");
      // Make sure we have permission to read the XML data source and
      // throw an exception if we don't
      FileIOPermission permission =
         new FileIOPermission(FileIOPermissionAccess.Read,
            _XmlFileName);
      permission.Demand();
      // Throw an exception if unrecognized attributes remain
      if (config.Count > 0)
      {
         string attr = config.GetKey(0);
         if (!String.IsNullOrEmpty(attr))
            throw new ProviderException
               ("Unrecognized attribute: " + attr);
      }
      // Read the role data source. NOTE: Unlike
      // ReadOnlyXmlMembershipProvider, this provider can
      // read the data source at this point because Read-
      // RoleDataStore doesn't call into the role manager
      ReadRoleDataStore();
   }

   public override bool IsUserInRole(string username, string roleName)
   {
      // Validate input parameters
      if (username == null || roleName == null)
         throw new ArgumentNullException();
      if (username == String.Empty || roleName == string.Empty)
         throw new ArgumentException();
      // Make sure the user name and role name are valid
      if (!_UsersAndRoles.ContainsKey(username))
         throw new ProviderException("Invalid user name");
      if (!_RolesAndUsers.ContainsKey(roleName))
         throw new ProviderException("Invalid role name");
      // Determine whether the user is in the specified role 
      string[] roles = _UsersAndRoles[username];
      foreach (string role in roles)
      {
         if (String.Compare(role, roleName, true) == 0)
            return true;
      }
      return false;
   }

   public override string[] GetRolesForUser(string username)
   {
      // Validate input parameters
      if (username == null)
         throw new ArgumentNullException();
      if (username == string.Empty)
         throw new ArgumentException();
      // Make sure the user name is valid
      string[] roles;
      if (!_UsersAndRoles.TryGetValue(username, out roles))
         throw new ProviderException("Invalid user name");
      // Return role names
      return roles;
   }

   public override string[] GetUsersInRole(string roleName)
   {
      // Validate input parameters
      if (roleName == null)
         throw new ArgumentNullException();
      if (roleName == string.Empty)
      throw new ArgumentException();
      // Make sure the role name is valid
      string[] users;
      if (!_RolesAndUsers.TryGetValue(roleName, out users))
         throw new ProviderException("Invalid role name");
      // Return user names
      return users;
   }

   public override string[] GetAllRoles()
   {
      int i = 0;
      string[] roles = new string[_RolesAndUsers.Count];
      foreach (KeyValuePair<string, string[]> pair in _RolesAndUsers)
         roles[i++] = pair.Key;
      return roles;
   }

   public override bool RoleExists(string roleName)
   {
      // Validate input parameters
      if (roleName == null)
         throw new ArgumentNullException();
      if (roleName == string.Empty)
         throw new ArgumentException();
      // Determine whether the role exists
      return _RolesAndUsers.ContainsKey(roleName);
   }

   public override void CreateRole(string roleName)
   {
      throw new NotSupportedException();
   }

   public override bool DeleteRole(string roleName,
      bool throwOnPopulatedRole)
   {
      throw new NotSupportedException();
   }

   public override void AddUsersToRoles(string[] usernames,
      string[] roleNames)
   {
      throw new NotSupportedException();
   }

   public override string[] FindUsersInRole(string roleName,
      string usernameToMatch)
   {
      throw new NotSupportedException();
   }

   public override void RemoveUsersFromRoles(string[] usernames,
      string[] roleNames)
   {
      throw new NotSupportedException();
   }

   // Helper method
   private void ReadRoleDataStore()
   {
      XmlDocument doc = new XmlDocument();
      doc.Load(_XmlFileName);
      XmlNodeList nodes = doc.GetElementsByTagName("User");
      foreach (XmlNode node in nodes)
      {
         if (node["UserName"] == null)
            throw new ProviderException
               ("Missing UserName element");
         string user = node["UserName"].InnerText;
         if (String.IsNullOrEmpty(user))
            throw new ProviderException("Empty UserName element");
         if (node["Roles"] == null ||
            String.IsNullOrEmpty(node["Roles"].InnerText))
               _UsersAndRoles.Add(user, new string[0]);
         else
         {
            string[] roles = node["Roles"].InnerText.Split(',');
            // Add the role names to _UsersAndRoles and
            // key them by user name
            _UsersAndRoles.Add(user, roles);
            foreach (string role in roles)
            {
               // Add the user name to _RolesAndUsers and
               // key it by role names
               string[] users1;
               if (_RolesAndUsers.TryGetValue(role, out users1))
               {
                  string[] users2 =
                     new string[users1.Length + 1];
                  users1.CopyTo(users2, 0);
                  users2[users1.Length] = user;
                  _RolesAndUsers.Remove(role);
                  _RolesAndUsers.Add(role, users2);
               }
               else
                  _RolesAndUsers.Add(role,
               new string[] { user });
            }
         }
      }
   }
}