Set oIIS = GetObject("winmgmts:root\WebAdministration")
Set oSite = oIIS.Get("Site.Name='NewSite'")
oSite.Delete_