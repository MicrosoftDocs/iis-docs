---
title: UpdateAvailableEventArgs.Text Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Text Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.UpdateAvailableEventArgs.Text
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.updateavailableeventargs.text(v=VS.90)
ms:contentKeyID: 22049710
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.UpdateAvailableEventArgs.Text
- Microsoft.Web.PlatformInstaller.UpdateAvailableEventArgs.get_Text
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.UpdateAvailableEventArgs.get_Text
- Microsoft.Web.PlatformInstaller.UpdateAvailableEventArgs.Text
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Text Property

Gets a string that contains the text to display.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyTextAsStringGet
'Usage
DiminstanceAsUpdateAvailableEventArgsDimvalueAsStringvalue = instance.Text
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
A string that contains the text to display.  

## Remarks

The [Caption](updateavailableeventargs-caption-property-microsoft-web-platforminstaller.md) and Text properties of the [UpdateAvailableEventArgs](updateavailableeventargs-class-microsoft-web-platforminstaller.md) class are displayed in dialog boxes when both the [Caption](updateavailableeventargs-caption-property-microsoft-web-platforminstaller.md) and the Text values are not null Nothing nullptr unit a null reference (Nothing in Visual Basic) (Nothing in Visual Basic).

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[UpdateAvailableEventArgs Class](updateavailableeventargs-class-microsoft-web-platforminstaller.md)

[UpdateAvailableEventArgs Members](updateavailableeventargs-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

