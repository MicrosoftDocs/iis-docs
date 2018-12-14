---
title: ChunkInfo Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ChunkInfo Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.ChunkInfo
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.chunkinfo(v=VS.95)
ms:contentKeyID: 46307933
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ChunkInfo Class

Defines per-chunk information for text/binary chunks of Smooth Streaming data.

## Inheritance Hierarchy

 [System.Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.95\))  
  Microsoft.Web.Media.SmoothStreaming.ChunkInfo  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Class ChunkInfo _
    Implements IComparable
'Usage

Dim instance As ChunkInfo
```

``` csharp
public class ChunkInfo : IComparable
```

``` c++
public ref class ChunkInfo : IComparable
```

``` fsharp
type ChunkInfo =  
    class
        interface IComparable
    end
```

``` jscript
public class ChunkInfo implements IComparable
```

The ChunkInfo type exposes the following members.

## Properties

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="chunkinfo-attributes-property-microsoft-web-media-smoothstreaming_1.md">Attributes</a></td>
<td>Gets or sets <a href="chunkinfo-attributes-property-microsoft-web-media-smoothstreaming_1.md">Attributes</a>.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="chunkinfo-duration-property-microsoft-web-media-smoothstreaming_1.md">Duration</a></td>
<td>Time duration that corresponds the to the &lt;d&gt; element in the manifest for the chunk.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="chunkinfo-stream-property-microsoft-web-media-smoothstreaming_1.md">Stream</a></td>
<td>Gets the <a href="streaminfo-class-microsoft-web-media-smoothstreaming_1.md">StreamInfo</a> object.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="chunkinfo-timestamp-property-microsoft-web-media-smoothstreaming_1.md">TimeStamp</a></td>
<td>Gets or sets the start time for the data chunk.</td>
</tr>
</tbody>
</table>


Top

## Methods

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="chunkinfo-compareto-method-microsoft-web-media-smoothstreaming_1.md">CompareTo</a></td>
<td>Compares a chunk to another object.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.95)">Equals</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.95)">Finalize</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.95)">GetHashCode</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.95)">GetType</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.95)">MemberwiseClone</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.95)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
</tbody>
</table>


Top

## Examples

The following example shows how to get the ChunkInfo objects in a [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) object and how to call the asynchronous method [BeginGetChunk(TimeSpan, AsyncCallback, Object)](trackinfo-begingetchunk-method-microsoft-web-media-smoothstreaming_1.md). For more information, see [Timeline Markers and Events](timeline-markers-and-events.md).

``` 
    foreach (TrackInfo trackInfo in streamInfo.SelectedTracks)
    {
        foreach (ChunkInfo chunk in streamInfo.ChunkList.ToList<ChunkInfo>())
        {
            IAsyncResult ar =
                trackInfo.BeginGetChunk(
                chunk.TimeStamp, new AsyncCallback(AddMarkers), streamInfo.UniqueId);
        }
    }
```

The following example shows the call to the [EndGetChunk(IAsyncResult)](trackinfo-endgetchunk-method-microsoft-web-media-smoothstreaming_1.md) method. For more information on this asynchronous scenario, see [Timeline Markers and Events](timeline-markers-and-events.md).

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

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

