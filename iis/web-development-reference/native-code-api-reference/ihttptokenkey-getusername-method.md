---
title: "IHttpTokenKey::GetUserName Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 3659a1ad-d0f4-9c43-8c6a-492cfe033d93
caps.latest.revision: 38
author: "shirhatti"
manager: "wpickett"
---
# IHttpTokenKey::GetUserName Method
Returns the user name.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetUserName(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a constant null-terminated Unicode string that contains the user name.  
  
## Remarks  
 The `GetUserName` method returns the user name in clear text. An example user name would be "User".  
  
## Notes for Implementers  
 [IHttpTokenKey](../../web-development-reference\webdev-native-api-reference/ihttptokenkey-interface.md) implementers are responsible for memory management with this data; therefore, `IHttpTokenKey` implementers that use dynamic memory allocation must release or call `delete` on the `PCWSTR` pointer when it is no longer needed.  
  
 Implementers of the `IHttpTokenKey` interface may use the values returned from the [GetLogonMethod](../../web-development-reference\webdev-native-api-reference/ihttptokenkey-getlogonmethod-method.md) and `GetUserName` methods to implement the [IHttpCacheKey::GetIsEqual](../../web-development-reference\webdev-native-api-reference/ihttpcachekey-getisequal-method.md) method.  
  
## Notes for Callers  
 `IHttpTokenKey` implementers are responsible for memory management with this data; therefore, `IHttpTokenKey` clients must not release or call `delete` on the returned `PCWSTR` pointer when this data is no longer needed. Furthermore, clients must not cast this data to a pointer that is not a `const` or change the state of the memory referenced by this `PCWSTR`; otherwise, an access violation will be thrown or the data will become invalid.  
  
 The `IHttpCacheKey::GetIsEqual` method returns `true` only if the `pCacheCompareKey` parameter can be cast to an `IHttpTokenKey` pointer, and if the values returned from both the [GetLogonMethod](../../web-development-reference\webdev-native-api-reference/ihttptokenkey-getlogonmethod-method.md) and `GetUserName` methods are equivalent for the `pCacheCompareKey` parameter and the current `IHttpTokenKey` pointer.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_CACHE_OPERATION](../../web-development-reference\webdev-native-api-reference/request-processing-constants.md) and [GL_CACHE_CLEANUP](../../web-development-reference\webdev-native-api-reference/request-processing-constants.md) events and then writes the `GetUserName` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpTokenKey#5](IHttpTokenKey#5)]  -->  
  
 The above code writes a new event to the Event Viewer, where the Data box contains a string that is similar to the following.  
  
```  
IHttpTokenKey::GetUserName: IUSR  
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
 [IHttpTokenKey Interface](../../web-development-reference\webdev-native-api-reference/ihttptokenkey-interface.md)