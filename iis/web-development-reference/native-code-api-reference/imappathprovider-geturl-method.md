---
title: "IMapPathProvider::GetUrl Method"
ms.date: "10/07/2016"
ms.assetid: 3e34715b-0a94-dd4a-8ec0-4974e470bb5d
---
# IMapPathProvider::GetUrl Method
Retrieves the relative URL for the request.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetUrl(  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a Unicode string that contains the relative URL.  
  
## Remarks  
 The `GetUrl` method retrieves the relative path for the current request when an HTTP module is processing the [CHttpModule::OnMapPath](../../web-development-reference/native-code-api-reference/chttpmodule-onmappath-method.md) event.  
  
## Example  
 The following code example demonstrates how to use the `GetUrl` method to create an HTTP module that retrieves the relative URL for the current request and returns the URL to a Web client.  
  
 [!code-cpp[IMapPathProviderGetUrl#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IMapPathProviderGetUrl/cpp/IMapPathProviderGetUrl.cpp#1)]  
  
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
 [IMapPathProvider Interface](../../web-development-reference/native-code-api-reference/imappathprovider-interface.md)