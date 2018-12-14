---
title: "HttpErrorsSection Class | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 70c759aa-ac2e-4dde-89e3-60f1a1a2d2bb
caps.latest.revision: 31
author: "shirhatti"
manager: "wpickett"
---
# HttpErrorsSection Class
Configures HTTP error handling for a Web server.  
  
## Syntax  
  
```vbs  
class HttpErrorsSection : ConfigurationSectionWithCollection  
```  
  
## Methods  
 The following table lists the methods exposed by the `HttpErrorsSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[Add](../wmi-provider/configurationsectionwithcollection-add-method.md)|(Inherited from [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md).)|  
|[Clear](../wmi-provider/configurationsectionwithcollection-clear-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[Get](../wmi-provider/configurationsectionwithcollection-get-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class1.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[Remove](../wmi-provider/configurationsectionwithcollection-remove-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `HttpErrorsSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`DefaultPath`|An optional `string` value that contains the default path of an HTTP error file or URL. When nonempty, this value is inherited by the `Path` property of newly created [HttpErrorElement](../wmi-provider/httperrorelement-class.md) objects.|  
|`DefaultResponseMode`|An optional `sint32` value that configures the default response to HTTP errors. When nonempty, this value is inherited by the `ResponseMode` property of newly created `HttpErrorElement` objects. The possible values are listed later in the Remarks section.|  
|`DetailedMoreInformationLink`|An optional read/write `string` value that specifies the URL for a link, shown at the bottom of the page, to a page with more detailed information about the error that was raised. The `status`, `substatus`, `hresult`, and `messageid` of the error are sent as part of the query string. You can use this property to point end users to a custom location for error information. The default is "http://go.microsoft.com/fwlink/?LinkID=62293".|  
|`ErrorMode`|A read/write `sint32` enumeration that specifies whether the detailed error functionality is enabled, disabled, or shown only to local clients. The possible values are listed later in the Remarks section.|  
|`ExistingResponse`|A read/write `sint32` enumeration that specifies how IIS handles existing custom errors. The possible values are listed later in the Remarks section.|  
|`HttpErrors`|An array of `HttpErrorElement` values that configure handling for specific HTTP errors.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 This class exposes the settings in the `<httpErrors>` section of a configuration file.  
  
 The custom errors represented by the `HttpErrorsSection` class are related to [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)] and are in the <xref:System.WebServer.Configuration?displayProperty=fullName> namespace. Each of these errors is represented by an instance of the [HttpErrorElement](../wmi-provider/httperrorelement-class.md) class.  
  
 The custom errors represented by the [CustomErrorsSection](../wmi-provider/customerrorssection-class.md) class are specific to [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] and are in the <xref:System.Web?displayProperty=fullName> namespace. Each of these errors is represented by an instance of the [CustomError](../wmi-provider/customerror-class.md) class.  
  
 The following table lists the possible values for the `DefaultResponseMode` property. The default is 0 (`File`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`File`|The Web server returns the Web page from the static file specified in the `Path` property of the `HttpErrorElement` class. **Note:**  Custom errors are language-specific and typically return the custom error in the language of the client. This requires that the client's language pack is installed. The file path is constructed as follows: *PrefixLanguageFilePath*\\*ClientLanguageID*\\*ErrorCodeFile* For example, if *PrefixLanguageFilePath* is "d:\inetpub\custerr", the client browser sends "en-us" in the `Accept-Language` header, and the error code is 404, the resulting path when the en-US language pack is installed is d:\inetpub\custerr\en-us\404.htm. If ja-JP is the system language, and the en-US language pack is not installed, the resulting path is d:\inetpub\custerr\ja-jp\404.htm.|  
|1|`ExecuteURL`|The Web server returns the internal ASP page specified in the `Path` property of the `HttpErrorElement` class. The URL should be in the scope of the same application pool. **Note:**  In [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)], the redirection creates a URL with the following format (the items in the brackets are optional): /*\<CustomErrorPage>*[?*\<QueryString>*]&resourcePath=*\<OriginalURL>*[?*\<OriginalQueryString>*]&statusCode=*\<StatusCode>*|  
|2|`Redirect`|The Web server provides an `HTTP 302 Found` response and includes the URL specified in the `Path` property of the `HttpErrorElement` class in the `Location` field of the response. If the response is a `GET` method instead of a `HEAD` method, it should also include an entity that has a short hyperlink to the new URL. **Note:**  In [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)], the redirection creates a URL with the following format (the items in the brackets are optional): /*\<CustomErrorPage>*[?*\<QueryString>*]&resourcePath=*\<OriginalURL>*[?*\<OriginalQueryString>*]&statusCode=*\<StatusCode>*|  
  
 The following table lists the possible values for the `ErrorMode` property. The default is 0 (`DetailedLocalOnly`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`DetailedLocalOnly`|A detailed error response is generated only if the request comes from the local computer. If the request comes from an external address, the server generates a custom error response. **Note:**  The value of the `ExistingResponse` property determines whether a detailed or custom error is generated.|  
|1|`Custom`|The error that the module or server generates is replaced by a custom page that you specify. This mode is useful in providing friendlier error messages to end users. **Note:**  This setting turns off detailed errors, even for local requests.|  
|2|`Detailed`|A page with detailed information about the application error is displayed, and custom errors are not shown. This mode is useful for testing and debugging Web sites and applications. **Note:**  It is a security risk to set `ErrorMode` to `Detailed`, because even remote clients will receive detailed error information that could lead to unwanted information disclosure.|  
  
 The following table lists the possible values for the `ExistingResponse` property. The default is 0 (`Auto`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`Auto`|The response depends on the first successful match of the following set of ordered conditions:<br /><br /> 1.  If the [IHttpResponse::SetStatus](../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-setstatus-method.md) method was called by using the `fTrySkipCustomErrors` flag, the existing response is passed through, and no detailed or custom error is shown.<br />2.  If the `ErrorMode` property is set to `Custom`, the response is replaced.<br />3.  If `ErrorMode` is set to `Detailed` and there is an existing response, the response is passed through.<br />4.  If `ErrorMode` is set to `Detailed` and there is no existing response, the response is replaced with a detailed error.|  
|1|`Replace`|The existing response is always replaced, regardless of how `SetStatus` was called.|  
|2|`PassThrough`|The existing response is always used.|  
  
## Example  
 The following code example specifies new values for the `DefaultPath`, `ErrorMode`, and `DetailedMoreInformationLink` properties. A helper function displays the configuration section values before and after the change.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the HTTP errors section.  
Set oSection = oWebAdmin.Get( _  
    "HttpErrorsSection.Path='" & _  
    "MACHINE/WEBROOT/APPHOST/',Location=''")  
  
' Display the class name of the section.  
WScript.Echo "[ " & oSection.Path_.Class & " ]"  
  
' Display the initial values.  
Call DisplayValues("Initial Values", oSection)   
  
' Specify the path of a default error page.  
oSection.DefaultPath = _  
    "D:\inetpub\custerr\en-US\contoso\DefaultErrorPage.htm"  
  
' Specify a detailed more information link.  
oSection.DetailedMoreInformationLink = "http://www.contoso.com/MoreInfo.htm"  
  
'Set the ErrorMode property to Custom.  
oSection.ErrorMode = 1  
  
' Save the values to configuration.  
oSection.Put_  
  
' Refresh the oSection object variable with the new values.  
oSection.Refresh_  
  
' Display the changed values.  
Call DisplayValues("New Values", oSection)  
  
' ==== DisplayValues helper function. ====  
Function DisplayValues(HeadingText, oSection)  
  
    ' Display a heading.  
    WScript.Echo  
    WScript.Echo HeadingText  
    WScript.Echo String(Len(HeadingText), "-")  
  
    ' Display the non-embedded section properties.  
    For Each prop In oSection.Properties_  
  
        If Left( _  
            Prop.Qualifiers_("CIMTYPE"), 6) _  
            <> "object" then  
            WScript.Echo prop.Name & ": " & prop.Value  
        End If  
  
    Next   
End Function  
  
```  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class1.md)  
  
 [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)  
  
 `HttpErrorsSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSection Class](../wmi-provider/configurationsection-class1.md)   
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)   
 [CustomError Class](../wmi-provider/customerror-class.md)   
 [CustomErrorsSection Class](../wmi-provider/customerrorssection-class.md)   
 [HttpErrorElement Class](../wmi-provider/httperrorelement-class.md)   
 [IHttpResponse::SetStatus Method](../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-setstatus-method.md)