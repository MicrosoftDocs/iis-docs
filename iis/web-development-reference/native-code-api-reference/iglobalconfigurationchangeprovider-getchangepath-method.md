---
title: "IGlobalConfigurationChangeProvider::GetChangePath Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: bafedfc8-9b20-cef2-48cb-de1d8d9c1938
caps.latest.revision: 18
author: "shirhatti"
manager: "wpickett"
---
# IGlobalConfigurationChangeProvider::GetChangePath Method
Retrieves the path of a configuration change.  
  
## Syntax  
  
```cpp  
virtual VOID GetChangePath(  
   PCWSTR* ppszPath  
) const = 0;  
```  
  
#### Parameters  
 `ppszPath`  
 [OUT] A pointer to a `PCWSTR` value.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 The `GetChangePath` method retrieves the configuration path that triggered a [GL_CONFIGURATION_CHANGE](../../web-development-reference\native-code-api-reference/request-processing-constants.md) notification. For example, the configuration path for the default Web site on a server running [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] will usually resemble MACHINE/WEBROOT/APPHOST/Default Web Site.  
  
## Example  
 The following code example demonstrates how to create a global-level HTTP module that uses the `GetChangePath` method to retrieve the path for a configuration change and add a log entry to the Event Viewer.  
  
 For example, when the ApplicationHost.config file is changed by using the [!INCLUDE[iismgr](../../wmi-provider/includes/iismgr-md.md)] application, an event that contains the configuration path will be written to the Event Viewer.  
  
<!-- TODO: review snippet reference  [!CODE [IGlobalConfigurationChangeProviderGetChangePath#1](IGlobalConfigurationChangeProviderGetChangePath#1)]  -->  
  
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
 [IGlobalConfigurationChangeProvider Interface](../../web-development-reference\native-code-api-reference/iglobalconfigurationchangeprovider-interface.md)