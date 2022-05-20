---
title: "WebServicesProtocolElement Class"
description: "The WebServicesProtocolElement class specifies a transmission protocol or protocols that are used to decrypt data sent from a client browser in an HTTP request."
ms.date: "10/07/2016"
ms.assetid: a9d8a894-5643-050e-f028-3af31e0202a3
---
# WebServicesProtocolElement Class
Specifies a transmission protocol or protocols that are used to decrypt data sent from a client browser in an HTTP request.  
  
## Syntax  
  
```vbs  
class WebServicesProtocolElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `WebServicesProtocolElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Name`|A read-only `sint32` mask that specifies the transmission protocols that are used to decrypt data sent from a client browser in the HTTP request. The possible values are listed later in the Remarks section. The key property.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are exposed as members of the `Protocols` property in the [WebServicesProtocolSettings](../wmi-provider/webservicesprotocolsettings-class.md) class.  
  
 The following table lists the possible values for the `Name` property.  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`Unknown`|An unknown protocol.|  
|1|`HttpSoap`|The HTTP SOAP protocol.|  
|2|`HttpGet`|The HTTP GET protocol.|  
|4|`HttpPost`|The HTTP POST protocol.|  
|8|`Documentation`|The XML Web services Documentation protocol.|  
|16|`HttpPostLocalhost`|The HTTP POST LOCALHOST protocol. **Note:**  This value checks only the request's host header to mitigate browser-redirect attacks. This value does not perform any other validation, authentication, or authorization checks. Authentication and authorization are still required to restrict access to a Web service.|  
|32|`HttpSoap12`|The HTTP SOAP version 1.2 protocol.|  
|33|`AnyHttpSoap`|Any version of the HTTP SOAP protocol.|  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `WebServicesProtocolElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [WebServicesProtocolSettings Class](../wmi-provider/webservicesprotocolsettings-class.md)   
 [WebServicesSection Class](../wmi-provider/webservicessection-class.md)   
 [System.Web.Services.Configuration.WebServiceProtocols Enumeration](https://go.microsoft.com/fwlink/?LinkId=69314)
