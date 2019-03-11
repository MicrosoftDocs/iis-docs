---
title: "IHttpUrlInfo::IsFrequentlyHit Method"
ms.date: "10/07/2016"
ms.assetid: 67fb593e-1cde-105d-652e-dc8617d99cbd
---
# IHttpUrlInfo::IsFrequentlyHit Method
Returns a Boolean value that indicates whether the URL is requested frequently.  
  
## Syntax  
  
```cpp  
virtual BOOL IsFrequentlyHit(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `true` if the URL is frequently requested; otherwise, `false`.  
  
## Remarks  
 The `IsFrequentlyHit` method retrieves a Boolean value that indicates whether the URL for the current request is frequently requested by Web clients. For example, if you were writing a custom HTTP compression module for [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)], you could determine which URLs should be compressed based on the results of the `IsFrequentlyHit` method.  
  
 By default, the determining factor for a return value of `true` is two requests in a 10-second time span. You can configure this behavior by modifying the `frequentHitThreshold` and `frequentHitTimePeriod` attributes of the `<serverRuntime>` element in your ApplicationHost.config file. For example, to configure your server to return a value of `true` when a URL has been requested 10 times in a 5-second period, you would modify the `<serverRuntime>` element in your ApplicationHost.config file by adding the following attributes:  
  
```  
<serverRuntime  
    frequentHitThreshold="10"  
    frequentHitTimePeriod="00:00:05" />  
```  
  
## Example  
 The following code example demonstrates how to use the [IHttpContext::GetUrlInfo](../../web-development-reference\native-code-api-reference/ihttpcontext-geturlinfo-method.md) method to create an HTTP module that retrieves an [IHttpUrlInfo](../../web-development-reference\native-code-api-reference/ihttpurlinfo-interface.md) interface for the current request. Then the example calls the `IsFrequentlyHit` method to determine whether the URL is requested frequently. Finally, the example displays this information to a Web client.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpContextGetUrlInfo#1](IHttpContextGetUrlInfo#1)]  -->  
  
 Your module must export the [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpContext::GetUrlInfo Method](../../web-development-reference\native-code-api-reference/ihttpcontext-geturlinfo-method.md)   
 [IHttpUrlInfo Interface](../../web-development-reference\native-code-api-reference/ihttpurlinfo-interface.md)