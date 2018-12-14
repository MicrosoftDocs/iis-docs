---
title: RewriteTemplateFeature.Title Property  (Microsoft.Web.Management.Iis.Rewrite)
TOCTitle: Title Property
ms:assetid: P:Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.Title
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.iis.rewrite.rewritetemplatefeature.title(v=VS.90)
ms:contentKeyID: 20476362
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.Title
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.get_Title
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.Rewrite.Client.dll
api_name:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.get_Title
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.Title
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Title Property

Gets the title displayed on the client-side user interface for this feature.

**Namespace:**  [Microsoft.Web.Management.Iis.Rewrite](microsoft-web-management-iis-rewrite-namespace.md)  
**Assembly:**  Microsoft.Web.Management.Rewrite.Client (in Microsoft.Web.Management.Rewrite.Client.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyTitleAsString
'Usage
DiminstanceAsRewriteTemplateFeatureDimvalueAsStringvalue = instance.Title
```

``` csharp
publicstringTitle { get; }
```

``` c++
public:
propertyString^ Title {
    String^ get ();
}
```

``` jscript
function getTitle () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the title displayed on the client-side user interface for this feature.  

## Remarks

The value of this property is passed to the current instance in the constructor.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[RewriteTemplateFeature Class](rewritetemplatefeature-class-microsoft-web-management-iis-rewrite.md)

[Microsoft.Web.Management.Iis.Rewrite Namespace](microsoft-web-management-iis-rewrite-namespace.md)

