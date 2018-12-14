---
title: Microsoft.Web.Media.SmoothStreaming Namespace ()
TOCTitle: Microsoft.Web.Media.SmoothStreaming
ms:assetid: N:Microsoft.Web.Media.SmoothStreaming
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming(v=VS.95)
ms:contentKeyID: 46307714
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming
dev_langs:
- CSharp
- JScript
- VB
- FSharp
---

# Microsoft.Web.Media.SmoothStreaming Namespace

Client classes for Microsoft Smooth Streaming applications.

Smooth Streaming extensions in IIS Media Services enable adaptive streaming of media to Silverlight clients over HTTP. For more information and code scenarios, see [Microsoft Smooth Streaming Client 2.0](microsoft-smooth-streaming-client-2-0.md).

## Classes

<table>
<thead>
<tr class="header">
<th> </th>
<th>Class</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="cacherequest-class-microsoft-web-media-smoothstreaming_1.md">CacheRequest</a></td>
<td>The object describing the request being made.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="cacherequest2-class-microsoft-web-media-smoothstreaming.md">CacheRequest2</a></td>
<td>Provides an extension of the <a href="cacherequest-class-microsoft-web-media-smoothstreaming_1.md">CacheRequest</a> class that enables creation of a CacheRequest object based on a specified stream or a specified <a href="https://msdn.microsoft.com/en-us/library/8y7x3zz2(v=vs.95)">HttpWebRequest</a> object and list of selectable tracks.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="cacheresponse-class-microsoft-web-media-smoothstreaming_1.md">CacheResponse</a></td>
<td>The object describing the response from the cache.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="cacheresponse2-class-microsoft-web-media-smoothstreaming.md">CacheResponse2</a></td>
<td>Provides an extension of the <a href="cacheresponse-class-microsoft-web-media-smoothstreaming_1.md">CacheResponse</a> class that enables creation of a CacheResponse object that is based on a specified stream or is fully finalized and ready for use.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="chunkdownloadedeventargs-class-microsoft-web-media-smoothstreaming.md">ChunkDownloadedEventArgs</a></td>
<td>Provides arguments for the <a href="smoothstreamingmediaelement-chunkdownloadfailed-event-microsoft-web-media-smoothstreaming.md">ChunkDownloadFailed</a> event for non-text chunks in main content.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="chunkinfo-class-microsoft-web-media-smoothstreaming_1.md">ChunkInfo</a></td>
<td>Defines per-chunk information for text/binary chunks of Smooth Streaming data.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="chunkresult-class-microsoft-web-media-smoothstreaming_1.md">ChunkResult</a></td>
<td>Contains all the result information for the <a href="trackinfo-begingetchunk-method-microsoft-web-media-smoothstreaming_1.md">BeginGetChunk</a> and <a href="trackinfo-endgetchunk-method-microsoft-web-media-smoothstreaming_1.md">EndGetChunk</a> methods.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="clipcontext-class-microsoft-web-media-smoothstreaming_1.md">ClipContext</a></td>
<td>Context information for a Smooth Streaming media clip. This information is Read-only and specific to clip.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="clipeventargs-class-microsoft-web-media-smoothstreaming_1.md">ClipEventArgs</a></td>
<td>Class used by media clips to pass event argument information that contains an associated clip context instance.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="clipinformation-class-microsoft-web-media-smoothstreaming_1.md">ClipInformation</a></td>
<td>Metadata class for scheduling and viewing a segment of audio or video media data.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="clipplaybackeventargs-class-microsoft-web-media-smoothstreaming_1.md">ClipPlaybackEventArgs</a></td>
<td>Class that contains event data for a media clip event.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="manifestinfo-class-microsoft-web-media-smoothstreaming_1.md">ManifestInfo</a></td>
<td>Represents the manifest in application code. This class corresponds to the &lt;SmoothStreamingMedia&gt; element in the client manifest and to the <a href="smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingSource</a> property of the <a href="smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingMediaElement</a>.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="protectionheader-class-microsoft-web-media-smoothstreaming_1.md">ProtectionHeader</a></td>
<td>Headers for <a href="protectioninfo-class-microsoft-web-media-smoothstreaming_1.md">ProtectionInfo</a> digital rights management objects.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="protectioninfo-class-microsoft-web-media-smoothstreaming_1.md">ProtectionInfo</a></td>
<td>Digital rights management information.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="seekcompletedeventargs-class-microsoft-web-media-smoothstreaming_1.md">SeekCompletedEventArgs</a></td>
<td>Class used to pass event argument information when a seek event completes.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="segmentinfo-class-microsoft-web-media-smoothstreaming_1.md">SegmentInfo</a></td>
<td>Defines the information that must be exposed by any manifest parser. This class corresponds to the Clip element in the composite manifest. You can extend the class with private data if a custom parser needs more information.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="setplaybackrangecompletedeventargs-class-microsoft-web-media-smoothstreaming.md">SetPlaybackRangeCompletedEventArgs</a></td>
<td>Represents event arguments for the completion of a SetPlaybackRangeAysnc operation.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="smoothstreamingasyncresult-class-microsoft-web-media-smoothstreaming.md">SmoothStreamingAsyncResult</a></td>
<td>Provides an implementation of the <a href="https://msdn.microsoft.com/en-us/library/ft8a6455(v=vs.95)">IAsyncResult</a> interface for the <a href="trackinfo-endgetchunk-method-microsoft-web-media-smoothstreaming_1.md">EndGetChunk(IAsyncResult)</a> method.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="smoothstreamingerroreventargs-class-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingErrorEventArgs</a></td>
<td>Class to pass error event information about a Smooth Streaming operation.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="smoothstreamingexception-class-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingException</a></td>
<td>Class to contain Smooth Streaming exception information.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingMediaElement</a></td>
<td>Represents a media player that provides <a href="https://msdn.microsoft.com/en-us/library/ms611595(v=vs.95)">MediaElement</a> capabilities and advertising integration. The class is designed to support Smooth Streaming.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="ssmedrmsetupdecryptorcompletedeventargs-class-microsoft-web-media-smoothstreaming.md">SSMEDrmSetupDecryptorCompletedEventArgs</a></td>
<td>Represents event arguments for a <a href="smoothstreamingmediaelement-drmsetupdecryptorcompleted-event-microsoft-web-media-smoothstreaming.md">DrmSetupDecryptorCompleted</a> event.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="ssmelogreadyroutedeventargs-class-microsoft-web-media-smoothstreaming_1.md">SSMELogReadyRoutedEventArgs</a></td>
<td>Provides data for the <a href="smoothstreamingmediaelement-logready-event-microsoft-web-media-smoothstreaming_1.md">LogReady</a> event.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="streaminfo-class-microsoft-web-media-smoothstreaming_1.md">StreamInfo</a></td>
<td>Defines the basic information for each stream. This class corresponds to the StreamIndex element of the client manifest. You can extend the class to add private data per stream.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md">StreamUpdatedEventArgs</a></td>
<td>Arguments for the Microsoft.Web.Media.SmoothStreaming.ManifestInfo.StreamSelected, Microsoft.Web.Media.SmoothStreaming.ManifestInfo.ChunkAdded and Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.StreamUpdatedAction.TracksSelected events.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="streamupdatedlisteventargs-class-microsoft-web-media-smoothstreaming_1.md">StreamUpdatedListEventArgs</a></td>
<td>A list of <a href="streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md">StreamUpdatedEventArgs</a>.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="trackchangedeventargs-class-microsoft-web-media-smoothstreaming_1.md">TrackChangedEventArgs</a></td>
<td>Arguments for an event that occurs when a media track changes.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="trackinfo-class-microsoft-web-media-smoothstreaming_1.md">TrackInfo</a></td>
<td>Represents track information that corresponds to the QualityLevel element of the client manifest.</td>
</tr>
</tbody>
</table>


