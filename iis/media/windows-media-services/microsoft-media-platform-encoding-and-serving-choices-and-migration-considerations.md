---
title: "Microsoft Media Platform: Encoding and Serving Choices and Migration Considerations | Microsoft Docs"
author: rick-anderson
description: "This article offers guidance for choosing among the Microsoft Media Platform Technologies that deliver video content. It includes general guidance for migrat..."
ms.author: iiscontent
manager: soshir
ms.date: 04/04/2013
ms.topic: article
ms.assetid: 890c1d57-4dcd-45f7-b0b6-276fa474e3ad
ms.technology: iis-media
ms.prod: iis
msc.legacyurl: /learn/media/windows-media-services/microsoft-media-platform-encoding-and-serving-choices-and-migration-considerations
msc.type: authoredcontent
---
Microsoft Media Platform: Encoding and Serving Choices and Migration Considerations
====================
by Tim Ammann

> This article offers guidance for choosing among the Microsoft Media Platform Technologies that deliver video content. It includes general guidance for migration, and provides details about the new Windows Azure Media Services platform.


**Technical Reviewers**: John Deutscher, Cenk Dingiloglu, David Bristol, Kilroy Hughes, Steven Goulet

**Also thanks to**: Anton Kucer, Eric Zocher

**Published**: January 2013

**Applies to**: Windows Media Services, IIS Media Services, Windows Azure Media Services, Expression Encoder, Transform Manager


## Introduction

Microsoft offers a number of important feature-rich Media Platform Technologies that are useful in a wide variety of scenarios. Nevertheless, some of the technologies offer advantages over others for particular scenarios. This article offers guidance for choosing among them and considerations for migration, including a look at the revolutionary new Windows Azure Media Services platform.


## Contents

