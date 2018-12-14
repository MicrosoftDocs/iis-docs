---
title: Product.Terms Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Terms Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Product.Terms
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.product.terms(v=VS.90)
ms:contentKeyID: 22049773
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Product.Terms
- Microsoft.Web.PlatformInstaller.Product.get_Terms
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Product.get_Terms
- Microsoft.Web.PlatformInstaller.Product.Terms
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Terms Property

Gets a read-only collection of terms for the current product.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyTermsAsReadOnlyCollection(OfTerms)
    Get
'Usage
DiminstanceAsProductDimvalueAsReadOnlyCollection(OfTerms)

value = instance.Terms
```

``` csharp
publicReadOnlyCollection<Terms> Terms { get; }
```

``` c++
public:
propertyReadOnlyCollection<Terms^>^ Terms {
    ReadOnlyCollection<Terms^>^ get ();
}
```

``` jscript
function getTerms () : ReadOnlyCollection<Terms>
```

#### Property Value

Type: ReadOnlyCollection\< (Of \< ( \<'[Terms](terms-class-microsoft-web-platforminstaller.md)\> ) \> ) \>  
A generic ReadOnlyCollection of [Terms](terms-class-microsoft-web-platforminstaller.md) objects.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Product Class](product-class-microsoft-web-platforminstaller.md)

[Product Members](product-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

