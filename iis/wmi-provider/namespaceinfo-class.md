---
title: "NamespaceInfo Class"
ms.date: "10/07/2016"
ms.assetid: a8819e4f-ec68-13bd-3236-aecd0d743d23
---
# NamespaceInfo Class

Contains namespace references similar to the `Import` directive.  
  
## Syntax  
  
```vbs  
class NamespaceInfo : EmbeddedObject  
```  
  
## Methods  

 This class contains no methods.  
  
## Properties  

 The following table lists the properties exposed by the `NamespaceInfo` class.  
  
|Name|Description|  
|----------|-----------------|  
|`AutoImportVBNamespace`|A read/write `boolean` value. `true` if the [Microsoft.VisualBasic](https://go.microsoft.com/fwlink/?LinkId=69333) namespace is imported automatically; otherwise, `false`. The default is `true`. **Note:**  For [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] pages written by using Visual Basic, the `VisualBasic` namespace is imported automatically unless the `AutoImportVBNamespace` property is set to `false`.|  
|`Namespaces`|An array of [NamespaceElement](../wmi-provider/namespaceelement-class.md) values that specify namespace references. **Note:**  No validation is performed to verify that the namespace references are valid.|  
  
## Subclasses  

 This class contains no subclasses.  
  
## Remarks  

 Instances of this class are contained in the `Namespaces` property of the [PagesSection](../wmi-provider/pagessection-class.md) class.  
  
 Each `NamespaceInfo` object is the same as an `Import` (\<%@ Import %>) directive that applies to all pages and controls in the scope of the configuration file. The `Import` directive enables you to import a namespace into your [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] page, which makes all its classes available for use on your page.  
  
## Inheritance Hierarchy  

 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `NamespaceInfo`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [System.Web.Configuration.NamespaceCollection](/dotnet/api/system.web.configuration.namespacecollection)   
 [System.Web.Configuration.NamespaceInfo](/dotnet/api/system.web.configuration.namespaceinfo)
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [NamespaceElement Class](../wmi-provider/namespaceelement-class.md)   
 [PagesSection Class](../wmi-provider/pagessection-class.md)   
 [Microsoft.VisualBasic Namespace](https://go.microsoft.com/fwlink/?LinkId=69333)
