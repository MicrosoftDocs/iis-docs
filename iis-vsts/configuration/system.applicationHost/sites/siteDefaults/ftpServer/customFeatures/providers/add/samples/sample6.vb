Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST")
Set siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults")
Set ftpServerElement = siteDefaultsElement.ChildElements.Item("ftpServer")

' Configure FTP sites to start automatically by default.
ftpServerElement.Properties.Item("serverAutoStart").Value = True

' Configure the default control channel time-out for 300 seconds.
Set connectionsElement = ftpServerElement.ChildElements.Item("connections")
   connectionsElement.Properties.Item("controlChannelTimeout").Value = 300

' Configure the default FTP security options.
Set securityElement = ftpServerElement.ChildElements.Item("security")
Set commandFilteringElement = securityElement.ChildElements.Item("commandFiltering")
Set commandFilteringCollection = commandFilteringElement.Collection
Set addElement = commandFilteringCollection.CreateNewElement("add")
   addElement.Properties.Item("command").Value = "SYST"
   addElement.Properties.Item("allowed").Value = False
   commandFilteringCollection.AddElement(addElement)
Set sslElement = securityElement.ChildElements.Item("ssl")
   sslElement.Properties.Item("controlChannelPolicy").Value = "SslAllow"
   sslElement.Properties.Item("dataChannelPolicy").Value = "SslAllow"
   sslElement.Properties.Item("serverCertHash").Value = "57686f6120447564652c2049495320526f636b73"
Set authenticationElement = securityElement.ChildElements.Item("authentication")
Set anonymousAuthenticationElement = authenticationElement.ChildElements.Item("anonymousAuthentication")
   anonymousAuthenticationElement.Properties.Item("enabled").Value = False
Set basicAuthenticationElement = authenticationElement.ChildElements.Item("basicAuthentication")
   basicAuthenticationElement.Properties.Item("enabled").Value = False
Set clientCertAuthenticationElement = authenticationElement.ChildElements.Item("clientCertAuthentication")
   clientCertAuthenticationElement.Properties.Item("enabled").Value = False
Set sslClientCertificatesElement = securityElement.ChildElements.Item("sslClientCertificates")
   sslClientCertificatesElement.Properties.Item("clientCertificatePolicy").Value = "CertIgnore"
Set customAuthenticationElement = authenticationElement.ChildElements.Item("customAuthentication")
Set providersCollection = customAuthenticationElement.ChildElements.Item("providers").Collection
Set addElement1 = providersCollection.CreateNewElement("add")
   addElement1.Properties.Item("name").Value = "FtpCustomAuthenticationModule"
   addElement1.Properties.Item("enabled").Value = False
   providersCollection.AddElement(addElement1)

' Configure a custom default banner message and local detailed error messages.
Set messagesElement = ftpServerElement.ChildElements.Item("messages")
   messagesElement.Properties.Item("bannerMessage").Value = "Welcome!"
   messagesElement.Properties.Item("allowLocalDetailedErrors").Value = True

' Configure the FTP service to keep partially-uploaded files by default.
Set fileHandlingElement = ftpServerElement.ChildElements.Item("fileHandling")
   fileHandlingElement.Properties.Item("keepPartialUploads").Value = False

' Configure the default external IP address of a firewall.
Set firewallSupportElement = ftpServerElement.ChildElements.Item("firewallSupport")
   firewallSupportElement.Properties.Item("externalIp4Address").Value = "169.254.10.10"

' Specify no user isolation by default.
Set userIsolationElement = ftpServerElement.ChildElements.Item("userIsolation")
   userIsolationElement.Properties.Item("mode").Value = "None"

' Configure UNIX-style directory listings by default and display the available drive space.
Set directoryBrowseElement = ftpServerElement.ChildElements.Item("directoryBrowse")
   directoryBrowseElement.Properties.Item("showFlags").Value = "StyleUnix, DisplayAvailableBytes"

' Enable logging by default with daily log file rollover.
Set logFileElement = ftpServerElement.ChildElements.Item("logFile")
   logFileElement.Properties.Item("period").Value = "Daily"
   logFileElement.Properties.Item("enabled").Value = True

adminManager.CommitChanges()