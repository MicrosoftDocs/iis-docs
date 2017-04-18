---
title: "Packaging and Restoring a Web site | Microsoft Docs"
author: rick-anderson
description: "This quick guide will show you how to create an package (compressed file) of a Web site, and then restore the site from the package. Prerequisites This guide..."
ms.author: iiscontent
manager: soshir
ms.date: 03/23/2008
ms.topic: article
ms.assetid: 7ba4c586-84ea-4cf6-91bd-f6ff2e73757e
ms.technology: iis-publish
ms.prod: iis
msc.legacyurl: /learn/publish/using-web-deploy/packaging-and-restoring-a-web-site
msc.type: authoredcontent
---
Packaging and Restoring a Web site
====================
by Faith A

This quick guide will show you how to create an package (compressed file) of a Web site, and then restore the site from the package.

## Prerequisites

This guide requires the following prerequisites:

- .NET Framework 2.0 SP1 or greater
- Web Deployment Tool 1.1

Note: If you have not already installed the Web Deployment Tool, see [Installing Web Deploy](use-the-web-deployment-tool.md "Installing Web Deploy").

## To package and restore an IIS 6.0 Web site

1. To create a package, run the following command:  

    [!code-console[Main](packaging-and-restoring-a-web-site/samples/sample1.cmd)]
2. To restore the package, run the following command:  

    [!code-console[Main](packaging-and-restoring-a-web-site/samples/sample2.cmd)]

## To package and restore an IIS 7 or Above Web site

1. To create a package, run the following command:  

    [!code-console[Main](packaging-and-restoring-a-web-site/samples/sample3.cmd)]
2. To restore the package, run the following command:  

    [!code-console[Main](packaging-and-restoring-a-web-site/samples/sample4.cmd)]

## Options for packaging multiple sites or objects

If you need to package a second directory outside the scope of your Web site, or you want to include other sites or objects, you have two options:

- Package each of them separately
- Create a manifest file to package multiple paths (see [Using Custom Manifests](using-custom-manifests.md "Using Custom Manifests"))

## Summary

You have now created a package of a Web site, and restored the site from the package. This is useful if you need to revert to a prior version of the site, or if files have become corrupt or missing from the site's content directory.

[Discuss in IIS Forums](https://forums.iis.net/1144.aspx)