---
title: "Quick Guide for Shared Hosting Deployment"
author: walterov
description: "This article provides a basic overview of the manual steps to deploy a front-end Web server running IIS 7.5 or above for the Shared Hosting scenario. It also..."
ms.date: 12/01/2007
ms.assetid: e64bd116-efe3-41c2-9602-6427ad7c0361
msc.legacyurl: /learn/web-hosting/configuring-servers-in-the-windows-web-platform/quick-guide-for-shared-hosting-deployment
msc.type: authoredcontent
---
Quick Guide for Shared Hosting Deployment
====================
by [Walter Oliver](https://github.com/walterov)

## Introduction

This article provides a basic overview of the manual steps to deploy a front-end Web server running IIS 7.5 or above for the Shared Hosting scenario. It also includes key per-site configuration settings. These steps are described in more detail in the [Web Server For Shared Hosting](../web-server-for-shared-hosting/index.md) and [File Server For Content Storage](index.md) articles of this guide.

## Web Server Pre-Setup

Before configuring permissions on the file server, you must join the Web server to an Active Directory domain controller.

> [!NOTE]
> It is possible to not use domain accounts, but the setup in this shared hosting architecture assumes a domain-joined machine. Certain things need to be changed for non-domain scenarios (if you are using content on a remote file server, the same user account with the same password must exist on both the Web server and the file server, for instance).

1. Join the Web server to the Active Directory domain controller. This is not required if you are setting up a standalone server
2. If you will be storing content or configuration on a remote file server, configure the MaxCmds registry key on the Web server -- see [SMB Commands Registry Keys](../web-server-for-shared-hosting/smb-commands-registry-keys_198.md).
3. If you will be using a Windows-based file server, add the MaxMptCt and MaxWorkItems registry keys on the file server -- see [SMB Command Registry Keys](smb-commands-registry-keys_196.md).

## Web Server Setup

1. [Install the Web Server Role](../web-server-for-shared-hosting/installing-the-web-server-role.md) - IIS. 

    - Note: Site provisioning is covered in [Provisioning IIS Sites for Shared Hosting](../../manage/creating-websites/provisioning-iis-7-sites-for-shared-hosting.md).
2. Run AppCmd to create an initial [Backup](../web-server-for-shared-hosting/create-a-backup-with-appcmd.md).

    [!code-console[Main](quick-guide-for-shared-hosting-deployment/samples/sample1.cmd)]
3. Configure [32-bit mode worker processes](../web-server-for-shared-hosting/32-bit-mode-worker-processes.md) globally on the server.

    [!code-console[Main](quick-guide-for-shared-hosting-deployment/samples/sample2.cmd)]
4. Configure the [Application Pool Identity as Anonymous User](../web-server-for-shared-hosting/application-pool-identity-as-anonymous-user.md) (anonymous user is to be the worker process identity) globally on the server.

    [!code-console[Main](quick-guide-for-shared-hosting-deployment/samples/sample3.cmd)]
5. Configure [Default Documents](../web-server-for-shared-hosting/default-documents.md) at the server level in IIS Manager.
6. [Select W3C Fields to Log](http://technet2.microsoft.com/windowsserver2008/en/library/844c691d-ea3d-49d8-aa53-874f401915261033.mspx?mfr=true) at the server level in IIS Manager.
7. Configure the [dynamicIdleThreshold](../web-server-for-shared-hosting/dynamicidlethreshold.md) property.
8. Configure [Dynamic Compression](../web-server-for-shared-hosting/dynamic-compression.md).
9. Enable [Remote Web Service Management](../../manage/remote-administration/remote-administration-for-iis-manager.md) in IIS Manager. 

    > [!NOTE]
    > If you are using IIS Manager Users and the content is stored in a file share (UNC), set WMSVC to run as a custom identity that has read/write access to the share. For details on WMSVC's read/write access actions see [Remote Administration Behavior Matrix](../../manage/remote-administration/remote-administration-behavior-matrix.md).
10. Enable the WMSVC port within the local firewall on your Web server by opening the Control Panel and double-clicking the Windows Firewall icon. Then select "Change firewall settings" and add the port for the service.

    > [!NOTE]
    > The firewall is enabled by default and you must add the default port (8172) or custom port if you chose one.
11. Create a custom [trust level based on Medium trust](../web-server-for-shared-hosting/aspnet-20-35-shared-hosting-configuration.md). 

    - Set unrestricted true for WebPermission.
    - Add custom trust to Web.config and lock it.
12. Enable Full trust to the remote file share. See [Share and NTFS Permissions](configuring-share-and-ntfs-permissions.md) for more details.

    [!code-console[Main](quick-guide-for-shared-hosting-deployment/samples/sample4.cmd)]
13. Open `%windir%\Microsoft.NET\Framework\{version}\aspnet.config` and set the gcServer enabled to false instead of true.

    [!code-xml[Main](quick-guide-for-shared-hosting-deployment/samples/sample5.xml)]
14. Disable ASP template cache.

    [!code-console[Main](quick-guide-for-shared-hosting-deployment/samples/sample6.cmd)]
15. Run AppCmd to create a [Backup](../web-server-for-shared-hosting/create-a-backup-with-appcmd.md) after all successful changes.

    [!code-console[Main](quick-guide-for-shared-hosting-deployment/samples/sample7.cmd)]
16. Enable [Shared Configuration](shared-configuration_211.md), if needed for your environment.
17. Create a backup schedule.