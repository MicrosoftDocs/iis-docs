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

        Dim directoryBrowseElement As ConfigurationElement = ftpServerElement.GetChildElement("directoryBrowse")
        directoryBrowseElement("showFlags") = "StyleUnix, DisplayAvailableBytes"

        serverManager.CommitChanges()
    End Sub

End Module