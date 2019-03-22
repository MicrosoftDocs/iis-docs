---
title: "IHttpResponse Interface"
ms.date: "10/07/2016"
ms.assetid: 718f9094-273e-713f-1d18-08fec8c0a6bb
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
|[Clear](../../web-development-reference/native-code-api-reference/ihttpresponse-clear-method.md)|Clears the response entity.|  
|[ClearHeaders](../../web-development-reference/native-code-api-reference/ihttpresponse-clearheaders-method.md)|Clears the response headers and sets headers to default values.|  
|[CloseConnection](../../web-development-reference/native-code-api-reference/ihttpresponse-closeconnection-method.md)|Closes the connection and sends a reset packet to the client.|  
|[DeleteHeader](../../web-development-reference/native-code-api-reference/ihttpresponse-deleteheader-method.md)|Deletes a specified HTTP header.|  
|[DisableBuffering](../../web-development-reference/native-code-api-reference/ihttpresponse-disablebuffering-method.md)|Disables response buffering for the current request.|  
|[DisableKernelCache](../../web-development-reference/native-code-api-reference/ihttpresponse-disablekernelcache-method.md)|Disables the kernel cache for this response.|  
|[Flush](../../web-development-reference/native-code-api-reference/ihttpresponse-flush-method.md)|Sends the existing content in the response buffer to the client.|  
|[GetCachePolicy](../../web-development-reference/native-code-api-reference/ihttpresponse-getcachepolicy-method.md)|Retrieves the response output cache policy.|  
|[GetErrorDescription](../../web-development-reference/native-code-api-reference/ihttpresponse-geterrordescription-method.md)|Retrieves the custom error description.|  
|[GetHeader](../../web-development-reference/native-code-api-reference/ihttpresponse-getheader-method.md)|Returns the value of a specified HTTP header.|  
|[GetHeaderChanges](../../web-development-reference/native-code-api-reference/ihttpresponse-getheaderchanges-method.md)|Retrieves the changes to the server headers for the current response.|  
|[GetHeadersSuppressed](../../web-development-reference/native-code-api-reference/ihttpresponse-getheaderssuppressed-method.md)|Determines whether the response status and headers are suppressed.|  
|[GetKernelCacheEnabled](../../web-development-reference/native-code-api-reference/ihttpresponse-getkernelcacheenabled-method.md)|Determines whether the kernel cache is enabled for the current response.|  
|[GetRawHttpResponse](../../web-development-reference/native-code-api-reference/ihttpresponse-getrawhttpresponse-method.md)|Retrieves a structure that contains the raw HTTP response.|  
|[GetStatus](../../web-development-reference/native-code-api-reference/ihttpresponse-getstatus-method.md)|Retrieves the HTTP status for the response.|  
|[Redirect](../../web-development-reference/native-code-api-reference/ihttpresponse-redirect-method.md)|Redirects the client to a specified URL.|  
|[ResetConnection](../../web-development-reference/native-code-api-reference/ihttpresponse-resetconnection-method.md)|Resets the socket connection immediately.|  
|[SetErrorDescription](../../web-development-reference/native-code-api-reference/ihttpresponse-seterrordescription-method.md)|Specifies the custom error description.|  
|[SetHeader](../../web-development-reference/native-code-api-reference/ihttpresponse-setheader-method.md)|Sets or appends the value of a specified HTTP response header.|  
|[SetNeedDisconnect](../../web-development-reference/native-code-api-reference/ihttpresponse-setneeddisconnect-method.md)|Resets the socket after the response is complete.|  
|[SetStatus](../../web-development-reference/native-code-api-reference/ihttpresponse-setstatus-method.md)|Sets the HTTP status for the response.|  
|[SuppressHeaders](../../web-development-reference/native-code-api-reference/ihttpresponse-suppressheaders-method.md)|Suppresses the response status and headers.|  
|[WriteEntityChunkByReference](../../web-development-reference/native-code-api-reference/ihttpresponse-writeentitychunkbyreference-method.md)|Inserts or appends an [HTTP_DATA_CHUNK](https://go.microsoft.com/fwlink/?LinkId=56011) structure into the response body.|  
|[WriteEntityChunks](../../web-development-reference/native-code-api-reference/ihttpresponse-writeentitychunks-method.md)|Appends one or more `HTTP_DATA_CHUNK` structures to the response body.|  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IHttpResponse2](../../web-development-reference/native-code-api-reference/ihttpresponse2-interface.md)|Provides an interface for flushing data and writing entity data chunks for asynchronous operations.|  
  
## Related Sections  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)  
  
 [IHttpRequest Interface](../../web-development-reference/native-code-api-reference/ihttprequest-interface.md)  
  
## See Also  
 [IHttpContext Interface](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md)