---
title: "StaticContentSection Class"
description: "The StaticContentSection Class exposes configuration settings for static content on a Web site. This article details its syntax, methods, properties, remarks, a code example, and inheritance hierarchy."
ms.date: "10/07/2016"
ms.assetid: 0f53f631-c9e7-5eb6-5bc0-8516079ac610
---
# StaticContentSection Class
Exposes configuration settings for static content on a Web site.  
  
## Syntax  
  
```vbs  
class StaticContentSection : ConfigurationSectionWithCollection  
```  
  
## Methods  
 The following table lists the methods exposed by the `StaticContentSection` class.  
  
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
 The following table lists the properties exposed by the `StaticContentSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`ClientCache`|A read/write [HttpClientCache](../wmi-provider/httpclientcache-class.md) value that exposes the client caching configuration.|  
|`DefaultDocFooter`|A read/write `string` value that contains either the default footer text for every Web page on a site, or the path to a file that contains the default footer text. How this property is read depends on the setting of the `IsDocFooterFileName` property. The default is `null`.|  
|`EnableDocFooter`|A read/write `boolean` value. `true` if the text indicated by `DefaultDocFooter` will appear on every static page on a Web site; otherwise, `false`. The default is `false`.|  
|`IsDocFooterFileName`|A read/write `boolean` value. `true` if the string in `DefaultDocFooter` contains a path to a file that contains the default footer text for every static Web page on a site; otherwise, `false`. The default is `false`.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
|`StaticContent`|An array of read/write [MimeMapElement](../wmi-provider/mimemapelement-class.md) objects that contain the MIME maps for static content.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 The properties in this class correspond to the attributes and elements in the `<staticContent>` section of the ApplicationHost.config file.  
  
## Example  
 The following example shows the footer-text and client-cache properties of the `StaticContentSection` class.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the static content section.  
Set oSection = oWebAdmin.Get("StaticContentSection.Path=" & _  
    "'MACHINE/WEBROOT/APPHOST',Location=''")  
' Show the path and location.  
WScript.Echo "Path: " & oSection.Path  
WScript.Echo "Location: " & oSection.Location  
WScript.Echo  
  
'Show the doc-footer-related properties.  
WScript.Echo "Doc Footer properties"  
WScript.Echo "---------------------"  
WScript.Echo "EnableDocFooter: " & oSection.EnableDocFooter  
WScript.Echo "IsDocFooterFileName: " & oSection.IsDocFooterFileName  
WScript.Echo "DefaultDocFooter: " & oSection.DefaultDocFooter  
WScript.Echo  
  
' Show the embedded client-cache properties.  
Set oClientCache = oSection.ClientCache  
WScript.Echo "ClientCache properties"  
WScript.Echo "----------------------"  
WScript.Echo "CacheControlCustom: " & _  
    oClientCache.CacheControlCustom  
WScript.Echo "CacheControlMaxAge: " & _  
    oClientCache.CacheControlMaxAge  
WScript.Echo "CacheControlMode: " & _  
    oClientCache.CacheControlMode  
WScript.Echo "HttpExpires: " & _  
    oClientCache.HttpExpires  
  
```  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)  
  
 `StaticContentSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)   
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)   
 [HttpClientCache Class](../wmi-provider/httpclientcache-class.md)   
 [MimeMapElement Class](../wmi-provider/mimemapelement-class.md)
