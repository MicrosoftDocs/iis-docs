---
title: "IHttpModuleRegistrationInfo::GetId Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 3b6e7b30-e480-8d34-8f75-196430e3951e
caps.latest.revision: 25
author: "shirhatti"
manager: "wpickett"
---
# IHttpModuleRegistrationInfo::GetId Method
Returns the unique identifier for the registered module.  
  
## Syntax  
  
```cpp  
virtual HTTP_MODULE_ID GetId(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 An `HTTP_MODULE_ID` pointer.  
  
> [!NOTE]
>  `HTTP_MODULE_ID` is a type definition of a `void` pointer.  
  
## Remarks  
 The `GetId` return value depends on implementation. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
 Starting with [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)], developers can create HTTP modules in native code, exposing a [PFN_REGISTERMODULE](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function for both global event and specific request processing. For more information, see [Designing Native-Code HTTP Modules](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/designing-native-code-http-modules.md). When IIS services start, an internal `static` counter is initialized to 0 and is incremented by 1 every time a new module is loaded. Each registration module receives this unique value from the counter when the module is loaded, and this value is cast to an `HTTP_MODULE_ID` pointer and returned when the `GetId` method is called.  
  
## Notes for Implementers  
 [IHttpModuleRegistrationInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-interface.md) implementers are responsible for creating a scheme that creates a unique identifier for each module that is loaded, and returning that identifier when the `GetId` method is called. Additionally, implementers are also required to verify that each identifier is internally immutable during the life of a module. Finally, implementers are responsible for any cleanup of both instance and `static` data when modules are released and when services perform shutdown procedures, respectively.  
  
## Notes for Callers  
 `IHttpModuleRegistrationInfo` clients must not call `delete` on the returned `HTTP_MODULE_ID` or modify the data that this pointer contains in any way, because `IHttpModuleRegistrationInfo` implementers are responsible for management of this data.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_TRACE_EVENT](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) and events, and declares and initializes an [HTTP_TRACE_CONFIGURATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/http-trace-configuration-structure.md) structure that contains tracing information for all events. The example then calls the `GetId` method to retrieve the `HTTP_MODULE_ID` pointer.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpModuleRegistrationInfo#2](IHttpModuleRegistrationInfo#2)]  -->  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpModuleRegistrationInfo Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-interface.md)