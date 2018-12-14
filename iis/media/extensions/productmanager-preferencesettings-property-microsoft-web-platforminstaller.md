---
title: ProductManager.PreferenceSettings Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: PreferenceSettings Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.ProductManager.PreferenceSettings
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.productmanager.preferencesettings(v=VS.90)
ms:contentKeyID: 22049600
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.ProductManager.PreferenceSettings
- Microsoft.Web.PlatformInstaller.ProductManager.get_PreferenceSettings
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.ProductManager.get_PreferenceSettings
- Microsoft.Web.PlatformInstaller.ProductManager.PreferenceSettings
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# PreferenceSettings Property

Gets the preferences for the current [ProductManager](productmanager-class-microsoft-web-platforminstaller.md) instance.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyPreferenceSettingsAsPreferenceSettingsGet
'Usage
DiminstanceAsProductManagerDimvalueAsPreferenceSettingsvalue = instance.PreferenceSettings
```

``` csharp
publicPreferenceSettingsPreferenceSettings { get; }
```

``` c++
public:
propertyPreferenceSettings^ PreferenceSettings {
    PreferenceSettings^ get ();
}
```

``` jscript
function getPreferenceSettings () : PreferenceSettings
```

#### Property Value

Type: [Microsoft.Web.PlatformInstaller. . :: . .PreferenceSettings](preferencesettings-class-microsoft-web-platforminstaller.md)  
A [PreferenceSettings](preferencesettings-class-microsoft-web-platforminstaller.md) instance.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[ProductManager Class](productmanager-class-microsoft-web-platforminstaller.md)

[ProductManager Members](productmanager-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

[PreferenceSettings](preferencesettings-class-microsoft-web-platforminstaller.md)

