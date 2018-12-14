---
title: DeploymentObject.Invoke Method  (Microsoft.Web.Deployment)
TOCTitle: Invoke Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObject.Invoke(System.String,System.Object[])
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobject.invoke(v=VS.90)
ms:contentKeyID: 20208703
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObject.Invoke
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObject.Invoke
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Invoke Method

Executes a named [DeploymentMethod](deploymentmethod-class-microsoft-web-deployment.md) from the [DeploymentManager](deploymentmanager-class-microsoft-web-deployment.md).

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionInvoke ( _
    methodNameAsString, _
    ParamArrayparametersAsObject() _
) AsObject
'Usage
DiminstanceAsDeploymentObjectDimmethodNameAsStringDimparametersAsObject()
DimreturnValueAsObjectreturnValue = instance.Invoke(methodName, _
    parameters)
```

``` csharp
publicObjectInvoke(
    stringmethodName,
    paramsObject[] parameters
)
```

``` c++
public:
Object^ Invoke(
    String^ methodName, 
    ... array<Object^>^ parameters
)
```

``` jscript
publicfunctionInvoke(
    methodName : String, 
    ... parameters : Object[]
) : Object
```

#### Parameters

  - methodName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the [DeploymentMethod](deploymentmethod-class-microsoft-web-deployment.md) to invoke.  

<!-- end list -->

  - parameters  
    Type: array\<[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))\> \[\] () \[\] \[\]  
    The parameters used by the [DeploymentMethod](deploymentmethod-class-microsoft-web-deployment.md).  

#### Return Value

Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
A System.Object result returned from the [DeploymentManager](deploymentmanager-class-microsoft-web-deployment.md).  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObject Class](deploymentobject-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

