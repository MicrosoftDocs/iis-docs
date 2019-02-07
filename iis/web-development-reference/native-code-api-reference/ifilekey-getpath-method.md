---
title: "IFileKey::GetPath Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: c2b0cdbc-c41a-300b-3deb-8514b5069c3f
caps.latest.revision: 44
author: "shirhatti"
manager: "wpickett"
---
# IFileKey::GetPath Method
Returns the absolute physical path of a file.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetPath(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a constant null-terminated Unicode string that contains the absolute physical path of a file.  
  
## Remarks  
 An example path is C:\InetPub\wwwroot\default.htm, which is the default Web page for the default Web site.  
  
 Values returned from the `GetPath` and [IUriKey::GetUrl](../../web-development-reference\webdev-native-api-reference/iurikey-geturl-method.md) methods are often related; the former represents the absolute path of a file on a computer, while the latter represents the relative value on a Web server.  
  
## Notes for Implementers  
 [IFileKey](../../web-development-reference\webdev-native-api-reference/ifilekey-interface.md) implementers are responsible for memory management with this data; therefore, `IFileKey` implementers that use dynamic memory allocation must release or call `delete` on the `PCWSTR` pointer when it is no longer needed.  
  
 Implementers of the [IFileKey](../../web-development-reference\webdev-native-api-reference/ifilekey-interface.md) interface may use the value returned from the `GetPath` method to implement both the [IHttpCacheKey::GetIsEqual](../../web-development-reference\webdev-native-api-reference/ihttpcachekey-getisequal-method.md) and [IHttpCacheKey::GetIsPrefix](../../web-development-reference\webdev-native-api-reference/ihttpcachekey-getisprefix-method.md) methods.  
  
## Notes for Callers  
 `IFileKey` implementers are responsible for memory management with this data; therefore, `IFileKey` clients must not release or call `delete` on the returned `PCWSTR` pointer when this data is no longer needed. Furthermore, clients must not cast this data to a pointer that is not a `const` or change the state of the memory referenced by this `PCWSTR`, because an access violation will be thrown or the data will become invalid.  
  
 The `IHttpCacheKey::GetIsEqual` method returns `true` only if the `pCacheCompareKey` parameter can be cast to an `IFileKey` pointer and if the value returned from the `GetPath` method on both the current and `pCacheCompareKey``IFileKey` pointers returns equivalent `PCWSTR` strings.  
  
 The `IHttpCacheKey::GetIsPrefix` method returns `true` only if the `pCacheCompareKey` parameter can be cast to an `IFileKey` pointer and if the value returned from `GetPath` on the current `IFileKey` pointer is a substring of the value returned from `GetPath` on the `pCacheCompareKey` parameter, starting at index 0.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_CACHE_OPERATION](../../web-development-reference\webdev-native-api-reference/request-processing-constants.md) and [GL_CACHE_CLEANUP](../../web-development-reference\webdev-native-api-reference/request-processing-constants.md) events and then writes the `GetPath` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
<!-- TODO: review snippet reference  [!CODE [IFileKey#3](IFileKey#3)]  -->  
  
 The above code writes a new event to the Event Viewer, where the Data box contains a string similar to the following.  
  
```  
IFileKey::GetPath: C:\INETPUB\WWWROOT\DEFAULT.HTM  
```  
  
 Your module must export the [RegisterModule](../../web-development-reference\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpcach.h|  
  
## See Also  
 [IFileKey Interface](../../web-development-reference\webdev-native-api-reference/ifilekey-interface.md)   
 [IHttpCacheKey Interface](../../web-development-reference\webdev-native-api-reference/ihttpcachekey-interface.md)