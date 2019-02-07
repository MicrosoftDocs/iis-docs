---
title: "ApplyIISEnvironmentVariables | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: a1ae5831-9b2f-48a3-ae9c-9040f188e1d0
caps.latest.revision: 5
manager: "wpickett"
---
# ApplyIISEnvironmentVariables
Injects dynamic environment variables into the current process that would otherwise have been injected into a running worker process.  
  
## Syntax  
  
```cpp  
    HRESULT  
    ApplyIISEnvironmentVariables();  
  
```  
  
## Return Value  
 `HRESULT`  
  
## Remarks  
 Examples of environment variables that this method can inject include `%IIS_BIN%` and `%IIS_USER_HOME`. This function can be useful if you are trying to process an IIS Express configuration file and must resolve an environment variable that has been declared within the file.  
  
## See Also  
 [GetPropertyValue](../../\express-api-reference/getpropertyvalue.md)   
 [CreateObjectFromProgId](../../\express-api-reference/createobjectfromprogid.md)   
 [CreateObjectFromCLSID](../../\express-api-reference/createobjectfromclsid.md)   
 [ClearIISEnvironmentVariables](../../\express-api-reference/cleariisenvironmentvariables.md)   
 [ApplyManifestContext](../../\express-api-reference/applymanifestcontext.md)   
 [ClearManifestContext](../../\express-api-reference/clearmanifestcontext.md)