---
title: "AppCmd.exe | Microsoft Docs"
author: walterov
description: "AppCmd.exe can be used to provision Web sites and run many commands to edit configuration. Creating and Configuring Use the following code samples for implem..."
ms.author: iiscontent
manager: soshir
ms.date: 12/02/2007
ms.topic: article
ms.assetid: 
ms.technology: iis-manage
ms.prod: iis
msc.legacyurl: /learn/manage/provisioning-and-managing-iis/appcmdexe
msc.type: authoredcontent
---
AppCmd.exe
====================
by [Walter Oliver](https://github.com/walterov)

## Introduction

AppCmd.exe can be used to provision Web sites and run many commands to edit configuration.

## Creating and Configuring

Use the following code samples for implementing AppCmd.exe.

**To create a site and an application pool (with failed request tracing and W3svc log file locations)**

[!code-console[Main](appcmdexe/samples/sample1.cmd)]

[!code-console[Main](appcmdexe/samples/sample2.cmd)]


[!code-console[Main](appcmdexe/samples/sample3.cmd)]


**To configure the Failed Request Tracing log file location**


[!code-console[Main](appcmdexe/samples/sample4.cmd)]


**To configure the W3SVC log file location**


[!code-console[Main](appcmdexe/samples/sample5.cmd)]