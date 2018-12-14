---
title: DeploymentRuleHandler.CompareAttribute Method  (Microsoft.Web.Deployment)
TOCTitle: CompareAttribute Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentRuleHandler.CompareAttribute(Microsoft.Web.Deployment.DeploymentSyncContext,Microsoft.Web.Deployment.DeploymentObject,Microsoft.Web.Deployment.DeploymentObjectAttribute,Microsoft.Web.Deployment.DeploymentObject,Microsoft.Web.Deployment.DeploymentObjectAttribute,System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentrulehandler.compareattribute(v=VS.90)
ms:contentKeyID: 22754065
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentRuleHandler.CompareAttribute
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentRuleHandler.CompareAttribute
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CompareAttribute Method

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicOverridableFunctionCompareAttribute ( _
    syncContextAsDeploymentSyncContext, _
    destinationObjectAsDeploymentObject, _
    destinationAttributeAsDeploymentObjectAttribute, _
    sourceObjectAsDeploymentObject, _
    sourceAttributeAsDeploymentObjectAttribute, _
    currentComparisonAsInteger _
) AsInteger
'Usage
DiminstanceAsDeploymentRuleHandlerDimsyncContextAsDeploymentSyncContextDimdestinationObjectAsDeploymentObjectDimdestinationAttributeAsDeploymentObjectAttributeDimsourceObjectAsDeploymentObjectDimsourceAttributeAsDeploymentObjectAttributeDimcurrentComparisonAsIntegerDimreturnValueAsIntegerreturnValue = instance.CompareAttribute(syncContext, _
    destinationObject, destinationAttribute, _
    sourceObject, sourceAttribute, currentComparison)
```

``` csharp
publicvirtualintCompareAttribute(
    DeploymentSyncContextsyncContext,
    DeploymentObjectdestinationObject,
    DeploymentObjectAttributedestinationAttribute,
    DeploymentObjectsourceObject,
    DeploymentObjectAttributesourceAttribute,
    intcurrentComparison
)
```

``` c++
public:
virtualintCompareAttribute(
    DeploymentSyncContext^ syncContext, 
    DeploymentObject^ destinationObject, 
    DeploymentObjectAttribute^ destinationAttribute, 
    DeploymentObject^ sourceObject, 
    DeploymentObjectAttribute^ sourceAttribute, 
    intcurrentComparison
)
```

``` jscript
publicfunctionCompareAttribute(
    syncContext : DeploymentSyncContext, 
    destinationObject : DeploymentObject, 
    destinationAttribute : DeploymentObjectAttribute, 
    sourceObject : DeploymentObject, 
    sourceAttribute : DeploymentObjectAttribute, 
    currentComparison : int
) : int
```

#### Parameters

  - syncContext  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentSyncContext](deploymentsynccontext-class-microsoft-web-deployment.md)  

<!-- end list -->

  - destinationObject  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObject](deploymentobject-class-microsoft-web-deployment.md)  

<!-- end list -->

  - destinationAttribute  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectAttribute](deploymentobjectattribute-class-microsoft-web-deployment.md)  

<!-- end list -->

  - sourceObject  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObject](deploymentobject-class-microsoft-web-deployment.md)  

<!-- end list -->

  - sourceAttribute  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectAttribute](deploymentobjectattribute-class-microsoft-web-deployment.md)  

<!-- end list -->

  - currentComparison  
    Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  

#### Return Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentRuleHandler Class](deploymentrulehandler-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

