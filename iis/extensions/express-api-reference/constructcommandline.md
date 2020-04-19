---
title: "ConstructCommandLine"
ms.date: "10/07/2016"
ms.assetid: 9f3d0ab2-c083-471b-a6b1-160ab006c613
---
# ConstructCommandLine
Returns the command line that starts an IIS Express instance using the specified options.  
  
## Syntax  
  
```cpp  
    HRESULT  
    ConstructCommandLine(   
        [in] BSTR bstrSite,  
        [in] BSTR bstrApplication,  
        [in] BSTR bstrApplicationPool,   
        [in] BSTR bstrConfigPath,   
        [out, retval] BSTR * pbstrCommandLine  
    );  
  
```  
  
```csharp  
  
```  
  
### Parameters  
  
-   [in] `bstrSite`  
  
     The name of the site.  
  
-   [in] `bstrApplication`  
  
     The name of the application.  
  
-   [in] `bstrApplicationPool`  
  
     The name of the application pool.  
  
-   [in] `bstrConfigPath`  
  
     The path to the configuration files.  
  
-   [out, retval] `* pbstrCommandLine`  
  
     The command line that starts an IIS Express instance.  
  
## Return Value  
 `HRESULT`  
  
## See Also  
 [GetRunningProcessForSite](../../extensions/express-api-reference/getrunningprocessforsite.md)   
 [StopProcess](../../extensions/express-api-reference/stopprocess.md)
