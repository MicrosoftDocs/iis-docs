---
title: RewriteTemplateFeature Constructor (Module, String, String, RewriteTemplateCategory) (Microsoft.Web.Management.Iis.Rewrite)
TOCTitle: RewriteTemplateFeature Constructor (Module, String, String, RewriteTemplateCategory)
ms:assetid: M:Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.#ctor(Microsoft.Web.Management.Client.Module,System.String,System.String,Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateCategory)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.iis.rewrite.rewritetemplatefeature.rewritetemplatefeature(v=VS.90)
ms:contentKeyID: 46408198
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- jscript
api_location:
- Microsoft.Web.Management.Rewrite.Client.dll
api_name:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# RewriteTemplateFeature Constructor (Module, String, String, RewriteTemplateCategory)

Creates an instance of a [RewriteTemplateFeature](rewritetemplatefeature-class-microsoft-web-management-iis-rewrite.md) object with the given module, title, description, small image and rewrite template category.

**Namespace:**  [Microsoft.Web.Management.Iis.Rewrite](microsoft-web-management-iis-rewrite-namespace.md)  
**Assembly:**  Microsoft.Web.Management.Rewrite.Client (in Microsoft.Web.Management.Rewrite.Client.dll)

## Syntax

``` vb
'Declaration
ProtectedSubNew ( _
    moduleAsModule, _
    titleAsString, _
    descriptionAsString, _
    categoryAsRewriteTemplateCategory _
)
'Usage
DimmoduleAs [Module]
DimtitleAsStringDimdescriptionAsStringDimcategoryAsRewriteTemplateCategoryDiminstanceAs NewRewriteTemplateFeature(module, _
    title, description, category)
```

``` csharp
protectedRewriteTemplateFeature(
    Modulemodule,
    stringtitle,
    stringdescription,
    RewriteTemplateCategorycategory
)
```

``` c++
protected:
RewriteTemplateFeature(
    Module^ module, 
    String^ title, 
    String^ description, 
    RewriteTemplateCategory^ category
)
```

``` jscript
protectedfunctionRewriteTemplateFeature(
    module : Module, 
    title : String, 
    description : String, 
    category : RewriteTemplateCategory
)
```

#### Parameters

  - module  
    Type: [Microsoft.Web.Management.Client. . :: . .Module](https://msdn.microsoft.com/en-us/library/ms634308\(v=vs.90\))  
    A [Module](https://msdn.microsoft.com/en-us/library/ms634308\(v=vs.90\)) object.  

<!-- end list -->

  - title  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    A string value that contains the title.  

<!-- end list -->

  - description  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    A string value that contains the description.  

<!-- end list -->

  - category  
    Type: [Microsoft.Web.Management.Iis.Rewrite. . :: . .RewriteTemplateCategory](rewritetemplatecategory-class-microsoft-web-management-iis-rewrite.md)  
    A [RewriteTemplateCategory](rewritetemplatecategory-class-microsoft-web-management-iis-rewrite.md) object.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[RewriteTemplateFeature Class](rewritetemplatefeature-class-microsoft-web-management-iis-rewrite.md)

[RewriteTemplateFeature Overload](rewritetemplatefeature-constructor-microsoft-web-management-iis-rewrite.md)

[Microsoft.Web.Management.Iis.Rewrite Namespace](microsoft-web-management-iis-rewrite-namespace.md)

