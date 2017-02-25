---
title: "Browse Cached Contents on Disk on Application Request Routing | Microsoft Docs"
author: rick-anderson
description: "This section of the document applies to Microsoft Application Request Routing Version 2 for IIS 7 and Above. Goal To successfully view and manage the cached..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 07/16/2009
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/extensions/configuring-application-request-routing-arr/browse-cached-contents-on-disk-on-application-request-routing
msc.type: authoredcontent
---
Browse Cached Contents on Disk on Application Request Routing
====================
by Won Yoo

This section of the document applies to **Microsoft Application Request Routing Version 2 for IIS 7 and Above.**

## Goal

To successfully view and manage the cached contents on Application Request Routing (ARR).

## Prerequisites

This walkthrough assumes that you are familiar with the overall functionality of ARR and know how to deploy and configure ARR with disk cache. If you have not done so already, it is strongly recommended that you review the following walkthroughs before proceeding:

- [Configure and enable disk cache in Application Request Routing](configure-and-enable-disk-cache-in-application-request-routing.md)
- [Cache hierarchy management using Application Request Routing](cache-hierarchy-management-using-application-request-routing.md)
- [Deploying Application Request Routing in CDN](../installing-application-request-routing-arr/deploying-application-request-routing-in-cdn.md)

If Application Request Routing Version 2 has not been installed, you can download it at:

- Microsoft Application Request Routing Version 2 for IIS 7 (x86) [here](https://download.microsoft.com/download/4/D/F/4DFDA851-515F-474E-BA7A-5802B3C95101/ARRv2_setup_x86.EXE).
- Microsoft Application Request Routing Version 2 for IIS 7 (x64) [here](https://download.microsoft.com/download/3/4/1/3415F3F9-5698-44FE-A072-D4AF09728390/ARRv2_setup_x64.EXE).

Follow the steps outlined in [this](../installing-application-request-routing-arr/install-application-request-routing-version-2.md) document to install ARR Version 2.

## Step 1 - Browse cached contents on disk.

The ability to view the cached contents on ARR is a UI feature that is implemented using IIS Manager. The steps outlined in this walkthrough assume that ARR has already been configured to be used with disk cache and some contents have already been cached on ARR. To learn more about how to configure and enable disk cache on ARR, see [this](configure-and-enable-disk-cache-in-application-request-routing.md) article.

1. Launch IIS Manager.
2. Select and expand the root of the server.

    ![](browse-cached-contents-on-disk-on-application-request-routing/_static/image2.jpg)
3. Double-click **Application Request Routing Cache**.
4. In the **Actions** pane, click **Browse Content**.

    ![](browse-cached-contents-on-disk-on-application-request-routing/_static/image3.jpg)
5. The contents appear similar to Windows Explorer. However, this view has an advantage over Windows Explorer in that given a host name, the contents may be cached on several drive locations based on CARP. Rather than browsing through the physical cache drive locations, the browse functionality in ARR aggregates the cached contents and provides a consolidated view.  
   
 You can further navigate the cached contents by clicking on the bread crumb or double-clicking the folders.

    [![](browse-cached-contents-on-disk-on-application-request-routing/_static/image5.jpg)](browse-cached-contents-on-disk-on-application-request-routing/_static/image4.jpg)

    > [!NOTE]
    > The browse functionality allows the user to view only the cached contents on the primary drives. More explicitly, it does not include the contents shown in the secondary drive. This is by design. ARR will cache both the uncompressed files as well as the compressed files based on the supported encoding by the client and the server. In addition, you may also see different segments of files due to the way the [byte-range requests are supported in ARR](configure-byte-range-request-segment-size-in-application-request-routing.md).

## Step 2 - Delete cached contents.

While you browse through the cached contents on disk, you may want to delete them. ARR provides a way to delete the selected cached content. If a folder is selected, all contents under the selected folder will be removed. If a file is selected, then ***all*** associated files will be removed. For example, you may have noticed that for a given content, there may be multiple files:

- example.jpg.full
- example.jpg.full.gzip
- example.jpg.0-1023
- example.jpg.1024-2047

In the above example, selecting ***any*** one of the files will remove ***all*** of the files that are associated with example.jpg.

> [!NOTE]
> The selected cached content(s) will be removed from both the primary cache drive location(s) and the secondary cache drive location, if configured.

1. While browsing, select a folder or a file that you want to delete.
2. In the **Actions** pane, click **Delete Selected Cached Object**. 

    ![](browse-cached-contents-on-disk-on-application-request-routing/_static/image6.jpg)
3. In the confirmation dialog box, click **Yes**.
4. The cached content has been removed from both the primary cache drive location(s) and the secondary cache drive location, if configured.

## Summary

You have now successfully browsed through the cached contents on disk using IIS Manager. You can also select and delete cached content(s) while browsing.

For other ARR Version 2 walkthroughs, see the documents in [this](../planning-for-arr/application-request-routing-version-2-overview.md) article.
  
  
[Discuss in IIS Forums](https://forums.iis.net/1154.aspx)