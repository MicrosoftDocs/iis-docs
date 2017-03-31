---
title: "Running IIS Express from the Command Line | Microsoft Docs"
author: vaidy4github
description: "IIS Express is a simple and self-contained version of IIS that is optimized for developers. This walkthrough describes how to run a site using the IIS Expres..."
ms.author: iiscontent
manager: soshir
ms.date: 07/06/2010
ms.topic: article
ms.assetid: 
ms.technology: iis-extensions
ms.prod: iis
msc.legacyurl: /learn/extensions/using-iis-express/running-iis-express-from-the-command-line
msc.type: authoredcontent
---
Running IIS Express from the Command Line
====================
by [Vaidy Gopalakrishnan](https://github.com/vaidy4github)

## Overview

IIS Express is a simple and self-contained version of IIS that is optimized for developers. This walkthrough describes how to run a site using the IIS Express command line.

### Prerequisites

You must have the following installed to complete the procedures in this walkthrough:

- Windows XP or newer
- IIS Express

For information about how to download and install IIS Express, see [IIS Express Overview](../introduction-to-iis-express/iis-express-overview.md "IIS Express Overview").

## Running a Site using IIS Express from the Command Line

1. Open a command prompt.  
  
 You do not need Administrator user rights to run the commands in this walkthrough. However, you must have Administrator user rights if you want to run IIS Express on ports numbered 1024 or less.
2. Run the following command to navigate to the IIS Express installation folder:

    [!code-console[Main](running-iis-express-from-the-command-line/samples/sample1.cmd)]

 or if you are using a 64-bit OS, run the following command:

    [!code-console[Main](running-iis-express-from-the-command-line/samples/sample2.cmd)]
3. Run the following command to view the IIS Express usage string:

    [!code-console[Main](running-iis-express-from-the-command-line/samples/sample3.cmd)]
4. Run your site using one of the following: 

    - Use /config to run a site from a configuration file.  
  
 See "Running your site from a configuration file" for more information.
    - Use /path to run a site from the application folder.  
  
 See "Running your site from the application folder" for more information.

    Note: The /path option and the /config option cannot be combined.
5. Once your site is running, you can use the IIS Express system tray to manage it. For more information, see [Use the Windows System Tray to Manage Websites and Applications](using-the-windows-system-tray-to-manage-websites-and-applications.md). Alternatively, you can disable the system tray by running the following option:

    [!code-unknown[Main](running-iis-express-from-the-command-line/samples/sample-127454-4.unknown)]

### Running your site from a configuration file

IIS Express and IIS use the ApplicationHost.config file, which specifies global settings for sites, application pools, handlers, etc. IIS Express uses a default, user-specific ApplicationHost.config file to allow many users to share the same computer without interfering with other user's settings. This file is located in the %*userprofile*%\Documents\IISExpress\config folder or %*userprofile*%\My Documents\IISExpress\config folder, depending on your OS. When you run a site from a configuration file, you can specify which site to run.

You can use the following commands:

- To run the website *Website1* in the default configuration file, run: 

    [!code-console[Main](running-iis-express-from-the-command-line/samples/sample5.cmd)]
- To run the first website in the default configuration file, run:

    [!code-unknown[Main](running-iis-express-from-the-command-line/samples/sample-127454-6.unknown)]
- To run the first website in a custom configuration file, run:

    [!code-console[Main](running-iis-express-from-the-command-line/samples/sample7.cmd)]
- To run a site called *MyBlog* from a custom configuration file, run:

    [!code-console[Main](running-iis-express-from-the-command-line/samples/sample8.cmd)]

Note: The /config option specifies the full path of the configuration file. You can omit this option if you want to use the default configuration file. The /site option specifies a particular site in the configuration file. You can omit this option to run the first site in the configuration file.

### Running your site from the application folder

You can also use the /path option to run a site directly from a folder. This option works for any type of application, including static HTML, ASP.NET, PHP, and WCF. By default, IIS Express will run the site on http://localhost:8080/. For a managed website, such as ASP.NET, IIS Express will use .NET 4.0. You can use the /port and /clr options to override these default values.

For example, the following command runs the specified application, "myapp," on http://localhost:9090/ by using .NET 2.0:

[!code-console[Main](running-iis-express-from-the-command-line/samples/sample9.cmd)]
  
  
[Discuss in IIS Forums](https://forums.iis.net/1166.aspx)