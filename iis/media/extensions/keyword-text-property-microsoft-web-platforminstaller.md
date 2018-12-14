---
title: Keyword.Text Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Text Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Keyword.Text
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.keyword.text(v=VS.90)
ms:contentKeyID: 22049768
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Keyword.Text
- Microsoft.Web.PlatformInstaller.Keyword.get_Text
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Keyword.get_Text
- Microsoft.Web.PlatformInstaller.Keyword.Text
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Text Property

Gets a string that contains text describing the current keyword.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyTextAsStringGet
'Usage
DiminstanceAsKeywordDimvalueAsStringvalue = instance.Text
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
A string that contains text describing the current keyword.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Keyword Class](keyword-class-microsoft-web-platforminstaller.md)

[Keyword Members](keyword-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

