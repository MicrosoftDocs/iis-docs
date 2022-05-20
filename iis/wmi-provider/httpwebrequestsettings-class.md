---
title: "HttpWebRequestSettings Class"
description: "The HttpWebRequestSettings class configures the maximum length for response headers. This article describes its syntax, methods, properties, remarks, and requirements."
ms.date: "10/07/2016"
ms.assetid: e3c34f66-20eb-c2e1-b0ee-f3f127d8b35c
---
# HttpWebRequestSettings Class
Configures the maximum length for response headers.  
  
## Syntax  
  
```vbs  
class HttpWebRequestSettings : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `HttpWebRequestSettings` class.  
  
|Name|Description|  
|----------|-----------------|  
|`MaximumErrorResponseLength`|A read/write `sint32` value that specifies the maximum allowed length, in kilobytes, of an error response. The default is 64.|  
|`MaximumResponseHeadersLength`|A read/write `sint32` value that specifies the maximum allowed length of the response headers. The default is 64.<br /><br /> The length is measured in kilobytes (1024 bytes) and it includes the response status line and the response headers, as well as all extra control characters received as part of the HTTP protocol. A value of -1 means no limit is imposed on the response headers; a value of 0 means that all requests will fail.|  
|`MaximumUnauthorizedUploadLength`|A read/write `sint32` value that specifies the maximum length, in bytes, of an upload in response to an unauthorized error code. The default is –1, which indicates that no size limit will be imposed on the upload.|  
|`UseUnsafeHeaderParsing`|A read/write `boolean` value. `true` if validation errors that occur during HTTP parsing are ignored; otherwise, `false`. The default is `false`.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `HttpWebRequest` property of the [SettingsSection](../wmi-provider/settingssection-class.md) class.  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `HttpWebRequestSettings`  
  
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
