---
title: IProcessHostFactoryHelper Interface
description: Describes the IProcessHostFactoryHelper interface and details its syntax, methods, inheritance hierarchy, and requirements.
ms.date: 10/07/2016
ms.assetid: dc1cd4f7-dbff-408b-26a5-0c4d6c6897c8
---
# IProcessHostFactoryHelper Interface
Provides a method to retrieve an [IProcessHost](../../web-development-reference/native-code-api-reference/iprocesshost-interface.md) interface.  
  
## Syntax  
  
```cpp  
struct IProcessHostFactoryHelper : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IProcessHostFactoryHelper` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[IProcessHostFactoryHelper::GetProcessHost](../../web-development-reference/native-code-api-reference/iprocesshostfactoryhelper-getprocesshost-method.md)|Retrieves an `IProcessHost` interface.|  
  
## Properties  
 This interface contains no properties.  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Inheritance Hierarchy  
 [IUnknown](/windows/win32/api/unknwn/nn-unknwn-iunknown)  
  
 `IProcessHostFactoryHelper`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Webhost.h|  
  
## See Also  
 [Windows Process Activation Service Interfaces](../../web-development-reference/native-code-api-reference/windows-process-activation-service-interfaces.md)
