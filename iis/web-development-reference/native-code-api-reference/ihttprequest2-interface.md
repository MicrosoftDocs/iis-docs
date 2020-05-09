---
title: "IHttpRequest2 Interface"
ms.date: "10/07/2016"
ms.assetid: 6716632d-e1a9-44a6-bdac-36075d50dadb
---
# IHttpRequest2 Interface
Provides an interface for retrieving the channel binding token (CBT) being used for request validation.  
  
## Syntax  
  
```cpp  
class IHttpRequest2 : public IHttpRequest  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpRequest2` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetChannelBindingToken](../../web-development-reference/native-code-api-reference/ihttprequest2-getchannelbindingtoken-method.md)|Gets the channel binding token (CBT) being used for request validation.|  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IHttpRequest3](../../web-development-reference/native-code-api-reference/ihttprequest3-interface.md)|Provides an interface for reading the request results into a buffer.|  
  
## Inheritance Hierarchy  
 [IHttpRequest](../../web-development-reference/native-code-api-reference/ihttprequest-interface.md)  
  
 `IHttpRequest2`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)
