---
title: "CGlobalModule::OnGlobalPreBeginRequest Method"
ms.date: "10/07/2016"
ms.assetid: 1c552a04-f229-33c5-af7f-05d28e55b9c9
---
# CGlobalModule::OnGlobalPreBeginRequest Method
Represents the method that will handle a `GlobalPreBeginRequest` event, which occurs before a request enters the pipeline.  
  
## Syntax  
  
```cpp  
virtual GLOBAL_NOTIFICATION_STATUS OnGlobalPreBeginRequest(  
   IN IPreBeginRequestProvider* pProvider  
);  
```  
  
### Parameters  
 `pProvider`  
 [IN] A pointer to an [IPreBeginRequestProvider](../../web-development-reference/native-code-api-reference/iprebeginrequestprovider-interface.md) interface.  
  
## Return Value  
 A [GLOBAL_NOTIFICATION_STATUS](../../web-development-reference/native-code-api-reference/global-notification-status-enumeration.md) value.  
  
## Remarks  
 When a global module has registered for the [GL_PRE_BEGIN_REQUEST](../../web-development-reference/native-code-api-reference/request-processing-constants.md) event notification, IIS will call the module's `OnGlobalPreBeginRequest` method before a request enters the request pipeline.  
  
> [!NOTE]
>  Global modules can register for the `GlobalPreBeginRequest` event notification by registering for `GL_PRE_BEGIN_REQUEST` in the module's [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function.  
  
## Example  
 The following code example demonstrates how to create a global-level HTTP module that registers for the `GL_PRE_BEGIN_REQUEST` notification. When a new request arrives, IIS will call the example module's `OnGlobalPreBeginRequest` method before the request enters the request pipeline. This method will write an entry in the application log of the Windows Event Viewer and then exit.  
  
 [!code-cpp[CGlobalModuleGlobalPreBeginRequest#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/CGlobalModuleGlobalPreBeginRequest/cpp/CGlobalModuleGlobalPreBeginRequest.cpp#1)]  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Global-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-global-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [CGlobalModule Class](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md)
