---
title: "ApplyIISEnvironmentVariables"
ms.date: "10/07/2016"
ms.assetid: a1ae5831-9b2f-48a3-ae9c-9040f188e1d0
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
 [GetPropertyValue](../../extensions/express-api-reference/getpropertyvalue.md)   
 [CreateObjectFromProgId](../../extensions/express-api-reference/createobjectfromprogid.md)   
 [CreateObjectFromCLSID](../../extensions/express-api-reference/createobjectfromclsid.md)   
 [ClearIISEnvironmentVariables](../../extensions/express-api-reference/cleariisenvironmentvariables.md)   
 [ApplyManifestContext](../../extensions/express-api-reference/applymanifestcontext.md)   
 [ClearManifestContext](../../extensions/express-api-reference/clearmanifestcontext.md)
