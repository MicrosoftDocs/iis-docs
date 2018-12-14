---
title: "IAppHostMethodInstance Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: bd4b1420-4828-4fde-b0c9-5257cf408d5e
caps.latest.revision: 7
author: "shirhatti"
manager: "wpickett"
---
# IAppHostMethodInstance Interface
Provides methods that access a specific invocation instance of the corresponding [IAppHostMethod Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostmethod-interface.md).  
  
## Syntax  
  
```cpp  
IAppHostMethodInstance : public IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostMethodInstance` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[Execute](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostmethodinstance-execute-method.md)|Executes the specified method.|  
|[GetMetadata](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostmethodinstance-getmetadata-method.md)|Gets the named metadata.|  
|[SetMetadata](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostmethodinstance-setmetadata-method.md)|Sets the named metadata|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostMethodInstance` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[Input](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostmethodinstance-input-property.md)|Gets an [IAppHostElement Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-interface.md) that may contain input parameters for a specified method instance call.|  
|[Output](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostmethodinstance-output-property.md)|Gets an [IAppHostElement Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-interface.md) in which output parameters may be retrieved after a specified method instance has been executed.|  
  
## Remarks  
 The caller of a method sets parameters and then executes the instance of the method.  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostMethodInstance`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/application-host-administration-interfaces.md)   
 [Application Host Administration API Reference](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/application-host-administration-api-reference.md)   
 [IAppHostMethod Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostmethod-interface.md)