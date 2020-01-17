---
title: "IHttpServer::NotifyFileChange Method"
ms.date: "10/07/2016"
ms.assetid: b807132a-9aa7-73fc-06d7-ec7412ec0588
---
# IHttpServer::NotifyFileChange Method
Triggers a notification that a file has changed.  
  
## Syntax  
  
```cpp  
virtual VOID NotifyFileChange(  
   IN PCWSTR pszFileName  
) = 0;  
```  
  
### Parameters  
 `pszFileName`  
 [IN] A pointer to a string that contains the path to a file.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] automatically triggers a [GL_FILE_CHANGE](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification when a file within a Web site is modified. Developers can use the `NotifyFileChange` method to manually trigger a `GL_FILE_CHANGE` notification for a file path that is specified in the `pszFileName` parameter.  
  
> [!NOTE]
>  Developers can use the [CGlobalModule::OnGlobalFileChange](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalfilechange-method.md) method to provide additional processing when a `GL_FILE_CHANGE` notification occurs.  
  
## Example  
 The following code example demonstrates how to use the `NotifyFileChange` method to create an HTTP module that manually triggers a `GL_FILE_CHANGE` notification for the C:\Inetpub\Wwwroot\Default.aspx file.  
  
 [!code-cpp[IHttpServerNotifyFileChange#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpServerNotifyFileChange/cpp/IHttpServerNotifyFileChange.cpp#1)]  
  
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
 [CGlobalModule::OnGlobalFileChange Method](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalfilechange-method.md)   
 [Request-Processing Constants](../../web-development-reference/native-code-api-reference/request-processing-constants.md)