---
title: QuickStartGroup.DevelopmentProducts Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: DevelopmentProducts Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.QuickStartGroup.DevelopmentProducts
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.quickstartgroup.developmentproducts(v=VS.90)
ms:contentKeyID: 22753898
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.QuickStartGroup.DevelopmentProducts
- Microsoft.Web.PlatformInstaller.QuickStartGroup.get_DevelopmentProducts
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.QuickStartGroup.DevelopmentProducts
- Microsoft.Web.PlatformInstaller.QuickStartGroup.get_DevelopmentProducts
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DevelopmentProducts Property

Gets a read-only collection of products.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyDevelopmentProductsAsReadOnlyCollection(OfProduct)
    Get
'Usage
DiminstanceAsQuickStartGroupDimvalueAsReadOnlyCollection(OfProduct)

value = instance.DevelopmentProducts
```

``` csharp
publicReadOnlyCollection<Product> DevelopmentProducts { get; }
```

``` c++
public:
propertyReadOnlyCollection<Product^>^ DevelopmentProducts {
    ReadOnlyCollection<Product^>^ get ();
}
```

``` jscript
function getDevelopmentProducts () : ReadOnlyCollection<Product>
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

