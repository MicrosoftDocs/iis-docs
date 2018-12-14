---
title: "IHttpUrlInfo::IsFrequentlyHit Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 67fb593e-1cde-105d-652e-dc8617d99cbd
caps.latest.revision: 17
author: "shirhatti"
manager: "wpickett"
---
# IHttpUrlInfo::IsFrequentlyHit Method
Returns a Boolean value that indicates whether the URL is requested frequently.  
  
## Syntax  
  
```cpp  
virtual BOOL IsFrequentlyHit(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `true` if the URL is frequently requested; otherwise, `false`.  
  
## Remarks  
 The `IsFrequentlyHit` method retrieves a Boolean value that indicates whether the URL for the current request is frequently requested by Web clients. For example, if you were writing a custom HTTP compression module for [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)], you could determine which URLs should be compressed based on the results of the `IsFrequentlyHit` method.  
  
 By default, the determining factor for a return value of `true` is two requests in a 10-second time span. You can configure this behavior by modifying the `frequentHitThreshold` and `frequentHitTimePeriod` attributes of the `<serverRuntime>` element in your ApplicationHost.config file. For example, to configure your server to return a value of `true` when a URL has been requested 10 times in a 5-second period, you would modify the `<serverRuntime>` element in your ApplicationHost.config file by adding the following attributes:  
  
```  
<serverRuntime  
    frequentHitThreshold="10"  
    frequentHitTimePeriod="00:00:05" />  
```  
  
## Example  
 The following code example demonstrates how to use the [IHttpContext::GetUrlInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-geturlinfo-method.md) method to create an HTTP module that retrieves an [IHttpUrlInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpurlinfo-interface.md) interface for the current request. Then the example calls the `IsFrequentlyHit` method to determine whether the URL is requested frequently. Finally, the example displays this information to a Web client.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpContextGetUrlInfo#1](IHttpContextGetUrlInfo#1)]  -->  
  
 Your module must export the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpContext::GetUrlInfo Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-geturlinfo-method.md)   
 [IHttpUrlInfo Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpurlinfo-interface.md)