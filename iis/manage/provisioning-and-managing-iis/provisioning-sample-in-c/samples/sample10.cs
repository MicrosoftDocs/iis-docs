public static bool CreateFtpSite(string applicationPoolName,string siteName, string domainName, string userName, string password,string contentPath, string ipAddress, string tcpPort, string hostHeader)
{
	try
	{
		//provision the application pool
		using (ServerManager mgr = new ServerManager())
		{
			ApplicationPool appPool = mgr.ApplicationPools[applicationPoolName];
			//per IIS7 team recommendation, we always create a new application pool
			//create new application pool
			if (appPool == null)
			{
				appPool = mgr.ApplicationPools.Add(applicationPoolName);
				//set the application pool attribute
				appPool.ProcessModel.IdentityType = ProcessModelIdentityType.SpecificUser;
				appPool.ProcessModel.UserName = domainName + "\\" + userName;
				appPool.ProcessModel.Password = password;
			}
			//if the appPool is null, we throw an exception. The appPool should be created or already exists.
			if (appPool == null)
				throw new Exception("Invalid Application Pool.");
			//if the site already exists, throw an exception
			if (mgr.Sites[siteName] != null)
				throw new Exception("Site already exists.");
			//create site
			Site newSite = mgr.Sites.CreateElement();                   
			newSite.Id = GenerateNewSiteID(mgr, siteName);
			newSite.SetAttributeValue("name", siteName);
			newSite.ServerAutoStart = true;
			mgr.Sites.Add(newSite);
			//create the default application for the site
			Application newApp = newSite.Applications.CreateElement();
			newApp.SetAttributeValue("path", "/"); //set to default root path
			newApp.SetAttributeValue("applicationPool", applicationPoolName);
			newSite.Applications.Add(newApp);
			//create the default virtual directory
			VirtualDirectory newVirtualDirectory = newApp.VirtualDirectories.CreateElement();
			newVirtualDirectory.SetAttributeValue("path", "/");
			newVirtualDirectory.SetAttributeValue("physicalPath", contentPath);
			newApp.VirtualDirectories.Add(newVirtualDirectory);
			//add the bindings 
			Binding binding = newSite.Bindings.CreateElement();
			binding.SetAttributeValue("protocol", "ftp");
			binding.SetAttributeValue("bindingInformation", ipAddress + ":" + tcpPort + ":" + hostHeader);
			newSite.Bindings.Add(binding);
			//commit the changes
			mgr.CommitChanges();
		}
	}
	catch (Exception ex)
	{
		throw new Exception(ex.Message, ex);
	}
	return true;
}