---
title: DeploymentObjectProvider.AddChild Method  (Microsoft.Web.Deployment)
TOCTitle: AddChild Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectProvider.AddChild(Microsoft.Web.Deployment.DeploymentObject,System.Int32,System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectprovider.addchild(v=VS.90)
ms:contentKeyID: 20209179
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectProvider.AddChild
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectProvider.AddChild
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# AddChild Method

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicOverridableFunctionAddChild ( _
    sourceAsDeploymentObject, _
    positionAsInteger, _
    whatIfAsBoolean _
) AsDeploymentObjectProvider
'Usage
DiminstanceAsDeploymentObjectProviderDimsourceAsDeploymentObjectDimpositionAsIntegerDimwhatIfAsBooleanDimreturnValueAsDeploymentObjectProviderreturnValue = instance.AddChild(source, _
    position, whatIf)
```

``` csharp
publicvirtualDeploymentObjectProviderAddChild(
    DeploymentObjectsource,
    intposition,
    boolwhatIf
)
```

``` c++
public:
virtualDeploymentObjectProvider^ AddChild(
    DeploymentObject^ source, 
    intposition, 
    boolwhatIf
)
```

``` jscript
publicfunctionAddChild(
    source : DeploymentObject, 
    position : int, 
    whatIf : boolean
) : DeploymentObjectProvider
```

#### Parameters

  - source  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObject](deploymentobject-class-microsoft-web-deployment.md)  

<!-- end list -->

  - position  
    Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  

<!-- end list -->

  - whatIf  
    Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  

#### Return Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectProvider](deploymentobjectprovider-class-microsoft-web-deployment.md)  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectProvider Class](deploymentobjectprovider-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

