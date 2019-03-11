public static bool CreateWebSite(string siteName)
{
   try
   {
     if (string.IsNullOrEmpty(siteName))
     {
        throw new ArgumentNullException("siteName", "CreateWebSite: siteName is null or empty.");
     }
     //get the server manager instance
     using (ServerManager mgr = new ServerManager())
     {
        Site newSite = mgr.Sites.CreateElement();
        //get site id
        newSite.Id = GenerateNewSiteID(mgr, siteName);
        newSite.SetAttributeValue("name", siteName);
        mgr.Sites.Add(newSite);
        mgr.CommitChanges();
     }
   }
   catch (Exception ex)
   {
      throw new Exception(ex.Message, ex);
   }
   return true;
}