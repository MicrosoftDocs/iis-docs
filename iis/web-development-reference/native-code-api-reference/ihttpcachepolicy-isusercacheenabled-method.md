---
title: "IHttpCachePolicy::IsUserCacheEnabled Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: ff83d13d-ba1d-2075-8231-df9d7877e96a
caps.latest.revision: 18
author: "shirhatti"
manager: "wpickett"
---
# IHttpCachePolicy::IsUserCacheEnabled Method
Returns a value that indicates whether user caching is enabled for the cache policy.  
  
## Syntax  
  
```cpp  
virtual BOOL IsUserCacheEnabled(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `true` if user caching is enabled for the cache policy; otherwise, `false`.  
  
## Remarks  
 [CHttpModule](../../web-development-reference\webdev-native-api-reference/chttpmodule-class.md) derived classes that register for request or response events receive an [IHttpContext](../../web-development-reference\webdev-native-api-reference/ihttpcontext-interface.md) pointer as a parameter on the corresponding `virtual` method. Call the [IHttpContext::GetResponse](../../web-development-reference\webdev-native-api-reference/ihttpcontext-getresponse-method.md) method, then the [IHttpResponse::GetCachePolicy](../../web-development-reference\webdev-native-api-reference/ihttpresponse-getcachepolicy-method.md) method, and finally the `IsUserCacheEnabled` method to determine if user caching is enabled for the cache policy.  
  
 `IsUserCacheEnabled` behavior depends on implementation. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
-   The current default implementer of the [IHttpCachePolicy](../../web-development-reference\webdev-native-api-reference/ihttpcachepolicy-interface.md) interface declares a `private` Boolean that determines whether caching is enabled for a user. During the construction of an implementer, this Boolean is initialized to `true`. When the [DisableUserCache](../../web-development-reference\webdev-native-api-reference/ihttpcachepolicy-disableusercache-method.md) method is called, this Boolean is set to `false`. Once caching is disabled for a user, there is no method to reset this Boolean to `true`.  
  
-   `IsUserCacheEnabled` returns the value of this Boolean.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [RQ_BEGIN_REQUEST](../../web-development-reference\webdev-native-api-reference/request-processing-constants.md) and [RQ_SEND_RESPONSE](../../web-development-reference\webdev-native-api-reference/request-processing-constants.md) events. The module then retrieves an `IHttpCachePolicy` pointer and writes user cache information to the response stream.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpCachePolicy#11](IHttpCachePolicy#11)]  -->  
  
 For more information on how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 The above code writes data that is similar to the following to the response stream:  
  
```  
User Cache Enabled: true  
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
 [IHttpCachePolicy Interface](../../web-development-reference\webdev-native-api-reference/ihttpcachepolicy-interface.md)