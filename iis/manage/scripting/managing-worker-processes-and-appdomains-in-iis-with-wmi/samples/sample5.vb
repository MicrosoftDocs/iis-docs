' Connect to the WMI WebAdministration namespace. 
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration") 
       
' Get the worker process instances. 
Set oWorkerProcesses = oWebAdmin.InstancesOf("WorkerProcess") 
       
' Get the ID of each worker process in the application pool and report its status. 
For Each oWorkerProcess In oWorkerProcesses 
       
    ' Report the worker process state via the GetStateDescription helper function. 
    WScript.Echo "WorkerProcess " & oWorkerProcess.ProcessID & ": " & _ 
        GetStateDescription(oWorkerProcess.GetState) 
    WScript.Echo "Application Pool: " & oWorkerProcess.AppPoolName
    WScript.Echo 
Next 

' The helper function translates the return value into text. 
Function GetStateDescription(StateCode) 
    Select Case StateCode 
        Case 0 
            GetStateDescription = "Starting" 
        Case 1 
            GetStateDescription = "Running" 
        Case 2 
            GetStateDescription = "Stopping" 
        Case 3 
            GetStateDescription = "Unknown" 
       
        Case Else 
            GetStateDescription = "Undefined value." 
    End Select 
End Function