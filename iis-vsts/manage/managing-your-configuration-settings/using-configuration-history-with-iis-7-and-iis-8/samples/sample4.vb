Option Explicit 

' Global objects, variables
Dim objShell, argObj, oExec
Dim strDirectory, strFile, strCmd, strFullCmd, stdIn, i

set objShell = CreateObject("Wscript.Shell")
strDirectory = "%windir%\system32\inetsrv\" 
strFile = "AppCmd.exe"

set ArgObj = Wscript.Arguments

' No args (default case), hard-code StdIn
If ArgObj.Count = 0 Then 
stdIn = 17

i = 0 'initilize i

For i = 0 to stdIn 
' Call Select Case to change Statement 
strCmd = getStrCmd(i)
strFullCmd = strDirectory & strFile & " " & strCmd

Set oExec = objShell.Exec(strFullCmd) 

Do While oExec.Status = 0
WScript.Sleep 100
Loop 

If oExec.ExitCode <> 0 Then 
' Something wrong with the IIS Installation

' Is AppCmd installed on the machine? \inetsrv directory?
msgBox "Executing AppCmd Command Failed. Please Try Again!"

wscript.Quit
End if 

WScript.Sleep(2 * 1000)

Next 

' Handle the case where we passed arguments to
' the script

Else 
stdIn = ArgObj(0)

' Same code as above but handle arguments being passed.

i = 0 ' initialize i

For i = 0 to stdIn 
' Call Select Case to change Statement
strCmd = getStrCmd(i)
strFullCmd = strDirectory & strFile & " " & strCmd

Set oExec = objShell.Exec(strFullCmd)

Do While oExec.Status = 0
WScript.Sleep 100
Loop 

' Validate that AppCmd calls succeeded by checking Error code
If oExec.ExitCode <> 0 Then 
' Something wrong with the IIS Installation
' Is AppCmd installed on the machine? \inetsrv directory?
msgBox "Executing AppCmd Command Failed. Please Try Again!"
wscript.Quit
End if 

' Go to sleep for x period (default: 20)
WScript.Sleep(20 * 1000)

Next 

' End the StdIn Input Tree

End if 

' AppCMD Command Function 
Function getStrCmd(MyIndex)
Select Case (MyIndex)
Case 0 ' set Server Runtime
getStrCmd = "set config /section:serverRuntime /enabled:false"
Case 1 ' set Default Document
getStrCmd = "set config /section:defaultDocument /enabled:true"
Case 2 'set httpRedirect
getStrCmd = "set config /section:httpRedirect /enabled:true"
Case 3 ' set Client Certificate Mapping Auth
getStrCmd = "set config /section:security/authentication/clientCertificateMappingAuthentication /enabled:true"
Case 4 ' set Directory Browse
getStrCmd = "set config /section:directoryBrowse /enabled:true"
Case 5 ' set httpRedirect
getStrCmd = "set config /section:httpRedirect /enabled:false" 
Case 6 ' set anonymousAuth
getStrCmd = "set config /section:security/authentication/anonymousAuthentication /enabled:false"
Case 7 ' set basicAuth
getStrCmd = "set config /section:security/authentication/basicAuthentication /enabled:true"
Case 8 ' set digestAuth
getStrCmd = "set config /section:security/authentication/digestAuthentication /enabled:true"
Case 9 ' set client cert mapping auth
getStrCmd = "set config /section:security/authentication/clientCertificateMappingAuthentication /enabled:false"
Case 10 ' set windows auth
getStrCmd = "set config /section:security/authentication/windowsAuthentication /enabled:true"
Case 11 ' server runtime
getStrCmd = "set config /section:serverRuntime /enabled:true"
Case 12 ' set Server Runtime
getStrCmd = "set config /section:serverRuntime /enabled:false"
Case 13 ' set Server Runtime
getStrCmd = "set config /section:serverRuntime /enabled:true"
Case 14 ' set Server Runtime
getStrCmd = "set config /section:serverRuntime /enabled:true"
Case 15 ' set Server Runtime
getStrCmd = "set config /section:serverRuntime /enabled:true"
Case 16 ' set Server Runtime
getStrCmd = "set config /section:serverRuntime /enabled:true"
Case 17 ' set Server Runtime
getStrCmd = "set config /section:serverRuntime /enabled:true"

End select 
End Function