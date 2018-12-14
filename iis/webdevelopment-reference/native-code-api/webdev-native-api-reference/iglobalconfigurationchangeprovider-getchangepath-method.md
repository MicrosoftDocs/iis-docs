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
 The `GetChangePath` method retrieves the configuration path that triggered a [GL_CONFIGURATION_CHANGE](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) notification. For example, the configuration path for the default Web site on a server running [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] will usually resemble MACHINE/WEBROOT/APPHOST/Default Web Site.  
  
## Example  
 The following code example demonstrates how to create a global-level HTTP module that uses the `GetChangePath` method to retrieve the path for a configuration change and add a log entry to the Event Viewer.  
  
 For example, when the ApplicationHost.config file is changed by using the [!INCLUDE[iismgr](../../../wmi-provider/includes/iismgr-md.md)] application, an event that contains the configuration path will be written to the Event Viewer.  
  
<!-- TODO: review snippet reference  [!CODE [IGlobalConfigurationChangeProviderGetChangePath#1](IGlobalConfigurationChangeProviderGetChangePath#1)]  -->  
  
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
 [IGlobalConfigurationChangeProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalconfigurationchangeprovider-interface.md)