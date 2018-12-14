---
title: Terms.TermsText Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: TermsText Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Terms.TermsText
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.terms.termstext(v=VS.90)
ms:contentKeyID: 22049564
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Terms.TermsText
- Microsoft.Web.PlatformInstaller.Terms.get_TermsText
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Terms.get_TermsText
- Microsoft.Web.PlatformInstaller.Terms.TermsText
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TermsText Property

Gets or sets the text of the software terms.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyTermsTextAsStringGet
'Usage
DiminstanceAsTermsDimvalueAsStringvalue = instance.TermsText
```

``` csharp
publicstringTermsText { get; }
```

``` c++
public:
propertyString^ TermsText {
    String^ get ();
}
```

``` jscript
function getTermsText () : String
```

#### Property Value

Type: String  
A string that represents the software terms for the software to be installed by Web Platform Installer.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Terms Class](terms-class-microsoft-web-platforminstaller.md)

[Terms Members](terms-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

