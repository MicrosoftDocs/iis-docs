Imports System
Imports System.Text
Imports Microsoft.Web.Administration


Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim ipSecuritySection As ConfigurationSection = config.GetSection("system.ftpServer/security/ipSecurity", "Default Web Site")
      Dim ipSecurityCollection As ConfigurationElementCollection = ipSecuritySection.GetCollection

      ipSecuritySection("allowUnlisted") = True

      Dim addElement As ConfigurationElement = ipSecurityCollection.CreateElement("add")
      addElement("ipAddress") = "127.0.0.1"
      addElement("allowed") = True
      ipSecurityCollection.Add(addElement)

      Dim addElement1 As ConfigurationElement = ipSecurityCollection.CreateElement("add")
      addElement1("ipAddress") = "169.254.0.0"
      addElement1("subnetMask") = "255.255.0.0"
      ipSecurityCollection.Add(addElement1)

      serverManager.CommitChanges()
   End Sub
End Module