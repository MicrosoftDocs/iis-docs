---
title: "HttpRedirectSection Class"
ms.date: "10/07/2016"
ms.assetid: 437c5154-8165-1852-d8f5-aeb7f68fdc05
---
# HttpRedirectSection Class
Configures HTTP redirection.  
  
## Syntax  
  
```vbs  
class HttpRedirectSection : ConfigurationSectionWithCollection  
```  
  
## Methods  
 The following table lists the methods exposed by the `HttpRedirectSection` class.  
  
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
 The following table lists the properties exposed by the `HttpRedirectSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`ChildOnly`|A read/write `boolean` value. `true` if the redirection destination is in a subdirectory of the original URL; otherwise, `false`. The default is `false`. This setting alerts IIS that the redirection should occur only once and prevents endless loops in the substitution engine.|  
|`Destination`|A required, nonempty read/write `string` value that contains the file name, directory path, or URL to which the user is redirected. The string can include redirect variables to pass portions of the original URL with the destination URL. You can use more than one variable in the string.|  
|`Enabled`|A read/write `boolean` value. `true` if HTTP redirection is enabled; otherwise, `false`. The default is `false`.|  
|`ExactDestination`|A read/write `boolean` value. `true` if the URL should be considered an absolute location; otherwise, `false`. A setting of `true` prevents the substitution engine from appending the original requested resource to the redirection URL.|  
|`HttpRedirect`|An array of [WildcardRedirectElement](../wmi-provider/wildcardredirectelement-class.md) values that, by using matching criteria, redirect file name, directory path, or URL requests to specified destinations.|  
|`HttpResponseStatus`|A read/write `sint32` enumeration that contains the HTTP response status. The possible values are listed later in the Remarks section.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 The following table lists the possible values for the `HttpResponseStatus` property. The default is 302 (`Found`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|301|`Permanent`|IIS tells the Web client that the location for the requested resource has permanently changed. The new location is specified in the `Location` HTTP header. This setting allows Web clients that keep record of HTTP URL links to update the stored URL with the new location.|  
|302|`Found`|IIS tells the Web client to issue a new request to the location specified in the `Location` HTTP header.|  
|307|`Temporary`|IIS tells the Web browser to reissue a POST request with original data to a new location. Normally, when a Web browser issues a POST request and receives a 302 redirect message from the Web server, the browser issues a GET request for the new location. This causes the data in the original POST request to be lost. If the browser receives a 307 redirect, it can reissue the POST with the original data intact.|  
  
## Example  
 The first example displays all of the properties of the `HttpRedirectSection` class, including the embedded `SectionInformation` and `HttpRedirect` properties.  
  
 The second example creates four wildcard redirect elements and attempts to add them to the default Web site's `<httpRedirect>` section. If duplicate entries exist, the code reports so; otherwise, it adds the new entries. Finally, it displays the new count of all entries and the wildcard and destination for each.  
  
```  
' 1) First example: Display the httpRedirect properties  
' for the default Web site.  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = _  
    GetObject("winmgmts:root\WebAdministration")  
  
' Get the httpRedirect section for the default Web site.  
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
oSite.GetSection "HttpRedirectSection", oSection  
  
' Display the nonembedded properties.  
WScript.Echo "=============================="  
WScript.Echo "HttpRedirectSection Properties"  
WScript.Echo "=============================="  
For Each vProp In oSection.Properties_  
    If (vProp.Name <> "HttpRedirect") And _  
    (vProp.Name <> "SectionInformation") Then  
        WScript.Echo vProp.Name & ": " & vProp.Value  
    End If  
Next  
  
' Display the contents of the SectionInformation property.  
WScript.Echo
WScript.Echo "--------------------------------------"  
WScript.Echo "HttpRedirectSection.SectionInformation"  
WScript.Echo "--------------------------------------"  
For Each vProp In oSection.SectionInformation.Properties_  
    WScript.Echo vProp.Name & ": " & vProp.Value  
Next  
WScript.Echo
  
' Display the WildcardRedirectElement instances in the  
' HttpRedirect array property.  
WScript.Echo "--------------------------------"  
WScript.Echo "HttpRedirectSection.HttpRedirect"  
WScript.Echo "--------------------------------"  
For Each oWildcardRedirectElement In oSection.HttpRedirect  
    For Each vProp In oWildcardRedirectElement.Properties_  
        WScript.Echo vProp.Name & ": " & vProp.Value  
    Next  
    WScript.Echo  
Next  
  
' 2) Second example: Add four WildcardRedirectElement  
' instances to the default Web site and display the result.  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = _  
    GetObject("winmgmts:root\WebAdministration")  
  
' Get the httpRedirect section for the default Web site.  
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
oSite.GetSection "HttpRedirectSection", oSection  
  
' Set up a loop to add four new redirects.  
For Counter = 1 To 4  
    ' Create a new instance of WildcardRedirectElement.  
    ' Note that you do not need to use SpawnInstance_.  
    Set oWildcardRedirect = _  
        oWebAdmin.Get("WildcardRedirectElement")  
  
    ' Specify the page to be redirected.  
    oWildcardRedirect.Wildcard = _  
        "Adatum.com/Page" & Counter & ".htm"  
  
    ' Specify the destination for the redirected page.  
    oWildcardRedirect.Destination = _  
        "Contoso.com/Page" & Counter & ".htm"  
  
    ' Prepare to catch duplicate entries.  
    On Error Resume Next  
  
    ' Attempt to add the wildcard entry to the collection.
    ' (You do not need to use Put_ to save the change.)  
    oSection.Add "HttpRedirect", oWildcardRedirect  
  
    ' Catch duplicate entries.  
    If Err.Number = -2147024713 Then  
        WScript.Echo "Redirect entry for """ & _  
        oWildcardRedirect.Wildcard & """ already exists."  
        WScript.Echo  
    End If  
Next  
  
' Update the contents of the oSection variable.  
oSection.Refresh_  
  
' Display a header and the new number of entries.  
WScript.Echo "--------------------------------"  
WScript.Echo "HttpRedirectSection.HttpRedirect"  
WScript.Echo "--------------------------------"  
WScript.Echo "The number of redirect entries is now " & _  
    UBound(oSection.HttpRedirect) + 1 & "."  
WScript.Echo
  
' Display the new set of wildcard redirect elements.  
For Each oWildcardRedirectElement In oSection.HttpRedirect  
    WScript.Echo "Wildcard: " & _  
        oWildcardRedirectElement.Wildcard & vbTab & _  
        "Destination: " & _  
        oWildcardRedirectElement.Destination  
    WScript.Echo  
Next  
  
```  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)  
  
 `HttpRedirectSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)
 [SectionInformation Class](../wmi-provider/sectioninformation-class.md)
 [WildcardRedirectElement Class](../wmi-provider/wildcardredirectelement-class.md)
