---
title: "ConfigurationSection.SetAllowLocation Method"
ms.date: "10/07/2016"
ms.assetid: ef360cdc-bd3f-4731-8e6c-87d0219903b2
---
# ConfigurationSection.SetAllowLocation Method
Sets the `allowLocation` attribute for a configuration section.  
  
## Syntax  
  
```vbs  
ConfigurationSection.SetAllowLocation(AllowLocation)  
```  
  
```jscript#  
ConfigurationSection.SetAllowLocation(AllowLocation);  
```  
  
### Parameters  
  
|Name|Definition|  
|----------|----------------|  
|`AllowLocation`|A case-sensitive `string` variable that sets the `allowLocation` attribute for the configuration section. The possible attribute values are "true" or "false". The default is "true". **Note:**  This parameter is a `string`, not a `boolean`.|  
  
## Return Value  
 This method does not return a value.  
  
## Remarks  
 The `allowLocation` attribute specifies whether a configuration section can appear inside a pair of location tags.  
  
 Because `SetAllowLocation` is a static method, you should call it by getting a class object, as in the following example.  
  
```  
' Correct syntax:  
Set oAnonAuth = oWebAdmin.Get("AnonymousAuthenticationSection")  
oAnonAuth.SetAllowLocation "false"  
```  
  
 The following syntax fails because it tries to call `SetAllowLocation` on a concrete instance of the `Site` class. The call to the method will cause an "SWbemObjectEx: Not found" error.  
  
```  
  
' Incorrect syntax:  
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
oSite.GetSection "AnonymousAuthenticationSection", oAnonAuth  
oAnonAuth.SetAllowLocation "false"  
```  
  
## Example  
 The following example sets the `allowLocation` attribute for the Anonymous authentication configuration section.  
  
```  
' Get the WebAdministration namespace.  
Set oWebAdmin = GetObject( _  
    "winmgmts:root\WebAdministration")  
  
' Get the AnonymousAuthenticationSection.  
Set oAnonAuth = oWebAdmin.Get( _  
    "AnonymousAuthenticationSection")  
  
' Set the allowLocation attribute.  
oAnonAuth.GetAllowLocation "false"  
  
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
 [ConfigurationSection.GetAllowLocation Method](../wmi-provider/configurationsection-getallowlocation-method.md)
