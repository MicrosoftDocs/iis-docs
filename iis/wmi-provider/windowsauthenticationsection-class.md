---
title: "WindowsAuthenticationSection Class | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: ed2cdad3-5361-01cc-8350-9e215a97514e
caps.latest.revision: 30
author: "shirhatti"
manager: "wpickett"
---
# WindowsAuthenticationSection Class
Configures Integrated Windows authentication.  
  
## Syntax  
  
```vbs  
class WindowsAuthenticationSection : ConfigurationSectionWithCollection  
```  
  
## Methods  
 The following table lists the methods exposed by the `WindowsAuthenticationSection` class.  
  
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
 The following table lists the properties exposed by the `WindowsAuthenticationSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`AuthPersistNonNTLM`|A read/write `boolean` value. `true` if IIS automatically reauthenticates every non-NTLM (for example, Kerberos) request, even those on the same connection; otherwise, `false`. The default is `false`. **Note:**  A setting of `false` means that the client will be authenticated only once on the same connection. IIS will cache a token or ticket on the server for a TCP session that stays established.|  
|`AuthPersistSingleRequest`|A read/write `boolean` value. `true` if IIS automatically reauthenticates every NTLM request, even those on the same connection; otherwise, `false`. The default is `false`. **Note:**  A setting of `false` means that the client will be authenticated only once on the same connection. IIS will cache a token or ticket on the server for a TCP session that stays established.|  
|`Enabled`|A read/write `boolean` value. `true` if Integrated Windows authentication is enabled; otherwise, `false`. The default is `false`.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Providers`|An [AuthenticationProviderSettings](../wmi-provider/authenticationprovidersettings-class.md) value that specifies security support providers that are used for Integrated Windows authentication.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
|`UseKernelMode`|A read/write `boolean` value. `true` if Integrated Windows authentication is done in kernel mode; otherwise, `false`. The default is `true`. **Note:**  Using kernel mode improves authentication performance. However, if you want to use the Kerberos protocol in a Web farm, you may want to set this property to `false`.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)  
  
 `WindowsAuthenticationSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [AnonymousAuthenticationSection Class](../wmi-provider/anonymousauthenticationsection-class.md)   
 [AuthenticationProviderSettings Class](../wmi-provider/authenticationprovidersettings-class.md)   
 [AuthenticationSection Class](../wmi-provider/authenticationsection-class.md)   
 [BasicAuthenticationSection Class](../wmi-provider/basicauthenticationsection-class.md)   
 [ClientCertificateMappingAuthenticationSection Class](../wmi-provider/clientcertificatemappingauthenticationsection-class.md)   
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)   
 [DigestAuthenticationSection Class](../wmi-provider/digestauthenticationsection-class.md)   
 [FormsAuthenticationConfiguration Class](../wmi-provider/formsauthenticationconfiguration-class.md)   
 [FormsAuthenticationCredentials Class](../wmi-provider/formsauthenticationcredentials-class.md)   
 [FormsAuthenticationUser Class](../wmi-provider/formsauthenticationuser-class.md)   
 [IisClientCertificateMappingAuthenticationSection Class](../wmi-provider/iisclientcertificatemappingauthenticationsection-class.md)   
 [PassportAuthentication Class](../wmi-provider/passportauthentication-class.md)   
 [StringElement Class](../wmi-provider/stringelement-class.md)