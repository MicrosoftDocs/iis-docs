---
title: "IHttpServer::GetWorkerProcessSettings Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 37efa150-d336-b2d7-77f8-872fb5887f7f
caps.latest.revision: 21
author: "shirhatti"
manager: "wpickett"
---
# IHttpServer::GetWorkerProcessSettings Method
Retrieves an [IWpfSettings](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfsettings-interface.md) interface.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetWorkerProcessSettings(  
   IWpfSettings** ppWorkerProcessSettings  
) = 0;  
```  
  
#### Parameters  
 `ppWorkerProcessSettings`  
 A dereferenced pointer to an [IWpfSettings](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfsettings-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 The `GetWorkerProcessSettings` method allows developers to retrieve configuration information about the worker process framework through an [IWpfSettings](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfsettings-interface.md) interface.  
  
> [!NOTE]
>  The server controls the lifetime and reference counting for `IWpfSettings`.  
  
 `IWpfSettings` exposes several methods that you can use to retrieve specific information about the worker process framework. For example, the [IWpfSettings::GetDwordProperty](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfsettings-getdwordproperty-method.md) method enables you to retrieve the [IDLE_TIMEOUT](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-dword-enum-enumeration.md) or [PERIODIC_RESTART_TIME](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-dword-enum-enumeration.md) settings.  
  
## Example  
 The following code example illustrates how to use the `GetWorkerProcessSettings` method to create an HTTP module that retrieves the version of the common language runtime (CLR) on the server. The module then returns that information to a Web client.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpServerGetWorkerProcessSettings#1](IHttpServerGetWorkerProcessSettings#1)]  -->  
  
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
 [IHttpServer Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-interface.md)   
 [IWpfSettings Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfsettings-interface.md)