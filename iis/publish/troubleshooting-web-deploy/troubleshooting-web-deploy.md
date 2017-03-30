---
title: "Troubleshooting Web Deploy | Microsoft Docs"
author: rick-anderson
description: "This quick guide will help you troubleshoot Web Deploy (Web Deployment Tool). Prerequisites This guide requires the following prerequisites: .NET Framework 2..."
ms.author: iiscontent
manager: soshir
ms.date: 03/23/2008
ms.topic: article
ms.assetid: 
ms.technology: iis-publish
ms.prod: iis
msc.legacyurl: /learn/publish/troubleshooting-web-deploy/troubleshooting-web-deploy
msc.type: authoredcontent
---
Troubleshooting Web Deploy
====================
by Faith A

This quick guide will help you troubleshoot Web Deploy (Web Deployment Tool).

## Prerequisites

This guide requires the following prerequisites:

- .NET Framework 2.0 SP1 or greater
- Web Deploy 1.0 or greater

Note: If you have not already installed Web Deploy, see [Installing Web Deploy](../using-web-deploy/use-the-web-deployment-tool.md "Installing the Web Deploy").

### Troubleshooting operations

The first level of validation for an operation should be the **-whatif** flag. The -whatif flag will show you what would happen if you ran a command and everything was successful. It is intended to be a comparison flag, and will not show you many errors. But if the operation did not go as expected and –whatif did not find any issues, you can use the –verbose flag to specify output settings. This is very useful if you need to determine what failed to sync, and often gives additional detail about the operation.

### To run with verbose output

Let's say we were running a sync operation. Run the command again, with -verbose specified:

[!code-powershell[Main](troubleshooting-web-deploy/samples/sample1.ps1)]

By specifying &gt; msdeploysync-verbose.log, the results of the operation and all the extra informational alerts will be listed in the log file and we can easily refer back to it.

Depending on the error, you should look through the log for related entries. For example, if a property wasn't set correctly, check the verbose logging actions to see why it was missed or skipped.

### Common errors

Cannot read configuration file or similar error may be due to running from a non-elevated command prompt on Windows Server 2008. Ensure you have administrative credentials for operations like reading or writing configuration or registry settings.

An assembly or other object with commas in its path does not sync correctly. This is a known issue and requires using double and single quotes around the path. For example, the path to an assembly contains commas and must be specially treated: -source:gacAssembly="'System.Web, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'"

If your site has no ServerComment set on IIS 6.0, the ABO Mapper component will be unable to recognize them on IIS 7.0 and above, and they will not be migrated correctly.

If you do not have IIS installed on the source or destination machine when you are trying to access IIS-related providers such as metakey or apphostconfig, you may receive the following error message:

[!code-unknown[Main](troubleshooting-web-deploy/samples/sample-127152-2.unknown)]

### Remote service errors

404 Remote file not found – the remote service is not installed or running, or the URL is incorrect. It is a Manual startup service so make sure that it is running.

The connection to the remote machine times out or returns a timeout error – verify that the port for the remote service is open on the target machine. If it is open, re-try the command. Many times it will work after a retry.

### Summary

You have run operations with tracing or verbosity enabled as well as learned some errors that can occur. This guide will be updated to include additional error cases and troubleshooting tips.

[Discuss in IIS Forums](https://forums.iis.net/1144.aspx)