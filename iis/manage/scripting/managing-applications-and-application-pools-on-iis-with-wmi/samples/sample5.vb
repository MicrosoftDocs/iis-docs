Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")
oWebAdmin.Get("ApplicationPool").Create("NewAppPool")
oWebAdmin.Get("ApplicationPool").Create("OneMoreAppPool")