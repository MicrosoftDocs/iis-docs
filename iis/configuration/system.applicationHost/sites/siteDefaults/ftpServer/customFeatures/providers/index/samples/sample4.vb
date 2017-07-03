Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim sitesSection As ConfigurationSection = config.GetSection("system.applicationHost/sites")
      Dim siteDefaultsElement As ConfigurationElement = sitesSection.GetChildElement("siteDefaults")
      Dim ftpServerElement As ConfigurationElement = siteDefaultsElement.GetChildElement("ftpServer")

      ' Configure FTP sites to start automatically by default.
      ftpServerElement("serverAutoStart") = True

      ' Configure the default control channel time-out for 300 seconds.
      Dim connectionsElement As ConfigurationElement = ftpServerElement.GetChildElement("connections")
         connectionsElement("controlChannelTimeout") = 300

      ' Configure the default FTP security options.
      Dim securityElement As ConfigurationElement = ftpServerElement.GetChildElement("security")
      Dim commandFilteringElement As ConfigurationElement = securityElement.GetChildElement("commandFiltering")
      Dim commandFilteringCollection As ConfigurationElementCollection = commandFilteringElement.GetCollection
      Dim addElement As ConfigurationElement = commandFilteringCollection.CreateElement("add")
         addElement("command") = "SYST"
         addElement("allowed") = False
         commandFilteringCollection.Add(addElement)
      Dim sslElement As ConfigurationElement = securityElement.GetChildElement("ssl")
         sslElement("controlChannelPolicy") = "SslAllow"
         sslElement("dataChannelPolicy") = "SslAllow"
         sslElement("serverCertHash") = "57686f6120447564652c2049495320526f636b73"
      Dim authenticationElement As ConfigurationElement = securityElement.GetChildElement("authentication")
      Dim anonymousAuthenticationElement As ConfigurationElement = authenticationElement.GetChildElement("anonymousAuthentication")
         anonymousAuthenticationElement("enabled") = False
      Dim basicAuthenticationElement As ConfigurationElement = authenticationElement.GetChildElement("basicAuthentication")
         basicAuthenticationElement("enabled") = False
      Dim clientCertAuthenticationElement As ConfigurationElement = authenticationElement.GetChildElement("clientCertAuthentication")
         clientCertAuthenticationElement("enabled") = False
      Dim sslClientCertificatesElement As ConfigurationElement = securityElement.GetChildElement("sslClientCertificates")
         sslClientCertificatesElement("clientCertificatePolicy") = "CertIgnore"
      Dim customAuthenticationElement As ConfigurationElement = authenticationElement.GetChildElement("customAuthentication")
      Dim providersCollection As ConfigurationElementCollection = customAuthenticationElement.GetCollection("providers")
      Dim addElement1 As ConfigurationElement = providersCollection.CreateElement("add")
         addElement1("name") = "FtpCustomAuthenticationModule"
         addElement1("enabled") = False
         providersCollection.Add(addElement1)

      ' Configure a custom default banner message and local detailed error messages.
      Dim messagesElement As ConfigurationElement = ftpServerElement.GetChildElement("messages")
         messagesElement("bannerMessage") = "Welcome!"
         messagesElement("allowLocalDetailedErrors") = True

      ' Configure the FTP service to keep partially-uploaded files by default.
      Dim fileHandlingElement As ConfigurationElement = ftpServerElement.GetChildElement("fileHandling")
         fileHandlingElement("keepPartialUploads") = False

      ' Configure the default external IP address of a firewall.
      Dim firewallSupportElement As ConfigurationElement = ftpServerElement.GetChildElement("firewallSupport")
         firewallSupportElement("externalIp4Address") = "169.254.10.10"

      ' Specify no user isolation by default.
      Dim userIsolationElement As ConfigurationElement = ftpServerElement.GetChildElement("userIsolation")
         userIsolationElement("mode") = "None"

      ' Configure UNIX-style directory listings by default and display the available drive space.
      Dim directoryBrowseElement As ConfigurationElement = ftpServerElement.GetChildElement("directoryBrowse")
         directoryBrowseElement("showFlags") = "StyleUnix, DisplayAvailableBytes"

      ' Enable logging by default with daily log file rollover.
      Dim logFileElement As ConfigurationElement = ftpServerElement.GetChildElement("logFile")
         logFileElement("period") = "Daily"
         logFileElement("enabled") = True

      serverManager.CommitChanges()
   End Sub

End Module