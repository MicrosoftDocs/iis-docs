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

      serverManager.CommitChanges()
   End Sub