---
title: IManagementService.TestConnection Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: TestConnection Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IManagementService.TestConnection(Microsoft.Web.Media.TransformManager.JobScheduler,Microsoft.Web.Media.TransformManager.Credential)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imanagementservice.testconnection(v=VS.90)
ms:contentKeyID: 35520623
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService.TestConnection
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService.TestConnection
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TestConnection Method

Tests connectivity of the IIS Transform Manager service to the [Scheduler](scheduler-class-microsoft-web-media-transformmanager.md) object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<OperationContractAttribute> _
FunctionTestConnection ( _
    schedulerAsJobScheduler, _
    credentialAsCredential _
) AsBoolean
'Usage
DiminstanceAsIManagementServiceDimschedulerAsJobSchedulerDimcredentialAsCredentialDimreturnValueAsBooleanreturnValue = instance.TestConnection(scheduler, _
    credential)
```

``` csharp
[OperationContractAttribute]
boolTestConnection(
    JobSchedulerscheduler,
    Credentialcredential
)
```

``` c++
[OperationContractAttribute]
boolTestConnection(
    JobScheduler^ scheduler, 
    Credential^ credential
)
```

``` fsharp
[<OperationContractAttribute>]
abstractTestConnection : 
        scheduler:JobScheduler * 
        credential:Credential->bool
```

``` jscript
functionTestConnection(
    scheduler : JobScheduler, 
    credential : Credential
) : boolean
```

#### Parameters

  - scheduler  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md)  
    The [Scheduler](scheduler-class-microsoft-web-media-transformmanager.md) object to test.  

<!-- end list -->

  - credential  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .Credential](credential-class-microsoft-web-media-transformmanager.md)  
    The [Credential](credential-class-microsoft-web-media-transformmanager.md) object that is required in order to run jobs and access resources.  

#### Return Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the IIS Transform Manager service is able to connect to the [Scheduler](scheduler-class-microsoft-web-media-transformmanager.md) object; otherwise, false.  

## Exceptions

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th>Exception</th>
<th>Condition</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><a href="https://msdn.microsoft.com/en-us/library/2asft85a(v=vs.90)">InvalidOperationException</a></td>
<td><p>The test connection is not valid for a local scheduler.</p></td>
</tr>
<tr class="even">
<td><a href="https://msdn.microsoft.com/en-us/library/dzyy5k3x(v=vs.90)">FileNotFoundException</a></td>
<td><p>HPC client utilities are not installed.</p></td>
</tr>
<tr class="odd">
<td>InvalidDataException</td>
<td><p>The scheduler is not responding.</p></td>
</tr>
</tbody>
</table>


## Remarks

By default, IIS Transform Manager uses the task scheduler on the local server, but it also supports using an HPC scheduler. A credential is required in order to run jobs and access resources on the HPC cluster. That credential can be different from the credential that the IIS Transform Manager service is running under on the local server.

## See Also

#### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

