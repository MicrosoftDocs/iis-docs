---
title: "Synchronizing Two IIS Servers with PHP | Microsoft Docs"
author: rick-anderson
description: "This article will guide you through the process of using Web Deploy to synchronize an entire IIS 7 or above Web server that has PHP installed to another IIS..."
ms.author: iiscontent
manager: soshir
ms.date: 03/26/2010
ms.topic: article
ms.assetid: d8ca581b-fa82-4fca-824f-3456f71799b7
ms.technology: iis-publish
ms.prod: iis
msc.legacyurl: /learn/publish/using-web-deploy/synchronizing-two-iis-servers-with-php
msc.type: authoredcontent
---
Synchronizing Two IIS Servers with PHP
====================
by Tim Ammann

This article will guide you through the process of using Web Deploy to synchronize an entire IIS 7 or above Web server that has PHP installed to another IIS 7 or above server. Article Goal: To synchronize a Web server from IIS that has PHP installed to another IIS server.

### Part 1 - View dependencies of the source

1. Get the dependencies of the Web site by running the following command:  

    [!code-console[Main](synchronizing-two-iis-servers-with-php/samples/sample1.cmd)]
2. Review the output of the dependencies and look for any script maps or installed components that are in use by the site.  

    > [!NOTE]
    > In most cases on Windows Server 2008, PHP is installed by using the built-in FastCGI module, so the dependency check will show CGI as a dependency, not PHP.
3. Compile a list of the components needed on the destination.

For detailed steps on analyzing the output of getDependencies, see [Viewing Dependencies](https://technet.microsoft.com/en-us/library/dd569091(WS.10).aspx "Viewing Dependencies").

### Part 2 - Configure the target or destination computer

1. Review the list of dependencies and install them on the destination server. For example, let's assume you had the following in use for your Web site:  

    - CGI (FastCGI with PHP).

Based this analysis of your dependencies, you would install those components on the destination server. Because PHP can be installed by simply copying the files, we will add a custom manifest that also copies the PHP folder.

### Part 3 – Create a custom manifest

Create the following manifest, assuming that your PHP install location is c:\php (replace with your actual install directory):

[!code-xml[Main](synchronizing-two-iis-servers-with-php/samples/sample2.xml)]

Save this as **ServerManifest.xml**. For convenience, you can save it into the "%systemdrive%\program files\microsoft web deploy" directory, or to a directory of your choice. You should save it to both the source and destination computers.

### Part 4 – Synchronize the source server to the destination server

#### Synchronize by using a package file:

1. Always make a backup of the destination server. Even if you are just testing, it allows you to easily restore the state of your server. Run the following command to backup an IIS server:  

    [!code-console[Main](synchronizing-two-iis-servers-with-php/samples/sample3.cmd)]
2. Run the following command on the source server to create a package (compressed file) of the server:  

    [!code-console[Main](synchronizing-two-iis-servers-with-php/samples/sample4.cmd)]
3. Run the following command on the destination server to validate what would happen if a synchronization were run:  

    [!code-console[Main](synchronizing-two-iis-servers-with-php/samples/sample5.cmd)]
4. After verifying the output, run the same command again without the -whatif flag:  

    [!code-console[Main](synchronizing-two-iis-servers-with-php/samples/sample6.cmd)]

#### Synchronize by using the remote service:

If you don't want to synchronize from a package, you can synchronize by using the Web Deployment Agent Service (MsDepSvc, also called the "remote service").

1. Make sure that the service is started on the destination computer by running the command:  

    [!code-console[Main](synchronizing-two-iis-servers-with-php/samples/sample7.cmd)]
2. Run the following command on the source server. Use the **computerName** argument to specify the name of a remote server (for example, DestServer1). If the source is a remote server, you would change the source argument to source:manifest=servermanifest.xml,**computerName=Server1**.  

    [!code-console[Main](synchronizing-two-iis-servers-with-php/samples/sample8.cmd)]
3. After verifying the output, run the same command again without the whatif flag:  

    [!code-console[Main](synchronizing-two-iis-servers-with-php/samples/sample9.cmd)]

### Summary

You are now done synchronizing your site. To verify, test browsing to the Web site on the destination server. For troubleshooting help, see [Troubleshooting Web Deploy](../troubleshooting-web-deploy/troubleshooting-web-deploy.md "Troubleshooting MS Deploy"). You synchronized a Web site from a source IIS server to a destination IIS server by viewing the dependencies, configuring the destination IIS server, and by using a package file or the Web Deployment Agent Service.

[Discuss in IIS Forums](https://forums.iis.net/1144.aspx)