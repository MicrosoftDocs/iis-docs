---
title: DeploymentObjectAttributeCollection.Item Property (String) (Microsoft.Web.Deployment)
TOCTitle: Item Property (String)
ms:assetid: P:Microsoft.Web.Deployment.DeploymentObjectAttributeCollection.Item(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectattributecollection.item(v=VS.90)
ms:contentKeyID: 22753920
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
- Microsoft.Web.Deployment.DeploymentObjectAttributeCollection.get_Item
- Microsoft.Web.Deployment.DeploymentObjectAttributeCollection.Item
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Item Property (String)

Gets the [DeploymentObjectAttribute](deploymentobjectattribute-class-microsoft-web-deployment.md) with the specified name from current collection.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyDefaultPropertyItem ( _
    attributeNameAsString _
) AsDeploymentObjectAttribute
'Usage
DiminstanceAsDeploymentObjectAttributeCollectionDimattributeNameAsStringDimvalueAsDeploymentObjectAttributevalue = instance(attributeName)
```

``` csharp
publicDeploymentObjectAttributethis[
    stringattributeName
] { get; }
```

``` c++
public:
propertyDeploymentObjectAttribute^ default[String^ attributeName] {
    DeploymentObjectAttribute^ get (String^ attributeName);
}
```

``` jscript
JScript does not support indexed properties.
```

#### Parameters

  - attributeName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the attribute to get from the current collection.  

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectAttribute](deploymentobjectattribute-class-microsoft-web-deployment.md)  
A [DeploymentObjectAttribute](deploymentobjectattribute-class-microsoft-web-deployment.md) instance with the specified name.  

## Exceptions

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th>Exception</th>
<th>Condition</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>[ArgumentNullException]</td>
<td><p>name is null Nothing nullptr unit a null reference (Nothing in Visual Basic) reference (Nothing in Visual Basic)</p></td>
</tr>
<tr class="even">
<td>[KeyNotFoundException]</td>
<td><p>The name does not exist in the collection.</p></td>
</tr>
</tbody>
</table>


## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectAttributeCollection Class](deploymentobjectattributecollection-class-microsoft-web-deployment.md)

[Item Overload](deploymentobjectattributecollection-item-property-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

