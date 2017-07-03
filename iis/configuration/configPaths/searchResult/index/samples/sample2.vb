Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Default Web Site")
      Dim configPathsSection As ConfigurationSection = config.GetSection("configPaths")
      Dim searchResultCollection As ConfigurationElementCollection = configPathsSection.GetCollection
      For Each searchResultElement As ConfigurationElement In searchResultCollection
         Dim path As String = CType(searchResultElement("path"), String)
         Dim locationPath As String = CType(searchResultElement("locationPath"), String)
         For Each sectionElement As ConfigurationElement In searchResultElement.GetCollection
            If (String.Compare("system.webServer/defaultDocument", _
                  CType(sectionElement("name"), String), False) = 0) Then
               Console.WriteLine(("Path: " + path))
               If Not String.IsNullOrEmpty(locationPath) Then
                  Console.WriteLine((vbTab & "Location: " + locationPath))
                  Console.WriteLine((vbTab & vbTab & "Name: " + sectionElement("name")))
               Else
                  Console.WriteLine((vbTab & "Name: " + sectionElement("name")))
               End If
            End If
         Next
      Next
   End Sub

End Module