## Interfaces

<table>
<thead>
<tr class="header">
<th> </th>
<th>Interface</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Public interface" alt="Public interface" /></td>
<td><a href="ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md">ISmoothStreamingCache</a></td>
<td>Interface definition for writing a cache plug-in.</td>
</tr>
</tbody>
</table>


## Delegates

<table>
<thead>
<tr class="header">
<th> </th>
<th>Delegate</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Ee532718.pubdelegate(en-us,VS.90).gif" title="Public delegate" alt="Public delegate" /></td>
<td><a href="smoothstreamingmediaelement-manifestmergehandler-delegate-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingMediaElement.ManifestMergeHandler</a></td>
<td>Delegate method to merge data from more than one manifest.</td>
</tr>
<tr class="even">
<td><img src="images/Ee532718.pubdelegate(en-us,VS.90).gif" title="Public delegate" alt="Public delegate" /></td>
<td><a href="smoothstreamingmediaelement-setplaybackrangecompletedeventhandler-delegate-microsoft-web-media-smoothstreaming.md">SmoothStreamingMediaElement.SetPlaybackRangeCompletedEventHandler</a></td>
<td>Represents the event handler signature for a SetPlaybackRangeAsync operation.</td>
</tr>
<tr class="odd">
<td><img src="images/Ee532718.pubdelegate(en-us,VS.90).gif" title="Public delegate" alt="Public delegate" /></td>
<td><a href="ssmelogreadyroutedeventhandler-delegate-microsoft-web-media-smoothstreaming_1.md">SSMELogReadyRoutedEventHandler</a></td>
<td>The event handler for the <a href="smoothstreamingmediaelement-logready-event-microsoft-web-media-smoothstreaming_1.md">LogReady</a> event.</td>
</tr>
</tbody>
</table>


