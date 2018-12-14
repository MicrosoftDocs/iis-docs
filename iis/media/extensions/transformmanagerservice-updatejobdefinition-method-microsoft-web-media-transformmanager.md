---
title: TransformManagerService.UpdateJobDefinition Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: UpdateJobDefinition Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.UpdateJobDefinition(Microsoft.Web.Media.TransformManager.JobDefinition)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.updatejobdefinition(v=VS.90)
ms:contentKeyID: 35521107
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.UpdateJobDefinition
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.UpdateJobDefinition
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# UpdateJobDefinition Method

Adds or updates the specified [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
PublicSubUpdateJobDefinition ( _
    jobDefinitionAsJobDefinition _
)
'Usage
DiminstanceAsTransformManagerServiceDimjobDefinitionAsJobDefinition

instance.UpdateJobDefinition(jobDefinition)
```

``` csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
publicvoidUpdateJobDefinition(
    JobDefinitionjobDefinition
)
```

``` c++
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtualvoidUpdateJobDefinition(
    JobDefinition^ jobDefinition
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstractUpdateJobDefinition : 
        jobDefinition:JobDefinition->unit 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
overrideUpdateJobDefinition : 
        jobDefinition:JobDefinition->unit
```

``` jscript
publicfinalfunctionUpdateJobDefinition(
    jobDefinition : JobDefinition
)
```

#### Parameters

  - jobDefinition  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md)  
    The ID of the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object to add or update.  

#### Implements

[IManagementService. . :: . .UpdateJobDefinition(JobDefinition)](imanagementservice-updatejobdefinition-method-microsoft-web-media-transformmanager.md)  

## Remarks

A [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object is used to define how IIS Transform Manager monitors, creates, schedules, and maintains jobs.

## See Also

#### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

