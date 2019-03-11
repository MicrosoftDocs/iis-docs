---
title: TransformManagerService.GetJobDefinition Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobDefinition Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobDefinition(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.getjobdefinition(v=VS.90)
ms:contentKeyID: 35520641
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobDefinition
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobDefinition
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetJobDefinition Method

Returns a [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object that defines how IIS Transform Manager monitors, creates, schedules, and maintains jobs.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Function GetJobDefinition ( _
    jobDefinitionId As String _
) As JobDefinition
'Usage

  Dim instance As TransformManagerService
Dim jobDefinitionId As String
Dim returnValue As JobDefinition

returnValue = instance.GetJobDefinition(jobDefinitionId)
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public JobDefinition GetJobDefinition(
    string jobDefinitionId
)
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual JobDefinition^ GetJobDefinition(
    String^ jobDefinitionId
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract GetJobDefinition : 
        jobDefinitionId:string -> JobDefinition 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override GetJobDefinition : 
        jobDefinitionId:string -> JobDefinition 
```

```jscript
  public final function GetJobDefinition(
    jobDefinitionId : String
) : JobDefinition
```

### Parameters

  - jobDefinitionId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object to get.  

### Return Value

Type: [Microsoft.Web.Media.TransformManager.JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md)  
The [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object.  

### Implements

[IManagementService.GetJobDefinition(String)](imanagementservice-getjobdefinition-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

