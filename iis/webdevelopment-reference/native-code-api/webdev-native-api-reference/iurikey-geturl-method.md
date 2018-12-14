---
title: "IUriKey::GetUrl Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: e3bc1574-276e-faeb-b018-4bac8eadd66f
caps.latest.revision: 36
author: "shirhatti"
manager: "wpickett"
---
# IUriKey::GetUrl Method
Returns the URL associated with the Uniform Resource Identifier (URI) data.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetUrl(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a constant null-terminated Unicode string that contains the URL.  
  
## Remarks  
 An example of a URL for the default Web page on the default Web site is /Default.htm.  
  
 Values returned from the [IFileKey::GetPath](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ifilekey-getpath-method.md) and `GetUrl` methods are often related; the former represents the absolute path of a file on a computer, while the latter represents the relative value on a Web server.  
  
## Notes for Implementers  
 [IUriKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iurikey-interface.md) implementers are responsible for memory management with this data; therefore, `IUriKey` implementers that use dynamic memory allocation must release or call `delete` on the `PCWSTR` pointer when it is no longer needed.  
  
 Implementers of the `IUriKey` interface may use the values returned from both the [GetSiteId](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iurikey-getsiteid-method.md) and `GetUrl` methods to implement the [IHttpCacheKey::GetIsEqual](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-getisequal-method.md) method.  
  
## Notes for Callers  
 `IUriKey` implementers are responsible for memory management with this data; therefore, `IUriKey` clients must not release or call `delete` on the returned `PCWSTR` pointer when this data is no longer needed. Furthermore, clients must not cast this data to a pointer that is not a `const` or change the state of the memory referenced by this `PCWSTR`; otherwise, an access violation will be thrown or the data will become invalid.  
  
 The `IHttpCacheKey::GetIsEqual` method returns `true` only if the `pCacheCompareKey` parameter can be cast to an `IUriKey` pointer, and the values returned from both the [GetSiteId](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iurikey-getsiteid-method.md) and `GetUrl` methods return equivalent values on both the current `IUriKey` and `pCacheCompareKey` pointers.  
  
 The [IHttpCacheKey::GetIsPrefix](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-getisprefix-method.md) method returns `false` immediately if the `GetSiteId` value of the current `IUriKey` pointer is not the same as the value returned from the same method on the `pCacheCompareKey` parameter. Otherwise, `GetIsPrefix` returns `true` only if the `GetUrl` method on the current `IUriKey` pointer returns a `PCWSTR` that is a substring of the `PCWSTR` returned from the same method on the `pCacheCompareKey` pointer, starting at index 0.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_CACHE_OPERATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) and [GL_CACHE_CLEANUP](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) events and then writes the `GetUrl` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
<!-- TODO: review snippet reference  [!CODE [IUriKey#5](IUriKey#5)]  -->  
  
 The above code writes a new event to the Event Viewer, where the Data box contains a string that is similar to the following.  
  
```  
IUriKey::GetUrl: /DEFAULT.HTM  
```  
  
 Your module must export the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpcach.h|  
  
## See Also  
 [IUriKey Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iurikey-interface.md)