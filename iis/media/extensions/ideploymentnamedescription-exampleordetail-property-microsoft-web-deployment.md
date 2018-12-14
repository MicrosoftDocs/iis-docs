---
title: IDeploymentNameDescription.ExampleOrDetail Property  (Microsoft.Web.Deployment)
TOCTitle: ExampleOrDetail Property
ms:assetid: P:Microsoft.Web.Deployment.IDeploymentNameDescription.ExampleOrDetail
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.ideploymentnamedescription.exampleordetail(v=VS.90)
ms:contentKeyID: 20208817
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.IDeploymentNameDescription.ExampleOrDetail
- Microsoft.Web.Deployment.IDeploymentNameDescription.get_ExampleOrDetail
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.IDeploymentNameDescription.ExampleOrDetail
- Microsoft.Web.Deployment.IDeploymentNameDescription.get_ExampleOrDetail
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ExampleOrDetail Property

Gets the example or detail information of the current deployment name and description object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
ReadOnlyPropertyExampleOrDetailAsString
'Usage
DiminstanceAsIDeploymentNameDescriptionDimvalueAsStringvalue = instance.ExampleOrDetail
```

``` csharp
stringExampleOrDetail { get; }
```

``` c++
propertyString^ ExampleOrDetail {
    String^ get ();
}
```

``` jscript
function getExampleOrDetail () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string containing the example or detail information of the current deployment name and description object.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[IDeploymentNameDescription Interface](ideploymentnamedescription-interface-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

