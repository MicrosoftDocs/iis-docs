---
title: ITaskStatus.PercentComplete Property (Microsoft.Web.Media.TransformManager)
TOCTitle: PercentComplete Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ITaskStatus.PercentComplete
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.itaskstatus.percentcomplete(v=VS.90)
ms:contentKeyID: 35520974
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ITaskStatus.PercentComplete
- Microsoft.Web.Media.TransformManager.ITaskStatus.get_PercentComplete
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ITaskStatus.get_PercentComplete
- Microsoft.Web.Media.TransformManager.ITaskStatus.PercentComplete
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# PercentComplete Property

Gets the percentage of task completion.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  ReadOnly Property PercentComplete As Integer
    Get
'Usage

  Dim instance As ITaskStatus
Dim value As Integer

value = instance.PercentComplete
```

```csharp
  int PercentComplete { get; }
```

```cpp
  property int PercentComplete {
    int get ();
}
```

``` fsharp
  abstract PercentComplete : int
```

```jscript
  function get PercentComplete () : int
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
The percentage completed.  

## Remarks

The percentage can be used to report progress in the UI.

## See Also

### Reference

[ITaskStatus Interface](itaskstatus-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

