---
title: "IAppHostPropertyExtension Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 75096e8d-a4d9-4c5d-ab8c-b844e1b52033
caps.latest.revision: 10
author: "shirhatti"
manager: "wpickett"
---
# IAppHostPropertyExtension Interface
Used to handle property extensions in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.  
  
## Syntax  
  
```cpp  
IAppHostPropertyExtension : public IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostPropertyExtension` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[ProvideGetProperty](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyextension-providegetproperty-method.md)|Populates the value of a dynamic property in a specified element.|  
  
## Properties  
 This interface contains no properties.  
  
## Remarks  
 The `IAppHostPropertyExtension` interface is used to handle property extensions to the configuration system. When this interface is implemented, the configuration system will call it to handle dynamic configuration.  
  
 The administration system allows dynamic properties to be defined, provided that they are backed by a class that implements the `IAppHostPropertyExtension` interface.  
  
> [!NOTE]
>  The `IAppHostPropertyExtension` interface is designed to work on a local computer; you cannot use this interface to manage a remote computer.  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostPropertyExtension`  
  
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