---
title: Product.RelatedProducts Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: RelatedProducts Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Product.RelatedProducts
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.product.relatedproducts(v=VS.90)
ms:contentKeyID: 22049533
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Product.RelatedProducts
- Microsoft.Web.PlatformInstaller.Product.get_RelatedProducts
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Product.get_RelatedProducts
- Microsoft.Web.PlatformInstaller.Product.RelatedProducts
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# RelatedProducts Property

Gets a read-only collection of products related to the current product.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyRelatedProductsAsReadOnlyCollection(OfRelatedProduct)
    Get
'Usage
DiminstanceAsProductDimvalueAsReadOnlyCollection(OfRelatedProduct)

value = instance.RelatedProducts
```

``` csharp
publicReadOnlyCollection<RelatedProduct> RelatedProducts { get; }
```

``` c++
public:
propertyReadOnlyCollection<RelatedProduct^>^ RelatedProducts {
    ReadOnlyCollection<RelatedProduct^>^ get ();
}
```

``` jscript
function getRelatedProducts () : ReadOnlyCollection<RelatedProduct>
```

#### Property Value

Type: ReadOnlyCollection\< (Of \< ( \<'[RelatedProduct](relatedproduct-class-microsoft-web-platforminstaller.md)\> ) \> ) \>  
A generic ReadOnlyCollection of [RelatedProduct](relatedproduct-class-microsoft-web-platforminstaller.md) instances.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Product Class](product-class-microsoft-web-platforminstaller.md)

[Product Members](product-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

