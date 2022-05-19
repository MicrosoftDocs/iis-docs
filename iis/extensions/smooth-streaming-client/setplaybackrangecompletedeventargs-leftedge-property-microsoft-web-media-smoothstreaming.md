---
title: SetPlaybackRangeCompletedEventArgs.LeftEdge Property (Microsoft.Web.Media.SmoothStreaming)
description: Describes the SetPlaybackRangeCompletedEventArgs.LeftEdge property and provides the property's namespace, assembly, syntax, and version information.
TOCTitle: LeftEdge Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventArgs.LeftEdge
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.setplaybackrangecompletedeventargs.leftedge(v=VS.95)
ms:contentKeyID: 46307793
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventArgs.LeftEdge
- Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventArgs.get_LeftEdge
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventArgs.get_LeftEdge
- Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventArgs.LeftEdge
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SetPlaybackRangeCompletedEventArgs.LeftEdge Property

Gets the left-most position for a seek operation.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property LeftEdge As TimeSpan
    Get
'Usage

Dim instance As SetPlaybackRangeCompletedEventArgs
Dim value As TimeSpan

value = instance.LeftEdge
```

```csharp
public TimeSpan LeftEdge { get; }
```

```cpp
public:
property TimeSpan LeftEdge {
    TimeSpan get ();
}
```

``` fsharp
member LeftEdge : TimeSpan
```

```jscript
function get LeftEdge () : TimeSpan
```

### Property Value

Type: [System.TimeSpan](https://msdn.microsoft.com/library/269ew577\(v=vs.95\))  
The left-most position for a seek operation.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SetPlaybackRangeCompletedEventArgs Class](setplaybackrangecompletedeventargs-class-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
