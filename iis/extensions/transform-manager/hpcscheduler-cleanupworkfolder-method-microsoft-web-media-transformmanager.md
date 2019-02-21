---
title: HpcScheduler.CleanupWorkFolder Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: CleanupWorkFolder Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.HpcScheduler.CleanupWorkFolder(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.hpcscheduler.cleanupworkfolder(v=VS.90)
ms:contentKeyID: 46408635
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.HpcScheduler.CleanupWorkFolder
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.HpcScheduler.CleanupWorkFolder
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# CleanupWorkFolder Method

This member overrides [Scheduler.CleanupWorkFolder(String)](scheduler-cleanupworkfolder-method-microsoft-web-media-transformmanager.md).

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Overrides Sub CleanupWorkFolder ( _
    workFolder As String _
)
'Usage

  Dim instance As HpcScheduler
Dim workFolder As String

instance.CleanupWorkFolder(workFolder)
```

```csharp
  public override void CleanupWorkFolder(
    string workFolder
)
```

```cpp
  public:
virtual void CleanupWorkFolder(
    String^ workFolder
) override
```

``` fsharp
  abstract CleanupWorkFolder : 
        workFolder:string -> unit 
override CleanupWorkFolder : 
        workFolder:string -> unit 
```

```jscript
  public override function CleanupWorkFolder(
    workFolder : String
)
```

### Parameters

  - workFolder  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  

## See Also

### Reference

[HpcScheduler Class](hpcscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

