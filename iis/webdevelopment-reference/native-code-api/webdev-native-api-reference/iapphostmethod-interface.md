---
title: "IAppHostMethod Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 86f78e95-288b-4fd5-979c-33a4a0e891e9
caps.latest.revision: 7
author: "shirhatti"
manager: "wpickett"
---
# IAppHostMethod Interface
Provides access to a custom method that is optionally supported on an [IAppHostElement Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-interface.md) object.  
  
## Syntax  
  
```cpp  
interface IAppHostMethod : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostMethod` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[IAppHostMethod::CreateInstance Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostmethod-createinstance-method.md)|Creates an executable  [IAppHostMethodInstance Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostmethodinstance-interface.md) object from the current method.|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostMethod` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[IAppHostMethod::Name Property](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostmethod-name-property.md)|Gets the name of the method.|  
|[IAppHostMethod::Schema Property](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostmethod-schema-property.md)|Gets the schema assigned to the current method.|  
  
## Remarks  
 [IAppHostElement Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-interface.md) objects provide a means for an administration system to support custom-defined methods that can be executed against a specific [IAppHostElement Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-interface.md) object. The methods are executed on the server side and the implementation of these custom methods is not exposed to the client.  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostMethod`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/application-host-administration-interfaces.md)   
 [IAppHostElement Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-interface.md)   
 [IAppHostMethodInstance Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostmethodinstance-interface.md)   
 [IAppHostMethodExtension Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostmethodextension-interface.md)