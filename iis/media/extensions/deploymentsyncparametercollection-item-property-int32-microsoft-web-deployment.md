---
title: DeploymentSyncParameterCollection.Item Property (Int32) (Microsoft.Web.Deployment)
TOCTitle: Item Property (Int32)
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSyncParameterCollection.Item(System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparametercollection.item(v=VS.90)
ms:contentKeyID: 20209164
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
- Microsoft.Web.Deployment.DeploymentSyncParameterCollection.get_Item
- Microsoft.Web.Deployment.DeploymentSyncParameterCollection.Item
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Item Property (Int32)

Gets the [DeploymentSyncParameter](deploymentsyncparameter-class-microsoft-web-deployment.md) at the specified index.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyDefaultPropertyItem ( _
    indexAsInteger _
) AsDeploymentSyncParameter
'Usage
DiminstanceAsDeploymentSyncParameterCollectionDimindexAsIntegerDimvalueAsDeploymentSyncParametervalue = instance(index)
```

``` csharp
publicDeploymentSyncParameterthis[
    intindex
] { get; }
```

``` c++
public:
propertyDeploymentSyncParameter^ default[intindex] {
    DeploymentSyncParameter^ get (intindex);
}
```

``` jscript
JScript does not support indexed properties.
```

#### Parameters

  - index  
    Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
    The zero-based index of the element to get.  

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentSyncParameter](deploymentsyncparameter-class-microsoft-web-deployment.md)  
The element at the specified index.  

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
<td>[ArgumentOutOfRangeException]</td>
<td><p>index is not a valid index in the collection.</p></td>
</tr>
</tbody>
</table>


## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncParameterCollection Class](deploymentsyncparametercollection-class-microsoft-web-deployment.md)

[Item Overload](deploymentsyncparametercollection-item-property-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

