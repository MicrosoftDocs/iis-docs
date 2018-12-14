---
title: Installer.InstallCommands Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: InstallCommands Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Installer.InstallCommands
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installer.installcommands(v=VS.90)
ms:contentKeyID: 22049674
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Installer.InstallCommands
- Microsoft.Web.PlatformInstaller.Installer.get_InstallCommands
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Installer.get_InstallCommands
- Microsoft.Web.PlatformInstaller.Installer.InstallCommands
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# InstallCommands Property

Gets a read-only collection of installer commands for the current installer.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyInstallCommandsAsReadOnlyCollection(OfInstallCommand)
    Get
'Usage
DiminstanceAsInstallerDimvalueAsReadOnlyCollection(OfInstallCommand)

value = instance.InstallCommands
```

``` csharp
publicReadOnlyCollection<InstallCommand> InstallCommands { get; }
```

``` c++
public:
propertyReadOnlyCollection<InstallCommand^>^ InstallCommands {
    ReadOnlyCollection<InstallCommand^>^ get ();
}
```

``` jscript
function getInstallCommands () : ReadOnlyCollection<InstallCommand>
```

#### Property Value

Type: ReadOnlyCollection\< (Of \< ( \<'[InstallCommand](installcommand-class-microsoft-web-platforminstaller.md)\> ) \> ) \>  
A generic ReadOnlyCollection of [InstallCommand](installcommand-class-microsoft-web-platforminstaller.md) objects.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Installer Class](installer-class-microsoft-web-platforminstaller.md)

[Installer Members](installer-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

