---
title: MSDeployPackage.SetConfigurationAndWebServerDirectories Method  (Microsoft.Web.PlatformInstaller)
TOCTitle: SetConfigurationAndWebServerDirectories Method
ms:assetid: M:Microsoft.Web.PlatformInstaller.MSDeployPackage.SetConfigurationAndWebServerDirectories(System.String,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.msdeploypackage.setconfigurationandwebserverdirectories(v=VS.90)
ms:contentKeyID: 46408510
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.MSDeployPackage.SetConfigurationAndWebServerDirectories
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.MSDeployPackage.SetConfigurationAndWebServerDirectories
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SetConfigurationAndWebServerDirectories Method

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicSubSetConfigurationAndWebServerDirectories ( _
    configurationDirectoryAsString, _
    webServerDirectoryAsString _
)
'Usage
DiminstanceAsMSDeployPackageDimconfigurationDirectoryAsStringDimwebServerDirectoryAsString

instance.SetConfigurationAndWebServerDirectories(configurationDirectory, _
    webServerDirectory)
```

``` csharp
publicvoidSetConfigurationAndWebServerDirectories(
    stringconfigurationDirectory,
    stringwebServerDirectory
)
```

``` c++
public:
voidSetConfigurationAndWebServerDirectories(
    String^ configurationDirectory, 
    String^ webServerDirectory
)
```

``` jscript
publicfunctionSetConfigurationAndWebServerDirectories(
    configurationDirectory : String, 
    webServerDirectory : String
)
```

#### Parameters

  - configurationDirectory  
    Type: String  

<!-- end list -->

  - webServerDirectory  
    Type: String  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[MSDeployPackage Class](msdeploypackage-class-microsoft-web-platforminstaller.md)

[MSDeployPackage Members](msdeploypackage-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

