---
title: DeploymentObjectAttributeCollection.TryGetValue Method  (Microsoft.Web.Deployment)
TOCTitle: TryGetValue Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectAttributeCollection.TryGetValue(System.String,Microsoft.Web.Deployment.DeploymentObjectAttribute@)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectattributecollection.trygetvalue(v=VS.90)
ms:contentKeyID: 22753967
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectAttributeCollection.TryGetValue
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectAttributeCollection.TryGetValue
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TryGetValue Method

Attempts to find the [DeploymentObjectAttribute](deploymentobjectattribute-class-microsoft-web-deployment.md) with the specified name in the current collection and returns a value indicating whether the operation was successful.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionTryGetValue ( _
    nameAsString, _
    <OutAttribute> ByRefattributeAsDeploymentObjectAttribute _
) AsBoolean
'Usage
DiminstanceAsDeploymentObjectAttributeCollectionDimnameAsStringDimattributeAsDeploymentObjectAttributeDimreturnValueAsBooleanreturnValue = instance.TryGetValue(name, _
    attribute)
```

``` csharp
publicboolTryGetValue(
    stringname,
    outDeploymentObjectAttributeattribute
)
```

``` c++
public:
boolTryGetValue(
    String^ name, 
    [OutAttribute] DeploymentObjectAttribute^% attribute
)
```

``` jscript
publicfunctionTryGetValue(
    name : String, 
    attribute : DeploymentObjectAttribute
) : boolean
```

#### Parameters

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the attribute to find in the current collection.  

<!-- end list -->

  - attribute  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectAttribute](deploymentobjectattribute-class-microsoft-web-deployment.md)%  
    The returned attribute instance if one is found.  

#### Return Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if a attribute with the specified name is found in the current collection, otherwise false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectAttributeCollection Class](deploymentobjectattributecollection-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

