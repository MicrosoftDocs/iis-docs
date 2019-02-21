---
title: "CGlobalModule::OnGlobalApplicationStart Method"
ms.date: "10/07/2016"
ms.assetid: 174fe925-4d25-a984-1573-0d13eeab7d8c
---
# CGlobalModule::OnGlobalApplicationStart Method
Represents the method that will handle a `GlobalApplicationStart` event, which occurs when IIS starts an application.  
  
## Syntax  
  
```cpp  
virtual GLOBAL_NOTIFICATION_STATUS OnGlobalApplicationStart(  
   IN IHttpApplicationStartProvider* pProvider  
);  
```  
  
### Parameters  
 `pProvider`  
 [IN] A pointer to an [IHttpApplicationStartProvider](../../web-development-reference\native-code-api-reference/ihttpapplicationprovider-interface.md) interface.  
  
> [!NOTE]
> The `IHttpApplicationStartProvider` interface is a type definition of an [IHttpApplicationProvider](../../web-development-reference\native-code-api-reference/ihttpapplicationprovider-interface.md) interface.  
  
## Return Value  
 A [GLOBAL_NOTIFICATION_STATUS](../../web-development-reference\native-code-api-reference/global-notification-status-enumeration.md) value.  
  
## Remarks  
 When a global module has registered for the [GL_APPLICATION_START](../../web-development-reference\native-code-api-reference/request-processing-constants.md) event notification, IIS will call the module's `OnGlobalApplicationStart` method when it starts an application.  
  
> [!NOTE]
> Global modules can register for the `GlobalApplicationStart` event notification by registering for `GL_APPLICATION_START` in the module's [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function.  
  
## Example  
 The following code example demonstrates how to create a global-level HTTP module that registers for the `GL_APPLICATION_START` notification. When IIS starts an application, it will call the example module's `OnGlobalApplicationStart` method. This method will write an entry in the application log of the Windows Event Viewer and then exit.  
  
<!-- TODO: review snippet reference  [!CODE [CGlobalModuleGlobalApplicationStart#1](CGlobalModuleGlobalApplicationStart#1)]  -->  
  
 Your module must export the [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Global-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-global-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [CGlobalModule Class](../../web-development-reference\native-code-api-reference/cglobalmodule-class.md)   
 [CGlobalModule::OnGlobalApplicationStop Method](../../web-development-reference\native-code-api-reference/cglobalmodule-onglobalapplicationstop-method.md)