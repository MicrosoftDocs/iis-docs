---
title: RewriteTemplateFeature.Module Property  (Microsoft.Web.Management.Iis.Rewrite)
TOCTitle: Module Property
ms:assetid: P:Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.Module
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.iis.rewrite.rewritetemplatefeature.module(v=VS.90)
ms:contentKeyID: 20476329
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.Module
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.get_Module
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.Rewrite.Client.dll
api_name:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.get_Module
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.Module
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Module Property

Gets the client-side user interface module that this feature uses.

**Namespace:**  [Microsoft.Web.Management.Iis.Rewrite](microsoft-web-management-iis-rewrite-namespace.md)  
**Assembly:**  Microsoft.Web.Management.Rewrite.Client (in Microsoft.Web.Management.Rewrite.Client.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyModuleAsModule
'Usage
DiminstanceAsRewriteTemplateFeatureDimvalueAs [Module]

value = instance.Module
```

``` csharp
publicModuleModule { get; }
```

``` c++
public:
propertyModule^ Module {
    Module^ get ();
}
```

``` jscript
function getModule () : Module
```

#### Property Value

Type: [Microsoft.Web.Management.Client. . :: . .Module](https://msdn.microsoft.com/en-us/library/ms634308\(v=vs.90\))  
A Module object that represents the current user interface module for this feature.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[RewriteTemplateFeature Class](rewritetemplatefeature-class-microsoft-web-management-iis-rewrite.md)

[Microsoft.Web.Management.Iis.Rewrite Namespace](microsoft-web-management-iis-rewrite-namespace.md)

