---
title: RewriteTemplateFeature.Run Method  (Microsoft.Web.Management.Iis.Rewrite)
TOCTitle: Run Method
ms:assetid: M:Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.Run
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.iis.rewrite.rewritetemplatefeature.run(v=VS.90)
ms:contentKeyID: 20476382
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.Run
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.Rewrite.Client.dll
api_name:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.Run
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Run Method

Runs the current feature.

**Namespace:**  [Microsoft.Web.Management.Iis.Rewrite](microsoft-web-management-iis-rewrite-namespace.md)  
**Assembly:**  Microsoft.Web.Management.Rewrite.Client (in Microsoft.Web.Management.Rewrite.Client.dll)

## Syntax

``` vb
'Declaration
PublicMustOverrideSubRun
'Usage
DiminstanceAsRewriteTemplateFeature

instance.Run()
```

``` csharp
publicabstractvoidRun()
```

``` c++
public:
virtualvoidRun() abstract
```

``` jscript
publicabstractfunctionRun()
```

## Remarks

This method is abstract (MustInherit in Visual Basic) and must be overridden. There is no default implementation, so inheriting classes do not need to call this base method.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[RewriteTemplateFeature Class](rewritetemplatefeature-class-microsoft-web-management-iis-rewrite.md)

[Microsoft.Web.Management.Iis.Rewrite Namespace](microsoft-web-management-iis-rewrite-namespace.md)

