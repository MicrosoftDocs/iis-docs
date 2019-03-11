public static bool AddDirectorySecurity(string directoryPath, string userAccount, FileSystemRights rights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType controlType)
{
   try
   {
       // Create a new DirectoryInfo object.
       DirectoryInfo dInfo = new DirectoryInfo(directoryPath);
       // Get a DirectorySecurity object that represents the 
       // current security settings.
       DirectorySecurity dSecurity = dInfo.GetAccessControl();
       // Add the FileSystemAccessRule to the security settings. 
       dSecurity.AddAccessRule(new FileSystemAccessRule(userAccount, rights, inheritanceFlags, propagationFlags, controlType));
       // Set the new access settings.
       dInfo.SetAccessControl(dSecurity);
   }
   catch (Exception ex)
   {
       throw new Exception(ex.Message, ex);
   }
   return true;
}