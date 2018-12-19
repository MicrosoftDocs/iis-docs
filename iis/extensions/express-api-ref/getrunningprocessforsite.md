---
title: "GetRunningProcessForSite | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 97a095d4-839a-4405-9b4d-7142be2ba815
caps.latest.revision: 7
manager: "wpickett"
---
# GetRunningProcessForSite
Returns the process ID of the worker process when the parameters of this function match the parameters for the current user specified by the [ConstructCommandLine](../../extenions\express-api-ref/constructcommandline.md) function.  
  
## Syntax  
  
```cpp  
    HRESULT  
    GetRunningProcessForSite(   
        [in] BSTR    bstrSite,   
        [in] BSTR    bstrApplication,   
        [in] BSTR    bstrApplicationPool,   
        [in] BSTR    bstrConfigPath,   
        [out, retval] DWORD * pdwPid  
    );  
  
```  
  
#### Parameters  
  
-   [in] `bstrSite`  
  
     The name of the site.  
  
-   [in] `bstrApplication`  
  
     The name of the application.  
  
-   [in] `bstrApplicationPool`  
  
     The name of the application pool.  
  
-   [in] `bstrConfigPath`  
  
     The path to the configuration files.  
  
-   [out, retval] `* pdwPid`  
  
     The process ID of the worker process.  
  
## Return Value  
 `HRESULT`  
  
## See Also  
 [ConstructCommandLine](../../extenions\express-api-ref/constructcommandline.md)   
 [StopProcess](../../extenions\express-api-ref/stopprocess.md)