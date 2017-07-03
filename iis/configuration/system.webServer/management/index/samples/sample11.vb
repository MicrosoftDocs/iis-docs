Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT"
adminManager.SetMetadata "pathMapper", "AdministrationConfig"

Set authorizationSection = adminManager.GetAdminSection("system.webServer/management/authorization", "MACHINE/WEBROOT")
Set authorizationRulesCollection = authorizationSection.ChildElements.Item("authorizationRules").Collection

scopeElementPos = FindElement(authorizationRulesCollection, "scope", Array("path", "/Default Web Site"))
If scopeElementPos = -1 Then
   Set scopeElement = authorizationRulesCollection.CreateNewElement("scope")
   scopeElement.Properties.Item("path").Value = "/Default Web Site"
   authorizationRulesCollection.AddElement(scopeElement)
Else
   Set scopeElement = authorizationRulesCollection.Item(scopeElementPos)
End If

Set scopeCollection = scopeElement.Collection
Set addElement = scopeCollection.CreateNewElement("add")
addElement.Properties.Item("name").Value = "ContosoUser"
scopeCollection.AddElement(addElement)

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