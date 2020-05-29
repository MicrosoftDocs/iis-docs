---
title: "Use Bit Rate Throttling"
author: rick-anderson
description: "The Bit Rate Throttling extension for Internet Information Services (IIS) provides the ability to throttle progressive downloads of media files (in which aud..."
ms.date: 11/15/2009
ms.assetid: 0ff9896a-d51a-4020-92fa-d3c77aa74bb9
msc.legacyurl: /learn/manage/managing-performance-settings/use-bit-rate-throttling
msc.type: authoredcontent
---
# Use Bit Rate Throttling

by Tali Smith

## Introduction

The Bit Rate Throttling extension for Internet Information Services (IIS) provides the ability to throttle progressive downloads of media files (in which audio/video playback starts as soon as sufficient data has been buffered on the client) based on the content bit rate. For sites that deliver audio and video files that may not be watched in their entirety, this extension can significantly reduce your media-related bandwidth costs. A secondary feature of Bit Rate Throttling is that it can also be used to throttle non-media ("Data") file types at specified bit rates.

For media files, automatic bit-rate detection and throttling are executed according to settings specified in the IIS configuration settings. New settings can be added, and existing settings can be adjusted, to achieve significant bandwidth savings without compromising the user experience. Bit Rate Throttling can automatically detect the encoded bit rates of 11 common media formats, such as Windows Media® Video (WMV), Flash Video (FLV), and MPEG 4 (MP4), and then throttles the response to the client. Bit Rate Throttling lets administrators configure throttling rules for all file and Multipurpose Internet Mail Extension (MIME) types.

- **Reduce bandwidth costs without compromising user experience**. Bit Rate Throttling saves network bandwidth costs by controlling the rate at which media is delivered over HTTP. The throttling rate can be configured using server-side rules or by automatically adjusting the download rate for detected media files based on format and encoded bit rate. When Bit Rate Throttling is not used, content is downloaded at the maximum possible speed. If an end user drops off after watching 20 percent of a video clip, the hoster would have paid for bandwidth for content that was never watched.  
 When Bit Rate Throttling is used, a few seconds of content is sent to the client at the highest possible data rate before throttling down delivery to the encoded bit rate, so that users experience a "Fast Start" of the content they want to watch.
- **Share extra bandwidth among all users with dynamic throttling**. Bit Rate Throttling also allows you to dynamically split your total available bandwidth allocation across all concurrent users. If you are billed for network usage based on a 95th percentile billing model, rather than per byte of data transferred, this equitably shares extra available bandwidth among all of your users. As new users start to consume the extra bandwidth, dynamic throttling reduces bandwidth to each user, but ensures that the allocated bandwidth for each user does not fall below the specified bit rate for the content being consumed.
- **Extend throttling to other content types**. Bit Rate Throttling allows you to add automatic detection and throttling support for other media file formats through its extensible architecture. You can also simply specify fixed-rate throttling for any file or MIME type, media or otherwise, by adding new throttle settings. If you need to vary the throttling rate on a per-response basis, Bit Rate Throttling also lets you configure programmatic throttling.

Features of Bit Rate Throttling include:

- Seamless integration into IIS Manager
- Out-of-the box compatibility for the following media types: .asf, .avi, .flv, .m4v, .mov, .mp3, .mp4, .rm, .rmvb, .wma, and .wmv
- Dynamic throttling adjustment based on: 

    - The file types and their encoded bit rate
    - The available bandwidth of the connection
    - Default and maximum throttling rates
    - Concurrent connection limits
    - Target throughput rate for the site
- Throttling rules configurable at various levels, including server, site, and virtual directory
- Fast Start experience for optimal user experience
- Extensibility to enable other media formats and file types

## Install Bit Rate Throttling

IIS Bit Rate Throttling is included in IIS Media Services 3.0, which can be installed by using either Microsoft® Web Platform Installer (Web PI) 2.0 or Windows® Installer.

### Install Using Web Platform Installer

1. Go to the **[Microsoft Web Platform Installer 2.0 Web page](https://go.microsoft.com/?linkid=9656457)**, and then click **Download It Now** to download and run Web Platform Installer 2.0.
2. In the lower-left corner of the **Web Platform Installer 2.0** dialog box, click **Options**.
3. In the **Change Options** dialog box, under **Display additional scenarios**, make sure that the **Media** check box is selected, and then click **OK**.
4. In the **Web Platform Installer 2.0** dialog box, on the **Media Platform** tab, under **Host and Deliver Media Content**, click **Customize**.
5. Select **IIS Media Services 3.0**, and then click **Install**.

## Install Using Windows Installer

Two separate downloadable installation packages are available for IIS Media Services 3.0, which includes IIS Bit Rate Throttling. Click one of the following links to download the Windows Installer (.msi) file for your edition of Windows®:

- [IIS Media Services 3.0 (32-bit)](https://go.microsoft.com/?linkid=9689914)
- [IIS Media Services 3.0 (64-bit)](https://go.microsoft.com/?linkid=9689915)

To run the Windows Installer file that you downloaded, do the following:

- Double-click the Windows Installer file that you downloaded, and then complete the Setup wizard.

-or-

1. Open an elevated Command Prompt window (click **Start**, click **All Programs**, click **Accessories**, right-click **Command Prompt**, and then click **Run as administrator**).
2. In the **Administrator: Command Prompt** window, navigate the command prompt to the folder where the Windows Installer file is stored.
3. Type one of the following commands to run the installation: **msiexec /I IISMedia32.msi** (for the 32-bit edition of the operating system) or **msiexec /I IISMedia64.msi** (for the 64-bit edition of the operating system).

If you encounter any problems during installation, type one of the following commands at the command prompt to create a log file that contains information about the installation process: **msiexec /L IISMedia.log /I IISMedia32.msi** (for the 32-bit edition of the operating system) or **msiexec /L IISMedia.log /I IISMedia64.msi** (for the 64-bit edition of the operating system). Analyze this log file after a failed installation to help determine the cause of the failure.

You can then configure throttling at the server level, the site level (using Web.config files in the content directories), the virtual directory level, and the file level.

## Links for Further Information

- [TechNet Virtual Lab: Using IIS 7.0 Media Features in a PHP Application](https://msevents.microsoft.com/CUI/WebCastEventDetails.aspx?EventID=1032413789&amp;EventCategory=3&amp;culture=en-US&amp;CountryCode=US).
- [Bit Rate Throttling](https://www.iis.net/downloads/microsoft/bit-rate-throttling)
