---
title: "PFN_ASYNC_COMPLETION function"
ms.date: "10/07/2016"
ms.assetid: b67d92d6-e099-4a9a-9862-993f00ff395b
---
# PFN_ASYNC_COMPLETION function

Defines the asynchronous completion function prototype.  
  
## Syntax  
  
```cpp  
typedef REQUEST_NOTIFICATION_STATUS(WINAPI* PFN_ASYNC_COMPLETION)(  
   IHttpContext3* pHttpContext,  
   IHttpCompletionInfo2* pCompletionInfo,  
   VOID* pvCompletionContext  
);  
```  
  
### Parameters  

 `pHttpContext`  
 A pointer to an [IHttpContext3](../../web-development-reference/native-code-api-reference/ihttpcontext3-interface.md) interface.  
  
 `pCompletionInfo`  
 A pointer to an [IHttpCompletionInfo2](../../web-development-reference/native-code-api-reference/ihttpcompletioninfo2-interface.md) interface.  
  
 `pvCompletionCointext`  
 Points to the completion context information for the operation.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|
