---
title: DeploymentSyncParameter.Value Property  (Microsoft.Web.Deployment)
TOCTitle: Value Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSyncParameter.Value
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparameter.value(v=VS.90)
ms:contentKeyID: 20209077
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncParameter.Value
- Microsoft.Web.Deployment.DeploymentSyncParameter.get_Value
- Microsoft.Web.Deployment.DeploymentSyncParameter.set_Value
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncParameter.get_Value
- Microsoft.Web.Deployment.DeploymentSyncParameter.set_Value
- Microsoft.Web.Deployment.DeploymentSyncParameter.Value
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Value Property

Gets or sets the value of the current parameter.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicPropertyValueAsString
'Usage
DiminstanceAsDeploymentSyncParameterDimvalueAsStringvalue = instance.Value

instance.Value = value
```

``` csharp
publicstringValue { get; set; }
```

``` c++
public:
propertyString^ Value {
    String^ get ();
    voidset (String^ value);
}
```

``` jscript
function getValue () : Stringfunction setValue (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the value of the current parameter.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncParameter Class](deploymentsyncparameter-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

