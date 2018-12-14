---
title: UpdateAvailableEventArgs.Caption Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Caption Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.UpdateAvailableEventArgs.Caption
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.updateavailableeventargs.caption(v=VS.90)
ms:contentKeyID: 22049681
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.UpdateAvailableEventArgs.Caption
- Microsoft.Web.PlatformInstaller.UpdateAvailableEventArgs.get_Caption
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.UpdateAvailableEventArgs.Caption
- Microsoft.Web.PlatformInstaller.UpdateAvailableEventArgs.get_Caption
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Caption Property

Gets a string that contains the caption to display.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyCaptionAsStringGet
'Usage
DiminstanceAsUpdateAvailableEventArgsDimvalueAsStringvalue = instance.Caption
```

``` csharp
publicstringCaption { get; }
```

``` c++
public:
propertyString^ Caption {
    String^ get ();
}
```

``` jscript
function getCaption () : String
```

#### Property Value

Type: String  
A string that contains a caption to display.  

## Remarks

The Caption and [Text](updateavailableeventargs-text-property-microsoft-web-platforminstaller.md) properties of the [UpdateAvailableEventArgs](updateavailableeventargs-class-microsoft-web-platforminstaller.md) class are displayed in dialog boxes when both the Caption and the [Text](updateavailableeventargs-text-property-microsoft-web-platforminstaller.md) values are not null Nothing nullptr unit a null reference (Nothing in Visual Basic) (Nothing in Visual Basic).

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[UpdateAvailableEventArgs Class](updateavailableeventargs-class-microsoft-web-platforminstaller.md)

[UpdateAvailableEventArgs Members](updateavailableeventargs-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

