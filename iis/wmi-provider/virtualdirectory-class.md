---
title: VirtualDirectory Class2
description: Describes the VirtualDirectory class and provides the class' syntax, methods, properties, remarks, examples, inheritance hierarchy, and requirements.
ms.date: 10/07/2016
ms.assetid: 87c349b9-1d64-ac13-cb24-e70a5c209b6e
---
# VirtualDirectory Class2
Represents an IIS virtual directory.  
  
## Syntax  
  
```vbs  
class VirtualDirectory : ConfiguredObject  
```  
  
## Methods  
 The following table lists the methods exposed by the `VirtualDirectory` class.  
  
|Name|Description|  
|----------|-----------------|  
|[Create](../wmi-provider/virtualdirectory-create-method.md)|Creates a virtual directory.|  
|[GetAllSections](../wmi-provider/configuredobject-getallsections-method.md)|(Inherited from [ConfiguredObject](../wmi-provider/configuredobject-class.md).)|  
|[GetSection](../wmi-provider/configuredobject-getsection-method.md)|(Inherited from `ConfiguredObject`.)|  
|[RevertToParent](../wmi-provider/virtualdirectory-reverttoparent-method.md)|Reverts a virtual directory's configuration value or values to those of its parent directory.|  
  
## Properties  
 The following table lists the properties exposed by the `VirtualDirectory` class.  
  
|Name|Description|  
|----------|-----------------|  
|`AllowSubDirConfig`|A read/write `boolean` value. `true` if IIS looks for Web.config files in content directories lower than the current level; `false` if IIS does not look for these files in directories lower than the current level. The default is `true`.|  
|`ApplicationPath`|A read-only `string` value that contains the path for the application to which the virtual directory belongs. A key property.|  
|`LogonMethod`|A read/write `sint32` enumeration that specifies how a user is locally logged on. The type of logon will determine whether the resulting token can also be used remotely. The possible values are listed later in the Remarks section.|  
|`Password`|A read/write `string` value that specifies the encrypted password for access to the physical path for the virtual directory.|  
|`Path`|A read-only `string` value that contains the virtual directory path. A key property.|  
|`PhysicalPath`|A read/write `string` value that specifies the physical path associated with the virtual directory.|  
|`SiteName`|A read-only `string` value that contains the name of the Web site to which the virtual directory belongs. A key property.|  
|`UserName`|A read/write `string` value that specifies a user who has rights to access any configuration files or content in a virtual directory. The default is `null`.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 The following table contains the possible values and keywords for the `LogonMethod` property. The default is 3 (`ClearText`). For more information, see the [LogonUserEx](https://go.microsoft.com/fwlink/?LinkId=60074) function.  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`Interactive`|This logon type is intended for users who will be interactively using the computer.|  
|1|`Batch`|This logon type is intended for batch servers, where processes may be executing on behalf of a user without their direct intervention. Credentials are not cached for this logon type.|  
|2|`Network`|This logon type is intended for high performance servers to authenticate plaintext passwords. Credentials are not cached for this logon type.|  
|3|`ClearText`|This logon type preserves the name and password in the authentication package, which allows the server to make connections to other network servers while impersonating the client.|  
  
## Example  
 The following example sets the physical path for the default Web site.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
' Get the root virtual directory for the default Web site.  
Set oVDir = oWebAdmin.Get(_   
"VirtualDirectory.SiteName='Default Web Site',ApplicationPath='/',Path='/'")  
  
' Set the physical path for the default Web site.  
oVDir.PhysicalPath = "C:\MyContent"  
oVDir.Put_  
  
```  
  
## Inheritance Hierarchy  
 [ConfiguredObject](../wmi-provider/configuredobject-class.md)  
  
 `VirtualDirectory`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfiguredObject Class](../wmi-provider/configuredobject-class.md)   
 [Object Class](../wmi-provider/object-class.md)   
 [LogonUserEx](https://go.microsoft.com/fwlink/?LinkId=60074)
