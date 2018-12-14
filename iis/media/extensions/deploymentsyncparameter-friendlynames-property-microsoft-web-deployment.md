---
title: DeploymentSyncParameter.FriendlyNames Property  (Microsoft.Web.Deployment)
TOCTitle: FriendlyNames Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSyncParameter.FriendlyNames
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparameter.friendlynames(v=VS.90)
ms:contentKeyID: 22753946
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncParameter.FriendlyNames
- Microsoft.Web.Deployment.DeploymentSyncParameter.get_FriendlyNames
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncParameter.FriendlyNames
- Microsoft.Web.Deployment.DeploymentSyncParameter.get_FriendlyNames
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# FriendlyNames Property

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyFriendlyNamesAsDictionary(OfString, String)
'Usage
DiminstanceAsDeploymentSyncParameterDimvalueAsDictionary(OfString, String)

value = instance.FriendlyNames
```

``` csharp
publicDictionary<string, string> FriendlyNames { get; }
```

``` c++
public:
propertyDictionary<String^, String^>^ FriendlyNames {
    Dictionary<String^, String^>^ get ();
}
```

``` jscript
function getFriendlyNames () : Dictionary<String, String>
```

#### Property Value

Type: [System.Collections.Generic. . :: . .Dictionary](https://msdn.microsoft.com/en-us/library/xfhwa508\(v=vs.90\))\< (Of \< ( \<'[String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\)), [String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))\> ) \> ) \>  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncParameter Class](deploymentsyncparameter-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

