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
|[IAppHostPathMapper2::MapPath Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpathmapper2-mappath-method.md)|Maps [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration paths to custom file system paths.|  
  
## Properties  
 This interface contains no properties.  
  
## Remarks  
 To receive incoming remote calls for this interface, the client must implement a UUID(0f80e901-8f4c-449a-bf90-13d5d082f187). The client must then specify an object that implements the interface to the [IAppHostAdminManager::SetMetadata Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostadminmanager-setmetadata-method.md) method with a `bstrMetadataName` of "pathMapper2".  
  
 As an administration system maps hierarchy paths to physical paths on the server, it optionally calls the client-supplied object that implements the IAppHostPathMapper2 interface. The implementer of this interface receives details of all mappings and can change the results of each mapping if required.  
  
> [!NOTE]
>  The `IAppHostPathMapper2` interface is designed to work on a local computer; you cannot use this interface to manage a remote computer.  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostPathMapper2`  
  
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