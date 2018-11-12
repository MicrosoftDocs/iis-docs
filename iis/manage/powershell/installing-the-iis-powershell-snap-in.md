---
title: "Installing the IIS 7.0 PowerShell Snap-in | Microsoft Docs"
author: thomasdeml
description: "In the following walkthrough you will learn how to install the IIS PowerShell Snap-in and how to start the IIS PowerShell Management Console. Prerequisites T..."
ms.author: iiscontent
manager: soshir
ms.date: 04/14/2008
ms.topic: article
ms.assetid: 46ae3bb1-3a75-4747-a646-6185b80a99e4
ms.technology: iis-manage
ms.prod: iis
msc.legacyurl: /learn/manage/powershell/installing-the-iis-powershell-snap-in
msc.type: authoredcontent
---
Installing the IIS 7.0 PowerShell Snap-in
====================
by [Thomas Deml](https://github.com/thomasdeml)

## Introduction

In the following walkthrough you will learn how to install the IIS PowerShell Snap-in and how to start the IIS PowerShell Management Console.

### Prerequisites

The IIS PowerShell Snap-in requires the following prerequisites:

- Windows Server 2008, Windows Server 2008 R2, Windows Vista Service Pack 1, or Windows 7
- Microsoft PowerShell 1.0 or 2.0

### To install IIS PowerShell Snap-in:

1. The IIS PowerShell Snap-in is available as x86 and x64 version. Download the [32-Bit version](https://iis.net/downloads/default.aspx?tabid=34&amp;g=6&amp;i=1664 "32-Bit IIS 7.0 PowerShell Provider") or [64-Bit version](https://iis.net/downloads/default.aspx?tabid=34&amp;g=6&amp;i=1665 "64-Bit PowerShell Provider").
2. Run the MSI file to install the IIS PowerShell Snap-in.

### To use the IIS PowerShell Snap-in

PowerShell snap-ins like the IIS PowerShell Snap-in have to be registered with PowerShell. There are two ways to do this:

#### Automatic Registration by using the IIS PowerShell Management Console

The IIS PowerShell Snap-in setup will create a new Program Menu shortcut. By starting this shortcut the IIS PowerShell Snap-in will be registered automatically. Click on the Start Menu - select "All Programs" - "IIS 7.0 Extensions" - "IIS PowerShell Management Console". The prompt of the new PowerShell command window is set to "IIS:\" - the root of the IIS Snap-in namespace.

#### Manual Registration

If you want to use the IIS PowerShell Snap-in in an existing PowerShell command window you have to register the IIS snap-in manually. You can do this by simply executing the IISConsole.PSC1 file located in the "$env:programfiles\IIS\PowerShellProvider" directory:


[!code-powershell[Main](installing-the-iis-powershell-snap-in/samples/sample1.ps1)]


## A Word About Security

### User Access Control

You need Administrator privileges to manage IIS configuration. This means that you have to run PowerShell command windows elevated. Make sure you always start PowerShell via the "Run as Administrator" menu item.

### PowerShell Execution Policies

You might see the following error depending on the PowerShell Execution Permissions.


[!code-console[Main](installing-the-iis-powershell-snap-in/samples/sample2.cmd)]


Although the IIS PowerShell Provider files are all signed, PowerShell only trusts scripts that are signed by a 'Trusted Publisher' when it's execution policy is set to "Restricted". There are two ways you can fix this problem.

#### Relax the Execution Policy

If you see the error above your execution policy is probably set to "Restricted". To trust other code you can set the execution policy to "RemoteSigned" which allows local scripts to run without requiring a digital signature. Execute the following command in an elevated PowerShell window:


[!code-powershell[Main](installing-the-iis-powershell-snap-in/samples/sample3.ps1)]


Execute the following command if you want to know more about signing and execution policies.


[!code-console[Main](installing-the-iis-powershell-snap-in/samples/sample4.cmd)]


#### Trust Microsoft Code Signing Certificate to Trusted Publishers List

To trust the IIS Provider scripts and binaries you can hit "A" in the above dialog and it will add the code signing certificate used by the IIS Snap-in to the list of Trusted Publishers. You can get a list of "Trusted Publishers" with the following command:


[!code-console[Main](installing-the-iis-powershell-snap-in/samples/sample5.cmd)]


## Summary

In this walkthrough you learned how to automatically or manually install the IIS PowerShell Snap-in.