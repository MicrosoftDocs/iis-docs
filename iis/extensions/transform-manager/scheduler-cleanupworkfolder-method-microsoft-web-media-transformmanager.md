---
title: Scheduler.CleanupWorkFolder Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: CleanupWorkFolder Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.Scheduler.CleanupWorkFolder(System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.scheduler.cleanupworkfolder(v=VS.90)
ms:contentKeyID: 46408308
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Scheduler.CleanupWorkFolder
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Scheduler.CleanupWorkFolder
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CleanupWorkFolder Method

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public MustOverride Sub CleanupWorkFolder ( _
    workFolder As String _
)
'Usage

  Dim instance As Scheduler
Dim workFolder As String

instance.CleanupWorkFolder(workFolder)
```

```csharp
  public abstract void CleanupWorkFolder(
    string workFolder
)
```

```cpp
  public:
virtual void CleanupWorkFolder(
    String^ workFolder
) abstract
```

``` fsharp
  abstract CleanupWorkFolder :
        workFolder:string -> unit
```

```jscript
  public abstract function CleanupWorkFolder(
    workFolder : String
)
```

### Parameters

  - workFolder  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  

## See Also

### Reference

[Scheduler Class](scheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
