---
title: "Deployment Recommendations for Application Request Routing"
author: rick-anderson
description: "This section of the document applies to Microsoft Application Request Routing Version 2 for IIS 7 and Above. Goal To highlight and understand deployment reco..."
ms.date: 07/16/2009
ms.assetid: c90b100b-f40f-442c-b55c-2a5b9def4f6a
msc.legacyurl: /learn/extensions/installing-application-request-routing-arr/deployment-recommendations-for-application-request-routing
msc.type: authoredcontent
---
Deployment Recommendations for Application Request Routing
====================
by Won Yoo

This section of the document applies to **Microsoft Application Request Routing Version 2 for IIS 7 and Above.**

## Goal

To highlight and understand deployment recommendations for Application Request Routing (ARR).  
This is more of a best practices document for deploying ARR Version 2 than a typical walkthrough article.

## Prerequisites

This article assumes that you are familiar with the overall functionality of ARR and know how to deploy and configure ARR with disk cache. If you have not done so already, it is strongly recommended that you review the following walkthroughs before proceeding:

- [Configure and enable disk cache in Application Request Routing](../configuring-application-request-routing-arr/configure-and-enable-disk-cache-in-application-request-routing.md)
- [Cache hierarchy management using Application Request Routing](../configuring-application-request-routing-arr/cache-hierarchy-management-using-application-request-routing.md)
- [Deploying Application Request Routing in CDN](deploying-application-request-routing-in-cdn.md)
- [Browse cached contents on disk on Application Request Routing](../configuring-application-request-routing-arr/browse-cached-contents-on-disk-on-application-request-routing.md)
- [Delete cached objects](../configuring-application-request-routing-arr/delete-cached-objects.md)
- [Manually override cache-control directives using Application Request Routing](../configuring-application-request-routing-arr/manually-override-cache-control-directives-using-application-request-routing.md)
- [Warm-up cache nodes on Application Request Routing](../configuring-application-request-routing-arr/warm-up-cache-nodes-on-application-request-routing.md)

If Application Request Routing Version 2 has not been installed, you can download it at:

- Microsoft Application Request Routing Version 2 for IIS 7 (x86) [here](https://download.microsoft.com/download/4/D/F/4DFDA851-515F-474E-BA7A-5802B3C95101/ARRv2_setup_x86.EXE).
- Microsoft Application Request Routing Version 2 for IIS 7 (x64) [here](https://download.microsoft.com/download/3/4/1/3415F3F9-5698-44FE-A072-D4AF09728390/ARRv2_setup_x64.EXE).

Follow the steps outlined in [this](install-application-request-routing-version-2.md) document to install ARR Version 2.

## Step 1 - Disable application pool idle time-out.

The application pool idle time-out is an IIS feature that shuts down the application pool when there is inactivity. By default the amount is set for 20 minutes, which represents:

Amount of time (in minutes) that a worker process will remain idle before it shuts down. A worker process is idle if it is not processing requests and no new requests are received.

The intent of this feature in IIS is to repurpose the resource that the application pool uses and reclaim it if the application pool is idle. This is useful if the IIS server is used to host multiple sites and applications, and it is configured to share the resources across the sites and applications.

In a typical ARR deployment scenario, this is not the case and you would actually want the application pool for ARR to be running all the time.

The steps to disable the application pool idle time-out are described in the [Install Application Request Routing Version 2](install-application-request-routing-version-2.md) article.

## Step 2 - Disable application pool recycling conditions.

The application pool recycling is an IIS feature that periodically recycles the application pool. This feature is useful when you do not have a high degree of confidence in the applications that are running in your application pool (ie. in a shared hosting environment where the end user will deploy the application directly), and restarting the application pool would benefit the functionality and stability of the application. (For example, an application may have a slow memory leak. Rather than running the application indefinitely, you will recycle the application periodically to mitigate against code defects.)

This, of course, is not ideal for ARR's use case when you expect ARR to be available all the time (and also to quickly respond all the time).

The steps to disable the application pool recycling conditions are described in the [Install Application Request Routing Version 2](install-application-request-routing-version-2.md) article.

## Step 3 - Separate the cache drive location from system drive.

Although ARR supports cache drive locations that are folders, it is highly recommended that the cache drive location(s) are separated from the system drive. This is because as the number of cached contents grow to millions of objects (or even billions of objects), managing them can be a costly I/O operation. As noted in the [Delete cached objects](../configuring-application-request-routing-arr/delete-cached-objects.md) article, deleting all cached objects from all primary cache drive location(s) can take a long time, and doing a quick formatting of the drive may be a better alternative. Of course, in order to do this, you will need to separate the cache drive location(s) from the system drive.

For optimal performance, it is recommended that the cache drive location be a physically separate drive than the system drive. It is also recommended that the cache drive location be a high RPM drive (15K RPM) for better performance. If you have only one physical drive, it is still recommended to separate the system drive from the cache location drive. You can partition the same physical drive into multiple volumes using **Disk Management** under **Server Manager**.

## Step 4 - Disable 8.3 name creation.

The creation of 8.3 file names and directories for all long file names and directories on NTFS partitions may decrease directory enumeration performance. Since ARR heavily uses the disk drive for its caching feature, it is recommended that 8.3 name creation is disabled.

On Windows Server 2008, the 8.3 name creation can only be disabled for the entire server. More explicitly, it cannot be configured per volume.

On Windows Server 2008 R2, this setting can be configured per volume.

More information about 8.3 name creation on NTFS is documented in [KB121007](https://support.microsoft.com/kb/121007). To simply disable 8.3 name creation, at the command prompt type **fsutil.exe behavior set disable8dot3 1** and then press ENTER.
