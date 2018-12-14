---
title: PreferenceSettings.Text Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Text Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.PreferenceSettings.Text
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.preferencesettings.text(v=VS.90)
ms:contentKeyID: 22049779
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.PreferenceSettings.Text
- Microsoft.Web.PlatformInstaller.PreferenceSettings.get_Text
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.PreferenceSettings.get_Text
- Microsoft.Web.PlatformInstaller.PreferenceSettings.Text
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Text Property

Gets a string that contains text for the preferences.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyTextAsStringGet
'Usage
DiminstanceAsPreferenceSettingsDimvalueAsStringvalue = instance.Text
```

``` csharp
publicstringText { get; }
```

``` c++
public:
propertyString^ Text {
    String^ get ();
}
```

``` jscript
function getText () : String
```

#### Property Value

Type: String  
A string that contains text for the preferences.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[PreferenceSettings Class](preferencesettings-class-microsoft-web-platforminstaller.md)

[PreferenceSettings Members](preferencesettings-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

