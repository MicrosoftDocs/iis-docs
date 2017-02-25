public static bool AddVirtualDirectory(string siteName, string application, string virtualDirectoryPath, string physicalPath, string userName, string password)
    {
        try
        {
            if (string.IsNullOrEmpty(siteName))
                throw new ArgumentNullException("siteName", "AddVirtualDirectory: siteName is null or empty.");
            if (string.IsNullOrEmpty(application))
                throw new ArgumentNullException("application", "AddVirtualDirectory: application is null or empty.");
            if (string.IsNullOrEmpty(virtualDirectoryPath))
                throw new ArgumentNullException("virtualDirectoryPath", "AddVirtualDirectory: virtualDirectoryPath is null or empty.");
            if (string.IsNullOrEmpty(physicalPath))
                throw new ArgumentNullException("physicalPath", "AddVirtualDirectory: physicalPath is null or empty.");
            using (ServerManager mgr = new ServerManager())
            {
                Site site = mgr.Sites[siteName];
                if (site != null)
                {
                    Application app = site.Applications[application];
                    if (app != null)
                    {
                        VirtualDirectory vDir = app.VirtualDirectories[virtualDirectoryPath];
                        if (vDir != null)
                        {
                            throw new Exception("Virtual Directory: " + virtualDirectoryPath + " already exists.");
                        }
                        else
                        {
                            vDir = app.VirtualDirectories.CreateElement();
                            vDir.Path = virtualDirectoryPath;
                            vDir.PhysicalPath = physicalPath;
                            if (!string.IsNullOrEmpty(userName))
                            {
                                if (string.IsNullOrEmpty(password))
                                    throw new Exception("Invalid Virtual Directory User Account Password.");
                                else
                                {
                                    vDir.UserName = userName;
                                    vDir.Password = password;
                                }
                            }
                            app.VirtualDirectories.Add(vDir);
                        }
                        mgr.CommitChanges();
                        return true;
                    }
                    else
                        throw new Exception("Application: " + application + " does not exist.");
                }
                else
                    throw new Exception("Site: " + siteName + " does not exist.");
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
   }