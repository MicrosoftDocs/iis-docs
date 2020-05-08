---
title: "WebProxyScriptSettings Class"
ms.date: "10/07/2016"
ms.assetid: 3e5f9462-6c46-4242-be1f-9c7c08928258
---
# WebProxyScriptSettings Class
Configures Web proxy scripts.  
  
## Syntax  
  
```vbs  
class WebProxyScriptSettings : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `WebProxyScriptSettings` class.  
  
|Name|Description|  
|----------|-----------------|  
|`DownloadTimeout`|A read/write `datetime` value that specifies the Web proxy script download time-out. The default is 2 minutes.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `WebProxyScript` property of the [SettingsSection](../wmi-provider/settingssection-class.md) class.  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `WebProxyScriptSettings`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CIM_DATETIME](https://go.microsoft.com/fwlink/?LinkId=57551)   
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [SettingsSection Class](../wmi-provider/settingssection-class.md)
