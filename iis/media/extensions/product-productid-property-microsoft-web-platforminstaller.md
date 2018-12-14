---
title: Product.ProductId Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: ProductId Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Product.ProductId
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.product.productid(v=VS.90)
ms:contentKeyID: 22049639
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Product.ProductId
- Microsoft.Web.PlatformInstaller.Product.get_ProductId
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Product.get_ProductId
- Microsoft.Web.PlatformInstaller.Product.ProductId
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ProductId Property

Gets a string that contains the unique product identifier.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyProductIdAsStringGet
'Usage
DiminstanceAsProductDimvalueAsStringvalue = instance.ProductId
```

``` csharp
publicstringProductId { get; }
```

``` c++
public:
propertyString^ ProductId {
    String^ get ();
}
```

``` jscript
function getProductId () : String
```

#### Property Value

Type: String  
A string that contains the unique product identifier.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Product Class](product-class-microsoft-web-platforminstaller.md)

[Product Members](product-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

