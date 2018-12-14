---
title: Terms.TermsLink Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: TermsLink Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Terms.TermsLink
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.terms.termslink(v=VS.90)
ms:contentKeyID: 22049744
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Terms.TermsLink
- Microsoft.Web.PlatformInstaller.Terms.get_TermsLink
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Terms.get_TermsLink
- Microsoft.Web.PlatformInstaller.Terms.TermsLink
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TermsLink Property

Gets or sets a link to provide additional information about the software terms.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyTermsLinkAsStringGet
'Usage
DiminstanceAsTermsDimvalueAsStringvalue = instance.TermsLink
```

``` csharp
publicstringTermsLink { get; }
```

``` c++
public:
propertyString^ TermsLink {
    String^ get ();
}
```

``` jscript
function getTermsLink () : String
```

#### Property Value

Type: String  
A string that contains the URL to get more information about the software terms.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Terms Class](terms-class-microsoft-web-platforminstaller.md)

[Terms Members](terms-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

