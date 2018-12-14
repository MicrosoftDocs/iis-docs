---
title: IDeploymentNameDescription.Description Property  (Microsoft.Web.Deployment)
TOCTitle: Description Property
ms:assetid: P:Microsoft.Web.Deployment.IDeploymentNameDescription.Description
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.ideploymentnamedescription.description(v=VS.90)
ms:contentKeyID: 20208721
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.IDeploymentNameDescription.Description
- Microsoft.Web.Deployment.IDeploymentNameDescription.get_Description
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.IDeploymentNameDescription.Description
- Microsoft.Web.Deployment.IDeploymentNameDescription.get_Description
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Description Property

Gets the description of the current deployment name and description object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
ReadOnlyPropertyDescriptionAsString
'Usage
DiminstanceAsIDeploymentNameDescriptionDimvalueAsStringvalue = instance.Description
```

``` csharp
stringDescription { get; }
```

``` c++
propertyString^ Description {
    String^ get ();
}
```

``` jscript
function getDescription () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string containing the description of the current deployment name and description object.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[IDeploymentNameDescription Interface](ideploymentnamedescription-interface-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

