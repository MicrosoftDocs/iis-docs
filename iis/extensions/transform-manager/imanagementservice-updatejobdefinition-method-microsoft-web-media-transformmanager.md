---
title: IManagementService.UpdateJobDefinition Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: UpdateJobDefinition Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IManagementService.UpdateJobDefinition(Microsoft.Web.Media.TransformManager.JobDefinition)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.imanagementservice.updatejobdefinition(v=VS.90)
ms:contentKeyID: 35520694
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService.UpdateJobDefinition
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService.UpdateJobDefinition
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# UpdateJobDefinition Method

Adds or replaces a [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<OperationContractAttribute> _
Sub UpdateJobDefinition ( _
    jobDefinition As JobDefinition _
)
'Usage

  Dim instance As IManagementService
Dim jobDefinition As JobDefinition

instance.UpdateJobDefinition(jobDefinition)
```

```csharp
[OperationContractAttribute]
void UpdateJobDefinition(
    JobDefinition jobDefinition
)
```

```cpp
[OperationContractAttribute]
void UpdateJobDefinition(
    JobDefinition^ jobDefinition
)
```

``` fsharp
[<OperationContractAttribute>]
abstract UpdateJobDefinition : 
        jobDefinition:JobDefinition -> unit 
```

```jscript
  function UpdateJobDefinition(
    jobDefinition : JobDefinition
)
```

### Parameters

  - jobDefinition  
    Type: [Microsoft.Web.Media.TransformManager.JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md)  
    The ID of the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object to update.  

## Remarks

A [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object is used to define how IIS Transform Manager monitors, creates, schedules, and maintains jobs.

## See Also

### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
