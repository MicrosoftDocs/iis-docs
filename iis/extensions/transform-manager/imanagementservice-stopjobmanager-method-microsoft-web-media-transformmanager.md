---
title: IManagementService.StopJobManager Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: StopJobManager Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IManagementService.StopJobManager(System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.imanagementservice.stopjobmanager(v=VS.90)
ms:contentKeyID: 35521019
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService.StopJobManager
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService.StopJobManager
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# StopJobManager Method

Signals a [JobManager](jobmanager-class-microsoft-web-media-transformmanager.md) object to stop.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<OperationContractAttribute> _
Sub StopJobManager ( _
    jobDefinitionId As String _
)
'Usage

  Dim instance As IManagementService
Dim jobDefinitionId As String

instance.StopJobManager(jobDefinitionId)
```

```csharp
[OperationContractAttribute]
void StopJobManager(
    string jobDefinitionId
)
```

```cpp
[OperationContractAttribute]
void StopJobManager(
    String^ jobDefinitionId
)
```

``` fsharp
[<OperationContractAttribute>]
abstract StopJobManager : 
        jobDefinitionId:string -> unit 
```

```jscript
  function StopJobManager(
    jobDefinitionId : String
)
```

### Parameters

  - jobDefinitionId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object to stop.  

## Remarks

When the StopJobManager method is called, the [JobManager](jobmanager-class-microsoft-web-media-transformmanager.md) object stops creating new jobs, finishes running any jobs that are already started or submitted, and shuts down.

## See Also

### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
