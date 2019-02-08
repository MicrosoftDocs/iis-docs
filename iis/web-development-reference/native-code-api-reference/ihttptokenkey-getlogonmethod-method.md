---
title: "IHttpTokenKey::GetLogonMethod Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 6afc12d7-fcec-58f8-7c75-ebd2be61eede
caps.latest.revision: 31
author: "shirhatti"
manager: "wpickett"
---
# IHttpTokenKey::GetLogonMethod Method
Returns the `LOGON32_*` value used when the user logs on.  
  
## Syntax  
  
```cpp  
virtual DWORD GetLogonMethod(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A `DWORD` that represents the logon method for a user.  
  
## Remarks  
 The `GetLogonMethod` returns the value from a call to the `LOGON32_LOGON_*` method. The following table describes logon methods with their corresponding numeric values defined in the Winbase.h header file.  
  
|Method|Value|  
|------------|-----------|  
|`LOGON32_PROVIDER_DEFAULT`|0|  
|`LOGON32_PROVIDER_WINNT35`|1|  
|`LOGON32_PROVIDER_WINNT40` or `LOGON32_LOGON_INTERACTIVE`|2|  
|`LOGON32_PROVIDER_WINNT50` or `LOGON32_LOGON_NETWORK`|3|  
|`LOGON32_LOGON_BATCH`|4|  
|`LOGON32_LOGON_SERVICE`|5|  
|`LOGON32_LOGON_UNLOCK`|7|  
|`LOGON32_LOGON_NETWORK_CLEARTEXT`|8|  
|`LOGON32_LOGON_NEW_CREDENTIALS`|9|  
  
## Notes for Implementers  
 Implementers of the [IHttpTokenKey](../../web-development-reference\native-code-api-reference/ihttptokenkey-interface.md) interface may use the values returned from both the `GetLogonMethod` and [GetUserName](../../web-development-reference\native-code-api-reference/ihttptokenkey-getusername-method.md) methods to implement the [IHttpCacheKey::GetIsEqual](../../web-development-reference\native-code-api-reference/ihttpcachekey-getisequal-method.md) method.  
  
## Notes for Callers  
 The `IHttpCacheKey::GetIsEqual` method returns `true` only if the `pCacheCompareKey` parameter can be cast to an `IHttpTokenKey` pointer, and if the values returned from both the `GetLogonMethod` and `GetUserName` methods are equivalent for the `pCacheCompareKey` parameter and the current `IHttpTokenKey` pointer.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_CACHE_OPERATION](../../web-development-reference\native-code-api-reference/request-processing-constants.md) and [GL_CACHE_CLEANUP](../../web-development-reference\native-code-api-reference/request-processing-constants.md) events and then writes the `GetLogonMethod` information to the Event Viewer where the user logged in using `LOGON32_PROVIDER_WINNT50`.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpTokenKey#3](IHttpTokenKey#3)]  -->  
  
 The above code writes a new event to the Event Viewer, where the Data box contains XML that is similar to the following.  
  
```  
IHttpTokenKey::GetLogonMethod: 3  
```  
  
 Your module must export the [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpcach.h|  
  
## See Also  
 [IHttpTokenKey Interface](../../web-development-reference\native-code-api-reference/ihttptokenkey-interface.md)