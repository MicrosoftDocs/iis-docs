---
title: "IAppHostMethodExtension Interface"
ms.date: "10/07/2016"
ms.assetid: 2018753d-8528-44f4-a4c3-dbde51b5f2ef
---
# IAppHostMethodExtension Interface
Used to handle method extensions in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.  
  
## Syntax  
  
```cpp  
IAppHostMethodExtension : public IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostMethodExtension` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[IAppHostMethodExtension::ProvideMethod Method](../../web-development-reference\native-code-api-reference/iapphostmethodextension-providemethod-method.md)|Populates the value of a dynamic method in a specified element.|  
  
## Properties  
 This interface contains no properties.  
  
## Remarks  
 When this interface is implemented, the configuration system will call it to handle dynamic configuration.  
  
 The administration system allows dynamic methods to be defined, provided that they are backed by a class that implements the `IAppHostMethodExtension` interface.  
  
> [!NOTE]
>  The `IAppHostMethodExtension` interface is designed to work on a local computer; you cannot use this interface to manage a remote computer.  
  
## Inheritance Hierarchy  
 [IUnknown](https://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostMethodExtension`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../web-development-reference\native-code-api-reference/application-host-administration-interfaces.md)   
 [Application Host Administration API Reference](../../web-development-reference\native-code-api-reference/application-host-administration-api-reference.md)   
 [IAppHostMethod Interface](../../web-development-reference\native-code-api-reference/iapphostmethod-interface.md)   
 [IAppHostMethodInstance Interface](../../web-development-reference\native-code-api-reference/iapphostmethodinstance-interface.md)