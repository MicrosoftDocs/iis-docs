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
 Implementers of the [IHttpTokenKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptokenkey-interface.md) interface may use the values returned from both the `GetLogonMethod` and [GetUserName](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptokenkey-getusername-method.md) methods to implement the [IHttpCacheKey::GetIsEqual](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-getisequal-method.md) method.  
  
## Notes for Callers  
 The `IHttpCacheKey::GetIsEqual` method returns `true` only if the `pCacheCompareKey` parameter can be cast to an `IHttpTokenKey` pointer, and if the values returned from both the `GetLogonMethod` and `GetUserName` methods are equivalent for the `pCacheCompareKey` parameter and the current `IHttpTokenKey` pointer.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_CACHE_OPERATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) and [GL_CACHE_CLEANUP](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) events and then writes the `GetLogonMethod` information to the Event Viewer where the user logged in using `LOGON32_PROVIDER_WINNT50`.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpTokenKey#3](IHttpTokenKey#3)]  -->  
  
 The above code writes a new event to the Event Viewer, where the Data box contains XML that is similar to the following.  
  
```  
IHttpTokenKey::GetLogonMethod: 3  
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
 [IHttpTokenKey Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptokenkey-interface.md)