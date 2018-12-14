---
title: "RequestLimitsElement Class | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: ad0f126f-9538-318d-dee0-c77a72fba0c5
caps.latest.revision: 24
author: "shirhatti"
manager: "wpickett"
---
# RequestLimitsElement Class
Specifies size limits on incoming HTTP requests.  
  
## Syntax  
  
```vbs  
class RequestLimitsElement : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `RequestLimitsElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`HeaderLimits`|A [HeaderLimitsSettings](../wmi-provider/headerlimitssettings-class.md) value that specifies HTTP header sizes.|  
|`MaxAllowedContentLength`|A read/write `uint32` value that specifies the maximum length, in bytes, of content in a request. The default is 30000000 (approximately 30 megabytes.)|  
|`MaxQueryString`|A read/write `uint32` value that specifies the maximum length, in bytes, of the query string. The default is 2048.|  
|`MaxUrl`|A read/write `uint32` value that specifies the maximum length, in bytes, of the request URL. The default is 260.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `RequestLimits` array property of the [RequestFilteringSection](../wmi-provider/requestfilteringsection-class.md) class.  
  
 This class integrates into [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)] the `RequestLimits` settings of the URLScan tool used by previous versions of IIS.  
  
> [!NOTE]
>  You must install the Request Filtering Module (Modrqflt.dll) for the settings in this class to take effect.  
  
## Example  
 The following example displays all the properties of the `RequestLimitsElement` class.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set objWMIService = GetObject("winmgmts:root\WebAdministration")  
  
' Get the RequestFilteringSection.  
Set oRequestFilteringSection = objWMIService.Get( _  
"RequestFilteringSection.Path='MACHINE/WEBROOT/APPHOST',Location=''")  
  
' Set a variable to the RequestFilteringSection.RequestLimits property,  
' which contains an array of RequestLimitsElement objects.  
Set oRequestLimitsElement = oRequestFilteringSection.RequestLimits  
  
' Display the path and list the non-array RequestLimitsElement properties.  
WScript.Echo "[Request Limits]"  
WScript.Echo "Path: " & oRequestFilteringSection.Path   
WScript.Echo "maxAllowedContentLength: " & _  
    oRequestLimitsElement.maxAllowedContentLength  
WScript.Echo "maxUrl: " & oRequestLimitsElement.maxUrl  
WScript.Echo "maxQueryString: " & oRequestLimitsElement.maxQueryString  
WScript.Echo   
  
' List the contents of the RequestLimitsElement.HeaderLimits.HeaderLimits  
' property, which contains an array of HeaderLimitsElement instances.  
WScript.Echo vbtab & "[Header Limits]"  
For Each oHeaderLimit In oRequestLimitsElement.HeaderLimits.HeaderLimits  
    WScript.Echo vbtab & "Header: " & oHeaderLimit.Header  
    WScript.Echo vbtab & "Header size limit: " & oHeaderLimit.sizeLimit  
    WScript.Echo   
Next  
```  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class1.md)  
  
 `RequestLimitsElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class1.md)   
 [FileExtensionsSettings Class](../wmi-provider/fileextensionssettings-class.md)   
 [HeaderLimitsElement Class](../wmi-provider/headerlimitselement-class.md)   
 [HeaderLimitsSettings Class](../wmi-provider/headerlimitssettings-class.md)   
 [RequestFilteringSection Class](../wmi-provider/requestfilteringsection-class.md)   
 [\<requestLimits>](http://msdn.microsoft.com/library/2464898f-f4aa-4955-919e-ed7492ad2b78)   
 [VerbsSettings Class](../wmi-provider/verbssettings-class.md)