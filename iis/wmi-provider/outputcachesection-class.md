---
title: "OutputCacheSection Class | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: fc8a6956-81a6-2150-f8b3-3193efdbd354
caps.latest.revision: 17
author: "shirhatti"
manager: "wpickett"
---
# OutputCacheSection Class
Specifies output cache settings for an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application.  
  
## Syntax  
  
```vbs  
class OutputCacheSection : ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `OutputCacheSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class1.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `OutputCacheSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`EnableFragmentCache`|A read/write `boolean` value. `true` if the application fragment cache is enabled; otherwise, `false`. The default is `true`.<br /><br /> If the fragment cache is disabled, no pages are cached, regardless of the `@ OutputCache` directive or caching profile used.|  
|`EnableKernelCacheForVaryByStar`|A read/write `boolean` value. `true` if kernel caching is enabled for the application when "Vary: *" headers are included in cached pages; otherwise, `false`. The default is `false`.|  
|`EnableOutputCache`|A read/write `boolean` value. `true` if the page output cache is enabled; otherwise, `false`. The default is `true`.<br /><br /> If the output cache is disabled, no pages are cached, regardless of any programmatic or declarative settings.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`OmitVaryStar`|An optional read/write `boolean` value. `true` if an HTTP "Vary: *" header is omitted in the response; otherwise, `false`. The default is `false`, which sends a "Vary: \*" header for output cached pages.<br /><br /> The `Vary` header indicates the request-header fields that the server uses to determine which of multiple cached responses are sent in response to a client request.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
|`SendCacheControlHeader`|An optional read/write `boolean` value. `true` if the `Cache-Control: private` header is sent by the output cache module by default; otherwise, `false`. The default is `true`.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class1.md)  
  
 `OutputCacheSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 <xref:System.Web.Configuration.OutputCacheSection?displayProperty=fullName>   
 <xref:System.Web.Configuration.SystemWebCachingSectionGroup.OutputCache%2A?displayProperty=fullName>   
 [CacheSection Class](../wmi-provider/cachesection-class.md)   
 [CachingProfileElement Class](../wmi-provider/cachingprofileelement-class.md)   
 [CachingSection Class](../wmi-provider/cachingsection-class.md)   
 [ConfigurationSection Class](../wmi-provider/configurationsection-class1.md)