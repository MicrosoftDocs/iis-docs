---
title: "IHttpServer::GetAppPoolName Method"
ms.date: "10/07/2016"
ms.assetid: f11a11fa-f364-d8ce-d7cb-1bc1ae4e0ad9
---
# IHttpServer::GetAppPoolName Method
Retrieves the name of the application pool for the current request.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetAppPoolName(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a string that contains the application pool name.  
  
## Remarks  
 The `GetAppPoolName` method returns the name of the application pool that is processing the current request. For example, requests for the default Web site on a new installation of [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] may return "ASP.NET 2.0 AppPool".  
  
 Depending on how you configure applications on a Web server, the name of an application may be different within a contiguous namespace. For example, if a Web client requests both http://example.com/ and http://example.com/example/, the name of the application pool may be different for the relative example path if a different application pool has been configured for that location.  
  
## Example  
 The following code example demonstrates how to use the `GetAppPoolName` method to create an HTTP module that retrieves the name of the application pool that is processing the current request. The module then returns the name to a Web client.  
  
 [!code-cpp[IHttpServerGetAppPoolName#1](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpServerGetAppPoolName/cpp/IHttpServerGetAppPoolName.cpp#1)]  
  
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
 [IHttpServer Interface](../../web-development-reference/native-code-api-reference/ihttpserver-interface.md)