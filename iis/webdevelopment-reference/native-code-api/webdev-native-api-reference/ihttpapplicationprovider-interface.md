---
title: "IHttpApplicationProvider Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 3aae3259-655e-382f-8fb4-6bfa24b1e3f9
caps.latest.revision: 21
author: "shirhatti"
manager: "wpickett"
---
# IHttpApplicationProvider Interface
Provides an interface for application startup notifications.  
  
## Syntax  
  
```cpp  
class IHttpApplicationProvider : public IHttpEventProvider  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpApplicationProvider` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetApplication](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpapplicationprovider-getapplication-method.md)|Retrieves an [IHttpApplication](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpapplication-interface.md) interface.|  
|[SetErrorStatus](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-seterrorstatus-method.md)|(Inherited from [IHttpEventProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-interface.md).)|  
  
## Derived Classes  
 The following table lists the derived classes exposed by the `IHttpApplicationProvider` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[IHttpApplicationResolveModulesProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpapplicationresolvemodulesprovider-interface.md)|Provides an interface for registering HTTP modules.|  
  
## Remarks  
 IIS creates and passes an `IHttpApplicationProvider` interface to a module's [CGlobalModule::OnGlobalApplicationStart](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalapplicationstart-method.md) method when the module has registered for the [GL_APPLICATION_START](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) notification in the module's exported [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function.  
  
## Inheritance Hierarchy  
 [IHttpEventProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-interface.md)  
  
 `IHttpApplicationProvider`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)   
 [CGlobalModule::OnGlobalApplicationStart Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalapplicationstart-method.md)