---
title: "GetAllVersionObjects | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 1a6a78bb-bbc9-4d93-8514-fb287203451e
caps.latest.revision: 7
manager: "wpickett"
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
  
#### Parameters  
  
-   [out, retval] `* pVersionsArray`  
  
     Contains all [IIISVersion](../../\express-api-reference/iiisversion.md) objects that are found on the computer.  
  
## Return Value  
 `HRESULT`  
  
## See Also  
 [GetVersionObject](../../\express-api-reference/getversionobject.md)