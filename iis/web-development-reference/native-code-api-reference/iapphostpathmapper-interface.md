---
title: "IAppHostPathMapper Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: d2a37cfd-c4d7-ceb7-ca99-3598caf3ee4a
caps.latest.revision: 11
author: "shirhatti"
manager: "wpickett"
---
# IAppHostPathMapper Interface
Maps [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration paths to file system paths.  
  
## Syntax  
  
```cpp  
interface IAppHostPathMapper : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostPathMapper` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[MapPath](../../web-development-reference\webdev-native-api-reference/iapphostpathmapper-mappath-method.md)|Maps [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration paths to custom file system paths.|  
  
## Properties  
 This interface contains no properties.  
  
## Remarks  
 This interface is used to point the configuration system to configuration files in custom physical paths.  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostPathMapper`  
  
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