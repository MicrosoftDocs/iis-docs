---
title: InstallerFile.FileSize Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: FileSize Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.InstallerFile.FileSize
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installerfile.filesize(v=VS.90)
ms:contentKeyID: 22049708
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallerFile.FileSize
- Microsoft.Web.PlatformInstaller.InstallerFile.get_FileSize
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallerFile.FileSize
- Microsoft.Web.PlatformInstaller.InstallerFile.get_FileSize
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# FileSize Property

Gets an integer value that represents the size of the installer file.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyFileSizeAsIntegerGet
'Usage
DiminstanceAsInstallerFileDimvalueAsIntegervalue = instance.FileSize
```

``` csharp
publicintFileSize { get; }
```

``` c++
public:
propertyintFileSize {
    intget ();
}
```

``` jscript
function getFileSize () : int
```

#### Property Value

Type: Int32  
An integer value that represents the size of the installer file.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallerFile Class](installerfile-class-microsoft-web-platforminstaller.md)

[InstallerFile Members](installerfile-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

