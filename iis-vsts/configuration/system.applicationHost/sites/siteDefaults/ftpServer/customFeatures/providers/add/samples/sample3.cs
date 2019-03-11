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

         // Configure FTP sites to start automatically by default.
         ftpServerElement["serverAutoStart"] = true;

         // Configure the default control channel time-out for 300 seconds.
         ConfigurationElement connectionsElement = ftpServerElement.GetChildElement("connections");
            connectionsElement["controlChannelTimeout"] = 300;

         // Configure the default FTP security options.
         ConfigurationElement securityElement = ftpServerElement.GetChildElement("security");
         ConfigurationElement commandFilteringElement = securityElement.GetChildElement("commandFiltering");
         ConfigurationElementCollection commandFilteringCollection = commandFilteringElement.GetCollection();
         ConfigurationElement addElement = commandFilteringCollection.CreateElement("add");
            addElement["command"] = @"SYST";
            addElement["allowed"] = false;
            commandFilteringCollection.Add(addElement);
         ConfigurationElement sslElement = securityElement.GetChildElement("ssl");
            sslElement["controlChannelPolicy"] = @"SslAllow";
            sslElement["dataChannelPolicy"] = @"SslAllow";
            sslElement["serverCertHash"] = "57686f6120447564652c2049495320526f636b73";
         ConfigurationElement authenticationElement = securityElement.GetChildElement("authentication");
         ConfigurationElement anonymousAuthenticationElement = authenticationElement.GetChildElement("anonymousAuthentication");
            anonymousAuthenticationElement["enabled"] = false;
         ConfigurationElement basicAuthenticationElement = authenticationElement.GetChildElement("basicAuthentication");
            basicAuthenticationElement["enabled"] = false;
         ConfigurationElement clientCertAuthenticationElement = authenticationElement.GetChildElement("clientCertAuthentication");
            clientCertAuthenticationElement["enabled"] = false;
         ConfigurationElement sslClientCertificatesElement = securityElement.GetChildElement("sslClientCertificates");
            sslClientCertificatesElement["clientCertificatePolicy"] = @"CertIgnore";
         ConfigurationElement customAuthenticationElement = authenticationElement.GetChildElement("customAuthentication");
         ConfigurationElementCollection providersCollection = customAuthenticationElement.GetCollection("providers");
         ConfigurationElement addElement1 = providersCollection.CreateElement("add");
            addElement1["name"] = @"FtpCustomAuthenticationModule";
            addElement1["enabled"] = false;
            providersCollection.Add(addElement1);

         // Configure a custom default banner message and local detailed error messages.
         ConfigurationElement messagesElement = ftpServerElement.GetChildElement("messages");
            messagesElement["bannerMessage"] = @"Welcome!";
            messagesElement["allowLocalDetailedErrors"] = true;

         // Configure the FTP service to keep partially-uploaded files by default.
         ConfigurationElement fileHandlingElement = ftpServerElement.GetChildElement("fileHandling");
           fileHandlingElement["keepPartialUploads"] = false;

         // Configure the default external IP address of a firewall.
         ConfigurationElement firewallSupportElement = ftpServerElement.GetChildElement("firewallSupport");
            firewallSupportElement["externalIp4Address"] = @"169.254.10.10";

         // Specify no user isolation by default.
         ConfigurationElement userIsolationElement = ftpServerElement.GetChildElement("userIsolation");
            userIsolationElement["mode"] = @"None";

         // Configure UNIX-style directory listings by default and display the available drive space.
         ConfigurationElement directoryBrowseElement = ftpServerElement.GetChildElement("directoryBrowse");
            directoryBrowseElement["showFlags"] = @"StyleUnix, DisplayAvailableBytes";

         // Enable logging by default with daily log file rollover.
         ConfigurationElement logFileElement = ftpServerElement.GetChildElement("logFile");
            logFileElement["period"] = @"Daily";
            logFileElement["enabled"] = true;

         serverManager.CommitChanges();
      }
   }
}