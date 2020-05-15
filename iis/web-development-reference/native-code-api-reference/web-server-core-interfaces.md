---
title: "Web Server Core Interfaces"
ms.date: "10/07/2016"
ms.assetid: a541dc16-8cd9-48f2-833d-eea649ef6b25
ms.author: "robmcm"
---
# Web Server Core Interfaces

This section describes the Web Server Core and integrated request-processing pipeline interfaces.  
  
## In This Section  

 The following table lists the interfaces exposed by the integrated request-processing pipeline.  
  
|Interface|Description|  
|---------------|-----------------|  
|[IAuthenticationProvider](../../web-development-reference/native-code-api-reference/iauthenticationprovider-interface.md)|Accepts a validated [IHttpUser](../../web-development-reference/native-code-api-reference/ihttpuser-interface.md) pointer through the [SetUser](../../web-development-reference/native-code-api-reference/iauthenticationprovider-setuser-method.md) method.|  
|[ICacheProvider](../../web-development-reference/native-code-api-reference/icacheprovider-interface.md)|Extends the [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md) interface by adding support for retrieving cache information from a cache provider.|  
|[ICustomNotificationProvider](../../web-development-reference/native-code-api-reference/icustomnotificationprovider-interface.md)|Provides an interface for creating custom notifications.|  
|[IDispensedHttpModuleContextContainer](../../web-development-reference/native-code-api-reference/idispensedhttpmodulecontextcontainer-interface.md)|Extends the [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md) interface by providing functionality for releasing a container.|  
|[IFileKey](../../web-development-reference/native-code-api-reference/ifilekey-interface.md)|Represents key information for accessing associated data in the global file cache.|  
|[IGlobalApplicationPreloadProvider](../../web-development-reference/native-code-api-reference/iglobalapplicationpreloadprovider-interface.md)|Provides a global-level interface for preloading an application into server memory.|  
|[IGlobalApplicationPreloadProvider2](../../web-development-reference/native-code-api-reference/iglobalapplicationpreloadprovider2-interface.md)|Provides information about whether an application’s worker process is recycled.|  
|[IGlobalConfigurationChangeProvider](../../web-development-reference/native-code-api-reference/iglobalconfigurationchangeprovider-interface.md)|Provides a global-level interface for [GL_CONFIGURATION_CHANGE](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notifications.|  
|[IGlobalFileChangeProvider](../../web-development-reference/native-code-api-reference/iglobalfilechangeprovider-interface.md)|Provides a global-level interface for [GL_FILE_CHANGE](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notifications.|  
|[IGlobalRscaQueryProvider](../../web-development-reference/native-code-api-reference/iglobalrscaqueryprovider-interface.md)|Extends the [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md) interface by adding support for querying IIS Run-Time Status and Control information.|  
|[IGlobalStopListeningProvider](../../web-development-reference/native-code-api-reference/iglobalstoplisteningprovider-interface.md)|Provides an interface for notifications that indicate whether a worker process is shutting down and will stop listening for new requests.|  
|[IGlobalThreadCleanupProvider](../../web-development-reference/native-code-api-reference/iglobalthreadcleanupprovider-interface.md)|Provides an interface for thread cleanup notifications.|  
|[IGlobalTraceEventProvider](../../web-development-reference/native-code-api-reference/iglobaltraceeventprovider-interface.md)|Extends the [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md) interface by providing trace events for [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) derived classes.|  
|[IHttpApplication](../../web-development-reference/native-code-api-reference/ihttpapplication-interface.md)|Retrieves application-specific configuration information.|  
|[IHttpApplication2](../../web-development-reference/native-code-api-reference/ihttpapplication2-interface.md)|Provides an interface for loading a Web application into server memory and initializing it before the first HTTP request arrives.|  
|[IHttpApplicationProvider](../../web-development-reference/native-code-api-reference/ihttpapplicationprovider-interface.md)|Provides an interface for application startup notifications.|  
|[IHttpApplicationResolveModulesProvider](../../web-development-reference/native-code-api-reference/ihttpapplicationresolvemodulesprovider-interface.md)|Provides an interface for registering HTTP modules.|  
|[IHttpCacheKey](../../web-development-reference/native-code-api-reference/ihttpcachekey-interface.md)|Provides key information for corresponding data that is stored in a global cache.|  
|[IHttpCachePolicy](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-interface.md)|Provides [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) derived classes access to the setting and getting policy for request caching.|  
|[IHttpCachePolicy2](../../web-development-reference/native-code-api-reference/ihttpcachepolicy2-interface.md)|Provides [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) derived classes access to the setting and getting policy for request caching.|  
|[IHttpCachePolicy2 Interface](../../web-development-reference/native-code-api-reference/ihttpcachepolicy2-interface.md)|Provides access to methods and properties that can force updates to the cache. This interface is only available in IIS 7.5.|  
|[IHttpCacheSpecificData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-interface.md)|Provides information and access methods for data that is stored in a global cache.|  
|[IHttpCompletionInfo](../../web-development-reference/native-code-api-reference/ihttpcompletioninfo-interface.md)|Provides information about an asynchronous completion.|  
|[IHttpCompletionInfo2](../../web-development-reference/native-code-api-reference/ihttpcompletioninfo2-interface.md)|Provides an interface to get the number of bytes completed by an asynchronous operation.|  
|[IHttpConnection](../../web-development-reference/native-code-api-reference/ihttpconnection-interface.md)|Provides an interface for connection-specific information.|  
|[IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md)|Defines an object that represents the processing context for request-level operations.|  
|[IHttpContext2](../../web-development-reference/native-code-api-reference/ihttpcontext2-interface.md)|Represents the reprocessing of an HTTP request and enables the retrieval of information about the original user during asynchronous operation.|  
|[IHttpContext3](../../web-development-reference/native-code-api-reference/ihttpcontext3-interface.md)|Represents the reprocessing of an HTTP request and enables additional support for asynchronous operations.|  
|[IHttpContext4](../../web-development-reference/native-code-api-reference/ihttpcontext4-interface.md)|Represents the reprocessing of an HTTP request and enables additional support for diagnostic operations.|  
|[IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md)|Provides a generic event-reporting interface.|  
|[IHttpFileInfo](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md)|Extends the [IHttpCacheSpecificData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-interface.md) interface by adding file-specific information for files that are cached on a server.|  
|[IHttpFileMonitor](../../web-development-reference/native-code-api-reference/ihttpfilemonitor-interface.md)|File change monitor.|  
|[IHttpModuleContextContainer](../../web-development-reference/native-code-api-reference/ihttpmodulecontextcontainer-interface.md)|Maintains a collection of [IHttpStoredContext](../../web-development-reference/native-code-api-reference/ihttpstoredcontext-interface.md) pointers.|  
|[IHttpModuleFactory](../../web-development-reference/native-code-api-reference/ihttpmodulefactory-interface.md)|Manages the creation of a [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) class.|  
|[IHttpModuleRegistrationInfo](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-interface.md)|Retrieves and sets a module's registration information.|  
|[IHttpPerfCounterInfo](../../web-development-reference/native-code-api-reference/ihttpperfcounterinfo-interface.md)|Provides an interface for incrementing and decrementing performance counters.|  
|[IHttpRequest](../../web-development-reference/native-code-api-reference/ihttprequest-interface.md)|Provides an interface to an HTTP request object.|  
|[IHttpRequest2](../../web-development-reference/native-code-api-reference/ihttprequest2-interface.md)|Provides an interface for retrieving the channel binding token (CBT) being used for request validation.|  
|[IHttpRequest3](../../web-development-reference/native-code-api-reference/ihttprequest3-interface.md)|Provides an interface for reading the request results into a buffer.|  
|[IHttpResponse](../../web-development-reference/native-code-api-reference/ihttpresponse-interface.md)|Provides an interface to an HTTP response object.|  
|[IHttpResponse2](../../web-development-reference/native-code-api-reference/ihttpresponse2-interface.md)|Provides an interface for flushing data and writing entity data chunks for asynchronous operations.|  
|[IHttpServer](../../web-development-reference/native-code-api-reference/ihttpserver-interface.md)|Represents the processing context for global-level operations.|  
|[IHttpServer2](../../web-development-reference/native-code-api-reference/ihttpserver2-interface.md)|Represents the processing context for global-level operations, and enables retrieving configuration files, extended interfaces, metadata, tokens, and the worker process framework.|  
|[IHttpSite](../../web-development-reference/native-code-api-reference/ihttpsite-interface.md)|Provides site-specific information within the current context.|  
|[IHttpStoredContext](../../web-development-reference/native-code-api-reference/ihttpstoredcontext-interface.md)|Defines context information for stored data.|  
|[IHttpTokenEntry](../../web-development-reference/native-code-api-reference/ihttptokenentry-interface.md)|Extends the [IHttpCacheSpecificData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-interface.md) interface by adding token-specific information for tokens that are cached on a server.|  
|[IHttpTokenKey](../../web-development-reference/native-code-api-reference/ihttptokenkey-interface.md)|Represents key information for accessing associated data in the global token cache.|  
|[IHttpTraceContext](../../web-development-reference/native-code-api-reference/ihttptracecontext-interface.md)|Provides a request-wide method for modules to raise events into the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] tracing infrastructure.|  
|[IHttpUrlInfo](../../web-development-reference/native-code-api-reference/ihttpurlinfo-interface.md)|Provides URL-specific information within the current context.|  
|[IHttpUser](../../web-development-reference/native-code-api-reference/ihttpuser-interface.md)|Provides request-specific information about a user.|  
|[IMapHandlerProvider](../../web-development-reference/native-code-api-reference/imaphandlerprovider-interface.md)|Provides a request-level interface for processing for [RQ_MAP_REQUEST_HANDLER](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notifications.|  
|[IMapPathProvider](../../web-development-reference/native-code-api-reference/imappathprovider-interface.md)|Retrieves information about a path that is being physically mapped.|  
|[IMetadataInfo](../../web-development-reference/native-code-api-reference/imetadatainfo-interface.md)|Retrieves metadata information for the current context.|  
|[IModuleAllocator](../../web-development-reference/native-code-api-reference/imoduleallocator-interface.md)|Allocates memory within the current request's memory pool.|  
|[INamedContextContainer](../../web-development-reference/native-code-api-reference/inamedcontextcontainer-interface.md)|Provides an interface for binding and retrieving a named context.|  
|[IPreBeginRequestProvider](../../web-development-reference/native-code-api-reference/iprebeginrequestprovider-interface.md)|Provides a global-level interface for [GL_PRE_BEGIN_REQUEST](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notifications.|  
|[IReadEntityProvider](../../web-development-reference/native-code-api-reference/ireadentityprovider-interface.md)|Provides an interface for retrieving or modifying the request entity.|  
|[IReferencedMetadataInfo](../../web-development-reference/native-code-api-reference/ireferencedmetadatainfo-interface.md)|Provides an interface for referencing and dereferencing context metadata.|  
|[IScriptMapInfo](../../web-development-reference/native-code-api-reference/iscriptmapinfo-interface.md)|Retrieves configuration settings for request handlers.|  
|[ISendResponseProvider](../../web-development-reference/native-code-api-reference/isendresponseprovider-interface.md)|Retrieves or modifies information about the current response.|  
|[IUriKey](../../web-development-reference/native-code-api-reference/iurikey-interface.md)|Represents key information for accessing associated data in the Uniform Resource Identifier (URI) cache.|  
|[IWebSocketContext](../../web-development-reference/native-code-api-reference/iwebsocketcontext-interface.md)|Represents context support for bi-directional WebSocket communications over a single TCP socket.|  
  
## See Also  

 [Web Server Core API Reference](../../web-development-reference/native-code-api-reference/web-server-core-api-reference.md)
