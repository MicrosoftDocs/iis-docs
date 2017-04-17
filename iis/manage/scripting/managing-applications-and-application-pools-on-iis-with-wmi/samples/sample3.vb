' Connect to the WMI WebAdministration namespace.
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
' Use InstancesOf to retrieve the applications.
Set oApps = oWebAdmin.InstancesOf("Application")
  ' Iterate through the applications.
For Each oApp In oApps
    WScript.Echo "  Web site/Application: " & oApp.SiteName & oApp.Path
    WScript.Echo "      Application Pool: " & oApp.ApplicationPool
    WScript.Echo "   Enabled protocol(s): " & oApp.EnabledProtocols
    WScript.Echo
Next