---
title: ManyToOneCertificateMappingRuleElement Class
description: Describes the ManyToOneCertificateMappingRuleElement class and provides the class' syntax, properties, inheritance hierarchy, and requirements.
ms.date: 10/07/2016
ms.assetid: 04fe2a42-1c6f-8e6c-c296-7c03eec6ec42
---
# ManyToOneCertificateMappingRuleElement Class
Represents a many-to-one certificate mapping rule.  
  
## Syntax  
  
```vbs  
class ManyToOneCertificateMappingRuleElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `ManyToOneCertificateMappingRuleElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`CertificateField`|A required unique read/write `sint32` value that specifies whether the mapping rule applies to the subject or issuer of the certificate. The possible values are listed later in the Remarks section. A key property.|  
|`CertificateSubField`|A required unique read/write `string` value that specifies the certificate subfield against which the `MatchCriteria` property is applied. A key property.|  
|`CompareCaseSensitive`|A required unique read/write `boolean` value. `true` if the comparison performed using the `MatchCriteria` property is case-sensitive; otherwise, `false`. A key property.|  
|`MatchCriteria`|A required unique read/write `string` value that specifies the value that must be present in the certificate subfield in order for the client certificate to be mapped to a token user account. A key property.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `Rules` array property of the `ManyToOneCertificateRuleSettings` class.  
  
 The following table lists the possible values for the `CertificateField` property.  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|1|`Subject`|The rule applies to the subject of the certificate.|  
|2|`Issuer`|The rule applies to the issuer of the certificate.|  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `ManyToOneCertificateMappingRuleElement`  
  
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
 [IisClientCertificateMappingAuthenticationSection Class](../wmi-provider/iisclientcertificatemappingauthenticationsection-class.md)   
 [ManyToOneCertificateMappingElement Class](../wmi-provider/manytoonecertificatemappingelement-class.md)   
 [ManyToOneCertificateRuleSettings Class](../wmi-provider/manytoonecertificaterulesettings-class.md)   
 [OneToOneCertificateMappingElement Class](../wmi-provider/onetoonecertificatemappingelement-class.md)
