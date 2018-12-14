---
title: InstallCommand.Installer Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Installer Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.InstallCommand.Installer
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installcommand.installer(v=VS.90)
ms:contentKeyID: 22195869
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallCommand.Installer
- Microsoft.Web.PlatformInstaller.InstallCommand.get_Installer
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallCommand.get_Installer
- Microsoft.Web.PlatformInstaller.InstallCommand.Installer
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Installer Property

Gets a reference to the [Installer](installer-class-microsoft-web-platforminstaller.md) object for this [InstallCommand](installcommand-class-microsoft-web-platforminstaller.md) instance.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
ProtectedReadOnlyPropertyInstallerAsInstallerGet
'Usage
DimvalueAsInstallervalue = Me.Installer
```

``` csharp
protectedInstallerInstaller { get; }
```

``` c++
protected:
propertyInstaller^ Installer {
    Installer^ get ();
}
```

``` jscript
function getInstaller () : Installer
```

#### Property Value

Type: [Microsoft.Web.PlatformInstaller. . :: . .Installer](installer-class-microsoft-web-platforminstaller.md)  
the [Installer](installer-class-microsoft-web-platforminstaller.md) object for this [InstallCommand](installcommand-class-microsoft-web-platforminstaller.md) instance.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallCommand Class](installcommand-class-microsoft-web-platforminstaller.md)

[InstallCommand Members](installcommand-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

