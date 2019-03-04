---
title: TransformManagerService.StopJobManager Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: StopJobManager Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.StopJobManager(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.stopjobmanager(v=VS.90)
ms:contentKeyID: 35520893
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.StopJobManager
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.StopJobManager
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# StopJobManager Method

Signals a [JobManager](jobmanager-class-microsoft-web-media-transformmanager.md) object to stop.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Sub StopJobManager ( _
    jobDefinitionId As String _
)
'Usage

  Dim instance As TransformManagerService
Dim jobDefinitionId As String

instance.StopJobManager(jobDefinitionId)
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public void StopJobManager(
    string jobDefinitionId
)
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual void StopJobManager(
    String^ jobDefinitionId
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract StopJobManager : 
        jobDefinitionId:string -> unit 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override StopJobManager : 
        jobDefinitionId:string -> unit 
```

```jscript
  public final function StopJobManager(
    jobDefinitionId : String
)
```

### Parameters

  - jobDefinitionId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object to stop.  

### Implements

[IManagementService.StopJobManager(String)](imanagementservice-stopjobmanager-method-microsoft-web-media-transformmanager.md)  

## Exceptions

|Exception|Condition|
|--- |--- |
|[ArgumentNullException](https://msdn.microsoft.com/library/27426hcy)|jobDetails is null Nothing nullptr unit a null reference (Nothing in Visual Basic) or the JobDefinitionId property of the jobDetails parameter is null Nothing nullptr unit a null reference (Nothing in Visual Basic) .|

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

