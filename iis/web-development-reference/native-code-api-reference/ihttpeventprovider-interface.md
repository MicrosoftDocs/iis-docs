---
title: "IHttpEventProvider Interface"
description: IHttpEventProvider Interface provides a generic event-reporting interface.
ms.date: "10/07/2016"
ms.assetid: 1f7b9790-66d0-fd22-edf0-721693702d35
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
|[SetErrorStatus](../../web-development-reference/native-code-api-reference/ihttpeventprovider-seterrorstatus-method.md)|Specifies an error to return.|  
  
## Derived Classes  
 The following table lists the derived classes exposed by the `IHttpEventProvider` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[IAuthenticationProvider](../../web-development-reference/native-code-api-reference/iauthenticationprovider-interface.md)|Provides an interface for [RQ_REQUEST_AUTHENTICATE](../../web-development-reference/native-code-api-reference/request-processing-constants.md) event notifications.|  
|[ICacheProvider](../../web-development-reference/native-code-api-reference/icacheprovider-interface.md)|Provides an interface for [GL_CACHE_OPERATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) event notifications.|  
|[ICustomNotificationProvider](../../web-development-reference/native-code-api-reference/icustomnotificationprovider-interface.md)|Provides an interface for [GL_CUSTOM_NOTIFCATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) and [RQ_CUSTOM_NOTIFCATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) event notifications.|  
|[IGlobalConfigurationChangeProvider](../../web-development-reference/native-code-api-reference/iglobalconfigurationchangeprovider-interface.md)|Provides an interface for [GL_CONFIGURATION_CHANGE](../../web-development-reference/native-code-api-reference/request-processing-constants.md) event notifications.|  
|[IGlobalFileChangeProvider](../../web-development-reference/native-code-api-reference/iglobalfilechangeprovider-interface.md)|Provides an interface for [GL_FILE_CHANGE](../../web-development-reference/native-code-api-reference/request-processing-constants.md) event notifications.|  
|[IGlobalRSCAQueryProvider](../../web-development-reference/native-code-api-reference/iglobalrscaqueryprovider-interface.md)|Provides an interface for [GL_RSCA_QUERY](../../web-development-reference/native-code-api-reference/request-processing-constants.md) event notifications.|  
|[IGlobalStopListeningProvider](../../web-development-reference/native-code-api-reference/iglobalstoplisteningprovider-interface.md)|Provides an interface for [GL_STOP_LISTENING](../../web-development-reference/native-code-api-reference/request-processing-constants.md) event notifications.|  
|[IGlobalThreadCleanupProvider](../../web-development-reference/native-code-api-reference/iglobalthreadcleanupprovider-interface.md)|Provides an interface for [GL_THREAD_CLEANUP](../../web-development-reference/native-code-api-reference/request-processing-constants.md) event notifications.|  
|[IGlobalTraceEventProvider](../../web-development-reference/native-code-api-reference/iglobaltraceeventprovider-interface.md)|Provides an interface for [GL_TRACE_EVENT](../../web-development-reference/native-code-api-reference/request-processing-constants.md) event notifications.|  
|[IHttpApplicationProvider](../../web-development-reference/native-code-api-reference/ihttpapplicationprovider-interface.md)|Provides an interface for [GL_APPLICATION_START](../../web-development-reference/native-code-api-reference/request-processing-constants.md) event notifications.|  
|[IMapHandlerProvider](../../web-development-reference/native-code-api-reference/imaphandlerprovider-interface.md)|Provides an interface for [RQ_DETERMINE_HANDLER](../../web-development-reference/native-code-api-reference/request-processing-constants.md) event notifications.|  
|[IMapPathProvider](../../web-development-reference/native-code-api-reference/imappathprovider-interface.md)|Provides an interface for [RQ_MAP_PATH](../../web-development-reference/native-code-api-reference/request-processing-constants.md) event notifications.|  
|[IPreBeginRequestProvider](../../web-development-reference/native-code-api-reference/iprebeginrequestprovider-interface.md)|Provides an interface for [GL_PRE_BEGIN_REQUEST](../../web-development-reference/native-code-api-reference/request-processing-constants.md) event notifications.|  
|[IReadEntityProvider](../../web-development-reference/native-code-api-reference/ireadentityprovider-interface.md)|Provides an interface for [RQ_READ_ENTITY](../../web-development-reference/native-code-api-reference/request-processing-constants.md) event notifications.|  
|[ISendResponseProvider](../../web-development-reference/native-code-api-reference/isendresponseprovider-interface.md)|Provides an interface for [RQ_SEND_RESPONSE](../../web-development-reference/native-code-api-reference/request-processing-constants.md) event notifications.|  
  
## Remarks  
 The `IHttpEventProvider` interface provides the generic event-reporting interface for most notification methods, and it serves as the parent class for the event-reporting interfaces that are used with the remaining notifications.  
  
 The `IHttpEventProvider` interface exposes only the [SetErrorStatus](../../web-development-reference/native-code-api-reference/ihttpeventprovider-seterrorstatus-method.md) method, which sets the error status for the current context. Several of the derived classes that are inherited from `IHttpEventProvider` expose additional methods that are specific to their respective events.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that sends an example string to the Web client and captures the return value from this operation. The module uses the `SetErrorStatus` method to specify the return value as the error status for the current request and then exits.  
  
 [!code-cpp[IHttpEventProviderSetErrorStatus#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpEventProviderSetErrorStatus/cpp/IHttpEventProviderSetErrorStatus.cpp#1)]  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)   
 [IAuthenticationProvider Interface](../../web-development-reference/native-code-api-reference/iauthenticationprovider-interface.md)   
 [ICacheProvider Interface](../../web-development-reference/native-code-api-reference/icacheprovider-interface.md)   
 [ICustomNotificationProvider Interface](../../web-development-reference/native-code-api-reference/icustomnotificationprovider-interface.md)   
 [IGlobalConfigurationChangeProvider Interface](../../web-development-reference/native-code-api-reference/iglobalconfigurationchangeprovider-interface.md)   
 [IGlobalFileChangeProvider Interface](../../web-development-reference/native-code-api-reference/iglobalfilechangeprovider-interface.md)   
 [IGlobalRSCAQueryProvider Interface](../../web-development-reference/native-code-api-reference/iglobalrscaqueryprovider-interface.md)   
 [IGlobalStopListeningProvider Interface](../../web-development-reference/native-code-api-reference/iglobalstoplisteningprovider-interface.md)   
 [IGlobalThreadCleanupProvider Interface](../../web-development-reference/native-code-api-reference/iglobalthreadcleanupprovider-interface.md)   
 [IGlobalTraceEventProvider Interface](../../web-development-reference/native-code-api-reference/iglobaltraceeventprovider-interface.md)   
 [IHttpApplicationProvider Interface](../../web-development-reference/native-code-api-reference/ihttpapplicationprovider-interface.md)   
 [IMapHandlerProvider Interface](../../web-development-reference/native-code-api-reference/imaphandlerprovider-interface.md)   
 [IMapPathProvider Interface](../../web-development-reference/native-code-api-reference/imappathprovider-interface.md)   
 [IPreBeginRequestProvider Interface](../../web-development-reference/native-code-api-reference/iprebeginrequestprovider-interface.md)   
 [IReadEntityProvider Interface](../../web-development-reference/native-code-api-reference/ireadentityprovider-interface.md)   
 [ISendResponseProvider Interface](../../web-development-reference/native-code-api-reference/isendresponseprovider-interface.md)
