---
title: "HttpHandlersSection Class"
ms.date: "10/07/2016"
ms.assetid: 6172d775-56fd-b3a6-ef47-803f372aeebd
---
# HttpHandlersSection Class
Configures settings for [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] handlers.  
  
## Syntax  
  
```vbs  
class HttpHandlersSection : ConfigurationSectionWithCollection  
```  
  
## Methods  
 The following table lists the methods exposed by the `HttpHandlersSection` class.  
  
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
 The following table lists the properties exposed by the `HttpHandlersSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`HttpHandlers`|An array of [HttpHandlerAction](../wmi-provider/httphandleraction-class.md) values that contain [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] handlers.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 The HTTP handlers contained in the `HttpHandlersSection` class are specific to [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] and are in the `<system.web>` section of the Web.config file. Each of these handlers is represented by an instance of the `HttpHandlerAction` class.  
  
 The HTTP handlers in the [HandlersSection](../wmi-provider/handlerssection-class.md) class are related to [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)] and are in the `<system.webServer>` section of the ApplicationHost.config file. Each of these handlers is represented by an instance of the [HandlerAction](../wmi-provider/handleraction-class.md) class.  
  
## Example  
 The following example displays `HttpHandlersSection` properties, including the `HttpHandlerAction` values that are in the `HttpHandlers` property.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the HttpHandlersSection.  
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
oSite.GetSection "HttpHandlersSection", oSection  
  
' Display the Path and Location properties.  
WScript.Echo "Path: " & oSection.Path  
WScript.Echo "Location: " & oSection.Location  
WScript.Echo   
  
' Display the HttpHandlerAction instances that are contained  
' in the HttpHandlers property.  
WScript.Echo "----------( Http Handlers )----------"  
Counter = 0  
For Each oHttpHandler In oSection.HttpHandlers  
     Counter = Counter + 1  
     WScript.Echo "[" & Counter & "] Path: " & oHttpHandler.Path  
     WScript.Echo "Type: " & oHttpHandler.Type  
     WScript.Echo "Validate: " & oHttpHandler.Validate  
     WScript.Echo "Verb: " & oHttpHandler.Verb  
     WScript.Echo  
Next  
  
```  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)  
  
 `HttpHandlersSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)   
 [HandlerAction Class](../wmi-provider/handleraction-class.md)   
 [HandlersSection Class](../wmi-provider/handlerssection-class.md)   
 [HttpHandlerAction Class](../wmi-provider/httphandleraction-class.md)