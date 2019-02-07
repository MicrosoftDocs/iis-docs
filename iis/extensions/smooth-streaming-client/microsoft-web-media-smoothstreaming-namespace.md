---
title: Microsoft.Web.Media.SmoothStreaming Namespace ()
TOCTitle: Microsoft.Web.Media.SmoothStreaming
ms:assetid: N:Microsoft.Web.Media.SmoothStreaming
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming(v=VS.90)
ms:contentKeyID: 23961138
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming
dev_langs:
- CSharp
- JScript
- VB
---

# Microsoft.Web.Media.SmoothStreaming Namespace

Client classes for IIS Media Services smooth streaming applications.

Smooth Streaming is an IIS Media Services extension that enables adaptive streaming of media to Silverlight clients over HTTP. For more information and code scenarios, see [IIS Smooth Streaming Client 1.5](microsoft-smooth-streaming-client-2-0.md).

## Classes

||Class|Description|
|--- |--- |--- |
|![Public class](images/Ee532677.pubclass(en-us,VS.90).gif "Public class")|[CacheRequest](cacherequest-class-microsoft-web-media-smoothstreaming_1.md)|The object describing the request being made.|
|![Public class](images/Ee532677.pubclass(en-us,VS.90).gif "Public class")|[CacheResponse](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md)|The object describing the response from the cache.|
|![Public class](images/Ee532677.pubclass(en-us,VS.90).gif "Public class")|[ChunkInfo](chunkinfo-class-microsoft-web-media-smoothstreaming_1.md)|Defines per chunk information for text/binary chunks of Smooth Streaming data.|
|![Public class](images/Ee532677.pubclass(en-us,VS.90).gif "Public class")|[ChunkResult](chunkresult-class-microsoft-web-media-smoothstreaming_1.md)|Contains all the result information for the [BeginGetChunk](trackinfo-begingetchunk-method-microsoft-web-media-smoothstreaming_1.md) and [EndGetChunk](trackinfo-endgetchunk-method-microsoft-web-media-smoothstreaming_1.md) methods.|
|![Public class](images/Ee532677.pubclass(en-us,VS.90).gif "Public class")|[ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md)|Context information for a Smooth Streaming media clip. This information is Read-only and specific to clip.|
|![Public class](images/Ee532677.pubclass(en-us,VS.90).gif "Public class")|[ClipEventArgs](clipeventargs-class-microsoft-web-media-smoothstreaming_1.md)|Class used by media clips to pass event argument information that contains an associated clip context instance.|
|![Public class](images/Ee532677.pubclass(en-us,VS.90).gif "Public class")|[ClipInformation](clipinformation-class-microsoft-web-media-smoothstreaming_1.md)|Metadata class for scheduling and viewing a segment of audio or video media data.|
|![Public class](images/Ee532677.pubclass(en-us,VS.90).gif "Public class")|[ClipPlaybackEventArgs](clipplaybackeventargs-class-microsoft-web-media-smoothstreaming_1.md)|Class that contains event data for a media clip event.|
|![Public class](images/Ee532677.pubclass(en-us,VS.90).gif "Public class")|[ManifestInfo](manifestinfo-class-microsoft-web-media-smoothstreaming_1.md)|Represents the manifest in application code. This class corresponds to the <SmoothStreamingMedia> element in the client manifest and to the [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) property of the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md).|
|![Public class](images/Ee532677.pubclass(en-us,VS.90).gif "Public class")|[ProtectionHeader](protectionheader-class-microsoft-web-media-smoothstreaming_1.md)|Headers for [ProtectionInfo](protectioninfo-class-microsoft-web-media-smoothstreaming_1.md) digital rights management objects.|
|![Public class](images/Ee532677.pubclass(en-us,VS.90).gif "Public class")|[ProtectionInfo](protectioninfo-class-microsoft-web-media-smoothstreaming_1.md)|Digital rights management information.|
|![Public class](images/Ee532677.pubclass(en-us,VS.90).gif "Public class")|[SeekCompletedEventArgs](seekcompletedeventargs-class-microsoft-web-media-smoothstreaming_1.md)|Class used to pass event argument information when a seek event completes.|
|![Public class](images/Ee532677.pubclass(en-us,VS.90).gif "Public class")|[SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md)|Defines the information that must be exposed by any manifest parser. This class corresponds to the Clip element in the composite manifest. You can extend the class with private data if a custom parser needs more information.|
|![Public class](images/Ee532677.pubclass(en-us,VS.90).gif "Public class")|[SmoothStreamingErrorEventArgs](smoothstreamingerroreventargs-class-microsoft-web-media-smoothstreaming_1.md)|Class to pass error event information about a Smooth Streaming operation.|
|![Public class](images/Ee532677.pubclass(en-us,VS.90).gif "Public class")|[SmoothStreamingException](smoothstreamingexception-class-microsoft-web-media-smoothstreaming_1.md)|Class to contain Smooth Streaming exception information.|
|![Public class](images/Ee532677.pubclass(en-us,VS.90).gif "Public class")|[SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)|Represents a media player that provides [MediaElement](https://msdn.microsoft.com/en-us/library/ms611595(v=vs.90)) capabilities and advertising integration. The class is designed to support IIS Smooth Streaming.|
|![Public class](images/Ee532677.pubclass(en-us,VS.90).gif "Public class")|[SSMELogReadyRoutedEventArgs](ssmelogreadyroutedeventargs-class-microsoft-web-media-smoothstreaming_1.md)|Provides data for the [LogReady](smoothstreamingmediaelement-logready-event-microsoft-web-media-smoothstreaming_1.md) event.|
|![Public class](images/Ee532677.pubclass(en-us,VS.90).gif "Public class")|[StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)|Defines the basic information for each stream. This class corresponds to the StreamIndex element of the client manifest. You can extend the class to add private data per stream.|
|![Public class](images/Ee532677.pubclass(en-us,VS.90).gif "Public class")|[StreamUpdatedEventArgs](streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md)|Arguments for the StreamSelected()()()(), ChunkAdded()()()() and TracksSelected()()()() events.|
|![Public class](images/Ee532677.pubclass(en-us,VS.90).gif "Public class")|[StreamUpdatedListEventArgs](streamupdatedlisteventargs-class-microsoft-web-media-smoothstreaming_1.md)|A list of [StreamUpdatedEventArgs](streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md).|
|![Public class](images/Ee532677.pubclass(en-us,VS.90).gif "Public class")|[TrackChangedEventArgs](trackchangedeventargs-class-microsoft-web-media-smoothstreaming_1.md)|Arguments for an event that occurs when a media track changes.|
|![Public class](images/Ee532677.pubclass(en-us,VS.90).gif "Public class")|[TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)|Represents track information that corresponds to the QualityLevel element of the client manifest.|


## Interfaces

||Interface|Description|
|--- |--- |--- |
|![Public interface](images/Ff728140.pubinterface(en-us,VS.90).gif "Public interface")|[ISmoothStreamingCache](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md)|Interface definition for writing a cache plug-in.|


## Delegates

||Delegate|Description|
|--- |--- |--- |
|![Public delegate](images/Ee532718.pubdelegate(en-us,VS.90).gif "Public delegate")|[SmoothStreamingMediaElement. . :: . .ManifestMergeHandler](smoothstreamingmediaelement-manifestmergehandler-delegate-microsoft-web-media-smoothstreaming_1.md)|Delegate method to merge data from more than one manifest.|
|![Public delegate](images/Ee532718.pubdelegate(en-us,VS.90).gif "Public delegate")|[SSMELogReadyRoutedEventHandler](ssmelogreadyroutedeventhandler-delegate-microsoft-web-media-smoothstreaming_1.md)|The event handler for the [LogReady](smoothstreamingmediaelement-logready-event-microsoft-web-media-smoothstreaming_1.md) event.|

## Enumerations

||Enumeration|Description|
|--- |--- |--- |
|![Public enumeration](images/Ee532677.pubenumeration(en-us,VS.90).gif "Public enumeration")|[ChunkResult. . :: . .ChunkResultState](chunkresult-chunkresultstate-enumeration-microsoft-web-media-smoothstreaming_1.md)|An enumeration that contains the possible result states during processing by the [BeginGetChunk](trackinfo-begingetchunk-method-microsoft-web-media-smoothstreaming_1.md) and [EndGetChunk](trackinfo-endgetchunk-method-microsoft-web-media-smoothstreaming_1.md) methods.|
|![Public enumeration](images/Ee532677.pubenumeration(en-us,VS.90).gif "Public enumeration")|[ClipProgress](clipprogress-enumeration-microsoft-web-media-smoothstreaming_1.md)|Enumeration that specifies the stages of progress through a media clip.|
|![Public enumeration](images/Ee532677.pubenumeration(en-us,VS.90).gif "Public enumeration")|[PlaybackMode](playbackmode-enumeration-microsoft-web-media-smoothstreaming_1.md)|Enumeration that specifies the Smooth Streaming playback mode to be used during main content playback.|
|![Public enumeration](images/Ee532677.pubenumeration(en-us,VS.90).gif "Public enumeration")|[PlaybackStartPosition](playbackstartposition-enumeration-microsoft-web-media-smoothstreaming_1.md)|Enumeration that specifies the position from which playback of a media stream begins.|
|![Public enumeration](images/Ee532677.pubenumeration(en-us,VS.90).gif "Public enumeration")|[SmoothStreamingMediaElementState](smoothstreamingmediaelementstate-enumeration-microsoft-web-media-smoothstreaming_1.md)|Enumeration of possible states for the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md).|
|![Public enumeration](images/Ee532677.pubenumeration(en-us,VS.90).gif "Public enumeration")|[StreamUpdatedEventArgs. . :: . .StreamUpdatedAction](streamupdatedeventargs-streamupdatedaction-enumeration-microsoft-web-media-smoothstreaming_1.md)|Action enumeration for the StreamSelected()()()(), ChunkAdded()()()() and TracksSelected()()()() in the [StreamUpdatedEventArgs](streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md) class.|
