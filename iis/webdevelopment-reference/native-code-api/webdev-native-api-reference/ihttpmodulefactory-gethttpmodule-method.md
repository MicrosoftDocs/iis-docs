---
title: "IHttpModuleFactory::GetHttpModule Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: cc84322a-c40b-5296-1d42-20af0f7e4e95
caps.latest.revision: 12
author: "shirhatti"
manager: "wpickett"
---
# IHttpModuleFactory::GetHttpModule Method
Creates an instance of a [CHttpModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-class.md) class.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetHttpModule(  
   OUT CHttpModule** ppModule,  
   IN IModuleAllocator* pAllocator  
) = 0;  
```  
  
#### Parameters  
 `ppModule`  
 [OUT] A dereferenced pointer to a [CHttpModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-class.md) class.  
  
 `pAllocator`  
 [IN] A pointer to an [IModuleAllocator](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/imoduleallocator-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
> [!NOTE]
>  Because your module factory is required to provide a `GetHttpModule` method, you can provide any status code for the return value as appropriate for your application. At the very least, your `GetHttpModule` method should return S_OK to indicate a successful completion.  
  
## Remarks  
 An [IHttpModuleFactory](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulefactory-interface.md) interface must provide a `GetHttpModule` method that creates an instance of your `CHttpModule` class. When IIS calls your module's exported [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function, IIS will use module factory's `GetHttpModule` method to create an instance of your `CHttpModule` class.  
  
## Example  
 The following code example demonstrates how to create a simple "Hello World" HTTP module. The module defines an exported `RegisterModule` function that passes an instance of an `IHttpModuleFactory` interface to the [IHttpModuleRegistrationInfo::SetRequestNotifications](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setrequestnotifications-method.md) method and registers for the [RQ_BEGIN_REQUEST](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) notification. IIS uses the `GetHttpModule` method to create an instance of a `CHttpModule` class and returns a success status. IIS also uses the [Terminate](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulefactory-terminate-method.md) method of the `IHttpModuleFactory` interface to remove the factory from memory.  
  
 When a `RQ_BEGIN_REQUEST` notification is triggered, IIS calls the module's [CHttpModule::OnBeginRequest](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-onbeginrequest-method.md) method to process the current request. `OnBeginRequest` clears the response buffer and modifies the MIME type for the response. The method then creates a data chunk that contains a "Hello World" string and returns the string to a Web client. Finally, the module returns a status indicator that notifies IIS that all notifications are finished and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [CHttpModuleHelloWorld#1](CHttpModuleHelloWorld#1)]  -->  
  
 Your module must export the `RegisterModule` function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [CHttpModule Class](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-class.md)   
 [IHttpModuleFactory Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulefactory-interface.md)   
 [Designing Native-Code HTTP Modules](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/designing-native-code-http-modules.md)   
 [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md)