Dim adminManager, section
Set adminManager = WScript.Createobject("Microsoft.ApplicationHost.AdminManager")
Set section = adminManager.GetAdminSection("system.webServer/simpleLogging", "MACHINE/WEBROOT/APPHOST/Default Web Site")
WScript.Echo(section.Properties.Item("logfileCount").Value)
section.Methods.Item("deleteLogs").CreateInstance().Execute()
WScript.Echo(section.Properties.Item("logfileCount").Value)