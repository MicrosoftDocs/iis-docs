Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")
Set oAppPools = oWebAdmin.InstancesOf("ApplicationPool")
For Each oAppPool In oAppPools
    WScript.Echo "Application pool name: " & oAppPool.Name
    If oAppPool.ManagedPipelineMode = 0 Then

        sAppPoolMode = "Integrated"
    ElseIf oAppPool.ManagedPipelineMode = 1 Then

        sAppPoolMode = "ISAPI"
    End if

    WScript.Echo "Application pool mode: " & sAppPoolMode
    WScript.Echo 
Next