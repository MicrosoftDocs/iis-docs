---
title: "ApplicationPoolFailureSettings Class1"
ms.date: "10/07/2016"
ms.assetid: 8e1aa657-4665-39cb-afee-d927d33c3f85
---
# ApplicationPoolFailureSettings Class1
Exposes properties that determine the actions to be taken when an application pool or worker process fails.  
  
## Syntax  
  
```vbs  
class ApplicationPoolFailureSettings : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `ApplicationPoolFailureSettings` class.  
  
|Name|Description|  
|----------|-----------------|  
|`AutoShutdownExe`|A read/write `string` value that specifies an executable file to run when the World Wide Web Publishing Service (WWW service) shuts down an application pool. The default is `null`. Use the `AutoShutdownParams` property to send parameters to the executable.|  
|`AutoShutdownParams`|A read/write `string` value that contains the command-line parameters for the executable file specified by the `AutoShutdownExe` property. The default is `null`.|  
|`LoadBalancerCapabilities`|A read/write `sint32` value that specifies application pool behavior when a service is unavailable. The possible values are listed later in the Remarks section.|  
|`OrphanActionExe`|A read/write `string` value that specifies an executable file to run when the WWW service orphans a worker process. The default is `null`. Use the `OrphanActionParams` property to send parameters to the executable file.|  
|`OrphanActionParams`|A read/write `string` value that contains the command-line parameters for the executable file specified by the `OrphanActionExe` property. To specify the process ID of the orphaned worker process, use "%1%". The default is `null`.|  
|`OrphanWorkerProcess`|A read/write `boolean` value. `true` if the WWW service orphans a worker process that fails to respond to requests; otherwise, `false`. The default is `false`. When the value is set to `false`, any worker process that fails to respond will be terminated.|  
|`RapidFailProtection`|A read/write `boolean` value. `true` if the WWW service will terminate all applications in an application pool when the number of worker process failures reaches the maximum specified by `RapidFailProtectionMaxCrashes` within the number of seconds specified by `RapidFailProtectionInterval`; otherwise, `false`. The default is `true`.|  
|`RapidFailProtectionInterval`|A read/write `datetime` value that specifies the number of seconds before the failure count for a worker process is reset. The default is 5.|  
|`RapidFailProtectionMaxCrashes`|A read/write `uint32` value that specifies the maximum number of permissible worker process failures. The default is 5.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `Failure` property of the [ApplicationPool](../wmi-provider/applicationpool-class.md) class and the [ApplicationPoolElementDefaults](../wmi-provider/applicationpoolelementdefaults-class.md) class.  
  
 The following table lists the possible values and the associated keywords and actions for the `LoadBalancerCapabilities` property. The default is 2 (`HttpLevel`).  
  
|Value|Keyword|Action|  
|-----------|-------------|------------|  
|1|`TcpLevel`|Terminates the connection.|  
|2|`HttpLevel`|Sends error code 503 (service unavailable).|  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `ApplicationPoolFailureSettings`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CIM_DATETIME](http://go.microsoft.com/fwlink/?LinkId=57551)   
 [ApplicationPool Class](../wmi-provider/applicationpool-class.md)   
 [ApplicationPoolElementDefaults Class](../wmi-provider/applicationpoolelementdefaults-class.md)   
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)