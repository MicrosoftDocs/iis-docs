---
title: "Offline Files for Shared Configuration"
author: walterov
description: "Once you have enabled shared configuration, a common question is what happens when the network share that serves those files becomes unavailable. When the sh..."
ms.date: 12/02/2007
ms.assetid: c6b51f76-282c-43d5-9bef-682de7e2f4e5
msc.legacyurl: /learn/web-hosting/configuring-servers-in-the-windows-web-platform/offline-files-for-shared-configuration
msc.type: authoredcontent
---
Offline Files for Shared Configuration
====================
by [Walter Oliver](https://github.com/walterov)

## Introduction

Once you have enabled shared configuration, a common question is what happens when the network share that serves those files becomes unavailable. When the share goes down, the configuration system will detect a change notification (after the share times out) and WAS will try to reload the configuration resulting in failure. At this point, the web server will not be functional, the W3SVC service will be unable to access configuration. To ensure that the Web server can always access the configuration files, it is recommended that you use either Distributed File System (DFS) with replication or offline files.

> [!NOTE]
> In Windows Server 2008 R2 (Windows 7), when the share goes down, the config system will send a special notification to WAS saying that there was an IO error when accessing the config file. At this time, WAS will continue using the cached copy of config that it currently has. Meanwhile, it will continue to poll the config system until the share comes back up (at which time, it will reload config). While WAS is running with cached config, if you stop WAS, or reboot the system, your webserver will stop working until the share comes back up.  

The offline files feature, or client side caching, enables files stored on a network share to be accessed even when the network share is unavailable. It is a simple solution for ensuring the configuration files are always available and is recommended for the shared configuration files. However, offline files are not recommended for the Web site content, because this reduces throughput.

**Problem summary**: When IIS 7.0 or above server is configured to work in shared configuration mode then configuration files are stored on a file share. This configuration is recommended for setting up web farms. But in case file share goes offline, the whole set up fails and web servers stop responding. Moreover when the file share comes up again, IIS server is not able to detect it gives following error message:

HTTP Error 500.19 - internal server errorThe requested page cannot be accessed because the related configuration data for the page is invalid.

We have to do an IISreset to start the web servers again after this.

## More Information

For Web site content, you may wish to consider using DFS for your file servers. For more information about DFS, see [Distributed File System](https://docs.microsoft.com/windows/desktop/dfs/distributed-file-system).

For more information about client side caching, go  to[https://www.microsoft.com/](https://www.microsoft.com/).

## Configuring Shared Configuration with Offline Files

**Follow the below steps to set up shared configuration with offline files (client side caching) enabled.**

Step 1: On the Web server, in Control Panel, open Offline Files.

Step 2: In the Offline Files dialog box, click Enable Offline Files. Do not reboot the machine yet.

Step 3: Ensure that the cache is set to read only by running the following command:

[!code-console[Main](offline-files-for-shared-configuration/samples/sample1.cmd)]

Step 4: Reboot the Web server.

Step 5: Browse to the file share folder from web server. Right click and select "Always Available Offline". [![](offline-files-for-shared-configuration/_static/image2.jpg)](offline-files-for-shared-configuration/_static/image1.jpg)

Step 6: Go to control panel -- &gt; Offline Files. Select Schedule option.
[![](offline-files-for-shared-configuration/_static/image4.jpg)](offline-files-for-shared-configuration/_static/image3.jpg)

Step 7: Schedule offline file sync after every 1 day or as per the requirement. This could be in minutes too. Even without setting up any scheduler, the moment I change anything in applicationhost.config file, it is reflected on the web server.

[![](offline-files-for-shared-configuration/_static/image6.jpg)](offline-files-for-shared-configuration/_static/image5.jpg)

Now the web server works fine even if the file share is offline and there is no need of IISReset now.
Many thanks to Won Yoo and Amol Mehrotra for helping with the content.
