---
title: DeploymentMethod.Invoke Method  (Microsoft.Web.Deployment)
TOCTitle: Invoke Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentMethod.Invoke(Microsoft.Web.Deployment.DeploymentObject,System.Object[])
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentmethod.invoke(v=VS.90)
ms:contentKeyID: 20209015
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentMethod.Invoke
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentMethod.Invoke
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Invoke Method

Executes the current method.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicMustOverrideFunctionInvoke ( _
    targetObjectAsDeploymentObject, _
    ParamArrayparametersAsObject() _
) AsObject
'Usage
DiminstanceAsDeploymentMethodDimtargetObjectAsDeploymentObjectDimparametersAsObject()
DimreturnValueAsObjectreturnValue = instance.Invoke(targetObject, _
    parameters)
```

``` csharp
publicabstractObjectInvoke(
    DeploymentObjecttargetObject,
    paramsObject[] parameters
)
```

``` c++
public:
virtualObject^ Invoke(
    DeploymentObject^ targetObject, 
    ... array<Object^>^ parameters
) abstract
```

``` jscript
publicabstractfunctionInvoke(
    targetObject : DeploymentObject, 
    ... parameters : Object[]
) : Object
```

#### Parameters

  - targetObject  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObject](deploymentobject-class-microsoft-web-deployment.md)  
    The target [DeploymentObject](deploymentobject-class-microsoft-web-deployment.md) to invoke the current method.  

<!-- end list -->

  - parameters  
    Type: array\<[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))\> \[\] () \[\] \[\]  

#### Return Value

Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
An object that contains the result of executing the method.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentMethod Class](deploymentmethod-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

