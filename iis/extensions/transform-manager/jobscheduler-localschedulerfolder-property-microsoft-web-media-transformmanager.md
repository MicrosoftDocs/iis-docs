---
title: JobScheduler.LocalSchedulerFolder Property (Microsoft.Web.Media.TransformManager)
TOCTitle: LocalSchedulerFolder Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobScheduler.LocalSchedulerFolder
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobscheduler.localschedulerfolder(v=VS.90)
ms:contentKeyID: 35520576
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobScheduler.get_LocalSchedulerFolder
- Microsoft.Web.Media.TransformManager.JobScheduler.LocalSchedulerFolder
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobScheduler.get_LocalSchedulerFolder
- Microsoft.Web.Media.TransformManager.JobScheduler.LocalSchedulerFolder
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# LocalSchedulerFolder Property

Gets the local scheduler folder name.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Shared ReadOnly Property LocalSchedulerFolder As String
    Get
'Usage

  Dim value As String

value = JobScheduler.LocalSchedulerFolder
```

```csharp
  public static string LocalSchedulerFolder { get; }
```

```cpp
  public:
static property String^ LocalSchedulerFolder {
    String^ get ();
}
```

``` fsharp
  static member LocalSchedulerFolder : string
```

```jscript
  static function get LocalSchedulerFolder () : String
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The local scheduler folder name.  

## Remarks

The string for the local scheduler folder name is "IIS Transform Manager\\".

## See Also

### Reference

[JobScheduler Class](jobscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

