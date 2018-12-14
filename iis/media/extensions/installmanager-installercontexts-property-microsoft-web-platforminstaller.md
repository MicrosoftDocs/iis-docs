---
title: InstallManager.InstallerContexts Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: InstallerContexts Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.InstallManager.InstallerContexts
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installmanager.installercontexts(v=VS.90)
ms:contentKeyID: 22049524
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallManager.InstallerContexts
- Microsoft.Web.PlatformInstaller.InstallManager.get_InstallerContexts
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallManager.get_InstallerContexts
- Microsoft.Web.PlatformInstaller.InstallManager.InstallerContexts
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# InstallerContexts Property

Gets a read-only collection of installer context objects.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyInstallerContextsAsReadOnlyCollection(OfInstallerContext)
    Get
'Usage
DiminstanceAsInstallManagerDimvalueAsReadOnlyCollection(OfInstallerContext)

value = instance.InstallerContexts
```

``` csharp
publicReadOnlyCollection<InstallerContext> InstallerContexts { get; }
```

``` c++
public:
propertyReadOnlyCollection<InstallerContext^>^ InstallerContexts {
    ReadOnlyCollection<InstallerContext^>^ get ();
}
```

``` jscript
function getInstallerContexts () : ReadOnlyCollection<InstallerContext>
```

#### Property Value

Type: ReadOnlyCollection\< (Of \< ( \<'[InstallerContext](installercontext-class-microsoft-web-platforminstaller.md)\> ) \> ) \>  
A generic ReadOnlyCollection of [InstallerContext](installercontext-class-microsoft-web-platforminstaller.md) objects.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallManager Class](installmanager-class-microsoft-web-platforminstaller.md)

[InstallManager Members](installmanager-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

