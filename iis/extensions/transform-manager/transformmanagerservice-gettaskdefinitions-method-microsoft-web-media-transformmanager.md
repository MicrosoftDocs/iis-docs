---
title: TransformManagerService.GetTaskDefinitions Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetTaskDefinitions Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.GetTaskDefinitions
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.transformmanagerservice.gettaskdefinitions(v=VS.90)
ms:contentKeyID: 35521111
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetTaskDefinitions
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetTaskDefinitions
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetTaskDefinitions Method

Returns a list of [TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md) objects from IIS Transform Manager.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Function GetTaskDefinitions As Collection(Of TaskDefinition)
'Usage

  Dim instance As TransformManagerService
Dim returnValue As Collection(Of TaskDefinition)

returnValue = instance.GetTaskDefinitions()
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public Collection<TaskDefinition> GetTaskDefinitions()
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual Collection<TaskDefinition^>^ GetTaskDefinitions() sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract GetTaskDefinitions : unit -> Collection<TaskDefinition>
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override GetTaskDefinitions : unit -> Collection<TaskDefinition>
```

```jscript
  public final function GetTaskDefinitions() : Collection<TaskDefinition>
```

### Return Value

Type: [System.Collections.ObjectModel.Collection](https://msdn.microsoft.com/library/ms132397)\< (Of \< ( \<'[TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
A collection of [TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md) objects.  

### Implements

[IManagementService.GetTaskDefinitions() () () ()](imanagementservice-gettaskdefinitions-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
