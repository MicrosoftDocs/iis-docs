---
title: LocalScheduler.CleanupWorkFolder Method  (Microsoft.Web.Media.TransformManager)
description: This member overrides Scheduler.CleanupWorkFolder.
TOCTitle: CleanupWorkFolder Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.LocalScheduler.CleanupWorkFolder(System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.localscheduler.cleanupworkfolder(v=VS.90)
ms:contentKeyID: 46408418
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.LocalScheduler.CleanupWorkFolder
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.LocalScheduler.CleanupWorkFolder
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CleanupWorkFolder Method

This member overrides [Scheduler.CleanupWorkFolder(String)](scheduler-cleanupworkfolder-method-microsoft-web-media-transformmanager.md).

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Overrides Sub CleanupWorkFolder ( _
    workfolder As String _
)
'Usage

  Dim instance As LocalScheduler
Dim workfolder As String

instance.CleanupWorkFolder(workfolder)
```

```csharp
  public override void CleanupWorkFolder(
    string workfolder
)
```

```cpp
  public:
virtual void CleanupWorkFolder(
    String^ workfolder
) override
```

``` fsharp
  abstract CleanupWorkFolder : 
        workfolder:string -> unit 
override CleanupWorkFolder : 
        workfolder:string -> unit 
```

```jscript
  public override function CleanupWorkFolder(
    workfolder : String
)
```

### Parameters

  - workfolder  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  

## See Also

### Reference

[LocalScheduler Class](localscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
