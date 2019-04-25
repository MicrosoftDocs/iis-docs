---
title: "CGlobalModule::OnGlobalThreadCleanup Method"
ms.date: "10/07/2016"
ms.assetid: 2aaac10f-de71-71ff-5547-a098f91e717d
---
# CGlobalModule::OnGlobalThreadCleanup Method
Represents the method that will handle a `GlobalThreadCleanup` event, which occurs when IIS returns a thread to the thread pool.  
  
## Syntax  
  
```cpp  
virtual GLOBAL_NOTIFICATION_STATUS OnGlobalThreadCleanup(  
   IN IGlobalThreadCleanupProvider* pProvider  
);  
```  
  
### Parameters  
 `pProvider`  
 [IN] A pointer to an [IGlobalThreadCleanupProvider](../../web-development-reference/native-code-api-reference/iglobalthreadcleanupprovider-interface.md) interface.  
  
## Return Value  
 A [GLOBAL_NOTIFICATION_STATUS](../../web-development-reference/native-code-api-reference/global-notification-status-enumeration.md) value.  
  
## Remarks  
 When a global module has registered for the [GL_THREAD_CLEANUP](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification, IIS will call the module's `OnGlobalThreadCleanup` method when a thread is returned to the thread pool after an operation has completed.  
  
> [!NOTE]
>  Global modules can register for the `GlobalThreadCleanup` event notification by registering for `GL_THREAD_CLEANUP` in the module's [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1.  The module registers for the `GL_THREAD_CLEANUP` notification.  
  
2.  The module creates a [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) class that contains an `OnGlobalThreadCleanup` method. This method performs the following tasks:  
  
    1.  Retrieves an [IHttpApplication](../../web-development-reference/native-code-api-reference/ihttpapplication-interface.md) interface by using the [IGlobalThreadCleanupProvider::GetApplication](../../web-development-reference/native-code-api-reference/iglobalthreadcleanupprovider-getapplication.md) method.  
  
    2.  Retrieves the application identifier of the current context's application by using the [IHttpApplication::GetApplicationId](../../web-development-reference/native-code-api-reference/ihttpapplication-getapplicationid-method.md) method.  
  
    3.  Writes the application identifier information as an event to the application log of the Event Viewer.  
  
3.  The module removes the `CGlobalModule` class from memory and then exits.  
  
 [!code-cpp[IGlobalThreadCleanupProviderGetApplication#1](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/IGlobalThreadCleanupProviderGetApplication/cpp/IGlobalThreadCleanupProviderGetApplication.cpp#1)]  
  
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