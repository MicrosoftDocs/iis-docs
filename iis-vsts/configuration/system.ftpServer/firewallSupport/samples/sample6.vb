Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set firewallSupportSection = adminManager.GetAdminSection("system.ftpServer/firewallSupport", "MACHINE/WEBROOT/APPHOST")
firewallSupportSection.Properties.Item("lowDataChannelPort").Value = 5000
firewallSupportSection.Properties.Item("highDataChannelPort").Value = 6000

adminManager.CommitChanges()