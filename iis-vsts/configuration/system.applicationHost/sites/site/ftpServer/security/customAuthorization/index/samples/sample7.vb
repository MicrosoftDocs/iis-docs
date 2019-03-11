Set adminManager = CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST")

Set sitesCollection = sitesSection.Collection
siteElementPos = FindElement(sitesCollection, "site", Array ("name", "MyFTP"))
if (siteElementPos = -1) THEN throw "Element not found!"
Set siteElement = sitesCollection.Item(siteElementPos)

Set ftpServerElement = siteElement.ChildElements.Item("ftpServer")
Set securityElement = ftpServerElement.ChildElements.Item("security")
Set customAuthorizationElement = securityElement.ChildElements.Item("customAuthorization")
Set providerElement = customAuthorizationElement.ChildElements.Item("provider")
providerElement.Properties.Item("name").Value = "MyProvider1"
providerElement.Properties.Item("enabled").Value = true

adminManager.CommitChanges()

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