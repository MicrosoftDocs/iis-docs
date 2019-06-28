---
title: "High-Performance Transcoding with IIS Transform Manager and Windows HPC Server"
author: rick-anderson
description: "Last Updated: April 27, 2011 You can use the IIS Transform Manager 1.0 extension for Internet Information Services (IIS) 7 to transcode media files to Smooth..."
ms.date: 04/27/2011
ms.assetid: c964eaba-99b0-4dca-bf52-3966366c3457
msc.legacyurl: /learn/media/transform-manager/high-performance-transcoding-with-iis-transform-manager-and-windows-hpc-server
msc.type: authoredcontent
---
# High-Performance Transcoding with IIS Transform Manager and Windows HPC Server

by Dave Nelson

Last Updated: April 27, 2011

You can use the [IIS Transform Manager 1.0](https://go.microsoft.com/?linkid=9771075) extension for Internet Information Services (IIS) 7 to transcode media files to Smooth Streaming and MPEG-2 Transport Stream (MPEG-2 TS) container formats. One web server is often sufficient for small transcoding jobs. However, offloading this task to multiple computers can greatly reduce the time required to convert a large media library. [Windows HPC Server](https://go.microsoft.com/?linkid=9771076) is a high performance computing (HPC) solution built on Windows Server technology that provides a platform for clustering computers to perform computation-intensive tasks, such as transcoding, without specialized hardware. Because transcoding audio and video is a computationally intensive task that involves decompressing the source audio and video formats and then recompressing them into a new format, an HPC cluster is a good fit for Transform Manager because the transcoding work can be shifted from the web server to compute nodes in the cluster.

This white paper describes how to configure Transform Manager to use an HPC cluster for transcoding media files to IIS Smooth Streaming format, using Expression Encoder presets. Download the white paper in the following formats: [DOCX](https://go.microsoft.com/?linkid=9771028) or [PDF](https://go.microsoft.com/?linkid=9771029).
