---
title: "IHttpContext4::GetRequestStartTime Method"
description: Learn how the IHttpContext4::GetRequestStartTime method retrieves the start time of the request in milliseconds. 
ms.date: "10/07/2016"
ms.assetid: e7af95c6-d1f5-4c0e-9a08-14374586a7c7
ms.author: "robmcm"
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
  
### Parameters  
 This method accepts no parameters.  
  
## Return Value  
 A ULONGLONG which contains the start time of the request as specified by GetTickCount64(), which is the offset in milliseconds since the system was started.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Product|IIS 10.0|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpContext4 Interface](../../web-development-reference/native-code-api-reference/ihttpcontext4-interface.md)   
 [GetTickCount64 Method](https://msdn.microsoft.com/3ebf05b9-cc53-43ae-bbcb-7841793a9d84)
