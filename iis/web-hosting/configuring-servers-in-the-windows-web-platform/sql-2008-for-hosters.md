---
title: "SQL 2008 for Hosters | Microsoft Docs"
author: rick-anderson
description: "The purpose of this article is to provide information about deploying and optimizing SQL Server 2008 for shared and dedicated hosting environments. It provid..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 01/13/2009
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/web-hosting/configuring-servers-in-the-windows-web-platform/sql-2008-for-hosters
msc.type: authoredcontent
---
SQL 2008 for Hosters
====================
by Walter Oliver

## Introduction

The purpose of this article is to provide information about deploying and optimizing SQL Server 2008 for shared and dedicated hosting environments. It provides links to videos and documents that cover best practices for deployment, configuration, management, security, programmability, tenant isolation, and performance optimization of a hosted SQL Server 2008 deployment. It constitutes a complete map of guidance and detailed information, including references to SQL Server architecture information and sample scripts for provisioning users and databases in shared hosting scenarios. It emphasizes detailed descriptions of the new features that make SQL Server an ideal database platform for the Web.

Notice that Microsoft has produced a set of SQL Server SKUs targeted for various scenarios, including Web Application Hosting. Here is the SKU feature comparison table:

[![](sql-2008-for-hosters/_static/image3.jpg)](sql-2008-for-hosters/_static/image1.jpg)

### Contents

