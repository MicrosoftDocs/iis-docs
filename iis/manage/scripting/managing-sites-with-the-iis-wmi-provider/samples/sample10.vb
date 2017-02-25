Set oIIS = GetObject("winmgmts:root\WebAdministration")
Set oSites = oIIS.InstancesOf("Site")
For Each oSite In oSites            
     WScript.Echo oSite.Name & " (" & oSite.Id & ")"
Next