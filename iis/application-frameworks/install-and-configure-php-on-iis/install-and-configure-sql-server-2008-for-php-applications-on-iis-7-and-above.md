---
title: "Install and Configure SQL Server 2008 for PHP Applications on IIS 7"
author: rick-anderson
description: "PHP is a widely used, easy-to-learn, open-source scripting language. Microsoft ® SQL Server ® is a powerful and robust relational model database server that..."
ms.date: 11/15/2009
ms.assetid: 322bf487-da24-463a-ac46-d526e179fe2a
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-on-iis/install-and-configure-sql-server-2008-for-php-applications-on-iis-7-and-above
msc.type: authoredcontent
---
# Install and Configure SQL Server 2008 for PHP Applications on IIS 7

by Tali Smith

## Introduction

PHP is a widely used, easy-to-learn, open-source scripting language. Microsoft® SQL Server® is a powerful and robust relational model database server that can handle terabytes of data. Together, PHP and SQL Server can be used to create and support database-driven Web sites that can handle significant traffic and data.

Although you can install an instance of SQL Server on a computer that is running Internet Information Services 7 (IIS 7) or above, this is typically done only for small Web sites that have a single server computer. Most Web sites have their middle-tier IIS systems on one server or cluster of servers and their databases on a separate server or federation of servers.

To access a SQL Server database from within PHP scripts, you must have the SQL Server Driver for PHP, which can be installed with the Microsoft® Web Platform Installer (Web PI), or downloaded from [here](https://www.microsoft.com/downloads/details.aspx?familyid=CCDF728B-1EA0-48A8-A84A-5052214CAAD9&amp;displaylang=en).

## Why Use SQL Server?

While it is possible to use MySQL as the database component, Microsoft offers a highly compelling solution for the data requirements of PHP-based applications. With the advent of the SQL Server Driver for PHP, you can take advantage of the efficient, reliable, and intelligent capabilities of Microsoft SQL Server.

Hosters and large Web properties need a manageable enterprise-class database solution to support:

- Effective monitoring and management of Web customers.
- Maximum server utilization for low-cost operations.
- Flexible platform options for developers.
- Consistently increasing scale-out needs.
- Efficient management of large groups of servers.

SQL Server 2008 can meet these needs by providing enterprise-class availability and scalability and a low total cost of ownership (TCO).

- **Increase scalability.** Scale out with unlimited memory and database size, which helps hosting companies offer support for multi-tenancy and customers with growing data needs. Scale out with support for up to four CPUs to maximize the utilization of hardware resources.
- **Ensure availability**. Help ensure availability by using log shipping to automatically back up data on separate server s or keep multiple read servers online to better handle large amounts of Web traffic. One-way merge and transactional replication provides enterprise-class data availability. **Lower TCO.** Help increase overall profit margins through low monthly licensing costs, enhanced publishing tools for fast customer deployment, and manageability tools for reduced administration. Businesses can take advantage of the low cost of Microsoft® SQL Server® 2008 Web for their core enterprise installations.
- **Automate tasks and policies.**   
 Use     *Policy-Based Management* to define configuration policies and apply them to servers, databases, tables, and other targets.   
 Use the     *performance data collector* to identify problematic customer applications and pinpoint causes for performance degradation.   
 Use     *SQL Agent* to reduce the amount of time spent on administrative tasks by scheduling and executing events like server backups.
- **Streamline administration.**   
 Use the     *service broker* to distribute applications across your servers to help balance the load while the applications seamlessly functions as a whole for easier scale out.   
 Use     *Windows PowerShell™* to automate server administration and application development more easily, giving administrators a common scripting language across Windows®, IIS, and SQL Server to save time.
- **Use built-in business intelligence**. Use basic SQL Server 2008 Reporting Services features to create unique report layouts. The new visualization enhancements in Reporting Services further enrich the reports and provide greater insight.
- **Take advantage of platform flexibility.**   
 Use     *ADO.NET Data Services* support to expose data through Web services using existing tools and processes. This helps hosters support customers with mixed applications like ASP and PHP.  
 Use     *FTS (full text search)* for fast and flexible indexing for keyword-based query of text stored in SQL Server for enterprise search functionality.

## SQL Server Versions

SQL Server 2008 is available in several editions, including two editions that are free. Most applicable to Web hosters are:

- **Microsoft SQL Server 2008 Web.**  
 Microsoft SQL Server 2008 Web has been designed to provide a robust backend to Web systems. Its feature set includes policy-based management tools, automated security policy enforcement, and performance data collection tools. Although this edition can only address four CPUs, there are no limits on memory or database size.
- **Microsoft® SQL Server® 2008 Express.**  
 This free edition provides an entry-level database (4 GB in size) that is ideal for learning, developing and powering desktop computers, Web and small server applications, and for redistribution by independent software vendors (ISVs). Built on the SQL Server 2008 Database Engine, it supports stored procedures, triggers, functions, and views, and it stores a variety of business data with native support for relational data, XML, FILESTREAM, and spatial data. This edition can address one CPU and has a limit of 1 GB of memory.



## Install SQL Server 2008 with Web PI

The fastest and easiest way to install a database component for a Windows-based PHP Web platform is by using Web PI. Web PI can install the latest versions of SQL Server Express (a scaled-down, free edition of SQL Server, which includes the core database engine) and the Microsoft SQL Server Driver for PHP with just a few clicks. You can simply navigate to the "Web Platform" tab and select "SQL Server Express 2008 with Service Pack 1" under the "Databases" customize link. Web PI can also install and set up IIS, FastCGI, and the latest version of PHP from the php.net site.

## Install SQL Server 2008 Manually

Alternately, you can manually set up SQL Server as the database component of the Microsoft® Web Platform. The SQL Server Installation Wizard is based on Windows® Installer. It provides a single feature tree for installation of all SQL Server components, so that you do not have to install them individually. SQL Server 2008 can also be installed from the command prompt or with a configuration file.

For instructions, see: [How to: Install SQL Server 2008](https://technet.microsoft.com/library/ms143219.aspx).

## Links for Further Information

- [SQL 2008 for Hosters](../../web-hosting/configuring-servers-in-the-windows-web-platform/sql-2008-for-hosters.md).
- [Hardware and Software Requirements for Installing SQL Server 2008](https://technet.microsoft.com/library/ms143506.aspx).
- [Editions and Components of SQL Server 2008.](https://technet.microsoft.com/library/ms144275.aspx)
- [SQL Server 2008 home page](https://www.microsoft.com/sqlserver/2008/en/us/default.aspx).
- [SQL Server Developer Center library](https://msdn.microsoft.com/library/bb545450.aspx).
- [SQL Server Best Practices](https://technet.microsoft.com/sqlserver/bb671430.aspx).
