---
title: "IHttpModuleRegistrationInfo Interface"
ms.date: "10/07/2016"
ms.assetid: 9104bb5a-ed5c-4584-605f-fd1d2a96ee07
---
# IHttpModuleRegistrationInfo Interface

Retrieves and sets a module's registration information.  
  
## Syntax  
  
```cpp  
class IHttpModuleRegistrationInfo  
```  
  
## Methods  

 The following table lists the methods exposed by the `IHttpModuleRegistrationInfo` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetId](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-getid-method.md)|Returns the unique identifier for the registered module.|  
|[GetName](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-getname-method.md)|Retrieves the module name.|  
|[SetGlobalNotifications](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-setglobalnotifications-method.md)|Registers the global-level notifications for a module.|  
|[SetPriorityForGlobalNotification](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-setpriorityforglobalnotification-method.md)|Sets the global-level priority for a module.|  
|[SetPriorityForRequestNotification](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-setpriorityforrequestnotification-method.md)|Sets the request-level priority for a module.|  
|[SetRequestNotifications](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-setrequestnotifications-method.md)|Registers the request-level notifications for a module.|  
  
## Derived Classes  

 This interface contains no derived classes.  
  
## Remarks  

 An `IHttpModuleRegistrationInfo` interface is created and passed to a module's exported [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function when the module is loaded by [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)]. This interface primarily defines the global-level and request-level priorities and notifications for a module.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  

 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)   
 [PFN_REGISTERMODULE Function](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md)
