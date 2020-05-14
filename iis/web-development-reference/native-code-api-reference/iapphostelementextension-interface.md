---
title: "IAppHostElementExtension Interface"
ms.date: "10/07/2016"
ms.assetid: a59b1d04-31f6-470a-9ee2-f6068b755e7f
---
# IAppHostElementExtension Interface
Used to handle element extensions in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.  
  
## Syntax  
  
```cpp  
IAppHostElementExtension : public IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostElementExtension` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[ProvideElement](../../web-development-reference/native-code-api-reference/iapphostelementextension-provideelement-method.md)|Populates the supplied configuration element.|  
  
## Properties  
 This interface contains no properties.  
  
## Remarks  
 The `IAppHostElementExtension` interface is used to handle element extensions to the configuration system. When this interface is implemented, the configuration system will call it to handle dynamic configuration.  
  
 The administration system allows dynamic elements to be defined, provided that they are backed by a class that implements the `IAppHostElementExtension` interface.  
  
> [!NOTE]
>  The `IAppHostElementExtension` interface is designed to work on a local computer; you cannot use this interface to manage a remote computer.  
  
## Inheritance Hierarchy  
 [IUnknown](https://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostElementExtension`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../web-development-reference/native-code-api-reference/application-host-administration-interfaces.md)
 [Application Host Administration API Reference](../../web-development-reference/native-code-api-reference/application-host-administration-api-reference.md)
