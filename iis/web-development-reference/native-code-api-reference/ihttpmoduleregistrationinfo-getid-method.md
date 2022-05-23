---
title: "IHttpModuleRegistrationInfo::GetId Method"
description: "Describes the IHttpModuleRegistrationInfo::GetId method and details its syntax, parameters, return value, remarks, code example, and requirements."
ms.date: 10/07/2016
ms.assetid: 3b6e7b30-e480-8d34-8f75-196430e3951e
---
# IHttpModuleRegistrationInfo::GetId Method
Returns the unique identifier for the registered module.  
  
## Syntax  
  
```cpp  
virtual HTTP_MODULE_ID GetId(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 An `HTTP_MODULE_ID` pointer.  
  
> [!NOTE]
>  `HTTP_MODULE_ID` is a type definition of a `void` pointer.  
  
## Remarks  
 The `GetId` return value depends on implementation. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
 Starting with [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)], developers can create HTTP modules in native code, exposing a [PFN_REGISTERMODULE](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function for both global event and specific request processing. For more information, see [Designing Native-Code HTTP Modules](../../web-development-reference/native-code-development-overview/designing-native-code-http-modules.md). When IIS services start, an internal `static` counter is initialized to 0 and is incremented by 1 every time a new module is loaded. Each registration module receives this unique value from the counter when the module is loaded, and this value is cast to an `HTTP_MODULE_ID` pointer and returned when the `GetId` method is called.  
  
## Notes for Implementers  
 [IHttpModuleRegistrationInfo](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-interface.md) implementers are responsible for creating a scheme that creates a unique identifier for each module that is loaded, and returning that identifier when the `GetId` method is called. Additionally, implementers are also required to verify that each identifier is internally immutable during the life of a module. Finally, implementers are responsible for any cleanup of both instance and `static` data when modules are released and when services perform shutdown procedures, respectively.  
  
## Notes for Callers  
 `IHttpModuleRegistrationInfo` clients must not call `delete` on the returned `HTTP_MODULE_ID` or modify the data that this pointer contains in any way, because `IHttpModuleRegistrationInfo` implementers are responsible for management of this data.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_TRACE_EVENT](../../web-development-reference/native-code-api-reference/request-processing-constants.md) and events, and declares and initializes an [HTTP_TRACE_CONFIGURATION](../../web-development-reference/native-code-api-reference/http-trace-configuration-structure.md) structure that contains tracing information for all events. The example then calls the `GetId` method to retrieve the `HTTP_MODULE_ID` pointer.  
  
 [!code-cpp[IHttpModuleRegistrationInfo#2](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpModuleRegistrationInfo/cpp/GetId.cpp#2)]  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpModuleRegistrationInfo Interface](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-interface.md)
