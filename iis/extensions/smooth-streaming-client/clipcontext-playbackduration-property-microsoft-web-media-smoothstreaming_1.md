---
title: ClipContext.PlaybackDuration Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: PlaybackDuration Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipContext.PlaybackDuration
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.clipcontext.playbackduration(v=VS.95)
ms:contentKeyID: 46307775
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipContext.get_PlaybackDuration
- Microsoft.Web.Media.SmoothStreaming.ClipContext.PlaybackDuration
- Microsoft.Web.Media.SmoothStreaming.ClipContext.set_PlaybackDuration
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipContext.get_PlaybackDuration
- Microsoft.Web.Media.SmoothStreaming.ClipContext.PlaybackDuration
- Microsoft.Web.Media.SmoothStreaming.ClipContext.set_PlaybackDuration
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ClipContext.PlaybackDuration Property

Gets or sets the playback duration.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property PlaybackDuration As Duration
    Get
    Friend Set
'Usage

Dim instance As ClipContext
Dim value As Duration

value = instance.PlaybackDuration
```

```csharp
public Duration PlaybackDuration { get; internal set; }
```

```cpp
public:
property Duration PlaybackDuration {
    Duration get ();
    internal: void set (Duration value);
}
```

``` fsharp
member PlaybackDuration : Duration with get, internal set
```

```jscript
function get PlaybackDuration () : Duration
internal function set PlaybackDuration (value : Duration)
```

### Property Value

Type: [System.Windows.Duration](https://msdn.microsoft.com/library/ms602372\(v=vs.95\))  
A [Duration](https://msdn.microsoft.com/library/ms602372\(v=vs.95\)) object.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[ClipContext Class](clipcontext-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

