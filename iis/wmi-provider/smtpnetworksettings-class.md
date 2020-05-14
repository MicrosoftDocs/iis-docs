---
title: "SmtpNetworkSettings Class"
ms.date: "10/07/2016"
ms.assetid: 56fb1598-1a9e-3fa0-08c4-2789202f1d4b
---
# SmtpNetworkSettings Class
Configures Simple Mail Transfer Protocol (SMTP) network settings.  
  
## Syntax  
  
```vbs  
class SmtpNetworkSettings : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `SmtpNetworkSettings` class.  
  
|Name|Description|  
|----------|-----------------|  
|`DefaultCredentials`|A read/write `boolean` value. `true` if default user credentials are used to access an SMTP server; otherwise, `false`. The default is `false`.|  
|`Host`|A read/write `string` value that specifies the name of the SMTP server.|  
|`Password`|A read/write `string` value that specifies the user password with which to connect to an SMTP server. **Note:**  The `DefaultCredentials` property takes precedence over the `UserName` and `Password` properties. The `UserName` and `Password` properties are used only if `DefaultCredentials` is set to `false`.|  
|`Port`|A read/write `sint32` value that specifies the port that SMTP clients use to connect to an SMTP server. The default is 25.|  
|`UserName`|A read/write `string` value that specifies the user name with which to connect to an SMTP server.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `Network` property of the [SmtpMailSettingsSection](../wmi-provider/smtpmailsettingssection-class.md) class.  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `SmtpNetworkSettings`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)
 [SmtpMailSettingsSection Class](../wmi-provider/smtpmailsettingssection-class.md)
