---
title: DeploymentSyncContext.Clone Method  (Microsoft.Web.Deployment)
TOCTitle: Clone Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSyncContext.Clone(Microsoft.Web.Deployment.DeploymentObject,Microsoft.Web.Deployment.DeploymentObjectAttributeData)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsynccontext.clone(v=VS.90)
ms:contentKeyID: 22754013
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncContext.Clone
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncContext.Clone
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Clone Method

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionClone ( _
    sourceAsDeploymentObject, _
    replaceAttributeAsDeploymentObjectAttributeData _
) AsDeploymentObject
'Usage
DiminstanceAsDeploymentSyncContextDimsourceAsDeploymentObjectDimreplaceAttributeAsDeploymentObjectAttributeDataDimreturnValueAsDeploymentObjectreturnValue = instance.Clone(source, replaceAttribute)
```

``` csharp
publicDeploymentObjectClone(
    DeploymentObjectsource,
    DeploymentObjectAttributeDatareplaceAttribute
)
```

``` c++
public:
DeploymentObject^ Clone(
    DeploymentObject^ source, 
    DeploymentObjectAttributeData^ replaceAttribute
)
```

``` jscript
publicfunctionClone(
    source : DeploymentObject, 
    replaceAttribute : DeploymentObjectAttributeData
) : DeploymentObject
```

#### Parameters

  - source  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObject](deploymentobject-class-microsoft-web-deployment.md)  

<!-- end list -->

  - replaceAttribute  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectAttributeData](deploymentobjectattributedata-class-microsoft-web-deployment.md)  

#### Return Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentObject](deploymentobject-class-microsoft-web-deployment.md)  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncContext Class](deploymentsynccontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

