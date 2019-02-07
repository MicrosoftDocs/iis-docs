---
title: "CreateObjectFromProgId | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: e04be95d-4c66-4fbf-8f39-6f96de98f053
caps.latest.revision: 9
manager: "wpickett"
---
# CreateObjectFromProgId
Creates a COM object using the specified ProgID.  
  
## Syntax  
  
```cpp  
    HRESULT  
    CreateObjectFromProgId(  
        [in, string] BSTR bstrObjectName,  
        [out, retval] VARIANT * pObject  
    );  
  
```  
  
#### Parameters  
  
-   [in, string] `bstrObjectName`  
  
     The ProgID of the COM object to create.  
  
-   [out, retval] `* pObject`  
  
     The COM object that is created.  
  
## Return Value  
 `HRESULT`  
  
## Remarks  
 This method attempts to create the COM object of the Fusion activation context of the product, if one exists, from the ProgID specified by the `bstrObjectName` parameter. For example, if you try to create the native reader object using the `IIS_PRODUCT_OS_SERVICE` product type and version object, the method returns the operating system’s native reader object. However, if the version object is of type `IIS_PRODUCT_EXPRESS`, the method first applies the Fusion manifest context for the product, and then creates the COM object and returns the native reader for that version of IIS Express.  
  
## See Also  
 [GetPropertyValue](../../extensions\express-api-ref/getpropertyvalue.md)   
 [CreateObjectFromCLSID](../../extensions\express-api-ref/createobjectfromclsid.md)   
 [ApplyIISEnvironmentVariables](../../extensions\express-api-ref/applyiisenvironmentvariables.md)   
 [ClearIISEnvironmentVariables](../../extensions\express-api-ref/cleariisenvironmentvariables.md)   
 [ApplyManifestContext](../../extensions\express-api-ref/applymanifestcontext.md)   
 [ClearManifestContext](../../extensions\express-api-ref/clearmanifestcontext.md)