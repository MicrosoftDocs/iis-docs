Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")
Set oAppPool = oWebAdmin.Get("ApplicationPool.Name='DefaultAppPool'")
' Get the application pool's name and its state.
WScript.Echo oAppPool.Name & " is " & _
      GetStateDescription(oAppPool.GetState) & "."
' The helper function translates the return value into text.
Function GetStateDescription(StateCode)
    Select Case StateCode
        Case 0
            GetStateDescription = "Starting"
        Case 1
            GetStateDescription = "Started"
        Case 2
            GetStateDescription = "Stopping"
        Case 3
            GetStateDescription = "Stopped"
        Case 4
            GetStateDescription = "Unknown"
        Case Else

            GetStateDescription = "Undefined value."
    End Select

End Function