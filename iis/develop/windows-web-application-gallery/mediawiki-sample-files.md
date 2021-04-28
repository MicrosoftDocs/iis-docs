---
title: "MediaWiki Sample Files"
author: rick-anderson
description: "This is a set of sample files you could use with MediaWiki and the Web Deployment tool for deploying MediaWiki on IIS. The files are annotated with comments..."
ms.date: 07/29/2009
ms.assetid: 052e4fa7-82d5-41f8-8c22-a37428f6de27
msc.legacyurl: /learn/develop/windows-web-application-gallery/mediawiki-sample-files
msc.type: authoredcontent
---
# MediaWiki Sample Files

by Steve Jacobson

> [!NOTE]
> The Windows Web Application Gallery (WWAG) is being retired on July 1, 2021. We are no longer taking submissions via the Submission Portal. Please contact webpi@microsoft.com to make updates to your existing submission.

This is a set of sample files you could use with MediaWiki and the Web Deployment tool for deploying MediaWiki on IIS. The files are annotated with comments that explain specific lines in the files you'll need to customize for your configuration.

MediaWiki has an installation routine that takes care of creating the database using database super user privileges, so there is no requirement for using the Web Deployment Tool for that. However, MediaWiki could be set up to create the database from the Web Deployment Tool if that was preferred.

In addition, the MediaWiki installation routine creates the configuration file "LocalSettings.php" in the config sub directory. This requires the user to access the Operating System through either a command line, or the Explorer, to move the LocalSettings.php file to the application root. It might be worth investigating whether or not moving all of the steps for creating the database and LocalSettings.php file into the Web Deployment Tool would be worth the effort. The benfit would be that when the Web Deployment Tool (Or Web Platform Installer calling the WDT) was finished, the Wiki would be completely configured and ready for use. Or at least ready for the remaining system tests to be performed, and then to have the Wiki be used. The work invovled would be converting the PHP parameterization to WDT parameterization. The potential risk is that if the installation needed to change in any significant way, the change would have to be made in the MediaWiki installer, and in the WDT configuration files.

## Sample manifest.xml file

[!code-xml[Main](mediawiki-sample-files/samples/sample1.xml)]

## Sample parameters.xml file

[!code-xml[Main](mediawiki-sample-files/samples/sample2.xml)]

## Sample web.config file

[!code-xml[Main](mediawiki-sample-files/samples/sample3.xml)]
