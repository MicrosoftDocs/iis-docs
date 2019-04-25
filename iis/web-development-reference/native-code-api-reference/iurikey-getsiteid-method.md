---
title: "IUriKey::GetSiteId Method"
ms.date: "10/07/2016"
ms.assetid: 691f1a35-1d36-82b5-fae4-45641398004f
---
# IUriKey::GetSiteId Method
Returns the site identifier associated with Uniform Resource Identifier (URI) data.  
  
## Syntax  
  
```cpp  
virtual DWORD GetSiteId(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A `DWORD` value that represents the unique identifier for a Web site.  
  
## Remarks  
 An example of a site identifier for the default Web site is 1.  
  
## Notes for Implementers  
 Implementers of the [IUriKey](../../web-development-reference/native-code-api-reference/iurikey-interface.md) interface may use the values returned from both the `GetSiteId` and [GetUrl](../../web-development-reference/native-code-api-reference/iurikey-geturl-method.md) methods to implement the [IHttpCacheKey::GetIsEqual](../../web-development-reference/native-code-api-reference/ihttpcachekey-getisequal-method.md) method.  
  
## Notes for Callers  
 The `IHttpCacheKey::GetIsEqual` method returns `true` only if the `pCacheCompareKey` parameter can be cast to an `IUriKey` pointer, and the values returned from both the `GetSiteId` and `GetUrl` methods return equivalent values on both the current `IUriKey` and `pCacheCompareKey` pointers.  
  
 The [IHttpCacheKey::GetIsPrefix](../../web-development-reference/native-code-api-reference/ihttpcachekey-getisprefix-method.md) method returns `false` immediately if the `GetSiteId` value of the current `IUriKey` pointer is not the same as the value returned from the same method on the `pCacheCompareKey` parameter. Otherwise, `GetIsPrefix` returns `true` only if the `GetUrl` method on the current `IUriKey` pointer returns a `PCWSTR` that is a substring of the `PCWSTR` returned from the same method on the `pCacheCompareKey` pointer, starting at index 0.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_CACHE_OPERATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) and [GL_CACHE_CLEANUP](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events and then writes the `GetSiteId` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
 [!code-cpp[IUriKey#3](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/IUriKey/cpp/GetSiteId.cpp#3)]  
  
 The above code writes a new event to the Event Viewer, where the Data box contains a string that is similar to the following.  
  
```  
IUriKey::GetSiteId: 1  
```  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpcach.h|  
  
## See Also  
 [IUriKey Interface](../../web-development-reference/native-code-api-reference/iurikey-interface.md)