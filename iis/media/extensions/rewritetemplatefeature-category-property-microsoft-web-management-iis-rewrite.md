---
title: RewriteTemplateFeature.Category Property  (Microsoft.Web.Management.Iis.Rewrite)
TOCTitle: Category Property
ms:assetid: P:Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.Category
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.iis.rewrite.rewritetemplatefeature.category(v=VS.90)
ms:contentKeyID: 22049456
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.Category
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.get_Category
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.Rewrite.Client.dll
api_name:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.Category
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.get_Category
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Category Property

Gets the [RewriteTemplateCategory](rewritetemplatecategory-class-microsoft-web-management-iis-rewrite.md) of the [RewriteTemplateFeature](rewritetemplatefeature-class-microsoft-web-management-iis-rewrite.md) object.

**Namespace:**  [Microsoft.Web.Management.Iis.Rewrite](microsoft-web-management-iis-rewrite-namespace.md)  
**Assembly:**  Microsoft.Web.Management.Rewrite.Client (in Microsoft.Web.Management.Rewrite.Client.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyCategoryAsRewriteTemplateCategory
'Usage
DiminstanceAsRewriteTemplateFeatureDimvalueAsRewriteTemplateCategoryvalue = instance.Category
```

``` csharp
publicRewriteTemplateCategoryCategory { get; }
```

``` c++
public:
propertyRewriteTemplateCategory^ Category {
    RewriteTemplateCategory^ get ();
}
```

``` jscript
function getCategory () : RewriteTemplateCategory
```

#### Property Value

Type: [Microsoft.Web.Management.Iis.Rewrite. . :: . .RewriteTemplateCategory](rewritetemplatecategory-class-microsoft-web-management-iis-rewrite.md)  
A [RewriteTemplateCategory](rewritetemplatecategory-class-microsoft-web-management-iis-rewrite.md) object.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[RewriteTemplateFeature Class](rewritetemplatefeature-class-microsoft-web-management-iis-rewrite.md)

[Microsoft.Web.Management.Iis.Rewrite Namespace](microsoft-web-management-iis-rewrite-namespace.md)

