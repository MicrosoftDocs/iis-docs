Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set aspSection = adminManager.GetAdminSection("system.webServer/asp", "MACHINE/WEBROOT/APPHOST/Default Web Site")
Set comPlusElement = aspSection.ChildElements.Item("comPlus")
comPlusElement.Properties.Item("trackThreadingModel").Value = True
comPlusElement.Properties.Item("executeInMta").Value = True

adminManager.CommitChanges()