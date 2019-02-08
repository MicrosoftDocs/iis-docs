---
title: "Server Class1 | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 52fd13ed-2645-bc13-c04d-a5e82ca50c0f
caps.latest.revision: 23
author: "shirhatti"
manager: "wpickett"
---
# Server Class1
Exposes default configuration settings for applications, application pools, Web sites, and virtual directories on a Web server running IIS.  
  
## Syntax  
  
```vbs  
class Server : Object  
```  
  
## Methods  
 The following table lists the methods exposed by the `Server` class.  
  
|Name|Description|  
|----------|-----------------|  
|[BeginUpdateBatch](../wmi-provider/server-beginupdatebatch-method.md)|Begins a batch of configuration changes for the specified path.|  
|[EndUpdateBatch](../wmi-provider/server-endupdatebatch-method.md)|Ends a batch of configuration changes.|  
  
## Properties  
 The following table lists the properties exposed by the `Server` class.  
  
|Name|Description|  
|----------|-----------------|  
|`ApplicationDefaults`|A read/write [ApplicationElementDefaults](../wmi-provider/applicationelementdefaults-class.md) value that specifies the default application pool and protocols for new applications.|  
|`ApplicationPoolDefaults`|A read/write [ApplicationPoolElementDefaults](../wmi-provider/applicationpoolelementdefaults-class.md) value that contains the default properties for the [ApplicationPool](../wmi-provider/applicationpool-class.md) class.|  
|`SiteDefaults`|A read/write [SiteElementDefaults](../wmi-provider/siteelementdefaults-class.md) value that contains the default values for an IIS Web site.|  
|`VirtualDirectoryDefaults`|A read/write [VirtualDirectoryElementDefaults](../wmi-provider/virtualdirectoryelementdefaults-class.md) value that exposes default configuration settings for IIS virtual directories.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 The `Server` object is a singleton object (that is, there is only one instance per computer) and, therefore, does not have any key properties.  
  
## Inheritance Hierarchy  
 [Object](../wmi-provider/object-class.md)  
  
 `Server`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ApplicationElementDefaults Class](../wmi-provider/applicationelementdefaults-class.md)   
 [ApplicationPool Class](../wmi-provider/applicationpool-class.md)   
 [ApplicationPoolElementDefaults Class](../wmi-provider/applicationpoolelementdefaults-class.md)   
 [ConfiguredObject Class](../wmi-provider/configuredobject-class.md)   
 [SiteElementDefaults Class](../wmi-provider/siteelementdefaults-class.md)   
 [VirtualDirectoryElementDefaults Class](../wmi-provider/virtualdirectoryelementdefaults-class.md)