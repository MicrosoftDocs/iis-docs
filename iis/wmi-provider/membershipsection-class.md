---
title: "MembershipSection Class"
ms.date: "10/07/2016"
ms.assetid: f8b2a0e9-0187-8227-fa8c-7bd6f3de477c
---
# MembershipSection Class
Validates user credentials and manages user settings.  
  
## Syntax  
  
```vbs  
class MembershipSection : ConfigurationSectionWithCollection  
```  
  
## Methods  
 The following table lists the methods exposed by the `MembershipSection` class.  
  
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
 The following table lists the properties exposed by the `MembershipSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`DefaultProvider`|A read/write `string` value that specifies the default membership provider for an application. The default is "AspNetSqlMembershipProvider".|  
|`HashAlgorithmType`|A read/write `string` value that identifies a custom algorithm that is used to hash passwords. If no value is specified, the hash algorithm specified in the `Validation` property of the [MachineKeySection](../wmi-provider/machinekeysection-class.md) class is used. **Note:**  The [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)] enables you to configure custom cryptography classes by using the [\<cryptographySettings>](http://go.microsoft.com/fwlink/?LinkId=70955) configuration section. The `HashAlgorithmType` property must match the name attribute of the [\<nameEntry>](http://go.microsoft.com/fwlink/?LinkId=70956) element in a [\<cryptoNameMapping>](http://go.microsoft.com/fwlink/?LinkId=70957) element. For more information, see [Mapping Algorithm Names to Cryptography Classes](http://go.microsoft.com/fwlink/?LinkId=70954).|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Providers`|A [ProvidersSettings](../wmi-provider/providerssettings-class.md) value that specifies membership providers for an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application (Web.config level) or for all [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] applications (Machine.config level).|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
|`UserIsOnlineTimeWindow`|A read/write `datetime` value that specifies the time interval after the last-activity date/time stamp for a user during which the user is considered online. The default is 15 minutes.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)  
  
 `MembershipSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [System.Web.Security.Membership](/dotnet/api/system.web.security.membership) 
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)   
 [ProvidersSettings Class](../wmi-provider/providerssettings-class.md)   
 [Mapping Algorithm Names to Cryptography Classes](http://go.microsoft.com/fwlink/?LinkId=70954)