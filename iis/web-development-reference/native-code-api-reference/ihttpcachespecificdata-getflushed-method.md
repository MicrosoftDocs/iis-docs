---
title: "IHttpCacheSpecificData::GetFlushed Method"
ms.date: "10/07/2016"
ms.assetid: 4cce500d-c3e2-a52c-3a15-32887e29c3dd
---
# IHttpCacheSpecificData::GetFlushed Method
Returns a value indicating whether the specific data has been flushed from the cache.  
  
## Syntax  
  
```cpp  
virtual BOOL GetFlushed(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `true` if the data has been flushed from the cache; otherwise, `false`.  
  
## Thread Safety  
 Classes that implement the [IHttpCacheSpecificData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-interface.md) interface are thread safe for the `GetFlushed` and [SetFlushed](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-setflushed-method.md) methods.  
  
## Remarks  
 The behavior of the `GetFlushed` method is implementation specific. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
-   Classes that implement the [IHttpCacheSpecificData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-interface.md) interface initialize a `private` Boolean flag to `false` as an instance variable during the construction of a new pointer. The classes then get and set this flag on subsequent calls to the `GetFlushed` and `SetFlushed` methods, respectively.  
  
-   Classes that implement the [IHttpFileInfo](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md) interface usually return `false` on `GetFlushed` and perform an empty operation on `SetFlushed`, because local files are considered to be always cached.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_CACHE_OPERATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) and [GL_CACHE_CLEANUP](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events and then writes the flush information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
 [!code-cpp[IHttpCacheSpecificData#3](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpCacheSpecificData/cpp/GetFlushed.cpp#3)]  
  
 For more information on how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 The above code writes a new event to the application log of the Event Viewer, where the Data box contains a string similar to the following.  
  
```  
IHttpCacheSpecificData::GetFlushed: false  
```  
  
 You can optionally compile the code by using the __`stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpCacheSpecificData Interface](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-interface.md)