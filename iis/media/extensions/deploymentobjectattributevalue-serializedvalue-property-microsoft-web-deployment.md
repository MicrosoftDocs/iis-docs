---
title: DeploymentObjectAttributeValue.SerializedValue Property  (Microsoft.Web.Deployment)
TOCTitle: SerializedValue Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentObjectAttributeValue.SerializedValue
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectattributevalue.serializedvalue(v=VS.90)
ms:contentKeyID: 22753950
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectAttributeValue.SerializedValue
- Microsoft.Web.Deployment.DeploymentObjectAttributeValue.get_SerializedValue
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectAttributeValue.get_SerializedValue
- Microsoft.Web.Deployment.DeploymentObjectAttributeValue.SerializedValue
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
PublicMustOverrideReadOnlyPropertySerializedValueAsByte()
'Usage
DiminstanceAsDeploymentObjectAttributeValueDimvalueAsByte()

value = instance.SerializedValue
```

``` csharp
publicabstractbyte[] SerializedValue { get; }
```

``` c++
public:
virtualpropertyarray<unsigned char>^ SerializedValue {
    array<unsigned char>^ get () abstract;
}
```

``` jscript
abstractfunction getSerializedValue () : byte[]
```

#### Property Value

Type: array\<[System. . :: . .Byte](https://msdn.microsoft.com/en-us/library/yyb1w04y\(v=vs.90\))\> \[\] () \[\] \[\]  
Returns [Byte](https://msdn.microsoft.com/en-us/library/yyb1w04y\(v=vs.90\)).  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectAttributeValue Class](deploymentobjectattributevalue-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

