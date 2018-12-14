---
title: Product.FeedLocation Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: FeedLocation Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Product.FeedLocation
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.product.feedlocation(v=VS.90)
ms:contentKeyID: 26179736
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Product.FeedLocation
- Microsoft.Web.PlatformInstaller.Product.get_FeedLocation
- Microsoft.Web.PlatformInstaller.Product.set_FeedLocation
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Product.FeedLocation
- Microsoft.Web.PlatformInstaller.Product.get_FeedLocation
- Microsoft.Web.PlatformInstaller.Product.set_FeedLocation
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# FeedLocation Property

Gets or sets the location of the feed.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicPropertyFeedLocationAsStringGetFriendSet
'Usage
DiminstanceAsProductDimvalueAsStringvalue = instance.FeedLocation
```

``` csharp
publicstringFeedLocation { get; internalset; }
```

``` c++
public:
propertyString^ FeedLocation {
    String^ get ();
    internal: voidset (String^ value);
}
```

``` jscript
function getFeedLocation () : Stringinternalfunction setFeedLocation (value : String)
```

#### Property Value

Type: String  
A string value that specifies the location.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Product Class](product-class-microsoft-web-platforminstaller.md)

[Product Members](product-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

