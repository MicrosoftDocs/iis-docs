---
title: "Request-Processing Constants"
ms.date: "10/07/2016"
ms.assetid: 42be02f0-5c30-4a82-8373-47c8b744a75a
---
# Request-Processing Constants

This topic describes the constants that are defined in the Httpserv.h header file.  
  
## Request Processing Constants  
  
### Deterministic Request-Level Notification Constants  

 The following constants are used with the [IHttpModuleRegistrationInfo::SetRequestNotifications](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-setrequestnotifications-method.md) method to specify which sequential request-level notifications an HTTP module will process.  
  
|Constant|Bitmask|Description|  
|--------------|-------------|-----------------|  
|RQ_BEGIN_REQUEST|0x00000001|Indicates that IIS began processing a request.|  
|RQ_AUTHENTICATE_REQUEST|0x00000002|Indicates that IIS authenticated a request.|  
|RQ_AUTHORIZE_REQUEST|0x00000004|Indicates that IIS authorized a request.|  
|RQ_RESOLVE_REQUEST_CACHE|0x00000008|Indicates that IIS satisfied a request from the cache.|  
|RQ_MAP_REQUEST_HANDLER|0x00000010|Indicates that IIS mapped the handler for request.|  
|RQ_ACQUIRE_REQUEST_STATE|0x00000020|Indicates that IIS acquired the state for a request.|  
|RQ_PRE_EXECUTE_REQUEST_HANDLER|0x00000040|Indicates that IIS will execute a request handler.|  
|RQ_EXECUTE_REQUEST_HANDLER|0x00000080|Indicates that IIS executed a request handler.|  
|RQ_RELEASE_REQUEST_STATE|0x00000100|Indicates that IIS released the state for a request.|  
|RQ_UPDATE_REQUEST_CACHE|0x00000200|Indicates that IIS updated the cache.|  
|RQ_LOG_REQUEST|0x00000400|Indicates that IIS logged the request.|  
|RQ_END_REQUEST|0x00000800|Indicates that IIS ended a request.|  
  
### Nondeterministic Request-Level Notification Constants  

 The following constants are used with the [IHttpModuleRegistrationInfo::SetRequestNotifications](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-setrequestnotifications-method.md) method to specify which nonsequential request-level notifications an HTTP module will process.  
  
|Constant|Bitmask|Description|  
|--------------|-------------|-----------------|  
|RQ_CUSTOM_NOTIFICATION|0x10000000|Indicates that a custom request-level notification occurred.|  
|RQ_SEND_RESPONSE|0x20000000|Indicates that IIS sent a response.|  
|RQ_READ_ENTITY|0x40000000|Indicates that IIS read data from the request entity.|  
|RQ_MAP_PATH|0x80000000|Indicates that IIS mapped a URL to a physical path.|  
  
### Global Notification Constants  

 The following constants are used with the [IHttpModuleRegistrationInfo::SetGlobalNotifications](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-setglobalnotifications-method.md) method to specify which global-level notifications an HTTP module will process.  
  
|Constant|Bitmask|Description|  
|--------------|-------------|-----------------|  
|GL_STOP_LISTENING|0x00000002|Indicates that IIS stopped accepting new requests.|  
|GL_CACHE_CLEANUP|0x00000004|Indicates that IIS cleaned up the cache.|  
|GL_CACHE_OPERATION|0x00000010|Indicates that a cache operation occurred.|  
|GL_HEALTH_CHECK|0x00000020|Indicates that a health check occurred.|  
|GL_CONFIGURATION_CHANGE|0x00000040|Indicates that the IIS configuration changed.|  
|GL_FILE_CHANGE|0x00000080|Indicates that a file changed.|  
|GL_PRE_BEGIN_REQUEST|0x00000100|Indicates that a request will enter the integrated request-processing pipeline.|  
|GL_APPLICATION_START|0x00000200|Indicates that an application started.|  
|GL_APPLICATION_RESOLVE_MODULES|0x00000400|Indicates that IIS resolved the modules for an application.|  
|GL_APPLICATION_STOP|0x00000800|Indicates that an application exited.|  
|GL_RSCA_QUERY|0x00001000|Indicates that a Run-Time Status and Control query was issued.|  
|GL_TRACE_EVENT|0x00002000|Indicates that an IIS trace event was raised.|  
|GL_CUSTOM_NOTIFICATION|0x00004000|Indicates that a custom global-level notification occurred.|  
|GL_THREAD_CLEANUP|0x00008000|Indicates that IIS cleaned up a thread.|  
  
