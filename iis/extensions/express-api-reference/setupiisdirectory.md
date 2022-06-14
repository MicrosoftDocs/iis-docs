---
title: SetupIISDirectory
description: Describes the SetupIISDirectory field and provides the field's syntax, parameters, return value, and additional references.
ms.date: 10/07/2016
ms.assetid: e9a056dc-feaa-431a-a1e6-38b917e45b3c
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
  
### Parameters  
  
- [in] `fOverride`.  
  
     True to specify that the method can override existing files; otherwise, false.  
  
## Return Value  
 `HRESULT`  
  
## See Also  
 [IISDirectory](../../extensions/express-api-reference/iisdirectory.md)   
 [ClearIISDirectory](../../extensions/express-api-reference/cleariisdirectory.md)
