Set adminManager = CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST")

Set sitesCollection = sitesSection.Collection

siteElementPos = FindElement(sitesCollection, "site", array ("name", "ContosoSite"))
if (siteElementPos = -1) THEN throw "Element not found!"
Set siteElement = sitesCollection.Item(siteElementPos)

Set logFileElement = siteElement.ChildElements.Item("logFile")
Set customFieldsElement = logFileElement.ChildElements.Item("customFields")

Set customFieldsCollection = customFieldsElement.Collection

Set addElement = customFieldsCollection.CreateNewElement("add")
addElement.Properties.Item("logFieldName").Value = "ContosoField"
addElement.Properties.Item("sourceName").Value = "ContosoSource"
addElement.Properties.Item("sourceType").Value = "ServerVariable"
customFieldsCollection.AddElement(addElement)


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