Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST")
Set siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults")
Set ftpServerElement = siteDefaultsElement.ChildElements.Item("ftpServer")

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

adminManager.CommitChanges()