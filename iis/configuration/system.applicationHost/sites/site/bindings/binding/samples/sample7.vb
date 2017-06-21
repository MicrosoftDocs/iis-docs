Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST")
Set sitesCollection = sitesSection.Collection
siteElementPos = FindElement(sitesCollection, "site", Array("name", "Contoso"))

If siteElementPos = -1 Then
   WScript.Echo "Element not found!"
   WScript.Quit
End If

Set siteElement = sitesCollection.Item(siteElementPos)
Set bindingsCollection = siteElement.ChildElements.Item("bindings").Collection

Set bindingElement = bindingsCollection.CreateNewElement("binding")
bindingElement.Properties.Item("protocol").Value = "http"
bindingElement.Properties.Item("bindingInformation").Value = "192.168.0.1:80:www.contoso.com"
bindingsCollection.AddElement(bindingElement)

Set bindingElement1 = bindingsCollection.CreateNewElement("binding")
bindingElement1.Properties.Item("protocol").Value = "https"
bindingElement1.Properties.Item("bindingInformation").Value = "*:443:"
bindingsCollection.AddElement(bindingElement1)

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