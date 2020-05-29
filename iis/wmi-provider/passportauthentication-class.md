---
title: "PassportAuthentication Class"
ms.date: "10/07/2016"
ms.assetid: 499ec9c2-244d-83e0-88a5-3003ef7114bd
---
# PassportAuthentication Class
Configures Microsoft Passport Network authentication in [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] applications.  
  
## Syntax  
  
```vbs  
class PassportAuthentication : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `PassportAuthentication` class.  
  
|Name|Description|  
|----------|-----------------|  
|`RedirectUrl`|A read/write `string` value that specifies the URL of the page to which the request must be redirected if Passport Network authentication is required and the user has not signed on by using Passport Network credentials. The default is "internal".|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `Passport` property of the [AuthenticationSection](../wmi-provider/authenticationsection-class.md) class.  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `PassportAuthentication`  
  
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
 [DigestAuthenticationSection Class](../wmi-provider/digestauthenticationsection-class.md)   
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [FormsAuthenticationConfiguration Class](../wmi-provider/formsauthenticationconfiguration-class.md)   
 [FormsAuthenticationCredentials Class](../wmi-provider/formsauthenticationcredentials-class.md)   
 [FormsAuthenticationUser Class](../wmi-provider/formsauthenticationuser-class.md)   
 [IisClientCertificateMappingAuthenticationSection Class](../wmi-provider/iisclientcertificatemappingauthenticationsection-class.md)   
 [WindowsAuthenticationSection Class](../wmi-provider/windowsauthenticationsection-class.md)
