Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")
Set oAppPools = oWebAdmin.InstancesOf("ApplicationPool")
For Each oAppPool In oAppPools
    If oAppPool.Name = "OneMoreAppPool" Then

        oAppPool.Delete_
        Exit For

   End If

Next