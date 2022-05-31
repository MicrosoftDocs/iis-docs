---
title: TransformManagerService.StartJobManager Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: StartJobManager Method
description: Describes the TransformManagerService.StartJobManager method and provides the syntax, parameters, and exceptions.
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.StartJobManager(System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.transformmanagerservice.startjobmanager(v=VS.90)
ms:contentKeyID: 35521003
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.StartJobManager
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.StartJobManager
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# StartJobManager Method

Enables jobs to be processed using a [JobManager](jobmanager-class-microsoft-web-media-transformmanager.md) object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Sub StartJobManager ( _
    jobDefinitionId As String _
)
'Usage

  Dim instance As TransformManagerService
Dim jobDefinitionId As String

instance.StartJobManager(jobDefinitionId)
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public void StartJobManager(
    string jobDefinitionId
)
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual void StartJobManager(
    String^ jobDefinitionId
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract StartJobManager : 
        jobDefinitionId:string -> unit 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override StartJobManager : 
        jobDefinitionId:string -> unit 
```

```jscript
  public final function StartJobManager(
    jobDefinitionId : String
)
```

### Parameters

  - jobDefinitionId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object that will be used to process jobs.  

### Implements

[IManagementService.StartJobManager(String)](imanagementservice-startjobmanager-method-microsoft-web-media-transformmanager.md)  

## Exceptions

|Exception|Condition|
|--- |--- |
|[InvalidOperationException](https://msdn.microsoft.com/library/2asft85a)|The job manager is in the process of shutting down.|
|[InvalidOperationException](https://msdn.microsoft.com/library/2asft85a)|The job manager is already running.|
|[UnauthorizedAccessException](https://msdn.microsoft.com/library/f2y9aa54)|The job manager is unable to create a watch folder.|
|[IOException](https://msdn.microsoft.com/library/hccy4eyd)|The job manager is unable to create a watch folder.|

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
