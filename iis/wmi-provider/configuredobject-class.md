---
title: "ConfiguredObject Class1"
ms.date: "10/07/2016"
ms.assetid: fbc82145-2355-3b59-ad74-3eb7b5f3f5ec
---
# ConfiguredObject Class1

Acts as a base type for namespace objects whose configuration can be specified in configuration sections.  
  
## Syntax  
  
```vbs  
class ConfiguredObject : Object  
```  
  
## Methods  

 The following table lists the methods exposed by the `ConfiguredObject` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllSections](../wmi-provider/configuredobject-getallsections-method.md)|Retrieves all configuration sections under a configured object.|  
|[GetSection](../wmi-provider/configuredobject-getsection-method.md)|Retrieves the contents of a configuration section for a configured object.|  
  
## Properties  

 This class contains no properties.  
  
## Subclasses  

 The following table lists the subclasses exposed by the `ConfiguredObject` class.  
  
|Name|Description|  
|----------|-----------------|  
|[Application](../wmi-provider/application-class.md)|Represents an IIS Web application.|  
|[Site](../wmi-provider/site-class.md)|Represents an IIS Web site.|  
|[VirtualDirectory](../wmi-provider/virtualdirectory-class.md)|Represents an IIS virtual directory.|  
  
## Inheritance Hierarchy  

 [Object](../wmi-provider/object-class.md)  
  
 `ConfiguredObject`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [Application Class](../wmi-provider/application-class.md)   
 [Object Class](../wmi-provider/object-class.md)   
 [Server Class](../wmi-provider/server-class.md)   
 [Site Class](../wmi-provider/site-class.md)   
 [VirtualDirectory Class](../wmi-provider/virtualdirectory-class.md)
