---
title: "IHttpApplication::GetAppConfigPath Method"
ms.date: "10/07/2016"
ms.assetid: 03799acd-fcad-0c04-f840-6065198e4c97
---
# IHttpApplication::GetAppConfigPath Method
Retrieves the application configuration path.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetAppConfigPath(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a string that contains the application configuration path.  
  
## Remarks  
 The `GetAppConfigPath` method returns the configuration path for the application that is processing the current request. For example, requests for the default Web site on a server running [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] will usually return the MACHINE/WEBROOT/APPHOST/Default Web Site path.  
  
## Example  
 The following code example demonstrates how to use the `GetAppConfigPath` method to create an HTTP module that retrieves the configuration path for the current application and returns this information to a Web client.  
  
 [!code-cpp[IHttpApplicationGetAppConfigPath#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpApplicationGetAppConfigPath/cpp/IHttpApplicationGetAppConfigPath.cpp#1)]  
  
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
 [IHttpApplication Interface](../../web-development-reference/native-code-api-reference/ihttpapplication-interface.md)
