---
title: Product.Installers Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Installers Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Product.Installers
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.product.installers(v=VS.90)
ms:contentKeyID: 22049676
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Product.Installers
- Microsoft.Web.PlatformInstaller.Product.get_Installers
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Product.get_Installers
- Microsoft.Web.PlatformInstaller.Product.Installers
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Installers Property

Gets a read-only collection of installers for the current product.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyInstallersAsReadOnlyCollection(OfInstaller)
    Get
'Usage
DiminstanceAsProductDimvalueAsReadOnlyCollection(OfInstaller)

value = instance.Installers
```

``` csharp
publicReadOnlyCollection<Installer> Installers { get; }
```

``` c++
public:
propertyReadOnlyCollection<Installer^>^ Installers {
    ReadOnlyCollection<Installer^>^ get ();
}
```

``` jscript
function getInstallers () : ReadOnlyCollection<Installer>
```

#### Property Value

Type: ReadOnlyCollection\< (Of \< ( \<'[Installer](installer-class-microsoft-web-platforminstaller.md)\> ) \> ) \>  
A generic ReadOnlyCollection of [Installer](installer-class-microsoft-web-platforminstaller.md) instances.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Product Class](product-class-microsoft-web-platforminstaller.md)

[Product Members](product-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

