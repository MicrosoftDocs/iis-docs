---
title: "HttpCompressionSection Class"
ms.date: "10/07/2016"
ms.assetid: ce0cb6ed-e8a5-ebb7-d063-cdd80ccf6ac9
---
# HttpCompressionSection Class
Configures HTTP compression.  
  
## Syntax  
  
```vbs  
class HttpCompressionSection : ConfigurationSectionWithCollection  
```  
  
## Methods  
 The following table lists the methods exposed by the `HttpCompressionSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[Add](../wmi-provider/configurationsectionwithcollection-add-method.md)|(Inherited from [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md).)|  
|[Clear](../wmi-provider/configurationsectionwithcollection-clear-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[Get](../wmi-provider/configurationsectionwithcollection-get-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[Remove](../wmi-provider/configurationsectionwithcollection-remove-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `HttpCompressionSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`CacheControlHeader`|A read/write `string` value that specifies the `Cache-Control` header that is sent with compressed files. The default is "max-age=86400". To enable this setting, you must set the `SendCacheHeaders` property to `true`. You must also restart the World Wide Web Publishing Service (WWW service) before changes to the `CacheControlHeader` property will take effect. **Note:**  The `Cache-Control` header is sent with the `HTTP Expires` header that is specified in the `ExpiresHeader` property. This combination of headers ensures that older clients and proxy servers do not try to cache compressed files.|  
|`Directory`|A read/write `string` value that specifies the directory where compressed versions of static files are temporarily stored and cached. The default is "%SystemDrive%\inetpub\temp\IIS Temporary Compressed Files". [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)] creates a subfolder in this folder for each application pool, and a subfolder in each application pool folder for each compression scheme. **Note:**  The default directory path for IIS temporary compressed files in IIS 6.0 was %Windir%\\\IIS Temporary Compressed Files, and a flat directory structure was used.|  
|`DoDiskSpaceLimiting`|A read/write `boolean` value. `true` if a limit exists for the amount of disk space that compressed files in the compressed files folder can occupy; otherwise, `false`. The default is `true`. The compressed files folder is specified by the `Directory` property.|  
|`DynamicCompressionDisableCpuUsage`|A read/write `uint32` value that specifies the percentage of CPU utilization at which dynamic compression will be disabled. The default is 90. The value must be between 0 and 100. Average CPU utilization is calculated every 30 seconds. **Note:**  This property acts as an upper CPU limit at which dynamic compression is turned off. When CPU utilization falls below the value specified in the `DynamicCompressionEnableCpuUsage` property, dynamic compression will be reenabled.|  
|`DynamicCompressionEnableCpuUsage`|A read/write `uint32` value that specifies the percentage of CPU utilization below which dynamic compression will be enabled. The default is 50. The value must be between 0 and 100. Average CPU utilization is calculated every 30 seconds. **Note:**  This property acts as a lower CPU limit below which dynamic compression is turned on. When CPU utilization rises above the value specified in the `DynamicCompressionDisableCpuUsage` property, dynamic compression will be disabled.|  
|`DynamicTypes`|A [DynamicTypeSettings](../wmi-provider/dynamictypesettings-class.md) value that contains file name extensions that IIS can serve with dynamic compression.|  
|`ExpiresHeader`|A read/write `string` value that specifies the content of the `HTTP Expires` header that is sent with compressed files. The default is "Wed, 01 Jan 1997 12:00:00 GMT". To enable this setting, you must set the `SendCacheHeaders` property to `true`. You must also restart the WWW service before changes to the `ExpiresHeader` property will take effect. **Note:**  The `HTTP Expires` header is sent with the `Cache-Control` header that is specified in the `CacheControlHeader` property. This combination of headers ensures that older clients and proxy servers do not try to cache compressed files.|  
|`HttpCompression`|An array of [HttpCompressionSchemeElement](../wmi-provider/httpcompressionschemeelement-class.md) values that specify the compression schemes (Gzip or Deflate) that IIS uses to compress client requests.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`MaxDiskSpaceUsage`|A read/write `uint32` value that specifies a limit of disk space, in megabytes, that compressed files can occupy in the compression directory. The default is 100. When the space used by compressed files exceeds 90 percent of the value in `MaxDiskSpaceUsage`, IIS deletes the least recently used files until a 90-percent usage level is reached. **Note:**  In IIS 6.0, this limit is expressed in bytes; in [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)], it is expressed in megabytes. In [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)] the limit is applied per application pool.|  
|`MinFileSizeForComp`|A read/write `uint32` value that specifies the minimum file size, in kilobytes, for a file to be compressed. The default is 256.|  
|`NoCompressionForHttp10`|A read/write `boolean` value. `true` if compression is disabled for requests that contain an HTTP 1.0 version number; otherwise, `false`. The default is `true`. **Note:**  Some HTTP 1.0 clients do not handle the caching of compressed objects correctly. You can use this setting to avoid returning a compressed file to a client that cannot decompress it.|  
|`NoCompressionForProxies`|A read/write `boolean` value. `true` if compression is disabled for HTTP 1.1 requests that come through a proxy server; otherwise, `false`. The default is `true.` **Note:**  Some HTTP proxy servers do not handle the caching of compressed objects correctly. You can use this setting to avoid returning a compressed file to a proxy server that cannot decompress it.|  
|`NoCompressionForRange`|A read/write `boolean` value. `true` if compression is disabled for HTTP requests that include the `Range` header; otherwise, `false`. The default is `true`. **Note:**  Some clients cannot handle range requests correctly. You can use this setting to avoid returning a compressed file to a client that cannot decompress it.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
|`SendCacheHeaders`|A read/write `boolean` value. `true` if the headers configured in the `CacheControlHeader` and `ExpiresHeader` properties are sent with compressed responses; otherwise, `false`. The default is `false`.|  
|`StaticCompressionDisableCpuUsage`|A read/write `uint32` value that specifies the percentage of CPU utilization at which static compression is disabled. The default is 100. The value must be between 0 and 100. Average CPU utilization is calculated every 30 seconds. **Note:**  This property acts as an upper CPU limit at which static compression is turned off. When CPU utilization falls below the value specified in the `StaticCompressionEnableCpuUsage` property, static compression will be reenabled.|  
|`StaticCompressionEnableCpuUsage`|A read/write `uint32` value that specifies the percentage of CPU utilization at which static compression is enabled. The default is 50. The value must be between 0 and 100. Average CPU utilization is calculated every 30 seconds. **Note:**  This property acts as a lower CPU limit below which static compression is turned on. When CPU utilization rises above the value specified in the `StaticCompressionDisableCpuUsage` property, static compression will be disabled.|  
|`StaticTypes`|A [StaticTypeSettings](../wmi-provider/statictypesettings-class.md) value that contains file name extensions that IIS can serve with static compression.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Static compression is on by default in [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)]. The `StaticCompressionEnableCpuUsage`, `StaticCompressionDisableCpuUsage`, `DynamicCompressionEnableCpuUsage`, and `DynamicCompressionDisableCpuUsage` properties have been added to enable or disable compression on the fly depending on CPU load.  
  
 The following compression properties from IIS 6.0 are no longer present in [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)]:  
  
