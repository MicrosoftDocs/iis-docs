---
title: Installer.InstallerFile Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: InstallerFile Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Installer.InstallerFile
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installer.installerfile(v=VS.90)
ms:contentKeyID: 22049543
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Installer.InstallerFile
- Microsoft.Web.PlatformInstaller.Installer.get_InstallerFile
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Installer.get_InstallerFile
- Microsoft.Web.PlatformInstaller.Installer.InstallerFile
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# InstallerFile Property

Gets the installer file associated with the current installer.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyInstallerFileAsInstallerFileGet
'Usage
DiminstanceAsInstallerDimvalueAsInstallerFilevalue = instance.InstallerFile
```

``` csharp
publicInstallerFileInstallerFile { get; }
```

``` c++
public:
propertyInstallerFile^ InstallerFile {
    InstallerFile^ get ();
}
```

``` jscript
function getInstallerFile () : InstallerFile
```

#### Property Value

Type: [Microsoft.Web.PlatformInstaller. . :: . .InstallerFile](installerfile-class-microsoft-web-platforminstaller.md)  
An [InstallerFile](installerfile-class-microsoft-web-platforminstaller.md) instance.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Installer Class](installer-class-microsoft-web-platforminstaller.md)

[Installer Members](installer-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

