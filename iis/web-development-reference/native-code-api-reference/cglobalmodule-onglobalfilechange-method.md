---
title: "CGlobalModule::OnGlobalFileChange Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: e7a07497-0000-13b4-34bd-82f9a3cbf266
caps.latest.revision: 13
author: "shirhatti"
manager: "wpickett"
---
# CGlobalModule::OnGlobalFileChange Method
Represents the method that will handle a `GlobalFileChange` event, which occurs when a file within a Web site is changed.  
  
## Syntax  
  
```cpp  
virtual GLOBAL_NOTIFICATION_STATUS OnGlobalFileChange(  
   IN IGlobalFileChangeProvider* pProvider  
);  
```  
  
#### Parameters  
 `pProvider`  
 [IN] A pointer to an [IGlobalFileChangeProvider](../../web-development-reference\native-code-api-reference/iglobalfilechangeprovider-interface.md) interface.  
  
## Return Value  
 A [GLOBAL_NOTIFICATION_STATUS](../../web-development-reference\native-code-api-reference/global-notification-status-enumeration.md) value.  
  
## Remarks  
 When a global module has registered for the [GL_FILE_CHANGE](../../web-development-reference\native-code-api-reference/request-processing-constants.md) event notification, IIS will call the module's `OnGlobalFileChange` method when a file within the scope of a Web site is changed.  
  
> [!NOTE]
>  Global modules can register for the `GlobalFileChange` event notification by registering for `GL_FILE_CHANGE` in the module's [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function.  
  
 IIS creates an [IGlobalFileChangeProvider](../../web-development-reference\native-code-api-reference/iglobalfilechangeprovider-interface.md) interface and passes the interface to a module's `OnGlobalFileChange` method. Developers can use this interface to retrieve information about the file that was changed.  
  
## Example  
 The following code example demonstrates how to create a global-level HTTP module that uses the [IGlobalFileChangeProvider::GetFileName](../../web-development-reference\native-code-api-reference/iglobalfilechangeprovider-getfilename-method.md) method to retrieve the path to a file that has been modified. The module then writes the path of the file to a log entry in the Event Viewer.  
  
<!-- TODO: review snippet reference  [!CODE [IGlobalFileChangeProviderGetFileName#1](IGlobalFileChangeProviderGetFileName#1)]  -->  
  
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