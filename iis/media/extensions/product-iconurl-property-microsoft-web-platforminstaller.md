---
title: Product.IconUrl Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: IconUrl Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Product.IconUrl
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.product.iconurl(v=VS.90)
ms:contentKeyID: 22049539
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Product.IconUrl
- Microsoft.Web.PlatformInstaller.Product.get_IconUrl
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Product.get_IconUrl
- Microsoft.Web.PlatformInstaller.Product.IconUrl
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IconUrl Property

Gets a Uri to the icon for the current product.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyIconUrlAsUriGet
'Usage
DiminstanceAsProductDimvalueAsUrivalue = instance.IconUrl
```

``` csharp
publicUriIconUrl { get; }
```

``` c++
public:
propertyUri^ IconUrl {
    Uri^ get ();
}
```

``` jscript
function getIconUrl () : Uri
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