[SQL Server 2008 Guidance for Hosters](sql-2008-for-hosters.md#sqlguide)

[High Availability](sql-2008-for-hosters.md#ha)

[Management](sql-2008-for-hosters.md#management)

[Performance Monitoring and Troubleshooting](sql-2008-for-hosters.md#perfmon)

[PHP Support in SQL Server 2008](sql-2008-for-hosters.md#php)

[T-SQL Programmability](sql-2008-for-hosters.md#tsql)

[Reporting Services (SSRS)](sql-2008-for-hosters.md#reporting)

[Security](sql-2008-for-hosters.md#security)

[SQL Server Data Services](sql-2008-for-hosters.md#dataservices)

[Unstructured Data Storage](sql-2008-for-hosters.md#undatastr)

[Upgrading to SQL Server 2008](sql-2008-for-hosters.md#upgrade)

[Planning, Deploying, and Running SQL Server 2008 Whitepapers](sql-2008-for-hosters.md#wp)

[Conclusion](sql-2008-for-hosters.md#conclusion)

<a id="sqlguide"></a>

## SQL Server 2008 Guidance for Hosters

This [download](https://download.microsoft.com/download/d/1/f/d1f05c2e-0741-442d-859e-9417b377fdfa/The%20architectural%20view%20of%20SQL%20Server.zip) provides best practices and considerations for hosting service providers who are interested in deploying SQL Server 2008 in multi-tenant environments. It contains information about:

- SQL Server Architecture: Relational engine, integration, analysis, reporting services, scalability, and high availability.
- SQL Server 2008 for Hosters Guidance, which is a guide about how to:

    - Deploy and configure a SQL Server computer:

        - Configure Windows for large amounts of memory.
        - Provision multiple instances of SQL Server.
        - Use the AWE API for servers with large amounts of memory.
        - Integrate CLR with SQL Server.
        - Query cost governor limits.
        - Provision security.
    - Configure the SQL Server surface area
    - Provision users 

        - Provision users and databases
        - Create assemblies using stored procedures

The [SQL Server 2008 for Hosters Guidance Video](https://mediadl.microsoft.com/mediadl/IISNET/Media/SQL%20Server%202008%20for%20Hosters.wmv) provides an overview of SQL Server 2008 for hosters. It is an introduction to the various editions of SQL Server, in particular the Web edition. The video gives guidelines to determine which editions are right for which scenarios. It highlights key features such as policy-based management, PowerShell, data warehousing, resource governor, transparent data encryption, auditing, backup, Hyper-V and SQL licensing, migration and upgrades, SQL Server driver for PHP 2005, Database Publishing Wizard, and Database Publishing Service.

<a id="ha"></a>

## High Availability

The [Clustering Microsoft SQL Server with Windows Server 2008 presentation](https://download.microsoft.com/download/d/1/f/d1f05c2e-0741-442d-859e-9417b377fdfa/Clustering%20Microsoft%20SQL%20Server%20With%20Windows%20Server%202008.zip) and [video](https://mediadl.microsoft.com/mediadl/IISNET/Media/Windows%20Server%20Infrastructure%20Clustering%20Microsoft%20SQL%20Server%20with%20Windows%20Server%202008.wmv) provide an overview and demos of the considerations for implementing SQL Server failover clusters on Windows Server 2008, and details about SQL Server 2008 failover clustering.

<a id="management"></a>

## Management

The following videos and presentations provide details about key manageability features of SQL Server 2008:

- Videos:

    - [24–hour Predictable Response to Your Users](https://mediadl.microsoft.com/mediadl/IISNET/Media/24hrs%20Predictable%20Response%20to%20Your%20Users%20.wmv) provides:

        - An overview of the resource governor that can organize database workload.
        - How-to information about making statement execution predictable through the use of plan freezing.
    - [Advanced Microsoft SQL Server PowerShell Tips and Tricks](https://mediadl.microsoft.com/mediadl/IISNET/Media/Advanced%20Microsoft%20SQL%20Server%20PowerShell%20Tips%20and%20Tricks.wmv) provides:

        - An overview of PowerShell.
        - Details about the SQL Server PowerShell Provider.
    - [Microsoft SQL Server 2008 Policy-Based Management](https://mediadl.microsoft.com/mediadl/IISNET/Media/Microsoft%20SQL%20Server%202008%20Policy-Based%20Management.wmv) provides:

        - An overview of policy-based management (PBM).
        - Building advanced policy conditions.
        - How-to information about using PowerShell with PBM.
    - [Microsoft SQL Server Backup and Disaster Recovery Features](https://mediadl.microsoft.com/mediadl/IISNET/Media/Microsoft%20SQL%20Server%20Backup%20and%20Disaster%20Recovery%20Features.wmv) provides:

        - An overview of disaster scenarios (site or server down, data corruption, and user errors).
        - Availability requirements for the various disaster scenarios.
        - SQL Server disaster recovery features:

            - Database Mirroring
            - Failover Clusters
            - Log Shipping
            - Backup/Restore
- [Presentations on SQL Server Management](https://download.microsoft.com/download/d/1/f/d1f05c2e-0741-442d-859e-9417b377fdfa/Microsoft%20SQL%20Server%20Backup%20and%20Disaster%20Recovery%20Features.zip)

<a id="perfmon"></a>

## Performance Monitoring and Troubleshooting

SQL Server 2008 provides new features for monitoring servers and troubleshooting issues. The following videos and presentation provide details on these areas.

- Videos:

    - [Advanced Troubleshooting with Extended Events](https://mediadl.microsoft.com/mediadl/IISNET/Media/Advanced%20Troubleshooting%20with%20Extended%20Events.wmv) provides:

        - An overview of the SQL Server Extended Events feature and architecture, and troubleshooting efficiency and visibility into SQL Server internals.
        - An understanding of the Extended Events architecture.
        - How-to information about using Extended Events to monitor and diagnose issues in SQL Server.
    - [Performance Monitoring Using SQL Server Management Studio](https://mediadl.microsoft.com/mediadl/IISNET/Media/Performance%20Monitoring%20Using%20SQL%20Server%20Management%20Studio.wmv) provides:

        - Definitions of the new tools and features.
        - Feature demonstrations.
        - Information about internals and architecture.
        - Information about planning and implementation.
- [Presentation on SQL Server Extended Events and Performance Monitoring](https://download.microsoft.com/download/d/1/f/d1f05c2e-0741-442d-859e-9417b377fdfa/SQL%20Server%202008-performance%20monitoring%20using%20management%20studio.zip)

<a id="php"></a>

## PHP Support in SQL Server 2008

The SQL Server driver for PHP is designed to enable reliable, scalable integration with SQL Server for PHP applications deployed on the Windows platform. The SQL Server 2005 driver for PHP is a PHP 5 extension that allows for the reading and writing of SQL Server data from within PHP scripts. The extension provides a procedural interface for accessing data in all editions of SQL Server 2005 and SQL Server 2008. It makes use of PHP features, including PHP streams, to read and write large objects. Download the SQL Server 2005 driver for PHP here: &lt;link: [https://www.microsoft.com/sqlserver/2005/en/us/PHP-Driver.aspx](https://www.microsoft.com/sqlserver/2005/en/us/PHP-Driver.aspx)&gt;.   
Source code is available here: &lt;link: [http://www.codeplex.com/SQL2K5PHP](http://www.codeplex.com/SQL2K5PHP)&gt;.   
A link to this paper, &lt;link: [https://msdn.microsoft.com/en-us/library/cc793139(SQL.90).aspx](https://msdn.microsoft.com/en-us/library/cc793139(SQL.90).aspx)&gt;, explains how to load and configure the driver, and discusses how to leverage several of the features. Complete information and samples are available on the following sites:

- MSDN Library &lt;link: [https://msdn.microsoft.com/en-us/library/cc296221.aspx](https://msdn.microsoft.com/en-us/library/cc296221.aspx)&gt;
- Forums at MSDN &lt;link: [http://forums.microsoft.com/msdn/ShowForum.aspx?ForumID=2108&amp;SiteID=1](http://forums.microsoft.com/msdn/ShowForum.aspx?ForumID=2108&amp;SiteID=1)&gt;
- SQL Server Driver Team Blog &lt;link: [https://blogs.msdn.com/sqlphp/](https://blogs.msdn.com/sqlphp/)&gt;

<a id="tsql"></a>

## T-SQL Programmability

The following [video](https://mediadl.microsoft.com/mediadl/IISNET/Media/New%20T-SQL%20Programmability%20Features%20in%20Microsoft%20SQL%20Server%202008.wmv) and [presentation](https://download.microsoft.com/download/d/1/f/d1f05c2e-0741-442d-859e-9417b377fdfa/New%20T-SQL%20Programmability%20Features%20in%20Microsoft%20SQL%20Server%202008.zip) provide details about the new SQL Server programmability features, including:

- New date, time, table, and user-defined data types
- New SQL query language features
- New procedural language features

<a id="reporting"></a>

## Reporting Services (SSRS)

Microsoft® SQL Server 2008 Reporting Services (SSRS) provides a full range of ready-to-use tools and services to create, deploy, and manage reports, as well as programming features to extend and customize reports.

The following [video](https://mediadl.microsoft.com/mediadl/IISNET/Media/SQL%20Server%202008%20Reporting%20Services%20Architecture%20Overview.wmv) and [presentation](https://download.microsoft.com/download/d/1/f/d1f05c2e-0741-442d-859e-9417b377fdfa/SQL%20Server%202008%20Reporting%20Services%20Architecture%20Overview.zip) provide details about the new SQL Server Reporting Services features, including:

- Service architecture
- Updates to management tools
- Scalability and memory management
- Deployment and upgrade

<a id="security"></a>

## Security

The [Security Enhancements in Microsoft SQL Server 2008 video](https://mediadl.microsoft.com/mediadl/IISNET/Media/Security%20Enhancements%20in%20Microsoft%20SQL%20Server%202008.wmv) and the corresponding [presentation](https://download.microsoft.com/download/d/1/f/d1f05c2e-0741-442d-859e-9417b377fdfa/Security%20Enhancements%20in%20SQL%20Server%202008.zip) and highlight the new features in this area of SQL Server. They include:

- SQL Server security overview
- Extensible key management
- Transparent data encryption
- Integrated authentication enhancements
- SQL audit

<a id="dataservices"></a>

## SQL Server Data Services

SQL Server Data Services (SDS) &lt;link: [https://www.microsoft.com/azure/data.mspx](https://www.microsoft.com/azure/data.mspx)&gt; offers highly scalable and Internet-facing distributed database services in the cloud for storing and processing relational queries. SDS enables the development and provisioning of new applications quickly with REST- and SOAP-based Web protocols. The services are built on robust SQL Server database and Windows Server technologies, providing high availability and security.

The [SQL Server Data Services video](https://mediadl.microsoft.com/mediadl/IISNET/Media/Introduction%20to%20SQL%20Data%20Services%20DAT251.wmv) and the corresponding [presentation](https://download.microsoft.com/download/d/1/f/d1f05c2e-0741-442d-859e-9417b377fdfa/Introduction%20to%20Microsoft%20SQL%20Server%20Data%20Services.zip) provide details about SDS. They include:

- Value proposition
- Example scenarios
- SDS architecture

    - Data model
    - Platform
    - Services ecosystem
- SDS service delivery

    - Business SLA
    - Roadmap
    - Resources

<a id="undatastr"></a>

## Unstructured Data Storage

SQL Server provides a number of capabilities that move beyond the traditional database system and towards a data platform to store, manage, and query all kinds of data, including unstructured binary data, XML, and spatial data. The [SQL Server Unstructured Storage](https://download.microsoft.com/download/a/c/d/acd8e043-d69b-4f09-bc9e-4168b65aaa71/SQL2008UnstructuredData.doc) whitepaper provides an overview of the scenarios and features involved in unstructured storage management. The [New Unstructured Data Storage Solutions video](https://mediadl.microsoft.com/mediadl/IISNET/Media/Unstructured%20Data%20Storage%20Solutions%20in%20Microsoft%20SQL%20Server%202008%20and%20Beyond.wmv) and the corresponding [presentation](https://download.microsoft.com/download/d/1/f/d1f05c2e-0741-442d-859e-9417b377fdfa/New%20Unstructured%20Data%20Storage%20Solutions%20in%20Microsoft%20SQL%20Server%202008.zip) provide further details about this area. They include:

- An overview and demonstration of the value proposition of FILESTREAM storage.
- An overview and demonstration of the value proposition of Remote Blob storage.

<a id="upgrade"></a>

## Upgrading to SQL Server 2008

The [Upgrading to SQL Server 2008 early adopter notes and best practices video](https://mediadl.microsoft.com/mediadl/IISNET/Media/Upgrading%20to%20Microsoft%20SQL%20Server%202008%20Notes%20from%20Early%20Adopters%20and%20Best%20Practices.wmv) and the corresponding [presentation](https://download.microsoft.com/download/d/1/f/d1f05c2e-0741-442d-859e-9417b377fdfa/Upgrading%20to%20SQL%20Server%202008%20early%20adopter%20notes%20and%20best%20practices.zip) provide details that are useful when planning and implementing the SQL Server 2008 upgrade. They include:

- Upgrade options, methodology, tools, and planning
- Technical and non-technical considerations
- Common issues, myths, and mistakes
- Pre-upgrade tasks
- Upgrade tasks
- Post-upgrade tasks

<a id="wp"></a>

## Planning, Deploying, and Running SQL Server 2008 Whitepapers

The following [download](https://download.microsoft.com/download/d/1/f/d1f05c2e-0741-442d-859e-9417b377fdfa/wp-Using%20Resource%20Governor%20in%20a%20Shared%20Hosting%20Environment.zip) includes these guides:

- Creating Manual Maintenance Plans for SQL Server 2008 Web Edition
- Running SQL Server 2008 in Hyper-V Environment
- SQL Server 2008 Deployment Guidance for Web Hosting Environments
- Using the Resource Governor in a Shared Hosting Environment

<a id="conclusion"></a>

## Conclusion

This article provides a complete map of guidance and detailed information about SQL Server 2008, tailored for hosting service providers to help them plan, deploy, maintain, integrate, and optimize SQL Server. It covers high availability, manageability, monitoring, troubleshooting, programming, reporting, and upgrading best practices and key features. It also provides information about PHP support, security, and SQL Server Data Services.