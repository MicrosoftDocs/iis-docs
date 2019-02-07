---
title: "IProcessHostIdleAndHealthMonitor Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 0cecacb6-0772-3d95-af9c-edf5069d30ac
caps.latest.revision: 19
author: "shirhatti"
manager: "wpickett"
---
# IProcessHostIdleAndHealthMonitor Interface
Monitors the health of a worker process.  
  
## Syntax  
  
```cpp  
struct IProcessHostIdleAndHealthMonitor : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IProcessHostIdleAndHealthMonitor` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[IProcessHostIdleAndHealthMonitor::IsIdle](../../web-development-reference\native-code-api-reference/iprocesshostidleandhealthmonitor-isidle-method.md)|Checks whether the process host is idle.|  
|[IProcessHostIdleAndHealthMonitor::Ping](../../web-development-reference\native-code-api-reference/iprocesshostidleandhealthmonitor-ping-method.md)|Performs an asynchronous ping operation.|  
  
## Properties  
 This interface contains no properties.  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IProcessHostIdleAndHealthMonitor`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Webhost.h|  
  
## See Also  
 [Windows Process Activation Service Interfaces](../../web-development-reference\native-code-api-reference/windows-process-activation-service-interfaces.md)