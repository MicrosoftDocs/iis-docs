' Connect to the WMI WebAdministration namespace.
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")
' Specify the application pool.
Set oAppPool = oWebAdmin.Get("ApplicationPool.Name='DefaultAppPool'")
' Start the application pool.
oAppPool.Start