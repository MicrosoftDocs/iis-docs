---
title: DeploymentRuleCollection.TryGetValue Method  (Microsoft.Web.Deployment)
TOCTitle: TryGetValue Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentRuleCollection.TryGetValue(System.String,Microsoft.Web.Deployment.DeploymentRule@)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentrulecollection.trygetvalue(v=VS.90)
ms:contentKeyID: 20209141
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentRuleCollection.TryGetValue
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentRuleCollection.TryGetValue
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TryGetValue Method

Gets a value indicating whether a [DeploymentRule](deploymentrule-class-microsoft-web-deployment.md) with the specified name exists in the current collection, and returns the rule in the specified out parameter.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionTryGetValue ( _
    nameAsString, _
    <OutAttribute> ByRefruleAsDeploymentRule _
) AsBoolean
'Usage
DiminstanceAsDeploymentRuleCollectionDimnameAsStringDimruleAsDeploymentRuleDimreturnValueAsBooleanreturnValue = instance.TryGetValue(name, _
    rule)
```

``` csharp
publicboolTryGetValue(
    stringname,
    outDeploymentRulerule
)
```

``` c++
public:
boolTryGetValue(
    String^ name, 
    [OutAttribute] DeploymentRule^% rule
)
```

``` jscript
publicfunctionTryGetValue(
    name : String, 
    rule : DeploymentRule
) : boolean
```

#### Parameters

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the rule to search for in the current collection.  

<!-- end list -->

  - rule  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentRule](deploymentrule-class-microsoft-web-deployment.md)%  
    Contains the returned rule if one exists in the current collection.  

#### Return Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the [DeploymentRule](deploymentrule-class-microsoft-web-deployment.md) was found in the current collection, otherwise false.  

## Remarks

When this operation is complete, the rule parameter will contain the specified [DeploymentRule](deploymentrule-class-microsoft-web-deployment.md) if one exists.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentRuleCollection Class](deploymentrulecollection-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

