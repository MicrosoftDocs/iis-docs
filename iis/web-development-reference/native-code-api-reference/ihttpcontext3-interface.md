---
title: "IHttpContext3 Interface"
ms.date: "10/07/2016"
ms.assetid: 0d446756-92cf-4edb-a806-615829b55339
ms.author: "robmcm"
---
# IHttpContext3 Interface
Represents the reprocessing of an HTTP request and enables additional support for asynchronous operations.  
  
## Syntax  
  
```cpp  
class IHttpContext3 : public IHttpContext2  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpContext3` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetNamedContextContainer](../../web-development-reference/native-code-api-reference/ihttpcontext3-getnamedcontextcontainer-method.md)|Retrieves a container of named context objects.|  
|[EnableFullDuplex](../../web-development-reference/native-code-api-reference/ihttpcontext3-enablefullduplex-method.md)|Enables an asynchronous full-duplex connection for this context.|  
|[InheritServerVariable](../../web-development-reference/native-code-api-reference/ihttpcontext3-inheritservervariable-method.md)|Causes the request to inherit the specified server variable.|  
|[PostCompletion](../../web-development-reference/native-code-api-reference/ihttpcontext3-postcompletion-method.md)|Posts the completion of the asynchronous operation.|  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IHttpContext4](../../web-development-reference/native-code-api-reference/ihttpcontext4-interface.md)|Represents the reprocessing of an HTTP request and enables additional support for diagnostic operations.|  
  
## Inheritance Hierarchy  
 [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md)  
  
 [IHttpContext2](../../web-development-reference/native-code-api-reference/ihttpcontext2-interface.md)  
  
 `IHttpContext3`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)