---
title: DeploymentObject.AbsolutePath Property  (Microsoft.Web.Deployment)
TOCTitle: AbsolutePath Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentObject.AbsolutePath
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobject.absolutepath(v=VS.90)
ms:contentKeyID: 20208663
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObject.AbsolutePath
- Microsoft.Web.Deployment.DeploymentObject.get_AbsolutePath
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObject.AbsolutePath
- Microsoft.Web.Deployment.DeploymentObject.get_AbsolutePath
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# AbsolutePath Property

Gets the absolute path of the underlying deployment object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyAbsolutePathAsString
'Usage
DiminstanceAsDeploymentObjectDimvalueAsStringvalue = instance.AbsolutePath
```

``` csharp
publicstringAbsolutePath { get; }
```

``` c++
public:
propertyString^ AbsolutePath {
    String^ get ();
}
```

``` jscript
function getAbsolutePath () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string representing the absolute path of the underlying deployment object.  

## Remarks

This value is obtained through a series of calls to the underlying infrastructure. The deployment object obtains an IDeploymentObjectResolver by accessing the provider's [GetObjectResolver](deploymentobjectprovider-getobjectresolver-method-microsoft-web-deployment.md) method. The absolute path is then returned by accessing the GetAbsolutePath(DeploymentObject) method of the returned interface

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObject Class](deploymentobject-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

