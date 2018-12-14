---
title: DeploymentSyncParameter.DefaultValue Property  (Microsoft.Web.Deployment)
TOCTitle: DefaultValue Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSyncParameter.DefaultValue
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparameter.defaultvalue(v=VS.90)
ms:contentKeyID: 20208743
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncParameter.DefaultValue
- Microsoft.Web.Deployment.DeploymentSyncParameter.get_DefaultValue
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncParameter.DefaultValue
- Microsoft.Web.Deployment.DeploymentSyncParameter.get_DefaultValue
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DefaultValue Property

Gets the default value of the current parameter.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyDefaultValueAsString
'Usage
DiminstanceAsDeploymentSyncParameterDimvalueAsStringvalue = instance.DefaultValue
```

``` csharp
publicstringDefaultValue { get; }
```

``` c++
public:
propertyString^ DefaultValue {
    String^ get ();
}
```

``` jscript
function getDefaultValue () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The default value of the current parameter.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncParameter Class](deploymentsyncparameter-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

