---
title: "IHttpContext::PostCompletion Method"
ms.date: "10/07/2016"
ms.assetid: 94fb5164-1bd1-57bb-255d-cb6ff409cd12
---
# IHttpContext::PostCompletion Method
Indicates the completion of asynchronous work and requests that IIS queue execution to the thread pool.  
  
## Syntax  
  
```cpp  
virtual HRESULT PostCompletion(  
   IN DWORD cbBytes  
) = 0;  
```  
  
### Parameters  
 `cbBytes`  
 [IN] A `DWORD` that contains the number of bytes for the completion.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 An HTTP module can use the `PostCompletion` method to indicate that an asynchronous operation has completed and request that IIS resume processing. The entry point for the original notification will be reentered to allow the notification to capture the completion and return the appropriate notification status. IIS queues the execution to the thread pool, and execution will occur on a thread from the thread pool. This behavior is unlike the behavior of the [IndicateCompletion](../../web-development-reference\native-code-api-reference/ihttpcontext-indicatecompletion-method.md) method, which continues on the current thread.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpContext Interface](../../web-development-reference\native-code-api-reference/ihttpcontext-interface.md)   
 [IHttpContext::IndicateCompletion Method](../../web-development-reference\native-code-api-reference/ihttpcontext-indicatecompletion-method.md)