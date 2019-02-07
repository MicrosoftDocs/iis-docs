---
title: "ApplyManifestContext | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 13f0c1a6-4ba3-4261-8dd5-4dcf1ce4eec2
caps.latest.revision: 5
manager: "wpickett"
---
# ApplyManifestContext
Applies the Fusion manifest context on the calling thread, enabling the creation of COM objects that might have been declared in the manifest file for the product.  
  
## Syntax  
  
```cpp  
    HRESULT  
    ApplyManifestContext(  
    );  
```  
  
## Return Value  
 `HRESULT`  
  
## Remarks  
 This function enables granular control of the process of setting and removing the Fusion activation context from the thread. It can be useful if you want to perform multiple operations with the context rather than using one of the helper functions such as [CreateObjectFromProgId](../../\express-api-reference/createobjectfromprogid.md) or [CreateObjectFromCLSID](../../\express-api-reference/createobjectfromclsid.md).  
  
## See Also  
 [GetPropertyValue](../../\express-api-reference/getpropertyvalue.md)   
 [CreateObjectFromProgId](../../\express-api-reference/createobjectfromprogid.md)   
 [CreateObjectFromCLSID](../../\express-api-reference/createobjectfromclsid.md)   
 [ApplyIISEnvironmentVariables](../../\express-api-reference/applyiisenvironmentvariables.md)   
 [ClearIISEnvironmentVariables](../../\express-api-reference/cleariisenvironmentvariables.md)   
 [ClearManifestContext](../../\express-api-reference/clearmanifestcontext.md)