---
title: "Smooth Streaming Client Readme | Microsoft Docs"
author: rick-anderson
description: "Last Updated: May 31, 2012 Applies To: Microsoft Smooth Streaming Client 2.0 RTW IIS Smooth Streaming Client 1.1 RTW IIS Smooth Streaming Client 1.5 RTW Cont..."
ms.author: iiscontent
manager: soshir
ms.date: 06/23/2011
ms.topic: article
ms.assetid: b945d983-c2cc-4827-a408-fca9ec9b1bd6
ms.technology: iis-media
ms.prod: iis
msc.legacyurl: /learn/media/smooth-streaming/smooth-streaming-client-readme
msc.type: authoredcontent
---
Smooth Streaming Client Readme
====================
by Dave Nelson

Last Updated: May 31, 2012

Applies To:

- [Microsoft Smooth Streaming Client 2.0 RTW](https://go.microsoft.com/?linkid=9811306)
- [IIS Smooth Streaming Client 1.1 RTW](https://go.microsoft.com/?linkid=9745648)
- [IIS Smooth Streaming Client 1.5 RTW](https://go.microsoft.com/?linkid=9754194)

**Contents**

- [Introduction](smooth-streaming-client-readme.md#intro)
- [Package contents](smooth-streaming-client-readme.md#package)
- [System Requirements](smooth-streaming-client-readme.md#requirements)
- [Known issues](smooth-streaming-client-readme.md#issues)
- [For more information](smooth-streaming-client-readme.md#resources)
- [Support information](smooth-streaming-client-readme.md#support)
- [Release history](smooth-streaming-client-readme.md#history)

<a id="intro"></a>

## Introduction

Smooth Streaming Client SDKs enable you to build rich on-demand and live Smooth Streaming experiences for [Silverlight](https://go.microsoft.com/?linkid=9735130) and [Windows Phone](https://go.microsoft.com/?linkid=9745649) applications that take full advantage of the capabilities of the Smooth Streaming extensions in [IIS Media Services](https://go.microsoft.com/?linkid=9735131). The [Smooth Streaming Client Application Programming Interfaces (APIs)](https://go.microsoft.com/?linkid=9811178) provide an easy-to-use interface for developers and designers to create rich Smooth Streaming experiences on Silverlight and Windows Phone platforms. The APIs provide support for simple operations such as Play, Pause, and Stop and also more complex operations such as scheduling advertisements, selecting and tracking bitrates for Smooth Streaming playback, and many more. Smooth Streaming Client is used in the [Microsoft Media Platform: Player Framework (MMPPF)](https://go.microsoft.com/?linkid=9745652). This partnership facilitates faster player development.

Smooth Streaming Client includes SDK DLLs with APIs for both desktop Silverlight client development and for Windows Phone development. For more information, see [Package contents](smooth-streaming-client-readme.md#package).

Smooth Streaming Client SDKs support the following high-level features:

**Available in Microsoft Smooth Streaming Client 2.0**

- Persistent advertisement ("linear ads") 

    - Ad-insertion ([ScheduleLinearClip](https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.schedulelinearclip(v=vs.95)))
    - Ad playback
- Live-to-VOD 

    - Client-controlled unlimited DVR window
- Failed chunk download details (non-text chunks) 

    - New [ChunkDownloadFailed](https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.chunkdownloadfailed(v=vs.95)) event arguments for getting information about failed chunk downloads
- Key rotation 

    - Prefetch root licenses for authorized channels to enable instant channel changes
    - Distribute license requests to avoid flooding the license server
- Updated cache plug-in properties 

    - Get or Set a web request that the media element downloader uses for downloading ([CacheRequest2](https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.cacherequest2(VS.95).aspx))
    - Get or Set the perceived bandwidth while downloading individual media chunks ([CacheResponse2](https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.cacheresponse2(VS.95).aspx))
    - Get or Set the track the cache plug-in uses for downloading a media chunk (CacheResponse2)

**Available in all versions**

- Basic playback controls 

    - APIs such as Play, Pause, Stop
    - Events for playback and diagnostics
    - Properties to track position, and so on
- Advanced playback support 

    - DVR support for Live Smooth Streaming
    - Support for tracking live events while in DVR
    - Trickplay: slow motion/fast-forward/rewind (desktop Silverlight only, not available on Windows Phone)
    - Multiple Audio Language support
    - Textstream support for captions/subtitles (desktop Silverlight only, not available on Windows Phone)
- Support for offline playback scenarios
- H.264/AAC support
- Monetization 

    - Ad playback integration: scheduling capabilities, tracking ad progress (desktop Silverlight only, not available on Windows Phone)
    - Live ad insertion with [IIS Live Smooth Streaming](https://go.microsoft.com/?linkid=9745650) (desktop Silverlight only, not available on Windows Phone)
    - Rich analytics with [IIS Advanced Logging](https://go.microsoft.com/?linkid=9745651).
    - Analytics APIs
    - Support for specifying markers/ad-ingestion points outside the main manifest (desktop Silverlight only, not available on Windows Phone)
- Content protection – PlayReady integration for VC-1/H.264-encoded content
- Composite manifest support for scenarios such as Microsoft Media Platform Video Editor (desktop Silverlight only, not available on Windows Phone)
- Selecting tracks for playback (for example, restrict the available bitrates, support multiple camera angles in a single stream, and so on)
- Support for progressive download ads/content (desktop Silverlight only, not available on Windows Phone)

Microsoft Smooth Streaming Client 2.0 and IIS Smooth Streaming Client 1.5 support IIS Media Services manifest compression (requires [IIS Media Services 4](https://go.microsoft.com/?linkid=9735131)). This is supported on desktop Silverlight only. It's not supported on Windows Phone.

<a id="package"></a>

## Package contents

When the package is installed, directories are created by default under: %*ProgramFiles*%\Microsoft SDKs\Smooth Streaming Client\*Version*\

The root directory contains the following folders and files:

- **Silverlight**. Contains the SDK DLL with APIs for desktop Silverlight.
- **Windows Phone**. Contains the SDK DLL with APIs for Windows Phone.
- **Smooth Streaming Client RTW.rtf**. The End-User License Agreement (EULA).
- **Readme.htm**. A link to this document.
- **REDIST.txt**. This file specifies which files the redistribution rights in the EULA apply to. See the license terms that accompany the package for more information about redistribution rights.

<a id="requirements"></a>

## System requirements

Smooth Streaming Client can be installed on the following operating systems: Windows Server 2008 R2, Windows Server 2008, Windows 7, Windows Vista, Windows XP

The following software must be installed to develop applications using Smooth Streaming Client:

- [Microsoft Visual Studio 2010](https://go.microsoft.com/?linkid=9745654) or [Microsoft Visual Web Developer 2010 Express](https://go.microsoft.com/?linkid=9745655).
- [Silverlight 5 Tools for Visual Studio 2010](https://www.microsoft.com/download/details.aspx?id=28358) (for application development using Microsoft Smooth Streaming Client 2.0) or [Silverlight 4 Tools for Visual Studio 2010](https://go.microsoft.com/?linkid=9745656) (for application development using IIS Smooth Streaming Client 1.5 or 1.1).
- For developing Windows Phone applications, install the [Windows Phone Developer Tools](https://go.microsoft.com/?linkid=9745657) and the [Windows Phone Developer Tools January 2011 Update](https://go.microsoft.com/?linkid=9767590). For more information about Windows Phone development, see the [Windows Phone App Hub](https://go.microsoft.com/?linkid=9745653).
- For testing your applications on client computers, your Macintosh or Windows client computer must be running an Internet browser supported by Silverlight 4, such as Internet Explorer, Safari, or Firefox.

<a id="issues"></a>

## Known issues

**Microsoft Smooth Streaming Client 2.0**

- IIS Media Services low-latency live Smooth Streaming isn't supported.
- Playback of encrypted streams isn't supported in Picture-in-Picture (PiP) mode.
- Rewinding an encrypted stream back to the beginning will close the stream.
- Non-sparse tracks in a stream should have the same fragment duration and lookahead values as audio and video tracks in the stream to enable synchronization.
- For linear-ad insertion to work, the main content stream and ad stream must be encoded using identical codecs, resolutions, and encoding profiles.
- When a media stream transitions from a linear clip to a linear ad (or vice-versa), the [LinearClipChanged](https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.linearclipchanged(VS.95).aspx) event might fire twice. The extra event can be ignored.
- If a user pauses a linear ad that's inserted in front of a live stream (a linear "preroll ad"), playback might not transition to the current live playback point when the linear ad finishes. To work around this issue, you can configure your client application to not allow pausing playback of the linear ad or you can call the [StartSeekToLive](https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.startseektolive(VS.95).aspx) method after the ad finishes.
- The first Seek operation after the [MediaOpened](https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.mediaopened(VS.95).aspx) event might be ignored.
- The [Stop](https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.stop(VS.95).aspx) method shouldn't be used during playback of live Smooth Streams.
- Calling the [SelectTracks](https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.streaminfo.selecttracks(VS.95).aspx) method or the [RestrictTracks](https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.streaminfo.restricttracks(VS.95).aspx) method during the [ManifestReady](https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.manifestready(VS.95).aspx) event doesn't update the [SelectedTracks](https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.streaminfo.selectedtracks(VS.95).aspx) property until after the ManifestReady event handler exits.
- You can call [BufferingTime](https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.bufferingtime(VS.95).aspx) Set and Get anytime, but only the last Set before assignment of [SmoothStreamingSource](https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.smoothstreamingsource(VS.95).aspx) is used. If you call Set after setting SmoothStreamingSource, and then call Get, the updated value is returned even though SmoothStreamingMediaElement isn't using that value for BufferingTime. Also, re-buffering causes SmoothStreamingMediaElement to update the BufferingTime value internally, making it unavailable to a Get operation.
- Clips from one or more client manifests that are combined into a composite manifest must have identical audio tracks.

**IIS Smooth Streaming Client 1.5**

- Smooth Streaming Client 1.5 supports IIS Media Services low latency for live Smooth Streams. (This is supported on desktop Silverlight only. It's not supported on Windows Phone.) Low-latency live streaming scenarios require that the Smooth Streaming client connect to a publishing point on a web server that's running at least IIS Media Services 4.0. Earlier versions of IIS Media Services don't support low-latency live streaming. For more information about how to configure low-latency live Smooth Streaming, see [BufferingTime](https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.bufferingtime(VS.90).aspx).  
  
    > [!NOTE]
    >  Audio-only streams aren't supported in low-latency live streaming scenarios.

**IIS Smooth Streaming Client 1.1**

- Markers don't fire in trickplay modes. Use [Microsoft Media Platform: Player Framework (MMPPF)](http://smf.codeplex.com/) markers if markers are required in fast-forward, rewind or slow-motion modes.
- The Client treats URIs as case-insensitive, which can cause issues on some servers. Use lowercase manifest/stream URIs to avoid any issues.
- Protected streams aren't supported in composite manifests.
- Audio, video, and textstream fragments in a live Smooth Stream must have the same duration.
- For live Smooth Streams, network requests for metadata might continue after calling the [Stop](https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.stop(VS.90).aspx) method. To avoid this issue, set the [Source](https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.source(VS.90).aspx) property to **Null**.
- To recover from a [MediaFailed](https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.mediafailed(VS.90).aspx) event, set the Source property to **Null**, and then wait for a period of time before resetting the source to reconnect.
- The [PlaybackRate](https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.playbackrate(VS.90).aspx) property must be set to **1.0** before calling the [ScheduleClip](https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.scheduleclip(VS.90).aspx) method. After the clip finishes, you can change the PlaybackRate property back to the desired value.

<a id="resources"></a>

## For more information

Smooth Streaming Client content for developers is available on [MSDN](https://go.microsoft.com/?linkid=9735132).

For more information on the streaming formats, client SDKs, and player formats used to develop Media Services client applications, see [Developing Windows Azure Media Services Client Applications](https://msdn.microsoft.com/en-us/library/dn223283.aspx).

For more information about Windows Phone development, see the [Windows Phone App Hub](https://go.microsoft.com/?linkid=9745653).

<a id="support"></a>

## Support information

You can obtain support for Smooth Streaming Client from fellow users by posting your questions on the [IIS Media Forum](https://forums.iis.net/1145.aspx).

To obtain support from Microsoft, go to [Microsoft Support](https://support.microsoft.com/common/international.aspx?RDPATH=dm;selectassist&amp;target=assistance). Charges may apply.

<a id="history"></a>

## Release history

- May 31, 2012. [Microsoft Smooth Streaming Client SDK 2.0 for Silverlight 5](https://go.microsoft.com/?linkid=9811306)
- September 2, 2011. [IIS Smooth Streaming Client SDK 1.5 for Silverlight 4](https://go.microsoft.com/?linkid=9754194)
- September 24, 2010. [IIS Smooth Streaming Client SDK 1.1 for Silverlight 4](https://go.microsoft.com/?linkid=9745648)
- June 10, 2010. IIS Smooth Streaming Client 1.0
