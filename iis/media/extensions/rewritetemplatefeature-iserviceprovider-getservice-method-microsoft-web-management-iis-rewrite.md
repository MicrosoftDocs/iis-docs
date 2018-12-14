---
title: RewriteTemplateFeature.IServiceProvider.GetService Method  (Microsoft.Web.Management.Iis.Rewrite)
TOCTitle: IServiceProvider.GetService Method
ms:assetid: M:Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.System#IServiceProvider#GetService(System.Type)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Dd565902(v=VS.90)
ms:contentKeyID: 20476385
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.IServiceProvider.GetService
- Microsoft::Web::Management::Iis::Rewrite::RewriteTemplateFeature::IServiceProvider::GetService
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

# IServiceProvider.GetService Method

**Namespace:**  [Microsoft.Web.Management.Iis.Rewrite](microsoft-web-management-iis-rewrite-namespace.md)  
**Assembly:**  Microsoft.Web.Management.Rewrite.Client (in Microsoft.Web.Management.Rewrite.Client.dll)

## Syntax

``` vb
'Declaration
PrivateFunctionGetService ( _
    serviceTypeAsType _
) AsObjectImplementsIServiceProvider.GetService
'Usage
DiminstanceAsRewriteTemplateFeatureDimserviceTypeAsTypeDimreturnValueAsObjectreturnValue = CType(instance, IServiceProvider).GetService(serviceType)
```

``` csharp
ObjectIServiceProvider.GetService(
    TypeserviceType
)
```

``` c++
private:
virtualObject^ GetService(
    Type^ serviceType
) sealed = IServiceProvider::GetService
```

``` jscript
JScript does not support explicit interface implementations.
```

#### Parameters

  - serviceType  
    Type: [System. . :: . .Type](https://msdn.microsoft.com/en-us/library/42892f65\(v=vs.90\))  

#### Return Value

Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  

#### Implements

[IServiceProvider. . :: . .GetService(Type)](https://msdn.microsoft.com/en-us/library/wacy2d1s\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[RewriteTemplateFeature Class](rewritetemplatefeature-class-microsoft-web-management-iis-rewrite.md)

[Microsoft.Web.Management.Iis.Rewrite Namespace](microsoft-web-management-iis-rewrite-namespace.md)

