---
title: "Using Custom Manifests | Microsoft Docs"
author: rick-anderson
description: "This quick guide will help you create a custom manifest and synchronize it. We will synchronize a Web site and include the application pool, an external dire..."
ms.author: iiscontent
manager: soshir
ms.date: 03/23/2008
ms.topic: article
ms.assetid: 68c0a088-a45f-4ea6-8e3d-a5876f949f29
ms.technology: iis-publish
ms.prod: iis
msc.legacyurl: /learn/publish/using-web-deploy/using-custom-manifests
msc.type: authoredcontent
---
Using Custom Manifests
====================
by Faith A

This quick guide will help you create a custom manifest and synchronize it. We will synchronize a Web site and include the application pool, an external directory, and an assembly and COM object that are not automatically gathered for a Web site.

## Prerequisites

This guide requires the following prerequisites:

- .NET Framework 2.0 SP1 or greater
- Web Deployment Tool 1.1

Note: If you have not already installed the Web Deployment Tool, see [Installing Web Deploy](use-the-web-deployment-tool.md "Installing Web Deploy").

## Overview of a Manifest

A manifest is simply a grouping of providers into one definition file. It is a way of specifying multiple paths that will be included in a synchronization, such as a Web site, an application pool, and an assembly. It can be used to specify multiple Web sites, multiple directories or other paths.

Note: In this article, we show how to move an IIS 7 and above Web site and application pool, but you could also use the manifest on IIS 6.0 to specify an IIS 6.0 Web site and application pool.

## Sample manifest

[!code-xml[Main](using-custom-manifests/samples/sample1.xml)]

## To create and use a custom manifest

1. Open Notepad and create an XML file. Let's call it Custom.xml.
2. Copy the sample manifest into Custom.xml.
3. Copy Custom.xml into your installation directory, %programfiles%\IIS\Microsoft Web Deploy.
4. Create a directory called MyExtraFiles on your C: drive.
5. Run the following command to synchronize the objects in the manifest to a package (compressed) file:  

    [!code-console[Main](using-custom-manifests/samples/sample2.cmd)]

    By specifying &gt; WebDeployPackage.log, the results of the package will be listed in the log file and you can easily refer back to it.

Open the package. You should see the site itself and the extra directory specified.

Later, you can use the package as the source and synchronize it to a destination that is specified by the manifest file (meaning you'll synchronize from the package to the providers that are specified in your manifest).

You can also perform a **sync** operation with a manifest live, without using a package. In order to synchronize with a manifest, both the source and the destination arguments must specify a manifest file.

## To synchronize a site by using a custom manifest

1. Run the following command to synchronize the manifest to a remote destination. The remote computer is specified by the **computername** argument.  

    [!code-console[Main](using-custom-manifests/samples/sample3.cmd)]

## Summary

You have now created a custom manifest and used it for synchronization. You can further extend the manifest by adding any provider paths that are important for your Web site or server, such as a registry key or an assembly in the GAC. For more information about the manifest provider, see [Web Deploy manifest Provider](https://technet.microsoft.com/en-us/library/dd569104.aspx "MS Deploy manifest Provider").