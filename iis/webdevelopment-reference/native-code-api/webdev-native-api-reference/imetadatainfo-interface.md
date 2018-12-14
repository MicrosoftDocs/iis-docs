---
title: "IMetadataInfo Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: a833d616-a815-b123-c943-df5af7c4025c
caps.latest.revision: 23
author: "shirhatti"
manager: "wpickett"
---
# IMetadataInfo Interface
Retrieves metadata information for the current context.  
  
## Syntax  
  
```cpp  
class IMetadataInfo  
```  
  
## Methods  
 The following table lists the methods exposed by the `IMetadataInfo` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetMetaPath](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/imetadatainfo-getmetapath-method.md)|Retrieves the configuration path for the current context.|  
|[GetModuleContextContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/imetadatainfo-getmodulecontextcontainer-method.md)|Returns the context container for the metadata.|  
|[GetVrPath](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/imetadatainfo-getvrpath-method.md)|Retrieves the physical path for a virtual directory within the current context.|  
|[GetVrToken](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/imetadatainfo-getvrtoken-method.md)|Retrieves an [IHttpTokenEntry](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptokenentry-interface.md) interface for the impersonation account that is configured for a virtual directory.|  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IReferencedMetadataInfo345258f4-4161-4f96-9ff1-2056d412d83b](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver2-interface.md)|Provides an interface for referencing and dereferencing context metadata.|  
  
## Remarks  
 Developers can use the `IMetadataInfo` interface to retrieve metadata-related configuration information.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)