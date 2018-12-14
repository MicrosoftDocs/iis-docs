---
title: PreferenceSettings.Feeds Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Feeds Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.PreferenceSettings.Feeds
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.preferencesettings.feeds(v=VS.90)
ms:contentKeyID: 22049740
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.PreferenceSettings.Feeds
- Microsoft.Web.PlatformInstaller.PreferenceSettings.get_Feeds
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.PreferenceSettings.Feeds
- Microsoft.Web.PlatformInstaller.PreferenceSettings.get_Feeds
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Feeds Property

Gets a read-only collection of feeds for the Web Platform Installer.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyFeedsAsReadOnlyCollection(OfFeed)
    Get
'Usage
DiminstanceAsPreferenceSettingsDimvalueAsReadOnlyCollection(OfFeed)

value = instance.Feeds
```

``` csharp
publicReadOnlyCollection<Feed> Feeds { get; }
```

``` c++
public:
propertyReadOnlyCollection<Feed^>^ Feeds {
    ReadOnlyCollection<Feed^>^ get ();
}
```

``` jscript
function getFeeds () : ReadOnlyCollection<Feed>
```

#### Property Value

Type: ReadOnlyCollection\< (Of \< ( \<'[Feed](feed-class-microsoft-web-platforminstaller.md)\> ) \> ) \>  
A generic ReadOnlyCollection of [Feed](feed-class-microsoft-web-platforminstaller.md) objects.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[PreferenceSettings Class](preferencesettings-class-microsoft-web-platforminstaller.md)

[PreferenceSettings Members](preferencesettings-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

