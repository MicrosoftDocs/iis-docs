---
title: IManagementService.DeleteJobDefinition Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: DeleteJobDefinition Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IManagementService.DeleteJobDefinition(System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.imanagementservice.deletejobdefinition(v=VS.90)
ms:contentKeyID: 35521027
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService.DeleteJobDefinition
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService.DeleteJobDefinition
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# DeleteJobDefinition Method

Deletes a [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object from IIS Transform Manager.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<OperationContractAttribute> _
Sub DeleteJobDefinition ( _
    jobDefinitionId As String _
)
'Usage

  Dim instance As IManagementService
Dim jobDefinitionId As String

instance.DeleteJobDefinition(jobDefinitionId)
```

```csharp
[OperationContractAttribute]
void DeleteJobDefinition(
    string jobDefinitionId
)
```

```cpp
[OperationContractAttribute]
void DeleteJobDefinition(
    String^ jobDefinitionId
)
```

``` fsharp
[<OperationContractAttribute>]
abstract DeleteJobDefinition : 
        jobDefinitionId:string -> unit 
```

```jscript
  function DeleteJobDefinition(
    jobDefinitionId : String
)
```

### Parameters

  - jobDefinitionId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object to delete.  

## Remarks

A [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object is used to define how IIS Transform Manager monitors, creates, schedules, and maintains jobs.

## See Also

### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
