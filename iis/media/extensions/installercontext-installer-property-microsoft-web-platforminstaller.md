---
title: InstallerContext.Installer Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Installer Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.InstallerContext.Installer
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installercontext.installer(v=VS.90)
ms:contentKeyID: 22049695
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallerContext.Installer
- Microsoft.Web.PlatformInstaller.InstallerContext.get_Installer
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallerContext.get_Installer
- Microsoft.Web.PlatformInstaller.InstallerContext.Installer
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Installer Property

Gets the [Installer](installer-class-microsoft-web-platforminstaller.md) associated with the current context.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyInstallerAsInstallerGet
'Usage
DiminstanceAsInstallerContextDimvalueAsInstallervalue = instance.Installer
```

``` csharp
publicInstallerInstaller { get; }
```

``` c++
public:
propertyInstaller^ Installer {
    Installer^ get ();
}
```

``` jscript
function getInstaller () : Installer
```

#### Property Value

Type: [Microsoft.Web.PlatformInstaller. . :: . .Installer](installer-class-microsoft-web-platforminstaller.md)  
An [Installer](installer-class-microsoft-web-platforminstaller.md) instance.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallerContext Class](installercontext-class-microsoft-web-platforminstaller.md)

[InstallerContext Members](installercontext-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

