---
title: "WebLimitsSection Class"
ms.date: "10/07/2016"
ms.assetid: 416bad62-0487-657f-8f78-9050d470c867
---
# WebLimitsSection Class
Specifies limits on client traffic to a Web server.  
  
## Syntax  
  
```vbs  
class WebLimitsSection : ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `WebLimitsSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `WebLimitsSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`ConnectionTimeout`|A read/write `datetime` value that specifies the time that IIS waits before it disconnects a connection that is not active. The default is 2 minutes.|  
|`DemandStartThreshold`|A read/write `uint32` value that specifies the maximum number of worker processes that are allowed to run concurrently on a Web server. The default is –1 (no limit). You can use this property to prevent IIS servers from becoming unresponsive when too many worker processes have been started.|  
|`DynamicIdleThreshold`|A read/write `uint32` value that specifies the percentage of committed physical RAM. The default is 0. The valid integer range is from 0 through 10000. The Windows Process Activation Service (WAS) uses this threshold value to dynamically shorten the idle time-out of worker processes. For more information, see the Remarks section.|  
|`HeaderWaitTimeout`|A read/write `datetime` value that specifies the amount of time that the server waits for all HTTP headers from a request to be received before it disconnects the client. The default is 0. Use this property to help prevent denial of service attacks that attempt to open the maximum number of connections and keep them open.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`MaxGlobalBandwidth`|A read/write `uint32` value that specifies the maximum total bandwidth for the server. **Note:**  Although the IIS_Schema.xml file specifies 4294967295 (unlimited) as the default for this property, the default returned by the WMI provider is -1.|  
|`MinBytesPerSecond`|A read/write `uint32` value that specifies the minimum throughput rate, in bytes, that is allowed between the client and the server. If the rate falls below the specified value, the connection is terminated. Use this setting to prevent malfunctioning or malicious software from holding a connection open with minimal data and consuming resources unnecessarily. The default is 240.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Every 60 seconds, a worker process checks how long it has been idle. If its current idle time is greater than the idle time-out value specified by WAS, the worker process initiates a shutdown. When you specify a nonzero value for the `DynamicIdleThreshold` property, WAS will dynamically reduce this idle time-out depending on amount of RAM used.  
  
 The `DynamicIdleThreshold` property represents the amount of committed physical RAM. For example, if your server has 2 gigabytes (GB) of physical memory installed and you set the `DynamicIdleThreshold` property value to 200, you have committed 200 percent (4 GB) of physical RAM for use. According to the following table, when 80 percent of 4 GB—that is, 160 percent (3.2 GB) of physical RAM—is allocated, WAS will start reducing the idle time-out of all worker processes by 50 percent.  
  
 The following table lists the idle time-out reductions that occur at predetermined percentages of the `DynamicIdleThreshold` value.  
  
|`DynamicIdleThreshold` percentage reached|Dynamic idle time-out reduction|  
|-----------------------------------------------|--------------------------------------|  
|75 or lower|WAS uses the original idle time-out settings.|  
|80|WAS sets the idle time-out to one-half of the original value for all worker processes that have a configured idle time-out.|  
|85|WAS sets the idle time-out to one-fourth of the original value for all worker processes that have a configured idle time-out.|  
|90|WAS sets the idle time-out to one-eighth of the original value for all worker processes that have a configured idle time-out.|  
|95|WAS sets the idle time-out to one-sixteenth of the original value for all worker processes that have a configured idle time-out.|  
|100|WAS sets the idle time-out to one thirty-second of the original value for all worker processes that have a configured idle time-out.|  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 `WebLimitsSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)   
 [CIM_DATETIME](https://go.microsoft.com/fwlink/?LinkId=57551)