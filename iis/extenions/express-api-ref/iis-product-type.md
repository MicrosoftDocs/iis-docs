---
title: "IIS_PRODUCT_TYPE | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: d6d67b0d-91e3-4856-b740-eb221cef2621
caps.latest.revision: 9
manager: "wpickett"
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
  
-   `IIS_PRODUCT_OS_SERVICE`. Full IIS product.  
  
-   `IIS_PRODUCT_DEPRECATED`. Deprecated.  
  
-   `IIS_PRODUCT_EXPRESS`. IIS Express.  
  
## See Also  
 [GetVersionObject](../../extenions\express-api-ref/getversionobject.md)