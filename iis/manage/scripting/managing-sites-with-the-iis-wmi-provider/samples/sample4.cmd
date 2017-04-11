Set oIIS = GetObject("winmgmts:root\WebAdministration")
Set oSite = oIIS.Get("Site.Name='Default Web Site'")            
WScript.Echo "Retrieved an instance of Site " 
WScript.Echo "        Name: " & oSite.Name 
WScript.Echo "        ID:   " & oSite.ID