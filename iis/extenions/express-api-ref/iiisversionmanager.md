---
title: "IIISVersionManager | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 54c836ae-d188-4ea2-bc00-2729d38a5edf
caps.latest.revision: 10
manager: "wpickett"
---
# IIISVersionManager
Represents a COM object that enables IIS versions to be queried and manipulated.  
  
## Syntax  
  
```cpp  
interface IIISVersionManager : IUnknown  
{  
    HRESULT  
    GetVersionObject(  
        [in, string] BSTR  bstrVersion,  
        [in] IIS_PRODUCT_TYPE dwProductType,  
        [out, retval] IIISVersion ** ppElement  
    );  
  
    HRESULT  
    GetAllVersionObjects(  
        [out, retval] SAFEARRAY(VARIANT) * pVersionsArray  
    );  
};  
  
```  
  
## Remarks  
 The computer hosts a top-level `IIISVersionManager` object. You must instantiate this object using `CoCreateInstance`.  
  
## See Also  
 [GetVersionObject](../../extenions\express-api-ref/getversionobject.md)   
 [GetAllVersionObjects](../../extenions\express-api-ref/getallversionobjects.md)