---
title: "UrlCompressionSection Class | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 356024fc-1000-cede-ffca-553146521b7a
caps.latest.revision: 23
author: "shirhatti"
manager: "wpickett"
---
# UrlCompressionSection Class
Enables or disables dynamic or static compression.  
  
## Syntax  
  
```vbs  
class UrlCompressionSection : ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `UrlCompressionSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `UrlCompressionSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`DoDynamicCompression`|A read/write `boolean` value. `true` if dynamic compression is enabled for URLs; otherwise, `false`. The default is `false`. **Note:**  Use of dynamic compression may increase processor utilization and reduce the overall performance of the Web server.|  
|`DoStaticCompression`|A read/write `boolean` value. `true` if static compression is enabled for URLs; otherwise, `false`. The default is `true`.|  
|`DynamicCompressionBeforeCache`|A read/write `boolean` value. `true` if the currently available response is dynamically compressed before it is put into the output cache; otherwise, `false`. The default is `false`. For more information, see the Remarks section.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 When the `DynamicCompressionBeforeCache` property is `true`, IIS dynamically compresses the response the first time a request is made. The compressed response is put into the output cache, and the cached response is sent to the client. Subsequent requests are served from the compressed response in the output cache.  
  
 When `DynamicCompressionBeforeCache` is `false`, IIS puts the noncompressed response into the output cache. Then, every time that the response is requested, IIS dynamically compresses the cached response as it is sent to the client.  
  
 If you set the `DynamicCompressionBeforeCache` property to `true`, the CPU will dynamically compress the response only once instead of every time the page is requested. Because dynamic compression is CPU-intensive, a setting of `true` can reduce the server load and improve site throughput.  
  
> [!NOTE]
>  If the `DynamicCompressionBeforeCache` property is `true` when the output cache response has been flushed, dynamic compression will not be performed before the response is put into the output cache. However, if the `DoDynamicCompression` property is `true`, dynamic compression will still occur after the response has been put into the output cache.  
  
## Example  
 The following example lists the dynamic and static compression settings for all paths and locations on a Web server. An empty `Location` property in the output indicates that the setting is global.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the URL compression section.  
Set oUrlCompressionSection = oWebAdmin.ExecQuery( _  
    "SELECT * FROM UrlCompressionSection")  
  
' List the dynamic and static compression settings for each location.  
For Each vUrlCompressionProperty In oUrlCompressionSection  
    WScript.Echo "Location: " & vUrlCompressionProperty.Location  
    WScript.Echo "DoDynamicCompression: " & _  
        vUrlCompressionProperty.DoDynamicCompression  
    WScript.Echo "DoStaticCompression: " & _  
        vUrlCompressionProperty.DoStaticCompression  
    WScript.Echo  
Next  
```  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 `UrlCompressionSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)   
 [HttpCompressionSection Class](../wmi-provider/httpcompressionsection-class.md)