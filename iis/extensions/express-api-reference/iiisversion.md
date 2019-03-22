---
title: "IIISVersion"
ms.date: "10/07/2016"
ms.assetid: 788ea4aa-7117-4ab1-b800-00a29aeb072d
---
# IIISVersion
Returns details about an IIS product version that is installed on the current computer.  
  
## Syntax  
  
```cpp  
interface IIISVersion : IUnknown  
{  
    HRESULT  
    GetPropertyValue(  
        [in, string]  BSTR bstrName,  
        [out, retval] VARIANT * pvarValue  
    );  
  
    HRESULT  
    CreateObjectFromProgId(  
        [in, string] BSTR bstrObjectName,  
        [out, retval] VARIANT * pObject  
    );  
  
    HRESULT  
    CreateObjectFromCLSID(  
        [in] CLSID clsidObject,  
        [out, retval] VARIANT * pObject  
    );  
  
    HRESULT  
    ApplyIISEnvironmentVariables();  
  
    HRESULT  
    ClearIISEnvironmentVariables();  
  
    HRESULT  
    ApplyManifestContext();  
  
    HRESULT  
    ClearManifestContext();  
};  
  
```  
  
## See Also  
 [GetPropertyValue](../../extensions/express-api-reference/getpropertyvalue.md)   
 [CreateObjectFromProgId](../../extensions/express-api-reference/createobjectfromprogid.md)   
 [CreateObjectFromCLSID](../../extensions/express-api-reference/createobjectfromclsid.md)   
 [ApplyIISEnvironmentVariables](../../extensions/express-api-reference/applyiisenvironmentvariables.md)   
 [ClearIISEnvironmentVariables](../../extensions/express-api-reference/cleariisenvironmentvariables.md)   
 [ApplyManifestContext](../../extensions/express-api-reference/applymanifestcontext.md)   
 [ClearManifestContext](../../extensions/express-api-reference/clearmanifestcontext.md)