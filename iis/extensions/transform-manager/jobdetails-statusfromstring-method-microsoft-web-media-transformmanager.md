---
title: JobDetails.StatusFromString Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: StatusFromString Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobDetails.StatusFromString(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.statusfromstring(v=VS.90)
ms:contentKeyID: 35521049
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.StatusFromString
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.StatusFromString
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# StatusFromString Method

Returns a [JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md) object that corresponds to the specified status string.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Shared Function StatusFromString ( _
    status As String _
) As JobStatus
'Usage

  Dim status As String
Dim returnValue As JobStatus

returnValue = JobDetails.StatusFromString(status)
```

```csharp
  public static JobStatus StatusFromString(
    string status
)
```

```cpp
  public:
static JobStatus StatusFromString(
    String^ status
)
```

``` fsharp
  static member StatusFromString : 
        status:string -> JobStatus 
```

```jscript
  public static function StatusFromString(
    status : String
) : JobStatus
```

### Parameters

  - status  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The status to get the [JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md) object for.  

### Return Value

Type: [Microsoft.Web.Media.TransformManager.JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
The job status.  

## Remarks

This method converts a string into a field as defined in the [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) type. If the status parameter does not match any of the known values, the [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object is set to [Unknown](jobstatus-enumeration-microsoft-web-media-transformmanager.md).

## See Also

### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

