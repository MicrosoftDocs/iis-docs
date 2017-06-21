' Create a Writable Admin Manager object.
Set adminManager = CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

' Retrieve the sites collection.
Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites","MACHINE/WEBROOT/APPHOST")
Set sitesCollection = sitesSection.Collection

' Locate a specific site.
siteElementPos = FindElement(sitesCollection,"site",Array("name","MySite"))
If siteElementPos = -1 Then
   WScript.Echo "Element not found!"
   WScript.Quit
End If

' Retrieve the site element.
Set siteElement = sitesCollection.Item(siteElementPos)
' Create an object for the ftpServer element.
Set ftpServerElement = siteElement.ChildElements.Item("ftpServer")
' Create an instance of the Start method.
Set Start = ftpServerElement.Methods.Item("Start").CreateInstance()
' Execute the method to start the FTP site.
Start.Execute()

Function FindElement(collection, elementTagName, valuesToMatch)
   For i = 0 To CInt(collection.Count) - 1
      Set element = collection.Item(i)
      If element.Name = elementTagName Then
         matches = True
         For iVal = 0 To UBound(valuesToMatch) Step 2
            Set property = element.GetPropertyByName(valuesToMatch(iVal))
            value = property.Value
            If Not IsNull(value) Then
               value = CStr(value)
            End If
            If Not value = CStr(valuesToMatch(iVal + 1)) Then
               matches = False
               Exit For
            End If
         Next
         If matches Then
            Exit For
         End If
      End If
   Next
   If matches Then
      FindElement = i
   Else
      FindElement = -1
   End If
End Function