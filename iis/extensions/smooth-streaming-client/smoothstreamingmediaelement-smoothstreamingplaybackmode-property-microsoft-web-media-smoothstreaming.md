---
title: SmoothStreamingMediaElement.SmoothStreamingPlaybackMode Property (Microsoft.Web.Media.SmoothStreaming)
description: Details the syntax for the SmoothStreamingPlaybackMode property. This property gets or sets the Smooth Streaming playback mode.
TOCTitle: SmoothStreamingPlaybackMode Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SmoothStreamingPlaybackMode
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.smoothstreamingplaybackmode(v=VS.90)
ms:contentKeyID: 31469288
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_SmoothStreamingPlaybackMode
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_SmoothStreamingPlaybackMode
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SmoothStreamingPlaybackMode
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_SmoothStreamingPlaybackMode
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_SmoothStreamingPlaybackMode
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SmoothStreamingPlaybackMode
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingPlaybackMode Property

Gets or sets the Smooth Streaming playback mode to use during main content playback.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property SmoothStreamingPlaybackMode As Nullable(Of PlaybackMode)
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim value As Nullable(Of PlaybackMode)

value = instance.SmoothStreamingPlaybackMode

instance.SmoothStreamingPlaybackMode = value
```

```csharp
  public Nullable<PlaybackMode> SmoothStreamingPlaybackMode { get; set; }
```

```cpp
  public:
property Nullable<PlaybackMode> SmoothStreamingPlaybackMode {
    Nullable<PlaybackMode> get ();
    void set (Nullable<PlaybackMode> value);
}
```

```jscript
  function get SmoothStreamingPlaybackMode () : Nullable<PlaybackMode>
function set SmoothStreamingPlaybackMode (value : Nullable<PlaybackMode>)
```

### Property Value

Type: [System.Nullable](https://msdn.microsoft.com/library/b3h38hb0)\< (Of \< ( \<'[PlaybackMode](playbackmode-enumeration-microsoft-web-media-smoothstreaming_1.md)\> ) \> ) \>  
A PlaybackMode()()()() object.  

## Remarks

This property can be set at any time, but it will not take effect until [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) is set or changed. Shows the currently selected mode for the current object represented by the [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) property. If you read SmoothStreamingPlaybackMode after setting it, it will still read the old value until you set the [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) property. Note that a null Nothing nullptr unit a null reference (Nothing in Visual Basic) value for the SmoothStreamingPlaybackMode property is equivalent to [AudioVideo](playbackmode-enumeration-microsoft-web-media-smoothstreaming_1.md).

> [!NOTE]  
> The SmoothStreamingPlaybackMode property does not support [VideoOnly](playbackmode-enumeration-microsoft-web-media-smoothstreaming_1.md) mode.

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
