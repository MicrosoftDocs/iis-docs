---
title: SetPlaybackRangeCompletedEventArgs.RightEdge Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: RightEdge Property
description: "The SetPlaybackRangeCompletedEventArgs.RightEdge property gets the player application's expected right-most position or chunk timestamp."
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventArgs.RightEdge
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.setplaybackrangecompletedeventargs.rightedge(v=VS.95)
ms:contentKeyID: 46307795
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventArgs.get_RightEdge
- Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventArgs.RightEdge
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventArgs.get_RightEdge
- Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventArgs.RightEdge
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SetPlaybackRangeCompletedEventArgs.RightEdge Property

Gets the player application's expected right-most position or chunk timestamp.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property RightEdge As TimeSpan
    Get
'Usage

Dim instance As SetPlaybackRangeCompletedEventArgs
Dim value As TimeSpan

value = instance.RightEdge
```

```csharp
public TimeSpan RightEdge { get; }
```

```cpp
public:
property TimeSpan RightEdge {
    TimeSpan get ();
}
```

``` fsharp
member RightEdge : TimeSpan
```

```jscript
function get RightEdge () : TimeSpan
```

### Property Value

Type: [System.TimeSpan](https://msdn.microsoft.com/library/269ew577\(v=vs.95\))  
The player application's expected right-most position or chunk timestamp.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SetPlaybackRangeCompletedEventArgs Class](setplaybackrangecompletedeventargs-class-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
