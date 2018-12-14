---
title: DeploymentSyncParameter.Entries Property  (Microsoft.Web.Deployment)
TOCTitle: Entries Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSyncParameter.Entries
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparameter.entries(v=VS.90)
ms:contentKeyID: 20208895
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncParameter.Entries
- Microsoft.Web.Deployment.DeploymentSyncParameter.get_Entries
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncParameter.Entries
- Microsoft.Web.Deployment.DeploymentSyncParameter.get_Entries
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Entries Property

Gets an IEnumerable\<DeploymentSyncParameterEntry\> interface that references the [DeploymentSyncParameterEntry](deploymentsyncparameterentry-class-microsoft-web-deployment.md) objects in the current parameter.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyEntriesAsIEnumerable(OfDeploymentSyncParameterEntry)
'Usage
DiminstanceAsDeploymentSyncParameterDimvalueAsIEnumerable(OfDeploymentSyncParameterEntry)

value = instance.Entries
```

``` csharp
publicIEnumerable<DeploymentSyncParameterEntry> Entries { get; }
```

``` c++
public:
propertyIEnumerable<DeploymentSyncParameterEntry^>^ Entries {
    IEnumerable<DeploymentSyncParameterEntry^>^ get ();
}
```

``` jscript
function getEntries () : IEnumerable<DeploymentSyncParameterEntry>
```

#### Property Value

Type: [System.Collections.Generic. . :: . .IEnumerable](https://msdn.microsoft.com/en-us/library/9eekhta0\(v=vs.90\))\< (Of \< ( \<'[DeploymentSyncParameterEntry](deploymentsyncparameterentry-class-microsoft-web-deployment.md)\> ) \> ) \>  
An IEnumerable\<DeploymentSyncParameterEntry\> interface that references the [DeploymentSyncParameterEntry](deploymentsyncparameterentry-class-microsoft-web-deployment.md) objects in the current parameter instance.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncParameter Class](deploymentsyncparameter-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

