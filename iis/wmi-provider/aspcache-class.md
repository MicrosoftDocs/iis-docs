---
title: "AspCache Class | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: fa41a3b8-75e1-529f-acc0-1fcb467704f3
caps.latest.revision: 16
author: "shirhatti"
manager: "wpickett"
---
# AspCache Class
Configures properties related to ASP caching.  
  
## Syntax  
  
```vbs  
class AspCache : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `AspCache` class.  
  
|Name|Description|  
|----------|-----------------|  
|`DiskTemplateCacheDirectory`|A read/write `string` value that contains the name of the directory that ASP uses to store compiled ASP templates to disk when the in-memory cache overflows. The default is "%systemdrive%\inetpub\temp\ASP Compiled Templates".|  
|`EnableTypelibCache`|A read/write `boolean` value. `true` if type libraries are cached on the server; otherwise, `false`. The default is `true`.|  
|`MaxDiskTemplateCacheFiles`|A read/write `uint32` value that specifies the maximum number of compiled ASP templates that can be stored. The default is 2000.|  
|`ScriptEngineCacheMax`|A read/write `uint32` value that specifies the maximum number of scripting engines that ASP pages will keep cached in memory. The default is 250.|  
|`ScriptFileCacheSize`|A read/write `uint32` value that specifies the number of precompiled script files to cache. If set to 0, no script files are cached. If set to 4294967295, all script files requested are cached. This property is used to tune performance, depending on the amount of available memory and the amount of script file traffic. The default is 500.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `Cache` property of the [AspSection](../wmi-provider/aspsection-class1.md) class.  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class1.md)  
  
 `AspCache`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [AspComPlus Class](../wmi-provider/aspcomplus-class.md)   
 [AspLimits Class](../wmi-provider/asplimits-class.md)   
 [AspSection Class](../wmi-provider/aspsection-class1.md)   
 [AspSession Class](../wmi-provider/aspsession-class.md)   
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class1.md)