---
title: "IHttpFileInfo Interface"
ms.date: "10/07/2016"
ms.assetid: 82e00c1a-d54d-64d2-465b-581234ab0d24
---
# IHttpFileInfo Interface

Extends the [IHttpCacheSpecificData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-interface.md) interface by adding file-specific information for files that are cached on a server.  
  
## Syntax  
  
```cpp  
class IHttpFileInfo : public IHttpCacheSpecificData  
```  
  
## Methods  

 The following table lists the methods exposed by the `IHttpFileInfo` class.  
  
|Name|Description|  
|----------|-----------------|  
|[AccessCheck](../../web-development-reference/native-code-api-reference/ihttpfileinfo-accesscheck-method.md)|Returns a value that indicates whether the user can access the corresponding file.|  
|[CheckIfFileHasChanged](../../web-development-reference/native-code-api-reference/ihttpfileinfo-checkiffilehaschanged-method.md)|Returns a value that indicates whether the corresponding file has been changed since it was loaded into a file cache.|  
|[DecrementTTL](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-decrementttl-method.md)|(Inherited from [IHttpCacheSpecificData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-interface.md).)|  
|[DereferenceCacheData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-dereferencecachedata-method.md)|(Inherited from `IHttpCacheSpecificData`.)|  
|[GetAttributes](../../web-development-reference/native-code-api-reference/ihttpfileinfo-getattributes-method.md)|Retrieves the attributes of the corresponding file for an `IHttpFileInfo` interface.|  
|[GetCacheKey](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-getcachekey-method.md)|(Inherited from `IHttpCacheSpecificData`.)|  
|[GetETag](../../web-development-reference/native-code-api-reference/ihttpfileinfo-getetag-method.md)|Retrieves the entity tag of the corresponding file for an `IHttpFileInfo` interface.|  
|[GetFileBuffer](../../web-development-reference/native-code-api-reference/ihttpfileinfo-getfilebuffer-method.md)|Returns a buffer in memory loaded from the corresponding file.|  
|[GetFileHandle](../../web-development-reference/native-code-api-reference/ihttpfileinfo-getfilehandle-method.md)|Returns the file handle for the corresponding file.|  
|[GetFilePath](../../web-development-reference/native-code-api-reference/ihttpfileinfo-getfilepath-method.md)|Returns the physical path of the file referenced by an `IHttpFileInfo` interface.|  
|[GetFlushed](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-getflushed-method.md)|(Inherited from `IHttpCacheSpecificData`.)|  
|[GetHttpCacheAllowed](../../web-development-reference/native-code-api-reference/ihttpfileinfo-gethttpcacheallowed-method.md)|Returns a value that indicates whether the corresponding file can be cached.|  
|[GetLastModifiedString](../../web-development-reference/native-code-api-reference/ihttpfileinfo-getlastmodifiedstring-method.md)|Retrieves the last modified string of the corresponding file for an `IHttpFileInfo` interface.|  
|[GetLastModifiedTime](../../web-development-reference/native-code-api-reference/ihttpfileinfo-getlastmodifiedtime-method.md)|Retrieves the last modified time structure of the corresponding file for an `IHttpFileInfo` interface.|  
|[GetModuleContextContainer](../../web-development-reference/native-code-api-reference/ihttpfileinfo-getmodulecontextcontainer-method.md)|Returns an [IHttpModuleContextContainer](../../web-development-reference/native-code-api-reference/ihttpmodulecontextcontainer-interface.md) pointer for the corresponding file.|  
|[GetSize](../../web-development-reference/native-code-api-reference/ihttpfileinfo-getsize-method.md)|Retrieves the size of the corresponding file for an `IHttpFileInfo` interface.|  
|[GetVrPath](../../web-development-reference/native-code-api-reference/ihttpfileinfo-getvrpath-method.md)|Returns the virtual path for the corresponding file.|  
|[GetVrToken](../../web-development-reference/native-code-api-reference/ihttpfileinfo-getvrtoken-method.md)|Returns the virtual token for the corresponding file.|  
|[ReferenceCacheData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-referencecachedata-method.md)|(Inherited from `IHttpCacheSpecificData`.)|  
|[ResetTTL](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-resetttl-method.md)|(Inherited from `IHttpCacheSpecificData`.)|  
|[SetFlushed](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-setflushed-method.md)|(Inherited from `IHttpCacheSpecificData`.)|  
  
## Derived Classes  

 This interface contains no derived classes.  
  
## Remarks  

 [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) derived classes that register for request or response events receive an [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md) pointer on the corresponding `virtual` method for the event. You can retrieve an `IHttpFileInfo` pointer by calling the [IHttpContext::GetFileInfo](../../web-development-reference/native-code-api-reference/ihttpcontext-getfileinfo-method.md) method.  
  
## Example  

 The following code example demonstrates how to use the [IHttpContext::GetFileInfo](../../web-development-reference/native-code-api-reference/ihttpcontext-getfileinfo-method.md) method to create an HTTP module that retrieves a pointer to an `IHttpFileInfo` interface. The example then displays the `IHttpFileInfo` data to a Web client.  
  
 [!code-cpp[IHttpFileInfo#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpFileInfo/cpp/IHttpFileInfo.cpp#1)]  
  
 The following text is a sample of the data output from the preceding code example.  
  
```  
HTTP/1.1 200 OK  
content-Type:text/plain  
Server: Microsoft-IIS/7.0  
Date: Thu, 15 Dec 2005 22:22:09 GMT  
Content-Length: 374  
  
Access: -123456789  
File Changed: false  
Attributes: 32  
ETag: "1234567890abcde:0"  
ETag Value: 19  
File Handle: INVALID_HANDLE_VALUE  
File Path: C:\INETPUB\WWWROOT\IISSTART.HTM  
Cache Allowed: true  
Time-to-Live: -1  
Last Modified String: Tue, 13 Dec 2005 10:57:41 GMT  
Last Modified Time: 12/13/2005 02:57  
Module Container: valid  
VR Path: NULL  
VR Token: NULL  
```  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Inheritance Hierarchy  

 [IHttpCacheSpecificData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-interface.md)  
  
 `IHttpFileInfo`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  

 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)   
 [IHttpTokenEntry Interface](../../web-development-reference/native-code-api-reference/ihttptokenentry-interface.md)
