---
title: Product.LongDescription Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: LongDescription Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Product.LongDescription
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.product.longdescription(v=VS.90)
ms:contentKeyID: 22049670
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Product.LongDescription
- Microsoft.Web.PlatformInstaller.Product.get_LongDescription
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Product.get_LongDescription
- Microsoft.Web.PlatformInstaller.Product.LongDescription
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# LongDescription Property

Gets a string that contains a long description of the product.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyLongDescriptionAsStringGet
'Usage
DiminstanceAsProductDimvalueAsStringvalue = instance.LongDescription
```

``` csharp
publicstringLongDescription { get; }
```

``` c++
public:
propertyString^ LongDescription {
    String^ get ();
}
```

``` jscript
function getLongDescription () : String
```

#### Property Value

Type: String  
A string that contains a long description of the product.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Product Class](product-class-microsoft-web-platforminstaller.md)

[Product Members](product-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

