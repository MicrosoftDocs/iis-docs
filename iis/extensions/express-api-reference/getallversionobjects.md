---
title: "GetAllVersionObjects"
description: "This article shares the syntax, parameters, and return value of GetAllVersionObjects, which numerates all IIS product versions that are installed on the computer."
ms.date: "10/07/2016"
ms.assetid: 1a6a78bb-bbc9-4d93-8514-fb287203451e
---
# GetAllVersionObjects
Enumerates all IIS product versions that are installed on the computer.  
  
## Syntax  
  
```cpp  
    HRESULT  
    GetAllVersionObjects(  
        [out, retval] SAFEARRAY(VARIANT) * pVersionsArray  
    );  
  
```  
  
### Parameters  
  
- [out, retval] `* pVersionsArray`  
  
     Contains all [IIISVersion](../../extensions/express-api-reference/iiisversion.md) objects that are found on the computer.  
  
## Return Value  
 `HRESULT`  
  
## See Also  
 [GetVersionObject](../../extensions/express-api-reference/getversionobject.md)
