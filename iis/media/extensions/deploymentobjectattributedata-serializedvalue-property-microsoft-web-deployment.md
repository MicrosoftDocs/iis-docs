---
title: DeploymentObjectAttributeData.SerializedValue Property  (Microsoft.Web.Deployment)
TOCTitle: SerializedValue Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentObjectAttributeData.SerializedValue
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectattributedata.serializedvalue(v=VS.90)
ms:contentKeyID: 22754059
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectAttributeData.SerializedValue
- Microsoft.Web.Deployment.DeploymentObjectAttributeData.get_SerializedValue
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectAttributeData.get_SerializedValue
- Microsoft.Web.Deployment.DeploymentObjectAttributeData.SerializedValue
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SerializedValue Property

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertySerializedValueAsByte()
'Usage
DiminstanceAsDeploymentObjectAttributeDataDimvalueAsByte()

value = instance.SerializedValue
```

``` csharp
publicbyte[] SerializedValue { get; }
```

``` c++
public:
propertyarray<unsigned char>^ SerializedValue {
    array<unsigned char>^ get ();
}
```

``` jscript
function getSerializedValue () : byte[]
```

#### Property Value

Type: array\<[System. . :: . .Byte](https://msdn.microsoft.com/en-us/library/yyb1w04y\(v=vs.90\))\> \[\] () \[\] \[\]  
Returns [Byte](https://msdn.microsoft.com/en-us/library/yyb1w04y\(v=vs.90\)).  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectAttributeData Class](deploymentobjectattributedata-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

