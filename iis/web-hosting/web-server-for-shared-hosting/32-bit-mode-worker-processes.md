---
title: "32-bit Mode Worker Processes"
author: walterov
description: "One of the performance benefits of the x64 platform is that it increases virtual address space, making more memory available. We recommend that you configure..."
ms.date: 12/01/2007
ms.assetid: c231f281-e384-4b4f-a1ee-a09841cabae0
msc.legacyurl: /learn/web-hosting/web-server-for-shared-hosting/32-bit-mode-worker-processes
msc.type: authoredcontent
---
# 32-bit Mode Worker Processes

by [Walter Oliver](https://github.com/walterov)

One of the performance benefits of the x64 platform is that it increases virtual address space, making more memory available. We recommend that you configure IIS to use a 32-bit worker processes on 64-bit Windows. Not only its compatibility better than the native 64-bit, performance and memory consumption are also better.

Set the Web server to enable this globally so that you do not need to set it for each application pool. Unlike previous versions of IIS, you can now configure specific worker processes to run in 32-bit or 64-bit mode independently of each other on the same server.

**To configure 32-bit mode for the server**

- Open a command prompt and run the following:

[!code-console[Main](32-bit-mode-worker-processes/samples/sample1.cmd)]

> [!NOTE]
> This setting applies only to 64-bit servers.

**To configure 32-bit mode for the server using the [IIS PowerShell Provider](../../manage/powershell/installing-the-iis-powershell-snap-in.md)**

- Open a PowerShell prompt and run the following:

[!code-powershell[Main](32-bit-mode-worker-processes/samples/sample2.ps1)]
