---
title: DeploymentSerializationEventArgs Constructor  (Microsoft.Web.Deployment)
TOCTitle: DeploymentSerializationEventArgs Constructor
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSerializationEventArgs.#ctor(Microsoft.Web.Deployment.DeploymentSerializationAction,System.String,System.Object[])
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentserializationeventargs.deploymentserializationeventargs(v=VS.90)
ms:contentKeyID: 20209276
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSerializationEventArgs.DeploymentSerializationEventArgs
- Microsoft.Web.Deployment.DeploymentSerializationEventArgs.#ctor
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSerializationEventArgs..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentSerializationEventArgs Constructor

Creates an instance of a [DeploymentSerializationEventArgs](deploymentserializationeventargs-class-microsoft-web-deployment.md) object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    serializationActionAsDeploymentSerializationAction, _
    messageAsString, _
    ParamArrayparametersAsObject() _
)
'Usage
DimserializationActionAsDeploymentSerializationActionDimmessageAsStringDimparametersAsObject()

DiminstanceAs NewDeploymentSerializationEventArgs(serializationAction, _
    message, parameters)
```

``` csharp
publicDeploymentSerializationEventArgs(
    DeploymentSerializationActionserializationAction,
    stringmessage,
    paramsObject[] parameters
)
```

``` c++
public:
DeploymentSerializationEventArgs(
    DeploymentSerializationActionserializationAction, 
    String^ message, 
    ... array<Object^>^ parameters
)
```

``` jscript
publicfunctionDeploymentSerializationEventArgs(
    serializationAction : DeploymentSerializationAction, 
    message : String, 
    ... parameters : Object[]
)
```

#### Parameters

  - serializationAction  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentSerializationAction](deploymentserializationaction-enumeration-microsoft-web-deployment.md)  
    The serialization operation this event represents.  

<!-- end list -->

  - message  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    A message describing the current action.  

<!-- end list -->

  - parameters  
    Type: array\<[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))\> \[\] () \[\] \[\]  
    An array of parameters used in the current serialization operation.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSerializationEventArgs Class](deploymentserializationeventargs-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

