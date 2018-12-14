---
title: IManagementService.DeleteTaskDefinition Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: DeleteTaskDefinition Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IManagementService.DeleteTaskDefinition(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imanagementservice.deletetaskdefinition(v=VS.90)
ms:contentKeyID: 35520581
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService.DeleteTaskDefinition
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService.DeleteTaskDefinition
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeleteTaskDefinition Method

Deletes a [TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md) object from IIS Transform Manager.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<OperationContractAttribute> _
SubDeleteTaskDefinition ( _
    taskDefinitionIdAsString _
)
'Usage
DiminstanceAsIManagementServiceDimtaskDefinitionIdAsString

instance.DeleteTaskDefinition(taskDefinitionId)
```

``` csharp
[OperationContractAttribute]
voidDeleteTaskDefinition(
    stringtaskDefinitionId
)
```

``` c++
[OperationContractAttribute]
voidDeleteTaskDefinition(
    String^ taskDefinitionId
)
```

``` fsharp
[<OperationContractAttribute>]
abstractDeleteTaskDefinition : 
        taskDefinitionId:string->unit
```

``` jscript
functionDeleteTaskDefinition(
    taskDefinitionId : String
)
```

#### Parameters

  - taskDefinitionId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the [TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md) object to delete.  

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
<td><a href="https://msdn.microsoft.com/en-us/library/2asft85a(v=vs.90)">InvalidOperationException</a></td>
<td><p>The specified task definition is in use.</p></td>
</tr>
</tbody>
</table>


## See Also

#### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

