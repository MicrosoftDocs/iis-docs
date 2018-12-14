---
title: DeploymentSerializationEventArgs.SerializationAction Property  (Microsoft.Web.Deployment)
TOCTitle: SerializationAction Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSerializationEventArgs.SerializationAction
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentserializationeventargs.serializationaction(v=VS.90)
ms:contentKeyID: 20208692
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSerializationEventArgs.SerializationAction
- Microsoft.Web.Deployment.DeploymentSerializationEventArgs.get_SerializationAction
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSerializationEventArgs.get_SerializationAction
- Microsoft.Web.Deployment.DeploymentSerializationEventArgs.SerializationAction
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SerializationAction Property

Gets the serialization operation this event represents.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertySerializationActionAsDeploymentSerializationAction
'Usage
DiminstanceAsDeploymentSerializationEventArgsDimvalueAsDeploymentSerializationActionvalue = instance.SerializationAction
```

``` csharp
publicDeploymentSerializationActionSerializationAction { get; }
```

``` c++
public:
propertyDeploymentSerializationActionSerializationAction {
    DeploymentSerializationActionget ();
}
```

``` jscript
function getSerializationAction () : DeploymentSerializationAction
```

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentSerializationAction](deploymentserializationaction-enumeration-microsoft-web-deployment.md)  
A valid value from the [DeploymentSerializationAction](deploymentserializationaction-enumeration-microsoft-web-deployment.md) enumeration.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSerializationEventArgs Class](deploymentserializationeventargs-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

