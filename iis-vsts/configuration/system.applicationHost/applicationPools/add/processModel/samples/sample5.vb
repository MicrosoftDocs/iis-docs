Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim applicationPoolsSection As ConfigurationSection = config.GetSection("system.applicationHost/applicationPools")
      Dim applicationPoolsCollection As ConfigurationElementCollection = applicationPoolsSection.GetCollection
      Dim addElement As ConfigurationElement = FindElement(applicationPoolsCollection, "add", "name", "Contoso")

      If (addElement Is Nothing) Then
         Throw New InvalidOperationException("Element not found!")
      End If

      Dim processModelElement As ConfigurationElement = addElement.GetChildElement("processModel")
      processModelElement("shutdownTimeLimit") = TimeSpan.Parse("00:00:30")
      processModelElement("startupTimeLimit") = TimeSpan.Parse("00:00:30")
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