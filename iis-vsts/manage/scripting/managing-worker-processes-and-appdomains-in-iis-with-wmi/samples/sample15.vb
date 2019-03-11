'Connect to the WMI WebAdministration namespace
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")
Set oAppDomains = oWebAdmin.InstancesOf("AppDomain")
WScript.Echo "AppDomain Count: " & oAppDomains.Count
WScript.Echo 
ADCounter = 0
For Each oAppDomain In oAppDomains
    ADCounter = ADCounter + 1
    WScript.Echo "---- AppDomain " & ADCounter & " of " & _
                oAppDomains.Count & " ----" & vbCrLf
    WScript.Echo "[ Key properties ]"
    WScript.Echo "ID: " & oAppDomain.ID
    WScript.Echo "Site Name: " & oAppDomain.SiteName
    WScript.Echo "Application Path: " & oAppDomain.ApplicationPath
    WScript.Echo
    WScript.Echo "[ Run-time properties ]"
    WScript.Echo "Process ID: " & oAppDomain.ProcessID
    WScript.Echo "Is idle: " & oAppDomain.IsIdle
    WScript.Echo vbCrLf
Next