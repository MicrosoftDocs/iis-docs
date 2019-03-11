---
title: "VerbsSettings Class"
ms.date: "10/07/2016"
ms.assetid: 1786330c-9084-4f84-9761-c042bdef9178
---
# VerbsSettings Class
Exposes configuration settings for HTTP verbs.  
  
## Syntax  
  
```vbs  
class VerbsSettings : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `VerbsSettings` class.  
  
|Name|Description|  
|----------|-----------------|  
|`AllowUnlisted`|A read/write `boolean` value. `true` if HTTP verbs not listed in the `Verbs` property will be allowed; otherwise, `false`. The default is `true`.|  
|`ApplyToWebDAV`|A read/write `boolean` value. `true` if the `AllowUnlisted` and `Verbs` properties are applied to WebDAV requests; otherwise, `false`. The default is `true`.|  
|`Verbs`|A read-only array of [VerbElement](../wmi-provider/verbelement-class.md) values that specifies HTTP verbs to allow or deny.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `Verbs` property of the [RequestFilteringSection](../wmi-provider/requestfilteringsection-class.md) class.  
  
 This class corresponds to the `<verbs>` section in the ApplicationHost.config file.  
  
> [!NOTE]
>  You must install the Request Filtering Module (Modrqflt.dll) for the settings in this class to take effect.  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `VerbsSettings`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [RequestFilteringSection Class](../wmi-provider/requestfilteringsection-class.md)   
 [VerbElement Class](../wmi-provider/verbelement-class.md)