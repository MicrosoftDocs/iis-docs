---
title: Tab.FeedList Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: FeedList Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Tab.FeedList
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.tab.feedlist(v=VS.90)
ms:contentKeyID: 26179793
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Tab.FeedList
- Microsoft.Web.PlatformInstaller.Tab.get_FeedList
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Tab.FeedList
- Microsoft.Web.PlatformInstaller.Tab.get_FeedList
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# FeedList Property

Gets a collection of [Feed](feed-class-microsoft-web-platforminstaller.md) objects.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyFeedListAsICollection(OfString)
    Get
'Usage
DiminstanceAsTabDimvalueAsICollection(OfString)

value = instance.FeedList
```

``` csharp
publicICollection<string> FeedList { get; }
```

``` c++
public:
propertyICollection<String^>^ FeedList {
    ICollection<String^>^ get ();
}
```

``` jscript
function getFeedList () : ICollection<String>
```

#### Property Value

Type: ICollection\< (Of \< ( \<'String\> ) \> ) \>  
A generic collection of [Feed](feed-class-microsoft-web-platforminstaller.md) objects.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Tab Class](tab-class-microsoft-web-platforminstaller.md)

[Tab Members](tab-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

