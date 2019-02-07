---
title: "BasicAuthenticationSection Class | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 55a1ded7-a01b-c38c-b661-ea61ab261400
caps.latest.revision: 24
author: "shirhatti"
manager: "wpickett"
---
# BasicAuthenticationSection Class
Configures Basic authentication.  
  
## Syntax  
  
```vbs  
class BasicAuthenticationSection : ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `BasicAuthenticationSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `BasicAuthenticationSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`DefaultLogonDomain`|A read/write `string` value that specifies the default domain that the server uses to authenticate users when the client does not specify a domain in the logon dialog box.|  
|`Enabled`|A read/write `boolean` value. `true` if Basic authentication is enabled; otherwise, `false`. The default is `false`.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`LogonMethod`|A read/write `sint32` enumeration that specifies the default logon method for a local user. The type of logon will determine whether the resulting token can also be used remotely. The possible values are listed later in the Remarks section.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Realm`|A read/write `string` value that contains the name of the realm that is used by the client for credential caching.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 The following table contains the possible values for the `LogonMethod` property. The default is 3 (`ClearText`). For more information, see the [LogonUserEx](http://go.microsoft.com/fwlink/?LinkId=60074) function.  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`Interactive`|This logon type is intended for users who will be interactively using the computer.|  
|1|`Batch`|This logon type is intended for batch servers, where processes may be executing on behalf of a user without their direct intervention. Credentials are not cached for this logon type.|  
|2|`Network`|This logon type is intended for high performance servers to authenticate plaintext passwords. Credentials are not cached for this logon type.|  
|3|`ClearText`|This logon type preserves the name and password in the authentication package, which allows the server to make connections to other network servers while impersonating the client.|  
  
## Example  
 The following example displays the `BasicAuthenticationSection` configuration for the default Web site.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = _  
    GetObject("winmgmts:root\WebAdministration")  
  
' Get the Basic authentication section for the default Web site.  
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
oSite.GetSection "BasicAuthenticationSection", oBasicAuth  
  
' Display the path and location.  
WScript.Echo "Basic Authentication Settings"  
WScript.Echo "-----------------------------"  
WScript.Echo "Path: " & oBasicAuth.Path  
WScript.Echo "Location: " & oBasicAuth.Location  
WScript.Echo   
  
' Display the Enabled, DefaultLogonDomain, Realm, and   
' LogonMethod properties.  
WScript.Echo "Enabled: " & _  
    "[" & oBasicAuth.Enabled & "]"  
  
WScript.Echo "DefaultLogonDomain: " & _  
    "[" & oBasicAuth.DefaultLogonDomain & "]"  
  
WScript.Echo "Realm: " & "[" & oBasicAuth.Realm & "]"  
  
WScript.Echo "LogonMethod: " &  _  
    "[" & GetLogonMethodText(oBasicAuth.LogonMethod) & "]"  
  
' Translate the LogonMethod enumeration values to text.  
Function GetLogonMethodText(LogonMethodValue)  
    Select Case LogonMethodValue  
        Case 0  
            GetLogonMethodText = "Interactive"  
        Case 1  
            GetLogonMethodText = "Batch"  
        Case 2  
            GetLogonMethodText = "Network"  
        Case 3  
            GetLogonMethodText = "ClearText"  
        Case Else  
            GetLogonMethodText = "Undefined enumeration."  
    End Select  
End Function  
  
```  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 `BasicAuthenticationSection`  
  
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
 [ClientCertificateMappingAuthenticationSection Class](../wmi-provider/clientcertificatemappingauthenticationsection-class.md)   
 [DigestAuthenticationSection Class](../wmi-provider/digestauthenticationsection-class.md)   
 [FormsAuthenticationConfiguration Class](../wmi-provider/formsauthenticationconfiguration-class.md)   
 [FormsAuthenticationCredentials Class](../wmi-provider/formsauthenticationcredentials-class.md)   
 [FormsAuthenticationUser Class](../wmi-provider/formsauthenticationuser-class.md)   
 [IisClientCertificateMappingAuthenticationSection Class](../wmi-provider/iisclientcertificatemappingauthenticationsection-class.md)   
 [PassportAuthentication Class](../wmi-provider/passportauthentication-class.md)   
 [WindowsAuthenticationSection Class](../wmi-provider/windowsauthenticationsection-class.md)   
 [LogonUserEx](http://go.microsoft.com/fwlink/?LinkId=60074)