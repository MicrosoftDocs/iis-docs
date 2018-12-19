---
title: "IIISVersion | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 788ea4aa-7117-4ab1-b800-00a29aeb072d
caps.latest.revision: 6
manager: "wpickett"
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
 [GetPropertyValue](../../extenions\express-api-ref/getpropertyvalue.md)   
 [CreateObjectFromProgId](../../extenions\express-api-ref/createobjectfromprogid.md)   
 [CreateObjectFromCLSID](../../extenions\express-api-ref/createobjectfromclsid.md)   
 [ApplyIISEnvironmentVariables](../../extenions\express-api-ref/applyiisenvironmentvariables.md)   
 [ClearIISEnvironmentVariables](../../extenions\express-api-ref/cleariisenvironmentvariables.md)   
 [ApplyManifestContext](../../extenions\express-api-ref/applymanifestcontext.md)   
 [ClearManifestContext](../../extenions\express-api-ref/clearmanifestcontext.md)