---
title: "IIISExpressProcessUtility"
ms.date: "10/07/2016"
ms.assetid: 514fec28-799c-464a-891b-d55bf892877c
---
# IIISExpressProcessUtility
Obtains information that describes how to locate, start, and stop IIS Express worker processes.  
  
## Syntax  
  
```cpp  
interface IIISExpressProcessUtility : IUnknown  
{  
    HRESULT  
    GetRunningProcessForSite(
        [in] BSTR    bstrSite,
        [in] BSTR    bstrApplication,
        [in] BSTR    bstrApplicationPool,
        [in] BSTR    bstrConfigPath,
        [out, retval] DWORD * pdwPid  
    );  
  
    HRESULT  
    ConstructCommandLine(
        [in] BSTR bstrSite,  
        [in] BSTR bstrApplication,  
        [in] BSTR bstrApplicationPool,
        [in] BSTR bstrConfigPath,
        [out, retval] BSTR * pbstrCommandLine  
    );  
  
    HRESULT  
    StopProcess(
        [in] DWORD dwPid  
    );  
};  
  
```  
  
## See Also  
 [GetRunningProcessForSite](../../extensions/express-api-reference/getrunningprocessforsite.md)
 [ConstructCommandLine](../../extensions/express-api-reference/constructcommandline.md)
 [StopProcess](../../extensions/express-api-reference/stopprocess.md)
