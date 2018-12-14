---
title: SegmentInfo Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SegmentInfo Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.SegmentInfo
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.segmentinfo(v=VS.90)
ms:contentKeyID: 31469293
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SegmentInfo Class

Defines the information that must be exposed by any manifest parser. This class corresponds to the Clip element in the composite manifest. You can extend the class with private data if a custom parser needs more information.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Media.SmoothStreaming..::..SegmentInfo  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicClassSegmentInfo
'Usage
DiminstanceAsSegmentInfo
```

``` csharp
publicclassSegmentInfo
```

``` c++
publicref classSegmentInfo
```

``` jscript
publicclass SegmentInfo
```

The SegmentInfo type exposes the following members.

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
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="segmentinfo-availablestreams-property-microsoft-web-media-smoothstreaming_1.md">AvailableStreams</a></td>
<td>Gets the available <a href="streaminfo-class-microsoft-web-media-smoothstreaming_1.md">StreamInfo</a> objects that is contained by a SegmentInfo object.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="segmentinfo-endposition-property-microsoft-web-media-smoothstreaming_1.md">EndPosition</a></td>
<td>Gets the minimum of the end time for the last audio chunk and last video chunk.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="segmentinfo-selectedstreams-property-microsoft-web-media-smoothstreaming_1.md">SelectedStreams</a></td>
<td>Gets the selected <a href="streaminfo-class-microsoft-web-media-smoothstreaming_1.md">StreamInfo</a> objects.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="segmentinfo-startposition-property-microsoft-web-media-smoothstreaming_1.md">StartPosition</a></td>
<td>Gets the maximum of the start times of the first audio chunk and first video chunk.</td>
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
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.90)">Equals</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.90)">Finalize</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90)">GetHashCode</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.90)">GetType</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90)">MemberwiseClone</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="segmentinfo-selectstreamsasync-method-ilist-streaminfo-microsoft-web-media-smoothstreaming_1.md">SelectStreamsAsync(IList&lt; (Of &lt; &lt;' (StreamInfo&gt; ) &gt; &gt; ))</a></td>
<td>Initializes a new instance of the SegmentInfo class.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="segmentinfo-selectstreamsasync-method-ilist-streaminfo-object-microsoft-web-media-smoothstreaming_1.md">SelectStreamsAsync(IList&lt; (Of &lt; &lt;' (StreamInfo&gt; ) &gt; &gt; ), Object)</a></td>
<td>Initializes a new instance of the SegmentInfo class.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
</tbody>
</table>


Top

## Remarks

For the client manifest, on demand and live, there is only one SegmentInfo object. You can refer to it as the zeroth segment of [Segments](manifestinfo-segments-property-microsoft-web-media-smoothstreaming_1.md). For composite manifests, there can be multiple SegmentInfo objects. (Composite manifests are currently exposed as one segment, but applications should use segment-handling code that can be called on several segments. Do not assume that ManifestInfo.Segments\[0\] is the current segment.)

SegmentInfo objects contain a list of all available and selected streams and a method for stream selection. The [AvailableStreams](segmentinfo-availablestreams-property-microsoft-web-media-smoothstreaming_1.md) and [SelectedStreams](segmentinfo-selectedstreams-property-microsoft-web-media-smoothstreaming_1.md) collections represent all the streams in the Smooth Streaming presentation.

For implementation examples, see [Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md) and other topics in [IIS Smooth Streaming Client 1.5](microsoft-smooth-streaming-client-2-0.md).

## Examples

The following example shows code that loops through any number of SegmentInfo objects.

``` 
    void SmoothPlayer_MediaOpened(object sender, RoutedEventArgs e)
    {
        foreach (SegmentInfo segmentInfo in SmoothPlayer.ManifestInfo.Segments)
        {
            List<StreamInfo> selectStreams = segmentInfo.SelectedStreams.ToList<StreamInfo>();
            foreach (StreamInfo streamInfo in segmentInfo.AvailableStreams)
            {
                if (streamInfo.Type == System.Windows.Media.MediaStreamType.Script)
                {
                    if (streamInfo.Attributes["Name"] == "ClosedCaptions" ||
                                            streamInfo.Attributes["Name"] == "MARKERS")
                    {
                        selectStreams.Add(streamInfo);
                        segmentInfo.SelectStreamsAsync(selectStreams);

                        foreach (TrackInfo trackInfo in streamInfo.SelectedTracks)
                        {
                            foreach (ChunkInfo chunk in streamInfo.ChunkList.ToList<ChunkInfo>())
                            {
                                IAsyncResult ar =
                                    trackInfo.BeginGetChunk(
                                    chunk.TimeStamp, new AsyncCallback(AddMarkers), streamInfo.UniqueId);
                            }
                        }
                    }
                }
            }
        }
    }
```

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

