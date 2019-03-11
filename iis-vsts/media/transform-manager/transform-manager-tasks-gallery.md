---
title: "Transform Manager Tasks Gallery"
author: johndeu
description: "Transform Manager includes two integrated tasks: an Expression Encoder 4 task and a Smooth Streaming to MPEG-2 Transport Stream task. You can also create you..."
ms.date: 06/10/2010
ms.assetid: 017f14b1-e083-49c5-a1c4-46f3eda076ee
msc.legacyurl: /learn/media/transform-manager/transform-manager-tasks-gallery
msc.type: authoredcontent
---
Transform Manager Tasks Gallery
====================
by [John Deutscher](https://github.com/johndeu)

Transform Manager includes two integrated tasks: an Expression Encoder 4 task and a Smooth Streaming to MPEG-2 Transport Stream task. You can also create your own custom tasks using the [Transform Manager Task Application Programming Interface (API)](transform-manager-tasks-gallery.md#taskapi).

As new third-party tasks become available, we'll post links to them on this page.

## Licensing

IIS Transform Manager is designed to work with other programs, such as programs that handle audio or video signals. It's solely your responsibility to ensure your compliance with any terms accompanying such other programs, and that you have obtained any necessary rights for your use of the programs.

## Expression Encoder 4 Task

The Expression Encoder 4 task can only be used on a computer that has Microsoft Expression Encoder 4 installed. This task enables batch-encoding and transcoding using the free [Expression Encoder 4 Trial](https://www.microsoft.com/expression/products/EncoderPro_Overview.aspx) version if you are targeting Smooth Streams with VC-1 encoded content. If you require H.264 (AVC) video and AAC audio encoding, the low-cost [Expression Encoder 4 Pro license](https://www.microsoft.com/expression/products/Purchase.aspx) can be purchased and installed on the computer to enable encoding to Smooth Streaming format using these codecs. This task is provided in the installation of Transform Manager.

## Smooth Streaming to MPEG-2 Transport Stream Task

The Smooth Streaming to MPEG-2 Transport Stream Task re-muxes existing Smooth Streaming presentations (.ismv, .isma) to MPEG-2 Transport Stream format and generates .m3u8 playlists and index files that are compatible with the on-demand Smooth Streaming module in IIS Media Services 4. Using this task, you can transmux existing Smooth Streaming content that is already encoded in H.264 with AAC-LC audio into MPEG-2 Transport Streams that are compliant with the Apple "Pantos" Live HTTP Streaming protocol. This task can be used stand-alone to batch convert Smooth Streaming presentations for delivery to Apple devices, or can use "chained" together with the Expression Encoder 4 Task. This task is provided in the installation of Transform Manager.

<a id="taskapi"></a>

## Write your own custom tasks with the Transform Manager Task API

Transform Manager contains a Task Engine that can be used to run custom tasks that have been created using the [IIS Transform Manager Task Application Programming Interface (API)](https://go.microsoft.com/?linkid=9735626). The Task API allows developers to build custom tasks that can be integrated with the Transform Manager job manager, logging, metadata, and task progress-reporting framework. Command line applications can also be used as tasks in a job template. For example, in the Transform Manager sample Job Templates, the Xcopy command is used to move assets from one location to another.