### Priority Alias Constants  

 The following constants are used with the [IHttpModuleRegistrationInfo::SetPriorityForRequestNotification](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-setpriorityforrequestnotification-method.md) and [IHttpModuleRegistrationInfo::SetPriorityForGlobalNotification](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-setpriorityforglobalnotification-method.md) methods to specify the priority level for notifications.  
  
> [!NOTE]
>  The priority levels are inverted for `RQ_SEND_RESPONSE` notifications.  
  
|Constant|Value|Description|  
|--------------|-----------|-----------------|  
|PRIORITY_ALIAS_FIRST|L"FIRST"|Indicates that the module should be processed before all other modules. For `RQ_SEND_RESPONSE` notifications, indicates that the module should be processed after all other modules.|  
|PRIORITY_ALIAS_HIGH|L"HIGH"|Indicates that the module should be processed with high priority. For `RQ_SEND_RESPONSE` notifications, indicates that the module should be processed with low priority.|  
|PRIORITY_ALIAS_MEDIUM|L"MEDIUM"|Indicates that the module should be processed with medium priority.|  
|PRIORITY_ALIAS_LOW|L"LOW"|Indicates that the module should be processed with low priority. For `RQ_SEND_RESPONSE` notifications, indicates that the module should be processed with high priority.|  
|PRIORITY_ALIAS_LAST|L"LAST"|Indicates that the module should be processed after all other modules. For `RQ_SEND_RESPONSE` notifications, indicates that the module should be processed before all other modules.|  
  
### Context-Cloning Constants  

 The following constants are used with the [IHttpContext::CloneContext](../../web-development-reference/native-code-api-reference/ihttpcontext-clonecontext-method.md) method to specify which sections of the context should be cloned.  
  
|Constant|Value|Description|  
|--------------|-----------|-----------------|  
|CLONE_FLAG_BASICS|0x01|Indicates that the URL, query string, and HTTP method should be cloned.|  
|CLONE_FLAG_HEADERS|0x02|Indicates that the request headers should be cloned.|  
|CLONE_FLAG_ENTITY|0x04|Indicates that the entity body should be cloned.|  
|CLONE_FLAG_NO_PRECONDITION|0x08|Indicates that any "range" and "if-" headers for the request should not be included in the clone operation.|  
|CLONE_FLAG_NO_DAV|0x10|Indicates that any WebDAV headers for the request should not be included in the clone operation.|  
  
### Request-Execution Constants  

 The following constants are used with the [IHttpContext::ExecuteRequest](../../web-development-reference/native-code-api-reference/ihttpcontext-executerequest-method.md) method to specify the execution behavior for a child context.  
  
|Constant|Value|Description|  
|--------------|-----------|-----------------|  
|EXECUTE_FLAG_NO_HEADERS|0x01|Indicates that the HTTP headers for the child request should be suppressed.|  
|EXECUTE_FLAG_IGNORE_CURRENT_INTERCEPTOR|0x02|Indicates that the current script map handler for this request chain should be ignored.|  
|EXECUTE_FLAG_IGNORE_APPPOOL|0x04|Indicates that the request should be executed, even if the child request is not in the same application pool.|  
|EXECUTE_FLAG_DISABLE_CUSTOM_ERROR|0x08|Indicates that the custom errors for the child request should be disabled.|  
|EXECUTE_FLAG_SAME_URL|0x10|Indicates that the URL for the child request is the same as the URL for the parent request.|  
|EXECUTE_FLAG_BUFFER_RESPONSE|0x20|Indicates that the child response should be returned to the parent request and not be flushed.|  
|EXECUTE_FLAG_HTTP_CACHE_ELIGIBLE|0x40|Indicates that the child response is still eligible for caching by Http.sys.|  
  
## See Also  

 [Web Server Core Constants](../../web-development-reference/native-code-api-reference/web-server-core-constants.md)   
 [Web Server Core API Reference](../../web-development-reference/native-code-api-reference/web-server-core-api-reference.md)   
 [IHttpContext::CloneContext Method](../../web-development-reference/native-code-api-reference/ihttpcontext-clonecontext-method.md)   
 [IHttpContext::ExecuteRequest Method](../../web-development-reference/native-code-api-reference/ihttpcontext-executerequest-method.md)   
 [IHttpModuleRegistrationInfo::SetGlobalNotifications Method](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-setglobalnotifications-method.md)   
 [IHttpModuleRegistrationInfo::SetPriorityForRequestNotification Method](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-setpriorityforrequestnotification-method.md)   
 [IHttpModuleRegistrationInfo::SetPriorityForGlobalNotification Method](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-setpriorityforglobalnotification-method.md)   
 [IHttpModuleRegistrationInfo::SetRequestNotifications Method](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-setrequestnotifications-method.md)
