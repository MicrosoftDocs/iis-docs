---
title: TransformManagerService.GetJobDetailsById Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobDetailsById Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobDetailsById(System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.transformmanagerservice.getjobdetailsbyid(v=VS.90)
ms:contentKeyID: 35520567
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobDetailsById
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobDetailsById
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetJobDetailsById Method

Returns a [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object for the specified job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Function GetJobDetailsById ( _
    jobId As String _
) As JobDetails
'Usage

  Dim instance As TransformManagerService
Dim jobId As String
Dim returnValue As JobDetails

returnValue = instance.GetJobDetailsById(jobId)
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public JobDetails GetJobDetailsById(
    string jobId
)
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual JobDetails^ GetJobDetailsById(
    String^ jobId
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract GetJobDetailsById : 
        jobId:string -> JobDetails 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override GetJobDetailsById : 
        jobId:string -> JobDetails 
```

```jscript
  public final function GetJobDetailsById(
    jobId : String
) : JobDetails
```

### Parameters

  - jobId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the job to return.  

### Return Value

Type: [Microsoft.Web.Media.TransformManager.JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)  
The [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object.  

### Implements

[IMonitoringService.GetJobDetailsById(String)](imonitoringservice-getjobdetailsbyid-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
