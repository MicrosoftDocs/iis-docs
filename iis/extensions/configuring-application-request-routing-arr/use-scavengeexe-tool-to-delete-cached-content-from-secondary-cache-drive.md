---
title: "Use Scavenge.exe tool to delete cached content from secondary cache drive"
author: rick-anderson
description: "This section of the document applies to Microsoft Application Request Routing Version 2 for IIS 7 and Above. Goal To understand scavenge.exe tool in Applicat..."
ms.date: 11/06/2009
ms.assetid: a0a6069a-6484-4486-a885-a0133ade560e
msc.legacyurl: /learn/extensions/configuring-application-request-routing-arr/use-scavengeexe-tool-to-delete-cached-content-from-secondary-cache-drive
msc.type: authoredcontent
---
Use Scavenge.exe tool to delete cached content from secondary cache drive
====================
by CJ Pattekar

This section of the document applies to **Microsoft Application Request Routing Version 2 for IIS 7 and Above.**

## Goal

To understand scavenge.exe tool in Application Request Routing (ARR) to delete cached content from secondary cache drive.

## Prerequisites

This article assumes that you are familiar with the overall functionality of ARR and know how to deploy and configure ARR with disk cache. If you have not done so already, it is strongly recommended that you review the following walkthrough before proceeding:

- [Configure and enable disk cache in Application Request Routing](configure-and-enable-disk-cache-in-application-request-routing.md)

If Application Request Routing Version 2 has not been installed, you can download it at:

- Microsoft Application Request Routing Version 2 for IIS 7 (x86) [here](https://download.microsoft.com/download/4/D/F/4DFDA851-515F-474E-BA7A-5802B3C95101/ARRv2_setup_x86.EXE).
- Microsoft Application Request Routing Version 2 for IIS 7 (x64) [here](https://download.microsoft.com/download/3/4/1/3415F3F9-5698-44FE-A072-D4AF09728390/ARRv2_setup_x64.EXE).

Follow the steps outlined in [this](../installing-application-request-routing-arr/install-application-request-routing-version-2.md) document to install ARR Version 2.

This walkthrough also assumes that secondary cache drive has been added to ARR for caching. If not, please follow the <a id="breadcrumblink_575"></a>[Configure and Enable Disk Cache in Application Request Routing](configure-and-enable-disk-cache-in-application-request-routing.md) walkthrough.

## Scavenge.exe tool in ARR

Scavenge.exe is a command line tool that can be used for managing the secondary drive by the administrators. The exe is installed with ARR and can be found in `%ProgramFiles%\IIS\Application Request Routing` folder.

**Usage:** scavenge.exe &lt;share&gt; dd:[hh[:mm[:ss]]]

- &lt;share&gt; is the path to the share that ARR is using as secondary cache drive.
- dd:[hh[:mm[:ss]]] - Duration - cached files older than this duration will be deleted by the tool. Note that hh, mm, ss are optional.

**Example:** scavenge.exe [\\ARR\SecondaryCache](file://arr/SecondaryCache) 04:11:30:15

This will delete all files located in [\\ARR\SecondaryCache](file://arr/SecondaryCache) that are older than 4 days, 11 hours, 30 minutes and 15 seconds. Note that the tool must be run as a user with permissions to delete content on the specified share.

Windows Task Scheduler can be used to run this tool at specified internval to delete old cached content from the secondary cache drive.
