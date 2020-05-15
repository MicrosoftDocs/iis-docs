---
title: "Web Server Core Functions"
ms.date: "10/07/2016"
ms.assetid: 2fb1a740-c0e8-4a93-b002-3b1fb735cf92
---
# Web Server Core Functions

This section describes the Web Server Core and integrated request-processing pipeline functions.  
  
## In This Section  

 The following table lists the functions exposed by the integrated request-processing pipeline.  
  
|Function|Description|  
|--------------|-----------------|  
|[Compress](../../web-development-reference/native-code-api-reference/compress-function.md)|Compresses data given the compression context, input buffer, output buffer, and compression level.|  
|[CreateCompression](../../web-development-reference/native-code-api-reference/createcompression-function.md)|Creates a new compression context.|  
|[DeInitCompression](../../web-development-reference/native-code-api-reference/deinitcompression-function.md)|De-initializes the compression scheme.|  
|[DestroyCompression](../../web-development-reference/native-code-api-reference/destroycompression-function.md)|Destroys the specified compression context.|  
|[HttpGetExtendedInterface](../../web-development-reference/native-code-api-reference/httpgetextendedinterface-function.md)|Retrieves an extended HTTP interface given the HTTP server instance and the pointer to be down cast.|  
|[InitCompression](../../web-development-reference/native-code-api-reference/initcompression-function.md)|Initializes the compression scheme.|  
|[PFN_ASYNC_COMPLETION](../../web-development-reference/native-code-api-reference/pfn-async-completion-function.md)|Defines the asynchronous completion function prototype.|  
|[PFN_REGISTERMODULE](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md)|Defines the `RegisterModule` function prototype for native-code HTTP modules.|  
|[PFN_WEBSOCKET_COMPLETION](../../web-development-reference/native-code-api-reference/pfn-websocket-completion-funtion.md)|Defines the WebSocket completion function prototype.|  
|[ResetCompression](../../web-development-reference/native-code-api-reference/resetcompression-function.md)|Resets the compression context.|  
  
## Remarks  

 The `PFN_REGISTERMODULE` function is a prototype for the `RegisterModule` function. All HTTP modules are required to implement and export the `RegisterModule` function, which IIS will use to load the module. For more information about creating HTTP modules, see [Designing Native-Code HTTP Modules](../../web-development-reference/native-code-development-overview/designing-native-code-http-modules.md).  
  
## See Also  

 [Web Server Core API Reference](../../web-development-reference/native-code-api-reference/web-server-core-api-reference.md)
