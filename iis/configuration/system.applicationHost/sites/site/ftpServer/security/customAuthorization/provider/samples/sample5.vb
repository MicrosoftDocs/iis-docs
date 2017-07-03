Imports System
Imports System.Text
Imports Microsoft.Web.Administration
Module Sample
     
     Sub Main()
         Dim serverManager As ServerManager = New ServerManager
         Dim config As Configuration = serverManager.GetApplicationHostConfiguration
         Dim sitesSection As ConfigurationSection = config.GetSection("system.applicationHost/sites")
         Dim sitesCollection As ConfigurationElementCollection = sitesSection.GetCollection
         Dim siteElement As ConfigurationElement = FindElement(sitesCollection, "site", "name", "MyFTPSite")
         If (siteElement Is Nothing) Then
             Throw New InvalidOperationException("Element not found!")
         End If
         Dim ftpServerElement As ConfigurationElement = siteElement.GetChildElement("ftpServer")
         Dim securityElement As ConfigurationElement = ftpServerElement.GetChildElement("security")
         Dim customAuthorizationElement As ConfigurationElement = securityElement.GetChildElement("customAuthorization")
         Dim providerElement As ConfigurationElement = customAuthorizationElement.GetChildElement("provider")
         providerElement("name") = "MyProvider"
         providerElement("enabled") = true
         serverManager.CommitChanges
     End Sub
     
     Private Shared Function FindElement(ByVal collection As ConfigurationElementCollection, ByVal elementTagName As String, ParamArray ByVal keyValues() As String) As ConfigurationElement
         For Each element As ConfigurationElement In collection
             If String.Equals(element.ElementTagName, elementTagName, StringComparison.OrdinalIgnoreCase) Then
                 Dim matches As Boolean = true
                 Dim i As Integer = 0
                 Do While (i < keyValues.Length)
                     Dim o As Object = element.GetAttributeValue(keyValues(i))
                     Dim value As String = Nothing
                     If (Not (o) Is Nothing) Then
                         value = o.ToString
                     End If
                     If Not String.Equals(value, keyValues((i + 1)), StringComparison.OrdinalIgnoreCase) Then
                         matches = false
                         Exit For
                     End If
                     i = (i + 2)
                 Loop
                 If matches Then
                     Return element
                 End If
             End If
         Next
         Return Nothing
     End Function
 End Module