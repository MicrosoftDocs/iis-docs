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
Accepts a validated [IHttpUser](../../web-development-reference\native-code-api-reference/ihttpuser-interface.md) pointer through the [SetUser](../../web-development-reference\native-code-api-reference/iauthenticationprovider-setuser-method.md) method. Once a non-NULL `IHttpUser` pointer is set, the user is authenticated and request processing can continue.  
  
## Syntax  
  
```cpp  
class IAuthenticationProvider : public IHttpEventProvider  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAuthenticationProvider` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[SetErrorStatus](../../web-development-reference\native-code-api-reference/ihttpeventprovider-seterrorstatus-method.md)|(Inherited from [IHttpEventProvider](../../web-development-reference\native-code-api-reference/ihttpeventprovider-interface.md).)|  
|[SetUser](../../web-development-reference\native-code-api-reference/iauthenticationprovider-setuser-method.md)|Sets the authenticated user on the authentication provider.|  
  
## Derived Classes  
 This class contains no derived classes.  
  
## Remarks  
 [CHttpModule](../../web-development-reference\native-code-api-reference/chttpmodule-class.md) derived classes that register for [RQ_AUTHENTICATE_REQUEST](../../web-development-reference\native-code-api-reference/request-processing-constants.md) events receive an `IAuthenticationProvider` pointer as a parameter on the [CHttpModule::OnAuthenticateRequest](../../web-development-reference\native-code-api-reference/chttpmodule-onauthenticaterequest-method.md) virtual method.  
  
## Inheritance Hierarchy  
 [IHttpEventProvider](../../web-development-reference\native-code-api-reference/ihttpeventprovider-interface.md)  
  
 `IAuthenticationProvider`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [CHttpModule Class](../../web-development-reference\native-code-api-reference/chttpmodule-class.md)   
 [CHttpModule::OnAuthenticateRequest Method](../../web-development-reference\native-code-api-reference/chttpmodule-onauthenticaterequest-method.md)