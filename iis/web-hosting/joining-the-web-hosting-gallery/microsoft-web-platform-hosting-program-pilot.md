---
title: "Microsoft Web Platform Hosting Program -Pilot | Microsoft Docs"
author: walterov
description: "As part of the Microsoft Web Platform Hosting Program, Microsoft created the Shared Hosting Guidance Content Map ; it references a set of guides, step-by-ste..."
ms.author: iiscontent
manager: soshir
ms.date: 02/18/2009
ms.topic: article
ms.assetid: 
ms.technology: iis-hosting
ms.prod: iis
msc.legacyurl: /learn/web-hosting/joining-the-web-hosting-gallery/microsoft-web-platform-hosting-program-pilot
msc.type: authoredcontent
---
Microsoft Web Platform Hosting Program -Pilot
====================
by [Walter Oliver](https://github.com/walterov)

## Introduction

As part of the Microsoft Web Platform Hosting Program, Microsoft created the [Shared Hosting Guidance Content Map](../getting-started/shared-hosting-content-map.md); it references a set of guides, step-by-step instructions, best practices, and script samples to guide in the planning, deployment, configuration, migration, and provisioning of Microsoft Web Platform technologies for Hosters. It provides a map to the latest content across the entire set of Microsoft documentation libraries and associated sample scripts relevant to hosting professionals. It is technical guidance documentation intended to lower operational costs while increasing average revenue per user. The entire content is available for download ([download I](https://go.microsoft.com/fwlink/?LinkID=142353&amp;clcid=0x409) and [download II](https://go.microsoft.com/fwlink/?LinkID=143140&amp;clcid=0x409)).

This document provides an offline snapshot of the [Shared Hosting Guidance Content Map](../getting-started/shared-hosting-content-map.md) web page as well as references to the following offline content:

1. [Shared Hosting Guidance](https://go.microsoft.com/fwlink/?LinkID=143142&amp;clcid=0x409): is an overview and the best starting point in the document collection. The live and most up to date version of this material can be found in the [Shared Hosting Guidance Content Map](../getting-started/shared-hosting-content-map.md) web page.
2. [Developing with Shared Hosting](../using-shared-hosting-environments/creating-and-publishing-web-applications-with-visual-web-developer.md): is a video that demonstrates how developers and web hosting customers can use, create, and edit web sites hosted on the Microsoft Web Platform. Developers will be able to learn about the development and publishing environment, and Hosters will learn about the experience that their customers go through when interacting with their services. You will find:

    - Steps a developer should follow to host their applications in a Shared Hosting Environment.
    - Typical activities performed when interacting with a shared hosting provider.
    - Publishing Content using FTP from Internet Explorer and Windows Explorer.
    - Using Visual Web Developer (VWD) to connect to a hoster FTP site and deploy the application.
    - Installing and configuring IIS Manager for Remote Administration of the web site.
    - Installing IIS Manager new Modules.
    - Using IIS Manager Remote Administration.
    - Modifying and publishing an update for the application.
    - Deploying the application database (ASP.NET Membership database).
3. [Setting up Delegated Administration Server and Client Experience](../using-shared-hosting-environments/setting-up-delegated-administration-server-and-client-experiences.md): is a video that demonstrates the Hoster and User experiences of setting up Delegated Administration. Hosters will learn how to setup Delegated Administration and what their users will need to set it up in their client computers. You will find: 

    - Introduction to Delegated Administration (also known as Remote Administration), it explains why it is useful in hosting scenarios.
    - Configuring Delegated Administration at the server through the Management Service UI module
    - Creating an IIS Manager User and assigning permissions to it. Explaining the difference between an IIS User and a Windows user account.
    - Uses an Windows XP client machine to remotely administer the site through delegated administration.
    - Installing IIS in XP.
    - Connect to the server/site from the client.
Installs extensions, explaining the server and client experience.
4. [Using Delegated Administration](../using-shared-hosting-environments/using-delegated-administration.md) is a video that provides a specific example of delegating a particular feature and how the user can take advantage of it. Hosters will learn how a currently blocked feature can be unblocked and their users can learn how to take advantage of the newly unblocked feature. You will find: 

    - A detailed explanation of using an actual configuration feature for administration of the site, error pages.
    - Shows the client experience when the feature is locked for a site.
    - The server experience when unlocking a feature for a site.
    - Shows the client experience of configuring the newly unlocked feature, error page setting for the site.
5. Within the content donwload ([download I](https://go.microsoft.com/fwlink/?LinkId=142353) and [download II](https://go.microsoft.com/fwlink/?LinkID=143140&amp;clcid=0x409)) you will find critical technology areas like **IIS**, **SQL Server 2008**, **Hyper-V**, and **System Center** sections subdivided into 4 major subsections: 

    - *Learn*: An in-depth technical drill down on the particular technology.
    - *Engage*: Explains the value of the technology.
    - *Deploy*: Instructions and pointers from where to download relevant bits.
    - *Market*: Collateral that Hosters and their Sales force can use to take an offering to market.
6. Content To Share with End Users:

- [Developing with Shared Hosting](../using-shared-hosting-environments/creating-and-publishing-web-applications-with-visual-web-developer.md) video.
- [Setting up Delegated Administration Server and Client Experience](../using-shared-hosting-environments/setting-up-delegated-administration-server-and-client-experiences.md) video.
- [Using Delegated Administration](../using-shared-hosting-environments/using-delegated-administration.md) video.
- [Administering your Site Remotely](../verifying-the-deployment/verifying-remote-administration.md).
- [Deploying a ASP.NET](../verifying-the-deployment/verifying-the-developer-experience-aspnet.md).
- [Deploying a PHP Application](../verifying-the-deployment/verifying-remote-administration.md).

## Step by Step Hosting Instructions

### Content Map

- [Planning the Web Hosting Architecture - [Deploying the Windows Web Platform in Shared Hosting Environments](microsoft-web-platform-hosting-program-pilot.md#deploying) - [Verifying the Deployment](microsoft-web-platform-hosting-program-pilot.md#verify) - [Installing Infrastructure Components](microsoft-web-platform-hosting-program-pilot.md#infra) - [Configuring IIS](microsoft-web-platform-hosting-program-pilot.md#configiis) - [Migrating](microsoft-web-platform-hosting-program-pilot.md#migrate) - [Provisioning and Managing](microsoft-web-platform-hosting-program-pilot.md#provision) - [PowerShell Scripts and C# Code Samples](microsoft-web-platform-hosting-program-pilot.md#scripts) - [Using Shared Hosting Environments](microsoft-web-platform-hosting-program-pilot.md#using)](microsoft-web-platform-hosting-program-pilot.md#plan)

<a id="plan"></a>

### [Planning the Web Hosting Architecture](../planning-the-web-hosting-architecture/index.md)

- [Shared Hosting Configuration](../planning-the-web-hosting-architecture/shared-hosting-configuration.md)
- [IIS Extensibility](../planning-the-web-hosting-architecture/iis-extensibility.md)
- [MIX08: Bringing Hosters and Developers Together with IIS](../using-shared-hosting-environments/mix08-bringing-hosters-and-developers-together-with-iis7.md)

<a id="deploying"></a>

### [Deploying the Windows Web Platform in Shared Hosting Environments](../configuring-servers-in-the-windows-web-platform/index.md)

- [Quick Guide for Shared Hosting Deployment](../configuring-servers-in-the-windows-web-platform/quick-guide-for-shared-hosting-deployment.md)
- [Web Server for Shared Hosting](../web-server-for-shared-hosting/index.md)

    - [IIS Components for Shared Hosting](../web-server-for-shared-hosting/iis-components-for-shared-hosting.md)
    - [Installing the Web Server Role](../web-server-for-shared-hosting/installing-the-web-server-role.md)
    - [Configuring IIS for Shared Hosting](../web-server-for-shared-hosting/index.md)

        - [32-bit Mode Worker Processes](../web-server-for-shared-hosting/32-bit-mode-worker-processes.md)
        - [Application Pool Identity as Anonymous User](../web-server-for-shared-hosting/application-pool-identity-as-anonymous-user.md)
        - [Default Documents](../web-server-for-shared-hosting/default-documents.md)
        - [HTTP Response Cache](../web-server-for-shared-hosting/http-response-cache.md)
        - [dynamicIdleThreshold](../web-server-for-shared-hosting/dynamicidlethreshold.md)
        - [Dynamic Compression](../web-server-for-shared-hosting/dynamic-compression.md)
        - [Delegated Administration](../web-server-for-shared-hosting/delegated-administration.md)
        - [Delegating errorMode in httpErrors](../web-server-for-shared-hosting/delegating-errormode-in-httperrors.md)
    - [ASP.NET](../web-server-for-shared-hosting/aspnet-20-35-shared-hosting-configuration.md)
    - [URL Rewrite for Hosters](../web-server-for-shared-hosting/url-rewrite-for-hosting-providers.md)
    - [Database Manager for Hosters](../web-server-for-shared-hosting/database-manager-for-hosters.md)
    - [Administration Pack](../web-server-for-shared-hosting/administration-pack.md)
    - [FastCGI with PHP](../web-server-for-shared-hosting/fastcgi-with-php.md)
    - [ASP](../web-server-for-shared-hosting/asp.md)
    - [Configuring IIS for Silverlight Applications](../web-server-for-shared-hosting/configuring-iis-for-silverlight-applications.md)
    - [SMB Commands Registry Keys](../web-server-for-shared-hosting/smb-commands-registry-keys_198.md)
    - [Backup](../web-server-for-shared-hosting/create-a-backup-with-appcmd.md)
- [File Server For Content Storage](../configuring-servers-in-the-windows-web-platform/index.md)

    - [Separate Partitions for Improved Performance](../configuring-servers-in-the-windows-web-platform/preparing-the-file-serve-deployment.md)
    - [Share and NTFS Permissions](../configuring-servers-in-the-windows-web-platform/configuring-share-and-ntfs-permissions.md)
    - [Directory Quotas and FSRM](../configuring-servers-in-the-windows-web-platform/enabling-directory-quotas.md)
    - [SMB Command Registry Keys](../configuring-servers-in-the-windows-web-platform/smb-commands-registry-keys_196.md)
- [Web Farm Support](../configuring-servers-in-the-windows-web-platform/index.md)

    - [Application Request Routing for Shared Hosting](../configuring-servers-in-the-windows-web-platform/application-request-routing-arr-20-for-shared-hosting.md)
    - [Shared Configuration](../configuring-servers-in-the-windows-web-platform/shared-configuration_211.md)
    - [Offline Files for Shared Configuration](../configuring-servers-in-the-windows-web-platform/offline-files-for-shared-configuration.md)
    - [Network Load Balancing](../configuring-servers-in-the-windows-web-platform/network-load-balancing.md)
- [Database Servers](../configuring-servers-in-the-windows-web-platform/index.md)

    - [SQL 2008 for Hosters](../configuring-servers-in-the-windows-web-platform/sql-2008-for-hosters.md)
    - [SQL Server 2005](../configuring-servers-in-the-windows-web-platform/sql-server-2005.md)
    - [MySQL Server](../../application-frameworks/install-and-configure-php-on-iis/install-and-configure-mysql-for-php-applications-on-iis-7-and-above.md)
- [Guide to Deploy FTP and Publish with VWD](../configuring-servers-in-the-windows-web-platform/guide-to-deploy-ftp-and-publish-with-vwd.md)
- [Publishing Components: FTP 7.0, WebDAV, and FPSE](../configuring-servers-in-the-windows-web-platform/publishing-components-ftp-70-webdav-and-fpse.md)

<a id="Verify"></a>

### [Verifying the Deployment](../verifying-the-deployment/index.md)

- [Verifying Remote Administration](../verifying-the-deployment/verifying-remote-administration.md)
- [Verifying the Developer Experience – ASP.NET](../verifying-the-deployment/verifying-the-developer-experience-aspnet.md)
- [Verifying the Developer Experience - PHP](../verifying-the-deployment/verifying-the-developer-experience-php.md)

<a id="infra"></a>

### [Installing Infrastructure Components](../installing-infrastructure-components/index.md)

- [Hyper-V Guides](../installing-infrastructure-components/hyper-v-guides.md)
- [System Center Solutions (VMM &amp; SCOM)](../installing-infrastructure-components/system-center-solutions-vmm-amp-scom.md)
- [DNS Server](../installing-infrastructure-components/dns-server.md)
- [Active Directory DS Forest](../installing-infrastructure-components/active-directory-ds-forest.md)
- [Introduction to Deploying Windows Server 2008](../installing-infrastructure-components/introduction-to-deploying-windows-server-2008-r2.md)

<a id="configiis"></a>

### [Configuring IIS](../configuring-components/index.md)

- [The Configuration System in IIS](../../get-started/planning-your-iis-architecture/the-configuration-system-in-iis-7.md)
- [C# and PowerShell Scripts Samples](../configuring-components/powershell-scripts.md)
- [Configuring Server Components](../configuring-components/configuring-server-components.md)
- [Using WSRM to manage IIS AppPool CPU Utilization](../../manage/managing-performance-settings/using-wsrm-to-manage-iis-7-apppool-cpu-utilization.md)
- [Enabling LINQ with ASP.NET](../configuring-components/deploying-linq-with-net-35.md)

<a id="migrate"></a>

### [Migrating](../migrate-to-the-microsoft-web-platform/index.md)

- [Integrated vs Classic Mode](microsoft-web-platform-hosting-program-pilot/_static/microsoft-web-platform-hosting-program---pilot-238-iis7integratedpipelinemodevsclassicmode1.zip)
- [Breaking Changes for ASP.NET 2.0 Apps Running on IIS Integrated Mode](../migrate-to-the-microsoft-web-platform/breaking-changes-for-aspnet-4-apps-running-on-iis-7-integrated-mode.md)

<a id="provision"></a>

### [Provisioning and Managing](../../manage/provisioning-and-managing-iis/index.md)

- [IIS Management and Administration](../../manage/provisioning-and-managing-iis/iis-management-and-administration.md)
- [Provisioning IIS](../../manage/provisioning-and-managing-iis/index.md)

    - [Provisioning IIS Sites](../../manage/creating-websites/provisioning-iis-7-sites.md)
    - [Provisioning Options in IIS](../../manage/provisioning-and-managing-iis/provisioning-options-in-iis-7.md)
    - [Using Managed APIs in IIS](../../manage/provisioning-and-managing-iis/using-managed-apis-in-iis-7.md)
    - [Shared Configuration and Remote Provisioning](../../manage/provisioning-and-managing-iis/shared-configuration-and-remote-provisioning.md)
    - [Provisioning IIS Sites for Shared Hosting](../../manage/creating-websites/provisioning-iis-7-sites-for-shared-hosting.md)
- [Provisioning and Managing Samples](../../manage/provisioning-and-managing-iis/index.md)

    - [Provisioning Sample in C#](../../manage/provisioning-and-managing-iis/provisioning-sample-in-c.md)
    - [Hosting Services Code Sample](../../manage/provisioning-and-managing-iis/index.md)

        - [Services Overview](../../manage/provisioning-and-managing-iis/services-overview.md)
        - [Services Implementation](../../manage/provisioning-and-managing-iis/setting-up-components.md)
        - [Consuming the Services](../../manage/provisioning-and-managing-iis/consuming-the-services.md)
    - [Code Samples and Scripts](../../manage/provisioning-and-managing-iis/index.md)

        - [Microsoft.Web.Administration](../../manage/provisioning-and-managing-iis/microsoftwebadministration.md)
        - [IIS WMI Provider](../../manage/provisioning-and-managing-iis/iis-7-wmi-provider.md)
        - [AppCmd.exe](../../manage/provisioning-and-managing-iis/appcmdexe.md)
        - [Other Managed Code Samples](../../manage/provisioning-and-managing-iis/other-managed-code-samples.md)
- [Provisioning FTP 7.0 Sites](../../manage/creating-websites/provisioning-ftp-75-sites.md)

<a id="scripts"></a>

### PowerShell Scripts and C# Code Samples

- [IIS 7.0 Configuration Reference with Code Samples](https://www.iis.net/configreference)
- [Managing IIS with the IIS PowerShell Snap-in](../../manage/powershell/index.md)
- [C# and PowerShell Scripts Samples](../configuring-components/powershell-scripts.md)
- [Provisioning Sample in C#](../../manage/provisioning-and-managing-iis/provisioning-sample-in-c.md)
- [Code Samples and Scripts](../../manage/provisioning-and-managing-iis/index.md)

<a id="using"></a>

### [Using Shared Hosting Environments](../using-shared-hosting-environments/index.md)

- [Creating, Updating, and Publishing Web applications with Visual Web Developer](../using-shared-hosting-environments/creating-and-publishing-web-applications-with-visual-web-developer.md)
- [Administering your Site Remotely](../verifying-the-deployment/verifying-remote-administration.md)
- [Deploying a ASP.NET](../verifying-the-deployment/verifying-the-developer-experience-aspnet.md)
- [Deploying a PHP Application](../verifying-the-deployment/verifying-remote-administration.md)

Please send your questions and feedback to [iisnet@microsoft.com](mailto:iisnet@microsoft.com)**.**