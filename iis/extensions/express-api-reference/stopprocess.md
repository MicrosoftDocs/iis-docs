---
title: "StopProcess"
ms.date: "10/07/2016"
ms.assetid: 3329bdda-a098-4d67-941b-f72c6a5486bd
---
# StopProcess
Stops the IIS Express process for the specified process ID.  
  
## Syntax  
  
```cpp  
    HRESULT  
    StopProcess(   
        [in] DWORD dwPid  
    );  
  
```  
  
### Parameters  
  
- [in] `dwPid`  
  
     The ID of the process to stop.  
  
## Return Value  
 `HRESULT`  
  
## See Also  
 [GetRunningProcessForSite](../../extensions/express-api-reference/getrunningprocessforsite.md)   
 [ConstructCommandLine](../../extensions/express-api-reference/constructcommandline.md)