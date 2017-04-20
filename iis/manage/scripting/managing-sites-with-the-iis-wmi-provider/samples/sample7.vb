Set oIIS = GetObject("winmgmts:root\WebAdministration")        
' In order to retrieve an object instance, the object's key properties
' and their values must be specified in the WMI object instance path
Set oSite = oIIS.Get("Site.Name='Default Web Site'")    
' The object definition can be retrieved by specifying the name
' of the object without any key properties and values
Set oSiteDefn = oIIS.Get("Site")