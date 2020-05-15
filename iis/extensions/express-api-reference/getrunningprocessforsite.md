---
title: "GetRunningProcessForSite"
ms.date: "10/07/2016"
ms.assetid: 97a095d4-839a-4405-9b4d-7142be2ba815
---
# GetRunningProcessForSite

Returns the process ID of the worker process when the parameters of this function match the parameters for the current user specified by the [ConstructCommandLine](../../extensions/express-api-reference/constructcommandline.md) function.  
  
## Syntax  
  
```cpp  
    HRESULT  
    GetRunningProcessForSite(   
        [in] BSTR    bstrSite,   
        [in] BSTR    bstrApplication,   
        [in] BSTR    bstrApplicationPool,   
        [in] BSTR    bstrConfigPath,   
        [out, retval] DWORD * pdwPid  
    );  
  
```  
  
### Parameters  
  
- [in] `bstrSite`  
  
     The name of the site.  
  
- [in] `bstrApplication`  
  
     The name of the application.  
  
- [in] `bstrApplicationPool`  
  
     The name of the application pool.  
  
- [in] `bstrConfigPath`  
  
     The path to the configuration files.  
  
- [out, retval] `* pdwPid`  
  
     The process ID of the worker process.  
  
## Return Value  

 `HRESULT`  
  
## See Also  

 [ConstructCommandLine](../../extensions/express-api-reference/constructcommandline.md)   
 [StopProcess](../../extensions/express-api-reference/stopprocess.md)
