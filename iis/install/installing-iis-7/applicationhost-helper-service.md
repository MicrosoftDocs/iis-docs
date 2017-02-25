---
title: "ApplicationHost Helper Service | Microsoft Docs"
author: rick-anderson
description: "The ApplicationHost Helper Service in IIS 7.0 and above hosts IIS functionality that is needed even if IIS is not running. This service currently hosts the f..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 11/22/2007
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/install/installing-iis-7/applicationhost-helper-service
msc.type: authoredcontent
---
ApplicationHost Helper Service
====================
by Saad Ladki

## Introduction

The ApplicationHost Helper Service in IIS 7.0 and above hosts IIS functionality that is needed even if IIS is not running. This service currently hosts the following functionality:

- Configuration history
- Application Pool account mapping

## Configuration History

In earlier versions of IIS, you could back up your metabase settings and restore these settings whenever you needed to. IIS 7.0 and above has equivalent functionality for backing up configuration settings.

IIS 7.0 and above provides a configuration history feature that lets you go back to an earlier version of the configuration any time you want. The ApplicationHost Helper Service enables this functionality by saving the ApplicationHost.config file to separate configuration history subdirectories at intervals that you specify. If you make a mistake when you modify the ApplicationHost.config file, for example, you can restore an earlier version of the file from a configuration history subdirectory by copying the earlier version into the *%windir%*\system32\inetsrv\config directory.

## Application Pool Account Mapping

In addition to backing up configuration settings, the ApplicationHost Helper Service also provides Application Pool account mapping. For example, if you want to lock down content directories to a particular Application Pool, the account mapping feature in the ApplicationHost Helper Service lets you use user-friendly names by using the access control list (ACL) UI in Windows Explorer or the ICACLS command-line tool instead of using security identifiers (SIDs) to lock down your directories. The ApplicationHost Helper Service maps the SIDs to their corresponding user-friendly names and vice versa.

## Runtime-independent

The ApplicationHost Helper Service is a runtime-independent service. It does not require the Windows Process Activation Service (WAS) or the World Wide Web Publishing Service (WWW service) to operate. It does not depend on any other service and starts automatically when you restart your computer. If the ApplicationHost Helper Service is stopped for any reason, configuration history and Application Pool account mapping will not work.

## Installation

The ApplicationHost Helper Service is installed whenever IIS 7.0 or above is installed. Upon installation of the ApplicationHost Helper Service, the *%systemdrive%*\inetpub\history directory is created, by default, to store the configuration subdirectories. You can change this default location by changing the value of the **ConfigHistoryPath** attribute.
  
  
[Discuss in IIS Forums](https://forums.iis.net/1041.aspx)