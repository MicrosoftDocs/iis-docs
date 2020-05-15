---
title: "IisClientCertificateMappingAuthenticationSection Class"
ms.date: "10/07/2016"
ms.assetid: ab36fc78-170a-754c-8128-86e05a251fac
---
# IisClientCertificateMappingAuthenticationSection Class

Configures mapping for IIS client certificates.  
  
## Syntax  
  
```vbs  
class IisClientCertificateMappingAuthenticationSection : ConfigurationSectionWithCollection  
```  
  
## Methods  

 The following table lists the methods exposed by the `IisClientCertificateMappingAuthenticationSection` class.  
  
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

 The following table lists the properties exposed by the `IisClientCertificateMappingAuthenticationSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`DefaultLogonDomain`|A read/write `string` value that specifies the default domain that the server uses to authenticate users.|  
|`Enabled`|A read/write `boolean` value. `true` if IIS Client Certificate Mapping authentication is enabled; otherwise, `false`. The default is `false`.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`LogonMethod`|A read/write `sint32` enumeration that specifies the method for logons. The possible values are listed later in the Remarks section.|  
|`ManyToOneCertificateMappingsEnabled`|A read/write `boolean` value. `true` if many-to-one mapping is enabled; otherwise, `false`. The default is `true`.|  
|`ManyToOneMappings`|A [ManyToOneSettings](../wmi-provider/manytoonesettings-class.md) value that specifies many-to-one client certificate mappings.|  
|`OneToOneCertificateMappingsEnabled`|A read/write `boolean` value. `true` if one-to-one mapping is enabled; otherwise, `false`. The default is `true`.|  
|`OneToOneMappings`|A [OneToOneSettings](../wmi-provider/onetoonesettings-class.md) value that specifies one-to-one client certificate mappings.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
  
## Subclasses  

 This class contains no subclasses.  
  
## Remarks  

 The following table lists the possible values for the `LogonMethod` property. The default is 3 (`ClearText`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`Interactive`|This logon type is intended for users who will be interactively using the computer.|  
|1|`Batch`|This logon type is intended for batch servers, where processes may be executing on behalf of a user without their direct intervention. Credentials are not cached for this logon type.|  
|2|`Network`|This logon type is intended for high performance servers to authenticate plaintext passwords. Credentials are not cached for this logon type.|  
|3|`ClearText`|This logon type preserves the name and password in the authentication package, which allows the server to make connections to other network servers while impersonating the client.|  
  
## Inheritance Hierarchy  

 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)  
  
 `IisClientCertificateMappingAuthenticationSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [AccessSection Class](../wmi-provider/accesssection-class.md)   
 [ClientCertificateMappingAuthenticationSection Class](../wmi-provider/clientcertificatemappingauthenticationsection-class.md)   
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)   
 [ManyToOneCertificateMappingElement Class](../wmi-provider/manytoonecertificatemappingelement-class.md)   
 [ManyToOneCertificateMappingRuleElement Class](../wmi-provider/manytoonecertificatemappingruleelement-class.md)   
 [ManyToOneSettings Class](../wmi-provider/manytoonesettings-class.md)   
 [OneToOneCertificateMappingElement Class](../wmi-provider/onetoonecertificatemappingelement-class.md)   
 [OneToOneSettings Class](../wmi-provider/onetoonesettings-class.md)
