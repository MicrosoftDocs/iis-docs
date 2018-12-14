---
title: "IHttpContext4::GetRequestStartTime Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: e7af95c6-d1f5-4c0e-9a08-14374586a7c7
caps.latest.revision: 3
author: "shirhatti"
ms.author: "robmcm"
manager: "wpickett"
---
# IHttpContext4::GetRequestStartTime Method
Retrieves the start time of the request in milliseconds.  
  
## Syntax  
  
```  
virtual ULONGLONG GetRequestStartTime(  
   VOID  
) = 0;  
```  
  
```csharp  
  
```  
  
#### Parameters  
 This method accepts no parameters.  
  
## Return Value  
 A ULONGLONG which contains the start time of the request as specified by GetTickCount64(), which is the offset in milliseconds since the system was started.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Product|IIS 10.0|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpContext4 Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext4-interface.md)   
 [GetTickCount64 Method](http://msdn.microsoft.com/en-us/3ebf05b9-cc53-43ae-bbcb-7841793a9d84)