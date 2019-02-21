---
title: ClipContext.PlaybackDuration Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: PlaybackDuration Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipContext.PlaybackDuration
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.clipcontext.playbackduration(v=VS.90)
ms:contentKeyID: 31469168
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipContext.get_PlaybackDuration
- Microsoft.Web.Media.SmoothStreaming.ClipContext.PlaybackDuration
- Microsoft.Web.Media.SmoothStreaming.ClipContext.set_PlaybackDuration
dev_langs:
- csharp
- jscript
- vb
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

# PlaybackDuration Property

Gets or sets the playback duration.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property PlaybackDuration As Duration
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

```jscript
  function get PlaybackDuration () : Duration
internal function set PlaybackDuration (value : Duration)
```

### Property Value

Type: [System.Windows.Duration](https://msdn.microsoft.com/library/ms602372)  
A [Duration](https://msdn.microsoft.com/library/ms602372) object.  

## Version Information

### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[ClipContext Class](clipcontext-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

