---
title: InstallerFile.DownloadedLocation Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: DownloadedLocation Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.InstallerFile.DownloadedLocation
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installerfile.downloadedlocation(v=VS.90)
ms:contentKeyID: 22049631
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallerFile.DownloadedLocation
- Microsoft.Web.PlatformInstaller.InstallerFile.get_DownloadedLocation
- Microsoft.Web.PlatformInstaller.InstallerFile.set_DownloadedLocation
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallerFile.DownloadedLocation
- Microsoft.Web.PlatformInstaller.InstallerFile.get_DownloadedLocation
- Microsoft.Web.PlatformInstaller.InstallerFile.set_DownloadedLocation
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DownloadedLocation Property

Gets or sets a string that contains the downloaded location of the installer file.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicPropertyDownloadedLocationAsStringGetFriendSet
'Usage
DiminstanceAsInstallerFileDimvalueAsStringvalue = instance.DownloadedLocation
```

``` csharp
publicstringDownloadedLocation { get; internalset; }
```

``` c++
public:
propertyString^ DownloadedLocation {
    String^ get ();
    internal: voidset (String^ value);
}
```

``` jscript
function getDownloadedLocation () : Stringinternalfunction setDownloadedLocation (value : String)
```

#### Property Value

Type: String  
A string that contains the downloaded location of the installer file.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallerFile Class](installerfile-class-microsoft-web-platforminstaller.md)

[InstallerFile Members](installerfile-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

