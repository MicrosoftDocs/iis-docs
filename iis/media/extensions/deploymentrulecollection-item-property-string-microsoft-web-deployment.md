---
title: DeploymentRuleCollection.Item Property (String) (Microsoft.Web.Deployment)
TOCTitle: Item Property (String)
ms:assetid: P:Microsoft.Web.Deployment.DeploymentRuleCollection.Item(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentrulecollection.item(v=VS.90)
ms:contentKeyID: 20208711
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
- Microsoft.Web.Deployment.DeploymentRuleCollection.get_Item
- Microsoft.Web.Deployment.DeploymentRuleCollection.Item
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Item Property (String)

Gets the DeploymentRule with the specified name from the current collection.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyDefaultPropertyItem ( _
    nameAsString _
) AsDeploymentRule
'Usage
DiminstanceAsDeploymentRuleCollectionDimnameAsStringDimvalueAsDeploymentRulevalue = instance(name)
```

``` csharp
publicDeploymentRulethis[
    stringname
] { get; }
```

``` c++
public:
propertyDeploymentRule^ default[String^ name] {
    DeploymentRule^ get (String^ name);
}
```

``` jscript
JScript does not support indexed properties.
```

#### Parameters

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the [DeploymentRule](deploymentrule-class-microsoft-web-deployment.md) to find in the current collection.  

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentRule](deploymentrule-class-microsoft-web-deployment.md)  
A [DeploymentRule](deploymentrule-class-microsoft-web-deployment.md) with the specified name if one exists.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentRuleCollection Class](deploymentrulecollection-class-microsoft-web-deployment.md)

[Item Overload](deploymentrulecollection-item-property-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

