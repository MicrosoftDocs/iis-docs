---
title: ChunkResult.ChunkResultState Enumeration (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ChunkResult.ChunkResultState Enumeration
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.ChunkResult.ChunkResultState
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.chunkresult.chunkresultstate(v=VS.95)
ms:contentKeyID: 46307934
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.ChunkResultState
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.ChunkResultState.Failed
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.ChunkResultState.Succeeded
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.ChunkResultState.TimedOut
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.ChunkResultState.Failed
- Microsoft.Web.Media.SmoothStreaming.ChunkResultState
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.ChunkResultState.TimedOut
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.ChunkResultState.Succeeded
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ChunkResult.ChunkResultState Enumeration

An enumeration that contains the possible result states during processing by the [BeginGetChunk](trackinfo-begingetchunk-method-microsoft-web-media-smoothstreaming_1.md) and [EndGetChunk](trackinfo-endgetchunk-method-microsoft-web-media-smoothstreaming_1.md) methods.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Enumeration ChunkResultState
'Usage

Dim instance As ChunkResult.ChunkResultState
```

``` csharp
public enum ChunkResultState
```

``` c++
public enum class ChunkResultState
```

``` fsharp
type ChunkResultState
```

``` jscript
public enum ChunkResultState
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
<td></td>
<td>Succeeded</td>
<td><a href="trackinfo-begingetchunk-method-microsoft-web-media-smoothstreaming_1.md">BeginGetChunk</a> succeeded.</td>
</tr>
<tr class="even">
<td></td>
<td>Failed</td>
<td><a href="trackinfo-begingetchunk-method-microsoft-web-media-smoothstreaming_1.md">BeginGetChunk</a> failed.</td>
</tr>
<tr class="odd">
<td></td>
<td>TimedOut</td>
<td><a href="trackinfo-begingetchunk-method-microsoft-web-media-smoothstreaming_1.md">BeginGetChunk</a> timed out.</td>
</tr>
</tbody>
</table>


## Examples

The following example shows the call to the [EndGetChunk(IAsyncResult)](trackinfo-endgetchunk-method-microsoft-web-media-smoothstreaming_1.md) method and return of a [ChunkResult](chunkresult-class-microsoft-web-media-smoothstreaming_1.md) object that contains the ChunkResult.ChunkResultState that indicates success or failure. For more information on this asynchronous scenario, see [Timeline Markers and Events](timeline-markers-and-events.md).

``` 
    foreach (TrackInfo trackInfo in streamInfo.SelectedTracks)
    {
        ChunkResult chunkResult = trackInfo.EndGetChunk(argAR);

        if (chunkResult.Result == ChunkResult.ChunkResultState.Succeeded)
        {
            System.Text.Encoding enc = System.Text.Encoding.UTF8;
            int length = (int)chunkResult.ChunkData.Length;
            byte[] rawData = new byte[length];
            chunkResult.ChunkData.Read(rawData, 0, length);
            String text = enc.GetString(rawData, 0, rawData.Length);
            TimelineMarker newMarker = new TimelineMarker();
            newMarker.Text = text;
            newMarker.Time = chunkResult.Timestamp;

            SmoothPlayer.Markers.Add(newMarker);
        }
    }
```

## Version Information

#### Silverlight

Supported in: 5  

## See Also

#### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

