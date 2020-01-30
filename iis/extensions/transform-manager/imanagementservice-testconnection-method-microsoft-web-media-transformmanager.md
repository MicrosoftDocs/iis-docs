---
title: IManagementService.TestConnection Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: TestConnection Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IManagementService.TestConnection(Microsoft.Web.Media.TransformManager.JobScheduler,Microsoft.Web.Media.TransformManager.Credential)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.imanagementservice.testconnection(v=VS.90)
ms:contentKeyID: 35520623
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService.TestConnection
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService.TestConnection
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TestConnection Method

Tests connectivity of the IIS Transform Manager service to the [Scheduler](scheduler-class-microsoft-web-media-transformmanager.md) object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<OperationContractAttribute> _
Function TestConnection ( _
    scheduler As JobScheduler, _
    credential As Credential _
) As Boolean
'Usage

  Dim instance As IManagementService
Dim scheduler As JobScheduler
Dim credential As Credential
Dim returnValue As Boolean

returnValue = instance.TestConnection(scheduler, _
    credential)
```

```csharp
[OperationContractAttribute]
bool TestConnection(
    JobScheduler scheduler,
    Credential credential
)
```

```cpp
[OperationContractAttribute]
bool TestConnection(
    JobScheduler^ scheduler, 
    Credential^ credential
)
```

``` fsharp
[<OperationContractAttribute>]
abstract TestConnection : 
        scheduler:JobScheduler * 
        credential:Credential -> bool 
```

```jscript
  function TestConnection(
    scheduler : JobScheduler, 
    credential : Credential
) : boolean
```

### Parameters

  - scheduler  
    Type: [Microsoft.Web.Media.TransformManager.JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md)  
    The [Scheduler](scheduler-class-microsoft-web-media-transformmanager.md) object to test.  

<!-- end list -->

  - credential  
    Type: [Microsoft.Web.Media.TransformManager.Credential](credential-class-microsoft-web-media-transformmanager.md)  
    The [Credential](credential-class-microsoft-web-media-transformmanager.md) object that is required in order to run jobs and access resources.  

### Return Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the IIS Transform Manager service is able to connect to the [Scheduler](scheduler-class-microsoft-web-media-transformmanager.md) object; otherwise, false.  

## Exceptions

|Exception|Condition|
|--- |--- |
|[InvalidOperationException](https://msdn.microsoft.com/library/2asft85a)|The test connection is not valid for a local scheduler.|
|[FileNotFoundException](https://msdn.microsoft.com/library/dzyy5k3x)|HPC client utilities are not installed.|
|InvalidDataException|The scheduler is not responding.|


## Remarks

By default, IIS Transform Manager uses the task scheduler on the local server, but it also supports using an HPC scheduler. A credential is required in order to run jobs and access resources on the HPC cluster. That credential can be different from the credential that the IIS Transform Manager service is running under on the local server.

## See Also

### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

