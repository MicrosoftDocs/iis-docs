---
title: "SSLBinding Class"
ms.date: "10/07/2016"
ms.assetid: 1c7b8e2b-2ce9-5bb5-87a5-4ac1603c0c66
---
# SSLBinding Class
Represents a Secure Sockets Layer (SSL) binding.  
  
## Syntax  
  
```vbs  
class SSLBinding : Object  
```  
  
## Methods  
 The following table lists the methods exposed by the `SSLBinding` class.  
  
|Name|Description|  
|----------|-----------------|  
|[Create](../wmi-provider/sslbinding-create-method.md)|Creates a Secure Sockets Layer (SSL) binding.|  
  
## Properties  
 The following table lists the properties exposed by the `SSLBinding` class.  
  
|Name|Description|  
|----------|-----------------|  
|`BindingOwnerId`|A read/write `string` value that contains a GUID that represents the application that created the binding.|  
|`CertificateCheckMode`|A read/write `sint32` enumeration that configures client certificate checking. The possible values are listed later in the Remarks section.|  
|`CertificateHash`|A read/write `string` value that represents the unique identifier for the certificate. This property maps to the IIS 6.0 [SSLCertHash](https://msdn.microsoft.com/c970c1e3-e29d-4d75-8aa2-cf22027cdd6c) metabase property.|  
|`CertificateStoreName`|A read/write `string` value that contains the name of the certificate store where the certificate is found. This property maps to the IIS 6.0 [SSLStoreName](https://msdn.microsoft.com/8b79e987-082d-451c-bce1-bcdc24ed056f) metabase property.|  
|`CTLIdentifier`|A read/write `string` value that identifies a certificate trust list (CTL). A CTL is a list of trusted certification authorities (CAs) for a particular Web site.|  
|`CTLStoreName`|A read/write `string` value that specifies the name of the certificate store that contains the CTL.|  
|`IPAddress`|A read-only `string` value that contains the IP address for the secure binding. A key property.|  
|`Port`|A read-only `uint32` value that contains the port number that the secure binding uses. A key property.|  
|`RevocationFreshnessTime`|A read/write `datetime` value that specifies the frequency with which the certificate revocation list (CRL) on the certificate client is replaced by the CRL from the certification authority (CA), even if the certificate client's cached CRL is still valid. The default is 0. **Note:**  You must set the `CertificateCheckMode` property to `EnableRevocationFreshnessTimeSetting` for the `RevocationFreshnessTime` property to take effect.|  
|`RevocationURLRetrievalTimeout`|A read/write `datetime` value that specifies the period of time that IIS waits for an updated CRL to finishing downloading to the client. The default is 0 (no limit). If the CRL is a large file, a higher value for this property allows more time for the download to complete. **Note:**  You must set the `CertificateCheckMode` property to `EnableRevocationFreshnessTimeSetting` for the `RevocationURLRetrievalTimeout` property to take effect.|  
|`SslAlwaysNegoClientCert`|A read/write `boolean` value that specifies how SSL client connections will be negotiated. `true` if the server will immediately negotiate a client certificate; otherwise, `false`. The default is `false`. Setting this property to `true` prevents expensive renegotiation and helps eliminate client certificate renegotiation deadlocks.|  
|`SslUseDsMapper`|A read/write `boolean` value. `true` if the Microsoft Active Directory certificate mapper is used for client certificate authentication; otherwise, `false`. The default is `false`.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 To enable SSL for a Web site, you must first create an SSL binding and then add it to the Web site. You can see code examples for these steps in the [SSLBinding.Create](../wmi-provider/sslbinding-create-method.md) method topic. To enable SSL in a domain environment, you must also set the `SslUseDsMapper` property to `true` and the `Enabled` property of the[ClientCertificateMappingAuthenticationSection](../wmi-provider/clientcertificatemappingauthenticationsection-class.md) class to `true`.  
  
 The following table lists the possible values for the `CertificateCheckMode` property.  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|1|`DisableClientCertRevocationCheck`|The client certificate is not verified for revocation.|  
|2|`AlwaysUseCachedCRL`|The cached CRL is always used.|  
|4|`EnableRevocationFreshnessTimeSetting`|Enables the value in the `RevocationFreshnessTime` property.|  
|65536|`DisableClientCertUsageCheck`|No client certificate usage check is performed.|  
  
## Example  
 The following example enumerates the secure bindings on a Web server.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the secure binding instances and display their properties.  
Set oBindings = oWebAdmin.InstancesOf("SSLBinding")  
For Each oBinding in oBindings  
    WScript.Echo "============================================"  
    WScript.Echo oBinding.Port  
    WScript.Echo oBinding.IPAddress  
    WScript.Echo oBinding.CertificateHash  
    WScript.Echo oBinding.BindingOwnerID  
Next  
```  
  
## Inheritance Hierarchy  
 [Object](../wmi-provider/object-class.md)  
  
 `SSLBinding`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [Object Class](../wmi-provider/object-class.md)   
 [ClientCertificateMappingAuthenticationSection Class](../wmi-provider/clientcertificatemappingauthenticationsection-class.md)   
 [IisClientCertificateMappingAuthenticationSection Class](../wmi-provider/iisclientcertificatemappingauthenticationsection-class.md)   
 [ManyToOneCertificateMappingElement Class](../wmi-provider/manytoonecertificatemappingelement-class.md)   
 [OneToOneCertificateMappingElement Class](../wmi-provider/onetoonecertificatemappingelement-class.md)