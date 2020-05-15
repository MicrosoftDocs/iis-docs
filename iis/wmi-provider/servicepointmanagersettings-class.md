---
title: "ServicePointManagerSettings Class"
ms.date: "10/07/2016"
ms.assetid: cf44f648-20cd-eb13-fbb3-c5514cf5749d
---
# ServicePointManagerSettings Class

Represents the default settings used to create connections to a remote computer.  
  
## Syntax  
  
```vbs  
class ServicePointManagerSettings : EmbeddedObject  
```  
  
## Methods  

 This class contains no methods.  
  
## Properties  

 The following table lists the properties exposed by the `ServicePointManagerSettings` class.  
  
|Name|Description|  
|----------|-----------------|  
|`CheckCertificateName`|A read/write `boolean` value. `true` to specify host name checking in an X.509 certificate; otherwise, `false`. The default is `true`.|  
|`CheckCertificateRevocationList`|A read/write `boolean` value. `true` if the presented certificate is checked against the certificate authority revocation list for validation; otherwise, `false`. The default is `false`.|  
|`DnsRefreshTimeout`|A read/write `sint32` value that specifies the amount of time, in milliseconds, after which address information is refreshed. The default is 120000 (2 minutes). A value of -1 indicates an infinite time-out period.|  
|`EnableDnsRoundRobin`|A read/write `boolean` value. `true` if round-robin DNS behavior is enabled; otherwise, `false`. The default is `false`. **Note:**  Round-robin DNS is a method of configuring a DNS server so that DNS requests for a particular host name are sequentially distributed across a pool of IP addresses instead of a single address.|  
|`Expect100Continue`|A read/write `boolean` value. `true` if an `Expect: 100-Continue` header is added to client POST requests; otherwise, `false`. The default is `true`. **Note:**  When this property is `true`, client requests that use the POST method will wait to receive a `100-Continue` response from the server to indicate that the client should send the data to be posted. This mechanism enables clients to avoid sending large amounts of data over the network when the server, based on the request headers, would reject the request.|  
|`UseNagleAlgorithm`|A `boolean` value. `true` if the Nagle algorithm is enabled; otherwise, `false`. The default is `true`. **Note:**  The Nagle algorithm reduces network traffic by buffering small packets of data and transmitting them as a single packet. This process is also referred to as *nagling*; it is widely used because it reduces the number of packets transmitted and lowers the overhead per packet.|  
  
## Subclasses  

 This class contains no subclasses.  
  
## Remarks  

 Instances of this class are contained in the `ServicePointManager` property of the [SettingsSection](../wmi-provider/settingssection-class.md) class.  
  
## Inheritance Hierarchy  

 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `ServicePointManagerSettings`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [SettingsSection Class](../wmi-provider/settingssection-class.md)   
 [WebRequest Class](https://go.microsoft.com/fwlink/?LinkId=69332)
