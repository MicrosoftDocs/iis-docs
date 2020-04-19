---
title: "IHttpServer::GetWorkerProcessSettings Method"
ms.date: "10/07/2016"
ms.assetid: 37efa150-d336-b2d7-77f8-872fb5887f7f
---
# IHttpServer::GetWorkerProcessSettings Method
Retrieves an [IWpfSettings](../../web-development-reference/native-code-api-reference/iwpfsettings-interface.md) interface.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetWorkerProcessSettings(  
   IWpfSettings** ppWorkerProcessSettings  
) = 0;  
```  
  
### Parameters  
 `ppWorkerProcessSettings`  
 A dereferenced pointer to an [IWpfSettings](../../web-development-reference/native-code-api-reference/iwpfsettings-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 The `GetWorkerProcessSettings` method allows developers to retrieve configuration information about the worker process framework through an [IWpfSettings](../../web-development-reference/native-code-api-reference/iwpfsettings-interface.md) interface.  
  
> [!NOTE]
>  The server controls the lifetime and reference counting for `IWpfSettings`.  
  
 `IWpfSettings` exposes several methods that you can use to retrieve specific information about the worker process framework. For example, the [IWpfSettings::GetDwordProperty](../../web-development-reference/native-code-api-reference/iwpfsettings-getdwordproperty-method.md) method enables you to retrieve the [IDLE_TIMEOUT](../../web-development-reference/native-code-api-reference/wpf-settings-dword-enum-enumeration.md) or [PERIODIC_RESTART_TIME](../../web-development-reference/native-code-api-reference/wpf-settings-dword-enum-enumeration.md) settings.  
  
## Example  
 The following code example illustrates how to use the `GetWorkerProcessSettings` method to create an HTTP module that retrieves the version of the common language runtime (CLR) on the server. The module then returns that information to a Web client.  
  
 [!code-cpp[IHttpServerGetWorkerProcessSettings#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpServerGetWorkerProcessSettings/cpp/IHttpServerGetWorkerProcessSettings.cpp#1)]  
  
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
 [IWpfSettings Interface](../../web-development-reference/native-code-api-reference/iwpfsettings-interface.md)