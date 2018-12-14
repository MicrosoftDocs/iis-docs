---
title: Product.Published Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Published Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Product.Published
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.product.published(v=VS.90)
ms:contentKeyID: 22049591
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Product.Published
- Microsoft.Web.PlatformInstaller.Product.get_Published
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Product.get_Published
- Microsoft.Web.PlatformInstaller.Product.Published
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Published Property

Gets the date and time that the product was published.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyPublishedAsDateTimeGet
'Usage
DiminstanceAsProductDimvalueAsDateTimevalue = instance.Published
```

``` csharp
publicDateTimePublished { get; }
```

``` c++
public:
propertyDateTimePublished {
    DateTimeget ();
}
```

``` jscript
function getPublished () : DateTime
```

#### Property Value

Type: DateTime  
A DateTime that indicates when the product was published.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Product Class](product-class-microsoft-web-platforminstaller.md)

[Product Members](product-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

