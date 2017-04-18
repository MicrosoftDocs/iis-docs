---
title: "Secure Your SQL Server Database | Microsoft Docs"
author: rick-anderson
description: "If you use Microsoft ® SQL Server ® as your database, you must create and implement an effective security plan. There is a wealth of information about how to..."
ms.author: iiscontent
manager: soshir
ms.date: 11/15/2009
ms.topic: article
ms.assetid: 58dc712c-8707-4c10-a48c-58d4df35ae6f
ms.technology: iis-appfx
ms.prod: iis
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-on-iis/secure-your-sql-server-database
msc.type: authoredcontent
---
Secure Your SQL Server Database
====================
by Tali Smith

## Introduction

If you use Microsoft® SQL Server® as your database, you must create and implement an effective security plan. There is a wealth of information about how to secure a SQL Server database; this article touches on a few areas of particular interest to Web hosters and provides links for further information.

Securing SQL Server can be viewed as a series of steps involving four areas: the platform, authentication, objects (including data), and applications that access the system.

## Platform and Network Security

The platform for SQL Server includes the physical hardware and networking systems connecting clients to the database servers and the binary files that are used to process database requests.

### Physical Security

Best practices for physical security strictly limit access to the physical server and hardware components. For example, use locked rooms with restricted access for the database server hardware and networking devices. In addition, limit access to backup media by storing it at a secure off-site location.

Implementing physical network security starts with keeping unauthorized users off the network. The following table contains more information about networking security information.

