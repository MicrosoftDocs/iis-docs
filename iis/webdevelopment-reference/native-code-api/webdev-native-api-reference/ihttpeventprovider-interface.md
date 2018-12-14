---
title: "IHttpEventProvider Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 1f7b9790-66d0-fd22-edf0-721693702d35
caps.latest.revision: 14
author: "shirhatti"
manager: "wpickett"
---
# IHttpEventProvider Interface
Provides a generic event-reporting interface.  
  
## Syntax  
  
```cpp  
class IHttpEventProvider  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpEventProvider` class.  
  
|Name|Description|  
|----------|-----------------|  
|[SetErrorStatus](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-seterrorstatus-method.md)|Specifies an error to return.|  
  
## Derived Classes  
 The following table lists the derived classes exposed by the `IHttpEventProvider` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[IAuthenticationProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iauthenticationprovider-interface.md)|Provides an interface for [RQ_REQUEST_AUTHENTICATE](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) event notifications.|  
|[ICacheProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-interface.md)|Provides an interface for [GL_CACHE_OPERATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) event notifications.|  
|[ICustomNotificationProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icustomnotificationprovider-interface.md)|Provides an interface for [GL_CUSTOM_NOTIFCATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) and [RQ_CUSTOM_NOTIFCATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) event notifications.|  
|[IGlobalConfigurationChangeProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalconfigurationchangeprovider-interface.md)|Provides an interface for [GL_CONFIGURATION_CHANGE](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) event notifications.|  
|[IGlobalFileChangeProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalfilechangeprovider-interface.md)|Provides an interface for [GL_FILE_CHANGE](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) event notifications.|  
|[IGlobalRSCAQueryProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalrscaqueryprovider-interface.md)|Provides an interface for [GL_RSCA_QUERY](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) event notifications.|  
|[IGlobalStopListeningProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalstoplisteningprovider-interface.md)|Provides an interface for [GL_STOP_LISTENING](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) event notifications.|  
|[IGlobalThreadCleanupProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalthreadcleanupprovider-interface.md)|Provides an interface for [GL_THREAD_CLEANUP](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) event notifications.|  
|[IGlobalTraceEventProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobaltraceeventprovider-interface.md)|Provides an interface for [GL_TRACE_EVENT](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) event notifications.|  
|[IHttpApplicationProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpapplicationprovider-interface.md)|Provides an interface for [GL_APPLICATION_START](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) event notifications.|  
|[IMapHandlerProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/imaphandlerprovider-interface.md)|Provides an interface for [RQ_DETERMINE_HANDLER](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) event notifications.|  
|[IMapPathProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/imappathprovider-interface.md)|Provides an interface for [RQ_MAP_PATH](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) event notifications.|  
|[IPreBeginRequestProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprebeginrequestprovider-interface.md)|Provides an interface for [GL_PRE_BEGIN_REQUEST](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) event notifications.|  
|[IReadEntityProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ireadentityprovider-interface.md)|Provides an interface for [RQ_READ_ENTITY](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) event notifications.|  
|[ISendResponseProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/isendresponseprovider-interface.md)|Provides an interface for [RQ_SEND_RESPONSE](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) event notifications.|  
  
## Remarks  
 The `IHttpEventProvider` interface provides the generic event-reporting interface for most notification methods, and it serves as the parent class for the event-reporting interfaces that are used with the remaining notifications.  
  
 The `IHttpEventProvider` interface exposes only the [SetErrorStatus](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-seterrorstatus-method.md) method, which sets the error status for the current context. Several of the derived classes that are inherited from `IHttpEventProvider` expose additional methods that are specific to their respective events.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that sends an example string to the Web client and captures the return value from this operation. The module uses the `SetErrorStatus` method to specify the return value as the error status for the current request and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpEventProviderSetErrorStatus#1](IHttpEventProviderSetErrorStatus#1)]  -->  
  
 Your module must export the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)   
 [IAuthenticationProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iauthenticationprovider-interface.md)   
 [ICacheProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-interface.md)   
 [ICustomNotificationProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icustomnotificationprovider-interface.md)   
 [IGlobalConfigurationChangeProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalconfigurationchangeprovider-interface.md)   
 [IGlobalFileChangeProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalfilechangeprovider-interface.md)   
 [IGlobalRSCAQueryProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalrscaqueryprovider-interface.md)   
 [IGlobalStopListeningProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalstoplisteningprovider-interface.md)   
 [IGlobalThreadCleanupProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalthreadcleanupprovider-interface.md)   
 [IGlobalTraceEventProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobaltraceeventprovider-interface.md)   
 [IHttpApplicationProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpapplicationprovider-interface.md)   
 [IMapHandlerProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/imaphandlerprovider-interface.md)   
 [IMapPathProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/imappathprovider-interface.md)   
 [IPreBeginRequestProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprebeginrequestprovider-interface.md)   
 [IReadEntityProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ireadentityprovider-interface.md)   
 [ISendResponseProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/isendresponseprovider-interface.md)