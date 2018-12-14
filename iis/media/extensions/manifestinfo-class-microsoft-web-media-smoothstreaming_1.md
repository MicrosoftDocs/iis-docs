---
title: ManifestInfo Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ManifestInfo Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.ManifestInfo
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.manifestinfo(v=VS.95)
ms:contentKeyID: 46307943
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ManifestInfo Class

Represents the manifest in application code. This class corresponds to the \<SmoothStreamingMedia\> element in the client manifest and to the [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) property of the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md).

## Inheritance Hierarchy

 [System.Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.95\))  
  Microsoft.Web.Media.SmoothStreaming.ManifestInfo  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Class ManifestInfo
'Usage

Dim instance As ManifestInfo
```

``` csharp
public class ManifestInfo
```

``` c++
public ref class ManifestInfo
```

``` fsharp
type ManifestInfo =  class end
```

``` jscript
public class ManifestInfo
```

The ManifestInfo type exposes the following members.

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
<td><a href="manifestinfo-attributes-property-microsoft-web-media-smoothstreaming_1.md">Attributes</a></td>
<td>Gets or sets attributes.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="manifestinfo-loguris-property-microsoft-web-media-smoothstreaming_1.md">LogUris</a></td>
<td>Gets the list of logging Uri objects.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="manifestinfo-manifesttype-property-microsoft-web-media-smoothstreaming.md">ManifestType</a></td>
<td></td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="manifestinfo-protectioninfo-property-microsoft-web-media-smoothstreaming_1.md">ProtectionInfo</a></td>
<td>Contains information specified in the protection element inside the manifest.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="manifestinfo-segments-property-microsoft-web-media-smoothstreaming_1.md">Segments</a></td>
<td>List of <a href="segmentinfo-class-microsoft-web-media-smoothstreaming_1.md">SegmentInfo</a> objects. There is a SegmentInfo for each &lt;Clip&gt; element in the manifest.</td>
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
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="manifestinfo-parsemanifest-method-microsoft-web-media-smoothstreaming_1.md">ParseManifest</a></td>
<td>Parses the Smooth Streaming manifest.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.95)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
</tbody>
</table>


Top

## Events

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
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /></td>
<td><a href="manifestinfo-chunklistchanged-event-microsoft-web-media-smoothstreaming_1.md">ChunkListChanged</a></td>
<td>Event activated when the fragment info of a new text/binary chunk in a live scenario is added to the manifest. This event will fire on the UI thread.</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="manifestinfo-selectstreamscompleted-event-microsoft-web-media-smoothstreaming_1.md">SelectStreamsCompleted</a></td>
<td>Event activated when a <a href="segmentinfo-selectstreamsasync-method-microsoft-web-media-smoothstreaming_1.md">SelectStreamsAsync</a> call has completed in any of the segments contained in <a href="manifestinfo-segments-property-microsoft-web-media-smoothstreaming_1.md">Segments</a>.</td>
</tr>
</tbody>
</table>


Top

## Remarks

The object represents the top element in the client manifest. It has a collection of [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) objects, which each contain [AvailableStreams](segmentinfo-availablestreams-property-microsoft-web-media-smoothstreaming_1.md) and [SelectedStreams](segmentinfo-selectedstreams-property-microsoft-web-media-smoothstreaming_1.md) collections. These [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects contain the audio, video, and textual data of Smooth Streaming presentations. The [SelectedStreams](segmentinfo-selectedstreams-property-microsoft-web-media-smoothstreaming_1.md) property must include exactly one video stream and one audio stream. Non-audio/video streams do not have this restriction and can be multiply selected and deselected. The streams in the list must be members of the current segment’s [AvailableStreams](segmentinfo-availablestreams-property-microsoft-web-media-smoothstreaming_1.md) and/or [SelectedStreams](segmentinfo-selectedstreams-property-microsoft-web-media-smoothstreaming_1.md) collections. To generate the lists of available streams or selected streams use a [List\<T\>.CopyTo](http://msdn.microsoft.com/en-us/library/t69dktcd\(v=vs.100\).aspx) constructor of type [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) to copy either the [AvailableStreams](segmentinfo-availablestreams-property-microsoft-web-media-smoothstreaming_1.md) or the [SelectedStreams](segmentinfo-selectedstreams-property-microsoft-web-media-smoothstreaming_1.md) property. Add or remove streams until you have the desired list.

Notifications for de-selection of current streams will arrive before selection notifications on a per-segment basis. Applications can clean up any state associated with the deselected stream before adding state associated with the new stream. However, due to the possibility of multiple segments, it is preferable to use the [UniqueId](streaminfo-uniqueid-property-microsoft-web-media-smoothstreaming_1.md) property to identify the stream with which objects are associated.

## Examples

The following example shows how to get [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) and [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects from the ManifestInfo object.

For more information, see [Microsoft Smooth Streaming Client 2.0](microsoft-smooth-streaming-client-2-0.md)

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

