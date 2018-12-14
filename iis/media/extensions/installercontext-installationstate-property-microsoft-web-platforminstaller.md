---
title: InstallerContext.InstallationState Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: InstallationState Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.InstallerContext.InstallationState
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installercontext.installationstate(v=VS.90)
ms:contentKeyID: 22049791
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallerContext.InstallationState
- Microsoft.Web.PlatformInstaller.InstallerContext.get_InstallationState
- Microsoft.Web.PlatformInstaller.InstallerContext.set_InstallationState
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallerContext.get_InstallationState
- Microsoft.Web.PlatformInstaller.InstallerContext.InstallationState
- Microsoft.Web.PlatformInstaller.InstallerContext.set_InstallationState
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# InstallationState Property

Gets or sets the current state of the installation process.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicPropertyInstallationStateAsInstallationStateGetSet
'Usage
DiminstanceAsInstallerContextDimvalueAsInstallationStatevalue = instance.InstallationState

instance.InstallationState = value
```

``` csharp
publicInstallationStateInstallationState { get; set; }
```

``` c++
public:
propertyInstallationStateInstallationState {
    InstallationStateget ();
    voidset (InstallationStatevalue);
}
```

``` jscript
function getInstallationState () : InstallationStatefunction setInstallationState (value : InstallationState)
```

#### Property Value

Type: [Microsoft.Web.PlatformInstaller. . :: . .InstallationState](installationstate-enumeration-microsoft-web-platforminstaller.md)  
A valid value from the [InstallationState](installationstate-enumeration-microsoft-web-platforminstaller.md) enumeration.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallerContext Class](installercontext-class-microsoft-web-platforminstaller.md)

[InstallerContext Members](installercontext-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

