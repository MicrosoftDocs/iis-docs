---
title: "IReadEntityProvider Interface"
ms.date: "10/07/2016"
ms.assetid: 88a39d22-b9ac-9ee7-1127-57158a8a9c4c
---
# IReadEntityProvider Interface
Provides an interface for retrieving or modifying the request entity.  
  
## Syntax  
  
```cpp  
class IReadEntityProvider : public IHttpEventProvider  
```  
  
## Methods  
 The following table lists the methods exposed by the `IReadEntityProvider` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetEntity](../../web-development-reference/native-code-api-reference/ireadentityprovider-getentity-method.md)|Retrieves the request entity.|  
|[SetEntity](../../web-development-reference/native-code-api-reference/ireadentityprovider-setentity-method.md)|Specifies the request entity.|  
|[SetErrorStatus](../../web-development-reference/native-code-api-reference/ihttpeventprovider-seterrorstatus-method.md)|(Inherited from [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md).)|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 IIS creates and passes an `IReadEntityProvider` interface to a module's [CHttpModule::OnReadEntity](../../web-development-reference/native-code-api-reference/chttpmodule-onreadentity-method.md) method when the module has registered for the [RQ_READ_ENTITY](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification in the module's exported [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function.  
  
 **Note** IIS will trigger `CHttpModule::OnReadEntity()` event for every [IHttpRequest::ReadEntityBody Method](../../web-development-reference/native-code-api-reference/ihttprequest-readentitybody-method.md) even if there is no entity left to read. This behavior addresses scenarios where a module should insert some entity when there is no request entity. You must write some entity-length-verification code so that your `CHttpModule::OnReadEntity()` handler is aware of the possibility of a zero entity length.  
  
## Inheritance Hierarchy  
 [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md)  
  
 `IReadEntityProvider`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)