---
title: TransformManagerService.UpdateTaskDefinition Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: UpdateTaskDefinition Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.UpdateTaskDefinition(Microsoft.Web.Media.TransformManager.TaskDefinition)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.updatetaskdefinition(v=VS.90)
ms:contentKeyID: 35520789
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.UpdateTaskDefinition
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.UpdateTaskDefinition
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# UpdateTaskDefinition Method

Adds or updates the specified [TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md) object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Sub UpdateTaskDefinition ( _
    taskDefinition As TaskDefinition _
)
'Usage

  Dim instance As TransformManagerService
Dim taskDefinition As TaskDefinition

instance.UpdateTaskDefinition(taskDefinition)
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public void UpdateTaskDefinition(
    TaskDefinition taskDefinition
)
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual void UpdateTaskDefinition(
    TaskDefinition^ taskDefinition
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract UpdateTaskDefinition : 
        taskDefinition:TaskDefinition -> unit 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override UpdateTaskDefinition : 
        taskDefinition:TaskDefinition -> unit 
```

```jscript
  public final function UpdateTaskDefinition(
    taskDefinition : TaskDefinition
)
```

### Parameters

  - taskDefinition  
    Type: [Microsoft.Web.Media.TransformManager.TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md)  
    A [TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md) object to add or update.  

### Implements

[IManagementService.UpdateTaskDefinition(TaskDefinition)](imanagementservice-updatetaskdefinition-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

