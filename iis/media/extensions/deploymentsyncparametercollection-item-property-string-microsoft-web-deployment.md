---
title: DeploymentSyncParameterCollection.Item Property (String) (Microsoft.Web.Deployment)
TOCTitle: Item Property (String)
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSyncParameterCollection.Item(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparametercollection.item(v=VS.90)
ms:contentKeyID: 20208983
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

# Item Property (String)

Gets the [DeploymentSyncParameter](deploymentsyncparameter-class-microsoft-web-deployment.md) with the specified name.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyDefaultPropertyItem ( _
    nameAsString _
) AsDeploymentSyncParameter
'Usage
DiminstanceAsDeploymentSyncParameterCollectionDimnameAsStringDimvalueAsDeploymentSyncParametervalue = instance(name)
```

``` csharp
publicDeploymentSyncParameterthis[
    stringname
] { get; }
```

``` c++
public:
propertyDeploymentSyncParameter^ default[String^ name] {
    DeploymentSyncParameter^ get (String^ name);
}
```

``` jscript
JScript does not support indexed properties.
```

#### Parameters

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the parameter to get.  

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentSyncParameter](deploymentsyncparameter-class-microsoft-web-deployment.md)  
The value associated with the specified key. If the specified key is not found, a get operation throws a KeyNotFoundException.  

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

[DeploymentSyncParameterCollection Class](deploymentsyncparametercollection-class-microsoft-web-deployment.md)

[Item Overload](deploymentsyncparametercollection-item-property-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

