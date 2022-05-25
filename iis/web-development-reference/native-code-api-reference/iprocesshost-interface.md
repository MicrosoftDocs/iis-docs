---
title: "IProcessHost Interface"
description: This article has information about syntax, methods, derived classes, inheritance hierarchy, and requirements for the IProcessHost interface.
ms.date: "10/07/2016"
ms.assetid: 5bfd0e30-2f05-ddd4-307f-810158e93339
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
|[IProcessHost::EnumerateAppDomains](../../web-development-reference/native-code-api-reference/iprocesshost-enumerateappdomains-method.md)|Retrieves a pointer to an [IAppDomainInfoEnum](../../web-development-reference/native-code-api-reference/iappdomaininfoenum-interface.md) interface.|  
|[IProcessHost::Shutdown](../../web-development-reference/native-code-api-reference/iprocesshost-shutdown-method.md)|Sends a request to terminate all applications in an application domain.|  
|[IProcessHost::ShutdownApplication](../../web-development-reference/native-code-api-reference/iprocesshost-shutdownapplication-method.md)|Terminates the specified application.|  
|[IProcessHost::StartApplication](../../web-development-reference/native-code-api-reference/iprocesshost-startapplication-method.md)|Starts the specified application.|  
  
## Properties  
 This interface contains no properties.  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Inheritance Hierarchy  
 [IUnknown](/windows/win32/api/unknwn/nn-unknwn-iunknown)  
  
 `IProcessHost`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Webhost.h|  
  
## See Also  
 [Windows Process Activation Service Interfaces](../../web-development-reference/native-code-api-reference/windows-process-activation-service-interfaces.md)
