Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")
Set oWorkerProcesses = oWebAdmin.InstancesOf("WorkerProcess")
     
For Each oWorkerProcess In oWorkerProcesses
    ' Place the requests queued for a process into an array variable.
    oWorkerProcess.GetExecutingRequests arrReqs
    
    ' Show the number of requests queued.
    If IsNull(arrReqs) Then
        WScript.Echo "No currently executing requests."

    Else
        ' Display the number of requests.
        WScript.Echo "Number of currently executing requests: " & _
            UBound(arrReqs) + 1
        WScript.Echo
  
        ' List the properties of each request.
        For Each oRequest In arrReqs
            WScript.Echo "Module: " & "[" & oRequest.CurrentModule & "]"
            WScript.Echo "Verb:" & "[" & oRequest.Verb & "]"
            WScript.Echo "HostName: " & "[" & oRequest.HostName & "]"
            WScript.Echo "Url: " & "[" & oRequest.Url & "]"
            WScript.Echo
        Next
    End If
Next