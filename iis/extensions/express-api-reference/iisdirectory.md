---
title: "IISDirectory"
description: "The IISDirectory gets the IIS Express home directory for the current user. This article describes its syntax, parameters, and return value."
ms.date: "10/07/2016"
ms.assetid: cf44e587-74c7-4ed0-aa69-d7e296a713d0
---
# IISDirectory
Gets the IIS Express home directory for the current user.  
  
## Syntax  
  
```cpp  
[propget]  
HRESULT  
IISDirectory(  
    [out, retval] BSTR * pbstrDirectory  
);  
  
```  
  
### Parameters  
  
- [out, retval] `* pbstrDirectory`  
  
     The IIS Express home directory for the current user.  
  
## Return Value  
 `HRESULT`  
  
## See Also  
 [SetupIISDirectory](../../extensions/express-api-reference/setupiisdirectory.md)   
 [ClearIISDirectory](../../extensions/express-api-reference/cleariisdirectory.md)
