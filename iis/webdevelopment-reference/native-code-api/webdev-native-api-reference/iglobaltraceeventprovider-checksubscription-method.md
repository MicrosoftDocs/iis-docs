---
title: "IGlobalTraceEventProvider::CheckSubscription Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 84096bba-9d37-fafd-4b74-1f3c97651eea
caps.latest.revision: 29
author: "shirhatti"
manager: "wpickett"
---
# IGlobalTraceEventProvider::CheckSubscription Method
Returns a value that indicates whether the trace event is intended for the module.  
  
## Syntax  
  
```cpp  
virtual BOOL CheckSubscription(  
   IN HTTP_MODULE_ID ModuleId  
) = 0;  
```  
  
#### Parameters  
 `ModuleId`  
 [IN] An `HTTP_MODULE_ID` pointer.  
  
> [!NOTE]
>  `HTTP_MODULE_ID` is a type definition of a `void` pointer.  
  
## Return Value  
 `true` if the trace event is intended for the module; otherwise, `false`.  
  
## Remarks  
 [CGlobalModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-class.md) derived classes will receive an [IHttpModuleRegistrationInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-interface.md) pointer and an [IHttpServer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-interface.md) pointer as parameters to the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. Retrieve an [IHttpTraceContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptracecontext-interface.md) pointer by calling the [IHttpServer::GetTraceContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-gettracecontext-method.md) method, and retrieve an `HTTP_MODULE_ID` by calling the [IHttpModuleRegistrationInfo::GetId](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-getid-method.md) method. Declare and initialize an [HTTP_TRACE_CONFIGURATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/http-trace-configuration-structure.md) structure, and call the [IHttpTraceContext::SetTraceConfiguration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptracecontext-settraceconfiguration-method.md) method with the address of this structure and the `HTTP_MODULE_ID` to filter the events received during [CGlobalModule::OnGlobalTraceEvent](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobaltraceevent-method.md) event handlers.  
  
 Subsequent `CGlobalModule::OnGlobalTraceEvent` calls receive an [IGlobalTraceEventProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobaltraceeventprovider-interface.md) pointer, and the Boolean value returned by the `CheckSubscription` method on this pointer is determined by the `HTTP_TRACE_CONFIGURATION` settings set above: a value of `true` means that the module should probably handle the event, and a value of `false` means that the module should probably ignore the event. However, some modules may handle events even if `CheckSubscription` returns `false`.  
  
 `CheckSubscription` behavior depends on implementation. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
-   Classes that provide HTTP trace events return `true` if the trace module should be notified of the event. Otherwise, these classes return the value from the global trace settings.  
  
-   Classes that provide global trace events return the value from the global trace settings.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_TRACE_EVENT](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) events and declares and initializes an [HTTP_TRACE_CONFIGURATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/http-trace-configuration-structure.md) structure. The module then writes the `CheckSubscription` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
<!-- TODO: review snippet reference  [!CODE [IGlobalTraceEventProvider#2](IGlobalTraceEventProvider#2)]  -->  
  
 The above code writes a new event to the Event Viewer, where the Data box contains XML similar to the following.  
  
```  
<eventProvider subscription="true" />  
```  
  
 Your module must export the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IGlobalTraceEventProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobaltraceeventprovider-interface.md)