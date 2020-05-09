---
title: "HeaderLimitsElement Class"
ms.date: "10/07/2016"
ms.assetid: 83dc2e2d-1233-bd6d-9474-ff674fe00fed
---
# HeaderLimitsElement Class
Specifies the permitted sizes of HTTP request headers.  
  
## Syntax  
  
```vbs  
class HeaderLimitsElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `HeaderLimitsElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Header`|A required unique read/write `string` value that specifies an HTTP request header. The default is a null reference. The key property.|  
|`SizeLimit`|A required `uint32` value that specifies, in bytes, the maximum length of the HTTP request header specified in the `Header` property.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `HeaderLimits` array property of the [HeaderLimitsSettings](../wmi-provider/headerlimitssettings-class.md) class.  
  
 This class corresponds to the `<headerLimits>` element in the `<requestLimits>` section of the ApplicationHost.config file.  
  
> [!NOTE]
>  You must install the Request Filtering Module (Modrqflt.dll) before the configuration settings in this class can take effect.  
  
## Example  
 The following example displays all the properties of the `RequestLimitsElement` class.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set objWMIService = GetObject("winmgmts:root\WebAdministration")  
  
' Get the RequestFilteringSection.  
Set oRequestFilteringSection = objWMIService.Get( _  
"RequestFilteringSection.Path='MACHINE/WEBROOT/APPHOST',Location=''")  
  
' Display the path and the contents of the   
' RequestFilteringSection.RequestLimits.HeaderLimits.HeaderLimits   
' property, which contains an array of HeaderLimitsElement instances.  
WScript.Echo "[Header Limits]"  
WScript.Echo "Path: " & oRequestFilteringSection.Path  
WScript.Echo   
For Each oHeaderLimit In oRequestFilteringSection.RequestLimits.HeaderLimits.HeaderLimits  
    WScript.Echo "Header: " & oHeaderLimit.Header  
    WScript.Echo "Header size limit: " & oHeaderLimit.sizeLimit  
    WScript.Echo   
Next  
  
```  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `HeaderLimitsElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [HeaderLimitsSettings Class](../wmi-provider/headerlimitssettings-class.md)   
 [RequestFilteringSection Class](../wmi-provider/requestfilteringsection-class.md)   
 [RequestLimitsElement Class](../wmi-provider/requestlimitselement-class.md)
