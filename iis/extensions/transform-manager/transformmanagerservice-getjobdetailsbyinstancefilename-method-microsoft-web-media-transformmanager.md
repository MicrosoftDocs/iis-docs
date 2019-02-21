---
title: TransformManagerService.GetJobDetailsByInstanceFileName Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobDetailsByInstanceFileName Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobDetailsByInstanceFileName(System.String,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.getjobdetailsbyinstancefilename(v=VS.90)
ms:contentKeyID: 36868660
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobDetailsByInstanceFileName
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobDetailsByInstanceFileName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# GetJobDetailsByInstanceFileName Method

Returns a collection of [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) objects based on the instance file name.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Function GetJobDetailsByInstanceFileName ( _
    jobDefinitionId As String, _
    instanceFileName As String _
) As Collection(Of JobDetails)
'Usage

  Dim instance As TransformManagerService
Dim jobDefinitionId As String
Dim instanceFileName As String
Dim returnValue As Collection(Of JobDetails)

returnValue = instance.GetJobDetailsByInstanceFileName(jobDefinitionId, _
    instanceFileName)
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public Collection<JobDetails> GetJobDetailsByInstanceFileName(
    string jobDefinitionId,
    string instanceFileName
)
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual Collection<JobDetails^>^ GetJobDetailsByInstanceFileName(
    String^ jobDefinitionId, 
    String^ instanceFileName
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract GetJobDetailsByInstanceFileName : 
        jobDefinitionId:string * 
        instanceFileName:string -> Collection<JobDetails> 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override GetJobDetailsByInstanceFileName : 
        jobDefinitionId:string * 
        instanceFileName:string -> Collection<JobDetails> 
```

```jscript
  public final function GetJobDetailsByInstanceFileName(
    jobDefinitionId : String, 
    instanceFileName : String
) : Collection<JobDetails>
```

### Parameters

  - jobDefinitionId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of a [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object.  

<!-- end list -->

  - instanceFileName  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The name of the file that instantiated the job.  

### Return Value

Type: [System.Collections.ObjectModel.Collection](https://msdn.microsoft.com/library/ms132397)\< (Of \< ( \<'[JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
A collection of job details.  

### Implements

[IMonitoringService.GetJobDetailsByInstanceFileName(String, String)](imonitoringservice-getjobdetailsbyinstancefilename-method-microsoft-web-media-transformmanager.md)  

## Remarks

The instance file name is created based on a combination of the date and a GUID.

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

