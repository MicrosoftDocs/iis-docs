Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")
Set oAppPool = oWebAdmin.Get("ApplicationPool.Name='DefaultAppPool'")
' Recycle the application pool.
oAppPool.Recycle