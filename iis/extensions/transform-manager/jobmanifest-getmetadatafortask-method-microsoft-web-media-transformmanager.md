---
title: JobManifest.GetMetadataForTask Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetMetadataForTask Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobManifest.GetMetadataForTask(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanifest.getmetadatafortask(v=VS.90)
ms:contentKeyID: 35521103
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.GetMetadataForTask
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.GetMetadataForTask
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetMetadataForTask Method

Returns the metadata for the specified task.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Function GetMetadataForTask ( _
    taskId As String _
) As XElement
'Usage

  Dim instance As JobManifest
Dim taskId As String
Dim returnValue As XElement

returnValue = instance.GetMetadataForTask(taskId)
```

```csharp
  public XElement GetMetadataForTask(
    string taskId
)
```

```cpp
  public:
XElement^ GetMetadataForTask(
    String^ taskId
)
```

``` fsharp
  member GetMetadataForTask : 
        taskId:string -> XElement 
```

```jscript
  public function GetMetadataForTask(
    taskId : String
) : XElement
```

### Parameters

  - taskId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the task.  

### Return Value

Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
The XML element that contains the task metadata.  

## See Also

### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

