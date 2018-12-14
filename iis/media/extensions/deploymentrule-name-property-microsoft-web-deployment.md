---
title: DeploymentRule.Name Property  (Microsoft.Web.Deployment)
TOCTitle: Name Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentRule.Name
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentrule.name(v=VS.90)
ms:contentKeyID: 20209054
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentRule.Name
- Microsoft.Web.Deployment.DeploymentRule.get_Name
- Microsoft.Web.Deployment.DeploymentRule.set_Name
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentRule.get_Name
- Microsoft.Web.Deployment.DeploymentRule.Name
- Microsoft.Web.Deployment.DeploymentRule.set_Name
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Name Property

Gets the name of the current deployment rule.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicPropertyNameAsString
'Usage
DiminstanceAsDeploymentRuleDimvalueAsStringvalue = instance.Name
```

``` csharp
publicstringName { get; internalset; }
```

``` c++
public:
virtualpropertyString^ Name {
    String^ get () sealed;
    internal: voidset (String^ value) sealed;
}
```

``` jscript
finalfunction getName () : Stringinternalfinalfunction setName (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the name of the current deployment rule.  

#### Implements

[IDeploymentNameDescription. . :: . .Name](ideploymentnamedescription-name-property-microsoft-web-deployment.md)  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentRule Class](deploymentrule-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

