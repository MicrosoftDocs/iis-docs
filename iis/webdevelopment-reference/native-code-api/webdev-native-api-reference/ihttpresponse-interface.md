---
title: "IHttpResponse Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 718f9094-273e-713f-1d18-08fec8c0a6bb
caps.latest.revision: 23
author: "shirhatti"
manager: "wpickett"
---
# IHttpResponse Interface
Provides an interface to an HTTP response object. You can use the methods in the `IHttpResponse` interface to retrieve and modify data in the current HTTP response.  
  
## Syntax  
  
```cpp  
class IHttpResponse  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpResponse` interface.  
  
|Topic|Description|  
|-----------|-----------------|  
|[Clear](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-clear-method.md)|Clears the response entity.|  
|[ClearHeaders](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-clearheaders-method.md)|Clears the response headers and sets headers to default values.|  
|[CloseConnection](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-closeconnection-method.md)|Closes the connection and sends a reset packet to the client.|  
|[DeleteHeader](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-deleteheader-method.md)|Deletes a specified HTTP header.|  
|[DisableBuffering](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-disablebuffering-method.md)|Disables response buffering for the current request.|  
|[DisableKernelCache](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-disablekernelcache-method.md)|Disables the kernel cache for this response.|  
|[Flush](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-flush-method.md)|Sends the existing content in the response buffer to the client.|  
|[GetCachePolicy](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-getcachepolicy-method.md)|Retrieves the response output cache policy.|  
|[GetErrorDescription](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-geterrordescription-method.md)|Retrieves the custom error description.|  
|[GetHeader](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-getheader-method.md)|Returns the value of a specified HTTP header.|  
|[GetHeaderChanges](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-getheaderchanges-method.md)|Retrieves the changes to the server headers for the current response.|  
|[GetHeadersSuppressed](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-getheaderssuppressed-method.md)|Determines whether the response status and headers are suppressed.|  
|[GetKernelCacheEnabled](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-getkernelcacheenabled-method.md)|Determines whether the kernel cache is enabled for the current response.|  
|[GetRawHttpResponse](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-getrawhttpresponse-method.md)|Retrieves a structure that contains the raw HTTP response.|  
|[GetStatus](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-getstatus-method.md)|Retrieves the HTTP status for the response.|  
|[Redirect](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-redirect-method.md)|Redirects the client to a specified URL.|  
|[ResetConnection](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-resetconnection-method.md)|Resets the socket connection immediately.|  
|[SetErrorDescription](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-seterrordescription-method.md)|Specifies the custom error description.|  
|[SetHeader](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-setheader-method.md)|Sets or appends the value of a specified HTTP response header.|  
|[SetNeedDisconnect](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-setneeddisconnect-method.md)|Resets the socket after the response is complete.|  
|[SetStatus](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-setstatus-method.md)|Sets the HTTP status for the response.|  
|[SuppressHeaders](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-suppressheaders-method.md)|Suppresses the response status and headers.|  
|[WriteEntityChunkByReference](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-writeentitychunkbyreference-method.md)|Inserts or appends an [HTTP_DATA_CHUNK](http://go.microsoft.com/fwlink/?LinkId=56011) structure into the response body.|  
|[WriteEntityChunks](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-writeentitychunks-method.md)|Appends one or more `HTTP_DATA_CHUNK` structures to the response body.|  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IHttpResponse2](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse2-interface.md)|Provides an interface for flushing data and writing entity data chunks for asynchronous operations.|  
  
## Related Sections  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)  
  
 [IHttpRequest Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttprequest-interface.md)  
  
## See Also  
 [IHttpContext Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md)