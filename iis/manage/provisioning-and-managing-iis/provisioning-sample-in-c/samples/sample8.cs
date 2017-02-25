public static bool AddApplication(string siteName, string applicationPath, string applicationPool, string virtualDirectoryPath, string physicalPath, string userName, string password)
    {
        try
        {
            if (string.IsNullOrEmpty(siteName))
                throw new ArgumentNullException("siteName", "AddApplication: siteName is null or empty.");
            if (string.IsNullOrEmpty(applicationPath))
                throw new ArgumentNullException("applicationPath", "AddApplication: application path is null or empty.");
            if (string.IsNullOrEmpty(physicalPath))
                throw new ArgumentNullException("PhysicalPath", "AddApplication: Invalid physical path.");
            if (string.IsNullOrEmpty(applicationPool))
                throw new ArgumentNullException("ApplicationPool", "AddApplication: application pool namespace is Nullable or empty.");
            using (ServerManager mgr = new ServerManager())
            {
                ApplicationPool appPool = mgr.ApplicationPools[applicationPool];
                if (appPool == null)
                    throw new Exception("Application Pool: " + applicationPool + " does not exist.");
                Site site = mgr.Sites[siteName];
                if (site != null)
                {
                    Application app = site.Applications[applicationPath];
                    if (app != null)
                        throw new Exception("Application: " + applicationPath + " already exists.");
                    else
                    {
                        app = site.Applications.CreateElement();
                        app.Path = applicationPath;
                        app.ApplicationPoolName = applicationPool;
                        VirtualDirectory vDir = app.VirtualDirectories.CreateElement();
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
                    site.Applications.Add(app);
                    mgr.CommitChanges();
                    return true;
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