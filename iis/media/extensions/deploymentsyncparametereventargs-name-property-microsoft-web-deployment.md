---
title: DeploymentSyncParameterEventArgs.Name Property  (Microsoft.Web.Deployment)
TOCTitle: Name Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSyncParameterEventArgs.Name
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparametereventargs.name(v=VS.90)
ms:contentKeyID: 22753971
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncParameterEventArgs.Name
- Microsoft.Web.Deployment.DeploymentSyncParameterEventArgs.get_Name
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncParameterEventArgs.get_Name
- Microsoft.Web.Deployment.DeploymentSyncParameterEventArgs.Name
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Name Property

Gets the name associated with the event arguments for a deployment synchronization parameter.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyNameAsString
'Usage
DiminstanceAsDeploymentSyncParameterEventArgsDimvalueAsStringvalue = instance.Name
```

``` csharp
publicstringName { get; }
```

``` c++
public:
propertyString^ Name {
    String^ get ();
}
```

``` jscript
function getName () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the name associated with the event arguments for a deployment synchronization parameter.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncParameterEventArgs Class](deploymentsyncparametereventargs-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

