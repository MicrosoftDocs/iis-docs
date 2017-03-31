---
title: "Gallery Server Pro sample files | Microsoft Docs"
author: rick-anderson
description: "This is a set of sample files you could use with Gallery Server Pro and the Web Deployment tool for deploying Gallery Server Pro on IIS. You can include a cu..."
ms.author: iiscontent
manager: soshir
ms.date: 07/21/2009
ms.topic: article
ms.assetid: 
ms.technology: iis-develop
ms.prod: iis
msc.legacyurl: /learn/develop/windows-web-application-gallery/gallery-server-pro-sample-files
msc.type: authoredcontent
---
Gallery Server Pro sample files
====================
by Steve Jacobson

This is a set of sample files you could use with Gallery Server Pro and the Web Deployment tool for deploying Gallery Server Pro on IIS. You can include a custom `_SqlMembership.txt` file to parameterize the Application's admin username and password that can be used by the application to setup the application administrator credentials.  
  
The files are annotated with comments that explain specific lines in the files you'll need to customize for your configuration.

## Sample manifest.xml file

[!code-xml[Main](gallery-server-pro-sample-files/samples/sample1.xml)]

## Sample parameters.xml file

[!code-xml[Main](gallery-server-pro-sample-files/samples/sample2.xml)]

## Sample App\_Data\\_SqlMembership.txt file

[!code-unknown[Main](gallery-server-pro-sample-files/samples/sample-127310-3.unknown)]