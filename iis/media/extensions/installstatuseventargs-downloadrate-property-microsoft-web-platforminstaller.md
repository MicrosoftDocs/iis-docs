---
title: InstallStatusEventArgs.DownloadRate Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: DownloadRate Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.InstallStatusEventArgs.DownloadRate
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installstatuseventargs.downloadrate(v=VS.90)
ms:contentKeyID: 22049510
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallStatusEventArgs.DownloadRate
- Microsoft.Web.PlatformInstaller.InstallStatusEventArgs.get_DownloadRate
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallStatusEventArgs.DownloadRate
- Microsoft.Web.PlatformInstaller.InstallStatusEventArgs.get_DownloadRate
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DownloadRate Property

Gets an integer value representing the download rate of the installer.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyDownloadRateAsIntegerGet
'Usage
DiminstanceAsInstallStatusEventArgsDimvalueAsIntegervalue = instance.DownloadRate
```

``` csharp
publicintDownloadRate { get; }
```

``` c++
public:
propertyintDownloadRate {
    intget ();
}
```

``` jscript
function getDownloadRate () : int
```

#### Property Value

Type: Int32  
An integer value representing the download rate of the installer.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallStatusEventArgs Class](installstatuseventargs-class-microsoft-web-platforminstaller.md)

[InstallStatusEventArgs Members](installstatuseventargs-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

