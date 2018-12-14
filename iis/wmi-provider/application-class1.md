---
title: "Application Class1 | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 8f5f708c-9ca7-48eb-8474-25eebe5c97c9
caps.latest.revision: 36
author: "shirhatti"
manager: "wpickett"
---
# Application Class1
Represents an IIS Web application.  
  
## Syntax  
  
```vbs  
class Application : ConfiguredObject  
```  
  
## Methods  
 The following table lists the methods exposed by the `Application` class.  
  
|Name|Description|  
|----------|-----------------|  
|[Create](../wmi-provider/application-create-method1.md)|Creates a Web application.|  
|[GetSection](../wmi-provider/configuredobject-getsection-method.md)|(Inherited from [ConfiguredObject](../wmi-provider/configuredobject-class1.md).)|  
|[GetAllSections](../wmi-provider/configuredobject-getallsections-method1.md)|(Inherited from [ConfiguredObject](../wmi-provider/configuredobject-class1.md).)|  
|[RevertToParent](../wmi-provider/application-reverttoparent-method1.md)|Reverts an application's configuration value or values to the default.|  
  
## Properties  
 The following table lists the properties exposed by the `Application` class.  
  
|Name|Description|  
|----------|-----------------|  
|`ApplicationPool`|A read/write `string` value that specifies a case-sensitive name for the application pool for an application. The default is "DefaultAppPool".|  
|`EnabledProtocols`|A read/write `string` array that specifies the protocols that requests can use to access an application. A value of either "HTTP" or "HTTPS" enables both HTTP and HTTPS. If neither "HTTP" nor "HTTPS" is specified, neither is enabled for the application. The default is "HTTP". To accept only HTTPS requests, configure the Secure Sockets Layer (SSL) feature for the site.|  
|`Path`|A read-only `string` value that specifies the virtual path of the application after the host header. For example, if you have an application at http://www.alpineskihouse.com/Skis/Downhill, the `Path` property is /Skis/Downhill. A key property.|  
|`SiteName`|A read-only `string` value that specifies the unique name of the Web site. A key property.|  
|`VirtualDirectoryDefaults`|A [VirtualDirectoryElementDefaults](../wmi-provider/virtualdirectoryelementdefaults-class1.md) object whose read/write properties specify default values for virtual directories under the application.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 A Web application is a grouping of content at the root level of a Web site or a grouping of content in a separate folder below the Web site's root directory. The `Application` class enables you to specify properties specific to a particular application, such as the application pool that the application will run in.  
  
## Example  
 The following example assigns the `Northwind` application to an application pool named `NewAppPool`.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Retrieve the application and display its Web site name and path.  
Set oApp = oWebAdmin.Get(_   
"Application.SiteName='Default Web Site',Path='/Northwind'")  
WScript.Echo "Web site and path: '" & oApp.SiteName & oApp.Path & "'"  
WScript.Echo "Old application pool: " & oApp. ApplicationPool  
  
' Specify a new application pool name and save it.  
' Note that the name is case-sensitive.  
oApp.ApplicationPool = "NewAppPool"  
oApp.Put_  
  
' Display the new application pool name.  
WScript.Echo "New application pool: " & oApp.ApplicationPool  
```  
  
> [!NOTE]
>  The name of the application pool is case-sensitive.  
  
 IIS does not verify whether the specified application pool actually exists. If the application pool does not exist, the user receives an HTTP error 403.18 with the message "The specified request cannot be executed in the application pool that is configured for this resource on the Web server."  
  
 To set the default application pool for all the applications in a Web site, use the `ApplicationDefaults` property of the [Site](../wmi-provider/site-class1.md) class.  
  
## Inheritance Hierarchy  
 [ConfiguredObject](../wmi-provider/configuredobject-class1.md)  
  
 `Application`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ApplicationElementDefaults Class](../wmi-provider/applicationelementdefaults-class2.md)   
 [ConfiguredObject Class](../wmi-provider/configuredobject-class1.md)   
 [Site Class](../wmi-provider/site-class1.md)   
 [VirtualDirectoryElementDefaults Class](../wmi-provider/virtualdirectoryelementdefaults-class1.md)