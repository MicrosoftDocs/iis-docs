---
title: DeploymentLinkExtension.ExampleOrDetail Property  (Microsoft.Web.Deployment)
TOCTitle: ExampleOrDetail Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentLinkExtension.ExampleOrDetail
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentlinkextension.exampleordetail(v=VS.90)
ms:contentKeyID: 20209131
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentLinkExtension.ExampleOrDetail
- Microsoft.Web.Deployment.DeploymentLinkExtension.get_ExampleOrDetail
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentLinkExtension.ExampleOrDetail
- Microsoft.Web.Deployment.DeploymentLinkExtension.get_ExampleOrDetail
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ExampleOrDetail Property

Gets the example or detail message for the current link extension.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicOverridableReadOnlyPropertyExampleOrDetailAsString
'Usage
DiminstanceAsDeploymentLinkExtensionDimvalueAsStringvalue = instance.ExampleOrDetail
```

``` csharp
publicvirtualstringExampleOrDetail { get; }
```

``` c++
public:
virtualpropertyString^ ExampleOrDetail {
    String^ get ();
}
```

``` jscript
function getExampleOrDetail () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the example or detail message for the current link extension.  

#### Implements

[IDeploymentNameDescription. . :: . .ExampleOrDetail](ideploymentnamedescription-exampleordetail-property-microsoft-web-deployment.md)  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentLinkExtension Class](deploymentlinkextension-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

