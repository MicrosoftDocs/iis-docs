---
title: "Web Site Deployment Made Easy | Microsoft Docs"
author: rick-anderson
description: "In previous versions of IIS, moving a Web site from one server to another meant that you had to explicitly configure IIS application settings in the machine-..."
ms.author: iiscontent
manager: soshir
ms.date: 11/23/2007
ms.topic: article
ms.assetid: 2258ad69-e31f-4b0f-a1bc-58680b562ccb
ms.technology: iis
ms.prod: iis
msc.legacyurl: /learn/get-started/introduction-to-iis/web-site-deployment-made-easy
msc.type: authoredcontent
---
Web Site Deployment Made Easy
====================
by IIS Team, [Saad Ladki](https://twitter.com/saadladki)

### Compatibility


| Version | Notes |
| --- | --- |
| IIS 7.0 and later | The features described in this article were introduced in IIS 7.0. |
| IIS 6.0 and earlier | The features described in this article were not supported prior to IIS 7.0. |


## Introduction

In previous versions of IIS, moving a Web site from one server to another meant that you had to explicitly configure IIS application settings in the machine-level metabase repository before the application could function properly. With IIS 7.0 and later, however, the process of deploying a Web site is now much easier.

<a id="Distributed"></a>

## Distributed Configuration

IIS 7.0 and later offer some major improvements to the way configuration data is stored and accessed. The old centralized configuration store, found in the previous releases of IIS (known as the metabase), is gone.

Instead, IIS 7.0 and later feature a new delegated configuration system based on a hierarchy of distributed XML configuration files. This hierarchy is made up of a global ApplicationHost.config file, which contains server-level configuration defaults, and distributed Web.config files located within the application's directory structure. These are the same Web.config files that are used by the ASP.NET application framework to store application settings in a portable way. As a result, IIS and ASP.NET configuration settings can be stored side-by-side using clean, strongly-structured XML directives.

IIS continues to support existing setup code that uses ABO APIs to write to the legacy metabase or scripts that use the higher-level Active Directory® Service Interfaces (ADSI) and Windows Management Instrumentation (WMI) objects to configure IIS. It does this by providing a compatibility layer that emulates the ABO APIs, on top of which all other legacy configuration APIs are based. This allows such scripts to read and change configuration just like they did in the previous releases of IIS. For more information about the metabase compatibility feature in IIS 7.0 and later, see [IIS Configuration Compatibility](../../manage/managing-your-configuration-settings/how-to-use-metabase-compatibility-with-iis-7-and-above.md).

<a id="Whats"></a>

## What's Where

As mentioned earlier, the new distributed configuration hierarchy is made up of the following XML configuration files:

### ApplicationHost.config

This is the main configuration file for IIS 7.0 and later. The ApplicationHost.config file stores global or computer-wide configuration settings and is located at the root level of the Web server in the `%windir%\system32\inetsrv\config` directory. There are two major configuration sections in this file:

- **system.applicationHost** - Contains configuration settings for sites, applications, virtual directories, and application pools. These are centralized settings that cannot be distributed.
- **system.webServer** - Contains configuration for all other settings, including global defaults. These settings can be delegated and distributed.

### Web.config

URL-specific configuration settings can either be stored directly within the code or in the content directories of a Web site using Web.config files. These are the same Web.config files that are used by the ASP.NET application framework to store application settings.

> [!NOTE]
> You can also store URL-specific configuration settings in the ApplicationHost.config file using `&lt;location&gt;` tags.

### Redirection.config

Contains settings used to redirect a Web server to configuration files and schemas located on another computer.

<a id="Benefits"></a>

## Benefits

Distributed configuration unleashes many powerful capabilities in IIS which:

- Enable developers to specify configuration for a Web site or application in the same directory as the code or content.
- Allow moving Web sites and applications from development to test or from test into production as simply a matter of copying the configuration files, along with the code and content, over to the new computer. Your Web site is up and running immediately with the desired settings in place.
- Enable administrators to share configuration information easily across multiple front-end Web servers and Web farms (once a Web site is in production), avoiding costly and error-prone replication and manual synchronization issues. You can do this by storing Web.config files on a back-end file server and referencing them from multiple front-end Web servers.