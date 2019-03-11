Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set serverSideIncludeSection = adminManager.GetAdminSection("system.webServer/serverSideInclude", "MACHINE/WEBROOT/APPHOST/Default Web Site")
serverSideIncludeSection.Properties.Item("ssiExecDisable").Value = True

adminManager.CommitChanges()