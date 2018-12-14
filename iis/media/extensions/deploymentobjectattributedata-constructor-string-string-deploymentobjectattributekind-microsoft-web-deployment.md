---
title: DeploymentObjectAttributeData Constructor (String, String, DeploymentObjectAttributeKind) (Microsoft.Web.Deployment)
TOCTitle: DeploymentObjectAttributeData Constructor (String, String, DeploymentObjectAttributeKind)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectAttributeData.#ctor(System.String,System.String,Microsoft.Web.Deployment.DeploymentObjectAttributeKind)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectattributedata.deploymentobjectattributedata(v=VS.90)
ms:contentKeyID: 22753955
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
- Microsoft.Web.Deployment.DeploymentObjectAttributeData..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentObjectAttributeData Constructor (String, String, DeploymentObjectAttributeKind)

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    nameAsString, _
    valueAsString, _
    kindAsDeploymentObjectAttributeKind _
)
'Usage
DimnameAsStringDimvalueAsStringDimkindAsDeploymentObjectAttributeKindDiminstanceAs NewDeploymentObjectAttributeData(name, value, _
    kind)
```

``` csharp
publicDeploymentObjectAttributeData(
    stringname,
    stringvalue,
    DeploymentObjectAttributeKindkind
)
```

``` c++
public:
DeploymentObjectAttributeData(
    String^ name, 
    String^ value, 
    DeploymentObjectAttributeKindkind
)
```

``` jscript
publicfunctionDeploymentObjectAttributeData(
    name : String, 
    value : String, 
    kind : DeploymentObjectAttributeKind
)
```

#### Parameters

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

<!-- end list -->

  - value  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

<!-- end list -->

  - kind  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectAttributeKind](deploymentobjectattributekind-enumeration-microsoft-web-deployment.md)  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectAttributeData Class](deploymentobjectattributedata-class-microsoft-web-deployment.md)

[DeploymentObjectAttributeData Overload](deploymentobjectattributedata-constructor-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

