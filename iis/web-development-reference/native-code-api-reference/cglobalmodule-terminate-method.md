---
title: "CGlobalModule::Terminate Method"
ms.date: "10/07/2016"
ms.assetid: d9da74a3-e716-1785-e600-08337d75bfc5
---
# CGlobalModule::Terminate Method
Represents the method that IIS calls when a global module has completed processing.  
  
## Syntax  
  
```cpp  
virtual VOID Terminate(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 IIS calls the `Terminate` method for a [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) before a module is unloaded.  
  
> [!IMPORTANT]
>  Developers should use the `Terminate` method to remove implementations of `CGlobalModule` classes from memory.  
  
## Example  
 The following code example demonstrates how to create a simple "Hello World" global-level HTTP module. The module defines an exported [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function that creates an instance of a class that is derived from `CGlobalModule`. If the class cannot be created, the function exits with an error code; otherwise, the function calls the [IHttpModuleRegistrationInfo::SetRequestNotifications](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-setrequestnotifications-method.md) method to register for the [GL_PRE_BEGIN_REQUEST](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification.  
  
 When a `GL_PRE_BEGIN_REQUEST` notification occurs, IIS calls the module's [CGlobalModule::OnGlobalPreBeginRequest](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalprebeginrequest-method.md) method to process the notification. The method calls a private method to write an event to the application log of the Event Viewer, and then it returns [GL_NOTIFICATION_CONTINUE](../../web-development-reference/native-code-api-reference/global-notification-status-enumeration.md) to notify IIS to continue processing other notifications. When processing is complete, IIS calls the module's `Terminate` method to remove the class from memory.  
  
 [!code-cpp[CGlobalModuleHelloWorld#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/CGlobalModuleHelloWorld/cpp/CGlobalModuleHelloWorld.cpp#1)]  
  
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