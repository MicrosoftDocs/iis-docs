---
title: FastCgiApplicationElement Class
description: Describes the FastCgiApplicationElement class and provides the class' syntax, properties, remarks, inheritance hierarchy, and requirements.
ms.date: 10/07/2016
ms.assetid: 7b3b787a-4c1d-4639-bc23-38983fe65e8c
---
# FastCgiApplicationElement Class
Configures settings for a FastCGI application.  
  
## Syntax  
  
```vbs  
class FastCgiApplicationElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `FastCgiApplicationElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`ActivityTimeout`|A read/write `uint32` value that specifies the maximum time, in seconds, that IIS waits for FastCGI activity, such as sending data. The default is 30. A key property. **Note:**  The value specified is a lowest-maximum value. This maximum is not strictly enforced and can increase substantially under heavy loads.|  
|`Arguments`|A read/write `string` value that specifies command-line arguments for the FastCGI application executable file.|  
|`EnvironmentVariables`|An array of [FastCgiEnvironmentSettings](../wmi-provider/fastcgienvironmentsettings-class.md) values that contain environment variables for the process executable program of an application pool.|  
|`FlushNamedPipe`|A read/write `boolean` value. `true` if named pipes are flushed at the end of each request; otherwise, `false`. The default is `false`. This property applies only when the named-pipe protocol is used.|  
|`FullPath`|A read/write `string` value that specifies the full path of the FastCGI application executable file. A key property.|  
|`IdleTimeout`|A read/write `uint32` value that specifies the time interval, in seconds, after which an idle process is ended. The default is 300.|  
|`InstanceMaxRequests`|A read/write `uint32` value that specifies the maximum number of requests that a FastCGI worker process can manage  before the process is recycled. The default is 200.|  
|`MaxInstances`|A read/write `uint32` value that specifies the maximum number of FastCGI worker processes that can be started for an application pool.|  
|`Protocol`|A read/write `sint32` enumeration that specifies the transport mechanism that communicates with the FastCGI worker process. The possible values are listed later in the Remarks section.|  
|`QueueLength`|A read/write `uint32` value that specifies the maximum number of requests that can be queued for the FastCGI application pool. When the queue is full, subsequent requests return HTTP error code 503 (Service Unavailable).|  
|`RequestTimeout`|A read/write `uint32` value that specifies the maximum time, in seconds, that IIS waits for a FastCGI application to finish processing a request. The default is 90. **Note:**  The value specified is a lowest-maximum value. This maximum is not strictly enforced and can increase substantially under heavy loads.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `FastCgi` array property of the [FastCgiSection](../wmi-provider/fastcgisection-class.md) class.  
  
 The following table lists the possible values for the `Protocol` property. The default is 0 (`NamedPipe`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`NamedPipe`|The named-pipe protocol will be used to communicate with the FastCGI worker process.|  
|1|`Tcp`|The TCP protocol will be used to communicate with the FastCGI worker process.|  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `FastCgiApplicationElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [FastCgiSection Class](../wmi-provider/fastcgisection-class.md)   
 [FastCgiEnvironmentSettings Class](../wmi-provider/fastcgienvironmentsettings-class.md)   
 [FastCgiEnvironmentElement Class](../wmi-provider/fastcgienvironmentelement-class.md)
