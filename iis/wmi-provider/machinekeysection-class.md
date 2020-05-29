---
title: "MachineKeySection Class"
ms.date: "10/07/2016"
ms.assetid: 6811603d-8bc9-590e-9bd3-4356b1d5190b
---
# MachineKeySection Class
Defines the configuration settings that control the key generation and algorithms that are used in encryption, decryption, and media access control (MAC) operations in Forms authentication, view-state validation, and session-state application isolation.  
  
## Syntax  
  
```vbs  
class MachineKeySection : ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `MachineKeySection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `MachineKeySection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Decryption`|A read/write trimmed `string` value that specifies the type of hashing algorithm used to decrypt data. The possible values are listed later in the Remarks section. The default is "Auto".|  
|`DecryptionKey`|A read/write trimmed `string` value that either specifies the process by which the key is generated or contains text that is used to encrypt and decrypt data. The default is "AutoGenerate,IsolateApps". **Note:**  Use the "AutoGenerate" string to specify that [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] generates a random key and stores it in the Local Security Authority. The "AutoGenerate" string is part of the default value. If you add the "IsolateApps" modifier to the `DecryptionKey` value, [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] generates a unique encrypted key for each application by using its application ID. "IsolateApps" is also part of the default value. If you need to support configuration across a network of Web servers (a Web farm), set the `DecryptionKey` property manually to ensure consistent configuration.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
|`Validation`|A read/write `sint32` value that specifies the type of encryption that is used for validating data. The possible values are listed later in the Remarks section.|  
|`ValidationKey`|A read/write trimmed `string` value that either specifies the process by which the key is generated or contains text that is used to validate encrypted data. The default is "AutoGenerate,IsolateApps". **Note:**  When the `EnableViewStateMAC` property of the [PagesSection](../wmi-provider/pagessection-class.md) class is `true`, [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] uses the `ValidationKey` property to create a message authentication code to ensure that view state has not been tampered with. The validation key is also used to generate out-of-process, application-specific session IDs to ensure that session-state variables are isolated between applications. Use the "AutoGenerate" string to specify that [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] generates a random key and stores it in the Local Security Authority. "The AutoGenerate" string is part of the default value. If you add the "IsolateApps" modifier to the `ValidationKey` value, [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] generates a unique encrypted key for each application by using its application ID. "IsolateApps" is also part of the default value. If you need to support configuration across a network of Web servers (a Web farm), set the `ValidationKey` property manually to ensure consistent configuration.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
  
> [!NOTE]
>  In order for the `MachineKeySection` class to work across a network of Web servers (a Web farm), the `MachineKeySection` properties must be configured explicitly and identically with a valid key value. The "AutoGenerate" value does not work for Web farms because it relies on a cryptographically random key that is persisted by only the local computer. This key cannot be decrypted by any other computer.  
  
 The following table lists the possible values for the `Decryption` property. The default is "Auto".  
  
|Value|Description|  
|-----------|-----------------|  
|Auto|[!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] determines the algorithm with which to decrypt data based on default configuration settings.|  
|AES|[!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] uses the AES algorithm to decrypt data.|  
|3DES|[!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] uses the Triple DES algorithm to decrypt data.|  
  
 The following table lists the possible values for the `Validation` property. The default is 1 (`SHA1`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`MD5`|[!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] uses MD5 (Message-Digest algorithm 5) encryption.|  
|1|`SHA1`|[!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] uses SHA1 (Secure Hash Algorithm 1) encryption.|  
|2|`3DES`|[!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] uses Triple DES (Data Encryption Standard) encryption.|  
|3|`AES`|[!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] uses AES (Advanced Encryption Standard) encryption.|  
  
## Example  
 The following example displays the `MachineKeySection` settings for the default Web site.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = _  
    GetObject("winmgmts:root\WebAdministration")  
  
' Get the machine key section.  
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
oSite.GetSection "MachineKeySection", oMKeySection  
  
' Display the path and location.  
WScript.Echo "Machine Key Section Settings"  
WScript.Echo "----------------------------"  
WScript.Echo "Path: " & oMKeySection.Path  
WScript.Echo "Location: " & oMKeySection.Location  
  
' Display the machine key settings.  
WScript.Echo "Decryption: " & oMKeySection.Decryption  
  
WScript.Echo "Decryption Key: " & _  
    oMKeySection.DecryptionKey      
  
WScript.Echo "Validation: " & _  
    ValidationText(oMKeySection.Validation)  
  
WScript.Echo "Validation Key: " & oMKeySection.ValidationKey  
  
' Convert the Validation enumeration values to text.  
Function ValidationText(enumValue)  
    Select Case enumValue  
        Case 0  
            ValidationText = "MD5"  
        Case 1  
            ValidationText = "SHA1"  
        Case 2  
            ValidationText = "3DES"  
        Case 3  
            ValidationText = "AES"  
        Case Else  
            ValidationText = "Undefined enumeration value."  
    End Select  
End Function  
  
```  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 `MachineKeySection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [System.Web.Configuration.MachineKeyValidation](/dotnet/api/system.web.configuration.machinekeysection.validation)
 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)   
 [PagesSection Class](../wmi-provider/pagessection-class.md)
