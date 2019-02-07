---
title: JobManifest.WorkQueueRoot Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: WorkQueueRoot Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManifest.WorkQueueRoot
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanifest.workqueueroot(v=VS.90)
ms:contentKeyID: 35520895
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.get_WorkQueueRoot
- Microsoft.Web.Media.TransformManager.JobManifest.WorkQueueRoot
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.get_WorkQueueRoot
- Microsoft.Web.Media.TransformManager.JobManifest.WorkQueueRoot
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# WorkQueueRoot Property

Gets the root work folder name.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration

  Public ReadOnly Property WorkQueueRoot As String
    Get
'Usage

  Dim instance As JobManifest
Dim value As String

value = instance.WorkQueueRoot
```

``` csharp
  public string WorkQueueRoot { get; }
```

``` c++
  public:
property String^ WorkQueueRoot {
    String^ get ();
}
```

``` fsharp
  member WorkQueueRoot : string
```

``` jscript
  function get WorkQueueRoot () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The root work folder name ("WorkQueue").  

## See Also

#### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

