---
title: InstallerFile.SHA1Hash Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: SHA1Hash Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.InstallerFile.SHA1Hash
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installerfile.sha1hash(v=VS.90)
ms:contentKeyID: 22049595
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallerFile.SHA1Hash
- Microsoft.Web.PlatformInstaller.InstallerFile.get_SHA1Hash
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallerFile.get_SHA1Hash
- Microsoft.Web.PlatformInstaller.InstallerFile.SHA1Hash
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SHA1Hash Property

Gets a string that contains the SHA1Hash of the current installer file.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertySHA1HashAsStringGet
'Usage
DiminstanceAsInstallerFileDimvalueAsStringvalue = instance.SHA1Hash
```

``` csharp
publicstringSHA1Hash { get; }
```

``` c++
public:
propertyString^ SHA1Hash {
    String^ get ();
}
```

``` jscript
function getSHA1Hash () : String
```

#### Property Value

Type: String  
A string that contains the SHA1Hash of the current installer file.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallerFile Class](installerfile-class-microsoft-web-platforminstaller.md)

[InstallerFile Members](installerfile-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

