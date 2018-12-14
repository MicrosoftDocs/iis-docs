---
title: Product.AuthorUri Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: AuthorUri Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Product.AuthorUri
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.product.authoruri(v=VS.90)
ms:contentKeyID: 22049763
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Product.AuthorUri
- Microsoft.Web.PlatformInstaller.Product.get_AuthorUri
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Product.AuthorUri
- Microsoft.Web.PlatformInstaller.Product.get_AuthorUri
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# AuthorUri Property

Gets a Uri to additional information about the author of the current product.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyAuthorUriAsUriGet
'Usage
DiminstanceAsProductDimvalueAsUrivalue = instance.AuthorUri
```

``` csharp
publicUriAuthorUri { get; }
```

``` c++
public:
propertyUri^ AuthorUri {
    Uri^ get ();
}
```

``` jscript
function getAuthorUri () : Uri
```

#### Property Value

Type: Uri  
A Uri instance.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Product Class](product-class-microsoft-web-platforminstaller.md)

[Product Members](product-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

