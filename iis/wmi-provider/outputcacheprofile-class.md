---
title: OutputCacheProfile Class
description: Describes the OutputCacheProfile class and provides the class' syntax, methods, properties, remarks, inheritance hierarchy, and requirements.
ms.date: 10/07/2016
ms.assetid: d61ba4fe-4570-e1a3-62ca-db897a24de99
---
# OutputCacheProfile Class
Configures the output cache profile for the pages of a Web application.  
  
## Syntax  
  
```vbs  
class OutputCacheProfile : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `OutputCacheProfile` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Duration`|A read/write `sint32` value that specifies the time, in seconds, that the page or user control is cached. The default is –1. Setting this attribute on a page or user control establishes an expiration policy for HTTP responses from the page or user control and will automatically cache the page or user control output. **Note:**  This property must be defined in either the profile or the `@ OutputCache` directive of a page that is using the profile.|  
|`Enabled`|A read/write `boolean` value. `true` if caching is enabled for all pages or controls that use this output cache profile; otherwise, `false`. The default is `true`.|  
|`Location`|A read/write `sint32` value that specifies the location of the cache. The possible values are listed later in the Remarks section.|  
|`Name`|A read-only `string` value that specifies the name of the output cache profile.|  
|`NoStore`|A read/write `boolean` value. `true` if the page issues a `Cache-Control: Private no-store` header in the HTTP response that directs the browser not to cache the page; otherwise, `false`. The default is `false`. **Note:**  Setting this attribute to `true` is equivalent to invoking the [System.Web.HttpCachePolicy.SetNoStore](/dotnet/api/system.web.httpcachepolicy.setnostore) method during a Web request.|  
|`SqlDependency`|A read/write `string` value that identifies a set of SQL database and table name pairs on which a page or control's output cache depends. When you specify a string for this property, output cached pages can be removed from the cache whenever the SQL table on which they depend changes.|  
|`VaryByControl`|A read/write `string` value that specifies a comma-delimited set of IDs of controls to be cached. **Note:**  The settings for this property are the same as those of the `VaryByControls` attribute of the `@ OutputCache` directive.|  
|`VaryByCustom`|A read/write comma-delimited `string` value that represents custom output caching requirements. If you give this property the value of "browser", the cache is varied by browser name and major version information. If you enter a custom string, you must override the `GetVaryByCustomString` method in the Global.asax file for your application. **Note:**  The settings for this property are the same as those of the `VaryByCustom` attribute of the `@ OutputCache` directive.|  
|`VaryByHeader`|A read/write `string` value that specifies a comma-delimited set of HTTP headers that are associated with the request and are used to vary the cached output. **Note:**  The settings for this property are the same as those of the `VaryByHeader` attribute of the `@ OutputCache` directive.|  
|`VaryByParam`|A `string` value that specifies a comma-delimited set of parameters that vary the cached output by GET query string or form POST parameters. **Note:**  The settings for this property are the same as those of the `VaryByParam` attribute of the `@ OutputCache` directive.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `OutputCacheProfiles` array property of the [OutputCacheProfileSettings](../wmi-provider/outputcacheprofilesettings-class.md) class.  
  
 The following table lists the possible values for the `Location` property.  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`Any`|The page is cached on the server, all HTTP 1.1 compliant proxies, and the client. This value corresponds to the [System.Web.HttpCacheability.Public](/dotnet/api/system.web.httpcacheability) enumeration value.|  
|1|`Client`|The page is cached only on the client where the request originated. This value corresponds to the [System.Web.HttpCacheability.Private](/dotnet/api/system.web.httpcacheability) enumeration value.|  
|2|`Downstream`|The page is cached on any HTTP 1.1 cache-capable devices except the originating server. Cache-capable devices include proxy servers and the client that made the request.|  
|3|`Server`|The page is cached only on the Web server where the request was processed. This value corresponds to the [System.Web.HttpCacheability.Server](/dotnet/api/system.web.httpcacheability) enumeration value.|  
|4|`None`|The page is not cached. This value corresponds to the [System.Web.HttpCacheability.NoCache](/dotnet/api/system.web.httpcacheability) enumeration value.|  
|5|`ServerAndClient`|The page is cached only on the originating server or on the requesting client. Proxy servers are not allowed to cache the response. This value corresponds to the combination of the [System.Web.HttpCacheability.Private](/dotnet/api/system.web.httpcacheability) and [System.Web.HttpCacheability.Server](/dotnet/api/system.web.httpcacheability) enumeration values.|  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `OutputCacheProfile`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [System.Web.HttpCachePolicy.SetNoStore](/dotnet/api/system.web.httpcachepolicy.setnostore) 
 [System.Web.HttpCacheability](/dotnet/api/system.web.httpcacheability)
 [System.Web.UI.OutputCacheLocation](/dotnet/api/system.web.configuration.outputcacheprofile.location)   
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [OutputCacheSection Class](../wmi-provider/outputcachesection-class.md)   
 [OutputCacheSettingsSection Class](../wmi-provider/outputcachesettingssection-class.md)   
 [OutputCacheProfileSettings Class](../wmi-provider/outputcacheprofilesettings-class.md)   
 [SqlCacheDependencySection Class](../wmi-provider/sqlcachedependencysection-class.md)   
 [@ OutputCache](/dotnet/api/system.web.caching.outputcache)   
 [Caching Multiple Versions of User Control Output](/previous-versions/aspnet/k4he1ds5(v=vs.100))
