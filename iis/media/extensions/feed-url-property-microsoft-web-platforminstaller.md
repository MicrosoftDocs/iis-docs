---
title: Feed.Url Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Url Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Feed.Url
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.feed.url(v=VS.90)
ms:contentKeyID: 22049789
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Feed.Url
- Microsoft.Web.PlatformInstaller.Feed.get_Url
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Feed.get_Url
- Microsoft.Web.PlatformInstaller.Feed.Url
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Url Property

Gets the URL of the feed.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyUrlAsUriGet
'Usage
DiminstanceAsFeedDimvalueAsUrivalue = instance.Url
```

``` csharp
publicUriUrl { get; }
```

``` c++
public:
propertyUri^ Url {
    Uri^ get ();
}
```

``` jscript
function getUrl () : Uri
```

#### Property Value

Type: Uri  
A Uri that contains the URL of the feed.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Feed Class](feed-class-microsoft-web-platforminstaller.md)

[Feed Members](feed-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

