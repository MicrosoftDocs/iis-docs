---
title: Installer.Product Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Product Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Installer.Product
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installer.product(v=VS.90)
ms:contentKeyID: 22049760
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Installer.Product
- Microsoft.Web.PlatformInstaller.Installer.get_Product
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Installer.get_Product
- Microsoft.Web.PlatformInstaller.Installer.Product
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Product Property

Gets the product associated with the current installer.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyProductAsProductGet
'Usage
DiminstanceAsInstallerDimvalueAsProductvalue = instance.Product
```

``` csharp
publicProductProduct { get; }
```

``` c++
public:
propertyProduct^ Product {
    Product^ get ();
}
```

``` jscript
function getProduct () : Product
```

#### Property Value

Type: [Microsoft.Web.PlatformInstaller. . :: . .Product](product-class-microsoft-web-platforminstaller.md)  
A [Product](product-class-microsoft-web-platforminstaller.md) instance.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Installer Class](installer-class-microsoft-web-platforminstaller.md)

[Installer Members](installer-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

