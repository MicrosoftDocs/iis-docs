---
title: DeploymentSkipDirectiveEntry.Value Property  (Microsoft.Web.Deployment)
TOCTitle: Value Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSkipDirectiveEntry.Value
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentskipdirectiveentry.value(v=VS.90)
ms:contentKeyID: 20208729
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSkipDirectiveEntry.Value
- Microsoft.Web.Deployment.DeploymentSkipDirectiveEntry.get_Value
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSkipDirectiveEntry.get_Value
- Microsoft.Web.Deployment.DeploymentSkipDirectiveEntry.Value
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Value Property

Gets the value of the skip directive entry.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyValueAsString
'Usage
DiminstanceAsDeploymentSkipDirectiveEntryDimvalueAsStringvalue = instance.Value
```

``` csharp
publicstringValue { get; }
```

``` c++
public:
propertyString^ Value {
    String^ get ();
}
```

``` jscript
function getValue () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the name of the current skip directive entry.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSkipDirectiveEntry Class](deploymentskipdirectiveentry-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

