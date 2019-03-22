---
title: "SourceElement Class"
ms.date: "10/07/2016"
ms.assetid: 096ddffe-341a-57e7-0b2a-29fdc0cff3ec
---
# SourceElement Class
Specifies a trace source that initiates tracing messages.  
  
## Syntax  
  
```vbs  
class SourceElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `SourceElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Listeners`|A [SourceListenerSettings](../wmi-provider/sourcelistenersettings-class.md) value that contains listeners that collect, store, and route messages.|  
|`Name`|A read/write `string` value that specifies the name of the trace source.|  
|`SwitchName`|A read/write `string` value that specifies the display name of a trace switch instance in the application.|  
|`SwitchType`|A read/write `string` value that specifies the type of the trace switch. The type must be a valid class name and cannot be an empty string.|  
|`SwitchValue`|A read/write `string` value that specifies a trace source-specific attribute.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `Sources` property of the [SourceSettings](../wmi-provider/sourcesettings-class.md) class.  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `SourceElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [SourceListenerSettings Class](../wmi-provider/sourcelistenersettings-class.md)   
 [SourceSettings Class](../wmi-provider/sourcesettings-class.md)   
 [\<source> Element](https://go.microsoft.com/fwlink/?LinkId=70916)