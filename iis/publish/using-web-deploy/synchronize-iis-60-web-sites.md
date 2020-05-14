---
title: "Synchronize IIS 6.0 Web Sites"
author: rick-anderson
description: "This quick guide will guide you through the process of using the Web Deployment Tool to synchronize a Web site fon an IIS 6.0 source computer to an IIS 6.0 d..."
ms.date: 04/07/2008
ms.assetid: d9e0150b-0bca-4920-a2b6-5109b8454a94
msc.legacyurl: /learn/publish/using-web-deploy/synchronize-iis-60-web-sites
msc.type: authoredcontent
---
Synchronize IIS 6.0 Web Sites
====================
by Faith A

This quick guide will guide you through the process of using the Web Deployment Tool to synchronize a Web site fon an IIS 6.0 source computer to an IIS 6.0 destination computer. You can do this by "pushing" data to a remote destination, or by "pulling" data from a remote source. This guide will show both methods, as well as an option to use a package file so that you do not have to install the Web Deployment Agent Service (MsDepSvc, or "remote agent service".)

**What are the ways you can synchronize by using the Web Deployment Tool?**

- Push (synchronize from a local source to a remote destination)
- Pull (synchronize from a remote source to a local destination)
- Independent Sync (initiate a synchronization from a computer where both destination and source are remote)
- Manual Local Sync (create a package file of the source and copy it to the destination, then run it locally)

### Prerequisites

This guide requires the following prerequisites:

- .NET Framework 2.0 SP1 or greater
- Web Deployment Tool 1.1

Note: If you have not already installed the Web Deployment Tool, see [Installing Web Deploy](use-the-web-deployment-tool.md "Installing the Web Deploy").

### Part 1 - View your site's dependencies

1. Get the dependencies of the Web site by running the following command:  

    [!code-console[Main](synchronize-iis-60-web-sites/samples/sample1.cmd)]
2. Review the output of the dependencies and look for any script maps or installed components that are in use by the site. For example, if Windows Authentication is in use by the Web site, you will see &lt;dependency name="WindowsAuthentication" /&gt;.
3. If your site is inheriting any script maps, these will not be listed in the dependencies and you should also review the script maps for your site manually.
4. Compile a list of the components needed on the destination.

For detailed steps on analyzing the output of getDependencies, see [Viewing Dependencies](https://technet.microsoft.com/library/dd569091(WS.10).aspx "Viewing Dependencies").

### Part 2 - Configure the target (destination)

1. Review the list of dependencies and install them on the destination server. For example, let's assume you had the following in use for your Web site:

    - ASP.NET
    - Windows Authentication
    - Anonymous Authentication

   Based on this analysis of your dependencies, you would install the corresponding components on the destination server before performing the synchronization.

### Part 3 – Synchronize your site to the target

1. Always make a backup of the destination and source servers. Even if you are just testing, it allows you to easily restore the state of your server.  

    [!code-console[Main](synchronize-iis-60-web-sites/samples/sample2.cmd)]
2. Install the remote service on the source or the destination depending on if you want to "pull" the data from a remote source or "push" the data to a remote destination.
3. Start the service on the server.  

    [!code-console[Main](synchronize-iis-60-web-sites/samples/sample3.cmd)]
4. Run the following command to validate what would happen if the synchronization were run. The **-whatif** flag will not show every change; it will just show an optimistic view of what might change if everything succeeds (for example, it won't catch errors where you can't write to the destination.)  

    - Pushing to remote destination, running on source machine (the **computerName** argument identifies the remote destination computer).  

        [!code-console[Main](synchronize-iis-60-web-sites/samples/sample4.cmd)]
    - Pulling from a remote source, running on destination machine (the **computerName** argument identifies the remote source computer).  

        [!code-console[Main](synchronize-iis-60-web-sites/samples/sample5.cmd)]
5. After verifying the output, run the same command again without the **-whatif** flag:  

    - Pushing to remote destination, running on source machine  

        [!code-console[Main](synchronize-iis-60-web-sites/samples/sample6.cmd)]
    - Pulling from a remote source, running on destination machine  

        [!code-console[Main](synchronize-iis-60-web-sites/samples/sample7.cmd)]

### {Optional - Synchronize your site to the target by using a package file}

If you don't wish to use the remote service, you can use a package (compressed file) instead.

1. Run the following command on the destination server to create a package of the Web site source:  

    [!code-console[Main](synchronize-iis-60-web-sites/samples/sample8.cmd)]
2. Copy the package file to the destination server.
3. Run the following command on the destination server to validate what would happen if the synchronization were run:  

    [!code-console[Main](synchronize-iis-60-web-sites/samples/sample9.cmd)]
4. After verifying the output, run the same command again without the whatif flag:  

    [!code-console[Main](synchronize-iis-60-web-sites/samples/sample10.cmd)]

You are now done synchronizing your site. To verify, test browsing to the Web site on the destination server. For troubleshooting help, see [Troubleshooting Web Deploy](../troubleshooting-web-deploy/troubleshooting-web-deploy.md "Troubleshooting Web Deploy").

### Summary

You synchronized a Web site from a source IIS 6.0 server to a destination IIS 6.0 server by viewing the dependencies, configuring the destination IIS 6.0 server, and by using the Web Deployment Agent Service or a package file.
