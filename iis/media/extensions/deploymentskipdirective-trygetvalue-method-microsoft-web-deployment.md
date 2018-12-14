---
title: DeploymentSkipDirective.TryGetValue Method  (Microsoft.Web.Deployment)
TOCTitle: TryGetValue Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSkipDirective.TryGetValue(System.String,Microsoft.Web.Deployment.DeploymentSkipDirectiveEntry@)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentskipdirective.trygetvalue(v=VS.90)
ms:contentKeyID: 20209069
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSkipDirective.TryGetValue
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSkipDirective.TryGetValue
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TryGetValue Method

Attempts to get the value of the [DeploymentSkipDirectiveEntry](deploymentskipdirectiveentry-class-microsoft-web-deployment.md) with the specified name from the current object instance.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionTryGetValue ( _
    nameAsString, _
    <OutAttribute> ByRefentryAsDeploymentSkipDirectiveEntry _
) AsBoolean
'Usage
DiminstanceAsDeploymentSkipDirectiveDimnameAsStringDimentryAsDeploymentSkipDirectiveEntryDimreturnValueAsBooleanreturnValue = instance.TryGetValue(name, _
    entry)
```

``` csharp
publicboolTryGetValue(
    stringname,
    outDeploymentSkipDirectiveEntryentry
)
```

``` c++
public:
boolTryGetValue(
    String^ name, 
    [OutAttribute] DeploymentSkipDirectiveEntry^% entry
)
```

``` jscript
publicfunctionTryGetValue(
    name : String, 
    entry : DeploymentSkipDirectiveEntry
) : boolean
```

#### Parameters

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the skip directive entry to get.  

<!-- end list -->

  - entry  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentSkipDirectiveEntry](deploymentskipdirectiveentry-class-microsoft-web-deployment.md)%  
    A valid out reference to a [DeploymentSkipDirectiveEntry](deploymentskipdirectiveentry-class-microsoft-web-deployment.md) object instance.  

#### Return Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the skip directive entry was found, otherwise false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSkipDirective Class](deploymentskipdirective-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

