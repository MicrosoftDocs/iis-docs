Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set applicationPoolsSection = adminManager.GetAdminSection("system.applicationHost/applicationPools", "MACHINE/WEBROOT/APPHOST")
Set applicationPoolsCollection = applicationPoolsSection.Collection
addElementPos = FindElement(applicationPoolsCollection, "add", Array("name", "DefaultAppPool"))

If (siteElementPos = -1) Then
   WScript.Echo "Element not found!"
   WScript.Quit
End If

Set addElement = applicationPoolsCollection.Item(addElementPos)
Set cpuElement = addElement.ChildElements.Item("cpu")
cpuElement.Properties.Item("action").Value = "KillW3wp"
cpuElement.Properties.Item("resetInterval").Value = "00:04:00"

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