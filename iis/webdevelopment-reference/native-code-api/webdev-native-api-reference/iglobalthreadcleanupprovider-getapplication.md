---
title: "IGlobalThreadCleanupProvider::GetApplication | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 58b4d588-36c4-574f-f180-02d305f7b22d
caps.latest.revision: 9
author: "shirhatti"
manager: "wpickett"
---
# IGlobalThreadCleanupProvider::GetApplication
Retrieves an [IHttpApplication](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpapplication-interface.md) interface.  
  
## Syntax  
  
```cpp  
virtual IHttpApplication* GetApplication(  
   VOID  
) = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an `IHttpApplication` interface.  
  
## Remarks  
 Developers can use the `GetApplication` method to retrieve an `IHttpApplication` interface, which they can then use to retrieve configuration information for an application.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1.  Registers for the [GL_THREAD_CLEANUP](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) notification.  
  
2.  Creates a [CGlobalModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-class.md) class that contains an [OnGlobalThreadCleanup](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalthreadcleanup-method.md) method. This method performs the following tasks:  
  
    1.  Retrieves an `IHttpApplication` interface by using the `GetApplication` method.  
  
    2.  Retrieves the application identifier of the current context's application by using the [IHttpApplication::GetApplicationId](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpapplication-getapplicationid-method.md) method.  
  
    3.  Writes the application identifier information as an event to the application log of the Event Viewer.  
  
3.  Removes the `CGlobalModule` class from memory and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IGlobalThreadCleanupProviderGetApplication#1](IGlobalThreadCleanupProviderGetApplication#1)]  -->  
  
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
 [IHttpApplication Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpapplication-interface.md)   
 [IGlobalThreadCleanupProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalthreadcleanupprovider-interface.md)