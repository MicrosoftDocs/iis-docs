public static bool CreateLocalUserAccount(string userName, string password)
{
   try
   {
      if (string.IsNullOrEmpty(userName))
        throw new ArgumentNullException("userName", "Invalid User Name.");
      if (string.IsNullOrEmpty(password))
        throw new ArgumentNullException("password", "Invalid Password.");
      DirectoryEntry directoryEntry = new DirectoryEntry("WinNT://" +
      Environment.MachineName + ",computer");
      bool userFound = false;
      try
      {
         if (directoryEntry.Children.Find(userName, "user") != null)
           userFound = true;
      }
      catch
      {
         userFound = false;
      }
      if (!userFound)
      {
         DirectoryEntry newUser = directoryEntry.Children.Add(userName, "user");
         newUser.Invoke("SetPassword", new object[] { password });
         newUser.Invoke("Put", new object[] { "Description", "Application Pool User Account" });
         newUser.CommitChanges();
         newUser.Close();
      }
   }
   catch (Exception ex)
   {
        throw new Exception(ex.Message, ex);
   }
   return true;
}