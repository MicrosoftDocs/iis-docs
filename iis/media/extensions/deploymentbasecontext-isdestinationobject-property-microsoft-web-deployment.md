---
title: DeploymentBaseContext.IsDestinationObject Property  (Microsoft.Web.Deployment)
TOCTitle: IsDestinationObject Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentBaseContext.IsDestinationObject
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbasecontext.isdestinationobject(v=VS.90)
ms:contentKeyID: 20209158
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseContext.IsDestinationObject
- Microsoft.Web.Deployment.DeploymentBaseContext.get_IsDestinationObject
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseContext.get_IsDestinationObject
- Microsoft.Web.Deployment.DeploymentBaseContext.IsDestinationObject
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IsDestinationObject Property

Gets a value that determines if the current instance is a destination object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyIsDestinationObjectAsBoolean
'Usage
DiminstanceAsDeploymentBaseContextDimvalueAsBooleanvalue = instance.IsDestinationObject
```

``` csharp
publicboolIsDestinationObject { get; }
```

``` c++
public:
propertyboolIsDestinationObject {
    boolget ();
}
```

``` jscript
function getIsDestinationObject () : boolean
```

#### Property Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the current object instance is a destination object, otherwise false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentBaseContext Class](deploymentbasecontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

