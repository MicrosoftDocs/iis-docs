Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Class Sample
   Shared Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim applicationPoolsSection As ConfigurationSection = config.GetSection("system.applicationHost/applicationPools")
      Dim applicationPoolDefaultsElement As ConfigurationElement = applicationPoolsSection.GetChildElement("applicationPoolDefaults")
      applicationPoolDefaultsElement("autoStart") = True
      applicationPoolDefaultsElement("managedRuntimeVersion") = "v2.0"
      applicationPoolDefaultsElement("managedPipelineMode") = "Integrated"
      serverManager.CommitChanges()
   End Sub
End Class