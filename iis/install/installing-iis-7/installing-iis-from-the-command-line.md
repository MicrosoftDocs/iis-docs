---
title: "Installing IIS 7.0 from the Command Line | Microsoft Docs"
author: rick-anderson
description: "Pkgmgr.exe is a new command tool in Windows Vista ® / Windows Server ® 2008 for installing Windows Optional Features: Replaces sysocmgr.exe for installing Wi..."
ms.author: iiscontent
manager: soshir
ms.date: 11/22/2007
ms.topic: article
ms.assetid: af287d62-e8f0-4ff7-8cbc-3d61e840d3f7
ms.technology: iis-install
ms.prod: iis
msc.legacyurl: /learn/install/installing-iis-7/installing-iis-from-the-command-line
msc.type: authoredcontent
---
Installing IIS 7.0 from the Command Line
====================
by [Saad Ladki](https://twitter.com/saadladki)

## Introduction

Pkgmgr.exe is a new command tool in Windows Vista® / Windows Server® 2008 for installing Windows Optional Features:

- Replaces sysocmgr.exe for installing Windows Optional Features
- Allows you to install / uninstall Windows Vista Optional Features directly from command prompt or from scripts

Pkgmgr can take a list of windows features to install on the command line or take an xml file name as a parameter for unattend installs. This lab will illustrate the use of pkgmgr command line parameters for installing optional features.

## Prerequisites

**Windows Vista/Windows Server 2008 Editions Supported**

This walkthrough is for the following editions of Windows Vista / Windows Server 2008:

- Windows Vista Home Premium Edition
- Windows Vista Professional Edition
- Windows Vista Ultimate Edition
- Windows Server 2008 Editions

Make sure you have installed one of the supported editions of Windows Vista/Windows Server 2008 before proceeding. For more information on IIS 7.0 on Windows Vista, please review the article [IIS 7.0 Features and Vista Editions](compatibility-and-feature-requirements-for-windows-vista.md) before continuing.

### Local User Administrator (LUA) Security

Make sure you have administrative privileges on the machine: By default, you do not have them if you are logged on as a user other than the built-in Administrator account, even if this user was added to the local Administrators group on the machine (this is a new security feature in Windows Server 2008, called LUA, which is beyond the scope of this article). Make sure to either log-on as the built-in Administrator account, or explicitly invoke applications as the built-in Administrator, as needed, using the "runas" cmd-line tool.

For example, to launch notepad.exe you could run this command: "runas /user:administrator notepad.exe". You will be prompted for the password of the Administrator account. It is useful to have a cmd-box shell that's already elevated, by running "runas /user:administrator cmd.exe". Every application you run from that cmd-box will be elevated as well, and you will not need to use the "runas" syntax from that cmd-box.

If you are logged on to an account other than the built in local administrator account you may see the following security alert dialog. Click **Allow** to continue running setup steps in this walkthrough.

### Windows Security Dialog – LUA

If you are logged on to an account other than the built in local administrator account you may see the following security alert dialog box.  
[![](installing-iis-from-the-command-line/_static/image2.jpg)](installing-iis-from-the-command-line/_static/image1.jpg)

Figure 1: Windows Security Dialog

Click **Allow** to continue running the setup steps in this walkthrough.

## Procedure

### Step 1: Pkgmgr.exe Overview

Windows Optional features in Vista/Windows Server 2008 can be installed using a new command tool called Pkgmgr. The command line syntax using pkgmgr.exe is:

[!code-console[Main](installing-iis-from-the-command-line/samples/sample1.cmd)]

Pkgmgr.exe Commands

- **/iu:{update name};** &mdash; Specifies updates to install by update name. Takes a semicolon separated name of updates to install.
- **/uu:{update name};** &mdash; Specifies the updates to uninstall. Takes a semicolon separated list of selectable updates to be uninstalled from the system. At least one update name must be specified.
- **/n:{unattend XML}** &mdash; Specifies file name of the unattend XML file.

> [!NOTE]
> If you run pkgmgr without the "start /w" prefix, the pkgmgr cmd will return immediately and you will not know when the optional feature install has completed.

### Step 2: Open Command Window

Follow the instructions in the Prerequisites section above for starting a cmd window running as the local Administrator account.

### Step 3: Enter Command to Install IIS 7.0 Default Features

To install only the IIS 7.0 default features from the command line, copy the following text into your command window and then proceed to Step 5.

> [!NOTE]
> Make sure you are pasting ascii text from a Web page: To make sure you are not getting any non-ascii text you may want to past content into notepad.exe first. The entire block below is one command.

IIS 7.0 setup via pkgmgr.exe should take 1 to 5 minutes. When the command prompt returns, IIS 7.0 setup is complete.

[!code-console[Main](installing-iis-from-the-command-line/samples/sample2.cmd)]

### Step 4: Command to Install All IIS 7.0 Features

If you want to install all IIS 7.0 features, use these command lines.

If you are installing IIS 7.0 on Windows Vista Professional, Windows Vista Ultimate, or Windows Server 2008 Editions, copy and paste the following text into the command window:


[!code-console[Main](installing-iis-from-the-command-line/samples/sample3.cmd)]


If you are installing IIS 7.0 on Windows Vista Home Premium, copy and paste the following text into the command window:


[!code-console[Main](installing-iis-from-the-command-line/samples/sample4.cmd)]


### Step 5: Check Error Code

At the command prompt type:

[!code-console[Main](installing-iis-from-the-command-line/samples/sample5.cmd)]

An error code of 0 indicates success.

### Step 6: Check IIS 7.0 Install

You can now perform a quick check to verify that IIS 7.0 is installed:

- Start Internet Explorer web browser and enter the address [http://localhost](http://localhost/).
- You should see the default IIS 7.0 "Welcome" page.

## Summary

In this article we examined how to use the pkgmgr.exe command line tool for installing IIS 7.0.

## Related Links

See the following resources for further information:

- [Install IIS 7.0 on Windows Server](installing-iis-7-and-above-on-windows-server-2008-or-windows-server-2008-r2.md) 2008
- [Install IIS 7.0 on Windows Vista](installing-iis-on-windows-vista-and-windows-7.md)
- [Use Unattended Install with IIS 7 and Above](using-unattended-setup-to-install-iis.md)
- [Install Typical IIS Workloads](install-typical-iis-workloads.md)

[Discuss in IIS Forums](https://forums.iis.net/1041.aspx)