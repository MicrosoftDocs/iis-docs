---
title: "ConfigurationSection.GetAllowLocation Method"
ms.date: "10/07/2016"
ms.assetid: f0488c2d-152c-4b55-a96a-f43b33ee34e1
---
# ConfigurationSection.GetAllowLocation Method
Retrieves the `allowLocation` attribute for a configuration section.  
  
## Syntax  
  
```vbs  
ConfigurationSection.GetAllowLocation AllowLocation  
```  
  
```jscript#  
ConfigurationSection.GetAllowLocation(AllowLocation);  
```  
  
### Parameters  
  
|Name|Definition|  
|----------|----------------|  
|`AllowLocation`|A `string` variable that receives the `allowLocation` attribute that the `GetAllowLocation` method returns. The possible attribute values are "true" or "false". The default is "true". **Note:**  This parameter is a `string`, not a `boolean`.|  
  
## Return Value  
 This method does not return a value.  
  
## Remarks  
 The `allowLocation` attribute specifies whether a configuration section can appear inside a pair of location tags.  
  
 Because `GetAllowLocation` is a static method, you should call it by getting a class object, as in the following example.  
  
```  
' Correct syntax:  
Set oAnonAuth = oWebAdmin.Get("AnonymousAuthenticationSection")  
oAnonAuth.GetAllowLocation strAnonAuthAllowLocation  
```  
  
 The following syntax fails because it tries to call `GetAllowLocation` on a concrete instance of the `Site` class. The call to the method will cause an "SWbemObjectEx: Not found" error.  
  
```  
  
' Incorrect syntax:  
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
oSite.GetSection "AnonymousAuthenticationSection", oAnonAuth  
oAnonAuth.GetAllowLocation strAnonAuthAllowLocation  
```  
  
## Example  
 The following example displays the `allowLocation` attribute for the Anonymous authentication configuration section.  
  
```  
' Get the WebAdministration namespace.  
Set oWebAdmin = GetObject( _  
    "winmgmts:root\WebAdministration")  
  
' Get the AnonymousAuthenticationSection.  
Set oAnonAuth = oWebAdmin.Get( _  
    "AnonymousAuthenticationSection")  
  
' Get the allowLocation attribute.  
oAnonAuth.GetAllowLocation strAnonAuthAllowLocation  
  
' Display the allowLocation attribute.  
WScript.Echo _  
    "Anonymous Authentication Allow Location: " & _  
        strAnonAuthAllowLocation  
  
```  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [AnonymousAuthenticationSection Class](../wmi-provider/anonymousauthenticationsection-class.md)   
 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)   
 [ConfigurationSection.GetAllowDefinition Method](../wmi-provider/configurationsection-getallowdefinition-method.md)
