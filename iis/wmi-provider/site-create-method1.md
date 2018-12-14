---
title: "Site.Create Method1 | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 134a8645-84b9-7c17-4cdc-be817cc88bfe
caps.latest.revision: 23
author: "shirhatti"
manager: "wpickett"
---
# Site.Create Method1
Creates a new Web site.  
  
## Syntax  
  
```vbs  
objAppSrv.Get("Site").Create(  
   SiteName,  
   Bindings[],  
   PhysicalPath,  
   ServerAutoStart  
)  
```  
  
```jscript#  
var newsite = appsrv.Get("Site").Create(  
   SiteName,  
   Bindings[],  
   PhysicalPath,  
   ServerAutoStart  
);  
```  
  
#### Parameters  
  
|Name|Description|  
|----------|-----------------|  
|`Name`|A string that contains the name for the new Web site.|  
|`Bindings`|An array of [BindingElement](../wmi-provider/bindingelement-class1.md) objects. The binding should include at least one host name, port, or IP address.|  
|`PhysicalPath`|A string that contains a fully qualified path of a physical directory to which you want the Web site mapped.|  
|`ServerAutoStart`|An optional `boolean` value. `true` if the server instance should start automatically when the World Wide Web Publishing Service (WWW service) is started; otherwise, `false`.|  
  
## Return Value  
 This method does not return a value.  
  
## Remarks  
 This method replaces the IIS 6.0 `IIsWebService.CreateWebSite` method.  
  
> [!NOTE]
>  You cannot use `Site.SpawnInstance_` and `Site.Put_` to create a new Web site. A new site must have a root application and a root virtual directory, and these can be specified only through the `Create` method.  
  
## Example  
 The following example creates a new Web site.  
  
> [!NOTE]
>  Because `Create` is a `static` method, you must call it by using the `Site` definition.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Specify a name and physical path for the new Web site.  
SiteName = "SampleSite"  
PhysicalPath = "C:\inetpub\wwwroot"  
  
' Create a Bindings object by using the WMI SpawnInstance_ method.  
Set SiteBinding = oWebAdmin.Get("BindingElement").SpawnInstance_  
SiteBinding.BindingInformation = "*:80:www.SampleSite.com"  
SiteBinding.Protocol = "http"  
BindingsArray = array(SiteBinding)  
  
' Get the site object definition  
Set SiteDefinition = oWebAdmin.Get("Site")  
  
' Pass the required parameters to the Create method on the Site  
' definition to create the site.  
SiteDefinition.Create SiteName, BindingsArray, PhysicalPath  
```  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [BindingElement Class](../wmi-provider/bindingelement-class1.md)   
 [Site Class](../wmi-provider/site-class1.md)