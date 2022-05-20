---
title: IHttpContext2 Interface
ms.date: 10/07/2016
description: Represents the reprocessing of an HTTP request and enables the retrieval of information about the original user during asynchronous operation.
ms.assetid: 8637cfed-ff2d-43ef-aaf3-771cb1fb6c61
ms.author: robmcm
---
# IHttpContext2 Interface
Represents the reprocessing of an HTTP request and enables the retrieval of information about the original user during asynchronous operation.  
  
## Syntax  
  
```cpp  
class IHttpContext2 : public IHttpContext  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpContext2` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetOriginalUser](../../web-development-reference/native-code-api-reference/ihttpcontext2-getoriginaluser-method.md)|Retrieves the user information associated with the original request during asynchronous operation.|  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IHttpContext3](../../web-development-reference/native-code-api-reference/ihttpcontext3-interface.md)|Represents the reprocessing of an HTTP request and enables additional support for asynchronous operations.|  
|[IHttpContext4](../../web-development-reference/native-code-api-reference/ihttpcontext4-interface.md)|Represents the reprocessing of an HTTP request and enables additional support for diagnostic operations.|  
  
## Inheritance Hierarchy  
 [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md)  
  
 `IHttpContext2`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)
