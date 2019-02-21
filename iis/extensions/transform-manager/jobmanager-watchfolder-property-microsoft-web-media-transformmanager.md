---
title: JobManager.WatchFolder Property (Microsoft.Web.Media.TransformManager)
TOCTitle: WatchFolder Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManager.WatchFolder
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanager.watchfolder(v=VS.90)
ms:contentKeyID: 35521192
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager.get_WatchFolder
- Microsoft.Web.Media.TransformManager.JobManager.WatchFolder
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.get_WatchFolder
- Microsoft.Web.Media.TransformManager.JobManager.WatchFolder
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# WatchFolder Property

Gets a file system folder that will be watched for files that instantiate jobs.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property WatchFolder As String
    Get
'Usage

  Dim instance As JobManager
Dim value As String

value = instance.WatchFolder
```

```csharp
  public string WatchFolder { get; }
```

```cpp
  public:
property String^ WatchFolder {
    String^ get ();
}
```

``` fsharp
  member WatchFolder : string
```

```jscript
  function get WatchFolder () : String
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
A file system folder that will be watched for files that instantiate jobs.  

## See Also

### Reference

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

