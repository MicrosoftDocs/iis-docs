---
title: "REQUEST_NOTIFICATION_STATUS Enumeration"
ms.date: "10/07/2016"
ms.assetid: 318f6aef-c052-9021-b89f-fbcfe9caf014
---
# REQUEST_NOTIFICATION_STATUS Enumeration
Defines the return values for request-level notifications.  
  
## Syntax  
  
```cpp  
typedef enum REQUEST_NOTIFICATION_STATUS{  
   RQ_NOTIFICATION_CONTINUE,  
   RQ_NOTIFICATION_PENDING,  
   RQ_NOTIFICATION_FINISH_REQUEST  
};  
```  
  
## Members  
  
|Member name|Description|  
|-----------------|-----------------|  
|`RQ_NOTIFICATION_CONTINUE`|Indicates that IIS should continue processing additional request-level notifications.|  
|`RQ_NOTIFICATION_PENDING`|Indicates that an asynchronous notification is pending and returns request-level processing to IIS.|  
|`RQ_NOTIFICATION_FINISH_REQUEST`|Indicates that IIS has finished processing request-level notifications and should not process any additional request-level notifications.|  
  
## Remarks  
 The members of the `REQUEST_NOTIFICATION_STATUS` enumeration are used as return values from request-level notifications, and the members help to control process flow within the integrated request-processing pipeline. For example, returning `RQ_NOTIFICATION_CONTINUE` from a request-level notification handler instructs IIS to continue processing additional request-level notifications, whereas returning `RQ_NOTIFICATION_FINISH_REQUEST` from a request-level notification handler informs IIS that request-level processing is complete and IIS should not process additional request-level notifications. Modules that implement request handling should return `RQ_NOTIFICATION_FINISH_REQUEST` when an error occurs.  
  
## Example  
 The following example implements a `RQ_BEGIN_REQUEST` handler. If the request is not an HTML file, the example returns `RQ_NOTIFICATION_CONTINUE` and normal processing occurs. When the counter value has a zero remainder, the requested file is replaced by a string returned by the [IHttpResponse::WriteEntityChunkByReference](../../web-development-reference/native-code-api-reference/ihttpresponse-writeentitychunkbyreference-method.md) method and the example returns `RQ_NOTIFICATION_FINISH_REQUEST`. If an error occurs, the example logs the error and returns `RQ_NOTIFICATION_FINISH_REQUEST`.  
  
 [!code-cpp[_RaiseEvnt#2](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/_RaiseEvnt/cpp/IHttpResponseWriteEntityChunkByReference.cpp#2)]  
[!code-cpp[_RaiseEvnt#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/_RaiseEvnt/cpp/IHttpResponseWriteEntityChunkByReference.cpp#1)]  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Enumerations](../../web-development-reference/native-code-api-reference/web-server-core-enumerations.md)   
 [GLOBAL_NOTIFICATION_STATUS Enumeration](../../web-development-reference/native-code-api-reference/global-notification-status-enumeration.md)
