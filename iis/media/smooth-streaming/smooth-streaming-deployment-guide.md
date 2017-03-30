---
title: "Smooth Streaming Deployment Guide | Microsoft Docs"
author: rick-anderson
description: "Last Updated: August 16, 2010 Smooth Streaming is the Microsoft implementation of adaptive streaming technology, which is a form of Web-based media content d..."
ms.author: iiscontent
manager: soshir
ms.date: 10/08/2009
ms.topic: article
ms.assetid: 
ms.technology: iis-media
ms.prod: iis
msc.legacyurl: /learn/media/smooth-streaming/smooth-streaming-deployment-guide
msc.type: authoredcontent
---
Smooth Streaming Deployment Guide
====================
by Dave Nelson

Last Updated: August 16, 2010

Smooth Streaming is the Microsoft implementation of adaptive streaming technology, which is a form of Web-based media content delivery that uses standard HTTP. Instead of delivering media as full-file downloads, or as persistent (and thus stateful) streams, the content is delivered to clients as a series of MPEG-4 (MP4) fragments that can be cached at edge servers. Smooth Streaming-compatible clients use special heuristics to dynamically monitor current network and local PC conditions and seamlessly switch the video quality of the Smooth Streaming presentation that they receive. As clients play the fragments, network conditions may change (for example, bandwidth may decrease) or video processing may be impacted by other applications that are running. Clients can immediately request that the next fragment come from a stream that is encoded at a different bit rate to accommodate the changing conditions. This enables clients to play the media without stuttering, buffering, or freezing. As a result, users experience the highest-quality playback available, with no interruptions in the stream.

Smooth Streaming provides media companies with a better way to make full-HD (1080p) streaming on the Web a reality. It offers code-free deployment and simplified content management for content creators and content delivery networks. For users, the improved viewing experience brings the reliability and quality of television to their favorite video Web sites.

The Smooth Streaming Deployment Guide describes the Microsoft implementation for delivering a full Smooth Streaming experience. As a content producer, you can encode on-demand files and live broadcasts to Smooth Streaming format using Microsoft Expression Encoder 4. As a content provider, you can use IIS Media Services to serve the encoded Smooth Streams. And as a content consumer, you can play the Smooth Streams using a Smooth Streaming-compatible client, such as Microsoft Silverlight.

You can **[download](https://go.microsoft.com/?linkid=9737462 "IIS Smooth Streaming Deployment Guide")** the Smooth Streaming Deployment Guide as a Microsoft Word document or PDF file.
  
  
[Discuss in IIS Forums](https://forums.iis.net/1145.aspx)