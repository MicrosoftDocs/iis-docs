---
title: "Migrate from MySQL to SQL Server 2008 | Microsoft Docs"
author: rick-anderson
description: "PHP, a powerful server-side scripting language used for creating dynamic Web sites and applications, is one of the most widely used Web programming languages..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 11/15/2009
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/web-hosting/migrate-to-the-microsoft-web-platform/migrate-from-mysql-to-sql-server-2008
msc.type: authoredcontent
---
Migrate from MySQL to SQL Server 2008
====================
by Tali Smith

## Introduction

PHP, a powerful server-side scripting language used for creating dynamic Web sites and applications, is one of the most widely used Web programming languages in use today. More than 4.5 million PHP developers and more than 22 million Internet domains use PHP <a id="_ftnref1"></a>[[1]](#_ftn1 "_ftnref1"). PHP has been widely deployed on Linux systems via the "LAMP" (Linux-Apache-MySQL-PHP) stack; this open-source Web development platform uses the Linux operating system, an Apache Web server, and a MySQL database with the PHP development language.

However, PHP can also be implemented on the Windows® operating system, bringing a familiar user interface and legendary ease of use to the server platform. Windows Server® 2008, with the Internet Information Services (IIS) role, supports and improves the interoperability of PHP on Windows Server®, providing a solid, hardened, scalable Web server platform.

With the advent of the SQL Server Driver for PHP and with the inclusion of FastCGI in IIS, PHP developers now have a strong platform for developing and running Web applications: Windows Server 2008, Internet Information Services (IIS), and Microsoft® SQL Server® 2008.

## Migrate from MySQL to SQL Server 2008

You can migrate from the MySQL database to SQL Server 2008 using the following steps:

1. Decide how you will map MySQL databases to SQL Server 2008. You have two main options:

- Map each MySQL database to a separate SQL Server database.   
 For example, you could map the MyDB MySQL database to MyDB SQL Server database.
- Map each MySQL database to a single SQL Server database but a separate schema.   
 For example, you could map the MyDB MySQL database to MySQLDatabases SQL Server database, schema MyDB.

2. In SQL Server, schemas are not necessarily linked to a specific user or a login, and one server contains multiple databases.

3. Convert database objects; these are tables, tables constraints, indexes, view, procedures, functions, and triggers.

4. Map data types from the MySQL data type to a SQL Server data type.

5. Rewrite your views, procedures, and functions according to SQL Server syntax.

6. Change your applications as necessary so that they can connect and work with SQL Server 2008.

After a successful database conversion, migrate your data from the old MySQL database to the newly created SQL Server 2008 database. For this task, you could use Microsoft® SQL Server® Integration Services (SSIS), for example.

## Convert Database Objects

You will then need to convert database objects.

### Schema Object Names

- In SQL Server 2008, an object name can be up to 128 characters long.
- Nonquoted identifier names must follow these rules:

    - The first character must be alphanumeric, an underscore (\_), an at sign (@), or a number sign (#).
    - Subsequent characters can include alphanumeric characters, an underscore, an at (@) sign, a number sign, or a dollar sign.
    - The identifier must not be a Transact-SQL reserved word.
    - Embedded spaces or special characters are not allowed.
- Identifiers that start with @ or a number sign have special meanings. Identifiers starting with @ are local variable names. Those that start with a number sign are temporary table names.
- To quote an identifier name in Transact-SQL, you must use square brackets ([]).

### Tables, Constraints, Indexes, and Views

- Convert tables by using column data type mapping (see Type Mapping later in this guide).
- SQL Server 2008 supports the following table (column) constraints: NOT NULL, UNIQUE, PRIMARY KEY, FOREIGN KEY, and CHECK. Convert each type of constraint according to Transact-SQL syntax.
- SELECT statements with VIEW should also be converted according to Transact-SQL SELECT syntax.

### Stored Procedures and User-Defined Functions

- Convert stored procedures and functions by using Transact-SQL syntax.
- SQL Server 2008 does not support DML statements in user-defined functions. This means that you cannot change any data from within the function.

### Triggers

- SQL Server 2008 does not have BEFORE triggers.
- Convert multiple BEFORE triggers to a single INSTEAD OF trigger.

## Migrate MySQL Data Types

You will need to migrate the MySQL data types. Follow the recommended type mappings for converting table columns, subroutine arguments, returned values, and local variable data types as found in the documentation: [http://tinyurl.com/yf9cfcg](http://tinyurl.com/yf9cfcg).

## Migrate MySQL System Functions

You will then need to migrate the MySQL system functions.

## Equivalent Functions

The following MySQL system functions are usable as is in SQL Server code:

ASCII, LEFT, LOWER, LTRIM, REPLACE, REVERSE, RIGHT, RTRIM, SOUNDEX, SPACE, SUBSTRING, UPPER, ABS, ACOS, ASIN, ATAN, ATAN2, CEILING, COS, COT, DEGREES, EXP, FLOOR, LOG, LOG10, PI, POWER, RADIANS, RAND, ROUND, SIGN, SIN, SQRT, TAN, DAY, MONTH, COALESCE, NULLIF, CAST, CONVERT.

<a id="_Toc237327829"></a>

## Nonsupported Functions

The following MySQL functions cannot be easily emulated in SQL Server because of logical and physical organization and security model differences:

BENCHMARK, CHARSET, COERCIBILITY, COLLATION, CRC32, DATE\_ADD with INTERVAL, DATE\_SUB with INTERVAL, GET\_FORMAT, PERIOD\_ADD, PERIOD\_DIFF, SUBTIME, TIMESTAMP, TIMESTAMPADD, TIMESTAMPDIFF, MATCH, EXTRACTVALUE, UPDATEXML, GET\_LOCK, IS\_FREE\_LOCK, MASTER\_POS\_WAIT, RELEASE\_LOCK.


> [!NOTE]
> *This article is summarizes material in: "[Guide to Migrating from MySQL to SQL Server 2008](http://tinyurl.com/yf9cfcg)" by Alexander Pavlov, Yuri Rusakov, and Yuri Turnakov, published in August of 2009.*


## Links for Further Information:

[Guide to Migrating from MySQL to SQL Server 2005](http://tinyurl.com/yg4v9e5).  
[SQL Server Driver for PHP Documentation](https://msdn.microsoft.com/en-us/library/ee229551(SQL.10).aspx).


* * *


<a id="_ftn1"></a>[[1]](#_ftnref1 "_ftn1") [IBM Corporation](http://www.ibm.com/developerworks/systems/library/es-path2php/index.html). 14 November 2006. Use PHP on System i, Part 1: Introduction and examples.