-   [HcCompressionBufferSize](<!-- TODO: review code entity reference <xref:assetId:///HcCompressionBufferSize?qualifyHint=False&amp;autoUpgrade=True>  -->)  
  
-   `HcCreateFlags`  
  
-   `HcDoOnDemandCompression`  
  
-   `HcFileExtensions`  
  
-   `HcFilesDeletedPerDiskFree`  
  
-   `HcIoBufferSize`  
  
-   `HcMaxQueueLength`  
  
-   `HcPriority`  
  
-   `HcScriptFileExtensions`  
  
## Example  
 The following example displays the non-array properties in the `HttpCompressionSection` class and lists the static and dynamic compression array properties.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject( _  
    "winmgmts:root\WebAdministration")  
  
' Get the HTTP compression section.  
Set oSection = oWebAdmin.Get( _  
    "HttpCompressionSection.Path=" & _  
    "'MACHINE/WEBROOT/APPHOST',Location=''")  
  
' Display the properties that are not collections.  
WScript.Echo "HttpCompressionSection properties"  
WScript.Echo "---------------------------------"  
WScript.Echo "Directory: " & oSection.Directory  
WScript.Echo "DoDiskSpaceLimiting: " & _  
    oSection.DoDiskSpaceLimiting  
WScript.Echo "DynamicCompressionDisableCpuUsage: " & _  
    oSection.DynamicCompressionDisableCpuUsage  
WScript.Echo "DynamicCompressionEnableCpuUsage: " & _  
    oSection.DynamicCompressionEnableCpuUsage  
WScript.Echo "ExpiresHeader: " & oSection.ExpiresHeader  
WScript.Echo "MaxDiskSpaceUsage: " & _  
    oSection.MaxDiskSpaceUsage  
WScript.Echo "MinFileSizeForComp: " & _  
    oSection.MinFileSizeForComp  
WScript.Echo "NoCompressionForProxies: " & _  
    oSection.NoCompressionForProxies  
WScript.Echo "NoCompressionForRange: " & _  
    oSection.NoCompressionForRange  
WScript.Echo "SendCacheHeaders: " & _  
    oSection.SendCacheHeaders  
WScript.Echo "StaticCompressionDisableCpuUsage: " & _  
    oSection.StaticCompressionDisableCpuUsage  
WScript.Echo "StaticCompressionEnableCpuUsage: " & _  
    oSection.StaticCompressionEnableCpuUsage  
WScript.Echo  
  
' Display the static compression types.  
WScript.Echo _  
    "HttpCompressionSection.StaticTypes.StaticTypes"  
WScript.Echo _  
    "----------------------------------------------"  
For Each oType In oSection.StaticTypes.StaticTypes  
    WScript.Echo "MimeType: " & oType.MimeType  
    WScript.Echo "Enabled: " & oType.Enabled  
    WScript.Echo  
Next  
WScript.Echo  
  
' Display the dynamic compression types.  
WScript.Echo _  
    "HttpCompressionSection.DynamicTypes.DynamicTypes"  
WScript.Echo _  
    "------------------------------------------------"  
For Each oType In oSection.DynamicTypes.DynamicTypes  
    WScript.Echo "MimeType: " & oType.MimeType  
    WScript.Echo "Enabled: " & oType.Enabled  
    WScript.Echo  
Next  
  
' Display the compression scheme elements.  
WScript.Echo "HttpCompressionSection.HttpCompression"  
WScript.Echo "-----------------------------------"  
For Each oScheme In oSection.HttpCompression  
    WScript.Echo "Name: " & oScheme.Name  
    WScript.Echo "Dll: " & oScheme.Dll  
    WScript.Echo "DoStaticCompression: " & _  
        oScheme.DoStaticCompression  
    WScript.Echo "StaticCompressionLevel: " & _  
        oScheme.StaticCompressionLevel  
    WScript.Echo "DoDynamicCompression: " & _  
        oScheme.DoDynamicCompression  
    WScript.Echo "DynamicCompressionLevel: " & _  
        oScheme.DynamicCompressionLevel  
    WScript.Echo  
Next  
  
```  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)  
  
 `HttpCompressionSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)   
 [DynamicTypeSettings Class](../wmi-provider/dynamictypesettings-class.md)   
 [HttpCompressionMimeTypeElement Class](../wmi-provider/httpcompressionmimetypeelement-class.md)   
 [HttpCompressionSchemeElement Class](../wmi-provider/httpcompressionschemeelement-class.md)   
 [StaticTypeSettings Class](../wmi-provider/statictypesettings-class.md)