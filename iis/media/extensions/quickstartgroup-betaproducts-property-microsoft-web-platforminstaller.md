---
title: QuickStartGroup.BetaProducts Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: BetaProducts Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.QuickStartGroup.BetaProducts
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.quickstartgroup.betaproducts(v=VS.90)
ms:contentKeyID: 22753928
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.QuickStartGroup.BetaProducts
- Microsoft.Web.PlatformInstaller.QuickStartGroup.get_BetaProducts
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.QuickStartGroup.BetaProducts
- Microsoft.Web.PlatformInstaller.QuickStartGroup.get_BetaProducts
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# BetaProducts Property

Gets a read-only collection of product objects.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyBetaProductsAsReadOnlyCollection(OfProduct)
    Get
'Usage
DiminstanceAsQuickStartGroupDimvalueAsReadOnlyCollection(OfProduct)

value = instance.BetaProducts
```

``` csharp
publicReadOnlyCollection<Product> BetaProducts { get; }
```

``` c++
public:
propertyReadOnlyCollection<Product^>^ BetaProducts {
    ReadOnlyCollection<Product^>^ get ();
}
```

``` jscript
function getBetaProducts () : ReadOnlyCollection<Product>
```

#### Property Value

Type: ReadOnlyCollection\< (Of \< ( \<'[Product](product-class-microsoft-web-platforminstaller.md)\> ) \> ) \>  
A generic ReadOnlyCollection of [Product](product-class-microsoft-web-platforminstaller.md) objects.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[QuickStartGroup Class](quickstartgroup-class-microsoft-web-platforminstaller.md)

[QuickStartGroup Members](quickstartgroup-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

