Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetAdministrationConfiguration
      Dim authorizationSection As ConfigurationSection = config.GetSection("system.webServer/management/authorization")
      Dim authorizationRulesCollection As ConfigurationElementCollection = authorizationSection.GetCollection("authorizationRules")

      Dim scopeElement As ConfigurationElement = FindElement(authorizationRulesCollection, "scope", "path", "/Default Web Site")
      If (scopeElement Is Nothing) Then
         scopeElement = authorizationRulesCollection.CreateElement("scope")
         scopeElement("path") = "/Default Web Site"
         authorizationRulesCollection.Add(scopeElement)
      End If

      Dim scopeCollection As ConfigurationElementCollection = scopeElement.GetCollection
      Dim addElement As ConfigurationElement = scopeCollection.CreateElement("add")
      addElement("name") = "ContosoUser"
      scopeCollection.Add(addElement)

      serverManager.CommitChanges()
   End Sub

   Private Function FindElement(ByVal collection As ConfigurationElementCollection, ByVal elementTagName As String, ByVal ParamArray keyValues() As String) As ConfigurationElement
      For Each element As ConfigurationElement In collection
         If String.Equals(element.ElementTagName, elementTagName, StringComparison.OrdinalIgnoreCase) Then
            Dim matches As Boolean = True
            Dim i As Integer
            For i = 0 To keyValues.Length - 1 Step 2
               Dim o As Object = element.GetAttributeValue(keyValues(i))
               Dim value As String = Nothing
               If (Not (o) Is Nothing) Then
                  value = o.ToString
               End If
               If Not String.Equals(value, keyValues((i + 1)), StringComparison.OrdinalIgnoreCase) Then
                  matches = False
                  Exit For
               End If
            Next
            If matches Then
               Return element
            End If
         End If
      Next
      Return Nothing
   End Function


End Module