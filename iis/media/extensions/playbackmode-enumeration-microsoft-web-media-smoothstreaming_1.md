---
title: PlaybackMode Enumeration (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: PlaybackMode Enumeration
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.PlaybackMode
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.playbackmode(v=VS.95)
ms:contentKeyID: 46307942
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.PlaybackMode
- Microsoft.Web.Media.SmoothStreaming.PlaybackMode.AudioOnly
- Microsoft.Web.Media.SmoothStreaming.PlaybackMode.AudioVideo
- Microsoft.Web.Media.SmoothStreaming.PlaybackMode.VideoOnly
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.PlaybackMode
- Microsoft.Web.Media.SmoothStreaming.PlaybackMode.VideoOnly
- Microsoft.Web.Media.SmoothStreaming.PlaybackMode.AudioOnly
- Microsoft.Web.Media.SmoothStreaming.PlaybackMode.AudioVideo
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# PlaybackMode Enumeration

Enumeration that specifies the Smooth Streaming playback mode to be used during main content playback.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Enumeration PlaybackMode
'Usage

Dim instance As PlaybackMode
```

``` csharp
public enum PlaybackMode
```

``` c++
public enum class PlaybackMode
```

``` fsharp
type PlaybackMode
```

``` jscript
public enum PlaybackMode
```

## Members

<table>
<thead>
<tr class="header">
<th></th>
<th>Member name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td>AudioVideo</td>
<td>Both audio and video.</td>
</tr>
<tr class="even">
<td><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td>AudioOnly</td>
<td>Audio only.The <a href="smoothstreamingmediaelement-smoothstreamingplaybackmode-property-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingPlaybackMode</a> property currently does not support VideoOnly.</td>
</tr>
<tr class="odd">
<td><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td>VideoOnly</td>
<td>Video only.The <a href="smoothstreamingmediaelement-smoothstreamingplaybackmode-property-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingPlaybackMode</a> property currently does not support VideoOnly</td>
</tr>
</tbody>
</table>


## Remarks

This property can be set at any time, but it will not take effect until [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) is set or changed. SmoothStreamingPlaybackMode always shows the currently selected mode for the current [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md). If you were to read PlaybackMode after setting it, it will still read the old value until you set [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md).

A null value for PlaybackMode is equivalent to AudioVideo.

The [SmoothStreamingPlaybackMode](smoothstreamingmediaelement-smoothstreamingplaybackmode-property-microsoft-web-media-smoothstreaming_1.md) property currently does not support VideoOnly.

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

