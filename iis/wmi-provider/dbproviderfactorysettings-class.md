---
title: DbProviderFactorySettings Class
description: Describes the DbProviderFactorySettings class and provides the class' syntax, properties, remarks, inheritance hierarchy, and requirements.
ms.date: 10/07/2016
ms.assetid: b9c5fbd7-3305-4d2b-a637-5f3e524f6be9
---
# DbProviderFactorySettings Class
Contains configuration settings for [!INCLUDE[ado_whidbey_long](../wmi-provider/includes/ado-whidbey-long-md.md)] provider factories.  
  
## Syntax  
  
```vbs  
class DbProviderFactorySettings : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `DbProviderFactorySettings` class.  
  
|Name|Description|  
|----------|-----------------|  
|`DbProviderFactories`|An array of [ProviderFactoryElement](https://msdn.microsoft.com/42f523ee-eaab-4a81-917d-5c0f591cfc45) values that contain configuration settings for [!INCLUDE[ado_whidbey_long](../wmi-provider/includes/ado-whidbey-long-md.md)] provider factories.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `DbProviderFactories` array property of the [SystemDataSection](../wmi-provider/systemdatasection-class.md) class.  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `DbProviderFactorySettings`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [ProviderFactoryElement Class](../wmi-provider/providerfactoryelement-class.md)   
 [SystemDataSection Class](../wmi-provider/systemdatasection-class.md)
