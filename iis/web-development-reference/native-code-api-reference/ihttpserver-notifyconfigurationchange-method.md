---
title: "IHttpServer::NotifyConfigurationChange Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: da798d70-df91-5214-1c4f-845d79ece45f
caps.latest.revision: 19
author: "shirhatti"
manager: "wpickett"
---
# IHttpServer::NotifyConfigurationChange Method
Triggers a notification that a configuration path has changed.  
  
## Syntax  
  
```cpp  
virtual VOID NotifyConfigurationChange(  
   PCWSTR pszPath  
) = 0;  
```  
  
#### Parameters  
 `pszPath`  
 A pointer to a string that contains the configuration path.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] automatically triggers a [GL_CONFIGURATION_CHANGE](../../web-development-reference\native-code-api-reference/request-processing-constants.md) notification when the ApplicationHost.config file is modified. Developers can use the `NotifyConfigurationChange` method to manually trigger a `GL_CONFIGURATION_CHANGE` notification for the configuration path that is specified in the `pszPath` parameter.  
  
> [!NOTE]
>  Developers can use the [CGlobalModule::OnGlobalConfigurationChange](../../web-development-reference\native-code-api-reference/cglobalmodule-onglobalconfigurationchange-method.md) method to provide additional processing when a `GL_CONFIGURATION_CHANGE` notification occurs.  
  
## Example  
 The following code example demonstrates how to use the `NotifyConfigurationChange` method to create an HTTP module that manually triggers a `GL_CONFIGURATION_CHANGE` notification for the MACHINE/WEBROOT/APPHOST/Default Web Site configuration path.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpServerNotifyConfigurationChange#1](IHttpServerNotifyConfigurationChange#1)]  -->  
  
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
 [IHttpServer Interface](../../web-development-reference\native-code-api-reference/ihttpserver-interface.md)   
 [CGlobalModule::OnGlobalConfigurationChange Method](../../web-development-reference\native-code-api-reference/cglobalmodule-onglobalconfigurationchange-method.md)