| **For information about** | **See** |
| --- | --- |
| Networking and SQL Server | [Network Protocols and Tabular Data Stream (TDS) Endpoints](https://msdn.microsoft.com/en-us/library/ms191220.aspx) |
| Specifying and restricting ports that are used for SQL Server | [Configuring Server Network Protocols and Net-Libraries](https://msdn.microsoft.com/en-us/library/ms177485.aspx) |
| Restricting network access to SQL Server | [Restricting Network Access](https://msdn.microsoft.com/en-us/library/ms174507.aspx) |
| Microsoft® SQL Server® Compact 3.5 Service Pack 1 (SP1) and network access to other SQL Server editions | [Configuring and Securing the Server Environment in SQL Server Compact 3.5 SP1 Books Online](https://www.microsoft.com/downloads/details.aspx?FamilyId=07829770-73A7-41E4-880D-E74B1A353623&amp;displaylang=en) |
| Backup and restore strategies | [Security Considerations for Backup and Restore (SQL Server)](https://msdn.microsoft.com/en-us/library/ms190964.aspx) |

### System Security

Operating system service packs and upgrades include important security enhancements. Apply all updates and upgrades to the operating system after you test them with the database applications.

Firewalls also provide effective ways to implement security. Logically, a firewall is a separator or restrictor of network traffic, which can be configured to enforce your organization's data security policy. If you use a firewall, you increase security at the operating system level by providing a chokepoint where your security measures can be focused.

The following table contains more information about how to use a firewall with SQL Server.

| **For information about** | **See** |
| --- | --- |
| Configuring a firewall to work with SQL Server | [How to: Configure a Windows® Firewall for Database Engine Access](https://msdn.microsoft.com/en-us/library/ms175043.aspx) |
| Configuring a firewall to work with Microsoft® SQL Server® Integration Services | [Configuring a Windows Firewall for Integration Services Access](https://msdn.microsoft.com/en-us/library/ms137861.aspx) |
| Configuring a firewall to work with Microsoft® SQL Server® Analysis Services | [How to: Configure Windows Firewall for Analysis Services Access](https://msdn.microsoft.com/en-us/library/ms174937.aspx) |
| Configuring a firewall to work with Microsoft® SQL Server® Reporting Services | [Server Deployment Checklist](https://msdn.microsoft.com/en-us/library/ms159689.aspx) |
| Opening specific ports on a firewall to enable access to SQL Server | [Opening Ports in the Firewall](https://msdn.microsoft.com/en-us/library/ms345310.aspx) |

Surface-area reduction is a security measure that involves stopping or disabling unused components. Surface-area reduction helps improve security by providing fewer avenues for potential attacks on a system. The key to limiting the surface area of SQL Server includes running required services that have "least privilege" by granting services and users only the appropriate rights.

The following table contains more information about services and system access.

| **For information about** | **See** |
| --- | --- |
| Services required for SQL Server | [Setting Up Windows® Service Accounts](https://msdn.microsoft.com/en-us/library/ms143504.aspx) |
| Restricting server logon access | [Restricting Interactive Logon Access](https://msdn.microsoft.com/en-us/library/ms175588.aspx) |
| Local administration rights | [Granting Local Administrative Rights](https://msdn.microsoft.com/en-us/library/ms174494.aspx) |

For Internet Information Services (IIS), additional steps are required to help secure the surface of the platform.

The following table contains information about SQL Server and Internet Information Services.

| **For information about** | **See** |
| --- | --- |
| IIS security with SQL Server Compact 3.5 SP1 | [IIS Security in SQL Server Compact 3.5 SP1 Books Online](https://technet.microsoft.com/en-us/library/bb283235.aspx) |
| Using Web services in SQL Server and IIS | [Best Practices for Using Native XML Web Services](https://msdn.microsoft.com/en-us/library/ms190399.aspx) |
| Report servers and Internet access | [Planning for Extranet or Internet Deployment](https://msdn.microsoft.com/en-us/library/ms159272.aspx) |
| Setting up forms security on a report server | [Readme\_Security Extension Sample](https://msdn.microsoft.com/en-us/library/ms160724.aspx) |
| Reporting Services Authentication | [Authentication in Reporting Services](https://msdn.microsoft.com/en-us/library/ms152899.aspx) |
| SQL Server Compact 3.5 SP1 and IIS access | [Internet Information Services Security Flowchart in SQL Server Compact 3.5 SP1 Books Online](https://technet.microsoft.com/en-us/library/ms172389.aspx) |

### SQL Server Operating System Files Security

SQL Server uses operating system files for operation and data storage. Best practices for file security require that you restrict access to these files.

The following table contains information about these files.

| **For information about** | **See** |
| --- | --- |
| SQL Server program files | [File Locations for Default and Named Instances of SQL Server](https://msdn.microsoft.com/en-us/library/ms143547.aspx) |
| Database file security | [Securing Data and Log Files](https://msdn.microsoft.com/en-us/library/ms189128.aspx) |
| Analysis Services file security | [Securing Program Files, Common Components, and Data Files](https://msdn.microsoft.com/en-us/library/ms174838.aspx) |

SQL Server service packs and upgrades provide enhanced security. To determine the latest available service pack available for SQL Server, see the [SQL Server](https://go.microsoft.com/fwlink/?LinkID=31629) Web site.

You can use the following script to determine the service pack installed on the system.


[!code-sql[Main](secure-your-sql-server-database/samples/sample1.sql)]


## Principals and Database Object Security

Principals are the individuals, groups, and processes granted access to SQL Server. "Securables" are the server, database, and objects the database contains. Each has a set of permissions that can be configured to help reduce the SQL Server surface area.

The following table contains information about principals and securables.

| **For information about** | **See** |
| --- | --- |
| Server and database users, roles, and processes | [Principals (Database Engine)](https://msdn.microsoft.com/en-us/library/ms181127.aspx) |
| Server and database objects security | [Securable](https://msdn.microsoft.com/en-us/library/ms190401.aspx) |
| The SQL Server security hierarchy | [Permissions Hierarchy (Database Engine)](https://msdn.microsoft.com/en-us/library/ms191465.aspx) |

For more information about database and application security, see [Identity and Access Control (Database Engine)](https://msdn.microsoft.com/en-us/library/bb510418.aspx).

### Encryption and Certificates

Encryption does not solve access control problems. However, encryption enhances security by limiting data loss even in the rare occurrence that access controls are bypassed. For example, if the database host computer is misconfigured and a malicious user obtains sensitive data, such as credit card numbers, that stolen information might be useless if it is encrypted.

The following table contains more information about encryption in SQL Server.

| **For information about** | **See** |
| --- | --- |
| The encryption hierarchy in SQL Server | [Encryption Hierarchy](https://msdn.microsoft.com/en-us/library/ms189586.aspx) |
| Encrypting SQL Server connections | [Encrypting Connections to SQL Server](https://msdn.microsoft.com/en-us/library/ms189067.aspx) |
| Implementing secure connections | [How to: Enable Encrypted Connections to the Database Engine (SQL Server Configuration Manager)](https://msdn.microsoft.com/en-us/library/ms191192.aspx) |
| Encryption functions | [Cryptographic Functions (Transact-SQL)](https://msdn.microsoft.com/en-us/library/ms173744.aspx) |
| Implementing encryption | [Encryption How-to Topics](https://msdn.microsoft.com/en-us/library/aa337557.aspx) |
| Setting up Analysis Services for data encryption | [Requiring Data Encryption](https://msdn.microsoft.com/en-us/library/ms175415.aspx) |

Certificates are software "keys" shared between two servers that enable secure communications by way of strong authentication. You can create and use certificates in SQL Server to enhance object and connection security.

The following table contains information about how to use certificates with SQL Server.

| **For information about** | **See** |
| --- | --- |
| Using a certificate for secure connections | [Configuring Certificate for Use by SSL](https://msdn.microsoft.com/en-us/library/ms186362.aspx) |
| Creating a certificate for use by SQL Server | [CREATE CERTIFICATE (Transact-SQL)](https://msdn.microsoft.com/en-us/library/ms187798.aspx) |
| Using a certificate with SQL Server Service Broker | [Certificates and Service Broker](https://msdn.microsoft.com/en-us/library/ms166096.aspx) |
| Using a certificate with database mirroring | [Using Certificates for Database Mirroring](https://msdn.microsoft.com/en-us/library/ms191477.aspx) |

## Application Security

SQL Server security best practices include writing secure client applications. For more information about server access and SQL Server client applications, see [Developer's Guide (Database Engine)](https://msdn.microsoft.com/en-us/library/bb522480.aspx).

For more information about how to help secure client applications at the networking layer, see [Client Network Configuration](https://msdn.microsoft.com/en-us/library/ms190611.aspx).

For more information about how to write applications that use native XML services, see [Writing Client Applications](https://msdn.microsoft.com/en-us/library/ms190173.aspx).

## SQL Server Security Tools, Utilities, Views, and Functions

SQL Server provides tools, utilities, views, and functions that can be used to configure and administer security.

### SQL Server Security Tools and Utilities

The following table contains information about SQL Server tools and utilities that you can use to configure and administer security.

| **For information about** | **See** |
| --- | --- |
| Connecting to, configuring, and controlling SQL Server | [Introducing SQL Server Management Studio](https://msdn.microsoft.com/en-us/library/ms174173.aspx) |
| Connecting to SQL Server and running queries at the command prompt | [sqlcmd Utility](https://msdn.microsoft.com/en-us/library/ms162773.aspx) |
| Network configuration and control for SQL Server | [SQL Server Configuration Manager](https://msdn.microsoft.com/en-us/library/ms174212.aspx) |
| Enabling and disabling features by using policy-based management | [Administering Servers by Using Policy-Based Management](https://msdn.microsoft.com/en-us/library/bb510667.aspx) |
| Manipulating symmetric keys for a report server | [rskeymgmt Utility](https://msdn.microsoft.com/en-us/library/ms162822.aspx) |

### SQL Server Security Catalog Views and Functions

The Database Engine exposes security information in several views and functions that are optimized for performance and utility.

The following table contains information about security views and functions.

| **For information about** | **See** |
| --- | --- |
| SQL Server security catalog views, which return information about database-level and server-level permissions, principals, roles, and so on. In addition, there are catalog views that provide information about encryption keys, certificates, and credentials. | [Security Catalog Views (Transact-SQL)](https://msdn.microsoft.com/en-us/library/ms178542.aspx) |
| SQL Server security functions, which return information about the current user, permissions, and schemas | [Security Functions (Transact-SQL)](https://msdn.microsoft.com/en-us/library/ms186236.aspx) |
| SQL Server security dynamic management views | [Security-Related Dynamic Management Views and Functions (Transact-SQL)](https://msdn.microsoft.com/en-us/library/bb677257.aspx) |

## Links for Further Information

[Securing SQL Server](https://msdn.microsoft.com/en-us/library/bb283235.aspx)

[SQL Server 2008 Deployment Guide for Web Hosting Environments](https://download.microsoft.com/download/d/1/f/d1f05c2e-0741-442d-859e-9417b377fdfa/The%20architectural%20view%20of%20SQL%20Server.zip)

[Security Considerations for a SQL Server Installation](https://msdn.microsoft.com/en-us/library/ms144228.aspx)

[Secure Deployment (Database Engine)](https://msdn.microsoft.com/en-us/library/bb522545.aspx)

[Security and Protection (Database Engine)](https://msdn.microsoft.com/en-us/library/bb510589.aspx)

[Security Enhancements in Microsoft SQL Server 2008 video](https://mediadl.microsoft.com/mediadl/IISNET/Media/Security%20Enhancements%20in%20Microsoft%20SQL%20Server%202008.wmv)

[Security Enhancements in Microsoft SQL Server 2008 presentation](https://download.microsoft.com/download/d/1/f/d1f05c2e-0741-442d-859e-9417b377fdfa/Security%20Enhancements%20in%20SQL%20Server%202008.zip)

[SQL Server 2008 for Hosters](../../web-hosting/configuring-servers-in-the-windows-web-platform/sql-2008-for-hosters.md)