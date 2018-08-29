---
title: "Adaptive Streaming Comparison | Microsoft Docs"
author: rick-anderson
description: "IIS Smooth Streaming provides users with a truly compelling way to watch the best-possible-quality streaming video. First proven in production at the Summer..."
ms.author: iiscontent
manager: soshir
ms.date: 01/28/2010
ms.topic: article
ms.assetid: 30b7a23b-7d85-42f3-b1fc-75355de6e090
ms.technology: iis-media
ms.prod: iis
msc.legacyurl: /learn/media/smooth-streaming/adaptive-streaming-comparison
msc.type: authoredcontent
---
Adaptive Streaming Comparison
====================
by [Chris Knowlton](https://twitter.com/chris_knowlton)

[IIS Smooth Streaming](https://www.iis.net/downloads/microsoft/smooth-streaming) provides users with a truly compelling way to watch the best-possible-quality streaming video. First proven in production at the Summer 2008 Olympics in Beijing, this live and on-demand adaptive streaming technology from Microsoft represents the latest generation in video streaming technologies.

Part of [IIS Media Services](https://www.iis.net/media), IIS Smooth Streaming delivers up to true HD (1080p) video experiences that increase user engagement times. With integrated media delivery in [IIS](https://www.iis.net/overview), you no longer need separate Web and streaming infrastructures to deliver compelling Web and rich media content to three screens (computer, TV, mobile). Using a single platform saves the cost of managing separate server infrastructures, and reduces the time to market and cost for deploying new applications, Web sites, and rich media experiences.

IIS Smooth Streaming is based on standard protocols, scales out using existing HTTP delivery and caching infrastructures, and ensures simplified file management by using as few as one contiguous video file to deliver multiple video quality levels. Combined with the [Silverlight Media Framework](http://smf.codeplex.com/) and the upcoming Smooth Streaming client porting kit, IIS Smooth Streaming provides built-in sophisticated stream-switching, full DVR controls, and support for multiple camera angles. In addition, IIS Smooth Streaming 4.0 will also provide an option for [streaming to iPhone](https://www.iis.net/overview/choice/integratedmediaplatform) and QuickTime X players.

The industry is excited by Microsoft's commitment to standards-based HTTP media delivery, and recent announcements from our partners and competitors are a validation of the Smooth Streaming approach to adaptive streaming. For example, as IIS Smooth Streaming has gained momentum, there have been new announcements from Adobe and Apple about methods each company now supports for varying the quality levels during video streaming. Adobe Flash Dynamic Streaming is a traditional multiple-bit-rate (MBR) streaming technology that is very similar to RealNetworks SureStream (released in 1998) and Windows Media Intelligent Streaming (released in 1999), and requires proprietary streaming servers to scale out to a large audience. Apple HTTP Adaptive Bitrate Streaming provides rudimentary stream-switching capabilities to devices running current Apple operating systems, and requires pre-segmenting your content into hundreds or thousands of small file chunks.

In the table below, we compare the latest adaptive streaming technologies from Microsoft, Adobe, and Apple.   

|  | Microsoft IIS Smooth Streaming | Adobe Flash Dynamic Streaming | Apple HTTP Adaptive Bitrate Streaming |
| --- | --- | --- | --- |
| Cost per Streaming Server | Free download[1](#1) + $469 for OS [2](#2) | $4500 [3](#3) + OS cost [4](#4) | Cost of Web server [5](#5) + segmenter OS [6](#6) |
| On-demand &amp; Live Streaming | ![](adaptive-streaming-comparison/_static/image1.gif) | ![](adaptive-streaming-comparison/_static/image3.gif) | ![](adaptive-streaming-comparison/_static/image5.gif) |
| Live Streaming DVR [7](adaptive-streaming-comparison.md#7) | ![](adaptive-streaming-comparison/_static/image7.gif) | Pause &amp; Seek |  |
| Streaming Protocol | HTTP | RTMP | HTTP |
| Scalability via HTTP Edge Caches | ![](adaptive-streaming-comparison/_static/image9.gif) |  | ![](adaptive-streaming-comparison/_static/image11.gif) |
| Stateless Server Connection [8](adaptive-streaming-comparison.md#8) | ![](adaptive-streaming-comparison/_static/image13.gif) |  | ![](adaptive-streaming-comparison/_static/image15.gif) |
| Supported Platforms | Silverlight, Xbox 360, other Smooth Streaming-compatible players, and iPhone OS 3.0 [9](adaptive-streaming-comparison.md#9) | Flash Player 10, AIR | iPhone OS 3.0, devices running QuickTime X |
| DRM Support for Live, VOD | PlayReady | None [10](adaptive-streaming-comparison.md#10) | None |
| DRM ASP &amp; Encoder ISV Support | ![](adaptive-streaming-comparison/_static/image17.gif) |  |  |
| Interoperable DRM (DECE Approved)[11](adaptive-streaming-comparison.md#11) | ![](adaptive-streaming-comparison/_static/image19.gif) |  |  |
| Real-time Client and Server Logging | ![](adaptive-streaming-comparison/_static/image21.gif)[12](adaptive-streaming-comparison.md#12) |  |  |
| Programmable Client Side Switching Logic | ![](adaptive-streaming-comparison/_static/image23.gif) | ![](adaptive-streaming-comparison/_static/image25.gif) |  |
| Live In-Stream Ad Integration | ![](adaptive-streaming-comparison/_static/image27.gif) |  |  |
| Built-in Analytics Framework | ![](adaptive-streaming-comparison/_static/image29.gif) |  |  |
| Delivery to Mobile Devices | ![](adaptive-streaming-comparison/_static/image31.gif) |  | ![](adaptive-streaming-comparison/_static/image33.gif) |
| Native 64-bit Server Support | ![](adaptive-streaming-comparison/_static/image35.gif) |  | ![](adaptive-streaming-comparison/_static/image37.gif) |
| Media Container | MPEG 4 – Part 12 (Fragmented MP4) | MPEG 4 – Part 12 (MP4), FLV | MPEG-2 TS |
| Supported Video Codecs | Codec Agnostic (currently supports VC-1 Advanced Profile &amp; H.264 Baseline, Main, and High) | H.264 Baseline, Main, and High; VP6 | H.264 Baseline Level 3.0 |
| Supported Audio Codecs | Codec Agnostic (currently supports WMA &amp; AAC) | AAC, MP3 | MP3, HE-AAC, AAC-LC |
| Maximum Bit Rate | No limit | No limit | 1.6 Mbps |
| Default Fragment Length | 2 seconds | n/a | 10 seconds |
| End-To-End Latency | As low as 1.5 seconds (configurable) | 6 seconds | 30 seconds [13](adaptive-streaming-comparison.md#13) |
| File Type on Server | Contiguous | Contiguous | Fragmented |
| Client Programming Platform | Microsoft .NET Framework | Adobe ActionScript | Objective-C |


|   Footnotes...    |
|-------------------|
|  <a id="1"></a>1  |
|  <a id="2"></a>2  |
|  <a id="3"></a>3  |
|  <a id="4"></a>4  |
|  <a id="5"></a>5  |
|  <a id="6"></a>6  |
|  <a id="7"></a>7  |
|  <a id="8"></a>8  |
|  <a id="9"></a>9  |
| <a id="10"></a>10 |
| <a id="11"></a>11 |
| <a id="12"></a>12 |
| <a id="13"></a>13 |

