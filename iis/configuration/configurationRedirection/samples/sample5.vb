Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/REDIRECTION"

Set configurationRedirection = adminManager.GetAdminSection( "configurationRedirection", _
"MACHINE/REDIRECTION" )

configurationRedirection.Properties.Item( "enabled" ).Value = True
configurationRedirection.Properties.Item( "path" ).Value = "\\SeverName\ShareName"
configurationRedirection.Properties.Item( "userName" ).Value = "MyUser"
configurationRedirection.Properties.Item( "password" ).Value = "P@ssw0rd"

adminManager.CommitChanges