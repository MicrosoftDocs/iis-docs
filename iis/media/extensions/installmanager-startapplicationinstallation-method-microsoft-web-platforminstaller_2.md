---
title: InstallManager.StartApplicationInstallation Method (, ) (Microsoft.Web.PlatformInstaller)
TOCTitle: StartApplicationInstallation Method (, )
ms:assetid: M:Microsoft.Web.PlatformInstaller.InstallManager.StartApplicationInstallation(System.String,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installmanager.startapplicationinstallation(v=VS.90)
ms:contentKeyID: 46408414
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- jscript
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallManager.StartApplicationInstallation
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# StartApplicationInstallation Method (, )

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicSubStartApplicationInstallation ( _
    configurationDirectoryAsString, _
    webServerDirectoryAsString _
)
'Usage
DiminstanceAsInstallManagerDimconfigurationDirectoryAsStringDimwebServerDirectoryAsString

instance.StartApplicationInstallation(configurationDirectory, _
    webServerDirectory)
```

``` csharp
publicvoidStartApplicationInstallation(
    stringconfigurationDirectory,
    stringwebServerDirectory
)
```

``` c++
public:
voidStartApplicationInstallation(
    String^ configurationDirectory, 
    String^ webServerDirectory
)
```

``` jscript
publicfunctionStartApplicationInstallation(
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

[InstallManager Class](installmanager-class-microsoft-web-platforminstaller.md)

[InstallManager Members](installmanager-members-microsoft-web-platforminstaller.md)

[StartApplicationInstallation Overload](installmanager-startapplicationinstallation-method-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

