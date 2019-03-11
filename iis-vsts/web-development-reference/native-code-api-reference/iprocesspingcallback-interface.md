---
title: "IProcessPingCallback Interface"
ms.date: "10/07/2016"
ms.assetid: 1dc21793-7db9-156b-9685-167462097678
---
# IProcessPingCallback Interface
Provides functionality to respond to a ping request.  
  
## Syntax  
  
```cpp  
struct IProcessPingCallback : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IProcessPingCallback` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[IProcessPingCallback::Respond Method](../../web-development-reference\native-code-api-reference/iprocesspingcallback-respond-method.md)|Provides a callback routine that responds to a ping.|  
  
## Properties  
 This interface contains no properties.  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Inheritance Hierarchy  
 [IUnknown](https://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IProcessPingCallback`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Webhost.h|  
  
## See Also  
 [Windows Process Activation Service Interfaces](../../web-development-reference\native-code-api-reference/windows-process-activation-service-interfaces.md)