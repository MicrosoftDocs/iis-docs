---
title: DeviceElement Class
description: Describes the DeviceElement class and provides the class' syntax, properties, remarks, inheritance hierarchy, and requirements.
ms.date: 10/07/2016
ms.assetid: 4459d7ff-8387-7249-83b1-238540a6c636
---
# DeviceElement Class
Defines an adapter set that maps [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] mobile controls to corresponding adapters within the `<system.web>` and `<mobileControls>` sections of the Web.config configuration file.  
  
## Syntax  
  
```vbs  
class DeviceElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `DeviceElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Device`|An array of read/write [AdapterElement](../wmi-provider/adapterelement-class.md) values, each of which maps an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] mobile control to a specific device adapter.|  
|`InheritsFrom`|An optional read/write `string` value that specifies the device adapter set from which this set must inherit. The specified device adapter set can appear either earlier in the same `<mobileControls>` section or in the `<mobileControls>` section of a higher-level configuration file.|  
|`Name`|A required read-only `string` value that specifies the unique name by which you must identify the device adapter set. The key property.|  
|`PageAdapter`|An optional read/write `string` value that specifies the class type of the page adapter for the adapter set. The specified class must implement the `IPageAdapter` interface. The name must follow the [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)] standards for specifying a fully qualified type name.<br /><br /> [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] searches the specified assembly for the type. If the adapter set inherits from another adapter set, the `PageAdapter` property is not necessary and its default value will be set to the value of the parent set.|  
|`PredicateClass`|An optional read/write `string` value that specifies the class type that supplies the evaluator predicate. The name that you use for the class type must follow the [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)] standards for specifying a fully qualified type name.<br /><br /> [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] searches the specified assembly for the type. If the adapter set inherits from another type, the `PredicateClass` property is not necessary and its default value will be set to the value of the parent set.|  
|`PredicateMethod`|An optional read/write `string` value that specifies the method that supplies the evaluator predicate. The method must be static and of the following signature:<br /><br /> `static bool EvaluatorMethod(HttpContext context)`<br /><br /> If the adapter set inherits from another adapter set, the `PredicateMethod` property is not necessary and its default value will be set to the value of the parent set.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `MobileControls` property of the [MobileControlsSection](../wmi-provider/mobilecontrolssection-class.md) class.  
  
 If an instance of this class specifies the `InheritsFrom` property, you do not need to specify the `PredicateClass`, `PredicateMethod`, or `PageAdapter` properties. Instead, your device adapter set can inherit these from the parent device-adapter set definition.  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `DeviceElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ASP.NET Mobile Web Applications Adapter Mappings](/previous-versions/aspnet/w5b9y36y(v=vs.100))   
 [device Element for mobileControls (ASP.NET Settings Schema)](/previous-versions/iis/dev/ms690331(v=vs.90))   
 [AdapterElement Class](../wmi-provider/adapterelement-class.md)   
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [MobileControlsSection Class](../wmi-provider/mobilecontrolssection-class.md)   
 [System.Web.UI.MobileControls.IPageAdapter Interface](/dotnet/api/system.web.ui.mobilecontrols.ipageadapter)   
 [system.web Element (ASP.NET Settings Schema)](/dotnet/framework/configure-apps/file-schema/web/system-web-element-web-settings)
