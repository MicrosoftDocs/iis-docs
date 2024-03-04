---
title: "Import a Package through IIS Manager"
author: rick-anderson
description: "This quick guide will help you install a package of your Web application using the IIS Manager, including a SQL database. To create a package, see Export a P..."
ms.date: 10/29/2008
ms.assetid: 52ab178f-2943-4752-ab28-6ab925fdbfdd
msc.legacyurl: /learn/publish/using-web-deploy/import-a-package-through-iis-manager
msc.type: authoredcontent
---
# Import a Package through IIS Manager

by Faith A

This quick guide will help you install a package of your Web application using the IIS Manager, including a SQL database. To create a package, see [Export a Package through IIS Manager](/iis/publish/using-web-deploy/export-a-package-through-iis-manager).

## Prerequisites

This guide requires the following prerequisites:

- .NET Framework 2.0 SP1 or greater
- Web Deployment Tool 1.0
- IIS 7.0 or above, or IIS Remote Manager

Note: If you have not already installed the Web Deployment Tool, see [Installing the Web Deployment Tool](use-the-web-deployment-tool.md "Installing the Web Deploy").

## Prerequisites if you're using SQL

- SQL Server Express or Standard
- SQL Server 2008 Management Objects (SMO)
- SQL CLR Types

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
