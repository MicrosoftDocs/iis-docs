---
title: "AspComPlus Class | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 8aea95ad-b8a7-6ba0-1155-f1000b176bfd
caps.latest.revision: 19
author: "shirhatti"
manager: "wpickett"
---
# AspComPlus Class
Exposes properties related to COM+.  
  
## Syntax  
  
```vbs  
class AspComPlus : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `AspComPlus` class.  
  
|Name|Description|  
|----------|-----------------|  
|`AppServiceFlags`|A read/write `sint32` enumeration that configures certain COM+ features. The possible values are listed later in the Remarks section. The default is 0 (`None`).|  
|`ExecuteInMta`|A read/write `boolean` value. `true` if ASP should run in a multithreaded environment; otherwise, `false`. The default is `false`.|  
|`PartitionId`|A read/write `string` value that specifies the GUID of the COM+ partition. This property is required when `AppServiceFlags` is set to `UsePartition`.|  
|`SxsName`|A read/write `string` value that specifies the name of a COM+ application. This property is required when `AppServiceFlags` is set to `EnableSxS`.|  
|`TrackThreadingModel`|A read/write `boolean` value. `true` if IIS honors the threading model of the components that an application creates; otherwise, `false`. The default is `false`.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `ComPlus` property of the [AspSection](../wmi-provider/aspsection-class1.md) class.  
  
 The following table lists the possible values for the `AppServiceFlags` property. The default is 0 (`None`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`None`|No COM+ application flags are enabled.|  
|1|`EnableTracker`|Enables the COM+ tracker, which enables ASP applications to be debugged.|  
|2|`EnableSxS`|Enables COM+ side-by-side assemblies, which enable ASP applications to specify which version of a system DLL or COM component (such as MDAC, MFS, MSVCRT, or MSXML) to use.|  
|4|`UsePartition`|Enables COM+ partitioning, which you can use to isolate applications into their own COM+ partitions. If you set this flag, you must also specify a value for the `PartitionID` property.|  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class1.md)  
  
 `AspComPlus`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [AspCache Class](../wmi-provider/aspcache-class.md)   
 [AspLimits Class](../wmi-provider/asplimits-class.md)   
 [AspSection Class](../wmi-provider/aspsection-class1.md)   
 [AspSession Class](../wmi-provider/aspsession-class.md)   
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class1.md)