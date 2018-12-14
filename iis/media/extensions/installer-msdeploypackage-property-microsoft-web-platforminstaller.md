---
title: Installer.MSDeployPackage Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: MSDeployPackage Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Installer.MSDeployPackage
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installer.msdeploypackage(v=VS.90)
ms:contentKeyID: 22049578
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Installer.MSDeployPackage
- Microsoft.Web.PlatformInstaller.Installer.get_MSDeployPackage
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Installer.get_MSDeployPackage
- Microsoft.Web.PlatformInstaller.Installer.MSDeployPackage
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# MSDeployPackage Property

Gets the [MSDeployPackage](msdeploypackage-class-microsoft-web-platforminstaller.md) associated with the current installer.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyMSDeployPackageAsMSDeployPackageGet
'Usage
DiminstanceAsInstallerDimvalueAsMSDeployPackagevalue = instance.MSDeployPackage
```

``` csharp
publicMSDeployPackageMSDeployPackage { get; }
```

``` c++
public:
propertyMSDeployPackage^ MSDeployPackage {
    MSDeployPackage^ get ();
}
```

``` jscript
function getMSDeployPackage () : MSDeployPackage
```

#### Property Value

Type: [Microsoft.Web.PlatformInstaller. . :: . .MSDeployPackage](msdeploypackage-class-microsoft-web-platforminstaller.md)  
An [MSDeployPackage](msdeploypackage-class-microsoft-web-platforminstaller.md) instance associated with the current installer.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Installer Class](installer-class-microsoft-web-platforminstaller.md)

[Installer Members](installer-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

