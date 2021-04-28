---
title: "Database Notes for packaging applications for the Web Application Gallery"
author: rick-anderson
description: "The database providers for the Web Deployment Tool (WebDeploy) give application developers a great deal of flexibility in setting up databases as part of the..."
ms.date: 06/02/2009
ms.assetid: 9e5f2ff1-7a54-45f0-8197-7dd783154e41
msc.legacyurl: /learn/develop/windows-web-application-gallery/database-notes-for-packaging-applications-for-use-with-the-web-application-gallery
msc.type: authoredcontent
---
# Database Notes for packaging applications for the Web Application Gallery

by Steve Jacobson

> [!NOTE] 
> The Windows Web Application Gallery (WWAG) is being retired on July 1, 2021. We are no longer taking submissions via the Submission Portal. Please contact webpi@microsoft.com to make updates to your existing submission.

The database providers for the Web Deployment Tool (WebDeploy) give application developers a great deal of flexibility in setting up databases as part of their application installs. Outside of the Gallery, applications have a variety of methods for setting up databases, tables, users, and starting data:

- Some applications can do everything necessary, as long as the user can provide administrative credentials during the application setup. These applications usually have the flexibility to work with any database components that have already been configured, and can work without administrative credentials in those cases.
- Some applications expect the database and the database user to be created before running the application for the first time.
- Some applications expect all of these steps to be done before running the application for the first time.
- Some applications will use any combination of the above.

The WebDeploy database providers give the application developer the ability to perform whatever database functions are required prior to the application's first run. There are three WebDeploy components involved in specifying database installation directives.

1. The provider directive in the manifest.xml file. This directive tells WebDeploy which database provider to use, and what file to use for the script.
2. The connection string in the parameters.xml file. This tells Web Deploy what credentials to use, and what database and server to connect to.
3. The SQL Script. This is a standalone file that can contain any valid database commands for the specific database engine you are using. We recommend using separate script files for different SQL transactions to isolate any SQL script errors.

A minimal provider directive identifies the provider to use and the SQL file for the provide to use :

[!code-xml[Main](database-notes-for-packaging-applications-for-use-with-the-web-application-gallery/samples/sample1.xml)]

This example tells WebDeploy to use the MS SQL (dbfullsql) provider and to run a file called "install.sql".

The connection string is usually put together from other parameters in the parameters.xml file. The [App Packaging Guide](package-an-application-for-the-windows-web-application-gallery.md) contains a description of the requirements for these parameters, and examples of how to use them and put them together.

When using one of the database providers, the user will need to provide credentials for WebDeploy to use to communicate with the database. Even though these credentials are used somewhat differently for the different databases, they are all present in some form for each. These credentials consist of:

- **Database Server** - This can be the hostname or IP address of a server, or the service name for the database server.
- **Database Name** - The name of the database on the server that the application will use
- **Database User -** This is the user that is used specifically for WebDeploy to connect to the database and, if necessary, perform database operations.
- **Database Password** - The password for the Database User.

In addition to these credentials, applications will usually need an ID and password specific to the application. Application developers can use the WebDeploy tool to prompt the user for these credentials as well. Then the credentials can be placed in configuration files or SQL scripts to be used by the application.

The SQL Script can be any valid SQL or commands that the database engine will accept. The contents of this file can be parameterized the same way as any other file in the package. The SQL file can also be empty if you just want to use the provider to ensure that the database already exists. Most of the current applications in the Web Application Gallery use this SQL to create a database user for the application to use. Example syntax for each engine is covered in their respective sections.

The providers will follow these steps in communicating with a database:

1. Connect to the database server.
2. Authenticate as the database user.
3. Check to see if the database exists, and if the user has access to it. 

    - If the database does not exist, WebDeploy will attempt to create it using the provided credentials.
    - If the database creation fails, then WebDeploy will exit with a message telling the user that the user does not have sufficient privileges for the required tasks.
4. Execute the contents of all the database scripts in the package.

