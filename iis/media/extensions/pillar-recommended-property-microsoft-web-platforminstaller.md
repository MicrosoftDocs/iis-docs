---
title: Pillar.Recommended Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Recommended Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Pillar.Recommended
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.pillar.recommended(v=VS.90)
ms:contentKeyID: 22049525
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Pillar.Recommended
- Microsoft.Web.PlatformInstaller.Pillar.get_Recommended
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Pillar.get_Recommended
- Microsoft.Web.PlatformInstaller.Pillar.Recommended
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Recommended Property

Gets a read-only collection of products that are recommended.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyRecommendedAsReadOnlyCollection(OfProduct)
    Get
'Usage
DiminstanceAsPillarDimvalueAsReadOnlyCollection(OfProduct)

value = instance.Recommended
```

``` csharp
publicReadOnlyCollection<Product> Recommended { get; }
```

``` c++
public:
propertyReadOnlyCollection<Product^>^ Recommended {
    ReadOnlyCollection<Product^>^ get ();
}
```

``` jscript
function getRecommended () : ReadOnlyCollection<Product>
```

#### Property Value

Type: ReadOnlyCollection\< (Of \< ( \<'[Product](product-class-microsoft-web-platforminstaller.md)\> ) \> ) \>  
A generic ReadOnlyCollection of [Product](product-class-microsoft-web-platforminstaller.md) objects.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Pillar Class](pillar-class-microsoft-web-platforminstaller.md)

[Pillar Members](pillar-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

