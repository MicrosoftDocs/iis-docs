---
title: TransformManagerService.GetJobSchedulers Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobSchedulers Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobSchedulers
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.getjobschedulers(v=VS.90)
ms:contentKeyID: 35521171
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobSchedulers
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobSchedulers
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# GetJobSchedulers Method

Returns all [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) objects from IIS Transform Manager.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Function GetJobSchedulers As Collection(Of JobScheduler)
'Usage

  Dim instance As TransformManagerService
Dim returnValue As Collection(Of JobScheduler)

returnValue = instance.GetJobSchedulers()
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public Collection<JobScheduler> GetJobSchedulers()
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual Collection<JobScheduler^>^ GetJobSchedulers() sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract GetJobSchedulers : unit -> Collection<JobScheduler> 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override GetJobSchedulers : unit -> Collection<JobScheduler> 
```

```jscript
  public final function GetJobSchedulers() : Collection<JobScheduler>
```

### Return Value

Type: [System.Collections.ObjectModel.Collection](https://msdn.microsoft.com/library/ms132397)\< (Of \< ( \<'[JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
A collection of [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) objects.  

### Implements

[IManagementService.GetJobSchedulers() () () ()](imanagementservice-getjobschedulers-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

