---
title: "How to Migrate FPSE Sites to WebDAV | Microsoft Docs"
author: rmcmurray
description: "Introduction Microsoft has created a new WebDAV extension module that has been completely rewritten for Internet Information Services 7.0 (IIS 7.0) on Window..."
ms.author: iiscontent
manager: soshir
ms.date: 02/18/2008
ms.topic: article
ms.assetid: 1f1fa413-7296-46eb-8ff3-4bc335185776
ms.technology: iis-publish
ms.prod: iis
msc.legacyurl: /learn/publish/using-webdav/how-to-migrate-fpse-sites-to-webdav
msc.type: authoredcontent
---
How to Migrate FPSE Sites to WebDAV
====================
by [Robert McMurray](https://github.com/rmcmurray)

<a id="00"></a>

## Introduction

Microsoft has created a new WebDAV extension module that has been completely rewritten for Internet Information Services 7.0 (IIS 7.0) on Windows Server® 2008. This new WebDAV extension module incorporates many new features that enable web authors to publish content better than before, and offers web administrators more security and configuration options.

Some of Microsoft's new web authoring tools like Expression Web Designer have built-in support for working with WebDAV-enabled sites, while other web authoring tools rely on the FrontPage Server Extensions (FPSE) for publishing. With the addition of a first-class WebDAV redirector in Windows Vista and Windows Server 2008, it is possible to map a drive letter to a web site that is configured to use the WebDAV module, and as such you can open that web site using web authoring tools that do not have built-in WebDAV support like FrontPage 2003 and Visual Studio.

This document walks you through migrating web sites on IIS 7.0 from the FrontPage Server Extensions to WebDAV and configuring your request filtering settings to protect FPSE metadata from non-WebDAV requests.

### Prerequisites

The following items are required to complete the procedures in this article:

- IIS 7.0 must be installed on your server, and the following must be configured: 

    - The Default Web Site that is created by the IIS 7.0 installation must still exist.
    - The Request Filtering role service must be installed.
- The new WebDAV extension module must be installed. For information regarding the installation of the new WebDAV module, please see the following document: 

    - [Installing and Configuring WebDAV on IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=105146)

> [!NOTE]
> You need to make sure that you follow the steps in this document using full administrative permissions. This is best accomplished using one of two methods:

- Log in to your computer using the local "administrator" account.
- If you are logged in using an account with administrative permissions that is not the local "administrator" account, open IIS Manager and all command prompt sessions using the "Run as Administrator" option.

The above condition is required because the User Account Control (UAC) security component in Windows Server 2008 prevents administrative access to the IIS 7.0 configuration settings. For more information about UAC, please see the following documentation:

- [https://go.microsoft.com/fwlink/?LinkId=113664](https://go.microsoft.com/fwlink/?LinkId=113664)

<a id="01"></a>

## A Brief Description of FPSE and WebDAV

One of the great things about the FrontPage Server Extensions from their original concept was their *vision*. When the FrontPage development team first envisioned a client-independent way of publishing content between disparate servers, technologies like WebDAV were still unheard of. By installing FPSE and using the FrontPage client, it became possible to seamlessly publish content from a Windows web server to a UNIX web server (or vice-versa) with full feature parity between the two systems. In its original presentation FPSE was implemented using the Common Gateway Interface (CGI), although it was later implemented for IIS through ISAPI.

[![](how-to-migrate-fpse-sites-to-webdav/_static/image3.jpg)](how-to-migrate-fpse-sites-to-webdav/_static/image1.jpg)

In addition to publishing functionality, FrontPage and FPSE also provided a variety of additional functionality through what were affectionately called "bots". These were subdivided into two categories: save-time bots and browse-time bots. Save-time bots were functionality that could be added to web pages when authoring that provided auto-generation of content, such as included content and tables of contents. Browse-time bots were designed to replace common CGI-based features, such as processing form-results. While these features offered web developers a plethora of functionality, they were also proprietary in nature and as such, industry adoption was limited.

Over the past several years Microsoft web authoring tools have moved away from bots: save-time bots are often replaced with other features, and browse-time bots are most often replaced by other dynamic features like ASP.NET or PHP applications. This leaves the remaining feature that FPSE provides as content publishing. That said, in July of 2006 Microsoft Office XP passed out of mainstream support, (Office 2000 was already out of mainstream support), and therefore FPSE was discontinued as a separate download. FPSE is still available and supported as a pre-installed Windows component in Windows Server® 2003, and recently Microsoft and [Ready-to-Run Software](http://www.rtr.com/) released a version of [FPSE for Windows Server 2008 and Windows Vista](https://go.microsoft.com/fwlink/?LinkId=86544). However, Microsoft web authoring tools are moving away from FPSE the publishing protocol of choice, which is where WebDAV enters the picture.

WebDAV stands for Web Distributed Authoring and Versioning, and it is an open-standard extension to HTTP that adds functionality in order to provide Internet-based web publishing without using a CGI-based or ISAPI-based protocol extension like FPSE. WebDAV has been in use for ten years now, and industry adoption is steadily growing. Windows now offers a great built-in WebDAV redirector that allows users to map drives to WebDAV-enabled web sites, therefore turning the Internet into an extension of your local network and delivering on the promise of seamlessly publishing content between disparate servers.

<a id="02"></a>

## Migrating Sites from FPSE to WebDAV

When migrating an FPSE web site to WebDAV, there are several folders that must be secured from normal HTTP access. A detailed examination of all of the files and folders in an FPSE-based web site is available in the [Upgrade issues with FrontPage Server Extensions](https://www.iis.net/downloads/community) white paper on the Microsoft IIS.NET web site. We examine several of the relevant FPSE folders in order to create request filtering rules later.

> | Folder | Notes |
> | --- | --- |
> | \_fpclass | Should contain publicly-available FrontPage code - but should be secured. |
> | \_private | The FrontPage Server Extensions often keep sensitive data files in this folder, so it should be secured to prevent browsing. |
> | \_vti\_bin | This is the virtual directory for the FrontPage Server Extensions executables. This path is configured to allow executables to function, and since we are migrating sites to WebDAV it should be secured to prevent browsing. |
> | \_vti\_cnf | The FrontPage Server Extensions keep sensitive metadata files in this folder, so it should be deleted or secured to prevent browsing. |
> | \_vti\_log | The FrontPage Server Extensions keep author logs in this folder, so it should be deleted or secured to prevent browsing. |
> | \_vti\_pvt | This folder holds several files that contain various metadata for your web site, and should be secured. |
> | \_vti\_txt | This folder contains the text indices and catalogs for the older FrontPage WAIS search. Since later versions of FrontPage only used Index Server, it is safe to delete this folder, but at the very least it should be secured to prevent browsing. |
> | fpdb | FrontPage keeps databases in this folder, so it should be secured to prevent browsing. |


<a id="02a"></a>

### Step 1: Removing FPSE from Your Web Site

The first step in the migration process is to remove FPSE from your content. The request filtering rules that we add later prevent access to the FPSE folders, but we need to remove FPSE just to be on the safe side. There are two ways to remove FPSE from a web site:

- **Uninstall** - Removes the \_vti\_bin virtual directory but preserves all FPSE metadata (remaining \_vti\_\* folders are kept)
- **Full Uninstall** - Removes the \_vti\_bin virtual directory and deletes all FPSE metadata (remaining \_vti\_\* folders are deleted)

The choice for whether to keep your FPSE metadata is up to you. If you are using FrontPage 2003 or Microsoft Expression Web Designer and you are going to map a drive using the WebDAV redirector, you may want to keep your metadata. If you are going to use Microsoft Expression Web Designer's built-in WebDAV support to open the web site, your metadata will be ignored.

There are two ways to remove FPSE: using the FPSE HTML administration pages and using the command line.

<a id="02a1"></a>

#### Using HTML Administration Pages to Uninstall FPSE

To uninstall the FrontPage 2002 Server Extensions using the FPSE HTML administration pages, follow these steps:

1. Open the Windows **Control Panel**.
2. Double-click **Administrative Tools**.
3. Double-click **Microsoft SharePoint Administrator**.
4. In the list of virtual servers, click **Administration** next to the virtual server you want to uninstall.
5. Under **Administration**, click **Uninstall FrontPage 2002 Server Extensions**.
6. If you want to uninstall FrontPage 2002 Server Extensions completely, including the metadata about your Web site, click **Yes** next to **Full Uninstall**, otherwise choose **No**.
7. Click **Uninstall**.

<a id="02a2"></a>

#### Using the Command Line to Uninstall FPSE

To uninstall the FrontPage 2002 Server Extensions using a command line, follow these steps:

1. Open a command prompt.
2. Type the following command:  

    [!code-console[Main](how-to-migrate-fpse-sites-to-webdav/samples/sample1.cmd)]
3. Type one of the following commands: 

    - To remove FPSE and preserve metadata:  

        [!code-console[Main](how-to-migrate-fpse-sites-to-webdav/samples/sample2.cmd)]
    - To remove FPSE and delete metadata:  

        [!code-console[Main](how-to-migrate-fpse-sites-to-webdav/samples/sample3.cmd)]

> [!NOTE]
> The "nnn" in the "lm/w3svc/nnn" path is the site ID that can be found in the IIS manager under the **Sites** node. For example, the Default Web Site should always be site 1, and subsequent sites should have numerically increasing site IDs. Therefore, to remove FPSE from the default web site you would use "lm/w3svc/1".

Additional information about installing or removing FPSE from web sites can be found in the [Installing the FrontPage Server Extensions on IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=88546) topic.

<a id="02b"></a>

### Step 2: Adding Request Filtering Rules

Two of the great new features in IIS 7.0 are Request Filtering, which is much like having UrlScan built-in, and AppCmd, which is a command-line tool that is used for configuring IIS settings. Detailed information on these IIS features and their use with WebDAV can be found in the following topics:

- [How to Use Request Filtering](../../manage/configuring-security/use-request-filtering.md)
- [Getting Started with AppCmd.exe](../../get-started/getting-started-with-iis/getting-started-with-appcmdexe.md)
- [How to Configure WebDAV Using AppCmd](how-to-configure-webdav-settings-using-appcmd.md)
- [How to Configure WebDAV and Request Filtering](how-to-configure-webdav-with-request-filtering.md)

With that information in mind, we configure request filtering for WebDAV access.

<a id="02b1"></a>

#### Creating Denied URL Sequences and Hidden Segments for FPSE Folders

Request Filtering blocks certain file paths like "App\_Code" from web access by default, and we add additional entries for the FPSE folders to the list of hidden paths. Additionally, you can control whether this list applies to WebDAV requests, and we configure request filtering to allow WebDAV access to all hidden paths.

1. Open a command prompt with full administrative privileges and change directory to your Inetsrv folder:  

    [!code-console[Main](how-to-migrate-fpse-sites-to-webdav/samples/sample4.cmd)]
2. Block access to the FPSE executables by adding an entry to the **denyUrlSequences** collection using the following syntax:  

    [!code-console[Main](how-to-migrate-fpse-sites-to-webdav/samples/sample5.cmd)]
3. Block access to the remaining FPSE segments by adding entries to the **hiddenSegments** collection using the following syntax:  

    [!code-console[Main](how-to-migrate-fpse-sites-to-webdav/samples/sample6.cmd)]
4. Allow WebDAV to access all hidden file segments by setting the **applyToWebDAV** attribute for the **hiddenSegments** collection to **false** using the following syntax:  

    [!code-console[Main](how-to-migrate-fpse-sites-to-webdav/samples/sample7.cmd)]

After completing the above steps the resulting code in the **requestFiltering** section of your applicationHost.config file should resemble the following example:

> [!code-xml[Main](how-to-migrate-fpse-sites-to-webdav/samples/sample8.xml)]


<a id="02b2"></a>

#### Allowing Access to Blocked HTTP Verbs

Request Filtering allows for a customized list of allowed or denied HTTP verbs for web access. When working with WebDAV, you may want to allow all HTTP verbs, so you will need to allow WebDAV to access all blocked verbs by setting the **applyToWebDAV** attribute for the **verbs** collection to **false** using the following steps:

1. Open a command prompt with full administrative privileges and change directory to your InetSrv folder:  

    [!code-console[Main](how-to-migrate-fpse-sites-to-webdav/samples/sample9.cmd)]
2. Allow WebDAV to access all HTTP verbs by setting the **applyToWebDAV** attribute for the **verbs** collection to **false** using the following syntax:  

    [!code-console[Main](how-to-migrate-fpse-sites-to-webdav/samples/sample10.cmd)]

After completing the above steps the resulting code in the **verbs** section of your applicationHost.config file should resemble the following example:

> [!code-xml[Main](how-to-migrate-fpse-sites-to-webdav/samples/sample11.xml)]


<a id="02b3"></a>

#### Allowing Access to Blocked File Extensions

Request Filtering will block certain file extensions like ".config" and ".asax" from web access by default, and you can control whether this list applies to WebDAV requests. Typically, you want to allow web authoring tools to modify these files, so you need to allow WebDAV to access all blocked file types by setting the **applyToWebDAV** attribute for the **fileExtensions** collection to **false** using the following steps:

1. Open a command prompt with full administrative privileges and change directory to your InetSrv folder:  

    [!code-console[Main](how-to-migrate-fpse-sites-to-webdav/samples/sample12.cmd)]
2. Allow WebDAV to access all blocked file types by setting the **applyToWebDAV** attribute for the **fileExtensions** collection to **false** using the following syntax:  

    [!code-console[Main](how-to-migrate-fpse-sites-to-webdav/samples/sample13.cmd)]

After completing the above steps the resulting code in the **fileExtensions** section of your applicationHost.config file should resemble the following example:

> [!code-xml[Main](how-to-migrate-fpse-sites-to-webdav/samples/sample14.xml)]


<a id="02c"></a>

### Step 3: Cleaning Up FPSE Settings

The remaining item is optional, and that is to remove the configuration settings that the FPSE administration tools create for the FPSE-related folders. If these settings are not removed, then tools like FrontPage 2003 and Visual Studio may not be able to access the metadata for the web site when accessing through the WebDAV redirector using a mapped drive.

> [!NOTE]
> The following script removes all of settings for each of the FPSE-related folders; if you have made any customized settings they will be removed as well. In addition, if you do not complete the steps in the request filtering section of this document before running this script then your metadata files will be browsable via the Internet.

To run this script, use the following steps:

1. Copy the VBcript code listed below and paste it into a text editor, such as Windows Notepad.  
  
    > [!NOTE]
    > If you are using a site other than the Default Web Site, you must update the     *strSiteName* variable.
2. Save the file as "CleanFpseSettings.vbs" to your desktop and close your text editor.
3. Open a command prompt as an administrator by right-clicking the Command Prompt menu item that is located in the Windows Accessories menu and selecting "Run as administrator".
4. Change directory to your desktop by entering the following command: 

    [!code-console[Main](how-to-migrate-fpse-sites-to-webdav/samples/sample15.cmd)]
5. Run the code using the following command: 

    [!code-console[Main](how-to-migrate-fpse-sites-to-webdav/samples/sample16.cmd)]
6. Close the command prompt.

> [!code-vb[Main](how-to-migrate-fpse-sites-to-webdav/samples/sample17.vb)]


<a id="03"></a>

## Summary

This document has shown you how to migrate sites from FPSE to WebDAV using following steps:

- [Step 1: Removing FPSE from your web site](how-to-migrate-fpse-sites-to-webdav.md#02a)

    - [Using HTML Administration Pages to Uninstall FPSE](how-to-migrate-fpse-sites-to-webdav.md#02a1)
    - [Using the Command Line to Uninstall FPSE](how-to-migrate-fpse-sites-to-webdav.md#02a2)
- [Step 2: Adding Request Filtering Rules](how-to-migrate-fpse-sites-to-webdav.md#02b)

    - [Creating Hidden Segments for FPSE Folders](how-to-migrate-fpse-sites-to-webdav.md#02b1)
    - [Allowing Access to Blocked HTTP Verbs](how-to-migrate-fpse-sites-to-webdav.md#02b2)
    - [Allowing Access to Blocked File Extensions](how-to-migrate-fpse-sites-to-webdav.md#02b3)
- [Step 3: Cleaning Up FPSE Settings](how-to-migrate-fpse-sites-to-webdav.md#02c)

### More Information

For additional information about using WebDAV, please see the following articles:

- [Installing and Configuring WebDAV on IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=105146)
- [How to manage WebDAV using AppCmd](https://go.microsoft.com/fwlink/?LinkId=108319)
- [How to configure WebDAV and Request Filtering](https://go.microsoft.com/fwlink/?LinkId=108321)