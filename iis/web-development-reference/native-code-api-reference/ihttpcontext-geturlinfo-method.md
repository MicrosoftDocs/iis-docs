---
title: "IHttpContext::GetUrlInfo Method"
ms.date: "10/07/2016"
ms.assetid: c7f49659-be13-b8eb-d401-3f35cdf88213
---
# IHttpContext::GetUrlInfo Method
Retrieves the URL information container for the current context.  
  
## Syntax  
  
```cpp  
virtual IHttpUrlInfo* GetUrlInfo(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [IHttpUrlInfo](../../web-development-reference/native-code-api-reference/ihttpurlinfo-interface.md) interface.  
  
## Remarks  
 The `GetUrlInfo` method retrieves a pointer to an `IHttpUrlInfo` interface that retrieves additional information about the URL for the current request. For example, the [IHttpUrlInfo::IsFrequentlyHit](../../web-development-reference/native-code-api-reference/ihttpurlinfo-isfrequentlyhit-method.md) method retrieves a Boolean value that indicates whether the URL for the current request is frequently requested by Web clients.  
  
> [!NOTE]
>  The [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md) interface owns the lifetime of this object. Therefore, you do not free this pointer when you write HTTP modules.  
  
## Example  
 The following code example demonstrates how to use the `GetUrlInfo` method to create an HTTP module that retrieves an `IHttpUrlInfo` interface. Then the example calls the [IHttpUrlInfo::IsFrequentlyHit](../../web-development-reference/native-code-api-reference/ihttpurlinfo-isfrequentlyhit-method.md) method to determine whether the URL is frequently requested. Finally, the example displays this information to a Web client.  
  
 [!code-cpp[IHttpContextGetUrlInfo#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpContextGetUrlInfo/cpp/IHttpContextGetUrlInfo.cpp#1)]  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpContext Interface](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md)
