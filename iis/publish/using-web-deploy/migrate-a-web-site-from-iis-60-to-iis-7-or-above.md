---
title: "Migrate a Web Site from IIS 6.0 to IIS 7 or above | Microsoft Docs"
author: rick-anderson
description: "This quick guide will help you migrate a Web site from IIS 6.0 to IIS 7 or above by using the Web Deployment Tool. What kinds of migrations can I accomplish..."
ms.author: iiscontent
manager: soshir
ms.date: 03/23/2008
ms.topic: article
ms.assetid: d1dc9de0-b74e-4f1d-bb22-b259574d9387
ms.technology: iis-publish
ms.prod: iis
msc.legacyurl: /learn/publish/using-web-deploy/migrate-a-web-site-from-iis-60-to-iis-7-or-above
msc.type: authoredcontent
---
Migrate a Web Site from IIS 6.0 to IIS 7 or above
====================
by Faith A

This quick guide will help you migrate a Web site from IIS 6.0 to IIS 7 or above by using the Web Deployment Tool.

**What kinds of migrations can I accomplish with the Web Deployment Tool?**

- Migrate 1 or 1,000 Web sites from IIS 6.0 to IIS 7 or above including all the configuration settings, content and certificates
- Migrate a single application
- Migrate an entire server (all Web sites, application pools, etc.) from IIS 6.0 to IIS 7 or above
- Migrate a custom manifest comprised of sites, application pools, assemblies, COM objects, registry keys, content and more from IIS 6.0 to IIS 7 or above

### Prerequisites

This guide requires the following prerequisites:

- .NET Framework 2.0 SP1 or greater
- Web Deployment Tool 1.1

Note: If you have not already installed the Web Deployment Tool, see [Installing and Configuring Web Deploy](../../install/installing-publishing-technologies/installing-and-configuring-web-deploy.md "Installing Web Deploy").

### Part 1 - View your site's dependencies

1. Get the dependencies of the Web site by running the following command:  

    [!code-console[Main](migrate-a-web-site-from-iis-60-to-iis-7-or-above/samples/sample1.cmd)]
2. Review the output of the dependencies and look for any script maps or installed components in use by the site. For example, if Windows Authentication is in use by the Web site, you will see &lt;dependency name="WindowsAuthentication" /&gt;.
3. If your site is inheriting any script maps, these will not be listed in the dependencies and you should also review the script maps for your site manually.
4. Compile a list of the components needed on the destination.

For detailed steps on analyzing the output of getDependencies, see [Viewing Dependencies](https://technet.microsoft.com/en-us/library/dd569091(WS.10).aspx "Viewing Dependencies").

### Part 2 - Configure the target

Review the list of dependencies and install them on the destination server.

For example, let's assume you had the following in use for your Web site:

- ASP.NET
- Windows Authentication
- Anonymous Authentication

Based on this analysis of your dependencies, you would install the corresponding components and modules.

### Part 3 – Migrate your site to the target by using a package file

1. Always make a backup of the destination server. Even if you are just testing, it allows you to easily restore the state of your server.  

    [!code-console[Main](migrate-a-web-site-from-iis-60-to-iis-7-or-above/samples/sample2.cmd)]
2. Run the following command on the source server to create a package (compressed) file of the server:  

    [!code-console[Main](migrate-a-web-site-from-iis-60-to-iis-7-or-above/samples/sample3.cmd)]
3. Copy the package file to the destination server.
4. Run the following command on the destination server to validate what would happen if a **sync** operation were run:  

    [!code-console[Main](migrate-a-web-site-from-iis-60-to-iis-7-or-above/samples/sample4.cmd)]
5. After verifying the output, run the same command again without the whatif flag:  

    [!code-console[Main](migrate-a-web-site-from-iis-60-to-iis-7-or-above/samples/sample5.cmd)]

### {Optional - Migrate your site to the target by using the Web Deployment Agent Service}

If you don't want to use a package, you can use the Web Deployment Agent Service (MsDepSvc, also called "remote service") to synchronize from IIS 6.0 to IIS 7 or above.

1. Install the remote service on either the source or the destination depending on whether you want to synchronize from a remote source or to a remote destination.
2. Start the service on the computer.  

    [!code-console[Main](migrate-a-web-site-from-iis-60-to-iis-7-or-above/samples/sample6.cmd)]
3. Run the following command to do a "push" synchronization from the local source to a remote destination (replace Server1 with the name of the remote computer). Run the command first with the whatif flag, then without it once you have confirmed that the command will do what you want.  

    [!code-console[Main](migrate-a-web-site-from-iis-60-to-iis-7-or-above/samples/sample7.cmd)]
4. Alternatively, run the following command to do a "pull" synchronization from the remote source to the local destination (replace Server1 with the name of the remote computer). Run the command first with the whatif flag, then without it once you have confirmed that the command will do what you want.  

    [!code-console[Main](migrate-a-web-site-from-iis-60-to-iis-7-or-above/samples/sample8.cmd)]

You are now done migrating your site. To verify, test browsing to the web site on the destination server. For troubleshooting help, see [Troubleshooting Web Deploy](../troubleshooting-web-deploy/troubleshooting-web-deploy.md "Troubleshooting Web Deploy").

### Summary

You have now synchronized a Web site from a source IIS 6.0 server to a destination IIS 7 or above server by viewing the dependencies, configuring the destination IIS server, and by using a package file or the Web Deployment Agent Service.
  
  
[Discuss in IIS Forums](https://forums.iis.net/1144.aspx)