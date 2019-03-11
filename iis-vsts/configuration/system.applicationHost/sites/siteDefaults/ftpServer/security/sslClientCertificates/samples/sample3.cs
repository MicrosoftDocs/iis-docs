using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample
{
   private static void Main()
   {
      using (ServerManager serverManager = new ServerManager())
      {
         Configuration config = serverManager.GetApplicationHostConfiguration();
         ConfigurationSection sitesSection = config.GetSection("system.applicationHost/sites");
         ConfigurationElement siteDefaultsElement = sitesSection.GetChildElement("siteDefaults");
         ConfigurationElement ftpServerElement = siteDefaultsElement.GetChildElement("ftpServer");

         ConfigurationElement securityElement = ftpServerElement.GetChildElement("security");
         ConfigurationElement sslElement = securityElement.GetChildElement("ssl");
            sslElement["controlChannelPolicy"] = @"SslAllow";
            sslElement["dataChannelPolicy"] = @"SslAllow";
            sslElement["serverCertHash"] = "57686f6120447564652c2049495320526f636b73";
         
         ConfigurationElement sslClientCertificatesElement = securityElement.GetChildElement("sslClientCertificates");
            sslClientCertificatesElement["clientCertificatePolicy"] = @"CertRequire";
            sslClientCertificatesElement["useActiveDirectoryMapping"] = false;

         serverManager.CommitChanges();
      }
   }
}