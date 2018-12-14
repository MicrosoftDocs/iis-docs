---
title: DeploymentManifestObject.Attributes Property  (Microsoft.Web.Deployment)
TOCTitle: Attributes Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentManifestObject.Attributes
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentmanifestobject.attributes(v=VS.90)
ms:contentKeyID: 20208777
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentManifestObject.Attributes
- Microsoft.Web.Deployment.DeploymentManifestObject.get_Attributes
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentManifestObject.Attributes
- Microsoft.Web.Deployment.DeploymentManifestObject.get_Attributes
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Attributes Property

Gets the collection of DeploymentAttribute objects associated with the current object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyAttributesAsICollection(OfDeploymentObjectAttributeData)
'Usage
DiminstanceAsDeploymentManifestObjectDimvalueAsICollection(OfDeploymentObjectAttributeData)

value = instance.Attributes
```

``` csharp
publicICollection<DeploymentObjectAttributeData> Attributes { get; }
```

``` c++
public:
propertyICollection<DeploymentObjectAttributeData^>^ Attributes {
    ICollection<DeploymentObjectAttributeData^>^ get ();
}
```

``` jscript
function getAttributes () : ICollection<DeploymentObjectAttributeData>
```

#### Property Value

Type: [System.Collections.Generic. . :: . .ICollection](https://msdn.microsoft.com/en-us/library/92t2ye13\(v=vs.90\))\< (Of \< ( \<'[DeploymentObjectAttributeData](deploymentobjectattributedata-class-microsoft-web-deployment.md)\> ) \> ) \>  
An ICollection\<DeploymentAttribute\> interface.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentManifestObject Class](deploymentmanifestobject-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

