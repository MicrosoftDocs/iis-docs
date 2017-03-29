---
title: "Import a Package through IIS Manager | Microsoft Docs"
author: rick-anderson
description: "This quick guide will help you install a package of your Web application using the IIS Manager, including a SQL database. To create a package, see Export a P..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 10/29/2008
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/publish/using-web-deploy/import-a-package-through-iis-manager
msc.type: authoredcontent
---
Import a Package through IIS Manager
====================
by Faith A

This quick guide will help you install a package of your Web application using the IIS Manager, including a SQL database. To create a package, see [Export a Package through IIS Manager](https://mail.microsoft.com/OWA/redir.aspx?C=eeea34c97415425ea53c9866545cffc0&amp;URL=http%3a%2f%2flearn.iis.net%2fpage.aspx%2f514%2fcreate-a-package%2f "Create a Package").

## Prerequisites

This guide requires the following prerequisites:

- .NET Framework 2.0 SP1 or greater
- Web Deployment Tool 1.0
- IIS 7.0 or above, or IIS Remote Manager

Note: If you have not already installed the Web Deployment Tool, see [Installing the Web Deployment Tool](use-the-web-deployment-tool.md "Installing the Web Deploy").

## Prerequisites if you're using SQL

Note: The second and third prerequisites will be installed if you install the Web Deployment Tool using the Web Platform Installer

- SQL Server Express or Standard
- SQL Server 2008 Management Objects (SMO) - [x86](https://go.microsoft.com/fwlink/?LinkId=123708&amp;clcid=0x409) or [x64](https://go.microsoft.com/fwlink/?LinkId=123709&amp;clcid=0x409)
- SQL CLR Types - [x86](https://go.microsoft.com/fwlink/?LinkId=123721&amp;clcid=0x409) or [x64](https://go.microsoft.com/fwlink/?LinkId=123722&amp;clcid=0x409)

## Import a Package

1. Always make a backup prior to changing your system. Run the following command to backup an IIS 7.0 or above server:  

    [!code-console[Main](import-a-package-through-iis-manager/samples/sample1.cmd)]
2. Open the IIS Manager by clicking Start &gt; Run and typing inetmgr.
3. In IIS Manager, expand the Server node and the Sites node, then select the Default Web Site.
4. In the right-hand Actions pane, click the **Import Application...** link to launch the packaging wizard.
5. Select the package that you created in the previous quick guide, MyApplication.zip, or any other package.
6. In the **Install an Application Package** dialog, you will see the application and the database.
7. On the Parameters page, enter a new application name if desired and enter a SQL connection string.
8. Click **Next** to install the package.
9. The **Summary** page will provide a high-level overview of some items that were installed from the package. The **Details** tab will give a lot of detail of exactly what was added.

### Summary

Congratulations! You have now installed a package. It contains the content files, a SQL database and an IIS application.

[Discuss in IIS Forums](https://forums.iis.net/1144.aspx)