---
title: "Blogengine .NET Sample files"
author: rick-anderson
description: "This is a set of sample files you could use with Blogengine .NET and the Web Deployment tool for deploying it on IIS. The manifest.xml and parameters.xml her..."
ms.date: 07/09/2009
ms.assetid: 1f41da75-1fde-433e-af1e-d29f8b187478
msc.legacyurl: /learn/develop/windows-web-application-gallery/blogengine-net-sample-files
msc.type: authoredcontent
---
# Blogengine .NET Sample files

by Steve Jacobson

> [!NOTE]
> The Windows Web Application Gallery (WWAG) is being retired on July 1, 2021. We are no longer taking submissions via the Submission Portal. Please contact webpi@microsoft.com to make updates to your existing submission.

This is a set of sample files you could use with Blogengine .NET and the Web Deployment tool for deploying it on IIS. The `manifest.xml` and `parameters.xml` here are used to set the appropriate permissions and deploy the files to a web server . This application uses a file data store within App\_Data directory and hence requires that this directory have ReadAndExecute,Write,Delete permissions .

The files are annotated with comments that explain specific lines in the files you'll need to customize for your configuration.

## Sample manifest.xml file

[!code-xml[Main](blogengine-net-sample-files/samples/sample1.xml)]

## Sample parameters.xml

[!code-xml[Main](blogengine-net-sample-files/samples/sample2.xml)]
