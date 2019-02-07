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
 [CGlobalModule](../../web-development-reference\native-code-api-reference/cglobalmodule-class.md) derived classes will receive an [IHttpModuleRegistrationInfo](../../web-development-reference\native-code-api-reference/ihttpmoduleregistrationinfo-interface.md) pointer and an [IHttpServer](../../web-development-reference\native-code-api-reference/ihttpserver-interface.md) pointer as parameters to the [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function. Retrieve an [IHttpTraceContext](../../web-development-reference\native-code-api-reference/ihttptracecontext-interface.md) pointer by calling the [IHttpServer::GetTraceContext](../../web-development-reference\native-code-api-reference/ihttpserver-gettracecontext-method.md) method, and retrieve an `HTTP_MODULE_ID` by calling the [IHttpModuleRegistrationInfo::GetId](../../web-development-reference\native-code-api-reference/ihttpmoduleregistrationinfo-getid-method.md) method. Declare and initialize an [HTTP_TRACE_CONFIGURATION](../../web-development-reference\native-code-api-reference/http-trace-configuration-structure.md) structure, and call the [IHttpTraceContext::SetTraceConfiguration](../../web-development-reference\native-code-api-reference/ihttptracecontext-settraceconfiguration-method.md) method with the address of this structure and the `HTTP_MODULE_ID` to filter the events received during [CGlobalModule::OnGlobalTraceEvent](../../web-development-reference\native-code-api-reference/cglobalmodule-onglobaltraceevent-method.md) event handlers.  
  
 Subsequent `CGlobalModule::OnGlobalTraceEvent` calls receive an [IGlobalTraceEventProvider](../../web-development-reference\native-code-api-reference/iglobaltraceeventprovider-interface.md) pointer, and the Boolean value returned by the `CheckSubscription` method on this pointer is determined by the `HTTP_TRACE_CONFIGURATION` settings set above: a value of `true` means that the module should probably handle the event, and a value of `false` means that the module should probably ignore the event. However, some modules may handle events even if `CheckSubscription` returns `false`.  
  
 `CheckSubscription` behavior depends on implementation. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
-   Classes that provide HTTP trace events return `true` if the trace module should be notified of the event. Otherwise, these classes return the value from the global trace settings.  
  
-   Classes that provide global trace events return the value from the global trace settings.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_TRACE_EVENT](../../web-development-reference\native-code-api-reference/request-processing-constants.md) events and declares and initializes an [HTTP_TRACE_CONFIGURATION](../../web-development-reference\native-code-api-reference/http-trace-configuration-structure.md) structure. The module then writes the `CheckSubscription` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
<!-- TODO: review snippet reference  [!CODE [IGlobalTraceEventProvider#2](IGlobalTraceEventProvider#2)]  -->  
  
 The above code writes a new event to the Event Viewer, where the Data box contains XML similar to the following.  
  
```  
<eventProvider subscription="true" />  
```  
  
 Your module must export the [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IGlobalTraceEventProvider Interface](../../web-development-reference\native-code-api-reference/iglobaltraceeventprovider-interface.md)