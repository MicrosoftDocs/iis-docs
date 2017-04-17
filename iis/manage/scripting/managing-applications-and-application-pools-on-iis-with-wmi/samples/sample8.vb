Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")

' Retrieve the NewApp application.
Set oApp = oWebAdmin.Get("Application.SiteName='Default Web Site',Path='/NewApp'")
WScript.Echo "Application Web site and Path: '" & oApp.SiteName & oApp.Path & "'"
WScript.Echo "Old application pool: " & oApp.ApplicationPool
WScript.Echo
' Specify the new application pool name.
oApp.ApplicationPool = "NewAppPool"
' Save the change.
oApp.Put_
' Display the new application pool name.
WScript.Echo
WScript.Echo "New application pool: " & oApp.ApplicationPool