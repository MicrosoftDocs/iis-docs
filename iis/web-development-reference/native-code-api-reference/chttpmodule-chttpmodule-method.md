---
title: "CHttpModule::CHttpModule Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 8b95c504-0a60-4676-8708-1765f91d7f6d
caps.latest.revision: 13
author: "shirhatti"
manager: "wpickett"
---
# CHttpModule::CHttpModule Method
Initializes a new instance of the [CHttpModule](../../web-development-reference\webdev-native-api-reference/chttpmodule-class.md) class.  
  
## Syntax  
  
```cpp  
CHttpModule (  
);  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Remarks  
 The constructor for the `CHttpModule` class is `protected` to prevent the direct creation of a `CHttpModule` class. You must create a class that is derived from `CHttpModule`, because `CHttpModule` defines pure `virtual` methods that derived classes must implement.  
  
## Example  
 The following code example demonstrates how to create a request-level HTTP module that registers for the [RQ_BEGIN_REQUEST](../../web-development-reference\webdev-native-api-reference/request-processing-constants.md) event notification. When a request enters the integrated request-processing pipeline, IIS will call the example module's [OnBeginRequest](../../web-development-reference\webdev-native-api-reference/chttpmodule-onbeginrequest-method.md) method. This method will write an entry in the application log of the Windows Event Viewer that contains "Hello World!" in the event data. When processing is complete, the module will exit.  
  
<!-- TODO: review snippet reference  [!CODE [CHttpModuleHelloWorldEventViewer#1](CHttpModuleHelloWorldEventViewer#1)]  -->  
  
 Your module must export the [RegisterModule](../../web-development-reference\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [CHttpModule Class](../../web-development-reference\webdev-native-api-reference/chttpmodule-class.md)   
 [REQUEST_NOTIFICATION_STATUS Enumeration](../../web-development-reference\webdev-native-api-reference/request-notification-status-enumeration.md)