---
title: TransformManagerService.StartJobManager Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: StartJobManager Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.StartJobManager(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.startjobmanager(v=VS.90)
ms:contentKeyID: 35521003
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.StartJobManager
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.StartJobManager
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# StartJobManager Method

Enables jobs to be processed using a [JobManager](jobmanager-class-microsoft-web-media-transformmanager.md) object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
PublicSubStartJobManager ( _
    jobDefinitionIdAsString _
)
'Usage
DiminstanceAsTransformManagerServiceDimjobDefinitionIdAsString

instance.StartJobManager(jobDefinitionId)
```

``` csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
publicvoidStartJobManager(
    stringjobDefinitionId
)
```

``` c++
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtualvoidStartJobManager(
    String^ jobDefinitionId
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstractStartJobManager : 
        jobDefinitionId:string->unit 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
overrideStartJobManager : 
        jobDefinitionId:string->unit
```

``` jscript
publicfinalfunctionStartJobManager(
    jobDefinitionId : String
)
```

#### Parameters

  - jobDefinitionId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object that will be used to process jobs.  

#### Implements

[IManagementService. . :: . .StartJobManager(String)](imanagementservice-startjobmanager-method-microsoft-web-media-transformmanager.md)  

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
<td><p>The job manager is in the process of shutting down.</p></td>
</tr>
<tr class="even">
<td><a href="https://msdn.microsoft.com/en-us/library/2asft85a(v=vs.90)">InvalidOperationException</a></td>
<td><p>The job manager is already running.</p></td>
</tr>
<tr class="odd">
<td><a href="https://msdn.microsoft.com/en-us/library/f2y9aa54(v=vs.90)">UnauthorizedAccessException</a></td>
<td><p>The job manager is unable to create a watch folder.</p></td>
</tr>
<tr class="even">
<td><a href="https://msdn.microsoft.com/en-us/library/hccy4eyd(v=vs.90)">IOException</a></td>
<td><p>The job manager is unable to create a watch folder.</p></td>
</tr>
</tbody>
</table>


## See Also

#### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

