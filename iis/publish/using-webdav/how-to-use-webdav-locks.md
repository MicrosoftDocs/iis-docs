---
title: "How to Use WebDAV Locks"
author: rmcmurray
description: "Introduction Microsoft has created a new WebDAV extension module that has been completely rewritten for Internet Information Services 7.0 (IIS 7.0) on Window..."
ms.date: 03/18/2009
ms.assetid: 1f2dc214-9214-4f68-bde3-8743bc49dfe8
msc.legacyurl: /learn/publish/using-webdav/how-to-use-webdav-locks
msc.type: authoredcontent
---
# How to Use WebDAV Locks

by [Robert McMurray](https://github.com/rmcmurray)

<a id="00"></a>

## Introduction

Microsoft has created a new WebDAV extension module that has been completely rewritten for Internet Information Services 7.0 (IIS 7.0) on Windows Server© 2008. This new WebDAV extension module incorporates many new features that enable Web authors to publish content more easily than before, and offers Web administrators more security and configuration options.

One of the features of WebDAV 7.5 is the ability to create WebDAV locks for content, which are most often used to lock files when updating content in your Web site.

This document walks you through how to configure the new WebDAV module to enable WebDAV locks on your Web server, which are used by some WebDAV clients.

## Prerequisites

The following items are required to complete the procedures in this article:

- IIS 7.0 or later must be installed on your server, and the following must be configured:

  - The Default Web Site that is created by the IIS installation must still exist.
  - The Internet Information Services (IIS) Manager must be installed.
- The new WebDAV 7.5 module must be installed. For information about the installation of the new WebDAV module, please see the following document:

  - [Installing and Configuring WebDAV on IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=105146)

> [!NOTE]
> You must make sure that you have full administrative user rights before you follow the steps in this document. This is best accomplished by using one of two methods:

- Log on to your computer using the local administrator account.
- If you are logged on using an account with administrative user rights that is not the local administrator account, open IIS Manager and all command prompt sessions using the "Run as Administrator" option.

The above condition is required because the User Account Control (UAC) security component in Windows Server 2008 prevents administrative access to the IIS 7.0 configuration settings. For more information about UAC, please see the [User Account Control](https://go.microsoft.com/fwlink/?LinkId=113664) article.

<a id="#01"></a>

## Enabling Locks Using IIS Manager

1. In IIS Manager, in the **Connections** pane, expand the **Sites** node in the tree, then click the **Default Web Site**.
2. As shown in the image below, double-click the **WebDAV Authoring Rules** feature.  
    ![](how-to-use-webdav-locks/_static/image2.jpg)
3. When the **WebDAV Authoring Rules** page is displayed, click the **WebDAV Settings** task in the **Actions** pane.  
    ![](how-to-use-webdav-locks/_static/image4.jpg)
4. When the **WebDAV Settings** page is displayed, specify the following options:

    - Set **Allow Locks** to **True**.
    - For **Lock Store**, choose "**webdav\_simple\_lock**" from the drop-down list.
    - Set **Require Lock for Writing** to your desired setting.  
        ![](how-to-use-webdav-locks/_static/image6.jpg)
5. Once you have completed steps 1-4, click **Apply** in the **Actions** pane.

<a id="#02"></a>

## Enabling Locks Using AppCmd

AppCmd.exe is a new command-line tool for administering IIS 7.0, and additional information about using this utility with IIS and WebDAV is located in the following document:

- [How to manage WebDAV using AppCmd](https://go.microsoft.com/fwlink/?LinkId=108319)

The following steps will walk you through how to use the AppCmd.exe utility to configure WebDAV"s lock settings.

> [!NOTE]
> The AppCmd.exe utility is located in the %*WinDir*%\System32\InetSrv folder.

### Configuring Lock Behaviors

#### Enabling WebDAV locks

To enable WebDAV locks, set the "enabled" attribute to "true" on the "locks" collection in the "authoring" section using the syntax in the following example:

[!code-console[Main](how-to-use-webdav-locks/samples/sample1.cmd)]

To disable WebDAV locks, use the syntax in the following example:

[!code-console[Main](how-to-use-webdav-locks/samples/sample2.cmd)]

#### Requiring locks for WebDAV

To ensure that multiple WebDAV clients do not try to update content at the same time, you can configure WebDAV to require locks. To do so, set the "requireLockForWriting" attribute to "true" on the "locks" collection in the "authoring" section by using the syntax in the following example:

[!code-console[Main](how-to-use-webdav-locks/samples/sample3.cmd)]

To configure WebDAV so that it does not require locks, use syntax in the following example:

[!code-console[Main](how-to-use-webdav-locks/samples/sample4.cmd)]

### Managing your Lock Provider

The WebDAV module is designed to work with a configurable set of lock providers, although currently only one provider named "webdav\_simple\_lock" has been developed. In the future, additional lock providers may be developed.

#### Configuring your lock provider

To specify the lock provider for a Web site, use the following syntax:

[!code-console[Main](how-to-use-webdav-locks/samples/sample5.cmd)]

#### Removing your lock provider

To remove the lock provider for a Web site, use the following syntax:

[!code-console[Main](how-to-use-webdav-locks/samples/sample6.cmd)]

## More Information

For additional information about how to use WebDAV, see the following articles:

- [Installing and Configuring WebDAV on IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=105146)
- [How to manage WebDAV using AppCmd](https://go.microsoft.com/fwlink/?LinkId=108319)
- [How to configure WebDAV and Request Filtering](https://go.microsoft.com/fwlink/?LinkId=108321)
