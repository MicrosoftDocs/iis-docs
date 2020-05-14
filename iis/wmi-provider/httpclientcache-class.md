---
title: "HttpClientCache Class"
ms.date: "10/07/2016"
ms.assetid: aba023d7-f6f2-0cdb-44b9-0e1e8b75db16
---
# HttpClientCache Class
Exposes the caching configuration for an HTTP client.  
  
## Syntax  
  
```vbs  
class HttpClientCache : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `HttpClientCache` class.  
  
|Name|Description|  
|----------|-----------------|  
|`CacheControlCustom`|A read/write `string` value that specifies an HTTP 1.1 `Cache-Control` header to add to the response.|  
|`CacheControlMaxAge`|A read/write `datetime` value that specifies the maximum age for the HTTP 1.1 cache control. The default is 1 day.|  
|`CacheControlMode`|A read/write `sint32` enumeration that specifies the mode to use for client caching. The possible values are listed later in the Remarks section.|  
|`HttpExpires`|A read/write `string` value that specifies, in Request for Comments (RFC) 1123 format, the date and time after which a cached response is considered stale.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `ClientCache` array property of the [StaticContentSection](../wmi-provider/staticcontentsection-class.md) class.  
  
 The following table contains the possible values for the `CacheControlMode` property. The default is 0 (`NoControl`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`NoControl`|Does not add a `Cache-Control` or `Expires` header to the response.|  
|1|`DisableCache`|Adds a `Cache-Control: no-cache` header to the response.|  
|2|`UseMaxAge`|Adds a `Cache-Control: max-age=<nnn>` header to the response based on the value specified in the `CacheControlMaxAge` property.|  
|3|`UseExpires`|Adds an `Expires: <date>` header to the response based on the date specified in the `HttpExpires` property.|  
  
 For more information about header fields, see Request for Comments (RFC) 2616, "Hypertext Transfer Protocol -- HTTP/1.1."  
  
 For more information about date and time formats, see RFC 1123, "Requirements for Internet Hosts -- Application and Support."  
  
## Example  
 The following example displays the properties for the `HttpClientCache` class.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Retrieve the static content section.  
Set oSection = oWebAdmin.Get("StaticContentSection.Path=" & _  
    "'MACHINE/WEBROOT/APPHOST',Location=''")  
  
' Show the path and location.  
WScript.Echo "Path: " & oSection.Path  
WScript.Echo "Location: " & oSection.Location  
WScript.Echo  
  
Display the embedded HttpClientCache properties.  
Set ohttpClientCache = oSection.ClientCache  
WScript.Echo "HttpClientCache properties"  
WScript.Echo "--------------------------"  
WScript.Echo "CacheControlCustom: " & ohttpClientCache.CacheControlCustom  
WScript.Echo "CacheControlMaxAge: " & ohttpClientCache.CacheControlMaxAge  
WScript.Echo "CacheControlMode: " & _  
    GetCacheControlModeText(ohttpClientCache.CacheControlMode)  
WScript.Echo "HttpExpires: " & ohttpClientCache.HttpExpires  
  
' Provide text for CacheControlMode enumeration values.  
Function GetCacheControlModeText(uint32Mode)  
    Select Case uint32Mode  
        Case 0  
            GetCacheControlModeText="NoControl"  
        Case 1  
            GetCacheControlModeText="DisableCache"  
        Case 2  
            GetCacheControlModeText="UseMaxAge"  
        Case 3  
            GetCacheControlModeText="UseExpires"  
        Case Else  
            GetCacheControlModeText="Unknown Mode"  
    End Select  
End Function  
```  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `HttpClientCache`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)
 [StaticContentSection Class](../wmi-provider/staticcontentsection-class.md)
 [CIM_DATETIME](https://go.microsoft.com/fwlink/?LinkId=57551)
 [Datetime.Parse Method](https://go.microsoft.com/fwlink/?LinkId=60577)
