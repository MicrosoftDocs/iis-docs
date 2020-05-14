---
title: "TrustSection Class"
ms.date: "10/07/2016"
ms.assetid: 4fdfb984-ac44-52c5-b709-b0dd2b08a942
---
# TrustSection Class
Configures the level of code-access security that is applied to an application.  
  
## Syntax  
  
```vbs  
class TrustSection : ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `TrustSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `TrustSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Level`|A required read/write `string` value that specifies the trust level under which the Web application will run. Each trust level is mapped to an individual XML policy file by using a [TrustLevel](../wmi-provider/trustlevel-class.md) configuration element. The policy file lists the set of permissions that are granted by each trust level. For more information about [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] and policy files, see [ASP.NET Trust Levels and Policy Files](https://go.microsoft.com/fwlink/?LinkId=69328).<br /><br /> The `Level` property can contain a user-defined value if there is a matching security policy mapping defined in a `T``rustLevel` element in the [SecurityPolicySection](../wmi-provider/securitypolicysection-class.md) class, or it can contain one of the possible values listed later in the Remarks section.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`OriginUrl`|An optional read/write `string` value that specifies a URL for use with the `WebPermission` permission that is granted in `High` and `Medium` trust. If present, this can be used for some permissions, such as `WebRequest`, that allow connectivity only to specific URLs that are specified by a `WebPermission`.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`ProcessRequestInApplicationTrust`|A read/write `boolean` value. `true` if page requests are automatically restricted to the permissions that are configured in the trust policy file that is applied to the [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application; otherwise, `false`. The default is `true`.<br /><br /> Trust policy files are specified in `TrustLevel` configuration elements in the `SecurityPolicySection` class. You can apply a single trust policy to an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application by using the `Level` property. **Note:**  If the `ProcessRequestInApplicationTrust` property is set to `false`, [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] requests can potentially execute under `Full` trust, even if the `Level` property specifies a different trust level. Unless there are specific reasons for doing this, do not reset this property from the default of `true`. This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 The possible values for the `Level` property are listed in the following table. The default is `Full` (no restrictions).  
  
|Value|Description|  
|-----------|-----------------|  
|`Full`|Specifies unrestricted permissions. Grants the [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application permissions to access any resource that is subject to operating system security. All privileged operations are supported. This setting is named `Unrestricted` in the [System.Web.AspNetHostingPermissionLevel](https://go.microsoft.com/fwlink/?LinkId=69330) enumeration.|  
|`High`|Specifies a high level of code access security, which means that the application cannot do any of the following things:<br /><br /> -   Call unmanaged code.<br />-   Call serviced components.<br />-   Write to the event log.<br />-   Access Microsoft Windows Message Queuing queues.<br />-   Access ODBC, OLE DB, or Oracle data sources.|  
|`Medium`|Specifies a medium level of code access security, which means that, in addition to the restrictions for `High`, the [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application cannot do any of the following things:<br /><br /> -   Access files outside the application directory.<br />-   Access the registry.|  
|`Low`|Specifies a low level of code access security, which means that, in addition to the restrictions for `Medium`, the application cannot do any of the following things:<br /><br /> -   Write to the file system.<br />-   Call the [System.Security.CodeAccessPermission.Assert](https://go.microsoft.com/fwlink/?LinkId=69334) method to expand permissions to resources.|  
|`Minimal`|Specifies a minimal level of code access security, which means that the application has only execute permission.|  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 `TrustSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [System.Web.Configuration.SystemWebSectionGroup.Trust](/dotnet/api/system.web.configuration.systemwebsectiongroup.trust)  
 [System.Web.Configuration.TrustSection](/dotnet/api/system.web.configuration.trustsection)
 [System.Web.AspNetHostingPermissionLevel Enumeration](https://go.microsoft.com/fwlink/?LinkId=69330)
 [ASP.NET Trust Levels and Policy Files](https://go.microsoft.com/fwlink/?LinkId=69328)
 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)
 [TrustLevel Class](../wmi-provider/trustlevel-class.md)
 [System.Net.WebPermission Class](https://go.microsoft.com/fwlink/?LinkId=69331)
 [System.Net.WebRequest Class](https://go.microsoft.com/fwlink/?LinkId=69332)
