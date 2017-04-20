---
title: "The Configuration System in IIS 7 | Microsoft Docs"
author: walterov
description: "IIS 7 introduces a brand-new configuration system, at the core of all the new administration-related features. The configuration system is based on distribut..."
ms.author: iiscontent
manager: soshir
ms.date: 12/22/2007
ms.topic: article
ms.assetid: 4a1c6d48-33f7-43f6-8ee0-a0c62e8068aa
ms.technology: iis
ms.prod: iis
msc.legacyurl: /learn/get-started/planning-your-iis-architecture/the-configuration-system-in-iis-7
msc.type: authoredcontent
---
The Configuration System in IIS 7
====================
by [Walter Oliver](https://github.com/walterov)

## Overview

IIS 7 introduces a brand-new configuration system, at the core of all the new administration-related features. The configuration system is based on distributed, clear-text, XML files that hold the configuration settings for the entire web server platform, including IIS, ASP.NET and other components, such as FTP 7.5; they may optionally be set at the content directories together with the web content if unlocked for that level. Notice that FTP 6.0 configuration settings are stored in the MetaBase.

Different levels of the configuration hierarchy may be delegated by the machine administrator to other users, such as the site owner or the application developer. Secure defaults and out-of-the-box lock down limit write-access to configuration settings to the machine administrator only (the exceptions are a few site specific settings such as DefaultDocument); however, sophisticated and granular locking features enable safe unlocking and delegation of management of specific configuration settings to more users, for their scope of the web namespace. The system is backward compatible at the API level with previous versions of IIS (after the MetaBase compatibility layer is installed).

At the root (or global) level, there are two separate files:

- system32\inetsrv\config\applicationHost.config: Holds the global defaults for web server (IIS) settings.
- \Windows\Microsoft.NET\Framework\v4.0.30319\Config\machine.config: Holds the global defaults for the .NET framework settings, including some of the ASP.NET ones (the rest of the settings are in the web.config at the same folder, which is sometimes called the root web.config).

The reason there are still two separate files is because the two technologies version differently (schedule-wise and product-wise). IIS is part of Windows and the .NET framework may version independently.

In the web content directories, there may be optional web.config files that control the behavior for their level of the hierarchy and downward. They could be local or remote (if the content directory is on a UNC share, for example). They may contain IIS, ASP.NET or any other .NET framework configuration settings that can be specified at their level. By default there are no web.config files.

## Hierarchy

In terms of inheritance hierarchy, the root file is machine.config, then web.config at the same directory (referred to as root web.config), then applicationHost.config, then the optional web.config files along the namespace as illustrated in the following diagram.[![](the-configuration-system-in-iis-7/_static/image3.jpg)](the-configuration-system-in-iis-7/_static/image1.jpg)

## Sections

Within a configuration file, the settings are organized in a structured manner, based on a unit called "section". Configuration section is a group of logically-related settings that can be deployed as a whole, or unregister from the system as a whole, and are typically consumed by one server module.

In other words, almost every runtime module that runs in the worker process has a corresponding configuration section for it. Configuration section is also the unit of extensibility: adding new settings to the configuration schema is done by extending an existing section or by adding one or more sections to it.

The sections are further grouped into logically-related collections, called "section groups". Section groups are not the unit of deployment, or registration, or any other substantial operation (e.g. locking, encryption). They do not have settings in them. Their purpose is to further structure the organization of settings, and avoid a long flat list of configuration sections. They are used to build hierarchy of settings, so they do have relationships between them (parent/child).

In other words, section groups can be nested. A given section always belongs to one section group only, and cannot contain other section (or section groups). A given section group may belong to a parent section group, and may contain zero or more child section groups. It typically contains more than one section; otherwise there is not a good reason to have it in the first place (however, customers can extend the schema by creating their own section groups that have one section only, for whatever reason).

Here is an example that demonstrates sections and section groups:

[!code-xml[Main](the-configuration-system-in-iis-7/samples/sample1.xml)]

Every section has a name. The short name is the name of the section itself, and the long name is the full name including all the containing section groups. For example, the full name for "windowsAuthentication" is "system.webServer/security/authentication/windowsAuthentication". This hierarchical organization allows for future sections (and section groups) with the same name, but under different section groups.

Every level of the URL namespace may have associated configuration. Configuration for a given level inherits down to child levels, unless specifically overridden by a child level. A simple way to achieve per-URL configuration is by using web.config files, in the physical file-system folders that are mapped to the virtual paths. At the root level (the computer level), separate files should be used, depending on the configuration section group (which will be defined later in the document; for current purposes, consider it as the name of the XML element containing the configuration):

| Section Group | Description | Root File |
| --- | --- | --- |
| system.applicationHost | Windows Activation System: process model | System32\inetsrv\config\applicationHost.config |
| system.webServer | IIS: web server | System32\inetsrv\config\applicationHost.config |
| system.web | ASP.NET | Windows\microsoft.net\framework\v2.0.50727\config\web.config |
| System.\* | Other .NET framework | Windows\microsoft.net\framework\v2.0.50727\config\machine.config |
| [Microsoft other] | Microsoft other | Windows\microsoft.net\framework\v2.0.50727\config\machine.config |
| [custom] | 3rd party | Either machine.config or root web.config or applicationHost.config, up to 3rd-party / customer |

The persistence format of configuration is XML; therefore it is useful to describe the mappings between configuration organizational units and XML terminology. Sections groups and sections are XML elements. Within a section, the settings are organized into smaller units that closely follow the XML terminology:

| Configuration unit | XML Terminology | Description |
| --- | --- | --- |
| Configuration element | XML element | Contains other child units; does not have a value. |
| Configuration collection | XML element | Private case of element: contains a group of elements in the form of add/remove/clear. |
| Configuration property | XML attribute | Contains only a value; does not contain child units. |

The configuration system is driven off of a declarative schema, at its core. The configuration schema spans multiple files, which reside in a well-known location: system32\inetsrv\config\schema\. By default, only machine administrators have access to this folder. Customers or third-parties can add schema files for their custom sections by copying them into that directory. The configuration system will pick them up automatically when it starts up, in the process of the caller to configuration. If the configuration system is already running, it will not pick up changes to the schema files, or new files.

Do not edit the IIS or other schema files that are installed into this directory, as errors may result in corrupted schema and inability of the server to start up.

> [!NOTE]
> There is no high-level programmatic interface to get and set schema files, short of traditional file access API and XML parsing/editing. It is always recommended to backup sensitive state like the schema folder, before making any changes to it.

Three files make up the unified schema of the web server platform:

- IIS\_schema.xml: covers the Windows Activation System and IIS web server settings and section groups.
- ASPNET\_schema.xml: covers the ASP.NET settings in the section group.
- FX\_schema.xml: covers other .NET framework settings in various section groups.

You will also find FTP\_schema.xml if you have IIS 7 FTP feature installed.