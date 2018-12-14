---
title: "IProcessHost Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 5bfd0e30-2f05-ddd4-307f-810158e93339
caps.latest.revision: 21
author: "shirhatti"
manager: "wpickett"
---
# IProcessHost Interface
Defines the set of processwide functionality that every host of the application manager must implement.  
  
## Syntax  
  
```cpp  
struct IProcessHost : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IProcessHost` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[IProcessHost::EnumerateAppDomains](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprocesshost-enumerateappdomains-method.md)|Retrieves a pointer to an [IAppDomainInfoEnum](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iappdomaininfoenum-interface.md) interface.|  
|[IProcessHost::Shutdown](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprocesshost-shutdown-method.md)|Sends a request to terminate all applications in an application domain.|  
|[IProcessHost::ShutdownApplication](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprocesshost-shutdownapplication-method.md)|Terminates the specified application.|  
|[IProcessHost::StartApplication](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprocesshost-startapplication-method.md)|Starts the specified application.|  
  
## Properties  
 This interface contains no properties.  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IProcessHost`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Webhost.h|  
  
## See Also  
 [Windows Process Activation Service Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/windows-process-activation-service-interfaces.md)