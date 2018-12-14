---
title: MSDeployPackage.PackageLocation Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: PackageLocation Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.MSDeployPackage.PackageLocation
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.msdeploypackage.packagelocation(v=VS.90)
ms:contentKeyID: 22049787
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.MSDeployPackage.PackageLocation
- Microsoft.Web.PlatformInstaller.MSDeployPackage.get_PackageLocation
- Microsoft.Web.PlatformInstaller.MSDeployPackage.set_PackageLocation
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.MSDeployPackage.get_PackageLocation
- Microsoft.Web.PlatformInstaller.MSDeployPackage.PackageLocation
- Microsoft.Web.PlatformInstaller.MSDeployPackage.set_PackageLocation
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# PackageLocation Property

Gets or sets a string that contains the location of the package to install.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicPropertyPackageLocationAsStringGetFriendSet
'Usage
DiminstanceAsMSDeployPackageDimvalueAsStringvalue = instance.PackageLocation
```

``` csharp
publicstringPackageLocation { get; internalset; }
```

``` c++
public:
propertyString^ PackageLocation {
    String^ get ();
    internal: voidset (String^ value);
}
```

``` jscript
function getPackageLocation () : Stringinternalfunction setPackageLocation (value : String)
```

#### Property Value

Type: String  
A string that contains the location of the package to install.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[MSDeployPackage Class](msdeploypackage-class-microsoft-web-platforminstaller.md)

[MSDeployPackage Members](msdeploypackage-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

