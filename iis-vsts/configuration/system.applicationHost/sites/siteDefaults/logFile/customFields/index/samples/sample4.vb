Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

    Sub Main()
        Dim serverManager As ServerManager = New ServerManager
        Dim config As Configuration =       serverManager.GetApplicationHostConfiguration
        Dim sitesSection As ConfigurationSection =  config.GetSection("system.applicationHost/sites")
        Dim siteDefaultsElement As ConfigurationElement =  sitesSection.GetChildElement("siteDefaults")
        Dim logFileElement As ConfigurationElement =  siteDefaultsElement.GetChildElement("logFile")
        Dim customFieldsElement As ConfigurationElement =  logFileElement.GetChildElement("customFields")
        Dim customFieldsCollection As ConfigurationElementCollection =  customFieldsElement.GetCollection
        Dim addElement As ConfigurationElement =  customFieldsCollection.CreateElement("add")
        addElement("logFieldName") = "ContosoField"
        addElement("sourceName") = "ContosoSource"
        addElement("sourceType") = "ServerVariable"
        customFieldsCollection.Add(addElement)
        serverManager.CommitChanges
    End Sub
End Module