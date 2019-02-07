---
title: "CHttpModule::OnReadEntity Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 97ba205d-2c55-d9e1-c0b1-36928035fd74
caps.latest.revision: 18
author: "shirhatti"
manager: "wpickett"
---
# CHttpModule::OnReadEntity Method
Represents the method that will handle a `ReadEntity` event, which occurs when an operation reads data from the request buffer.  
  
## Syntax  
  
```cpp  
virtual REQUEST_NOTIFICATION_STATUS OnReadEntity(  
   IN IHttpContext* pHttpContext,  
   IN IReadEntityProvider* pProvider  
);  
```  
  
#### Parameters  
 `pHttpContext`  
 [IN] A pointer to an [IHttpContext](../../web-development-reference\webdev-native-api-reference/ihttpcontext-interface.md) interface.  
  
 `pProvider`  
 [IN] A pointer to an [IReadEntityProvider](../../web-development-reference\webdev-native-api-reference/ireadentityprovider-interface.md) interface.  
  
## Return Value  
 A [REQUEST_NOTIFICATION_STATUS](../../web-development-reference\webdev-native-api-reference/request-notification-status-enumeration.md) value.  
  
## Remarks  
 When a request-level module has registered for the [RQ_READ_ENTITY](../../web-development-reference\webdev-native-api-reference/request-processing-constants.md) event notification, IIS will call the module's `OnReadEntity` method when an operation reads data from the request buffer.  
  
> [!NOTE]
>  Request-level modules can register for the `PostReadEntity` event notification by registering for `RQ_READ_ENTITY` in the module's [RegisterModule](../../web-development-reference\webdev-native-api-reference/pfn-registermodule-function.md) function.  
  
## Example  
 The following example demonstrates how to create a request-level HTTP module that registers for the `RQ_READ_ENTITY` event notification. When IIS reads data from the request buffer, it will call the example module's `OnReadEntity` method. A simple HTML or [!INCLUDE[vstecasp](../../wmi-provider/includes/vstecasp-md.md)] page that performs a post will cause the example code to run.  
  
<!-- TODO: review snippet reference  [!CODE [CHttpModuleReadEntity#1](CHttpModuleReadEntity#1)]  -->  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [CHttpModule Class](../../web-development-reference\webdev-native-api-reference/chttpmodule-class.md)