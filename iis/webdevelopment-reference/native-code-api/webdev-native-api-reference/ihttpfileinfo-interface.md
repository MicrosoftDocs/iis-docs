---
title: "IHttpFileInfo Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 82e00c1a-d54d-64d2-465b-581234ab0d24
caps.latest.revision: 38
author: "shirhatti"
manager: "wpickett"
---
# IHttpFileInfo Interface
Extends the [IHttpCacheSpecificData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-interface.md) interface by adding file-specific information for files that are cached on a server.  
  
## Syntax  
  
```cpp  
class IHttpFileInfo : public IHttpCacheSpecificData  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpFileInfo` class.  
  
|Name|Description|  
|----------|-----------------|  
|[AccessCheck](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-accesscheck-method.md)|Returns a value that indicates whether the user can access the corresponding file.|  
|[CheckIfFileHasChanged](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-checkiffilehaschanged-method.md)|Returns a value that indicates whether the corresponding file has been changed since it was loaded into a file cache.|  
|[DecrementTTL](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-decrementttl-method.md)|(Inherited from [IHttpCacheSpecificData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-interface.md).)|  
|[DereferenceCacheData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-dereferencecachedata-method.md)|(Inherited from `IHttpCacheSpecificData`.)|  
|[GetAttributes](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-getattributes-method.md)|Retrieves the attributes of the corresponding file for an `IHttpFileInfo` interface.|  
|[GetCacheKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-getcachekey-method.md)|(Inherited from `IHttpCacheSpecificData`.)|  
|[GetETag](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-getetag-method.md)|Retrieves the entity tag of the corresponding file for an `IHttpFileInfo` interface.|  
|[GetFileBuffer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-getfilebuffer-method.md)|Returns a buffer in memory loaded from the corresponding file.|  
|[GetFileHandle](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-getfilehandle-method.md)|Returns the file handle for the corresponding file.|  
|[GetFilePath](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-getfilepath-method.md)|Returns the physical path of the file referenced by an `IHttpFileInfo` interface.|  
|[GetFlushed](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-getflushed-method.md)|(Inherited from `IHttpCacheSpecificData`.)|  
|[GetHttpCacheAllowed](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-gethttpcacheallowed-method.md)|Returns a value that indicates whether the corresponding file can be cached.|  
|[GetLastModifiedString](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-getlastmodifiedstring-method.md)|Retrieves the last modified string of the corresponding file for an `IHttpFileInfo` interface.|  
|[GetLastModifiedTime](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-getlastmodifiedtime-method.md)|Retrieves the last modified time structure of the corresponding file for an `IHttpFileInfo` interface.|  
|[GetModuleContextContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-getmodulecontextcontainer-method.md)|Returns an [IHttpModuleContextContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulecontextcontainer-interface.md) pointer for the corresponding file.|  
|[GetSize](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-getsize-method.md)|Retrieves the size of the corresponding file for an `IHttpFileInfo` interface.|  
|[GetVrPath](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-getvrpath-method.md)|Returns the virtual path for the corresponding file.|  
|[GetVrToken](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-getvrtoken-method.md)|Returns the virtual token for the corresponding file.|  
|[ReferenceCacheData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-referencecachedata-method.md)|(Inherited from `IHttpCacheSpecificData`.)|  
|[ResetTTL](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-resetttl-method.md)|(Inherited from `IHttpCacheSpecificData`.)|  
|[SetFlushed](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-setflushed-method.md)|(Inherited from `IHttpCacheSpecificData`.)|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 [CHttpModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-class.md) derived classes that register for request or response events receive an [IHttpContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md) pointer on the corresponding `virtual` method for the event. You can retrieve an `IHttpFileInfo` pointer by calling the [IHttpContext::GetFileInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getfileinfo-method.md) method.  
  
## Example  
 The following code example demonstrates how to use the [IHttpContext::GetFileInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getfileinfo-method.md) method to create an HTTP module that retrieves a pointer to an `IHttpFileInfo` interface. The example then displays the `IHttpFileInfo` data to a Web client.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpFileInfo#1](IHttpFileInfo#1)]  -->  
  
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
  
 Your module must export the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Inheritance Hierarchy  
 [IHttpCacheSpecificData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-interface.md)  
  
 `IHttpFileInfo`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)   
 [IHttpTokenEntry Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptokenentry-interface.md)