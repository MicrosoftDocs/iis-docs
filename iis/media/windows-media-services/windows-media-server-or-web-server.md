---
title: "Windows Media Server or Web Server? | Microsoft Docs"
author: rick-anderson
description: "You can deliver digital media audio and video files and live streams either from a Windows Media server (a server that is running Windows Media Services) or..."
ms.author: iiscontent
manager: soshir
ms.date: 05/15/2008
ms.topic: article
ms.assetid: 
ms.technology: iis-media
ms.prod: iis
msc.legacyurl: /learn/media/windows-media-services/windows-media-server-or-web-server
msc.type: authoredcontent
---
Windows Media Server or Web Server?
====================
by Dave Nelson

You can deliver digital media audio and video files and live streams either from a [Windows Media server](http://technet2.microsoft.com/windowsserver2008/en/servermanager/streamingmediaservices.mspx) (a server that is running Windows Media Services) or from a [Web server](http://technet2.microsoft.com/windowsserver2008/en/servermanager/webserver.mspx) (a server that is running Internet Information Services (IIS)). Clients use different methods to receive digital media content from Windows Media servers and Web servers: they stream digital media from a Windows Media server and download digital media from a Web server.

With the broader availability of high-bandwidth networks and new media delivery features for IIS 7 and above, the differences that previously favored the use of a Windows Media server over a Web server for delivering digital media content have blurred. In non-multicast streaming scenarios, depending upon your business need, a Windows Media server or a Web server can both be viable options for digital media content delivery today.

This article introduces the delivery methods and bandwidth-management capabilities of Windows Media servers and Web servers, two important aspects of media delivery to consider when you are trying to decide which server type to deploy for your delivery scenario.

## Introducing Windows Media servers and Web servers

This section introduces the two primary Windows Server roles that are used to deliver digital media to clients:

- [Windows Media servers](windows-media-server-or-web-server.md#media)
- [Web servers](windows-media-server-or-web-server.md#web)

<a id="media"></a>

### Windows Media servers

A Windows Media server is designed specifically for streaming on-demand and live digital media to clients. It provides high-quality streaming over a wide range of bandwidths to [Windows Media Player](https://www.microsoft.com/windows/windowsmedia/player/default.aspx) and to Web browsers that use the Windows Media Player 9 Series ActiveX control or the [Microsoft Silverlight](https://www.microsoft.com/silverlight) browser plug-in. It is especially useful for streaming large amounts of data over busy, congested networks and low-bandwidth connections. Streaming uses bandwidth more efficiently than downloading because it sends data over the network only at the speed that is necessary for the client to render it correctly. This helps prevent the network from becoming overloaded and helps maintain system reliability.

Users that connect to a stream can start to play it almost immediately. If streaming on-demand content was indexed during encoding, they can use Seek functions (Fast-Forward and Rewind) on their player to jump to any part of the stream without waiting for a download to finish. Streaming prevents users from downloading files directly to their hard disk because the streaming data packets are delivered directly to the client application and discarded by the client application after they are rendered.

A Windows Media server supports delivery of a limited number of popular digital media file formats, including Windows Media Audio (WMA), Windows Media Video (WMV), and MP3. It also supports the use of JPEG files as media elements in server-side playlists or as banner graphics to be displayed in Windows Media Player.

<a id="web"></a>

### Web servers

A Web server is designed to host Web sites and serve the Web site's pages and files to clients upon request. When a client requests a file from a standard Web server, all available network bandwidth is used to download the data to the client as quickly as possible. Web server deployments that serve small files to a limited number of users simultaneously require little bandwidth. But as delivery of audio and video files (which are frequently large) has increased, and as sites must serve greater numbers of simultaneous client requests, more bandwidth is required to fulfill the client requests in a timely manner.

A Web server supports delivery of an unlimited number of popular digital media file formats using standard file-download. If the IIS Media Services Smooth Streaming extensions are installed on a Web server running IIS, delivery of on-demand and live streams in the MP4 container format is also supported.

<a id="delivery"></a>

## Streaming vs. Downloading

This section compares the content delivery methods for Windows Media servers and Web servers:

- [Streaming](windows-media-server-or-web-server.md#stream)
- [Downloading](windows-media-server-or-web-server.md#download)

<a id="stream"></a>

### Streaming

User Datagram Protocol (UDP) has long been the preferred transport protocol for traditional streaming media. It is a fast, lightweight protocol without any retransmission or data-rate management functionality, making it an ideal protocol for transmitting real-time audio and video data, which can tolerate some lost packets. UDP also has higher priority than Transmission Control Protocol (TCP)-based HTTP for Internet traffic, giving streaming audio and video data higher priority over file and Web page transfers and increasing the likelihood of uninterrupted viewing on congested networks. A Windows Media server also uses UDP Resend, an intelligent UDP-retransmission scheme that ensures that it only retransmits lost packets that can be sent to a player in time to be played, instead of the blind retransmission scheme employed by TCP. This smart-resend feature conserves additional bandwidth on congested networks.

A Windows Media server may stream digital media by using the Real Time Streaming Protocol (RTSP) with UDP-based transport (RTSPT) to take advantage of UDP-based streaming efficiencies. On networks that don't support UDP, the server is normally configured to use a process called [protocol rollover](http://technet2.microsoft.com/windowsserver2008/en/library/82fb84a9-96f5-49dc-92d2-cf76c912aab81033.mspx?mfr=true) to try TCP-based streaming, first by using RTSP, and if that doesn't work, it uses its own version of HTTP for firewalls that allow Web traffic through port 80. This enables corporate users to view Internet content without compromising firewall security and ensures that all users on all networks can access all streaming media content. For more information about the streaming protocols that are used by Windows Media Services, see [Comparing HTTP Streaming Protocol with RTSP](https://msdn.microsoft.com/en-us/library/bb905764.aspx).

As network bandwidths increase, the use of TCP is becoming more common. Because TCP guarantees delivery of every packet, it is preferred for video-on-demand delivery, especially if end users are paying for the content through a pay-per-view or subscription billing model.

<a id="download"></a>

### Downloading

The bandwidth-management capabilities that are present in a Windows Media server are lacking in a standard Web server. When a client requests digital media from a Web server, the Web server downloads the content to the client as fast as the network will allow without monitoring the quality of the delivery and adjusting the bit rate for the client in the way that a Windows Media server does. A client can start to play the content as soon as enough data is downloaded to its Internet cache (this is referred to as *progressive downloading*); however, in bandwidth-constrained systems, simultaneous requests from multiple clients can quickly saturate the available network bandwidth and clients must buffer more data to the cache before starting or resuming playback.

Downloading also uses the available bandwidth less efficiently than streaming. Web server content delivery uses HTTP, the standard Web protocol that is used by all Web servers and Web browsers for communication between the server and the client. HTTP operates on top of the TCP transport protocol, which handles all data transfers. TCP is optimized for non-real-time applications such as file transfer and remote log-in; therefore, it maximizes data transfer rates while ensuring overall stability and high throughput for the whole network. TCP achieves reliable data transfer by re-transmitting all lost packets, but it can't ensure that all resent packets will arrive at the client in time to be played, and so sometimes wastes bandwidth.

With IIS, you have a choice. You can use standard progressive downloads, with the limitations mentioned above, or you can use a new IIS feature called [Bit Rate Throttling](windows-media-server-or-web-server.md#brt), described below, which provides some of the benefits of traditional streaming to almost any type of media file.

<a id="wms"></a>

## Windows Media Services

With its built-in bandwidth-management capabilities, a Windows Media server is an ideal way to deliver digital media content to large numbers of concurrent users using traditional streaming.

A Windows Media server sends data at the same bit rate as the content, leaving more bandwidth available for servicing concurrent client requests for content and resulting in better quality audio and video for connected clients. There is typically a delay between the time the stream is received by a player and the point at which it starts to play because the player must first buffer some data in case there are delays or gaps in the stream. This buffer allows the media to continue playing uninterrupted, even during periods of high network congestion. Because data streaming and rendering occurs almost simultaneously, streaming also enables you to deliver live content. Windows Media Services contains many additional features that are used to optimize network throughput. This section describes two of the most important: Intelligent streaming and Fast Streaming.

<a id="intelligent"></a>

### Intelligent streaming

The most difficult task of streaming audio and video over a network is maintaining a continuous presentation to the user in a highly changeable environment. Buffering is the biggest problem of streaming digital media. It is caused when the client runs out of data in memory (the buffer) and must wait for more to arrive. The client will always run out of data if the bit rate of the incoming stream exceeds the current available bandwidth.

Unpredictability of bandwidth is taken for granted on the Internet. The actual bandwidth at any given point is determined by network conditions and traffic, which are constantly fluctuating. To ensure a continuous presentation during traditional streaming delivery, Windows Media technologies use [intelligent streaming](https://technet.microsoft.com/en-us/library/cc732815.aspx), which adjusts the bit rate of the content stream to counteract changes in available bandwidth. When a client first connects to a stream, intelligent streaming ensures that the client receives content at the bit rate that is most appropriate for the current bandwidth. As the stream plays, intelligent streaming is designed to dynamically and seamlessly adjust the bit rate of the streaming content as the available bandwidth changes.

Intelligent streaming progresses through a series of strategies to modify the bit rate of the stream so that it plays continuously on the client regardless of the current bandwidth. As bandwidth fluctuates between server and client, the server detects the changes and adopts the best strategy. The strategies are as follows:

1. The server and client automatically determine the current available bandwidth, and then the server selects and delivers the stream with the most appropriate bit rate. This requires that the content be encoded as a multiple-bit-rate (MBR) stream.
2. During transmission, if the bandwidth decreases, the server automatically detects the change and switches to a stream with a lower bit rate. If bandwidth improves, the server switches to a stream with a higher bit rate, but never higher than the original bit rate. The process of selecting the appropriate stream is transparent to the user.
3. If the bandwidth can no longer support streaming video, the client and server intelligently degrade image quality to avoid buffering. This method of decreasing the bit rate to accommodate the current bandwidth is called stream thinning. The server decreases the video frame rate first. If the bit rate is still too high, the server stops sending video frames.
4. After the server stops sending video frames, it uses intelligent streaming to try to maintain a continuous audio stream. If audio quality starts to degrade, the client reconstructs parts of the stream to preserve quality.

When bandwidth is at its best, the server uses the first strategy. As conditions worsen, the server tries each strategy in the previous list of options in succession until the bit rate is optimized for the current bandwidth.

A newer and improved form of intelligent streaming for delivery of media from Web servers is also available using IIS. See the [Smooth Streaming](windows-media-server-or-web-server.md#ss) section of this article for more information.

<a id="fast"></a>

### Fast Streaming

[Fast Streaming](https://technet.microsoft.com/en-us/library/cc731688.aspx) refers to a group of features in Windows Media Services that improve the quality of streaming media content for the user. These features allow for a combination of streaming, downloading, and caching to provide the best user experience:

- **Fast Cache**. Enables Windows Media Services to use any additional bandwidth to send additional data to the player buffer, allowing the player to better withstand network bandwidth fluctuations.
- **Fast Start**. Enables the beginning part of the content to be quickly downloaded to a player at the maximum available bandwidth, reducing the time required to fill the player's buffer requirement and the amount of time a user has to wait (also known as *latency*) before starting to receive the stream.
- **Fast Recovery**. Enables the server to provide an uninterrupted viewing experience to users receiving content over high latency network connections, such as wireless and satellite networks, by using forward error correction to greatly reduce packet corruption and interruption.
- **Fast Reconnect**. Enables the server to automatically restore client connections—including encoders, distribution servers, and players—that are lost during a broadcast because of network conditions.
- **Advanced Fast Start**. Adds to Fast Start capabilities by allowing the player to start to play content as soon as its buffer receives a minimum amount of data, further reducing the amount of latency before the user starts to receive the stream.

<a id="iis"></a>

## IIS Media Services

IIS Media Services extensions are designed to add media delivery capabilities to a Web server that is running [Internet Information Services (IIS) 7](http://technet2.microsoft.com/windowsserver2008/en/servermanager/webserver.mspx). The IIS Media Services extensions take advantage of the broader market availability of high-bandwidth networks, which make a Web server an increasingly practical option for digital media content delivery. This section describes the following streaming and bandwidth management extensions that are available in IIS Media Services:

- [Smooth Streaming](windows-media-server-or-web-server.md#ss)
- [Bit Rate Throttling](windows-media-server-or-web-server.md#brt)

IIS Media Services includes additional extensions that add Windows Media Services-like capabilitres, such as server-side playlists and rich client logging, to Web servers running IIS. For more information about these extensions, and additional extensions that may be developed to enhance delivery of digital media content from Web servers, see the [IIS Media Services Web site](https://www.iis.net/media).

<a id="ss"></a>

### Smooth Streaming

Smooth Streaming is the Microsoft implementation of adaptive streaming technology, which is a form of Web-based media content delivery that uses standard HTTP. Instead of delivering media as full-file downloads, or as persistent (and thus stateful) streams, the content is delivered to clients as a series of MPEG-4 (MP4) fragments that can be cached at edge servers. Smooth Streaming-compatible clients use special heuristics to dynamically monitor current network and local PC conditions and seamlessly switch the video quality of the Smooth Streaming presentation that they receive. As clients play the fragments, network conditions may change (for example, bandwidth may decrease) or video processing may be impacted by other applications that are running. Clients can immediately request that the next fragment come from a stream that is encoded at a different bit rate to accommodate the changing conditions. This enables clients to play the media without stuttering, buffering, or freezing. As a result, users experience the highest-quality playback available, with no interruptions in the stream.

Smooth Streaming provides media companies with a better way to make full-HD (1080p) streaming on the Web a reality. It offers code-free deployment and simplified content management for content creators and content delivery networks. For users, the improved viewing experience brings the reliability and quality of television to their favorite video Web sites.

As a content producer, you can encode live and on-demand Smooth Streaming video using [Microsoft® Expression® Encoder 4](https://www.microsoft.com/expression/products/EncoderPro_Overview.aspx). As a content provider, you can use IIS Media Services to serve the encoded Smooth Streams. And as a content consumer, you can play the Smooth Streams using a Smooth Streaming-compatible client, such as Microsoft® Silverlight™.

**For more information**

- [Smooth Streaming Technical Overview](../on-demand-smooth-streaming/smooth-streaming-technical-overview.md). Provides a comprehensive history, context, introduction, and technical description of Smooth Streaming.
- [Smooth Streaming Deployment Guide](../smooth-streaming/smooth-streaming-deployment-guide.md). Describes the Microsoft implementation for delivering a full Smooth Streaming experience.
- [Experience Smooth Streaming](https://www.iis.net/media/experiencesmoothstreaming). Go to this Web page to use a Silverlight browser plug-in to simulate different bandwidths and see Smooth Streaming in action.

<a id="brt"></a>

### Bit Rate Throttling

If you are concerned about the overall bandwidth limitations of your Web server system, instead of switching your network computers to a new streaming distribution system, you may be able to use the Bit Rate Throttling extension, which offers similar bandwidth-management and client-connection capabilities to those in Windows Media Services. Unlike Windows Media Services, you can use Bit Rate Throttling to intelligently deliver any media file type, not just Windows Media files. (Even better, Bit Rate Throttling can be used to deliver *any* file type in a controlled manner, not just media files.)

You can configure Bit Rate Throttling to send an initial burst of data to a client's cache (similar to the Fast Start capability of Windows Media Services that reduces latency) so that the client application can start to play the file by using progressive download, and then configure the rate at which the remaining data is downloaded to the client. Typically, this throttle rate is slightly greater than the encoded bit rate of the file, so that the client renders the throttled data as it is downloaded (similar to a streaming experience). When multiple clients request data from the Web server, they consume the data at the throttled rate, instead of all at once. This frees additional bandwidth for servicing additional client requests.

On standard Web server networks that have lots of available bandwidth, a complete file can be downloaded to a user's Internet cache in just a few seconds, provided it isn't exceptionally large, and content providers can incur costs related to unused bandwidth if users stop playing the downloaded file after a short time. By throttling the content download rate so that clients receive just enough content to render it, content providers don't incur costs related to the bandwidth that is wasted in the unviewed parts of downloaded files.

The Bit Rate Throttling extension offers advanced settings that allow you more control of the cumulative network throughput from your Web server. For example, you can specify global default and maximum throttle rates for all digital media files (regardless of their encoded bit rates) and specify a total bit rate throughput limit for a site so that the available bandwidth is dynamically allocated to connected clients. The Bit Rate Throttling extension also offers a useful secondary feature that throttles data file types at specified bit rates.

For more information, see [Bit Rate Throttling](https://www.iis.net/downloads/microsoft/bit-rate-throttling).

<a id="checklist"></a>

## Feature checklist

A Windows Media server is designed to handle the special requirements of streaming and administering Windows Media-based content. However, a Web server can be a practical option for delivering digital media content, especially by installing IIS Media Services extensions for IIS that bring Windows Media server capabilities to the Web server.

Windows Media Services 2008 and IIS have additional features that are not described in this article that might affect your choice for delivering digital media. For example, Windows Media Services is the only server role that can be used for multicast delivery of content on enterprise networks. Before you make a final decision about which server role to deploy to facilitate your business model, review the features for each server role in the following table.

![](windows-media-server-or-web-server/_static/image1.gif)= This feature or function is supported.

![](windows-media-server-or-web-server/_static/image2.gif)= This feature or function is supported on a Web Server running IIS if the referenced extension is installed. The implementation on the Web server may differ from the Windows Media server.

![](windows-media-server-or-web-server/_static/image3.gif)= This feature or function is not supported.


| **Windows Server 2008 Feature** | **Windows Media Services 2008** | **Internet Information Services** |
| --- | --- | --- |
| Optimized for streaming [Windows Media-based content](https://www.microsoft.com/windows/windowsmedia/forpros/prosolutions.mspx) | [![](windows-media-server-or-web-server/_static/image5.gif)](windows-media-server-or-web-server/_static/image4.gif) | **1![](windows-media-server-or-web-server/_static/image6.gif)** |
| Delivers content through most [firewalls](https://www.microsoft.com/technet/security/guidance/networksecurity/firewall.mspx) | ![](windows-media-server-or-web-server/_static/image7.gif) | ![](windows-media-server-or-web-server/_static/image8.gif) |
| Streams without downloading | ![](windows-media-server-or-web-server/_static/image9.gif) | ![](windows-media-server-or-web-server/_static/image10.gif) |
| Broadcasts live content | ![](windows-media-server-or-web-server/_static/image11.gif) | **2![](windows-media-server-or-web-server/_static/image12.gif)** |
| Delivers content using [multicast streaming](http://technet2.microsoft.com/windowsserver2008/en/library/0e5fa6c2-72ad-4337-8c85-e0fe5e85f8e41033.mspx?mfr=true) | ![](windows-media-server-or-web-server/_static/image13.gif) | **3![](windows-media-server-or-web-server/_static/image14.gif)** |
| Supports trick mode playback of on-demand files | ![](windows-media-server-or-web-server/_static/image15.gif) | **4![](windows-media-server-or-web-server/_static/image16.gif)** |
| Delivers content protected with [Digital Rights Management](https://www.microsoft.com/windows/windowsmedia/forpros/drm/default.mspx) | ![](windows-media-server-or-web-server/_static/image17.gif) | ![](windows-media-server-or-web-server/_static/image18.gif) |
| Delivers content using Fast Streaming | ![](windows-media-server-or-web-server/_static/image19.gif) | **1, 2, 4![](windows-media-server-or-web-server/_static/image20.gif)** |
| Delivers content using Intelligent Streaming | ![](windows-media-server-or-web-server/_static/image21.gif) | **2, 4![](windows-media-server-or-web-server/_static/image22.gif)** |
| Supports cache/proxy delivery scenarios | ![](windows-media-server-or-web-server/_static/image23.gif) | **5![](windows-media-server-or-web-server/_static/image24.gif)** |
| Supports rich client logging | ![](windows-media-server-or-web-server/_static/image25.gif) | **6![](windows-media-server-or-web-server/_static/image26.gif)** |
| Delivers content to cross-platform [Silverlight](https://www.microsoft.com/silverlight/) clients | ![](windows-media-server-or-web-server/_static/image27.gif) | ![](windows-media-server-or-web-server/_static/image28.gif) |
| Delivers content to iOS devices (iPhone, iPad) | ![](windows-media-server-or-web-server/_static/image29.gif) | ![](windows-media-server-or-web-server/_static/image30.gif) |
| Delivers content referenced by server-controlled playlists | ![](windows-media-server-or-web-server/_static/image31.gif) | **7![](windows-media-server-or-web-server/_static/image32.gif)** |
| Provides advanced performance boundary limits properties | ![](windows-media-server-or-web-server/_static/image33.gif) | **1![](windows-media-server-or-web-server/_static/image34.gif)** |
| Supported on [Server Core](http://technet2.microsoft.com/windowsserver2008/en/library/47a23a74-e13c-46de-8d30-ad0afb1eaffc1033.mspx?mfr=true) installations | ![](windows-media-server-or-web-server/_static/image35.gif) | ![](windows-media-server-or-web-server/_static/image36.gif) |
| Available for [Windows Web Server 2008](https://www.microsoft.com/windowsserver2008/en/us/editions-overview.aspx) | ![](windows-media-server-or-web-server/_static/image37.gif) | ![](windows-media-server-or-web-server/_static/image38.gif) |


**1**[IIS Bit Rate Throttling](https://www.iis.net/downloads/microsoft/bit-rate-throttling)  
**2**[IIS Live Smooth Streaming](https://www.iis.net/downloads/microsoft/live-smooth-streaming)  
**3** Coming soon in IIS Smooth Multicast  
**4**[IIS Smooth Streaming](https://www.iis.net/downloads/microsoft/smooth-streaming)  
**5**[IIS Application Request Routing](https://www.iis.net/downloads/microsoft/application-request-routing)  
**6**[IIS Advanced Logging](https://www.iis.net/downloads/microsoft/advanced-logging)  
**7**[IIS Web Playlists](https://www.iis.net/downloads/microsoft/web-playlists)

[Discuss in IIS Forums](https://forums.iis.net/1145.aspx)