---
title: "Web Server Core Enumerations"
ms.date: "10/07/2016"
ms.assetid: 6ea0ab85-153f-4c51-9d2e-4c963b38210a
---
# Web Server Core Enumerations
This section describes the Web Server Core and integrated request-processing pipeline enumerations.  
  
## In This Section  
 The following table lists the enumerations exposed by the integrated request-processing pipeline.  
  
|Enumeration|Description|  
|-----------------|-----------------|  
|[CACHE_OPERATION](../../web-development-reference/native-code-api-reference/cache-operation-enumeration.md)|Defines the enumeration values for cache operations.|  
|[GLOBAL_NOTIFICATION_STATUS](../../web-development-reference/native-code-api-reference/global-notification-status-enumeration.md)|Defines the return values for global-level notifications.|  
|[HTTP_TRACE_TYPE](../../web-development-reference/native-code-api-reference/http-trace-type-enumeration.md)|Determines what data type the [HTTP_TRACE_EVENT_ITEM](../../web-development-reference/native-code-api-reference/http-trace-event-item-structure.md) structure maintains.|  
|[REQUEST_NOTIFICATION_STATUS](../../web-development-reference/native-code-api-reference/request-notification-status-enumeration.md)|Defines the return values for request-level notifications.|  
  
## Remarks  
 All global-level notification handlers are required to return a value from the `GLOBAL_NOTIFICATION_STATUS` enumeration, and all request-level notification handlers are required to return a value from the `REQUEST_NOTIFICATION_STATUS` enumeration.  
  
 You can use the values from the `HTTP_TRACE_TYPE` enumeration to define the type of data that is contained within an `HTTP_TRACE_EVENT_ITEM` structure.  
  
 When you call the [ICacheProvider::GetCacheOperation](../../web-development-reference/native-code-api-reference/icacheprovider-getcacheoperation-method.md) method, values from the `CACHE_OPERATION` enumeration indicate the resulting cache event.  
  
## See Also  
 [Web Server Core API Reference](../../web-development-reference/native-code-api-reference/web-server-core-api-reference.md)   
 [HTTP_TRACE_EVENT Structure](../../web-development-reference/native-code-api-reference/http-trace-event-structure.md)   
 [HTTP_TRACE_EVENT_ITEM Structure](../../web-development-reference/native-code-api-reference/http-trace-event-item-structure.md)