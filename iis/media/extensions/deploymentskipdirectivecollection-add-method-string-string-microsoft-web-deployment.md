---
title: DeploymentSkipDirectiveCollection.Add Method (String, String) (Microsoft.Web.Deployment)
TOCTitle: Add Method (String, String)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSkipDirectiveCollection.Add(System.String,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentskipdirectivecollection.add(v=VS.90)
ms:contentKeyID: 20208753
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
- Microsoft.Web.Deployment.DeploymentSkipDirectiveCollection.Add
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Add Method (String, String)

Adds a [DeploymentSkipDirective](deploymentskipdirective-class-microsoft-web-deployment.md) object to the current collection.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubAdd ( _
    nameAsString, _
    skipDirectiveAsString _
)
'Usage
DiminstanceAsDeploymentSkipDirectiveCollectionDimnameAsStringDimskipDirectiveAsString

instance.Add(name, skipDirective)
```

``` csharp
publicvoidAdd(
    stringname,
    stringskipDirective
)
```

``` c++
public:
voidAdd(
    String^ name, 
    String^ skipDirective
)
```

``` jscript
publicfunctionAdd(
    name : String, 
    skipDirective : String
)
```

#### Parameters

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the skip directive to add.  

<!-- end list -->

  - skipDirective  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSkipDirectiveCollection Class](deploymentskipdirectivecollection-class-microsoft-web-deployment.md)

[Add Overload](deploymentskipdirectivecollection-add-method-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

