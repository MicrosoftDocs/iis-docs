---
title: "How to Configure WebDAV with Request Filtering"
author: rmcmurray
description: "Introduction Microsoft released a new WebDAV extension module that was completely rewritten for Internet Information Services 7.0 (IIS 7.0) on Windows Server..."
ms.date: 02/14/2008
ms.assetid: 7cca593d-4d66-4d8b-a764-37ca1a67201c
msc.legacyurl: /learn/publish/using-webdav/how-to-configure-webdav-with-request-filtering
msc.type: authoredcontent
---
How to Configure WebDAV with Request Filtering
====================
by [Robert McMurray](https://github.com/rmcmurray)

<a id="00"></a>

## Introduction

Microsoft released a new WebDAV extension module that was completely rewritten for Internet Information Services 7.0 (IIS 7.0) on Windows Server® 2008. This new WebDAV extension module incorporated many new features that enable web authors to publish content better than before, and offers web administrators more security and configuration options. Microsoft has released an update to the WebDAV extension module for Windows Server® 2008 that provides shared and exclusive locks support to prevent lost updates due to overwrites.

IIS 7.0 provides several great new security features, including the IIS 7.0 new Request Filtering. For IIS users who are familiar with [UrlScan](https://www.iis.net/downloads/microsoft/urlscan) from previous versions of IIS, the Request Filtering feature in IIS 7.0 is like having URLScan built-in.

The new WebDAV module and Request Filtering were designed to work together, and this document walks you through configuring WebDAV-related Request Filtering settings together with WebDAV settings in order to set up a secure publishing environment. Note that if you use the IIS Manager UI to configure WebDAV then the request filtering settings are automatically updated and you do not need to follow the steps in this article.

### Prerequisites

The following items are required to complete the procedures in this article:

- IIS 7.0 must be installed on your server, and the following must be configured:

    - The Default Web Site that is created by the IIS 7.0 installation must still exist.
    - The Request Filtering feature must be installed.
- The new WebDAV extension module must be installed. For information regarding the installation of the new WebDAV module, please see the following document:

    - [Installing and Configuring WebDAV on IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=105146)
- Knowledge of how to use AppCmd is helpful. For more information about using request filtering, please see the following document:

    - [How to Use Request Filtering](../../manage/configuring-security/use-request-filtering.md)

> [!NOTE]
> You need to make sure that you follow the steps in this document using full administrative permissions. This is best accomplished using one of two methods:

- Log in to your computer using the local "administrator" account.
- If you are logged in using an account with administrative permissions that is not the local "administrator" account, open IIS Manager and all command prompt sessions using the "Run as Administrator" option.

The above condition is required because the User Account Control (UAC) security component in Windows Server 2008 will prevent administrative access to IIS 7.0's configuration settings. For more information about UAC, please see the following documentation:

- [https://go.microsoft.com/fwlink/?LinkId=113664](https://go.microsoft.com/fwlink/?LinkId=113664)

<a id="01"></a>

## Basic Request Filtering Concepts

Request Filtering in IIS 7.0 consists of filtering requests based on the following parameters:

- File Extensions
- Hidden Segments
- HTTP Verbs
- Request Limits
- URL Sequences

All of these request filtering features can impact content that is uploaded or download through WebDAV, but some features can be configured to work in cooperation with WebDAV.

The following list describes which features can be configured to work with WebDAV:

- The following features always affect WebDAV requests:

    - Request Limits
    - URL Sequences
- The following features affect WebDAV requests by default, but they can be configured to bypass WebDAV requests:

    - File Extensions
    - Hidden Segments
    - HTTP Verbs

For example, you can configure your server to allow non-WebDAV requests for ".htm" and ".php" files while blocking access to ".mdb" and ".config" files, while still allowing WebDAV requests to access that blocked content.

> [!NOTE]
> WebDAV requests require authentication.

You can edit your request filtering settings using one of the following methods:

- Using the user interface that is provided as part of Administration Pack for IIS 7.0
- Using AppCmd from a command-line
- Editing your applicationHost.config file
- Using Microsoft.Web.Administration from a .NET application or Windows PowerShell

The remaining information in this walkthrough will show you how to use AppCmd from a command-line, while also showing what the resulting configuration settings in your applicationHost.config file might look like.

> [!NOTE]
> This document does not cover all of the features that can be configured using request filtering. For information about configuring additional request filtering options, please see the following topic:

- [How to Use Request Filtering](../../manage/configuring-security/use-request-filtering.md)

<a id="02"></a>

## Configuring Request Filtering and WebDAV

<a id="02a"></a>

### Filtering File Extensions

Certain file extensions like ".config" and ".asax" are protected by the default request filtering **fileExtensions** collection. You can add additional entries to the list of file extensions in order to allow or block them for HTTP requests, and you can control whether this list applies to WebDAV requests. In this example you will use AppCmd block ".txt" files from being accessed, even though they might normally be accessible, and you will specify that WebDAV requests will be able to access all blocked file extensions.

1. Open a command prompt with full administrative privileges and change directory to your InetSrv folder:  

    [!code-console[Main](how-to-configure-webdav-with-request-filtering/samples/sample1.cmd)]
2. Use the following syntax to view the existing request filtering rules:  

    [!code-console[Main](how-to-configure-webdav-with-request-filtering/samples/sample2.cmd)]
3. Block access to ".txt" files by adding a specific file extension to the **fileExtensions** collection and specifying **false** for the **allowed** attribute using the following syntax:  

    [!code-console[Main](how-to-configure-webdav-with-request-filtering/samples/sample3.cmd)]
4. Allow WebDAV to access all blocked file types by setting the **applyToWebDAV** attribute for the **fileExtensions** collection to **false** using the following syntax:  

    [!code-console[Main](how-to-configure-webdav-with-request-filtering/samples/sample4.cmd)]

After completing the above steps the resulting code in the **fileExtensions** section of your applicationHost.config file should resemble the following example:

[!code-xml[Main](how-to-configure-webdav-with-request-filtering/samples/sample5.xml)]

#### Notes:

- You can use the above steps to block access to additional file extensions by adding them to the **fileExtensions** collection, or you can modify the syntax to allow specific files by specifying **true** for the **allowed** attribute.
- You can block all unknown file extensions by setting the **allowUnlisted** attribute for the **fileExtensions** collection to **false** using the following syntax:  

    [!code-console[Main](how-to-configure-webdav-with-request-filtering/samples/sample6.cmd)]
  
    > [!NOTE]
    > Setting this option requires that you specifically add each file extension before it can be accessed by non-WebDAV requests.
- You can use the above steps to block access for WebDAV requests by specifying **true** for the **applyToWebDAV** attribute.

<a id="02b"></a>

### Filtering Hidden Segments

Certain file segments like "web.config" and "App\_code" are hidden by the default request filtering **hiddenSegments** collection. You can add additional entries to the list of file segments in order to hide them for HTTP requests, and you can control whether this list applies to WebDAV requests. In this example, you will use AppCmd hide the "include" segment from HTTP requests, even though it would normally be visible, and you will specify that WebDAV requests will be able to access all hidden file segments.

1. Open a command prompt with full administrative privileges and change directory to your InetSrv folder:  

    [!code-console[Main](how-to-configure-webdav-with-request-filtering/samples/sample7.cmd)]
2. Block access to the "include" segment by adding a specific entry to the **hiddenSegments** collection using the following syntax:  

    [!code-console[Main](how-to-configure-webdav-with-request-filtering/samples/sample8.cmd)]
3. Allow WebDAV to access all blocked file types by setting the **applyToWebDAV** attribute for the **hiddenSegments** collection to **false** using the following syntax:  

    [!code-console[Main](how-to-configure-webdav-with-request-filtering/samples/sample9.cmd)]

After completing the above steps the resulting code in the **hiddenSegments** section of your applicationHost.config file should resemble the following example:

[!code-xml[Main](how-to-configure-webdav-with-request-filtering/samples/sample10.xml)]

#### Notes:

- You can use the above steps to hide additional file segments by adding them to the **hiddenSegments** collection.
- You can use the above steps to block access for WebDAV requests by specifying **true** for the **applyToWebDAV** attribute.

<a id="02c"></a>

### Filtering HTTP Verbs

The default request filtering **verbs** collection allows all unlisted HTTP verbs, even though some verbs may not be mapped to specific HTTP handlers. You can specify which HTTP verbs should be allowed or blocked by adding entries to this list, and you can control whether this list applies to WebDAV requests. In this example, you will use AppCmd to block the "DELETE" and "PUT" verb from HTTP requests, and you will specify that WebDAV requests will be able to use these verbs.

1. Open a command prompt with full administrative privileges and change directory to your InetSrv folder:  

    [!code-console[Main](how-to-configure-webdav-with-request-filtering/samples/sample11.cmd)]
2. Block access to the "DELETE" verb by adding a specific entry to the **verbs** collection and specifying **false** for the **allowed** attribute using the following syntax:  

    [!code-console[Main](how-to-configure-webdav-with-request-filtering/samples/sample12.cmd)]
3. Block access to the "PUT" verb by adding another specific entry to the **verbs** collection and specifying **false** for the **allowed** attribute using the following syntax:  

    [!code-console[Main](how-to-configure-webdav-with-request-filtering/samples/sample13.cmd)]
4. Allow WebDAV to access all HTTP verbs by setting the **applyToWebDAV** attribute for the **verbs** collection to **false** using the following syntax:  

    [!code-console[Main](how-to-configure-webdav-with-request-filtering/samples/sample14.cmd)]

After completing the above steps the resulting code in the **verbs** section of your applicationHost.config file should resemble the following example:

[!code-xml[Main](how-to-configure-webdav-with-request-filtering/samples/sample15.xml)]

#### Notes:

- You can use the above steps to block additional HTTP verbs by adding them to the **verbs** collection, or you can modify the syntax to allow specific verbs by specifying **true** for the **allowed** attribute.
- You can block all unknown HTTP verbs by setting the **allowUnlisted** attribute for the **verbs** collection to **false** using the following syntax:  

    [!code-console[Main](how-to-configure-webdav-with-request-filtering/samples/sample16.cmd)]
  
    > [!NOTE]
    > Setting this option requires that you specifically add each HTTP verb before it can be accessed by non-WebDAV requests.
- You can use the above steps to block access for WebDAV requests by specifying **true** for the **applyToWebDAV** attribute.

<a id="03"></a>

## Summary

This document has shown you the following concepts:

- [The basics of Request Filtering](how-to-configure-webdav-with-request-filtering.md#01)
- [Configuring Request Filtering with WebDAV](how-to-configure-webdav-with-request-filtering.md#02)

    - [Filtering File Extensions](how-to-configure-webdav-with-request-filtering.md#02a)
    - [Filtering Hidden Segments](how-to-configure-webdav-with-request-filtering.md#02b)
    - [Filtering HTTP Verbs](how-to-configure-webdav-with-request-filtering.md#02c)

### More Information

For additional information about using WebDAV, please see the following articles:

- [Installing and Configuring WebDAV on IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=105146)
- [How to manage WebDAV using AppCmd](https://go.microsoft.com/fwlink/?LinkId=108319)
