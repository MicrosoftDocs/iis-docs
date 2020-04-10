---
title: TransformManagerService.DeleteTaskDefinition Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: DeleteTaskDefinition Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.DeleteTaskDefinition(System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.transformmanagerservice.deletetaskdefinition(v=VS.90)
ms:contentKeyID: 35521064
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.DeleteTaskDefinition
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.DeleteTaskDefinition
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# DeleteTaskDefinition Method

Deletes a [TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md) object from IIS Transform Manager.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Sub DeleteTaskDefinition ( _
    taskDefinitionId As String _
)
'Usage

  Dim instance As TransformManagerService
Dim taskDefinitionId As String

instance.DeleteTaskDefinition(taskDefinitionId)
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public void DeleteTaskDefinition(
    string taskDefinitionId
)
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual void DeleteTaskDefinition(
    String^ taskDefinitionId
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract DeleteTaskDefinition : 
        taskDefinitionId:string -> unit 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override DeleteTaskDefinition : 
        taskDefinitionId:string -> unit 
```

```jscript
  public final function DeleteTaskDefinition(
    taskDefinitionId : String
)
```

### Parameters

  - taskDefinitionId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the [TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md) object to delete.  

### Implements

[IManagementService.DeleteTaskDefinition(String)](imanagementservice-deletetaskdefinition-method-microsoft-web-media-transformmanager.md)  

## Exceptions

|Exception|Condition|
|--- |--- |
|[InvalidOperationException](https://msdn.microsoft.com/library/2asft85a)|The task definition is in use and cannot be deleted.|

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
