---
title: RequestCachingSection Class
description: Describes the RequestCachingSection class and provides the class' syntax, methods, properties, remarks, inheritance hierarchy, and requirements.
ms.date: 10/07/2016
ms.assetid: 142f14bd-be2f-2ed7-a8ac-f2eae361c96e
---
# RequestCachingSection Class
Contains configuration information for request caching.  
  
## Syntax  
  
```vbs  
class RequestCachingSection : ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `RequestCachingSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `RequestCachingSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`DefaultFtpCachePolicy`|An [FtpCachePolicySettings](../wmi-provider/ftpcachepolicysettings-class.md) value that specifies the default FTP caching behavior for the local computer.|  
|`DefaultHttpCachePolicy`|An [HttpCachePolicySettings](../wmi-provider/httpcachepolicysettings-class.md) value that specifies the default HTTP caching behavior for the local computer.|  
|`DefaultPolicyLevel`|A read/write `sint32` value that specifies the default cache policy level. The possible values are listed later in the Remarks section.|  
|`DisableAllCaching`|A read/write `boolean` value. `true` if caching is disabled on the local computer; otherwise, `false`. **Note:**  If this configuration attribute is set to `true` in any configuration file, caching is disabled globally, and all other cache-related settings are ignored.|  
|`IsPrivateCache`|A read/write `boolean` value. `true` if the local computer cache is private (that is, provides user isolation); otherwise, `false`. **Note:**  On client computers, this value is typically set to `true`, which indicates that one user cannot use resources cached by another user. For middle-tier applications, this value is typically set to `false`.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
|`UnspecifiedMaximumAge`|A read/write `datetime` value that specifies the default maximum age for cached resources that do not have expiration information. The default is 1 day. Setting this property ensures that a resource that does not have expiration header information does not remain fresh in the cache indefinitely.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 The following table lists the possible values for the `DefaultPolicyLevel` property. The default is 1 (`BypassCache`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`Default`|Satisfies a request for a resource either by using the cached copy of the resource or by sending a request for the resource to the server. The action taken is determined by the current cache policy and the age of the content in the cache. Most applications should use this cache level.|  
|1|`BypassCache`|Satisfies a request by using the server. No entries are taken from caches, added to caches, or removed from caches between the client and server. This is the default cache behavior specified in the computer configuration file that is included with the [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)].|  
|2|`CacheOnly`|Satisfies a request by using the locally cached resource; does not send a request for an item that is not in the cache. When this cache policy level is specified, a [WebException](/dotnet/api/system.net.webexception) exception is thrown if the item is not in the client cache.|  
|3|`CacheIfAvailable`|Satisfies a request for a resource from the cache if the resource is available; otherwise, sends a request for a resource to the server. If the requested item is not available in the local cache, but it is available in a cache between the client and the server, the intermediate cache satisfies the request.|  
|4|`Revalidate`|Satisfies a request by using the cached copy of the resource if the time stamp is the same as the time stamp of the resource on the server; otherwise, the resource is downloaded from the server, presented to the caller, and stored in the cache.|  
|5|`Reload`|Satisfies a request by using the server. The response might be saved in the cache, depending on the settings of the `no-cache` cache control directive and the `Pragma: no-cache` header in the HTTP caching protocol.|  
|6|`NoCacheNoStore`|Never satisfies a request by using resources from the cache, and does not cache resources. If the resource is present in the local cache, it is removed. This policy level indicates to intermediate caches that they should remove the resource. In the HTTP caching protocol, this is achieved by using the `no-cache` cache control directive.|  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 `RequestCachingSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)   
 [FtpCachePolicySettings Class](../wmi-provider/ftpcachepolicysettings-class.md)   
 [HttpCachePolicySettings Class](../wmi-provider/httpcachepolicysettings-class.md)   
 [System.Net.Cache.RequestCacheLevel Enumeration](/dotnet/api/system.net.cache.requestcachelevel)   
 [System.Net.WebException Class](/dotnet/api/system.net.webexception)   
 CIM_DATETIME
