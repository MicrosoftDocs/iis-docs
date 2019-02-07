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
Provides methods that access a specific invocation instance of the corresponding [IAppHostMethod Interface](../../web-development-reference\webdev-native-api-reference/iapphostmethod-interface.md).  
  
## Syntax  
  
```cpp  
IAppHostMethodInstance : public IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostMethodInstance` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[Execute](../../web-development-reference\webdev-native-api-reference/iapphostmethodinstance-execute-method.md)|Executes the specified method.|  
|[GetMetadata](../../web-development-reference\webdev-native-api-reference/iapphostmethodinstance-getmetadata-method.md)|Gets the named metadata.|  
|[SetMetadata](../../web-development-reference\webdev-native-api-reference/iapphostmethodinstance-setmetadata-method.md)|Sets the named metadata|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostMethodInstance` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[Input](../../web-development-reference\webdev-native-api-reference/iapphostmethodinstance-input-property.md)|Gets an [IAppHostElement Interface](../../web-development-reference\webdev-native-api-reference/iapphostelement-interface.md) that may contain input parameters for a specified method instance call.|  
|[Output](../../web-development-reference\webdev-native-api-reference/iapphostmethodinstance-output-property.md)|Gets an [IAppHostElement Interface](../../web-development-reference\webdev-native-api-reference/iapphostelement-interface.md) in which output parameters may be retrieved after a specified method instance has been executed.|  
  
## Remarks  
 The caller of a method sets parameters and then executes the instance of the method.  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostMethodInstance`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../web-development-reference\webdev-native-api-reference/application-host-administration-interfaces.md)   
 [Application Host Administration API Reference](../../web-development-reference\webdev-native-api-reference/application-host-administration-api-reference.md)   
 [IAppHostMethod Interface](../../web-development-reference\webdev-native-api-reference/iapphostmethod-interface.md)