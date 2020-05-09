---
title: "TransactionsDefaultSettingsSection Class"
ms.date: "10/07/2016"
ms.assetid: 3fed9528-f632-d270-6196-3b37bb64ca08
---
# TransactionsDefaultSettingsSection Class
Contains default settings for transactions.  
  
## Syntax  
  
```vbs  
class TransactionsDefaultSettingsSection : ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `TransactionsDefaultSettingsSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `TransactionsDefaultSettingsSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`DistributedTransactionManagerName`|A read/write `string` value that specifies the computer name of the Microsoft Distributed Transaction Coordinator (MSDTC) that is responsible for coordinating all distributed transactions that are started locally. The name is not case-sensitive and should contain only the short name of the computer.<br /><br /> The `DistributedTransactionManagerName` property does not accept fully qualified domain names, localhost names, or IP addresses. If this property contains an invalid remote computer name, an "unable to read configuration information" exception is thrown.<br /><br /> If the `DistributedTransactionManagerName` property is `null` or contains an empty string, the local transaction manager is used as the remote transaction manager.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
|`Timeout`|A read/write `datetime` value that contains the default interval after which a transaction times out. The default is 1 minute. A value of 0 is interpreted as infinity. **Note:**  At run time, this value is automatically adjusted by the `MaxTimeout` property of the [TransactionsMachineSettingsSection](../wmi-provider/transactionsmachinesettingssection-class.md) class|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 `TransactionsDefaultSettingsSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)   
 [TransactionsMachineSettingsSection Class](../wmi-provider/transactionsmachinesettingssection-class.md)   
 [CIM_DATETIME](https://go.microsoft.com/fwlink/?LinkId=57551)
