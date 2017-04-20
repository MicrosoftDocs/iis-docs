Set oIIS = GetObject("winmgmts:root\WebAdministration") 
Set oApp = oIIS.Get("Application.SiteName='Default Web Site',Path='/'")
WScript.Echo "Successfully retrieved: '" & oApp.SiteName & oApp.Path & "'"