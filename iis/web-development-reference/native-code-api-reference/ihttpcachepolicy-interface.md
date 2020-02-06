---
title: "IHttpCachePolicy Interface"
ms.date: "10/07/2016"
ms.assetid: 25090637-88d3-52df-17bc-9560fa3d92dc
---
# IHttpCachePolicy Interface
Provides [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) derived classes access to the setting and getting policy for request caching.  
  
## Syntax  
  
```cpp  
class IHttpCachePolicy  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpCachePolicy` class.  
  
|Name|Description|  
|----------|-----------------|  
|[AppendVaryByHeader](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-appendvarybyheader-method.md)|Appends the header value to the cache policy.|  
|[AppendVaryByQueryString](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-appendvarybyquerystring-method.md)|Appends the query value to the cache policy.|  
|[DisableUserCache](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-disableusercache-method.md)|Disables user caching for the cache policy.|  
|[GetKernelCacheInvalidatorSet](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-getkernelcacheinvalidatorset.md)|Gets a value that indicates whether the kernel cache is invalidated.|  
|[GetKernelCachePolicy](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-getkernelcachepolicy-method.md)|Returns the cache policy for the kernel.|  
|[GetUserCachePolicy](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-getusercachepolicy-method.md)|Returns the cache policy for the user.|  
|[GetVaryByHeaders](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-getvarybyheaders-method.md)|Returns the custom header values for the cache policy.|  
|[GetVaryByQueryStrings](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-getvarybyquerystrings-method.md)|Returns the custom query values for the cache policy.|  
|[GetVaryByValue](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-getvarybyvalue-method.md)|Returns the variable value for the cache policy.|  
|[IsCached](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-iscached-method.md)|Returns a value that indicates whether the cache policy is enabled.|  
|[IsUserCacheEnabled](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-isusercacheenabled-method.md)|Returns a value that indicates whether user caching is enabled for the cache policy.|  
|[SetIsCached](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-setiscached-method.md)|Sets a value that indicates that the data is cached.|  
|[SetKernelCacheInvalidatorSet](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-setkernelcacheinvalidatorset-method.md)|Sets a value that indicates that the kernel cache is invalidated.|  
|[SetVaryByValue](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-setvarybyvalue-method.md)|Sets the variable value for the cache policy.|  
  
## Properties  
 This class contains no properties.  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IHttpCachePolicy2](../../web-development-reference/native-code-api-reference/ihttpcachepolicy2-interface.md)|Provides [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) derived classes access to the setting and getting policy for request caching.|  
  
## Remarks  
 [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) derived classes that register for request or response events receive an [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md) pointer as a parameter on the corresponding `virtual` method.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [RQ_BEGIN_REQUEST](../../web-development-reference/native-code-api-reference/request-processing-constants.md) and [RQ_SEND_RESPONSE](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events, and then sets `IHttpCachePolicy` data and returns that data to the browser as an XML document.  
  
 [!code-cpp[IHttpCachePolicy#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpCachePolicy/cpp/IHttpCachePolicy.cpp#1)]  
  
 For more information on how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
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
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)