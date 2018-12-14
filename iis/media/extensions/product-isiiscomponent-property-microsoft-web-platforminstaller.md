---
title: Product.IsIisComponent Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: IsIisComponent Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Product.IsIisComponent
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.product.isiiscomponent(v=VS.90)
ms:contentKeyID: 22049537
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Product.IsIisComponent
- Microsoft.Web.PlatformInstaller.Product.get_IsIisComponent
- Microsoft.Web.PlatformInstaller.Product.set_IsIisComponent
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Product.get_IsIisComponent
- Microsoft.Web.PlatformInstaller.Product.IsIisComponent
- Microsoft.Web.PlatformInstaller.Product.set_IsIisComponent
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IsIisComponent Property

Gets or sets a value that indicates whether the product is an IIS component.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicPropertyIsIisComponentAsBooleanGetFriendSet
'Usage
DiminstanceAsProductDimvalueAsBooleanvalue = instance.IsIisComponent
```

``` csharp
publicboolIsIisComponent { get; internalset; }
```

``` c++
public:
propertyboolIsIisComponent {
    boolget ();
    internal: voidset (boolvalue);
}
```

``` jscript
function getIsIisComponent () : booleaninternalfunction setIsIisComponent (value : boolean)
```

#### Property Value

Type: Boolean  
true if the product is an IIS component, otherwise false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Product Class](product-class-microsoft-web-platforminstaller.md)

[Product Members](product-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

