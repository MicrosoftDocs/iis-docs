Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")
strNewAppPoolName = InputBox("Enter the name for the new application pool.")
 If strNewAppPoolName <> "" Then
oWebAdmin.Get("ApplicationPool").Create(strNewAppPoolName)
End If