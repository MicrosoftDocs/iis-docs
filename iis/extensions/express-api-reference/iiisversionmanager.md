---
title: "IIISVersionManager"
ms.date: "10/07/2016"
ms.assetid: 54c836ae-d188-4ea2-bc00-2729d38a5edf
---
# IIISVersionManager
Represents a COM object that enables IIS versions to be queried and manipulated.  
  
## Syntax  
  
```cpp  
interface IIISVersionManager : IUnknown  
{  
    HRESULT  
    GetVersionObject(  
        [in, string] BSTR  bstrVersion,  
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
 [GetVersionObject](../../extensions/express-api-reference/getversionobject.md)   
 [GetAllVersionObjects](../../extensions/express-api-reference/getallversionobjects.md)
