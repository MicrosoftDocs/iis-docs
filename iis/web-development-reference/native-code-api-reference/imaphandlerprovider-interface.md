---
title: "IMapHandlerProvider Interface"
ms.date: "10/07/2016"
ms.assetid: 751560c1-2a88-7175-c78d-615c42f86feb
---
# IMapHandlerProvider Interface
Provides a request-level interface for processing [RQ_MAP_REQUEST_HANDLER](../../web-development-reference\native-code-api-reference/request-processing-constants.md) notifications.  
  
## Syntax  
  
```cpp  
class IMapHandlerProvider : public IHttpEventProvider  
```  
  
## Methods  
 The following table lists the methods exposed by the `IMapHandlerProvider` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[SetErrorStatus](../../web-development-reference\native-code-api-reference/ihttpeventprovider-seterrorstatus-method.md)|(Inherited from [IHttpEventProvider](../../web-development-reference\native-code-api-reference/ihttpeventprovider-interface.md).)|  
|[SetFileInfo](../../web-development-reference\native-code-api-reference/imaphandlerprovider-setfileinfo-method.md)|Specifies the [IHttpFileInfo](../../web-development-reference\native-code-api-reference/ihttpfileinfo-interface.md) interface to use for the current request-level context.|  
|[SetScriptMap](../../web-development-reference\native-code-api-reference/imaphandlerprovider-setscriptmap-method.md)|Specifies which [IScriptMapInfo](../../web-development-reference\native-code-api-reference/iscriptmapinfo-interface.md) interface to use for the current context.|  
|[SetScriptName](../../web-development-reference\native-code-api-reference/imaphandlerprovider-setscriptname-method.md)|Specifies the script name for a request URL.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 An `IMapHandlerProvider` interface is created and passed to a module's [CHttpModule::OnMapRequestHandler](../../web-development-reference\native-code-api-reference/chttpmodule-onmaprequesthandler-method.md) method when the module has registered for the [RQ_MAP_REQUEST_HANDLER](../../web-development-reference\native-code-api-reference/request-processing-constants.md) notification in the module's exported [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function. You can use the methods provided by the `IMapHandlerProvider` interface to override the way that IIS processes a request.  
  
## Inheritance Hierarchy  
 [IHttpEventProvider](../../web-development-reference\native-code-api-reference/ihttpeventprovider-interface.md)  
  
 `IMapHandlerProvider`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference\native-code-api-reference/web-server-core-interfaces.md)