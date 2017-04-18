---
title: "Taking an Application Offline before Publishing | Microsoft Docs"
author: rick-anderson
description: "In Web Deploy V3, we added support to automatically take an ASP.Net application offline before publishing to it. This is useful if a user wants to ensure tha..."
ms.author: iiscontent
manager: soshir
ms.date: 07/26/2012
ms.topic: article
ms.assetid: 116712ee-4e7c-4042-8c7d-12dccbff8254
ms.technology: iis-publish
ms.prod: iis
msc.legacyurl: /learn/publish/deploying-application-packages/taking-an-application-offline-before-publishing
msc.type: authoredcontent
---
Taking an Application Offline before Publishing
====================
by [Harsh Mittal](https://twitter.com/harshmittal)

In Web Deploy V3, we added support to automatically take an ASP.Net application offline before publishing to it. This is useful if a user wants to ensure that their application does not have a lock on a file (e.g. SQL CE sdf files which only allow one connection to the file at a time) being overwritten, or if they want to ensure that visitors to their site cannot affect the publish process. The way it works is if Web Deploy detects that a change needs to be made on the destination server, it will automatically drop a blank App\_Offline.htm file into the root of the application folder. When ASP.Net detects that a file by the name of "App\_Offline.htm" exists, it will automatically bring down the app domain hosting the application. When the publish process is completed, the App\_Offline.htm file will be removed and the site will be online again.

## Enabling Application Offline

Web Deploy takes an application offline by using the "AppOffline" rule, which is off by default. If a client wishes to turn it on during a publish operation, it simply needs to enable the rule. Here is an example of how to do this from the command line (executable lives under "%programfiles%\IIS\Microsoft Web Deploy V3"):

> [!code-console[Main](taking-an-application-offline-before-publishing/samples/sample1.cmd)]


### 

## What happens when a publish fails

If an error occurred during publishing, the htm file will remain in the site root to keep it offline because it is now in an unknown state. After fixing your publishing issue, you will need to bring the application back online. To do this, you can either manually delete the App\_Offline.htm file from your application root on the server, or republish your site. Here is an example of how to delete the App\_Offline.htm file from the command line:

> [!code-console[Main](taking-an-application-offline-before-publishing/samples/sample2.cmd)]