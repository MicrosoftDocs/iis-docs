---
title: "SQL Server 2005 | Microsoft Docs"
author: walterov
description: "SQL Server 2005 is an ideal database platform for use in shared and dedicated Web hosting environments. Of the various SQL Server editions, only SQL Server E..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 01/28/2008
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/web-hosting/configuring-servers-in-the-windows-web-platform/sql-server-2005
msc.type: authoredcontent
---
SQL Server 2005
====================
by [Walter Oliver](https://github.com/walterov)

## Introduction

SQL Server 2005 is an ideal database platform for use in shared and dedicated Web hosting environments. Of the various SQL Server editions, only **SQL Server Express should never be used in Shared Hosting scenarios**, this edition was meant for application development environments only; see [SQL Server Express and Hosting](https://blogs.msdn.com/sqlexpress/archive/2008/02/22/sql-server-express-and-hosting.aspx "SQL Server Express and Hosting") for details.

The [SQL Server 2005 Deployment Guidance for Web Hosting Environments](https://www.microsoft.com/technet/prodtechnol/sql/bestpractice/sql2005dgwhe.mspx "SQL 2005 Guide") provides best practices for configuring SQL Server 2005 to optimize security, tenant isolation, and the performance of your hosted SQL Server 2005 deployment. Sample scripts for provisioning users and databases for use in shared hosting are included.

## Subjects

The document covers:

- Server Provisioning

    - Configuring Windows for Large Amounts of Memory
    - Provisioning Multiple Instances of SQL Server
    - Using the AWE API for Servers with Large Amounts of Memory
    - CLR Integration with SQL Server
    - Query Cost Governor Limits
    - Security Provisioning
    - Disabling or Renaming the Built-in sa Account
    - Server-Level Dynamic Management Views
    - Thwarting Luring Attacks
    - Deploying SQL Server Directly on the Internet
    - SQL Server Surface Area Configuration
- User Provisioning

    - User and database provisioning (logins, users, and databases)
    - Stored procedure for creating assemblies