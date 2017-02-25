Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")
' Retrieve the default Web site.
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")
' Specify the new default application pool name.
oSite.ApplicationDefaults.ApplicationPool = "NewAppPool"
' Save the change.
oSite.Put_