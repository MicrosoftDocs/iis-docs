---
title: SmoothStreamingMediaElement.SmoothStreamingPlaybackMode Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SmoothStreamingPlaybackMode Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SmoothStreamingPlaybackMode
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.smoothstreamingplaybackmode(v=VS.95)
ms:contentKeyID: 46307851
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_SmoothStreamingPlaybackMode
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_SmoothStreamingPlaybackMode
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SmoothStreamingPlaybackMode
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_SmoothStreamingPlaybackMode
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_SmoothStreamingPlaybackMode
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SmoothStreamingPlaybackMode
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElement.SmoothStreamingPlaybackMode Property

Gets or sets the Smooth Streaming playback mode to use during main content playback.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Property SmoothStreamingPlaybackMode As Nullable(Of PlaybackMode)
    Get
    Set
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Nullable(Of PlaybackMode)

value = instance.SmoothStreamingPlaybackMode

instance.SmoothStreamingPlaybackMode = value
```

``` csharp
public Nullable<PlaybackMode> SmoothStreamingPlaybackMode { get; set; }
```

``` c++
public:
property Nullable<PlaybackMode> SmoothStreamingPlaybackMode {
    Nullable<PlaybackMode> get ();
    void set (Nullable<PlaybackMode> value);
}
```

``` fsharp
member SmoothStreamingPlaybackMode : Nullable<PlaybackMode> with get, set
```

``` jscript
function get SmoothStreamingPlaybackMode () : Nullable<PlaybackMode>
function set SmoothStreamingPlaybackMode (value : Nullable<PlaybackMode>)
```

#### Property Value

Type: [System.Nullable](https://msdn.microsoft.com/en-us/library/b3h38hb0\(v=vs.95\))\<[PlaybackMode](playbackmode-enumeration-microsoft-web-media-smoothstreaming_1.md)\>  
A Microsoft.Web.Media.SmoothStreaming.PlaybackMode object.

## Remarks

This property can be set at any time, but it will not take effect until [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) is set or changed. It shows the currently selected mode for the current object represented by the [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) property. If you read SmoothStreamingPlaybackMode after setting it, it will still read the old value until you set the [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) property. Note that a nulla null reference (Nothing in Visual Basic) value for the SmoothStreamingPlaybackMode property is equivalent to [AudioVideo](playbackmode-enumeration-microsoft-web-media-smoothstreaming_1.md).


> [!NOTE]  
> The SmoothStreamingPlaybackMode property does not support [VideoOnly](playbackmode-enumeration-microsoft-web-media-smoothstreaming_1.md) mode.


## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

