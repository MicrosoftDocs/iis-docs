---
title: HttpCachePolicySettings Class
description: Describes the HttpCachePolicySettings class and provides the class' syntax, properties, remarks, examples, and requirements.
ms.date: 10/07/2016
ms.assetid: 5eeb1357-ddb1-a9b2-fc3b-c34428e9b6ed
---
# HttpCachePolicySettings Class
Represents the default HTTP cache policy for network resources.  
  
## Syntax  
  
```vbs  
class HttpCachePolicySettings : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `HttpCachePolicySettings` class.  
  
|Name|Description|  
|----------|-----------------|  
|`MaximumAge`|A read/write `datetime` value that specifies the maximum age permitted for a resource returned from the cache. The default is infinite.<br /><br /> If the cached copy of the resource is older than the specified time value, the resource must be revalidated by comparing the cached resource to the resource on the server.|  
|`MaximumStale`|A read/write `datetime` value that specifies the amount of time that the cached copy of the resource can be used after content expiration. The default is 0.|  
|`MinimumFresh`|A read/write `datetime` value that specifies the amount of time that the cached copy of the resource can be used before content expiration. The default is 0.|  
|`PolicyLevel`|A read/write `sint32` value that specifies the HTTP caching behavior for the local computer. The possible values are listed later in the Remarks section.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `DefaultHttpCachePolicy` property of the [RequestCachingSection](../wmi-provider/requestcachingsection-class.md) class.  
  
 The following table lists the possible values for the `PolicyLevel` property. The default is 0 (`Default`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`Default`|Satisfies a request for a resource either by using the cached copy of the resource or by sending a request for the resource to the server. The action taken is determined by the current cache policy and the age of the content in the cache. This is the cache level that most applications should use.|  
|1|`BypassCache`|Satisfies a request by using the server. No entries are taken from caches, added to caches, or removed from caches between the client and server. This is the default cache behavior specified in the computer configuration file that is included with the [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)].|  
|2|`CacheOnly`|Satisfies a request by using the locally cached resource; does not send a request for an item that is not in the cache. When this cache policy level is specified, a [WebException](/dotnet/api/system.net.webexception) exception is thrown if the item is not in the client cache.|  
|3|`CacheIfAvailable`|Satisfies a request for a resource from the cache if the resource is available in the cache; otherwise, sends a request for a resource to the server. If the requested item is not available in the local cache, but it is available in a cache between the client and the server, the intermediate cache satisfies the request.|  
|4|`Revalidate`|Satisfies a request by using the cached copy of the resource if the time stamp is the same as the time stamp of the resource on the server; otherwise, the resource is downloaded from the server, presented to the caller, and stored in the cache.|  
|5|`Reload`|Satisfies a request by using the server. The response might be saved in the cache, depending on the settings of the `no-cache` cache control directive and the `Pragma: no-cache` header in the HTTP caching protocol.|  
|6|`NoCacheNoStore`|Never satisfies a request by using resources from the cache, and does not cache resources. If the resource is present in the local cache, it is removed. This policy level indicates to intermediate caches that they should remove the resource. In the HTTP caching protocol, this is achieved by using the `no-cache` cache control directive.|  
|7|`CacheOrNextCacheOnly`|Satisfies a request for a resource from either the local computer's cache or a remote cache on the local area network. If the request cannot be satisfied, a `WebException` exception is thrown. In the HTTP caching protocol, this is achieved by using the `only-if-cached` cache control directive.|  
|8|`Refresh`|Satisfies a request by using the server or a cache other than the local cache. Before an intermediate cache can satisfy the request, that cache must revalidate its cached entry with the server. In the HTTP caching protocol, this is achieved by using the `max-age = 0` cache control directive and the `Pragma:``no-cache` header.|  
  
## Example  
 The following code example specifies the http caching policy and sets values for the `MinimumFresh`, `MaximumStale`, and `MaximumAge` properties.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the RequestCachingSection.  
Set oSection = oWebAdmin.Get("RequestCachingSection.Path=" & _  
    "'MACHINE/WEBROOT/APPHOST',Location=''")  
  
' Display the class name of the section.  
WScript.Echo "[ " & oSection.Path_.Class & " ]"  
  
' Display the initial values for the DefaultHttpCachePolicy property.  
Call DisplayValues("Initial Values", oSection.DefaultHttpCachePolicy)  
  
' Set the http cache policy to use the default.  
oSection.DefaultHttpCachePolicy.PolicyLevel = 0  
  
' Set the MinimumFresh property to 30 minutes.  
oSection.DefaultHttpCachePolicy.MinimumFresh = "00000000003000.000000:000"  
  
' Set the MaximumStale property to 10 minutes.  
oSection.DefaultHttpCachePolicy.MaximumStale = "00000000001000.000000:000"  
  
' Set the MaximumAge property to 1 hour.  
oSection.DefaultHttpCachePolicy.MaximumAge =   "00000000010000.000000:000"  
  
' Save the values to configuration.  
oSection.Put_  
  
' Refresh the oSection object variable with the new values.  
oSection.Refresh_  
  
' Show the changed values.  
Call DisplayValues("New Values", oSection.DefaultHttpCachePolicy)  
  
' ==== DisplayValues helper function. ====  
Function DisplayValues(HeadingText, oObject)  
    WScript.Echo  
    WScript.Echo String(Len(HeadingText), "=")  
    WScript.Echo HeadingText  
    WScript.Echo String(Len(HeadingText), "=")  
  
    For Each Prop In oObject.Properties_  
        WScript.Echo Prop.Name & ": " & Prop.Value  
    Next  
End Function  
  
```  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `HttpCachePolicySettings`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [FtpCachePolicySettings Class](../wmi-provider/ftpcachepolicysettings-class.md)   
 [RequestCachingSection Class](../wmi-provider/requestcachingsection-class.md)   
 CIM_DATETIME
