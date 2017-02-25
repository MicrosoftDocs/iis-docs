---
title: "Synchronize IIS | Microsoft Docs"
author: rick-anderson
description: "This quick guide will guide you through the process of using the Web Deployment Tool to synchronize a Web site on an IIS source computer to an IIS destinatio..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 04/07/2008
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/publish/using-web-deploy/synchronize-iis
msc.type: authoredcontent
---
Synchronize IIS
====================
by Faith A

This quick guide will guide you through the process of using the Web Deployment Tool to synchronize a Web site on an IIS source computer to an IIS destination computer. You can do this by "pushing" data to a remote destination, or by "pulling" data from a remote source. This guide will show both methods, as well as an option to use a package file so that you do not have to install the Web Deployment Agent Service (MsDepSvc, or "remote agent service".)

**What are the ways you can synchronize** **using the Web Deployment Tool?**

- Push (synchronize from a local source to a remote destination)
- Pull (synchronize from a remote source to a local destination)
- Independent Sync (initiate a synchronization from a computer where both destination and source are remote)
- Manual Local Sync (create a package file of the source and copy it to the destination, then run it locally)

### Prerequisites

This guide requires the following prerequisites:

- .NET Framework 2.0 SP1 or greater
- Web Deployment Tool 1.1

Note: If you have not already installed the Web Deployment Tool, see [Installing and Configuring Web Deploy](../../install/installing-publishing-technologies/installing-and-configuring-web-deploy.md "Installing Web Deploy").

### Part 1 - View your site's dependencies

1. Get the dependencies of the Web site by running the following command:

> [!code-unknown[Main](synchronize-iis/samples/sample-127155-1.unknown)]


2. Review the output of the dependencies and look for any script maps or installed components that are in use by the site. For example, if Windows Authentication is in use by the Web site, you will see &lt;dependency name="WindowsAuthentication" /&gt;.

3. If your site is inheriting any script maps, these will not be listed in the dependencies and you should also review the script maps for your site manually.

4. Compile a list of the components needed on the destination.

For detailed steps on analyzing the output of getDependencies, see [Viewing Web Site Dependencies](viewing-web-site-dependencies.md "Viewing Web Site Dependencies").

### Part 2 - Configure the target (destination)

1. Review the list of dependencies and install them on the destination server.

For example, let's assume you had the following in use for your Web site:

> • ASP.NET


> • Windows Authentication


> • Anonymous Authentication


Based on analyzing your dependencies, you would install those components on the destination server before performing the synchronization.

### Part 3 – Synchronize your site to the target

1. Always make a backup of the destination and source servers. Even if you are just testing, it allows you to easily restore the state of your server. Run the following command to backup an IIS 7 or above server:

[!code-console[Main](synchronize-iis/samples/sample2.cmd)]

2. Install the remote agent service on the source or the destination depending on if you want to "pull" the data from a remote source or "push" the data to a remote destination.

3. Start the service on the computer.

[!code-console[Main](synchronize-iis/samples/sample3.cmd)]

4. Run the following command to validate what would happen if the synchronization were run. The **-whatif** flag will not show every change; it will just show an optimistic view of what might change if everything succeeds (for example, it won't catch errors where you can't write to the destination.)

> *Pushing to remote destination, running on source computer (the computerName argument identifies the remote destination computer).*
> 
> [!code-unknown[Main](synchronize-iis/samples/sample-127155-4.unknown)]
> 
> *Pulling from a remote source, running on destination machine (the computerName argument identifies the remote source computer).*
> 
> [!code-unknown[Main](synchronize-iis/samples/sample-127155-5.unknown)]


5. After verifying the output, run the same command again without the **-whatif** flag:

> *Pushing to remote destination, running on source machine*
> 
> [!code-unknown[Main](synchronize-iis/samples/sample-127155-6.unknown)]
> 
> *Pulling from a remote source, running on destination machine*
> 
> [!code-unknown[Main](synchronize-iis/samples/sample-127155-7.unknown)]


### {Optional - Synchronize your site to the target by using a package file}

If you don't wish to use the remote service, you can use a package (compressed file) instead.

1. Run the following command on the source server to create a package of the Web site for synchronization:

> [!code-unknown[Main](synchronize-iis/samples/sample-127155-8.unknown)]


2. Copy the package file to the destination server.

3. Run the following command on the destination server to validate what would happen if the synchronization were run:

> [!code-unknown[Main](synchronize-iis/samples/sample-127155-9.unknown)]


4. After verifying the output, run the same command again without the -whatif flag:

> [!code-unknown[Main](synchronize-iis/samples/sample-127155-10.unknown)]


You are now done synchronizing your site. To verify, test browsing to the Web site on the destination server. For troubleshooting help, see [Troubleshooting Web Deploy](../troubleshooting-web-deploy/troubleshooting-web-deploy.md "Troubleshooting Web Deploy").

### Summary

You have now synchronized a web site from a source IIS server to a destination IIS server, including viewing the dependencies, configuring the destination IIS server and performing the synchronization.
  
  
[Discuss in IIS Forums](https://forums.iis.net/1144.aspx)