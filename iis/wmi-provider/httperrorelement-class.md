---
title: "HttpErrorElement Class"
description: Describes the HttpErrorElement class and provides the class' syntax, methods, properties, subclasses, remarks, requirements, and reference.
ms.date: "10/07/2016"
ms.assetid: 1a551d62-b9c9-0f51-921b-60bd965ffa19
---
# HttpErrorElement Class
Configures the response to a specific HTTP error.  
  
## Syntax  
  
```vbs  
class HttpErrorElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `HttpErrorElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Path`|A required read/write `string` value that contains the file name or URL that is served in response to the HTTP error specified by the `StatusCode` and `SubStatusCode` properties.|  
|`PrefixLanguageFilePath`|An optional read/write `string` value that specifies the physical path of a custom error page directory. The custom error page directory contains one or more language-specific subdirectories with custom error pages for the error specified in the `StatusCode` property.<br /><br /> The file path is constructed as follows: *PrefixLanguageFilePath*\\*ClientLanguageID*\\*CustomErrorPageFile*. For example, *PrefixLanguageFilePath* might be "*%SystemDrive%*\inetpub\custerr", *ClientLanguageID* might be "en-us" and *CustomErrorPageFile* (specified by the `Path` property) might be "401.htm". **Note:**  Custom errors are language-specific and typically return the custom error in the system language of the client. For an error page to be returned in a language different from the system language of the client, the language pack for that language must be installed on the client. For example, if *PrefixLanguageFilePath* is "d:\inetpub\custerr" and the client has the en-US language pack installed, the resulting path for error code 404 is d:\inetpub\custerr\en-us\404.htm when the client browser sends "en-us" in the `Accept-Language` header. However, if ja-JP is the system language, and the en-US language pack is not installed, the resulting path is d:\inetpub\custerr\ja-jp\404.htm.|  
|`ResponseMode`|A required read/write `sint32` value that specifies the response to the HTTP error specified by `StatusCode` and `SubStatusCode`. The possible values are listed later in the Remarks section.|  
|`StatusCode`|A required unique read/write `uint32` value that contains a status code from 400 through 999. A key property.|  
|`SubStatusCode`|A required unique read/write `sint32` value that contains a substatus code from –1 through 999. The default is –1. A key property.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `HttpErrors` array property of the [HttpErrorsSection](../wmi-provider/httperrorssection-class.md) class.  
  
 This class represents an `<error>` element in the `<httpErrors>` section of the ApplicationHost.config file.  
  
 The following table contains the possible values and keywords for the `ResponseMode` property. The default is 0 (`File`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`File`|The Web server returns the Web page specified in the `Path` property.|  
|1|`ExecuteURL`|The Web server returns the ASP page specified in `Path`.|  
|2|`Redirect`|The Web server redirects the request to the URL specified in `Path`.|  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `HttpErrorElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [HttpErrorsSection Class](../wmi-provider/httperrorssection-class.md)   
 [Configuring Custom Error Messages](https://go.microsoft.com/fwlink/?LinkId=61892)   
 [IIS Status Codes](https://go.microsoft.com/fwlink/?LinkId=61888)
