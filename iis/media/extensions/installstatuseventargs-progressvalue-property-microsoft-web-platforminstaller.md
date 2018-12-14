---
title: InstallStatusEventArgs.ProgressValue Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: ProgressValue Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.InstallStatusEventArgs.ProgressValue
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installstatuseventargs.progressvalue(v=VS.90)
ms:contentKeyID: 22049546
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallStatusEventArgs.ProgressValue
- Microsoft.Web.PlatformInstaller.InstallStatusEventArgs.get_ProgressValue
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallStatusEventArgs.get_ProgressValue
- Microsoft.Web.PlatformInstaller.InstallStatusEventArgs.ProgressValue
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ProgressValue Property

Gets an integer value representing the progress value.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyProgressValueAsIntegerGet
'Usage
DiminstanceAsInstallStatusEventArgsDimvalueAsIntegervalue = instance.ProgressValue
```

``` csharp
publicintProgressValue { get; }
```

``` c++
public:
propertyintProgressValue {
    intget ();
}
```

``` jscript
function getProgressValue () : int
```

#### Property Value

Type: Int32  
An integer value representing the progress value.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallStatusEventArgs Class](installstatuseventargs-class-microsoft-web-platforminstaller.md)

[InstallStatusEventArgs Members](installstatuseventargs-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

