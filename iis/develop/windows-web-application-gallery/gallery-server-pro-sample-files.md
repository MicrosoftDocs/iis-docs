---
title: "Gallery Server Pro sample files"
author: rick-anderson
description: "This is a set of sample files you could use with Gallery Server Pro and the Web Deployment tool for deploying Gallery Server Pro on IIS. You can include a cu..."
ms.date: 07/21/2009
ms.assetid: a0991296-04e5-4a8a-8d67-8a79d6754405
msc.legacyurl: /learn/develop/windows-web-application-gallery/gallery-server-pro-sample-files
msc.type: authoredcontent
---
# Gallery Server Pro sample files

by Steve Jacobson

> [!NOTE]
> The Windows Web Application Gallery (WWAG) is being retired on July 1, 2021. We are no longer taking submissions via the Submission Portal. Please contact webpi@microsoft.com to make updates to your existing submission.

This is a set of sample files you could use with Gallery Server Pro and the Web Deployment tool for deploying Gallery Server Pro on IIS. You can include a custom `_SqlMembership.txt` file to parameterize the Application's admin username and password that can be used by the application to setup the application administrator credentials.  
  
The files are annotated with comments that explain specific lines in the files you'll need to customize for your configuration.

## Sample manifest.xml file

[!code-xml[Main](gallery-server-pro-sample-files/samples/sample1.xml)]

## Sample parameters.xml file

[!code-xml[Main](gallery-server-pro-sample-files/samples/sample2.xml)]

## Sample App\_Data\\_SqlMembership.txt file

[!code-console[Main](gallery-server-pro-sample-files/samples/sample3.cmd)]
