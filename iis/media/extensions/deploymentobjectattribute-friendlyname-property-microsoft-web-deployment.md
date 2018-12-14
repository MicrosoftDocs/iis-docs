---
title: DeploymentObjectAttribute.FriendlyName Property  (Microsoft.Web.Deployment)
TOCTitle: FriendlyName Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentObjectAttribute.FriendlyName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectattribute.friendlyname(v=VS.90)
ms:contentKeyID: 22754067
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectAttribute.FriendlyName
- Microsoft.Web.Deployment.DeploymentObjectAttribute.get_FriendlyName
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectAttribute.FriendlyName
- Microsoft.Web.Deployment.DeploymentObjectAttribute.get_FriendlyName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# FriendlyName Property

Gets the friendly name of the deployment attribute.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyFriendlyNameAsString
'Usage
DiminstanceAsDeploymentObjectAttributeDimvalueAsStringvalue = instance.FriendlyName
```

``` csharp
publicstringFriendlyName { get; }
```

``` c++
public:
virtualpropertyString^ FriendlyName {
    String^ get () sealed;
}
```

``` jscript
finalfunction getFriendlyName () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the friendly name of the deployment attribute.  

#### Implements

[IDeploymentNameDescription. . :: . .FriendlyName](ideploymentnamedescription-friendlyname-property-microsoft-web-deployment.md)  

## Remarks

Unlike the [Name](deploymentobjectattribute-name-property-microsoft-web-deployment.md) property, friendly names do not need to be unique. They are not used to identify the object in a collection.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectAttribute Class](deploymentobjectattribute-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

