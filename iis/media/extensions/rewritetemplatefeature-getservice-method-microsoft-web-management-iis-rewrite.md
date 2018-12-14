---
title: RewriteTemplateFeature.GetService Method  (Microsoft.Web.Management.Iis.Rewrite)
TOCTitle: GetService Method
ms:assetid: M:Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.GetService(System.Type)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.iis.rewrite.rewritetemplatefeature.getservice(v=VS.90)
ms:contentKeyID: 20476333
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.GetService
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.Rewrite.Client.dll
api_name:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.GetService
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetService Method

Gets the service object of the specified type.

**Namespace:**  [Microsoft.Web.Management.Iis.Rewrite](microsoft-web-management-iis-rewrite-namespace.md)  
**Assembly:**  Microsoft.Web.Management.Rewrite.Client (in Microsoft.Web.Management.Rewrite.Client.dll)

## Syntax

``` vb
'Declaration
ProtectedOverridableFunctionGetService ( _
    typeAsType _
) AsObject
'Usage
DimtypeAsTypeDimreturnValueAsObjectreturnValue = Me.GetService(type)
```

``` csharp
protectedvirtualObjectGetService(
    Typetype
)
```

``` c++
protected:
virtualObject^ GetService(
    Type^ type
)
```

``` jscript
protectedfunctionGetService(
    type : Type
) : Object
```

#### Parameters

  - type  
    Type: [System. . :: . .Type](https://msdn.microsoft.com/en-us/library/42892f65\(v=vs.90\))  
    An object that specifies the type of service object to get.  

#### Return Value

Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
A service object of specified type.or nullNothingnullptrunita null reference (Nothing in Visual Basic) (Nothing in Visual Basic) if there is no service object of type specified.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[RewriteTemplateFeature Class](rewritetemplatefeature-class-microsoft-web-management-iis-rewrite.md)

[Microsoft.Web.Management.Iis.Rewrite Namespace](microsoft-web-management-iis-rewrite-namespace.md)

