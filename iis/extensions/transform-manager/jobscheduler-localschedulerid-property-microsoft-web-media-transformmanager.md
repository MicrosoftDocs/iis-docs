---
title: JobScheduler.LocalSchedulerId Property (Microsoft.Web.Media.TransformManager)
TOCTitle: LocalSchedulerId Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobScheduler.LocalSchedulerId
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobscheduler.localschedulerid(v=VS.90)
ms:contentKeyID: 35521022
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobScheduler.get_LocalSchedulerId
- Microsoft.Web.Media.TransformManager.JobScheduler.LocalSchedulerId
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobScheduler.get_LocalSchedulerId
- Microsoft.Web.Media.TransformManager.JobScheduler.LocalSchedulerId
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# LocalSchedulerId Property

Gets the local scheduler ID.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Shared ReadOnly Property LocalSchedulerId As String
    Get
'Usage

  Dim value As String

value = JobScheduler.LocalSchedulerId
```

```csharp
  public static string LocalSchedulerId { get; }
```

```cpp
  public:
static property String^ LocalSchedulerId {
    String^ get ();
}
```

``` fsharp
  static member LocalSchedulerId : string
```

```jscript
  static function get LocalSchedulerId () : String
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The local scheduler ID.  

## See Also

### Reference

[JobScheduler Class](jobscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

