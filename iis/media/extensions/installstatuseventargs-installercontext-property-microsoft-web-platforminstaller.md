---
title: InstallStatusEventArgs.InstallerContext Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: InstallerContext Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.InstallStatusEventArgs.InstallerContext
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installstatuseventargs.installercontext(v=VS.90)
ms:contentKeyID: 22049553
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallStatusEventArgs.InstallerContext
- Microsoft.Web.PlatformInstaller.InstallStatusEventArgs.get_InstallerContext
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallStatusEventArgs.get_InstallerContext
- Microsoft.Web.PlatformInstaller.InstallStatusEventArgs.InstallerContext
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# InstallerContext Property

Gets the context of the installer this event represents.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyInstallerContextAsInstallerContextGet
'Usage
DiminstanceAsInstallStatusEventArgsDimvalueAsInstallerContextvalue = instance.InstallerContext
```

``` csharp
publicInstallerContextInstallerContext { get; }
```

``` c++
public:
propertyInstallerContext^ InstallerContext {
    InstallerContext^ get ();
}
```

``` jscript
function getInstallerContext () : InstallerContext
```

#### Property Value

Type: [Microsoft.Web.PlatformInstaller. . :: . .InstallerContext](installercontext-class-microsoft-web-platforminstaller.md)  
An [InstallerContext](installercontext-class-microsoft-web-platforminstaller.md) instance.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallStatusEventArgs Class](installstatuseventargs-class-microsoft-web-platforminstaller.md)

[InstallStatusEventArgs Members](installstatuseventargs-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

