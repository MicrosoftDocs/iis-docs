---
title: Product.Author Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Author Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Product.Author
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.product.author(v=VS.90)
ms:contentKeyID: 22049555
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Product.Author
- Microsoft.Web.PlatformInstaller.Product.get_Author
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Product.Author
- Microsoft.Web.PlatformInstaller.Product.get_Author
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Author Property

Gets a string that contains the name of author.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyAuthorAsStringGet
'Usage
DiminstanceAsProductDimvalueAsStringvalue = instance.Author
```

``` csharp
publicstringAuthor { get; }
```

``` c++
public:
propertyString^ Author {
    String^ get ();
}
```

``` jscript
function getAuthor () : String
```

#### Property Value

Type: String  
A string that contains the name of the author.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Product Class](product-class-microsoft-web-platforminstaller.md)

[Product Members](product-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

