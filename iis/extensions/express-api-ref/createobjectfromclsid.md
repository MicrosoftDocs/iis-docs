---
title: "CreateObjectFromCLSID | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 94eaf219-d206-4f90-9eef-940a96f2d9a7
caps.latest.revision: 8
manager: "wpickett"
---
# CreateObjectFromCLSID
Creates a COM object using the specified class ID (CLSID).  
  
## Syntax  
  
```cpp  
    HRESULT  
    CreateObjectFromCLSID(  
        [in] CLSID clsidObject,  
        [out, retval] VARIANT * pObject  
    );  
  
```  
  
#### Parameters  
  
-   [in] `clsidObject`  
  
     The class ID (CLSID) of the COM object to create.  
  
-   [out, retval] `* pObject`  
  
     The COM object that is created.  
  
## Return Value  
 `HRESULT`  
  
## Remarks  
 This method attempts to create the COM object of the Fusion activation context of the product, if one exists, from the CLSID specified by the `clsidObject` parameter. For example, if you try to create the native reader object using the `IIS_PRODUCT_OS_SERVICE` product type and version object, you will get the operating system’s native reader object. However, if the version object is of type `IIS_PRODUCT_EXPRESS`, the method first applies the Fusion manifest context for the product, and then creates the COM object and returns the native reader for that version of IIS Express.  
  
## See Also  
 [GetPropertyValue](../../extensions\express-api-ref/getpropertyvalue.md)   
 [CreateObjectFromProgId](../../extensions\express-api-ref/createobjectfromprogid.md)   
 [ApplyIISEnvironmentVariables](../../extensions\express-api-ref/applyiisenvironmentvariables.md)   
 [ClearIISEnvironmentVariables](../../extensions\express-api-ref/cleariisenvironmentvariables.md)   
 [ApplyManifestContext](../../extensions\express-api-ref/applymanifestcontext.md)   
 [ClearManifestContext](../../extensions\express-api-ref/clearmanifestcontext.md)