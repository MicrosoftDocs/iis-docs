Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
Set configPathsSection = adminManager.GetAdminSection("configPaths", "MACHINE/WEBROOT/APPHOST/Default Web Site")
Set searchResultCollection = configPathsSection.Collection

For i = 0 To CInt(searchResultCollection.Count) - 1
   Set searchResultElement = searchResultCollection.Item(i)
   path = searchResultElement.GetPropertyByName("path").Value
   locationPath = searchResultElement.GetPropertyByName("locationPath").Value
   Set sectionElementCollection = searchResultElement.Collection
   For j = 0 To CInt(sectionElementCollection.Count) - 1
      Set sectionElement = sectionElementCollection.Item(j)
      name = sectionElement.GetPropertyByName("name").Value
      If name = "system.webServer/defaultDocument" Then
         WScript.Echo "Path: " + path
         If locationPath<>"" Then
            WScript.Echo(vbTab & "Location: " + locationPath)
            WScript.Echo(vbTab & vbTab & "Name: " + name)
         Else
            WScript.Echo(vbTab & "Name: " + name)
         End if
      End If
   Next
Next