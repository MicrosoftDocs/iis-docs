---
title: "IPreBeginRequestProvider Interface"
ms.date: "10/07/2016"
ms.assetid: d4ae5a10-95ec-0e4d-263b-291bc92c548b
---
# IPreBeginRequestProvider Interface
Provides a global-level interface for [GL_PRE_BEGIN_REQUEST](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notifications.  
  
## Syntax  
  
```cpp  
class IPreBeginRequestProvider : public IHttpEventProvider  
```  
  
## Methods  
 The following table lists the methods exposed by the `IPreBeginRequestProvider` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetHttpContext](../../web-development-reference/native-code-api-reference/iprebeginrequestprovider-gethttpcontext-method.md)|Retrieves an [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md) interface.|  
|[SetErrorStatus](../../web-development-reference/native-code-api-reference/ihttpeventprovider-seterrorstatus-method.md)|(Inherited from [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md).)|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 An `IPreBeginRequestProvider` interface is created and passed to a module's [CGlobalModule::OnGlobalPreBeginRequest](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalprebeginrequest-method.md) method when the module has registered for the [GL_PRE_BEGIN_REQUEST](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification in the module's exported [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function.  
  
## Inheritance Hierarchy  
 [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md)  
  
 `IPreBeginRequestProvider`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)   
 [CGlobalModule::OnGlobalPreBeginRequest Method](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalprebeginrequest-method.md)   
 [IHttpEventProvider Interface](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md)   
 [PFN_REGISTERMODULE Function](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md)