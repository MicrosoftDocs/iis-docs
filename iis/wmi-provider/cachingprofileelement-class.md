---
title: "CachingProfileElement Class"
ms.date: "10/07/2016"
ms.assetid: 5152947a-4fcf-afcc-70a5-b370b0bf7301
---
# CachingProfileElement Class
Configures caching for a given request extension.  
  
## Syntax  
  
```vbs  
class CachingProfileElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `CachingProfileElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Duration`|A read/write `datetime` value that specifies the amount of time a response should remain in the cache. The default is 30 seconds. The valid time range is from 0 through 365 days.|  
|`Extension`|A required unique read/write `string` value that specifies the extension of a request that will use the cache profile. The extension must be in the form "*EXT*" or "*\**", where *EXT* is the extension. The key property. **Note:**  No overlapping extension entries are allowed. Each request maps to exactly one `CachingProfileElement` object. If an entry with a "*\**" exists, other caching profiles with more specific extensions will override the profile with the asterisk. The ordering of profile entries is not important.|  
|`KernelCachePolicy`|A read/write `sint32` value that configures the kernel caching policy. The possible values are listed later in the Remarks section.|  
|`Location`|A read/write `sint32` value that specifies possible locations for the output cache. The possible values are listed later in the Remarks section.|  
|`Policy`|A read/write `sint32` value that configures the output caching policy. The possible values are listed later in the Remarks section.|  
|`VaryByHeaders`|A read/write `string` value that contains a comma-delimited list of header names that the server will use to vary cached responses to the URL.|  
|`VaryByQueryString`|A read/write `string` value that contains a comma-delimited list of query string parameter names that the server will use to vary cached responses to the URL.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 This class corresponds to the `<profiles>` element under the `<system.webServer/caching>` section in the ApplicationHost.config file. Instances of this class are contained in the `Profiles` array property of the [CachingProfileSettings](../wmi-provider/cachingprofilesettings-class.md) class.  
  
 The following table lists the possible values for the `KernelCachePolicy` property. The default is 0 (`DontCache`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`DontCache`|The response will not be cached in the kernel. However, output caching can still occur. **Note:**  This setting overrides any conflicting settings in the `Location` property.|  
|1|`CacheUntilChange`|The response is cached in the HTTP.SYS cache until the entry is invalidated or until it expires after the period of inactivity specified by the `Duration` property.|  
|2|`CacheForTimePeriod`|The response is cached for the amount of time specified by the `Duration` property, even if the entry is invalidated in the interim.|  
|3|`DisableCache`|The cache is disabled and no caching will occur.|  
  
 The following table lists the possible values for the `Location` property. The default is 3 (`Server`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`Any`|The response can be cached on the client, Web server, or proxy server.|  
|1|`Client`|The response is cached only on the client.|  
|2|`Downstream`|The response is cached on proxy servers and on the client, but not on the Web server.|  
|3|`Server`|The response is cached only on the Web server.|  
|4|`None`|The response is not cached anywhere.|  
|5|`ServerAndClient`|The response is cached on both the Web server and the client, but not on proxy servers. **Note:**  You can use this setting to avoid sharing content among multiple users on proxy caches when the server has varying behavior for private content.|  
  
 The following table lists the possible values for the `Policy` property. The default is 0 (`DontCache`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`DontCache`|The response will not be placed in the output cache. However, kernel caching can still occur.|  
|1|`CacheUntilChange`|The response is cached until the entry is invalidated or until it expires after the period of inactivity specified by the `Duration` property.|  
|2|`CacheForTimePeriod`|The response is cached for the amount of time specified by the `Duration` property, even if the entry is invalidated in the interim.|  
|3|`DisableCache`|The cache is disabled and no caching will occur.|  
  
## Example  
 The following example displays all of the `CachingProfileElement` objects for the default Web site.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the caching section for the default Web site.  
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
oSite.GetSection "CachingSection", oSection  
  
' Display the path and location.  
Wscript.Echo "Path: " & oSection.Path  
Wscript.Echo "Location: " & oSection.Location  
Wscript.Echo   
  
' Display all of the caching profiles for the default Web site.  
For Each oCachingProfileElement In oSection.Profiles.Profiles  
    Wscript.Echo   
    WScript.Echo "[ " & oCachingProfileElement.Extension & _  
        " ] Caching Profile"  
    WScript.Echo "-----------------------------------"  
    WScript.Echo "Duration: " & oCachingProfileElement.Duration  
    WScript.Echo "KernelCachePolicy: " & _  
        CachePolicyText(oCachingProfileElement.KernelCachePolicy)  
    WScript.Echo "Location: " & _  
        LocationText(oCachingProfileElement.Location)  
    WScript.Echo "Policy: " & _  
        CachePolicyText(oCachingProfileElement.Policy)  
    WScript.Echo "VaryByHeaders: " & _  
        oCachingProfileElement.VaryByHeaders  
    WScript.Echo "VaryByQueryString: " & _  
        oCachingProfileElement.VaryByQueryString  
    WScript.Echo               
Next  
  
' Provide text for KernelCachePolicy and Policy enumeration values.  
Function CachePolicyText(enumval)  
  
Select Case enumval  
    Case 0  
        CachePolicyText="DontCache"  
    Case 1  
        CachePolicyText="CacheUntilChange"  
    Case 2  
        CachePolicyText="CacheForTimePeriod"  
    Case 3  
        CachePolicyText="DisableCache"  
    Case Else  
        CachePolicyText="Undefined enumeration value"  
End Select  
  
End Function  
  
' Provide text for Location enumeration values.  
Function LocationText(enumval)  
  
Select Case enumval  
    Case 0  
        LocationText="Any"  
    Case 1  
        LocationText="Client"  
    Case 2  
        GetLocationText="Downstream"  
    Case 3  
        LocationText="Server"  
    Case 4  
        LocationText="None"  
    Case 5  
        LocationText="ServerAndClient"  
    Case Else  
        LocationText="Undefined enumeration value"  
End Select  
  
End Function  
  
```  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `CachingProfileElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [AspCache Class](../wmi-provider/aspcache-class.md)   
 [CachingProfileSettings Class](../wmi-provider/cachingprofilesettings-class.md)   
 [CachingSection Class](../wmi-provider/cachingsection-class.md)   
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [HttpClientCache Class](../wmi-provider/httpclientcache-class.md)