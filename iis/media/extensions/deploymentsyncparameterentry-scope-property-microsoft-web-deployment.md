---
title: DeploymentSyncParameterEntry.Scope Property  (Microsoft.Web.Deployment)
TOCTitle: Scope Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSyncParameterEntry.Scope
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparameterentry.scope(v=VS.90)
ms:contentKeyID: 20208975
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncParameterEntry.Scope
- Microsoft.Web.Deployment.DeploymentSyncParameterEntry.get_Scope
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncParameterEntry.get_Scope
- Microsoft.Web.Deployment.DeploymentSyncParameterEntry.Scope
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Scope Property

Gets the regular expression used to determine if the entry is in scope.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyScopeAsString
'Usage
DiminstanceAsDeploymentSyncParameterEntryDimvalueAsStringvalue = instance.Scope
```

``` csharp
publicstringScope { get; }
```

``` c++
public:
propertyString^ Scope {
    String^ get ();
}
```

``` jscript
function getScope () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains a regular expression.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncParameterEntry Class](deploymentsyncparameterentry-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

