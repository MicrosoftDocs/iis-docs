---
title: DeploymentSyncParameterEntry Constructor (DeploymentSyncParameterEntryKind, String, String, String) (Microsoft.Web.Deployment)
TOCTitle: DeploymentSyncParameterEntry Constructor (DeploymentSyncParameterEntryKind, String, String, String)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSyncParameterEntry.#ctor(Microsoft.Web.Deployment.DeploymentSyncParameterEntryKind,System.String,System.String,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparameterentry.deploymentsyncparameterentry(v=VS.90)
ms:contentKeyID: 22753964
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- jscript
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncParameterEntry..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentSyncParameterEntry Constructor (DeploymentSyncParameterEntryKind, String, String, String)

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    kindAsDeploymentSyncParameterEntryKind, _
    scopeAsString, _
    matchAsString, _
    tagsAsString _
)
'Usage
DimkindAsDeploymentSyncParameterEntryKindDimscopeAsStringDimmatchAsStringDimtagsAsStringDiminstanceAs NewDeploymentSyncParameterEntry(kind, scope, _
    match, tags)
```

``` csharp
publicDeploymentSyncParameterEntry(
    DeploymentSyncParameterEntryKindkind,
    stringscope,
    stringmatch,
    stringtags
)
```

``` c++
public:
DeploymentSyncParameterEntry(
    DeploymentSyncParameterEntryKindkind, 
    String^ scope, 
    String^ match, 
    String^ tags
)
```

``` jscript
publicfunctionDeploymentSyncParameterEntry(
    kind : DeploymentSyncParameterEntryKind, 
    scope : String, 
    match : String, 
    tags : String
)
```

#### Parameters

  - kind  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentSyncParameterEntryKind](deploymentsyncparameterentrykind-enumeration-microsoft-web-deployment.md)  

<!-- end list -->

  - scope  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

<!-- end list -->

  - match  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

<!-- end list -->

  - tags  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncParameterEntry Class](deploymentsyncparameterentry-class-microsoft-web-deployment.md)

[DeploymentSyncParameterEntry Overload](deploymentsyncparameterentry-constructor-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

