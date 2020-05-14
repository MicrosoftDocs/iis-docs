---
title: Scheduler.GetJobCompletionDetails Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobCompletionDetails Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.Scheduler.GetJobCompletionDetails(System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.scheduler.getjobcompletiondetails(v=VS.90)
ms:contentKeyID: 35520649
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Scheduler.GetJobCompletionDetails
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Scheduler.GetJobCompletionDetails
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetJobCompletionDetails Method

Returns a report about the specified job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public MustOverride Function GetJobCompletionDetails ( _
    jobInstanceId As String _
) As XElement
'Usage

  Dim instance As Scheduler
Dim jobInstanceId As String
Dim returnValue As XElement

returnValue = instance.GetJobCompletionDetails(jobInstanceId)
```

```csharp
  public abstract XElement GetJobCompletionDetails(
    string jobInstanceId
)
```

```cpp
  public:
virtual XElement^ GetJobCompletionDetails(
    String^ jobInstanceId
) abstract
```

``` fsharp
  abstract GetJobCompletionDetails :
        jobInstanceId:string -> XElement
```

```jscript
  public abstract function GetJobCompletionDetails(
    jobInstanceId : String
) : XElement
```

### Parameters

  - jobInstanceId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the job.  

### Return Value

Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
An XML element that contains a report about the job instance.  

## See Also

### Reference

[Scheduler Class](scheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
