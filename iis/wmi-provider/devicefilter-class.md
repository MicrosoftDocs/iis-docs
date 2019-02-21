---
title: "DeviceFilter Class"
ms.date: "10/07/2016"
ms.assetid: 41743e11-7d57-c232-723f-e5ef3af7166f
---
# DeviceFilter Class
Specifies criteria for determining mobile browser capabilities or the type of mobile device.  
  
## Syntax  
  
```vbs  
class DeviceFilter : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `DeviceFilter` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Argument`|A read/write `string` value that specifies a keyword to be compared. The `Compare` property specifies the category for the keyword.|  
|`Compare`|A read/write `string` value that specifies the category for a keyword to be compared. The `Argument` property specifies the keyword to be compared.|  
|`Method`|A read/write `string` value that contains the name of a method to be used in an evaluator-delegate filter. The method determines whether the device filter evaluates to `true`. If you specify a value for this property, you must also specify a value for the `Type` property.|  
|`Name`|A required unique read/write `string` value that specifies the name of the device filter. The key property.|  
|`Type`|A read/write `string` value that specifies the class of an evaluator delegate method. If you specify a value for this property, you must also specify a value for the `Method` property.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `DeviceFilters` property of the [DeviceFiltersSection](../wmi-provider/devicefilterssection-class.md) class.  
  
 The properties in this class specify criteria against which target mobile devices and capabilities should be matched. You can select from two types of device filters: comparison evaluators or evaluator delegates.  
  
 For the comparison-based filter, you use the `Compare` and `Argument` properties to specify a capability and the value that you want the filter to compare. At run time, the evaluator succeeds if the value that you provide and the value that is returned are equal. Compared Boolean properties are case-insensitive (for example, "true" and "True" are considered to be equal). Other compared properties are case-sensitive.  
  
 You can implement more complex evaluations by specifying an evaluator-delegate-based filter. This type of filter delegates the evaluation to a method that you create. To implement an evaluator-delegate method, specify the method name in the `Method` property and the method's class in the `Type` property. At run time, the method that you specified is called to perform the evaluation.  
  
 The following `DeviceFilters` element is not explicitly configured in the machine configuration file or in the root Web.config file, but it is the default configuration returned in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].  
  
 `<deviceFilters>`  
  
 `<filter name="isJPhone" compare="Type" argument="J-Phone"/>`  
  
 `<filter name="isHTML32" compare="PreferredRenderingType" argument="html32"/>`  
  
 `<filter name="isWML11" compare="PreferredRenderingType" argument="wml11"/>`  
  
 `<filter name="isCHTML10" compare="PreferredRenderingType" argument="chtml10"/>`  
  
 `<filter name="isGoAmerica" compare="Browser" argument="Go.Web"/>`  
  
 `<filter name="isMME" compare="Browser" argument="Microsoft Mobile Explorer"/>`  
  
 `<filter name="isMyPalm" compare="Browser" argument="MyPalm"/>`  
  
 `<filter name="isPocketIE" compare="Browser" argument="Pocket IE"/>`  
  
 `<filter name="isUP3x" compare="Type" argument="Phone.com 3.x Browser"/>`  
  
 `<filter name="isUP4x" compare="Type" argument="Phone.com 4.x Browser"/>`  
  
 `<filter name="isEricssonR380" compare="Type" argument="Ericsson R380"/>`  
  
 `<filter name="isNokia7110" compare="Type" argument="Nokia 7110"/>`  
  
 `<filter name="prefersGIF" compare="PreferredImageMIME" argument="image/gif"/>`  
  
 `<filter name="prefersWBMP" compare="PreferredImageMIME" argument="image/vnd.wap.wbmp"/>`  
  
 `<filter name="supportsColor" compare="IsColor" argument="true"/>`  
  
 `<filter name="supportsCookies" compare="Cookies" argument="true"/>`  
  
 `<filter name="supportsJavaScript" compare="Javascript" argument="true"/>`  
  
 `<filter name="supportsVoiceCalls" compare="CanInitiateVoiceCall" argument="true"/>`  
  
 `</deviceFilters>`  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `DeviceFilter`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [System.Web.Configuration.SystemWebSectionGroup.DeviceFilters](/dotnet/api/system.web.configuration.systemwebsectiongroup.devicefilters)
 [\<filter> Element](http://go.microsoft.com/fwlink/?LinkId=69324)   
 [Device-Specific Rendering](http://go.microsoft.com/fwlink/?LinkId=69323)   
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [DeviceFiltersSection Class](../wmi-provider/devicefilterssection-class.md)   
 [System.Web.Mobile.MobileCapabilities Class](http://go.microsoft.com/fwlink/?LinkId=69325)