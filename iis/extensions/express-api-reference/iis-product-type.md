---
title: "IIS_PRODUCT_TYPE"
ms.date: "10/07/2016"
ms.assetid: d6d67b0d-91e3-4856-b740-eb221cef2621
---
# IIS_PRODUCT_TYPE
Enumerates the IIS types (IIS or IIS Express) that are installed on a computer.  
  
## Syntax  
  
```cpp  
typedef enum  
{  
    IIS_PRODUCT_OS_SERVICE=0,   
    IIS_PRODUCT_DEPRECATED=1,  
    IIS_PRODUCT_EXPRESS=2  
} IIS_PRODUCT_TYPE;  
  
```  
  
## Member Descriptions  
  
- `IIS_PRODUCT_OS_SERVICE`. Full IIS product.  
  
- `IIS_PRODUCT_DEPRECATED`. Deprecated.  
  
- `IIS_PRODUCT_EXPRESS`. IIS Express.  
  
## See Also  
 [GetVersionObject](../../extensions/express-api-reference/getversionobject.md)
