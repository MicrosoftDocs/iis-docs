---
title: "IAuthenticationProvider Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 0b7fa94a-41b3-0863-1549-ad130e749269
caps.latest.revision: 29
author: "shirhatti"
manager: "wpickett"
---
# IAuthenticationProvider Interface
Accepts a validated [IHttpUser](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-interface.md) pointer through the [SetUser](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iauthenticationprovider-setuser-method.md) method. Once a non-NULL `IHttpUser` pointer is set, the user is authenticated and request processing can continue.  
  
## Syntax  
  
```cpp  
class IAuthenticationProvider : public IHttpEventProvider  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAuthenticationProvider` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[SetErrorStatus](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-seterrorstatus-method.md)|(Inherited from [IHttpEventProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-interface.md).)|  
|[SetUser](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iauthenticationprovider-setuser-method.md)|Sets the authenticated user on the authentication provider.|  
  
## Derived Classes  
 This class contains no derived classes.  
  
## Remarks  
 [CHttpModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-class.md) derived classes that register for [RQ_AUTHENTICATE_REQUEST](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) events receive an `IAuthenticationProvider` pointer as a parameter on the [CHttpModule::OnAuthenticateRequest](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-onauthenticaterequest-method.md) virtual method.  
  
## Inheritance Hierarchy  
 [IHttpEventProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-interface.md)  
  
 `IAuthenticationProvider`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [CHttpModule Class](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-class.md)   
 [CHttpModule::OnAuthenticateRequest Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-onauthenticaterequest-method.md)