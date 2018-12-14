---
title: PlaybackStartPosition Enumeration (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: PlaybackStartPosition Enumeration
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.PlaybackStartPosition
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.playbackstartposition(v=VS.95)
ms:contentKeyID: 46307944
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.PlaybackStartPosition.Beginning
- Microsoft.Web.Media.SmoothStreaming.PlaybackStartPosition
- Microsoft.Web.Media.SmoothStreaming.PlaybackStartPosition.End
- Microsoft.Web.Media.SmoothStreaming.PlaybackStartPosition.PausedPosition
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.PlaybackStartPosition
- Microsoft.Web.Media.SmoothStreaming.PlaybackStartPosition.Beginning
- Microsoft.Web.Media.SmoothStreaming.PlaybackStartPosition.End
- Microsoft.Web.Media.SmoothStreaming.PlaybackStartPosition.PausedPosition
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# PlaybackStartPosition Enumeration

Enumeration that specifies the position from which playback of a media stream begins.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Enumeration PlaybackStartPosition
'Usage

Dim instance As PlaybackStartPosition
```

``` csharp
public enum PlaybackStartPosition
```

``` c++
public enum class PlaybackStartPosition
```

``` fsharp
type PlaybackStartPosition
```

``` jscript
public enum PlaybackStartPosition
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
<td>Beginning</td>
<td>Starts at the beginning of the timeline that is provided by the manifest.</td>
</tr>
<tr class="even">
<td><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td>End</td>
<td>Starts at the end of the timeline that is provided by the manifest.</td>
</tr>
<tr class="odd">
<td><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td>PausedPosition</td>
<td>Starts at the paused position.</td>
</tr>
</tbody>
</table>


## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

