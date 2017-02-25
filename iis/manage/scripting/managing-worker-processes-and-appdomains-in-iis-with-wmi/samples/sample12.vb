Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")

' Get all the application domains on the Web server.
Set oAppDomains = oWebAdmin.ExecQuery("SELECT * FROM AppDomain")

' Unload all the application domains.
For Each oAppDomain In oAppDomains
    oAppDomain.Unload
Next