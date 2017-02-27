---
title: "Introduction to Web Deploy | Microsoft Docs"
author: rick-anderson
description: "Web Deploy is an extensible client-server tool for syncing content and configuration to IIS. Web Deploy is used primarily in two scenarios: Developers use it..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 12/09/2011
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/publish/using-web-deploy/introduction-to-web-deploy
msc.type: authoredcontent
---
Introduction to Web Deploy
====================
by Harsh Mittal

## What is Web Deploy?

Web Deploy is an extensible client-server tool for syncing content and configuration to IIS. Web Deploy is used primarily in two scenarios:

1. Developers use it to sync (aka ‘publish') a compiled web applications (ASP .Net, PHP etc) from developer tools (Visual Studio, WebMatrix, etc) to IIS
2. IT professionals use it to migrate websites &amp; applications from an operating system running an older version of IIS such as IIS6 to an operating system running a newer version of IIS such as IIS 7.5.

[![](introduction-to-web-deploy/_static/image2.png)](introduction-to-web-deploy/_static/image1.png)

## How does Web Deploy compare to FTP?

Web Deploy is often compared to technologies like FTP, XCOPY or RoboCopy. While these technologies are useful, Web Deploy offers several benefits.

Here is a comparison of Web Deploy to FTP:

1. **Web Deploy is faster than FTP.** Web Deploy does not issue a different command for each operation. Instead, it does a comparison at the start of the sync and only transfers changes.
2. **Web Deploy is secure.** Web Deploy supports transfer over HTTPS. Note that variants of FTP such as SFTP and FTPS are also secure.
3. **Web Deploy can set security descriptors (ACLs) on destination files and directories.** For example, you can use Web Deploy to give a Windows user specific access to your application's ‘Downloads' folder during deployment.
4. **Web Deploy can publish databases.** Web Deploy has out-of-box support for scripting out SQL Server, MySQL Server, Sqlite and SQL Server Compact databases and applying the resulting script during the sync. This can be very handy if your app needs a database to function.
5. **Web Deploy can apply transforms during deployment.** You can use Web Deploy to change a connection string or application setting during a sync. Web Deploy supports a large range of transforms, including transforming IIS settings.
6. **Web Deploy integrates with Visual Studio 2010 and WebMatrix.**
7. **Web Deploy is extensible.** Web Deploy has a rich, publicly-accessible extensibility model which lets you author new scenarios.

## How does it work?

[[[![](introduction-to-web-deploy/_static/image6.png)](introduction-to-web-deploy/_static/image5.png)](introduction-to-web-deploy/_static/image4.png)](introduction-to-web-deploy/_static/image3.png)

Most of the Web Deploy operations are modeled around sync operation between a source and a destination. Sync operation is orchestrated by Web Deploy framework using one or more Web deploy providers as described below.

### Framework

Web Deploy consists of a framework which manages connection state and orchestrates the sync between source &amp; destination. For example, the framework is responsible for skipping syncing certain types of content, running rules and transforming files.

The framework is accessible via a public API as well as via a command-line executable, *msdeploy.exe*.

### Providers

Web Deploy can synchronize any kind of data between two locations through the use of its built-in providers which plug into the framework. Providers know how to synchronize a particular type of data between two sources, or retrieve useful information about the data source.

For example, Web Deploy has a provider that works with SQL databases (dbFullSql) that can synchronize an entire SQL Server database to another server. Other built-in providers synchronize MySQL databases (dbMySql), IIS 7 configuration (appHostConfig), GAC assemblies (gacAssembly), or COM objects (comObject32/comObject64). [A more complete listing](https://technet.microsoft.com/en-us/library/dd569040(WS.10).aspx)can be found on TechNet.

The provider model is extensible and lets developers write their own providers for Web Deploy if they need to synchronize custom data.

### Under the Hood

When a source initiates an action through Web Deploy, the Web Deploy Framework establishes a connection with the destination. Web Deploy supports two connection end-points, and the one you use depends on several factors:

[![](introduction-to-web-deploy/_static/image8.png)](introduction-to-web-deploy/_static/image7.png)

- If the destination is Windows Server 2003 running IIS6, you can connect to its Web Deployment Agent Service (also known as the Remote Agent Service) endpoint. The Remote Agent Service provides security for this connection, and is only accessible to administrator users.
- If the destination is Windows Server 2008 running IIS7 or Windows Server 2008 R2 running IIS7.5 AND you are connecting with non-administrator credentials, you must connect to the Web Management Service endpoint. Web Deploy installs a handler in Web Management Service, which allows non-administrators to deploy after authenticating and authorizing with the Web Management Service.
- If the destination is Windows Server 2008 running IIS7 or Windows Server 2008 R2 running IIS7.5 AND you are connecting with administrator credentials, you can connect to either endpoint.

## To Learn More

Please visit our [walkthrough tutorials on iis.net](../deploying-application-packages/index.md) and our [technet documentation](https://technet.microsoft.com/en-us/library/dd568996(v=ws.10).aspx).
  
  
[Discuss in IIS Forums](https://forums.iis.net/1144.aspx)