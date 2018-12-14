---
title: Product.IsUpdate Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: IsUpdate Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Product.IsUpdate
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.product.isupdate(v=VS.90)
ms:contentKeyID: 22049726
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Product.IsUpdate
- Microsoft.Web.PlatformInstaller.Product.get_IsUpdate
- Microsoft.Web.PlatformInstaller.Product.set_IsUpdate
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Product.get_IsUpdate
- Microsoft.Web.PlatformInstaller.Product.IsUpdate
- Microsoft.Web.PlatformInstaller.Product.set_IsUpdate
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IsUpdate Property

Gets or sets a value that indicates whether the current product is an update.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicPropertyIsUpdateAsBooleanGetFriendSet
'Usage
DiminstanceAsProductDimvalueAsBooleanvalue = instance.IsUpdate
```

``` csharp
publicboolIsUpdate { get; internalset; }
```

``` c++
public:
propertyboolIsUpdate {
    boolget ();
    internal: voidset (boolvalue);
}
```

``` jscript
function getIsUpdate () : booleaninternalfunction setIsUpdate (value : boolean)
```

#### Property Value

Type: Boolean  
true if the product is an update to a previous version of a product, otherwise false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Product Class](product-class-microsoft-web-platforminstaller.md)

[Product Members](product-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

