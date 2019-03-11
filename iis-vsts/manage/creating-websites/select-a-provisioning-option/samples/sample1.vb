If WScript.Arguments.Count < 4 Then 
    WScript.Echo "Not enough parameters. Enter: username | web site name | app pool password | site ID" 
    WScript.Quit
End If

userName = WScript.Arguments(0) 
siteName = WScript.Arguments(1)
appPoolPassword = WScript.Arguments(2)
siteID = WScript.Arguments(3) 
appPoolName = "apppool_" & siteName
physicalPath = "\\server\share" & userName & "\" & siteName [slg1] [slg2] 

Set oIIS = GetObject("winmgmts:root\WebAdministration")

Set oBinding = oIIS.Get("BindingElement").SpawnInstance_
oBinding.BindingInformation = "*:80:" & siteName
oBinding.Protocol = "http"

Set oBinding2 = oIIS.Get("BindingElement").SpawnInstance_
oBinding2.BindingInformation = "*:80:www." & siteName
oBinding2.Protocol = "http"
arrBindings = array(oBinding, oBinding2)

Set oSiteDefn = oIIS.Get("Site")
oSiteDefn.Create siteName, arrBindings, physicalPath
WScript.Echo "Site created"

WScript.Sleep(100)

Set oSite = oIIS.Get("Site.Name='" & siteName & "'")
oSite.ID = siteID 
oSite.Put_

Set oSite = oIIS.Get("Site.Name='" & siteName & "'")
appPoolUserName = "poolname_" & siteID

Set oAppDefn = oIIS.Get("ApplicationPool")
oAppDefn.Create appPoolName
WScript.Echo "App pool created"

WScript.Sleep(3000)

Set oAppDefn = oIIS.Get("ApplicationPool.Name='" & appPoolName & "'")
oAppDefn.ProcessModel.IdentityType = 3
oAppDefn.ProcessModel.Username = appPoolUserName
oAppDefn.ProcessModel.Password = appPoolPassword
oAppDefn.Put_ 

WScript.Echo "Identity set for App Pool"

Set oSiteDefn = oIIS.Get("Site.Name='" & siteName & "'")
oSiteDefn.ApplicationDefaults.ApplicationPool = appPoolName
oSiteDefn.Put_
WScript.Echo "Site assigned to pool"

Set oSite = oIIS.Get("Site.Name='" & siteName & "'")
oSite.Start