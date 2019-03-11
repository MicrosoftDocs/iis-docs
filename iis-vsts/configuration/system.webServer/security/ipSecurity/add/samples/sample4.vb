Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim ipSecuritySection As ConfigurationSection = config.GetSection("system.webServer/security/ipSecurity", "Default Web Site")
      Dim ipSecurityCollection As ConfigurationElementCollection = ipSecuritySection.GetCollection

      Dim addElement As ConfigurationElement = ipSecurityCollection.CreateElement("add")
      addElement("ipAddress") = "192.168.100.1"
      addElement("allowed") = False
      ipSecurityCollection.Add(addElement)

      Dim addElement1 As ConfigurationElement = ipSecurityCollection.CreateElement("add")
      addElement1("ipAddress") = "169.254.0.0"
      addElement1("subnetMask") = "255.255.0.0"
      addElement1("allowed") = False
      ipSecurityCollection.Add(addElement1)

      serverManager.CommitChanges()
   End Sub

End Module