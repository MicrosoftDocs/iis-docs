---
title: DeploymentMethod.Name Property  (Microsoft.Web.Deployment)
TOCTitle: Name Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentMethod.Name
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentmethod.name(v=VS.90)
ms:contentKeyID: 20209134
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentMethod.Name
- Microsoft.Web.Deployment.DeploymentMethod.get_Name
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentMethod.get_Name
- Microsoft.Web.Deployment.DeploymentMethod.Name
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Name Property

Gets the name of the current [DeploymentMethod](deploymentmethod-class-microsoft-web-deployment.md) object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicMustOverrideReadOnlyPropertyNameAsString
'Usage
DiminstanceAsDeploymentMethodDimvalueAsStringvalue = instance.Name
```

``` csharp
publicabstractstringName { get; }
```

``` c++
public:
virtualpropertyString^ Name {
    String^ get () abstract;
}
```

``` jscript
abstractfunction getName () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string value that contains the name of the current [DeploymentMethod](deploymentmethod-class-microsoft-web-deployment.md) object.  

#### Implements

[IDeploymentNameDescription. . :: . .Name](ideploymentnamedescription-name-property-microsoft-web-deployment.md)  

## Remarks

Method names are used to uniquely identify methods in a collection. You may invoke a method assigned to a [DeploymentObject](deploymentobject-class-microsoft-web-deployment.md) by using the method name and providing a list of parameters with the [Invoke](deploymentobject-invoke-method-microsoft-web-deployment.md) method.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentMethod Class](deploymentmethod-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