**Common Scenarios**

There are a few common scenarios that users of applications in the Gallery will face. The WebDeploy database providers have been designed with the flexibility to allow an application developer to create one set of configuration entries and scripts that will work for all of these scenarios.

**Shared hosting**

In a shared hosting scenario, the customer rarely has direct administrative access to the database. While in many cases, the user can create databases, the function is usually performed through a control panel where the user never sees the administrative credentials. The user that gets created as part of this process usually has full administrative privileges for the specific database that was created. Packages need to be able to execute the required SQL without needing full database administrative privileges. The database is usually remote in these scenarios.

**Dedicated Hosting**

Dedicated hosting users will usually have full privileges for their database engine. Many of these users may not have the skills, though, to be a full DBA. These users require the flexibility to be able to use either the administrative user for WebDeploy connections, or an application database user. The database may be local or remote.

**Dev environment**

In a dev environment, the user can be expected to have full control over the database and operating system. Any actions required by the application can be performed from outside the setup, if necessary. However, most devs still prefer an application installation that takes care of setting up the database.

**Installation Methods**

WebDeploy packages which are part of the Application Gallery can be installed by one of the methods below, each of which will provide a slightly different experience for users. As you design your package, you should keep each of these methods in mind such that your package will work with any of them.

1. Using the [Web Platform Installer (WebPI)](https://www.microsoft.com/web/downloads/platform.aspx). When a package is installed with the WebPI, the WebPI's user interface adapts to the database requirements of the package. The WebPI will look at the tags on database oriented parameters, and the providers specified in the manifest.xml file. If more than one database engine is available for the application, the WebPI will ask the user to specify which database to use. The parameter setting screen will then only show the parameters that are relevant for that database. The WebPI will ask the user if the user wants to use an existing database, or create one. The user will only be asked for database administrative credentials if they are needed to create a new database.
2. Using WebDeploy locally. You may choose to make your WebDeploy package available to users outside of the WebPI. Users could then download the package and use the IIS Manager to install the application. The WebDeploy UI will ask the user to select from multiple databases if relevant. The user will be asked to provide all parameters specified for that database, including the administrative credentials. When designing your script, you should think about how the script would run if run by a regular user instead of an administrative user.
3. Using a third-party control panel. We have provided documentation on the way we use the parameter tags to all of our partners who are working on control panels to integrate with the Gallery. How they choose to implement their user interfaces is up to their discretion, and is dependent on their existing models. In some cases, the UI will behave like either of the examples above. Control panel vendors may choose to expose or hide any portion of the parameterization they want. It is important to make sure you use the specified tags, as these control panel vendors will be looking for them to help them build their UIs.

**SQL Specifics**

Applications that require access to MS SQL databases can work with either SQL Server (including SQL Express) and SQL Azure (with some additional requirements).When the Web Platform Installer installs one of these applications, it will check to see if any SQL is installed on the local machine. If there is none, the WebPI will select SQL Express as one of the components to be installed. Users that want to use a remote database have the option of unselecting the SQL Express option.

**SQL Express / SQL Azure**

The Web Platform Installer will install current version of SQL Express 2008 when the user requests a SQL Installation, or when an application needs SQL. The WebPI will offer the user a choice of authentication modes for SQL - either Windows Native or database based. The WebPI recommends that application users choose database based authentication, as most applications prefer that method. When the user selects database authentication, the user will need to enter a password for the ‘sa' or administrative user. This password needs to meet the requirements set out in [https://msdn.microsoft.com/library/ms143705.aspx](https://msdn.microsoft.com/library/ms143705.aspx). If you use the SQL script to set a password for a database user, the same password requirements will apply. The default installation sets up the SQL Express server with the service name of .\SQLEXPRESS.

If you want to use a remote database (SQL Server on another machine, or SQL Azure) you don't need to install SQL Express.

In all cases, two scripts are required to perform the initial setup of the database. This script will be complementary to the parameters example shown before in the packaging and their goal is:

1. CreateLogin.sql: Create a login in the DB (newly created if the DB didn't exist). This script requires a connection string parameter with database administrative user credentials
2. CreateUser.sql: Create a user with appropriate db roles for the application's database. This script requires a connection string parameter with database user credentials.

Refer to this [sample](umbraco-cms-sample-files.md "Umbraco Sample") to get you started with building a package for SQL Server or SQL Azure based application. The script is designed to set all of the required privileges for most application needs for both SQL Server and SQL Azure.

Please note that in order to work in both SQL Server and SQL Azure, these two scripts need to be divided in two different files since the connection string are different (SQL Azure does not allow the " USE database" command). For more information about LOGIN and USER creation on SQL Azure, you can refer to [this page](https://msdn.microsoft.com/library/windowsazure/ee336235.aspx). For more information about SQL Azure limitations, you can refer to [this page](https://msdn.microsoft.com/library/windowsazure/ff394102.aspx).

**Usage:** 

***Use a script for creating a login***

[!code-console[Main](database-notes-for-packaging-applications-for-use-with-the-web-application-gallery/samples/sample2.cmd)]

***Use a script to create a user and add database roles***

[!code-sql[Main](database-notes-for-packaging-applications-for-use-with-the-web-application-gallery/samples/sample3.sql)]

**MySQL Specifics**

The Web PI will install MySQL on your users' systems. If your application requires MySQL, the WebPI will check for the existence of MySQL on the local system. If MySQL is not found, the WebPI will install it.

WebDeploy can work with MySQL databases in much the same way as it does with SQL. SQL scripts can contain any valid MySQL syntax. The Install.sql script below works with the parameters example in the packaging guide to create a user and set a password for the application's database. The script is designed to set all of the required privileges for most application needs.

In a shared hosting environment, the end user will probably not have the administrative privileges required for executing the GRANT statement in the script. If the user does not have permission to execute the GRANT statement, the MySQL provider will throw an error, and the installation process will fail. We have developed the add\_user script to ignore errors caused by the end user having insufficient privileges to execute the GRANT. This way, the installation can be completed successfully in an environment where both the user and the database are created before installing the application.

In MySQL syntax, the normal command delimiter is a semi-colon (;). MySQL procedures require a different delimiter to be used for separating statements. This is explained in the [MySQL documentation](http://dev.mysql.com/doc/refman/5.1/en/stored-programs-defining.html). To specify the delimiter for WebDeploy, you should use attributes of the **dbMySQL** provider directive in the manifest.xml file:

[!code-xml[Main](database-notes-for-packaging-applications-for-use-with-the-web-application-gallery/samples/sample4.xml)]

The create user script we use can be parameterized as well. We do recommend parameterizing the database server for the GRANT statement in the SQL Script below in the parameters.xml file and using a place-holder to represent the Database server, for example *‘PlaceHolderForServer'* . By doing so, the user will have the option to either install the application against a local MySQL server, usually ‘*localhost'* or install the application against a remote MySQL database .

[!code-console[Main](database-notes-for-packaging-applications-for-use-with-the-web-application-gallery/samples/sample5.cmd)]

#### Related Articles

- [MSDeploy SQL Database Provider (dbFullSql)](https://blogs.iis.net/msdeploy/archive/2008/11/10/the-msdeploy-sql-database-provider-dbfullsql.aspx)
- [MSDeploy MySql Database Provider(dbMySql)](https://blogs.iis.net/msdeploy/archive/2009/03/30/msdeploy-sample-custom-provider-to-sync-mysql-databases-dbfullmysql.aspx)
- [SQL Azure Limitations](https://msdn.microsoft.com/library/windowsazure/ff394102.aspx)
- [Migrating to SQL Azure](https://blogs.msdn.com/b/ssdt/archive/2012/04/19/migrating-a-database-to-sql-azure-using-ssdt.aspx)
- [MySQL documentation](http://dev.mysql.com/doc/refman/5.1/en/stored-programs-defining.html)