1 [Platform Technologies](#Toc343780144)

2 [Encoding and Conversion Technologies](#Toc343780145)

3 [Recent History of Media Formats](#Toc343780146)

4 [Why migrate from Windows Media Services to IIS Media Services?](#Toc343780147)

5 [Reasons to use IIS Media Services and Windows Media Services side-by-side](#Toc343780152)

6 [Considerations when migrating to IIS Media Services](#Toc343780154)

7 [The Advantages of Migrating to Windows Azure Media Services](#Toc343780167)

8 [Resources](#Toc343780187)


<a id="Toc343780144"></a>
## 1 Platform Technologies

Two Microsoft Media Platform Technologies are on-premises (that is, they run on servers placed directly in an enterprise), while the latest, Windows Azure Media Services, is cloud-based as part of Microsoft's Windows Azure cloud computing platform ( [https://www.windowsazure.com/](https://www.windowsazure.com/)).

On-premises media technologies:

- [Windows Media Services](https://www.microsoft.com/windows/windowsmedia/forpros/server/server.aspx) (with versions for [Windows Server 2008](https://www.microsoft.com/en-us/download/details.aspx?id=12442) and [Windows Server 2008 R2](https://www.iis.net/downloads/microsoft/windows-media-services))
- [IIS Media Services 4.1](https://www.iis.net/media) (which runs on Windows Server 2008, Windows Server 2008 R2, and Windows Server 2012)

Cloud-based media technologies:

- [Windows Azure Media Services](https://www.windowsazure.com/en-us/home/scenarios/media/)

The initial components of Windows Azure Media Services, including Ingest, Encoding, Content Protection, and On-Demand, are available or shipping soon. Advertising (Ad Insertion) is currently available through Client SDKs. Additional components, including Live Streaming and Analytics, will be rolled out as they become available. When all of the components are in place, Windows Azure Media Services will offer a complete end-to-end media services solution, including video ingest, encoding and conversion, content protection, on-demand streaming, live streaming, and analytics.


<a id="Toc343780145"></a>
## 2 Encoding and Conversion Technologies

The following encoding and conversion technologies are available from Microsoft:

- [Transform Manager 1.1](https://www.microsoft.com/en-us/download/details.aspx?id=29890) : Converts media files to on-demand smooth streaming format for Silverlight clients and Apple mobile digital devices. This product is available for free download.
- [Expression Encoder 4 with Service Pack 2](https://www.microsoft.com/en-us/download/details.aspx?id=27870) : Expression Encoder is a video-encoding and live-broadcasting application. A free version is available. The [Expression Encoder 4 Pro](https://go.microsoft.com/fwlink/?LinkID=149601) version is necessary for H.264 encoding. Some SP2 features, such as GPU encoding and live template support, are also available only in Expression Encoder 4 Pro.

> [!NOTE]
> Expression Encoder 4 Pro will be unavailable for purchase after 12/31/2013. For more information, see [Microsoft Expression Changes](http://expression.microsoft.com/en-us/cc136533). Additional encoders are available from Microsoft partners such as [Telestream](http://www.telestream.net/), [Digital Rapids](http://www.digitalrapids.com/), [Harmonic](http://harmonicinc.com/), [Elemental](http://www.elementaltechnologies.com/), and [Envivio](http://www.envivio.com/).


- Windows Azure Media Encoding Services: Incorporates the technologies of Transform Manager and Expression Encoder into the Windows Azure cloud. Going forward, the latest versions of these technologies will continue to be developed in the Windows Azure Media Services cloud.

> [!NOTE]
> Third-party encoders are also available for IIS Media Services. For more information, see the Partners section of the [IIS Media Services](https://www.iis.net/media) page. For Windows Azure Media Services, third-party encoders will be available in the Azure Store sometime after Windows Azure Media Services releases.


<a id="Toc343780146"></a>
## 3 Recent History of Media Formats

The Windows Media format helped establish internet video download, first to PCs, then to other devices by using the WMV file container, WMA audio codecs, and the VC-1 video codec (and its predecessors).

To support large scale adaptive bitrate streaming over the internet, Microsoft later developed Smooth Streaming. Smooth Streaming uses the PIFF media format (Protected Interoperable File Format), which is derived from the MPEG ISO Base Media File Format standard. The PIFF media format supports the MPEG AVC video codec, AAC and other audio codecs, and [PlayReady](https://www.microsoft.com/playready/overview/) DRM.

Recently, the core technologies in PIFF and Smooth Streaming have been incorporated into the MPEG standards called Common Encryption (ISO/IEC 23001-7) and DASH "Dynamic Adaptive Streaming over HTTP" (ISO/IEC 23009-1).

Migration to the DASH standard is underway at Microsoft and most of the Internet video industry. The W3C is standardizing the APIs for HTML5 browsers. These APIs will allow Web pages to stream DASH to HTML5 browsers on all types of devices, including TVs, PCs, tablets, and phones.


<a id="Toc343780147"></a>
## 4 Why migrate from Windows Media Services to IIS Media Services?

If you are currently using Windows Media Services, migrating to IIS Media Services offers the following advantages:

- The Smooth Streaming format. Smooth Streaming is a form of adaptive streaming over HTTP that stores video on disk as a single full-length file per encoded bit rate, but creates file chunks virtually upon client request. Because the chunks are sent as standalone files, they are fully cacheable via local network HTTP caching or with a downstream CDN (Content Delivery Network). The single file approach combined with dynamic chunking offers both significant adaptive performance and file-management benefits.
- IIS Media Services can stream to mobile devices, including Apple and Android clients.
- IIS Media Services can stream AVC video in ISO Media files to clients, including Silverlight. (Windows Media Services cannot stream AVC video in ISO Media File Format).
- IIS Media Services can push a live stream from an encoder to multiple downstream media servers. IIS Media Services 4.1 has the ability to pull or push from an upstream server to a downstream server. With Windows Media Services, you are limited to a single downstream server.
- IIS Media Services is supported on Windows Server 2012, while Windows Media Services is not. Take this into consideration when migrating to Windows Server 2012.

<a id="Toc343780148"></a>
### Scenarios still appropriate for Windows Media Services

<a id="Toc343780149"></a>
#### Re-encoding requirement

IIS Media Services does not support the wmv video format, so wmv files must be converted to Smooth Streaming (fragmented ISO Media) format. When planning a migration, take into consideration the size and number of files to be converted.

For more information on re-encoding content for IIS Media Services, see the section "Re-encode wmv content" later in this document.

<a id="Toc343780150"></a>
#### Multicast Streaming (Multicasting)

[Multicast streaming](https://blogs.iis.net/chriskno/archive/2008/07/14/sourcing-from-a-multicast-broadcast-using-windows-media-services.aspx) is a feature of Windows Media Services that lets you deliver streaming content on a closed internal network from a media server. Multicast streaming uses special multicast-enabled routers to deliver streams to an IP address that all clients subscribe to. For more information about multicast streaming, see [Delivering content as a multicast stream](https://technet.microsoft.com/library/cc754435.aspx).

As of this writing, multicast streaming is supported by Windows Media Services, but not by IIS Media Services or Windows Azure Media Services.

<a id="Toc343780151"></a>
#### Audio-only streaming

If you are streaming audio-only content, Silverlight does not support audio-only smooth streaming from IIS Media Services. Silverlight requires a stream to contain both audio and video. For this reason, Windows Media Services may be the better choice for audio-only scenarios.

> [!NOTE]
> If you must use Silverlight, Expression Encoder and IIS Media Services to stream audio, there is a workaround: you can provide Expression Encoder with a very low bitrate (for example, 10 bits per second) placeholder video stream that contains a 1 x 1 pixel. Although not a true audio-only stream, the video portion of the combined audio/video will be very minimal.


<a id="Toc343780152"></a>
## 5 Reasons to use IIS Media Services and Windows Media Services side-by-side

In some scenarios, it might be appropriate to use IIS Media Services and Windows Media Services side-by-side, with each having separate, specific purposes. Because IIS Media Services and Windows Media Services are separate technologies, they can coexist on the same computer.

For example, if you have a mix of audio and video formats, you could use Windows Media Services to deliver wmv and audio content, and IIS Media Services to deliver Smooth Streaming content to Silverlight clients and mobile devices. If you need to stream content both internally and outside to the web, you could use Windows Media Services for multicast streaming, and IIS Media Services for smooth streaming.

The following table shows a comparison of the live streaming features in Windows Media Services and IIS Media Services:

<a id="Toc343780153"></a>
### Streaming: Windows Media Services vs. IIS Media Services 4.1

| Streaming Feature | WMS 2008 | IIS MS 4.1 |
| --- | --- | --- |
| Archiving of live streams | &#10004; | &#10004; |
| Broadcast streaming from files | &#10004; | &#10004; |
| High Availability content sourcing (encoder failover) | &#10004; | &#10004; |
| HTTP Streaming | &#10004; | &#10004; |
| Multiple bitrate streaming (Intelligent vs. Smooth) | &#10004; | &#10004; |
| Server and client side logging | &#10004; | &#10004; |
| Unicast HTTP streaming from live encoders | &#10004; | &#10004; |
| Play While Archiving (late joiner feature) | &#10004; | &#10004; |
| Advanced Server-side Playlists | &#10004; |  |
| Multicast streaming | &#10004; |  |
| RTSP/TCP &amp; RTSP/UDP Streaming | &#10004; |  |
| Windows Media Services proxying and caching | &#10004; |  |
| Full Network DVR |  | &#10004; |
| ISO-based file formats |  | &#10004; |
| Low-latency streaming |  | &#10004; |
| REST-based streaming requests |  | &#10004; |
| Standard HTTP proxying and caching |  | &#10004; |
| Streaming to iOS clients |  | &#10004; |
| Streaming to mobile devices |  | &#10004; |


<a id="Toc343780154"></a>
## 6 Considerations when migrating to IIS Media Services

When migrating from Windows Media Services to IIS Media Services, a phased, gradual approach can be taken, using these three steps:

1) Change the encoder

2) Install Silverlight, or use the Microsoft OSMF plugin

3) Re-encode wmv content

<a id="Toc343780155"></a>
### 1) Change the Encoder

The [mainstream support end date for Windows Media Encoder](https://support.microsoft.com/lifecycle/?LN=en-ie&amp;C2=7761) was 12/01/2010, so if you are currently using Windows Media Encoder, switch to either using the stand-alone [Expression Encoder](http://expression.microsoft.com/en-us/cc136533) tool or a third-party encoder.

> [!NOTE]
> Expression Encoder 4 Pro will be unavailable for purchase after 12/31/2013. For more information, see [Microsoft Expression Changes](http://expression.microsoft.com/en-us/cc136533). Additional encoders are available from Microsoft partners such as [Telestream](http://www.telestream.net/), [Digital Rapids](http://www.digitalrapids.com/), [Harmonic](http://harmonicinc.com/), [Elemental](http://www.elementaltechnologies.com/), and [Envivio](http://www.envivio.com/).


Replacing the encoder is the first step because the encoder is perhaps the easiest of components to replace. Expression Encoder can create content for both Windows Media Services and IIS Media Services.

<a id="Toc343780156"></a>
### 2) Install Silverlight, or use the Microsoft OSMF plugin

Depending on your requirements, your next step will be to install Silverlight on your clients, or use the OSMF plugin to prepare to Smooth Stream to Flash.

<a id="Toc343780157"></a>
#### Silverlight

If your clients are currently using Windows Media Player, you can install [Silverlight](https://www.microsoft.com/silverlight/) on all your clients. Silverlight is capable of playing content from both IIS Media Services and Windows Media Services.

In this interim step, you will have two different Silverlight Application (xap) client files: one for Windows Media Services, and one for IIS Media Smooth Streaming. At this point, you are still using Windows Media Services, but your clients are ready to receive Smooth Streaming content when you make the transition to IIS Media Services. In addition, this interim step has the advantage of providing wider support for browsers, including Safari.

> [!NOTE]
> Different Silverlight applications (.xap files) are required for playing back IIS Media Services and Windows Media Services content. To play Windows Media content, a number of Silverlight templates are available as part of the installation of Expression Encoder. For playing Smooth Streaming content, you can use the [Microsoft Media Platform Player Framework](http://smf.codeplex.com/).


<a id="Toc343780158"></a>
#### OSMF (Open Source Media Framework) plugin

If you do not need to use DRM such as PlayReady and are restricted from deploying Silverlight in your Enterprise, you can use the [Microsoft Smooth Streaming plugin for Open Source Media Framework](https://www.microsoft.com/en-us/download/details.aspx?id=36057). After your .wmv content has been re-encoded to Smooth Streaming format, the plugin will allow you to deliver that content in Smooth Streaming format to Flash clients.

> [!NOTE]
> The OSMF plugin cannot deliver content that is in .wmv format.


In this interim step, your clients will continue using Windows Media Player for Windows Media Services. After your re-coding is complete, you can transition to using IIS Media Services and the OSMF plugin to stream to Flash clients.

#### 

<a id="Toc343780159"></a>
##### A few details about the plugin

The Microsoft Smooth Streaming plugin for Open Source Media Framework 2.0 can easily add Smooth Streaming playback capabilities to existing OSMF-based players. The plugin can be dynamically loaded for use with Strobe Media Playback. With very little coding, the plugin can enable your new or existing applications to consume Smooth Streaming content.

The plugin has the following features:

- On-demand Smooth Streaming playback (Play, Pause, Seek, Stop) 

    - Support for video codecs - H.264
    - Support for Audio codecs - AAC
- Multiple audio language switching with OSMF built-in APIs
- Maximum playback quality selection with OSMF built-in APIs

This version of the plugin requires OSMF 2.0 and Adobe Flash Player 10.2 or higher. For more information, see the [Microsoft Smooth Streaming Plugin for OSMF (Preview)](https://www.microsoft.com/en-us/download/details.aspx?id=36057) download page.

<a id="Toc343780160"></a>
### 3) Re-encode wmv content

When re-encoding your wmv files for migration, you'll need to choose an appropriate Smooth Streaming format and decide which re-encoding tools to use. After you are done re-encoding, change your application and web page links to use the Silverlight Smooth Streaming client or OSMF player.

#### 

<a id="Toc343780161"></a>
#### The IIS smooth streaming format

The IIS Media Services Smooth Streaming format consists of .ismv files that can contain H.264, or VC-1 compression formats. For more information, see [IIS Smooth Streaming Technical Overview](https://download.microsoft.com/download/4/2/4/4247C3AA-7105-4764-A8F9-321CB6C765EB/IIS_Smooth_Streaming_Technical_Overview.pdf).

If your goal is to stream to mobile devices, it is recommended that you choose H.264 rather than VC-1 as the target format because the H.264 format is supported by the hardware decoders on most mobile devices as well as the GPU decoders on most PCs.

<a id="Toc343780162"></a>
#### Re-encoding options

To do the re-encoding, Microsoft offers three choices:

- The format conversion facilities of [Windows Azure Media Services](https://www.windowsazure.com/en-us/home/features/media-services/)
- [Transform Manager](https://www.microsoft.com/en-us/download/details.aspx?id=29890) with [Expression Encoder](http://expression.microsoft.com/en-us/cc136533) (note that re-encoding the AVC (H.264/MPEG-4) format requires the [Pro version of Expression Encoder 4](https://go.microsoft.com/fwlink/?LinkID=149601))
- Expression Encoder, if you have only a few files to convert

> [!NOTE]
> Expression Encoder 4 Pro will be unavailable for purchase after 12/31/2013. For more information, see [Microsoft Expression Changes](http://expression.microsoft.com/en-us/cc136533). Additional encoders are available from Microsoft partners such as [Telestream](http://www.telestream.net/), [Digital Rapids](http://www.digitalrapids.com/), [Harmonic](http://harmonicinc.com/), [Elemental](http://www.elementaltechnologies.com/), and [Envivio](http://www.envivio.com/).


Windows Azure Media Encoder puts the functionality of Expression Encoder into the Windows Azure Media Services cloud. Going forward, the encoding technology in Windows Azure is the one that Microsoft will continue to develop.

If you do decide to use Transform Manager, keep in mind that the Windows Azure equivalent of Transform Manager (that is, the format conversion service on Windows Azure Media Services) will continue to evolve in the cloud while the downloadable version is likely to undergo only minor changes and have limited support.

<a id="Toc343780163"></a>
### OS Platform Considerations

When migrating to IIS Media Services, it is possible to do an in-place migration on the same server, migrate to a separate server, or migrate to virtual machines.

Many customers use virtual machines to reduce the TOC (total cost of ownership) and maximize the use of their hardware. Of course, if you migrate to Windows Azure Media Services, you will be able to take advantage of the scalability of the Azure cloud without the overhead of maintaining an in-house infrastructure.

<a id="Toc343780164"></a>
### An on-premises hybrid approach

One hybrid, less compute-intensive approach is to produce only your new content in Smooth Streaming format, and maintain your existing content in the older wmv format. The content could be served by using IIS Media Services and Windows Media Services side-by-side, as mentioned earlier in this document. This scenario might be an option if your older content is less frequently accessed, or used exclusively by legacy clients.

<a id="Toc343780165"></a>
### Choose a format that supports dynamic packaging

If your plan is to migrate at some point to Windows Azure Media Services for on-demand streaming, your best choice will be to use either the Smooth Streaming or multi-bitrate ISO Base Media File Format (Smooth Streaming is itself a fragmented ISO Base Media format), for the following reasons:

- Fragmented ISO Base Media (fMP4) offers substantial technical advantages over HLS. For more information, see [Unifying Global Video Strategies: MP4 File Fragmentation For Broadcast, Mobile and Web Delivery](http://184.168.176.117/reports-public/Adobe/20111116-fMP4-Adobe-Microsoft.pdf).
- The Windows Azure Media Packager can easily repackage between Smooth Streaming and multi-bitrate ISO Base Media formats.
- The Windows Azure Media Services Origin Service allows you to use a single Smooth Streaming or ISO Base Media 14496-12 multi-bitrate source to dynamically serve both Smooth Streaming and HLS clients. This feature, called dynamic packaging, avoids the need for you (or for Windows Azure) to duplicate storage for every streaming-format type (for example, MP4 for HTML5; Smooth Streaming for Silverlight, XBox, and Flash; and MPEG2-TS (MPEG 2 Transport Stream, also called M2TS) for HLS to iOS devices). As a result, you only need to store and pay for the files in one storage format. For more information, see [Walkthrough: Dynamically Packaging Assets](https://msdn.microsoft.com/en-us/library/windowsazure/jj889436.aspx).

<a id="Toc343780166"></a>
#### A note on MPEG-DASH

[MPEG-DASH](http://dashif.org/mpeg-dash/) (MPEG Dynamic Adaptive Streaming over HTTP) is a standard for dynamic adaptive bit-rate HTTP streaming that will be fully supported in Windows Azure Media Services. Support will also be added to the Microsoft Media Platform Smooth Streaming client development kits. For more details, see [Microsoft Announces Support for MPEG-DASH in Microsoft Media Platform](https://blogs.msdn.com/b/msmediaplatform/archive/2012/04/16/microsoft-announces-support-for-mpeg-dash-in-microsoft-media-platform.aspx) .

The adoption of MPEG-DASH will greatly reduce (and hopefully eliminate) the need for re-encoding between competing video formats. After it is fully supported in Windows Azure Media Services, MPEG-DASH will become Microsoft's preferred format for HTTP streaming.

If you currently stream using Windows Azure Media Services using multi-bitrate ISO Base Media or Smooth Streaming formats, you will not need to repackage or re-encode your video to MPEG-DASH. Windows Azure Media Services will do this for you dynamically. For this reason, Microsoft recommends that when choosing to encode, you use either the Smooth Streaming or multi-bitrate ISO Base Media format.


<a id="Toc343780167"></a>
## 7 The Advantages of Migrating to Windows Azure Media Services

The current environment for video streaming is experiencing new challenges. The video portion of Internet traffic today is significant and growing rapidly, as is the number of internet connected TVs and mobile devices. In this environment, video providers and broadcasters are switching to IP as the medium of choice to reach this wide diversity of endpoints.

To address these challenges, Windows Azure Media Services is designed to become a one-stop platform for securely encoding, packaging, and delivering video content from Windows Azure or CDNs, thus offering the scalability and reach of the cloud.

Some of advantages of migrating to Windows Azure Media Services are:

- Windows Azure Media Services has the scalability and reliability of a cloud platform and can handle large bursts in demand for video applications.
- It is widely available for a global audience and can use third-party CDNs like [Akamai](http://www.akamai.com/), [Level3](http://www.level3.com/), or [Limelight](http://www.limelight.com/).
- Windows Azure Media Services has cloud-based versions of familiar Microsoft Media Platform and media partner technologies.
- As a Platform-as-a-Service (PaaS), Windows Azure Media Services is faster, cheaper, and lowers risk: 

    - PaaS is faster because there is less work for developers. End-to-end solutions benefit from a single platform that solves integration issues. As a result, applications can go from idea to availability more quickly.
    - PaaS is cheaper because it offers less administration and management overhead, and greater economies of scale: you pay only for what you use, and large capital outlays for media servers and network infrastructure can be replaced by the more efficient operating expenses of cloud computing.
    - PaaS lowers risk. Because the platform does more for you, there are fewer opportunities for error.
- Security Standards and Certifications: Windows Azure Media Services Security is working towards SOC2 (Service Organization Control 2) compliance and plans to complete a [CDSA](http://www.cdsaonline.org/) (Content Delivery and Security Association) certification process and an MPAA audit in 2013.

<a id="Toc343780168"></a>
### Windows Azure Media Services Usage Scenarios

Windows Azure Media Services have the flexibility and power to enable you to create whatever media services solution that you envision. Some key usage scenarios are:

- Creating an end-to-end workflow in the cloud. For example, a content management service can use Windows Azure Media Services to process on-demand Smooth Streaming video and distribute it to a variety of mobile and desktop clients.
- Developing hybrid workflows that incorporate pre-existing on-premises resources. For example, a video production house might upload its finished videos to Windows Azure Media Services for encoding into multiple formats, and then use the Windows Azure Media Services Origin Service and a third-party CDN to deliver video on demand.
- Choosing to utilize built-in Media Services components, or mixing and matching your own custom components or components from third parties. Individual Windows Azure Media Services components can be called via standard REST APIs for easy integration with external applications and services.

The following section provides a more detailed breakdown of the various Windows Azure Media Services components.

<a id="Toc343780169"></a>
### Principal Windows Azure Media Components

Windows Azure Media Services components, when put together, are designed to create a complete end-to-end workflow. Currently available components include Ingest, Encoding and Conversion, Content Protection, On-Demand Streaming, and client-side support for Ad Insertion. Forthcoming components are Live Streaming, Analytics, and Identity Management. These components are described in more detail below.

<a id="Toc343780170"></a>
#### Secure Media Ingest Service

The Windows Azure Media Services Ingest service uploads video via HTTPS into Windows Azure Blobs for processing or delivery. A few key points:

- When uploading high value content such as studio quality mezzanine files, you should pre-encrypt the files with AES 256 prior to upload. The [Media Services .NET SDK](https://nuget.org/packages/windowsazure.mediaservices) and Java SDK  support this pre-encryption, which is a best practice for compliant secure media workflows.
- For greater efficiency when uploading your videos, you can use a fast upload UDP technology such as the one from [Aspera](http://asperasoft.com/), which can be obtained through the [Azure Store](https://www.windowsazure.com/en-us/store/service/?name=aspera).
- If your solution requires support for bulk ingest, you can implement this using the [Media Services REST API](https://msdn.microsoft.com/en-us/library/windowsazure/jj853021.aspx), or the [.NET](https://msdn.microsoft.com/en-us/library/windowsazure/jj853021.aspx) or Java SDKs.

<a id="Toc343780171"></a>
#### Encoding and Conversion Service

Windows Azure Media services can encode to and convert a variety of video and audio formats. The functionality of the standalone Expression Encoder tool has been folded into Windows Azure Media Encoder, which will continue to be Microsoft's primary encoding offering.

Windows Azure Media Encoder:

- Encodes video to H.264 or VC-1, with 25+ presets available. For a complete list, see [Task Preset Strings for Windows Azure Media Encoder](https://msdn.microsoft.com/en-us/library/windowsazure/jj129582.aspx).
- Encodes audio to AAC-LC, HE-AAC, and WMA (Dolby DD+ is planned).
- Packages to the MP4, HLS, Smooth Streaming, and WMV formats.
- Enables you to process assets by using the [Media Services SDK for .NET](https://msdn.microsoft.com/en-us/library/windowsazure/jj129580.aspx) or the Java SDK.

<a id="Toc343780172"></a>
#### Content Protection

Content Protection is a feature of Windows Azure Media Services that provides encryption and digital rights management. Some of the features available or planned are:

- Encryption with [Windows Azure Media Encryptor](https://msdn.microsoft.com/en-us/library/windowsazure/hh973610.aspx)
- Protection for Smooth and DASH Streaming or Apple HLS sources
- Support for [PlayReady](https://www.microsoft.com/playready/overview/) DRM with MPEG Common Encryption (CENC)

Content protection solutions from partners like [BuyDRM](http://www.buydrm.com/), [EZDRM](http://www.ezdrm.com/), and [Civolution](http://www.civolution.com/) are also available for solutions with Windows Azure Media Services.

> [!NOTE]
> To use PlayReady, you currently need to provide your own PlayReady server or use one from a third party provider such as those mentioned.


<a id="Toc343780173"></a>
#### On Demand Streaming

Windows Azure Media Services offers an Origin Service that delivers Video on Demand.

The Origin Service is a managed adaptive bitrate streaming service that offers guaranteed bandwidth, auto recovery, high redundancy, and high availability. You can use the Origin Service in conjunction with third-party CDNs like [Level3](http://www.level3.com/) and [Akamai](http://www.akamai.com/) to provide wide availability and low latency.

The Origin Service offers dynamic packaging support of standard MP4 files into Smooth Streaming, MPEG-DASH, or HLS files. This means that a file in one format can be packaged on-the-fly and delivered in the other format. This eliminates the need to store two separate versions of the same file, greatly reducing storage and CPU costs.

> [!NOTE]
> The dynamic packaging feature does not apply to MPEG 2 Transport Stream (M2TS) files, or to encrypted files.


<a id="Toc343780174"></a>
#### Live Streaming

Live Streaming is a forthcoming feature of Windows Azure Media Services that will offer live ingest, live origin, and live encoding that will enable video to be streamed for live events.

Windows Azure Media Services Live Streaming was previewed with great success in the 2012 Olympics. Here are some highlights of its features:

- **One source, many clients**: using industry standard H.264 and AAC codecs, content was encoded once and delivered to all devices and platforms, including Silverlight, Flash, iOS, Android, and Windows Phone clients and devices.
- **Easy configuration and automation**: Live and on-demand channels were established and configured with a few lines of code. The creation of 140 live HD channels was automated. No manual setup or steps were required. For example, 120 channels were initially provisioned. When it became clear that 20 additional channels would be required, with a few clicks, the 20 channels were added and available within the space of 30 minutes.
- **Scalable, reliable, robust**: During the 2012 Olympics, Windows Azure Media Services provided a scalable mechanism that handled spikes and prioritization of high volume transcoding needs. A solution for an event like this would have been unachievable or too costly with traditional on-premise implementations or generic cloud compute services. Redundant ingest, origin, storage and edge caching services across multiple datacenters delivered a high availability solution that provided automated self-healing when issues arose.
- **Real-time monitoring**: The REST channel APIs provided by Windows Azure Media Services were used to build a web-based dashboard that allowed broadcasters to monitor the health and quality of the outbound flow of streams to CDNs.
- **Seamless transition between Live and Video On-demand**: Video was available immediately for replay both during and after a live broadcast with full DVR functionality. As an event ended in real time, a full video on-demand archive was created.
- **Microsoft Media Platform tools**: Microsoft provided rough cut editing tools for highlight reel creation. Within a couple of minutes of an event, these tools allowed highlight clips to be quickly assembled into highlight reels that could be streamed from the live chunks already cached at the CDN edge. There was no need to download or save the video assets locally.
- **Automated conversion of content**: Using the VOD Services SDK, several custom media processing tools were created for the automatic conversion of content to various formats that could be served to a wide variety of devices and online services.

For more information about how Live Streaming was implemented in the 2012 Olympics, see [Windows Azure Media Services and the London 2012 Olympics](https://weblogs.asp.net/scottgu/archive/2012/08/21/windows-azure-media-services-and-the-london-2012-olympics.aspx).

During the calendar year 2013, the above Live Streaming capabilities are to be gradually added to Windows Azure Media Services, becoming available for general consumption as they are released.

Currently, you can live stream using IIS Media Services 4.1, or use the facilities of third party providers. A new version of IIS Media Services is planned but has not yet been released.

<a id="Toc343780175"></a>
#### Advertising (Ad Insertion)

Ad Insertion is currently available in client SDKs, with support for the [VMAP](http://en.wikipedia.org/wiki/VMAP) and [VPAID](http://www.iab.net/iab_products_and_industry_services/508676/compliance/679310) standards in clients using [MMPPF](http://smf.codeplex.com/), [PlayerFramework](http://playerframework.codeplex.com/), [OSMF AD plugins](http://www.osmf.org/partner.php) and the [Windows Azure Player Framework for iOS](https://github.com/WindowsAzure/azure-media-player-framework).

On the server side, ad integration features are forthcoming.

<a id="Toc343780176"></a>
#### Analytics and Identity Management

Analyticsand Identity Management are forthcoming features of Windows Azure Media Services.

- Analytics refers to tracking the penetration and usage of video content. Real-time analytics are planned.
- [Identity Management](https://www.windowsazure.com/en-us/home/features/identity/) already exists in Windows Azure but will be extended to Media Services to provide access control for your applications.

<a id="Toc343780177"></a>
### Windows Azure Media Services Pricing

Windows Azure Media Services charges for storage, compute cycles, and egress of data (that is, to download the content or serve it). There is no charge for uploading content to Azure unless you are using a third-party fast transfer tool such as the one from Aspera. The compute cycles relate mostly to encoding. Regular Windows Azure Storage costs apply to storage.

Preliminary summary information about how Encoding and On-Demand services will be charged is provided below. For up-to-date, detailed pricing information for Windows Azure and Windows Azure Media Services, see [Windows Azure Pricing Details](https://www.windowsazure.com/en-us/pricing/details/).

Depending on your scenario, the total cost of serving your content through Windows Azure Media Services can be significantly less than that of streaming from your own in-house infrastructure.

<a id="Toc343780178"></a>
#### Encoding

Encoding is charged by the total number of gigabytes input to and output from the encoder per billing-cycle month. (The total of gigabytes processed is the data input to the encoder, plus the data output from the encoder.) Both input and output data are stored in your Media Services storage account, for which the standard Windows Azure Storage and Data Transfer charges apply.

To ensure that specified number of encoding tasks can run concurrently, you can purchase one or more encoding reserve units (RUs). One reserve unit can run one task at a time. A typical number of encoding reserve units is from 1 to 5. A reserve unit is also the primary unit of SLA (Service Level Agreement). If you do not purchase reserve units, the level of service that you receive cannot be guaranteed.

More details are available on the [pricing page](https://www.windowsazure.com/en-us/pricing/details/).

<a id="Toc343780179"></a>
#### On-Demand Streaming

Once On-Demand Streaming becomes generally available, you will need to purchase reserved units to use the service. On-Demand Streaming will be billed based on the number of reserved units in use calculated on a daily basis using the highest number of reserved units that were active in the account in the corresponding 24-hour period. The allocated bandwidth per On-Demand Reserved Unit is 200 Mbps. More details are available on the [pricing page](https://www.windowsazure.com/en-us/pricing/details/).

<a id="Toc343780180"></a>
### Scenarios still appropriate for earlier Media Services versions

In some scenarios, Windows Azure Media Services might not be the best choice. For example, this might be the case if multicasting is a requirement, if heavy traffic or the need for scalability is not a concern, or if a Windows Azure Media Services component that you require has not yet been released. Note, however, that in many cases third parties can supply components for Windows Azure Media Services that have not yet been made public.

<a id="Toc343780181"></a>
### Alternate or Hybrid Solutions

You might think that an interim approach to streaming from Windows Azure would be to host IIS Media Services in an Azure Web Role. Although this might make moving an existing IIS Media Services solution to the cloud seem more straightforward, it has the following drawbacks:

- Because Web Role VMs are not persistent, you would have to store state and session data on an Azure Drive via [Windows Azure Storage Services](https://msdn.microsoft.com/en-us/library/windowsazure/ee924681.aspx).
- Live streams would not be archived; you would have to implement this functionality yourself. Windows Azure Media Services Live Streaming, when available, will do this for you automatically.

If your existing on-premises infrastructure is sufficient for most cases but is occasionally overwhelmed by 'bursty' traffic or events, you might consider offloading the extra traffic onto a CDN such as those offered by [Akamai](http://www.akamai.com/), [Level3](http://www.level3.com/), or [Limelight](http://www.limelight.com/).

<a id="Toc343780182"></a>
### Programming Windows Azure Media Services

<a id="Toc343780183"></a>
#### REST APIs

All of Windows Azure Media Services is accessible through REST APIs, which are built on [OData 3.0](http://www.odata.org/documentation/overview) . Because it uses HTTP, the APIs will work with any platform and any device. You can program the REST APIs directly or through the .NET or Java SDKs.

The .NET and Java SDKs conveniently wrap the REST APIs to make coding your solutions easier. For more information, see [Building Applications with the Media Services SDK for .NET](https://msdn.microsoft.com/en-us/library/hh973613.aspx). To download the .NET SDK for Windows Azure Media Services, see [Windows Azure Media Services .NET SDK (Preview)](https://nuget.org/packages/windowsazure.mediaservices).

To make direct REST API calls rather than using an SDK, or to use programming languages outside of the .NET Framework, use the Media Services REST API. For more information, see [Building Applications with the Windows Azure Media Services REST API](https://msdn.microsoft.com/en-us/library/hh973618).

<a id="Toc343780184"></a>
#### Smooth Streaming Client SDKs

Smooth Streaming Client SDKS are available for a wide variety of platforms, including [Windows 8](https://visualstudiogallery.msdn.microsoft.com/04423d13-3b3e-4741-a01c-1ae29e84fea6?SRC=Home), [Silverlight](https://www.microsoft.com/en-us/download/details.aspx?id=29940), [Windows Phone](https://www.iis.net/downloads/microsoft/smooth-streaming), iOS, and Android. Some are available from third parties. For more information, see [Media Services Client Development](https://social.msdn.microsoft.com/Forums/en-US/MediaServices/thread/e9092ec6-2dfc-44cb-adce-1dc935309d2a).

<a id="Toc343780185"></a>
#### Media Platform Player Framework

The Microsoft Media Platform Player Framework is a fully open source video player for Silverlight, HTML5, Windows Phone, Xbox, and Windows 8 applications. For more information, see [Microsoft Media Platform Player Framework](http://playerframework.codeplex.com/).

<a id="Toc343780186"></a>
#### Xbox LIVE Application Development Kit (ADK)

The Xbox LIVE Application Development Kit (ADK), available to [Xbox Partners](http://www.xbox.com/en-US/live/partners), can be used to create applications that consume media content from Windows Azure Media Services and IIS Media Services. The ADK includes the Smooth Streaming Client for Xbox LIVE ADK, and the Microsoft Media Platform Player Framework for Xbox LIVE ADK.


<a id="Toc343780187"></a>
## 8 Resources

Aspera Platform on Demand (Windows Azure Store): [https://www.windowsazure.com/en-us/store/service/?name=aspera](https://www.windowsazure.com/en-us/store/service/?name=aspera)

Building Applications with the Media Services SDK for .NET: [https://msdn.microsoft.com/en-us/library/hh973613.aspx](https://msdn.microsoft.com/en-us/library/hh973613.aspx)

Building Applications with the Windows Azure Media Services REST API: [https://msdn.microsoft.com/en-us/library/windowsazure/hh973618.aspx](https://msdn.microsoft.com/en-us/library/windowsazure/hh973618.aspx))

Configuring the Transform Manager Service: [https://technet.microsoft.com/en-us/library/ff730170(v=WS.10).aspx](https://technet.microsoft.com/en-us/library/ff730170(v=WS.10).aspx)

Content Delivery &amp; Security Association (CDSA): [http://www.cdsaonline.org/](http://www.cdsaonline.org/)

Delivering content as a multicast stream: [https://technet.microsoft.com/library/cc754435.aspx](https://technet.microsoft.com/library/cc754435.aspx)

Digital Video Player-Ad Interface Definitions (VPAID) Compliance: [http://www.iab.net/iab\_products\_and\_industry\_services/508676/compliance/679310](http://www.iab.net/iab_products_and_industry_services/508676/compliance/679310)

Expression Encoder: [http://expression.microsoft.com/en-us/cc136533](http://expression.microsoft.com/en-us/cc136533)

Expression Encoder 4 with Service Pack 2: [https://www.microsoft.com/en-us/download/details.aspx?id=27870](https://www.microsoft.com/en-us/download/details.aspx?id=27870)

Expression Encoder Pro: [https://go.microsoft.com/fwlink/?LinkID=149601](https://go.microsoft.com/fwlink/?LinkID=149601)

IIS Media Services 4.1: [https://www.iis.net/media](https://www.iis.net/media)

IIS Smooth Streaming Technical Overview: [https://download.microsoft.com/download/4/2/4/4247C3AA-7105-4764-A8F9-321CB6C765EB/IIS\_Smooth\_Streaming\_Technical\_Overview.pdf](https://download.microsoft.com/download/4/2/4/4247C3AA-7105-4764-A8F9-321CB6C765EB/IIS_Smooth_Streaming_Technical_Overview.pdf)

Ingest Assets with the Media Services REST API: [https://msdn.microsoft.com/en-us/library/windowsazure/jj129593.aspx](https://msdn.microsoft.com/en-us/library/windowsazure/jj129593.aspx)

Ingesting Assets in Bulk (Windows Azure Media Services SDK): [https://msdn.microsoft.com/en-us/library/windowsazure/jj853022.aspx](https://msdn.microsoft.com/en-us/library/windowsazure/jj853022.aspx)

Ingesting Assets in Bulk with the REST API: [https://msdn.microsoft.com/en-us/library/windowsazure/jj853021.aspx](https://msdn.microsoft.com/en-us/library/windowsazure/jj853021.aspx)

Media Services Client Development: [https://social.msdn.microsoft.com/Forums/en-US/MediaServices/thread/e9092ec6-2dfc-44cb-adce-1dc935309d2a](https://social.msdn.microsoft.com/Forums/en-US/MediaServices/thread/e9092ec6-2dfc-44cb-adce-1dc935309d2a)

Microsoft Announces Support for MPEG-DASH in Microsoft Media Platform: [https://blogs.msdn.com/b/msmediaplatform/archive/2012/04/16/microsoft-announces-support-for-mpeg-dash-in-microsoft-media-platform.aspx](https://blogs.msdn.com/b/msmediaplatform/archive/2012/04/16/microsoft-announces-support-for-mpeg-dash-in-microsoft-media-platform.aspx)

Microsoft Media Platform: [https://www.microsoft.com/en-us/mediaplatform/](https://www.microsoft.com/en-us/mediaplatform/)

Microsoft Media Platform Player Framework: [http://playerframework.codeplex.com/](http://playerframework.codeplex.com/)

Microsoft PlayReady DRM: [https://www.microsoft.com/playready/overview/](https://www.microsoft.com/playready/overview/)

Microsoft Silverlight: [https://www.microsoft.com/silverlight/](https://www.microsoft.com/silverlight/)

Microsoft Smooth Streaming Client 2.0 RTW (for Silverlight and Windows Phone): [https://www.microsoft.com/en-us/download/details.aspx?id=29940](https://www.microsoft.com/en-us/download/details.aspx?id=29940)

Microsoft Smooth Streaming Client SDK for Windows 8: [https://visualstudiogallery.msdn.microsoft.com/04423d13-3b3e-4741-a01c-1ae29e84fea6?SRC=Home](https://visualstudiogallery.msdn.microsoft.com/04423d13-3b3e-4741-a01c-1ae29e84fea6?SRC=Home)

Microsoft Smooth Streaming Plugin for OSMF (Preview): [https://www.microsoft.com/en-us/download/details.aspx?id=36057](https://www.microsoft.com/en-us/download/details.aspx?id=36057)

Open Data Protocol (OData): [http://www.odata.org/documentation/overview](http://www.odata.org/documentation/overview)

OSMF Advertising Plugins: [http://www.osmf.org/partner.php](http://www.osmf.org/partner.php)

Overview of MPEG-DASH Standard: [http://dashif.org/mpeg-dash/](http://dashif.org/mpeg-dash/)

Player Framework for Windows 8: [http://playerframework.codeplex.com/](http://playerframework.codeplex.com/)

Process Assets with the Media Services SDK for .NET: [https://msdn.microsoft.com/en-us/library/windowsazure/jj129580.aspx](https://msdn.microsoft.com/en-us/library/windowsazure/jj129580.aspx)

Sourcing from a multicast broadcast using Windows Media Services: [https://blogs.iis.net/chriskno/archive/2008/07/14/sourcing-from-a-multicast-broadcast-using-windows-media-services.aspx](https://blogs.iis.net/chriskno/archive/2008/07/14/sourcing-from-a-multicast-broadcast-using-windows-media-services.aspx)

Task Preset for Windows Azure Media Encryptor: [https://msdn.microsoft.com/en-us/library/windowsazure/hh973610.aspx](https://msdn.microsoft.com/en-us/library/windowsazure/hh973610.aspx)

Task Preset Strings for Windows Azure Media Encoder: [https://msdn.microsoft.com/en-us/library/windowsazure/jj129582.aspx](https://msdn.microsoft.com/en-us/library/windowsazure/jj129582.aspx)

Transform Manager: [https://www.iis.net/downloads/microsoft/transform-manager](https://www.iis.net/downloads/microsoft/transform-manager)

Transform Manager 1.1 download: [https://www.microsoft.com/en-us/download/details.aspx?id=29890](https://www.microsoft.com/en-us/download/details.aspx?id=29890)

Unifying Global Video Strategies: MP4 File Fragmentation for Broadcast, Mobile and Web Delivery (white paper): [http://184.168.176.117/reports-public/Adobe/20111116-fMP4-Adobe-Microsoft.pdf](http://184.168.176.117/reports-public/Adobe/20111116-fMP4-Adobe-Microsoft.pdf)

Using the Windows Azure Storage Services: [https://msdn.microsoft.com/en-us/library/windowsazure/ee924681.aspx](https://msdn.microsoft.com/en-us/library/windowsazure/ee924681.aspx)

Windows Azure Identity: [https://www.windowsazure.com/en-us/home/features/identity/](https://www.windowsazure.com/en-us/home/features/identity/)

Windows Azure Media Player Framework for iOS: [https://github.com/WindowsAzure/azure-media-player-framework](https://github.com/WindowsAzure/azure-media-player-framework)

Windows Azure Media Services: [https://www.windowsazure.com/en-us/home/scenarios/media/](https://www.windowsazure.com/en-us/home/scenarios/media/)

Windows Azure Media Services .NET SDK: [https://nuget.org/packages/windowsazure.mediaservices](https://nuget.org/packages/windowsazure.mediaservices)

Windows Azure Media Services (MSDN): [https://msdn.microsoft.com/en-us/library/hh973629](https://msdn.microsoft.com/en-us/library/hh973629)

Windows Azure Media Services and the London 2012 Olympics: [https://weblogs.asp.net/scottgu/archive/2012/08/21/windows-azure-media-services-and-the-london-2012-olympics.aspx](https://weblogs.asp.net/scottgu/archive/2012/08/21/windows-azure-media-services-and-the-london-2012-olympics.aspx)

Windows Azure: Microsoft's Cloud Platform: [https://www.windowsazure.com](https://www.windowsazure.com)

Windows Azure Pricing Details: [https://www.windowsazure.com/en-us/pricing/details/](https://www.windowsazure.com/en-us/pricing/details/)

Windows Azure Store: [https://www.windowsazure.com/en-us/store/overview/](https://www.windowsazure.com/en-us/store/overview/)

Windows Media Services: [https://www.microsoft.com/windows/windowsmedia/forpros/server/server.aspx](https://www.microsoft.com/windows/windowsmedia/forpros/server/server.aspx)

Windows Media Services for Windows Server 2008: [https://www.microsoft.com/en-us/download/details.aspx?id=12442](https://www.microsoft.com/en-us/download/details.aspx?id=12442)

Windows Media Services for Windows Server 2008 R2: [https://www.iis.net/downloads/microsoft/windows-media-services](https://www.iis.net/downloads/microsoft/windows-media-services)