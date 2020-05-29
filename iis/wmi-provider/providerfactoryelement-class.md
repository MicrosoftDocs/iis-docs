---
title: "ProviderFactoryElement Class"
ms.date: "10/07/2016"
ms.assetid: 6cee1598-11a6-3211-c3e1-24b5e68e46e8
---
# ProviderFactoryElement Class
Contains configuration settings for an [!INCLUDE[ado_whidbey_long](../wmi-provider/includes/ado-whidbey-long-md.md)] provider factory.  
  
## Syntax  
  
```vbs  
class ProviderFactoryElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `ProviderFactoryElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Description`|A read/write `string` value that contains the verbose name of the data provider specified in the `Name` and `Invariant` properties (for example, ".NET Framework Data Provider for ODBC").|  
|`Invariant`|A read/write `string` value that contains the invariant name of the provider that is specified in the `Description` and `Name` properties (for example, "System.Data.Odbc"). The invariant name can be passed to the [System.Data.Common.DBProviderFactories.GetFactory](https://go.microsoft.com/fwlink/?LinkId=70912) method to obtain a [System.Data.Common.DBProviderFactory](https://go.microsoft.com/fwlink/?LinkId=70913) object for the provider.|  
|`Name`|A required unique read/write `string` value that contains the name of a data provider (for example, "ODBC Data Provider"). The key property.|  
|`Type`|A read/write `string` value that specifies the type for the provider specified in the `Name`, `Description`, and `Invariant` properties (for example, "System.Data.Odbc.OdbcFactory, System.Data, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089").|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `DbProviderFactories` array property of the [DbProviderFactorySettings](../wmi-provider/dbproviderfactorysettings-class.md) class.  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `ProviderFactoryElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [DbProviderFactorySettings Class](../wmi-provider/dbproviderfactorysettings-class.md)   
 [SystemDataSection Class](../wmi-provider/systemdatasection-class.md)   
 [ADO.NET 2.0 Feature Matrix](https://go.microsoft.com/fwlink/?LinkId=70915)
