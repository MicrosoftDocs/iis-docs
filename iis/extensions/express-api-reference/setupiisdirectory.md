---
title: "SetupIISDirectory | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: e9a056dc-feaa-431a-a1e6-38b917e45b3c
caps.latest.revision: 6
manager: "wpickett"
---
# SetupIISDirectory
Creates the IIS Express home directory for the current user by copying all relevant initial configuration and website files.  
  
## Syntax  
  
```cpp  
HRESULT  
SetupIISDirectory(  
    [in] BOOL fOverride  
);  
  
```  
  
#### Parameters  
  
-   [in] `fOverride`.  
  
     True to specify that the method can override existing files; otherwise, false.  
  
## Return Value  
 `HRESULT`  
  
## See Also  
 [IISDirectory](../../\express-api-reference/iisdirectory.md)   
 [ClearIISDirectory](../../\express-api-reference/cleariisdirectory.md)