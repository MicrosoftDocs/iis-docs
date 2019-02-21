---
title: LocalScheduler.GetJobCompletionDetails Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobCompletionDetails Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.LocalScheduler.GetJobCompletionDetails(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.localscheduler.getjobcompletiondetails(v=VS.90)
ms:contentKeyID: 35520656
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.LocalScheduler.GetJobCompletionDetails
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.LocalScheduler.GetJobCompletionDetails
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetJobCompletionDetails Method

Returns a report about the specified job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Overrides Function GetJobCompletionDetails ( _
    jobInstanceId As String _
) As XElement
'Usage

  Dim instance As LocalScheduler
Dim jobInstanceId As String
Dim returnValue As XElement

returnValue = instance.GetJobCompletionDetails(jobInstanceId)
```

```csharp
  public override XElement GetJobCompletionDetails(
    string jobInstanceId
)
```

```cpp
  public:
virtual XElement^ GetJobCompletionDetails(
    String^ jobInstanceId
) override
```

``` fsharp
  abstract GetJobCompletionDetails : 
        jobInstanceId:string -> XElement 
override GetJobCompletionDetails : 
        jobInstanceId:string -> XElement 
```

```jscript
  public override function GetJobCompletionDetails(
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

[LocalScheduler Class](localscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

