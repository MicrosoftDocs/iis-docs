---
title: "CHttpModule::OnMapPath Method"
ms.date: "10/07/2016"
ms.assetid: 4c9cdb28-6efc-67d0-31d1-7fe043851a45
---
# CHttpModule::OnMapPath Method
Represents the method that will handle a `MapPath` event, which occurs when an operation requests the physical path to be mapped for the current request.  
  
## Syntax  
  
```cpp  
virtual REQUEST_NOTIFICATION_STATUS OnMapPath(  
   IN IHttpContext* pHttpContext,  
   IN IMapPathProvider* pProvider  
);  
```  
  
### Parameters  
 `pHttpContext`  
 [IN] A pointer to an [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md) interface.  
  
 `pProvider`  
 [IN] A pointer to an [IMapPathProvider](../../web-development-reference/native-code-api-reference/imappathprovider-interface.md) interface.  
  
## Return Value  
 A [REQUEST_NOTIFICATION_STATUS](../../web-development-reference/native-code-api-reference/request-notification-status-enumeration.md) value.  
  
## Remarks  
 When a request-level module is registered for the [RQ_MAP_PATH](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification, IIS will call the module's `OnMapPath` method when an operation requests the physical path to be mapped for the current request.  
  
> [!NOTE]
>  Request-level modules can register for the `MapPath` event notification by registering for `RQ_MAP_PATH` in the module's [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function.  
  
## Example  
 The following code example demonstrates how to create a request-level HTTP module that registers for the `RQ_MAP_PATH` event notifications. When an operation requests the physical path to be mapped for the current request, IIS will call the example module's `OnMapPath` method.  
  
 [!code-cpp[_MapPath#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/_MapPath/cpp/module.cpp#1)]  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [CHttpModule Class](../../web-development-reference/native-code-api-reference/chttpmodule-class.md)
