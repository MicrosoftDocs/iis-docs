---
title: "IHttpCachePolicy Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 25090637-88d3-52df-17bc-9560fa3d92dc
caps.latest.revision: 31
author: "shirhatti"
manager: "wpickett"
---
# IHttpCachePolicy Interface
Provides [CHttpModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-class.md) derived classes access to the setting and getting policy for request caching.  
  
## Syntax  
  
```cpp  
class IHttpCachePolicy  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpCachePolicy` class.  
  
|Name|Description|  
|----------|-----------------|  
|[AppendVaryByHeader](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachepolicy-appendvarybyheader-method.md)|Appends the header value to the cache policy.|  
|[AppendVaryByQueryString](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachepolicy-appendvarybyquerystring-method.md)|Appends the query value to the cache policy.|  
|[DisableUserCache](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachepolicy-disableusercache-method.md)|Disables user caching for the cache policy.|  
|[GetKernelCacheInvalidatorSet](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachepolicy-getkernelcacheinvalidatorset.md)|Gets a value that indicates whether the kernel cache is invalidated.|  
|[GetKernelCachePolicy](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachepolicy-getkernelcachepolicy-method.md)|Returns the cache policy for the kernel.|  
|[GetUserCachePolicy](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachepolicy-getusercachepolicy-method.md)|Returns the cache policy for the user.|  
|[GetVaryByHeaders](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachepolicy-getvarybyheaders-method.md)|Returns the custom header values for the cache policy.|  
|[GetVaryByQueryStrings](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachepolicy-getvarybyquerystrings-method.md)|Returns the custom query values for the cache policy.|  
|[GetVaryByValue](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachepolicy-getvarybyvalue-method.md)|Returns the variable value for the cache policy.|  
|[IsCached](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachepolicy-iscached-method.md)|Returns a value that indicates whether the cache policy is enabled.|  
|[IsUserCacheEnabled](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachepolicy-isusercacheenabled-method.md)|Returns a value that indicates whether user caching is enabled for the cache policy.|  
|[SetIsCached](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachepolicy-setiscached-method.md)|Sets a value that indicates that the data is cached.|  
|[SetKernelCacheInvalidatorSet](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachepolicy-setkernelcacheinvalidatorset-method.md)|Sets a value that indicates that the kernel cache is invalidated.|  
|[SetVaryByValue](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachepolicy-setvarybyvalue-method.md)|Sets the variable value for the cache policy.|  
  
## Properties  
 This class contains no properties.  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IHttpCachePolicy2](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachepolicy2-interface.md)|Provides [CHttpModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-class.md) derived classes access to the setting and getting policy for request caching.|  
  
## Remarks  
 [CHttpModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-class.md) derived classes that register for request or response events receive an [IHttpContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md) pointer as a parameter on the corresponding `virtual` method.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [RQ_BEGIN_REQUEST](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) and [RQ_SEND_RESPONSE](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) events, and then sets `IHttpCachePolicy` data and returns that data to the browser as an XML document.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpCachePolicy#1](IHttpCachePolicy#1)]  -->  
  
 For more information on how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 The above code writes an XML document that is similar to the following to the response stream:  
  
```  
<?xml version="1.0"?>  
<response>  
    <httpCachePolicy   
        varyByHeaders="header1,header2"   
        varyByQuery="query1,query2"   
        varyByValue="vary"   
        isCached="true"   
        isUserCacheEnabled="false">  
            <cachePolicy   
                kernelPolicy="HttpCachePolicyUserInvalidates"   
                secondsToLive="2"/>  
            <cachePolicy   
                userPolicy="HttpCachePolicyMaximum"   
                secondsToLive="5"/>  
    </httpCachePolicy>  
</response>  
```  
  
 You can optionally compile the code by using the __`stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)