---
title: "DateTimeSerializationSection Class"
ms.date: "10/07/2016"
ms.assetid: ad1ba074-e2d7-8528-1a35-a25053eb5106
---
# DateTimeSerializationSection Class
Handles configuration settings for XML serialization of [System.DateTime](http://go.microsoft.com/fwlink/?LinkId=70919) instances.  
  
## Syntax  
  
```vbs  
class DateTimeSerializationSection : ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `DateTimeSerializationSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `DateTimeSerializationSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Mode`|A read/write `sint32` value that determines the serialization format for `DateTime` instances. The possible values are listed later in the Remarks section.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 The following table lists the possible values for the `Mode` property.  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`Default`|The same as `Roundtrip`.|  
|1|`Roundtrip`|The serializer examines the `DateTime` instance to determine whether the serialization format is Coordinated Universal Time (UTC), local, or unspecified, and it serializes the instance in such a way that this information is preserved. You should use this setting for all new applications that do not communicate with versions 1.0 or 1.1 of the [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)].|  
|2|`Local`|The serializer formats all `DateTime` objects as local time. **Note:**  In the [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)] 1.0 and 1.1, `DateTime` objects are always formatted as the local time. That is, local time zone information is always included with the serialized data. Use this setting to guarantee compatibility with the [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)] 1.0 and 1.1.|  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 `DateTimeSerializationSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)   
 [System.Xml.Serialization.Configuration.DateTimeSerializationSection.DateTimeSerializationMode Enumeration](http://go.microsoft.com/fwlink/?LinkId=70920)   
 [System.DateTime Structure](http://go.microsoft.com/fwlink/?LinkId=70919)