## Enumerations

<table>
<thead>
<tr class="header">
<th> </th>
<th>Enumeration</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd566080.pubenumeration(en-us,VS.90).gif" title="Public enumeration" alt="Public enumeration" /></td>
<td><a href="chunkrequesttype-enumeration-microsoft-web-media-smoothstreaming.md">ChunkRequestType</a></td>
<td>The chunk type for a download request.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubenumeration(en-us,VS.90).gif" title="Public enumeration" alt="Public enumeration" /></td>
<td><a href="chunkresult-chunkresultstate-enumeration-microsoft-web-media-smoothstreaming_1.md">ChunkResult.ChunkResultState</a></td>
<td>An enumeration that contains the possible result states during processing by the <a href="trackinfo-begingetchunk-method-microsoft-web-media-smoothstreaming_1.md">BeginGetChunk</a> and <a href="trackinfo-endgetchunk-method-microsoft-web-media-smoothstreaming_1.md">EndGetChunk</a> methods.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubenumeration(en-us,VS.90).gif" title="Public enumeration" alt="Public enumeration" /></td>
<td><a href="clipprogress-enumeration-microsoft-web-media-smoothstreaming_1.md">ClipProgress</a></td>
<td>Enumeration that specifies the stages of progress through a media clip.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubenumeration(en-us,VS.90).gif" title="Public enumeration" alt="Public enumeration" /></td>
<td><a href="manifesttype-enumeration-microsoft-web-media-smoothstreaming.md">ManifestType</a></td>
<td>The manifest type.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubenumeration(en-us,VS.90).gif" title="Public enumeration" alt="Public enumeration" /></td>
<td><a href="playbackmode-enumeration-microsoft-web-media-smoothstreaming_1.md">PlaybackMode</a></td>
<td>Enumeration that specifies the Smooth Streaming playback mode to be used during main content playback.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubenumeration(en-us,VS.90).gif" title="Public enumeration" alt="Public enumeration" /></td>
<td><a href="playbackstartposition-enumeration-microsoft-web-media-smoothstreaming_1.md">PlaybackStartPosition</a></td>
<td>Enumeration that specifies the position from which playback of a media stream begins.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubenumeration(en-us,VS.90).gif" title="Public enumeration" alt="Public enumeration" /></td>
<td><a href="smoothstreamingmediaelementstate-enumeration-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingMediaElementState</a></td>
<td>Enumeration of possible states for the <a href="smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingMediaElement</a>.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubenumeration(en-us,VS.90).gif" title="Public enumeration" alt="Public enumeration" /></td>
<td><a href="streamupdatedeventargs-streamupdatedaction-enumeration-microsoft-web-media-smoothstreaming_1.md">StreamUpdatedEventArgs.StreamUpdatedAction</a></td>
<td>Action enumeration for the Microsoft.Web.Media.SmoothStreaming.ManifestInfo.StreamSelected, Microsoft.Web.Media.SmoothStreaming.ManifestInfo.ChunkAdded and Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.StreamUpdatedAction.TracksSelected in the <a href="streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md">StreamUpdatedEventArgs</a> class.</td>
</tr>
</tbody>
</table>

