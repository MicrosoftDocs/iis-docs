Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration

      Dim firewallSupportSection As ConfigurationSection = config.GetSection("system.ftpServer/firewallSupport")
      firewallSupportSection("lowDataChannelPort") = 5000
      firewallSupportSection("highDataChannelPort") = 6000

      serverManager.CommitChanges()
   End Sub
End Module