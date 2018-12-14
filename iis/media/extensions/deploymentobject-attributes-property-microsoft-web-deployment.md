---
title: DeploymentObject.Attributes Property  (Microsoft.Web.Deployment)
TOCTitle: Attributes Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentObject.Attributes
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobject.attributes(v=VS.90)
ms:contentKeyID: 20208935
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObject.Attributes
- Microsoft.Web.Deployment.DeploymentObject.get_Attributes
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObject.Attributes
- Microsoft.Web.Deployment.DeploymentObject.get_Attributes
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Attributes Property

Gets a DeploymentAttributeCollection instance that contains the attributes of the deployment object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyAttributesAsDeploymentObjectAttributeCollection
'Usage
DiminstanceAsDeploymentObjectDimvalueAsDeploymentObjectAttributeCollectionvalue = instance.Attributes
```

``` csharp
publicDeploymentObjectAttributeCollectionAttributes { get; }
```

``` c++
public:
propertyDeploymentObjectAttributeCollection^ Attributes {
    DeploymentObjectAttributeCollection^ get ();
}
```

``` jscript
function getAttributes () : DeploymentObjectAttributeCollection
```

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectAttributeCollection](deploymentobjectattributecollection-class-microsoft-web-deployment.md)  
A DeploymentAttributeCollection instance that contains the attributes of the deployment object.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObject Class](deploymentobject-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

