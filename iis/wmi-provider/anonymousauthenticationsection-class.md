---
title: AnonymousAuthenticationSection Class1
description: Describes the AnonymousAuthenticationSection class and provides the class' syntax, methods, properties, an example, inheritance hierarchy, and requirements.
ms.date: 10/07/2016
ms.assetid: bb9b1588-672f-2a06-d1ac-9a3a1a3e3121
---
# AnonymousAuthenticationSection Class1
Configures Anonymous authentication.  
  
## Syntax  
  
```vbs  
class AnonymousAuthenticationSection : ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `AnonymousAuthenticationSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `AnonymousAuthenticationSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Enabled`|A read/write `boolean` value. `true` if Anonymous authentication is enabled; otherwise, `false`. The default is `true`.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`LogonMethod`|A read/write `sint32` enumeration that specifies the method for logons. The possible values are listed later in the Remarks section.|  
|`Password`|A read/write encrypted `string` value that contains a password.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`UserName`|A read/write `string` value that contains a user name. The default is "IUSR".|  
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
  
## Example  
 The following example displays the `AnonymousAuthenticationSection` values for the default Web site.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = _  
    GetObject("winmgmts:root\WebAdministration")  
  
' Get the Anonymous authentication section for the default  
' Web site.  
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
oSite.GetSection "AnonymousAuthenticationSection", oAnonAuth  
  
' Display the path and location.  
WScript.Echo "Anonymous Authentication Settings"  
WScript.Echo "---------------------------------"  
WScript.Echo "Path: " & oAnonAuth.Path  
WScript.Echo "Location: " & oAnonAuth.Location  
WScript.Echo   
  
' Display the Enabled, LogonMethod, UserName, and Password  
' properties.  
WScript.Echo "Enabled: " & _  
    "[" & oAnonAuth.Enabled & "]"  
WScript.Echo "LogonMethod: " &  _  
    "[" & GetLogonMethodText(oAnonAuth.LogonMethod) & "]"  
WScript.Echo "UserName: " & "[" & oAnonAuth.UserName & "]"  
WScript.Echo "Password: " & "[" & oAnonAuth.Password & "]"  
  
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
            GetLogonMethodText = "Undefined value."  
    End Select  
End Function  
  
```  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 `AnonymousAuthenticationSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [AuthenticationSection Class](../wmi-provider/authenticationsection-class.md)   
 [BasicAuthenticationSection Class](../wmi-provider/basicauthenticationsection-class.md)   
 [ClientCertificateMappingAuthenticationSection Class](../wmi-provider/clientcertificatemappingauthenticationsection-class.md)   
 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)   
 [DigestAuthenticationSection Class](../wmi-provider/digestauthenticationsection-class.md)   
 [FormsAuthenticationConfiguration Class](../wmi-provider/formsauthenticationconfiguration-class.md)   
 [FormsAuthenticationCredentials Class](../wmi-provider/formsauthenticationcredentials-class.md)   
 [FormsAuthenticationUser Class](../wmi-provider/formsauthenticationuser-class.md)   
 [IisClientCertificateMappingAuthenticationSection Class](../wmi-provider/iisclientcertificatemappingauthenticationsection-class.md)   
 [PassportAuthentication Class](../wmi-provider/passportauthentication-class.md)   
 [WindowsAuthenticationSection Class](../wmi-provider/windowsauthenticationsection-class.md)
