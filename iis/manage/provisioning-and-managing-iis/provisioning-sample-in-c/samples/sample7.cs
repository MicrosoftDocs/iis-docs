public static bool AddSiteBinding(string siteName, string ipAddress, string tcpPort, string hostHeader, string protocol)
{
    try
    {
        if (string.IsNullOrEmpty(siteName))
        {
            throw new ArgumentNullException("siteName", "AddSiteBinding: siteName is null or empty.");
        }
        //get the server manager instance
        using (ServerManager mgr = new ServerManager())
        {
            SiteCollection sites = mgr.Sites;
            Site site = mgr.Sites[siteName];
            if (site != null)
            {
                string bind = ipAddress + ":" + tcpPort + ":" + hostHeader;
                //check the binding exists or not
                foreach (Binding b in site.Bindings)
                {
                    if (b.Protocol == protocol && b.BindingInformation == bind)
                    {
                        throw new Exception("A binding with the same ip, port and host header already exists.");
                    }
                }
                Binding newBinding = site.Bindings.CreateElement();
                newBinding.Protocol = protocol;
                newBinding.BindingInformation = bind;
                site.Bindings.Add(newBinding);
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