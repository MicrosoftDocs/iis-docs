---
title: "IHttpContext4::GetRequestElapsedTime Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 8020886b-c917-44b1-9cfc-c03973b3fca1
caps.latest.revision: 3
author: "shirhatti"
ms.author: "robmcm"
manager: "wpickett"
---
# IHttpContext4::GetRequestElapsedTime Method
Retrieves the elapsed time of the request in milliseconds.  
  
## Syntax  
  
```  
virtual ULONGLONG GetRequestElapsedTime(  
   VOID  
) = 0;  
```  
  
```csharp  
  
```  
  
#### Parameters  
 This method accepts no parameters.  
  
## Return Value  
 A ULONGLONG which contains the elapsed time in milliseconds since the request was initiated.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Product|IIS 10.0|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpContext4 Interface](../../web-development-reference\native-code-api-reference/ihttpcontext4-interface.md)