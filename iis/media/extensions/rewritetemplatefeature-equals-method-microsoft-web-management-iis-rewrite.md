---
title: RewriteTemplateFeature.Equals Method  (Microsoft.Web.Management.Iis.Rewrite)
TOCTitle: Equals Method
ms:assetid: M:Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.Equals(System.Object)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.iis.rewrite.rewritetemplatefeature.equals(v=VS.90)
ms:contentKeyID: 20476372
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.Equals
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.Rewrite.Client.dll
api_name:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.Equals
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Equals Method

Determines whether this instance and another specified object have the same value.

**Namespace:**  [Microsoft.Web.Management.Iis.Rewrite](microsoft-web-management-iis-rewrite-namespace.md)  
**Assembly:**  Microsoft.Web.Management.Rewrite.Client (in Microsoft.Web.Management.Rewrite.Client.dll)

## Syntax

``` vb
'Declaration
PublicOverridesFunctionEquals ( _
    objAsObject _
) AsBoolean
'Usage
DiminstanceAsRewriteTemplateFeatureDimobjAsObjectDimreturnValueAsBooleanreturnValue = instance.Equals(obj)
```

``` csharp
publicoverrideboolEquals(
    Objectobj
)
```

``` c++
public:
virtualboolEquals(
    Object^ obj
) override
```

``` jscript
publicoverridefunctionEquals(
    obj : Object
) : boolean
```

#### Parameters

  - obj  
    Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
    A [RewriteTemplateFeature](rewritetemplatefeature-class-microsoft-web-management-iis-rewrite.md) object reference.  

#### Return Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the title of the obj parameter is the same as this instance; otherwise, false.  

## Remarks

This method determines that an object has the same value as another [RewriteTemplateFeature](rewritetemplatefeature-class-microsoft-web-management-iis-rewrite.md) if they have the same title.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[RewriteTemplateFeature Class](rewritetemplatefeature-class-microsoft-web-management-iis-rewrite.md)

[Microsoft.Web.Management.Iis.Rewrite Namespace](microsoft-web-management-iis-rewrite-namespace.md)

