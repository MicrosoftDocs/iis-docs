---
title: KeywordTab.Name Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Name Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.KeywordTab.Name
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.keywordtab.name(v=VS.90)
ms:contentKeyID: 22049704
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.KeywordTab.Name
- Microsoft.Web.PlatformInstaller.KeywordTab.get_Name
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.KeywordTab.get_Name
- Microsoft.Web.PlatformInstaller.KeywordTab.Name
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Name Property

Gets a string that contains the name of the current tab.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicOverridesReadOnlyPropertyNameAsStringGet
'Usage
DiminstanceAsKeywordTabDimvalueAsStringvalue = instance.Name
```

``` csharp
publicoverridestringName { get; }
```

``` c++
public:
virtualpropertyString^ Name {
    String^ get () override;
}
```

``` jscript
overridefunction getName () : String
```

#### Property Value

Type: String  
A string that contains the name of the current tab.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[KeywordTab Class](keywordtab-class-microsoft-web-platforminstaller.md)

[KeywordTab Members](keywordtab-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

