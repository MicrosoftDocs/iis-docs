---
title: "ServerRuntimeSection Class"
description: Configures request limits for applications on a Web server.
ms.date: "10/07/2016"
ms.assetid: 6fd863ba-e8d4-c1c4-904b-7b52a91843f6
---
# ServerRuntimeSection Class
Configures request limits for applications on a Web server.  
  
## Syntax  
  
```vbs  
class ServerRuntimeSection : ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `ServerRuntimeSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `ServerRuntimeSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`AlternateHostName`|A read/write `string` value that specifies the name of an alternate host.|  
|`AppConcurrentRequestLimit`|A read/write `uint32` value that specifies the maximum number of requests that can be queued for an application. The default is 5000.|  
|`Enabled`|A read/write `boolean` value. `true` if applications on the Web server are allowed to serve content; otherwise, `false`. The default is `true`.|  
|`EnableNagling`|A read/write `boolean` value. `true` if nagling is enabled; otherwise, `false`. The default is `false`. **Note:**  Nagling is an optimization for HTTP over TCP that increases efficiency by trying to minimize the number of packets needed to send data. It works by waiting to send a packet until its data area is full, until a 200-millisecond time-out period expires, or until the sender indicates that it is done sending data. IIS versions 5.1 and earlier use nagling for all data sent to the client. Nagling has a possible downside. If an extension does not fill up the packet, there is still a delay of 200 milliseconds before the response is sent. This behavior is most evident for ISAPI extensions that support an HTTP `Keep-Alive` header in the response to the client. In this case, IIS does not close the connection after the response, so the final packet ends up waiting for the 200 milliseconds.|  
|`FrequentHitThreshold`|A read/write `uint32` value that specifies the number of times a URL must be requested, within the time span specified in the `FrequentHitTimePeriod` property, to be considered frequently hit. The value must be between 1 and 2147483647. The default is 2. If the URL is frequently hit, it is cached by IIS.|  
|`FrequentHitTimePeriod`|A read/write `datetime` value that specifies the time interval in which a URL must be requested a specified number of times to be considered frequently hit. The default is 10 seconds. The number of times is specified in the `FrequentHitThreshold` property.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`MaxRequestEntityAllowed`|A read/write `uint32` value that specifies the maximum number of bytes allowed in the entity body of a request. If a `Content-Length` header specifies a larger amount, IIS sends a 403 error response. **Note:**  Although the IIS_Schema.xml file specifies 4294967295 (unlimited) as the default for this property, the default returned by the WMI provider is -1.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
|`UploadReadAheadSize`|A read/write `uint32` value that specifies the number of bytes a Web server will read into a buffer and pass to an ISAPI extension. This occurs once per client request. The ISAPI extension receives any additional data directly from the client. The value must be between 0 and 2147483647. The default is 49152.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 This class corresponds to the `<serverRuntime>` section in the ApplicationHost.config file.  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 `ServerRuntimeSection`  
  
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
 [HttpRequest Class](../wmi-provider/httprequest-class.md)   
 [RequestFilteringSection Class](../wmi-provider/requestfilteringsection-class.md)   
 [CIM_DATETIME](https://go.microsoft.com/fwlink/?LinkId=57551)
