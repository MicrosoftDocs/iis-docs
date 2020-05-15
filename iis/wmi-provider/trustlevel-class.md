---
title: "TrustLevel Class"
ms.date: "10/07/2016"
ms.assetid: b83352ab-7aed-6422-b311-8e9a2b615ab0
---
# TrustLevel Class

Configures a trust level for Web applications on a Web server.  
  
## Syntax  
  
```vbs  
class TrustLevel : CollectionElement  
```  
  
## Methods  

 This class contains no methods.  
  
## Properties  

 The following table lists the properties exposed by the `TrustLevel` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Name`|A required read-only `string` value that specifies a named security level that is mapped to a policy file. The possible values are listed later in the Remarks section. The key property.|  
|`PolicyFile`|A required read/write `string` value that specifies a configuration file that contains security policy settings for the security level specified in the `Name` property. The default is "internal".<br /><br /> The policy file must be located in the same directory as the computer-level Web.config file. By default this directory is *%windir%*\Microsoft.NET\Framework\\*{version}*\Config.<br /><br /> You can apply the security policy file to an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application by specifying the trust level name in the `Level` property of the [TrustSection](../wmi-provider/trustsection-class.md) class.|  
  
## Subclasses  

 This class contains no subclasses.  
  
## Remarks  

 Instances of this class are contained in the `SecurityPolicy` property of the [SecurityPolicySection](../wmi-provider/securitypolicysection-class.md) class.  
  
 You can establish the security policy for all Web applications on the server by setting the trust level. Because trust levels can be defined only at the computer level, configuration files must set the levels in the computer-level configuration directory. By default, this directory is *%windir%*\Microsoft.NET\Framework\\*{version}*\Config.  
  
 You can create a custom policy by mapping a named `<trustLevel>` element in the computer-level Web.config file to a custom policy configuration file. The custom policy configuration file must also reside in the computer-level configuration directory.  
  
 The following table lists the possible values for the `Name` property. The default is "`Full`". For an explanation of what each trust level allows, see the [TrustSection](../wmi-provider/trustsection-class.md) class.  
  
|Value|Description|  
|-----------|-----------------|  
|"`Full`"|Specifies that [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] does not restrict security policy with an application domain–specific policy. There is no security policy file associated with `Full`. By default, this trust-level value is mapped to "internal" in the `PolicyFile` property. **Note:**  Because [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] treats Full trust as a special case, Full trust does not have an associated policy file. If Full is set, the [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] host does not add extra domain–level policy to the application. The Full trust level is always mapped to an internal handler, and the `PolicyFile` property is ignored.|  
|"`High`"|Specifies a high level of security for policy file mapping. By default, this trust-level value is mapped to the Web_hightrust.config policy file.|  
|"`Medium`"|Specifies a medium level of security for policy file mapping. By default, this trust-level value is mapped to the Web_mediumtrust.config policy file.|  
|"`Low`"|Specifies a low level of security for policy file mapping. By default, this trust-level value is mapped to the Web_lowtrust.config policy file.|  
|"`Minimal`"|Specifies a minimal level of security for policy file mapping. By default, this trust-level value is mapped to the Web_minimaltrust.config policy file.|  
|"`User Defined`"|Specifies the name of a user-defined trust level. For more information, see [Administering Security Policy](https://go.microsoft.com/fwlink/?LinkId=69326).|  
  
## Example  

 The following example displays the trust-level names and corresponding security policy configuration files that are specified in the computer-level Web.config file.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the security policy section.  
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
oSite.GetSection "SecurityPolicySection", oSection  
  
' Display the path and location.  
WScript.Echo "Path: " & oSection.Path   
WScript.Echo "Location: " & oSection.Location  
WScript.Echo  
  
' Display the security level names and their policy files.  
For Each oTrustLevel In oSection.SecurityPolicy  
    WScript.Echo "Security level: " & oTrustLevel.Name  
    WScript.Echo "   Policy file: " & oTrustLevel.PolicyFile  
    WScript.Echo   
Next  
  
```  
  
## Inheritance Hierarchy  

 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `TrustLevel`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [System.Web.Configuration.TrustLevel](/dotnet/api/system.web.configuration.trustlevel)
 [Administering Security Policy](https://go.microsoft.com/fwlink/?LinkId=69326)   
 [ASP.NET Trust Levels and Policy Files](https://go.microsoft.com/fwlink/?LinkId=69328)   
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [SecurityPolicySection Class](../wmi-provider/securitypolicysection-class.md)   
 [trustLevel Element for securityPolicy (ASP.NET Settings Schema)](https://go.microsoft.com/fwlink/?LinkId=69327)
