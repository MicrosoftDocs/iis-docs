---
title: StreamInfo Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: StreamInfo Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.StreamInfo
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.streaminfo(v=VS.95)
ms:contentKeyID: 46307966
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# StreamInfo Class

Defines the basic information for each stream. This class corresponds to the StreamIndex element of the client manifest. You can extend the class to add private data per stream.

## Inheritance Hierarchy

 [System.Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.95\))  
  Microsoft.Web.Media.SmoothStreaming.StreamInfo  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Class StreamInfo
'Usage

Dim instance As StreamInfo
```

``` csharp
public class StreamInfo
```

``` c++
public ref class StreamInfo
```

``` fsharp
type StreamInfo =  class end
```

``` jscript
public class StreamInfo
```

The StreamInfo type exposes the following members.

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
<td><a href="streaminfo-attributes-property-microsoft-web-media-smoothstreaming_1.md">Attributes</a></td>
<td>Gets or sets attributes for this stream.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="streaminfo-availabletracks-property-microsoft-web-media-smoothstreaming_1.md">AvailableTracks</a></td>
<td>Gets the <a href="streaminfo-availabletracks-property-microsoft-web-media-smoothstreaming_1.md">AvailableTracks</a> property.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="streaminfo-childstreams-property-microsoft-web-media-smoothstreaming_1.md">ChildStreams</a></td>
<td>Gets the <a href="streaminfo-childstreams-property-microsoft-web-media-smoothstreaming_1.md">ChildStreams</a> property.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="streaminfo-chunklist-property-microsoft-web-media-smoothstreaming_1.md">ChunkList</a></td>
<td>Gets the list of chunks for this stream.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="streaminfo-parentstream-property-microsoft-web-media-smoothstreaming_1.md">ParentStream</a></td>
<td>Gets or sets the parent stream in the case of a sparse stream. Otherwise this is null.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="streaminfo-segment-property-microsoft-web-media-smoothstreaming_1.md">Segment</a></td>
<td>Gets or sets the segment for this stream.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="streaminfo-selectedtracks-property-microsoft-web-media-smoothstreaming_1.md">SelectedTracks</a></td>
<td>Gets or sets the <a href="streaminfo-selectedtracks-property-microsoft-web-media-smoothstreaming_1.md">SelectedTracks</a> property.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="streaminfo-subtype-property-microsoft-web-media-smoothstreaming_1.md">Subtype</a></td>
<td>Gets or sets the <a href="streaminfo-subtype-property-microsoft-web-media-smoothstreaming_1.md">Subtype</a> property.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="streaminfo-timescale-property-microsoft-web-media-smoothstreaming.md">Timescale</a></td>
<td>Gets or sets the time scale of the stream.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="streaminfo-type-property-microsoft-web-media-smoothstreaming_1.md">Type</a></td>
<td>Gets or sets the <a href="streaminfo-type-property-microsoft-web-media-smoothstreaming_1.md">Type</a> property.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="streaminfo-uniqueid-property-microsoft-web-media-smoothstreaming_1.md">UniqueId</a></td>
<td>Gets or sets the Id that identifies this stream.</td>
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
<td><a href="https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.95)">Equals</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.95)">Finalize</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.95)">GetHashCode</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.95)">GetType</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.95)">MemberwiseClone</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="streaminfo-restricttracks-method-microsoft-web-media-smoothstreaming_1.md">RestrictTracks</a></td>
<td>Replaces <a href="streaminfo-availabletracks-property-microsoft-web-media-smoothstreaming_1.md">AvailableTracks</a> with the specified list of available tracks.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="streaminfo-selecttracks-method-microsoft-web-media-smoothstreaming_1.md">SelectTracks</a></td>
<td>Selects <a href="trackinfo-class-microsoft-web-media-smoothstreaming_1.md">TrackInfo</a> objects for this stream. For more information see <a href="select-and-monitor-bitrate.md">Select and Monitor Bitrate</a>.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="streaminfo-tostring-method-microsoft-web-media-smoothstreaming_1.md">ToString</a></td>
<td>Writes the StreamInfo item to a string. (Overrides <a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.95)">Object.ToString()</a>.)</td>
</tr>
</tbody>
</table>


Top

## Remarks

The [AvailableStreams](segmentinfo-availablestreams-property-microsoft-web-media-smoothstreaming_1.md) property of the [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) object contains a collection of StreamInfo objects. The [SelectedStreams](segmentinfo-selectedstreams-property-microsoft-web-media-smoothstreaming_1.md) property of the [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) object must include exactly one video StreamInfo object and one audio StreamInfo object. Text streams do not have this restriction and can be multiply selected and deselected. Streams must be members of the current segment’s [AvailableStreams](segmentinfo-availablestreams-property-microsoft-web-media-smoothstreaming_1.md) and/or [SelectedStreams](segmentinfo-selectedstreams-property-microsoft-web-media-smoothstreaming_1.md) property. To generate the lists of available streams or selected streams use a [List\<T\>.CopyTo](http://msdn.microsoft.com/en-us/library/t69dktcd\(v=vs.100\).aspx) constructor of type StreamInfo to copy either the [AvailableStreams](segmentinfo-availablestreams-property-microsoft-web-media-smoothstreaming_1.md) or the [SelectedStreams](segmentinfo-selectedstreams-property-microsoft-web-media-smoothstreaming_1.md) property. Add or remove streams until you have the desired list.

Notifications for de-selection of current streams will arrive before selection notifications on a per-segment basis. Applications can clean up any state associated with the deselected stream before adding state associated with the new stream. However, due to the possibility of multiple segments, it is preferable to use the [UniqueId](streaminfo-uniqueid-property-microsoft-web-media-smoothstreaming_1.md) property to identify the stream with which objects are associated.

For an implementation example that parses StreamInfo objects, see [Timeline Markers and Events](timeline-markers-and-events.md) under the heading "Extract Timeline Events and Assign Markers."

## Examples

The following example shows how to get [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) and StreamInfo objects from the [ManifestInfo](manifestinfo-class-microsoft-web-media-smoothstreaming_1.md) object.

``` 
    void SmoothPlayer_ManifestReady(object sender, EventArgs e)
    {
        if (!PremiumAccount)
        {
            foreach (SegmentInfo segment in SmoothPlayer.ManifestInfo.Segments)
            {
                IList<StreamInfo> streamInfoList = segment.AvailableStreams;
                foreach (StreamInfo stream in streamInfoList)
                {
                    if (stream.Type == MediaStreamType.Video)
                    {
                        // Limit bit-rate to 866000.
                        ulong highRate = 866000 + 1;
                        List<TrackInfo> tracks = new List<TrackInfo>();

                        tracks = stream.AvailableTracks.ToList<TrackInfo>();
                        IList<TrackInfo> allowedTracks = tracks.Where((ti) => ti.Bitrate < highRate).ToList();
                        stream.SelectTracks(allowedTracks, false);
                    }
                }
            }
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

