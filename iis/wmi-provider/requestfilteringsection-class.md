---
title: "RequestFilteringSection Class | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 73911071-57c6-2fc8-5e52-9f5cfd4595a8
caps.latest.revision: 38
author: "shirhatti"
manager: "wpickett"
---
# RequestFilteringSection Class
Configures the scanning of incoming URL requests.  
  
## Syntax  
  
```vbs  
class RequestFilteringSection : ConfigurationSectionWithCollection  
```  
  
## Methods  
 The following table lists the methods exposed by the `RequestFilteringSection` class.  
  
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
 The following table lists the properties exposed by the `RequestFilteringSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`AllowDoubleEscaping`|A read/write `boolean` value. `true` if double escape characters are permitted in URLs; otherwise, `false`. The default is `false`.|  
|`AllowHighBitCharacters`|A read/write `boolean` value. `true` if non-ASCII characters are permitted in URLs; otherwise, `false`. The default is `true`.|  
|`DenyUrlSequences`|A [UrlSequenceSettings](../wmi-provider/urlsequencesettings-class.md) value that contains URL sequences that can be used to attack a Web server and, therefore, will be denied.|  
|`FileExtensions`|A read/write [FileExtensionsSettings](../wmi-provider/fileextensionssettings-class.md) value that specifies file extensions that can be allowed or denied in a request.|  
|`HiddenSegments`|A [HiddenSegmentSettings](../wmi-provider/hiddensegmentsettings-class.md) value that specifies segments whose content will not be served to the client. **Note:**  A segment is the part of a URL between two slashes or the part of the URL following the last slash. For example, the URL /segment1/segment2/segment3.asp has three segments: segment1, segment2, and segment3.asp. **Note:**  The following segments are blocked by default: bin, App_code, App_GlobalResources, App_LocalResources, App_WebReferences, App_Data, and App_Browsers.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`RequestLimits`|A [RequestLimitsElement](../wmi-provider/requestlimitselement-class.md) value that specifies size limits on incoming HTTP requests.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
|`Verbs`|A read/write [VerbsSettings](../wmi-provider/verbssettings-class.md) value that specifies HTTP verbs to allow or deny. **Note:**  Wildcards for HTTP verbs are not supported.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 This class integrates into [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)] the functionality of the URLScan tool used by previous versions of IIS.  
  
> [!NOTE]
>  For the functionality in the `RequestFilteringSection` class to work, the Request Filtering Module (Modrqflt.dll) must be installed.  
  
## Example  
 The following example shows all of the properties for the request-filtering section in the ApplicationHost.config file.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set objWMIService = GetObject("winmgmts:root\WebAdministration")  
  
' Get the request-filtering section.  
Set oRequestFilteringSection = objWMIService.Get( _  
"RequestFilteringSection.Path='MACHINE/WEBROOT/APPHOST',Location=''")  
  
' Show the path.  
WScript.Echo "[Request Filtering Path]"  
WScript.Echo oRequestFilteringSection.Path_  
WScript.Echo   
  
' Show the AllowDoubleEscaping property as "True" or "False."  
WScript.Echo "[AllowDoubleEscaping]"  
WScript.Echo CStr(oRequestFilteringSection.AllowDoubleEscaping)  
WScript.Echo   
  
' Show the AllowHighBitCharacters property as "True" or "False."  
WScript.Echo "[AllowHighBitCharacters]"  
WScript.Echo CStr(oRequestFilteringSection.AllowHighBitCharacters)  
WScript.Echo   
  
' List the denied URL sequences.  
WScript.Echo "[Denied Url Sequences]"  
For Each oSequence In _  
    oRequestFilteringSection.DenyUrlSequences.DenyUrlSequences  
    WScript.Echo oSequence.Sequence  
Next  
WScript.Echo   
  
' List the file extensions settings.  
WScript.Echo "[File Extensions]"  
  
' Show the AllowUnlisted property as "True" or "False."  
WScript.Echo "Allow unlisted file extensions: " & _  
    oRequestFilteringSection.FileExtensions.AllowUnlisted  
WScript.Echo  
  
' List each file extension and show whether it is allowed.  
For Each oFileExtension In _  
    oRequestFilteringSection.FileExtensions.FileExtensions  
    WScript.Echo "File extension: " & oFileExtension.FileExtension  
    WScript.Echo "File extension allowed: " & oFileExtension.Allowed  
    WScript.Echo  
Next  
WScript.Echo   
  
' List the hidden segments.  
WScript.Echo "[Hidden Segments]"  
For Each oHiddenSegment In _  
    oRequestFilteringSection.HiddenSegments.HiddenSegments  
    WScript.Echo oHiddenSegment.Segment  
Next  
WScript.Echo   
  
' Show the request limits settings.  
WScript.Echo "[Request Limits]"  
WScript.Echo "maxAllowedContentLength: " & _  
oRequestFilteringSection.RequestLimits.maxAllowedContentLength  
WScript.Echo "maxUrl: " & oRequestFilteringSection.RequestLimits.maxUrl  
WScript.Echo "maxQueryString: " & oRequestFilteringSection.RequestLimits.maxQueryString  
WScript.Echo   
  
' Show the header limits settings.  
WScript.Echo vbtab & "[Header Limits]"  
For Each oHeaderLimit In _  
    oRequestFilteringSection.RequestLimits.HeaderLimits.HeaderLimits  
    WScript.Echo vbtab & "Header: " & oHeaderLimit.Header  
    WScript.Echo vbtab & "Header size limit: " & oHeaderLimit.SizeLimit  
    WScript.Echo   
Next  
  
' List the verbs settings.  
WScript.Echo "[Verbs]"  
WScript.Echo "Allow unlisted verbs: " & oRequestFilteringSection.Verbs.AllowUnlisted  
WScript.Echo   
  
' List each verb and show whether it is allowed.  
For Each oVerb In oRequestFilteringSection.Verbs.Verbs  
    WScript.Echo "Verb: " & oVerb.Verb  
    WScript.Echo "Verb allowed: " & oVerb.Allowed  
    WScript.Echo  
Next  
  
```  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)  
  
 `RequestFilteringSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)   
 [FileExtensionElement Class](../wmi-provider/fileextensionelement-class.md)   
 [FileExtensionsSettings Class](../wmi-provider/fileextensionssettings-class.md)   
 [HeaderLimitsSettings Class](../wmi-provider/headerlimitssettings-class.md)   
 [HiddenSegmentSettings Class](../wmi-provider/hiddensegmentsettings-class.md)   
 [\<requestFiltering>](http://msdn.microsoft.com/library/23af9c9d-50d3-4db8-918c-6214259aa59c)   
 [RequestLimitsElement Class](../wmi-provider/requestlimitselement-class.md)   
 [UrlSequence Class](../wmi-provider/urlsequence-class.md)   
 [UrlSequenceSettings Class](../wmi-provider/urlsequencesettings-class.md)   
 [VerbElement Class](../wmi-provider/verbelement-class.md)   
 [VerbsSettings Class](../wmi-provider/verbssettings-class.md)