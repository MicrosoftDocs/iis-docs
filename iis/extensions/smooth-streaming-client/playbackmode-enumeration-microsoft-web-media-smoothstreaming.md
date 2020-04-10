---
title: PlaybackMode Enumeration (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: PlaybackMode Enumeration
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.PlaybackMode
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.playbackmode(v=VS.90)
ms:contentKeyID: 31469294
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.PlaybackMode
- Microsoft.Web.Media.SmoothStreaming.PlaybackMode.AudioOnly
- Microsoft.Web.Media.SmoothStreaming.PlaybackMode.AudioVideo
- Microsoft.Web.Media.SmoothStreaming.PlaybackMode.VideoOnly
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.PlaybackMode
- Microsoft.Web.Media.SmoothStreaming.PlaybackMode.VideoOnly
- Microsoft.Web.Media.SmoothStreaming.PlaybackMode.AudioOnly
- Microsoft.Web.Media.SmoothStreaming.PlaybackMode.AudioVideo
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# PlaybackMode Enumeration

Enumeration that specifies the Smooth Streaming playback mode to be used during main content playback.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Enumeration PlaybackMode
'Usage

  Dim instance As PlaybackMode
```

```csharp
  public enum PlaybackMode
```

```cpp
  public enum class PlaybackMode
```

```jscript
  public enum PlaybackMode
```

## Remarks

This property can be set at any time, but it will not take effect until [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) is set or changed. SmoothStreamingPlaybackMode always shows the currently selected mode for the current [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md). If you were to read PlaybackMode after setting it, it will still read the old value until you set [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md).

A null value for PlaybackMode is equivalent to AudioVideo.

The [SmoothStreamingPlaybackMode](smoothstreamingmediaelement-smoothstreamingplaybackmode-property-microsoft-web-media-smoothstreaming_1.md) property currently does not support VideoOnly.

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
