---
title: "IMapHandlerProvider Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 751560c1-2a88-7175-c78d-615c42f86feb
caps.latest.revision: 13
author: "shirhatti"
manager: "wpickett"
---
# IMapHandlerProvider Interface
Provides a request-level interface for processing [RQ_MAP_REQUEST_HANDLER](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) notifications.  
  
## Syntax  
  
```cpp  
class IMapHandlerProvider : public IHttpEventProvider  
```  
  
## Methods  
 The following table lists the methods exposed by the `IMapHandlerProvider` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[SetErrorStatus](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-seterrorstatus-method.md)|(Inherited from [IHttpEventProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-interface.md).)|  
|[SetFileInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/imaphandlerprovider-setfileinfo-method.md)|Specifies the [IHttpFileInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-interface.md) interface to use for the current request-level context.|  
|[SetScriptMap](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/imaphandlerprovider-setscriptmap-method.md)|Specifies which [IScriptMapInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iscriptmapinfo-interface.md) interface to use for the current context.|  
|[SetScriptName](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/imaphandlerprovider-setscriptname-method.md)|Specifies the script name for a request URL.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 An `IMapHandlerProvider` interface is created and passed to a module's [CHttpModule::OnMapRequestHandler](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-onmaprequesthandler-method.md) method when the module has registered for the [RQ_MAP_REQUEST_HANDLER](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) notification in the module's exported [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can use the methods provided by the `IMapHandlerProvider` interface to override the way that IIS processes a request.  
  
## Inheritance Hierarchy  
 [IHttpEventProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-interface.md)  
  
 `IMapHandlerProvider`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)