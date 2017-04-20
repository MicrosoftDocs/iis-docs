---
title: "Automating server setup | Microsoft Docs"
author: bilalaslam
description: "This article explains how to provision an IIS frontend server with full WebMatrix compatibility in an automated manner. It fully automates all steps describe..."
ms.author: iiscontent
manager: soshir
ms.date: 01/05/2011
ms.topic: article
ms.assetid: 75449e45-0fee-4250-99d0-34b10b3aa051
ms.technology: iis-hosting
ms.prod: iis
msc.legacyurl: /learn/web-hosting/joining-the-web-hosting-gallery/automating-server-setup
msc.type: authoredcontent
---
Automating server setup
====================
by [Bilal Aslam](https://github.com/bilalaslam)

## Introduction

This article explains how to provision an IIS frontend server with full WebMatrix compatibility in an automated manner. It fully automates all steps described in the rest of this documentation, with one exception: a Microsoft SQL Server or MySQL Server is expected to be provisioned separately and is not covered here.

## Requirements

- Windows Server 2008 R2
- Powershell v1 enabled on the above server
- Internet connectivity on the above server (to download software requirements)

## Preparing to Run Scripts

1. Download the scripts from this location:

[https://go.microsoft.com/fwlink/?prd=12062&amp;pver=1.0&amp;sbp=WebMatrix&amp;plcid=0x409&amp;clcid=0x409&amp;ar=Hosting Kit&amp;sar=Scripts](https://go.microsoft.com/fwlink/?prd=12062&amp;pver=1.0&amp;sbp=WebMatrix&amp;plcid=0x409&amp;clcid=0x409&amp;ar=Hosting Kit&amp;sar=Scripts)

1. Extract them to `%systemdrive%\Webmatrix`
2. Launch a Powershell console in Administrator mode
3. Run this command: *Set-Executionpolicy Unrestricted - force*. This will allow the unsigned scripts to execute.

## Installing Software Requirements

The script pack contains a program called webpicmdline.exe in the \webpicmdline folder.

1. Open an elevated command prompt (cmd.exe, NOT Powershell)
2. Run this command to install the software stack:


[!code-console[Main](automating-server-setup/samples/sample1.cmd)]


## Configuring the Web Management Service

Run *.\01\_InitializeWebManagementService.ps1*. This script will do the following:

1. Set service startup type to Automatic
2. Enable remote connections
3. Enable tracing
4. Increase number of tracing logs files that are retained
5. Restart Web Management Service

## Creating Web Deploy Delegation Rules

The script .\02\_AddDelegationRules.ps1 creates Web Deploy delegation rules. This script will create the following delegation rules:

- contentPath,iisApp
- dbFullSql
- dbMySql
- createApp
- setAcl
- recycleApp
- appPoolNetFx
- appPoolPipeline

The script needs several parameter inputs for the rules to be created properly:

- elevatedUsername: username of a user who has Write access to applicationHost.config. Required for createApp, appPoolNetFx, appPoolPipeline rules.
- elevatedPassword: password of above user
- adminUsername: username of a user who is in the Administrators group on the IIS server. Required for recyleApp rule.
- adminPassword: password of above user.

Please note that the script CREATES these above users.

*.\02\_AddDelegationRules.ps1 -elevatedUsername wdeploy\_elevated -elevatedPassword &lt;password&gt; -adminUsername wdeploy\_admin -adminPassword &lt;password&gt;*

## Installing the Extensionless URL hotfix

Run *.\InstallExtensionlessUrlHotfix.ps1*

This will download and install the hotfix, KBKB980368.

> [!NOTE]
> We suppress server reboots during the hotfix installation. You may need to restart the server (shutdown /r) after the update installs.

## Virtual Dedicated: Creating and Assigning a New Self-signed Certificate

The Web Management Service is installed by default with a self-signed certificate. If you run sysprep after installing IIS (as is common with virtual dedicated servers), the self-signed certificate is no longer valid as the machine SID has changed, and you may see errors when connecting to the Web Management Service. You need to create a new self-signed certificate and assign it to the Web Management Service.

Run *.\00\_Certificate.ps1*. This script will:

- Remove the SSL binding of the old certificate on port 8172
- Create a new self-signed certificate
- Bind new self-signed certificate to port 8172
- Configure Web Management Service to use new self-signed certificate
- Restart Web Management Service

This script needs to run on the first logon into the image. If you do this as the very last step before running sysprep, it ensures the certificate script runs on the next login.

1. Start regedit.exe
2. Navigate to HKCU\Software\Microsoft\Windows\CurrentVersion
3. Create a key called RunOnce if it doesn't already exist
4. Right-click the RunOnce key add a new String value. Name the value anything (e.g. – "CertInitScript")
5. Double click the string value and add the following for its data: `%WinDir%\System32\WindowsPowerShell\v1.0\powershell.exe C:\WebMatrix\00\_Certificate.ps1`

Note: You can easily modify this script to assign an existing certificate (such as a trusted root certificate) to the Web Management Service. This is recommended so WebMatrix users do not see a certificate warning when publishing to your server.

## Known Issues

- 02\_AddDelegationRules.ps1 does not work with shared configuration. Workaround: change the GetApplicationHostConfigPath function in HostingCommon.psm1 to return the path to your shared configuration.

## Debugging

Scripts create a log file in the same folder they are run, starting with HostingLog.