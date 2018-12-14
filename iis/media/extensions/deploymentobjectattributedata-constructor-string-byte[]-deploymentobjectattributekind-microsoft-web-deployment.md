---
title: DeploymentObjectAttributeData Constructor (String, Byte[], DeploymentObjectAttributeKind) (Microsoft.Web.Deployment)
TOCTitle: DeploymentObjectAttributeData Constructor (String, Byte[], DeploymentObjectAttributeKind)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectAttributeData.#ctor(System.String,System.Byte[],Microsoft.Web.Deployment.DeploymentObjectAttributeKind)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectattributedata.deploymentobjectattributedata(v=VS.90)
ms:contentKeyID: 22753949
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

# DeploymentObjectAttributeData Constructor (String, Byte\[\], DeploymentObjectAttributeKind)

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    nameAsString, _
    valueAsByte(), _
    kindAsDeploymentObjectAttributeKind _
)
'Usage
DimnameAsStringDimvalueAsByte()
DimkindAsDeploymentObjectAttributeKindDiminstanceAs NewDeploymentObjectAttributeData(name, value, _
    kind)
```

``` csharp
publicDeploymentObjectAttributeData(
    stringname,
    byte[] value,
    DeploymentObjectAttributeKindkind
)
```

``` c++
public:
DeploymentObjectAttributeData(
    String^ name, 
    array<unsigned char>^ value, 
    DeploymentObjectAttributeKindkind
)
```

``` jscript
publicfunctionDeploymentObjectAttributeData(
    name : String, 
    value : byte[], 
    kind : DeploymentObjectAttributeKind
)
```

#### Parameters

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

<!-- end list -->

  - value  
    Type: array\<[System. . :: . .Byte](https://msdn.microsoft.com/en-us/library/yyb1w04y\(v=vs.90\))\> \[\] () \[\] \[\]  

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

