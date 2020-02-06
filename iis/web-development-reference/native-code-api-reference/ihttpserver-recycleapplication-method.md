---
title: "IHttpServer::RecycleApplication Method"
ms.date: "10/07/2016"
ms.assetid: a80a7157-39a1-6c4e-ef4b-c03d6e913361
---
# IHttpServer::RecycleApplication Method
Recycles an application.  
  
## Syntax  
  
```cpp  
virtual VOID RecycleApplication(  
   PCWSTR pszAppConfigPath  
) = 0;  
```  
  
### Parameters  
 `pszAppConfigPath`  
 A pointer to a string that contains the configuration path to recycle.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 The `RecycleApplication` method will request a recycle of the application that is specified by the configuration path in the `pszAppConfigPath` parameter. For example, the configuration path for the default Web site on a server running [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] will usually resemble MACHINE/WEBROOT/APPHOST/Default Web Site.  
  
> [!NOTE]
>  You can retrieve the configuration path by using the [IHttpApplication::GetAppConfigPath](../../web-development-reference/native-code-api-reference/ihttpapplication-getappconfigpath-method.md) method.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that uses the [IHttpApplication::GetAppConfigPath](../../web-development-reference/native-code-api-reference/ihttpapplication-getappconfigpath-method.md) and `RecycleApplication` methods to retrieve and recycle the managed application that is processing the current request.  
  
 [!code-cpp[IHttpServerRecycleApplication#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpServerRecycleApplication/cpp/IHttpServerRecycleApplication.cpp#1)]  
  
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
 [IHttpApplication::GetAppConfigPath Method](../../web-development-reference/native-code-api-reference/ihttpapplication-getappconfigpath-method.md)   
 [IHttpServer Interface](../../web-development-reference/native-code-api-reference/ihttpserver-interface.md)   
 [IHttpServer::RecycleProcess Method](../../web-development-reference/native-code-api-reference/ihttpserver-recycleprocess-method.md)