---
title: "PFN_REGISTERMODULE Function | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 1c0cc3d8-ecf8-f11c-97a0-2b9743799c29
caps.latest.revision: 18
author: "shirhatti"
manager: "wpickett"
---
# PFN_REGISTERMODULE Function
Defines the `RegisterModule` function prototype for native-code HTTP modules.  
  
## Syntax  
  
```cpp  
typedef HRESULT(WINAPI* PFN_REGISTERMODULE)(  
   DWORD dwServerVersion,  
   IHttpModuleRegistrationInfo* pModuleInfo,  
   IHttpServer* pGlobalInfo  
);  
```  
  
#### Parameters  
 `dwServerVersion`  
 A `DWORD` that contains the IIS major version number.  
  
 `pModuleInfo`  
 A pointer to an [IHttpModuleRegistrationInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-interface.md) interface.  
  
 `pGlobalInfo`  
 A pointer to an [IHttpServer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
> [!NOTE]
>  Your module can return any valid `HRESULT` value, but it should return at least S_OK to indicate that your `RegisterModule` function was successful.  
  
## Remarks  
 `PFN_REGISTERMODULE` is a function prototype for the `RegisterModule` function that all HTTP modules are required to implement for their DLL entry point.  
  
 When you create an HTTP module, your module needs to add the following `RegisterModule` method:  
  
```  
HRESULT RegisterModule(  
   DWORD dwServerVersion,  
   IHttpModuleRegistrationInfo* pModuleInfo,  
   IHttpServer* pGlobalInfo  
)  
```  
  
 All HTTP modules must export their `RegisterModule` function in order for IIS to load the module. You can export the `RegisterModule` function by creating a module definition (.def) file for your DLL project or compiling the module by using the `/EXPORT:RegisterModule` switch.  
  
 Your `RegisterModule` function will need to use the `IHttpModuleRegistrationInfo` interface to register for notifications by using the [SetRequestNotifications](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setrequestnotifications-method.md) and [SetGlobalNotifications](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setglobalnotifications-method.md) methods. `RegisterModule` will also need to use `IHttpModuleRegistrationInfo` to register module priorities by using the [SetPriorityForRequestNotification](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setpriorityforrequestnotification-method.md) and [SetPriorityForGlobalNotification](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setpriorityforglobalnotification-method.md) methods.  
  
 The `dwServerVersion` parameter contains the major version number for the version of IIS that loads the module. For example, for IIS 7.0 the `dwServerVersion` parameter will contain a 7.  
  
 When IIS calls your `RegisterModule` function, it provides an `IHttpServer` interface, which your module can use to retrieve server-level information.  
  
> [!NOTE]
>  Trace events should not be raised (through [IHttpTraceContext::QuickTrace Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptracecontext-quicktrace-method.md) or any other means through [IHttpServer::GetTraceContext Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-gettracecontext-method.md)) inside of the `RegisterModule` function implementation. Raising trace events inside of RegisterModule can cause an access violation as it is too early in the request pipeline.  
  
## Example  
 The following code example demonstrates how to create a simple "Hello World" HTTP module. The module defines an exported `RegisterModule` function that passes an instance of an [IHttpModuleFactory](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulefactory-interface.md) interface to the [IHttpModuleRegistrationInfo::SetRequestNotifications](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setrequestnotifications-method.md) method and registers for the [RQ_BEGIN_REQUEST](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) notification. IIS uses the [IHttpModuleFactory::GetHttpModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulefactory-gethttpmodule-method.md) method to create an instance of a [CHttpModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-class.md) class and returns a success status. IIS also uses the [IHttpModuleFactory::Terminate](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulefactory-terminate-method.md) method to remove the factory from memory.  
  
 When an `RQ_BEGIN_REQUEST` notification occurs, IIS calls the module's [CHttpModule::OnBeginRequest](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-onbeginrequest-method.md) method to process the current request. `OnBeginRequest` clears the response buffer and modifies the MIME type for the response. The method then creates a data chunk that contains a "Hello World" string and returns the string to a Web client. Finally, the module returns a status indicator that notifies IIS that all notifications are finished and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [CHttpModuleHelloWorld#1](CHttpModuleHelloWorld#1)]  -->  
  
 Your module must export the `RegisterModule` function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpModuleRegistrationInfo Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-interface.md)   
 [IHttpModuleRegistrationInfo::SetGlobalNotifications Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setglobalnotifications-method.md)   
 [IHttpModuleRegistrationInfo::SetPriorityForGlobalNotification Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setpriorityforglobalnotification-method.md)   
 [IHttpModuleRegistrationInfo::SetPriorityForRequestNotification Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setpriorityforrequestnotification-method.md)   
 [IHttpModuleRegistrationInfo::SetRequestNotifications Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setrequestnotifications-method.md)   
 [IHttpServer Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-interface.md)