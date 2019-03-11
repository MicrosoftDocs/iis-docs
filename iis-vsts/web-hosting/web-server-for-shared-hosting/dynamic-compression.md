---
title: "Dynamic Compression"
author: walterov
description: "Dynamic compression can save a significant amount of bandwidth with a tradeoff in using extra CPU. If bandwidth savings are more important than additional CP..."
ms.date: 12/01/2007
ms.assetid: c4482a67-804d-431f-8fb8-d81df610e295
msc.legacyurl: /learn/web-hosting/web-server-for-shared-hosting/dynamic-compression
msc.type: authoredcontent
---
Dynamic Compression
====================
by [Walter Oliver](https://github.com/walterov)

Dynamic compression can save a significant amount of bandwidth with a tradeoff in using extra CPU. If bandwidth savings are more important than additional CPU, and the server is not currently bound by CPU, enable dynamic compression.

The amount of CPU used by dynamic compression can be controlled by a setting on the server called **dynamicCompressionDisableCpuUsage**. This setting makes sure that if the system reaches the specified level of CPU usage, dynamic compression will not cause additional load. The default value for disabling the CPU usage is 90%. Depending on your requirements, determine a number that works for your environment.

> [!NOTE]
> If you do not install Dynamic Compression, these settings will not take effect.

**To configure dynamic compression**

- Open a command prompt and run the following:


[!code-console[Main](dynamic-compression/samples/sample1.cmd)]