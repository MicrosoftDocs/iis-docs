---
title: InstallManager.RebootRequired Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: RebootRequired Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.InstallManager.RebootRequired
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installmanager.rebootrequired(v=VS.90)
ms:contentKeyID: 22049778
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallManager.RebootRequired
- Microsoft.Web.PlatformInstaller.InstallManager.get_RebootRequired
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallManager.get_RebootRequired
- Microsoft.Web.PlatformInstaller.InstallManager.RebootRequired
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# RebootRequired Property

Gets a value that indicates whether a reboot is required.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyRebootRequiredAsBooleanGet
'Usage
DiminstanceAsInstallManagerDimvalueAsBooleanvalue = instance.RebootRequired
```

``` csharp
publicboolRebootRequired { get; }
```

``` c++
public:
propertyboolRebootRequired {
    boolget ();
}
```

``` jscript
function getRebootRequired () : boolean
```

#### Property Value

Type: Boolean  
true if a reboot is required, otherwise false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallManager Class](installmanager-class-microsoft-web-platforminstaller.md)

[InstallManager Members](installmanager-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

