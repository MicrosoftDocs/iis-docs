---
title: InstallCommand Constructor  (Microsoft.Web.PlatformInstaller)
TOCTitle: InstallCommand Constructor
ms:assetid: M:Microsoft.Web.PlatformInstaller.InstallCommand.#ctor(Microsoft.Web.PlatformInstaller.Installer)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installcommand.installcommand(v=VS.90)
ms:contentKeyID: 22049715
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallCommand.InstallCommand
- Microsoft.Web.PlatformInstaller.InstallCommand.#ctor
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallCommand..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# InstallCommand Constructor

Creates an instance of an [InstallCommand](installcommand-class-microsoft-web-platforminstaller.md) object for a given [Installer](installer-class-microsoft-web-platforminstaller.md) instance.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
ProtectedSubNew ( _
    installerAsInstaller _
)
'Usage
DiminstallerAsInstallerDiminstanceAs NewInstallCommand(installer)
```

``` csharp
protectedInstallCommand(
    Installerinstaller
)
```

``` c++
protected:
InstallCommand(
    Installer^ installer
)
```

``` jscript
protectedfunctionInstallCommand(
    installer : Installer
)
```

#### Parameters

  - installer  
    Type: [Microsoft.Web.PlatformInstaller. . :: . .Installer](installer-class-microsoft-web-platforminstaller.md)  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallCommand Class](installcommand-class-microsoft-web-platforminstaller.md)

[InstallCommand Members](installcommand-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

