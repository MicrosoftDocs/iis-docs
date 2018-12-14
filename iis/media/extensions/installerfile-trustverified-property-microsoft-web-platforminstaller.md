---
title: InstallerFile.TrustVerified Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: TrustVerified Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.InstallerFile.TrustVerified
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installerfile.trustverified(v=VS.90)
ms:contentKeyID: 22049601
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallerFile.TrustVerified
- Microsoft.Web.PlatformInstaller.InstallerFile.get_TrustVerified
- Microsoft.Web.PlatformInstaller.InstallerFile.set_TrustVerified
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallerFile.get_TrustVerified
- Microsoft.Web.PlatformInstaller.InstallerFile.set_TrustVerified
- Microsoft.Web.PlatformInstaller.InstallerFile.TrustVerified
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TrustVerified Property

Gets or sets a value that indicates whether the current installer file is trust verified.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicPropertyTrustVerifiedAsBooleanGetFriendSet
'Usage
DiminstanceAsInstallerFileDimvalueAsBooleanvalue = instance.TrustVerified
```

``` csharp
publicboolTrustVerified { get; internalset; }
```

``` c++
public:
propertyboolTrustVerified {
    boolget ();
    internal: voidset (boolvalue);
}
```

``` jscript
function getTrustVerified () : booleaninternalfunction setTrustVerified (value : boolean)
```

#### Property Value

Type: Boolean  
true if the current installer file is trust verified, otherwise false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallerFile Class](installerfile-class-microsoft-web-platforminstaller.md)

[InstallerFile Members](installerfile-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

