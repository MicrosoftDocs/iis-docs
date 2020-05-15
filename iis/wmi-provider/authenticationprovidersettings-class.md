---
title: "AuthenticationProviderSettings Class"
ms.date: "10/07/2016"
ms.assetid: b07e1d3e-6894-4ca3-b5e3-7f80e6944c12
---
# AuthenticationProviderSettings Class

Contains security support providers that are used for Integrated Windows authentication.  
  
## Syntax  
  
```vbs  
class AuthenticationProviderSettings : EmbeddedObject  
```  
  
## Methods  

 This class contains no methods.  
  
## Properties  

 The following table lists the properties exposed by the `AuthenticationProviderSettings` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Providers`|An array of [StringElement](../wmi-provider/stringelement-class.md) values that specify security support providers that are used for Integrated Windows authentication.|  
  
## Subclasses  

 This class contains no subclasses.  
  
## Remarks  

 Instances of this class are contained in the `Providers` array property of the [WindowsAuthenticationSection](../wmi-provider/windowsauthenticationsection-class.md) class.  
  
## Inheritance Hierarchy  

 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `AuthenticationProviderSettings`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [AnonymousAuthenticationSection Class](../wmi-provider/anonymousauthenticationsection-class.md)   
 [AuthenticationSection Class](../wmi-provider/authenticationsection-class.md)   
 [BasicAuthenticationSection Class](../wmi-provider/basicauthenticationsection-class.md)   
 [ClientCertificateMappingAuthenticationSection Class](../wmi-provider/clientcertificatemappingauthenticationsection-class.md)   
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)   
 [DigestAuthenticationSection Class](../wmi-provider/digestauthenticationsection-class.md)   
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [FormsAuthenticationConfiguration Class](../wmi-provider/formsauthenticationconfiguration-class.md)   
 [FormsAuthenticationCredentials Class](../wmi-provider/formsauthenticationcredentials-class.md)   
 [FormsAuthenticationUser Class](../wmi-provider/formsauthenticationuser-class.md)   
 [IisClientCertificateMappingAuthenticationSection Class](../wmi-provider/iisclientcertificatemappingauthenticationsection-class.md)   
 [PassportAuthentication Class](../wmi-provider/passportauthentication-class.md)   
 [StringElement Class](../wmi-provider/stringelement-class.md)   
 [WindowsAuthenticationSection Class](../wmi-provider/windowsauthenticationsection-class.md)
