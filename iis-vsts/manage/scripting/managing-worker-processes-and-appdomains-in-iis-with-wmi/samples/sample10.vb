Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")
Set oAppDomains = oWebAdmin.ExecQuery("SELECT * FROM AppDomain")

' Unload only the Northwind application domain.
For Each oAppDomain In oAppDomains
    If oAppDomain.ApplicationPath = "/Northwind/" Then 
        oAppDomain.Unload
        Exit For 
    End If 
Next