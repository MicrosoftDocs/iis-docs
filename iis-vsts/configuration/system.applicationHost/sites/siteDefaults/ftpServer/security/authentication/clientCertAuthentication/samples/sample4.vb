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
        Dim sslElement As ConfigurationElement = securityElement.GetChildElement("ssl")
        sslElement("controlChannelPolicy") = "SslAllow"
        sslElement("dataChannelPolicy") = "SslAllow"
        sslElement("serverCertHash") = "57686f6120447564652c2049495320526f636b73"

        Dim authenticationElement As ConfigurationElement = securityElement.GetChildElement("authentication")
        Dim clientCertAuthenticationElement As ConfigurationElement = authenticationElement.GetChildElement("clientCertAuthentication")
        clientCertAuthenticationElement("enabled") = True

        Dim sslClientCertificatesElement As ConfigurationElement = securityElement.GetChildElement("sslClientCertificates")
        sslClientCertificatesElement("clientCertificatePolicy") = "CertIgnore"
        sslClientCertificatesElement("useActiveDirectoryMapping") = True

        serverManager.CommitChanges()
    End Sub

End Module