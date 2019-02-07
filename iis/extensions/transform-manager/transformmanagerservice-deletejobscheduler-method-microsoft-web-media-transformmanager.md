---
title: TransformManagerService.DeleteJobScheduler Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: DeleteJobScheduler Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.DeleteJobScheduler(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.deletejobscheduler(v=VS.90)
ms:contentKeyID: 35520951
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.DeleteJobScheduler
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.DeleteJobScheduler
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeleteJobScheduler Method

Deletes a [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) object from IIS Transform Manager.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Sub DeleteJobScheduler ( _
    jobSchedulerId As String _
)
'Usage

  Dim instance As TransformManagerService
Dim jobSchedulerId As String

instance.DeleteJobScheduler(jobSchedulerId)
```

``` csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public void DeleteJobScheduler(
    string jobSchedulerId
)
```

``` c++
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual void DeleteJobScheduler(
    String^ jobSchedulerId
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract DeleteJobScheduler : 
        jobSchedulerId:string -> unit 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override DeleteJobScheduler : 
        jobSchedulerId:string -> unit 
```

``` jscript
  public final function DeleteJobScheduler(
    jobSchedulerId : String
)
```

#### Parameters

  - jobSchedulerId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) object to delete.  

#### Implements

[IManagementService. . :: . .DeleteJobScheduler(String)](imanagementservice-deletejobscheduler-method-microsoft-web-media-transformmanager.md)  

## Exceptions

|Exception|Condition|
|--- |--- |
|[InvalidOperationException](https://msdn.microsoft.com/en-us/library/2asft85a(v=vs.90))|The job scheduler is in use and cannot be deleted.|

## See Also

#### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

