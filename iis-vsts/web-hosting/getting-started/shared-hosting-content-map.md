---
title: "Shared Hosting Content Map"
author: walterov
description: "As a hoster, you know that managing a shared hosting environment is about offering customers an inexpensive place to host their sites and services, while at..."
ms.date: 01/08/2009
ms.assetid: 45ffafee-6469-4be7-a648-da15d8ece438
msc.legacyurl: /learn/web-hosting/getting-started/shared-hosting-content-map
msc.type: authoredcontent
---
Shared Hosting Content Map
====================
by [Walter Oliver](https://github.com/walterov)

## Introduction

As a hoster, you know that managing a shared hosting environment is about offering customers an inexpensive place to host their sites and services, while at the same time optimizing your infrastructure and overhead to remain profitable. Typical shared hosting environments include front-end servers for routing requests to their proper content locations, back-end web servers for storing and indexing content, web management services that make it possible for customers to publish and manage their content quickly, and large deployments of web server farms that share a common site configuration synchronized across multiple web servers within the farm. With all that in the mix, it's important to have a solid solution for managing the security, site density, quality of service, and performance optimization of your hosting environment.

This portal page is designed to help you create a service-oriented shared hosting infrastructure by combining a set of products, technologies, and service offerings using Microsoft best practices and guidance. Microsoft offers a complete technology platform for shared hosters to deliver all the components necessary for deploying a highly available, highly scalable, shared hosting environment that includes the following components:

- **Back-end Web Servers.** The Windows Server 2008 R2 operating system includes Internet Information Services (IIS) 7.5, which is a unified web platform that integrates IIS, Microsoft ASP.NET, and Windows Communication Foundation.
- **Front-end Servers.** Microsoft Application Request Routing for IIS 7.5 and above is a proxy-based routing module that forwards HTTP requests to content servers based on HTTP headers, server variables, and load-balance algorithms.
- **Database Servers.** Microsoft SQL Server 2008 R2 data management software provides database services to the back-end web servers. SQL Server 2008 R2 also provides a large number of features to optimize security, manage tenant isolation, and improve the performance of the hosted SQL Server 2008 R2 deployment.
- **Web Server Farms.** Using IIS 7.5 and above, web farms are supported through the Shared Configuration feature, which makes it possible for administrators to store the IIS server configuration files on a remote share (NAS File Server). This provides the ability to replicate and synchronize configuration among the web servers in the farm.
- **Remote Administration.** With IIS 7 and above Remote Administration, hosters can empower their customers to manage their web applications and corresponding database(s) remotely.

To assist hosters who are building out a complete shared hosting solution using the technologies listed above, Microsoft has updated the Microsoft Hosting Deployment Accelerator to become a one-stop shop for hosting guidance on the Microsoft technology that includes documentation, scenario-based licensing guidance, and tools to plan, build, and sell your hosting business.

At the core of the Microsoft Hosting Deployment Accelerator is the latest version of the Dynamic Datacenter Toolkit for hosters, which helps you create scalable shared host offerings based on Microsoft Hyper-V and the Microsoft System Center Enterprise Suite.

You can find additional resources for understanding Windows Server 2008 R2 with Hyper-V technology, Microsoft System Center, Microsoft Dynamic Datacenter Toolkit for Hosting, and other related shared hosting topics on this portal.

## Content Map

<a id="plan"></a>

### [Planning the Web Hosting Architecture](../planning-the-web-hosting-architecture/index.md)

- [Shared Hosting Configuration](../planning-the-web-hosting-architecture/shared-hosting-configuration.md)
- [IIS Extensibility](../planning-the-web-hosting-architecture/iis-extensibility.md)

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
- [Publishing Components: FTP 7.5, WebDAV, and FPSE](../configuring-servers-in-the-windows-web-platform/publishing-components-ftp-70-webdav-and-fpse.md)
- [Web Platform Installer](../configuring-servers-in-the-windows-web-platform/microsoft-web-platform-installer-20.md)

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

- [Integrated vs Classic Mode](shared-hosting-content-map/_static/shared-hosting-content-map-238-iis7integratedpipelinemodevsclassicmode1.zip)
- [Breaking Changes for ASP.NET 4.0 Apps Running on IIS Integrated Mode](../migrate-to-the-microsoft-web-platform/breaking-changes-for-aspnet-4-apps-running-on-iis-7-integrated-mode.md)

<a id="provision"></a>

### [Provisioning and Managing](../../manage/provisioning-and-managing-iis/index.md)

- [IIS Management and Administration](../../manage/provisioning-and-managing-iis/iis-management-and-administration.md)
- [Hosted Services Control Panels](../../manage/provisioning-and-managing-iis/hosted-services-control-panels.md)
- [WebsitePanel](../../manage/provisioning-and-managing-iis/websitepanel.md)
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
- [Provisioning FTP 7.5 Sites](../../manage/creating-websites/provisioning-ftp-75-sites.md)

### [PowerShell Scripts and C# Code Samples](../configuring-components/powershell-scripts.md)

- [IIS 7 Configuration Reference with Code Samples](https://www.iis.net/configreference)
- [Managing IIS with the IIS PowerShell Snap-in](../../manage/powershell/index.md)
- [C# and PowerShell Scripts Samples](../configuring-components/powershell-scripts.md)
- [Provisioning Sample in C#](../../manage/provisioning-and-managing-iis/provisioning-sample-in-c.md)
- [Code Samples and Scripts](../../manage/provisioning-and-managing-iis/index.md)

<a id="using"></a>

### [Using Shared Hosting Environments](../using-shared-hosting-environments/index.md)

- [Creating, Updating, and Publishing Web applications with Visual Web Developer](../using-shared-hosting-environments/creating-and-publishing-web-applications-with-visual-web-developer.md)
- [Setting up Delegated Administration, Server and Client Experiences](../using-shared-hosting-environments/setting-up-delegated-administration-server-and-client-experiences.md)
- [Using Delegated Administration](../using-shared-hosting-environments/using-delegated-administration.md)
- [Web Platform Installer](../configuring-servers-in-the-windows-web-platform/microsoft-web-platform-installer-20.md)