---
title: "IAppHostPathMapper2 Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 4037d4c6-28dd-4c53-8f61-5d099946cf45
caps.latest.revision: 9
author: "shirhatti"
manager: "wpickett"
---
# IAppHostPathMapper2 Interface
Provides methods that are called by the server implementation when the server informs the client about the hierarchy mapping decisions.  
  
## Syntax  
  
```cpp  
interface IAppHostPathMapper2 : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostPathMapper2` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[IAppHostPathMapper2::MapPath Method](../../web-development-reference\native-code-api-reference/iapphostpathmapper2-mappath-method.md)|Maps [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration paths to custom file system paths.|  
  
## Properties  
 This interface contains no properties.  
  
## Remarks  
 To receive incoming remote calls for this interface, the client must implement a UUID(0f80e901-8f4c-449a-bf90-13d5d082f187). The client must then specify an object that implements the interface to the [IAppHostAdminManager::SetMetadata Method](../../web-development-reference\native-code-api-reference/iapphostadminmanager-setmetadata-method.md) method with a `bstrMetadataName` of "pathMapper2".  
  
 As an administration system maps hierarchy paths to physical paths on the server, it optionally calls the client-supplied object that implements the IAppHostPathMapper2 interface. The implementer of this interface receives details of all mappings and can change the results of each mapping if required.  
  
> [!NOTE]
>  The `IAppHostPathMapper2` interface is designed to work on a local computer; you cannot use this interface to manage a remote computer.  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostPathMapper2`  
  
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