---
title: "Configuration Reference &lt;configuration&gt; | Microsoft Docs"
author: rick-anderson
description: "IIS Configuration Reference Internet Information Services (IIS) 7 and later use an XML-based configuration system for storing IIS settings which replaces the..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: 
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference
msc.type: config
---
Configuration Reference &lt;configuration&gt;
====================
## IIS Configuration Reference


Internet Information Services (IIS) 7 and later use an XML-based configuration system for storing IIS settings which replaces the metabase that was used in IIS 6.0 and earlier. This new configuration system was introduced with ASP.NET and is based on a hierarchical system of management system that uses \*.config files. The configuration files for IIS 7 and later are located in your %*WinDir*%\System32\Inetsrv\Config folder, and the primary configuration files are:

- **ApplicationHost.config** - This configuration file stores the settings for all your Web sites and applications.
- **Administration.config** - This configuration file stores the settings for IIS management. These settings include the list of management modules that are installed for the IIS Manager tool, as well as configuration settings for management modules.
- **Redirection.config** - IIS 7 and later support the management of several IIS servers from a single, centralized configuration file. This configuration file contains the settings that indicate the location where the centralized configuration files are stored.

> [!NOTE]
> Some settings can be delegated to Web.config files, which may override settings in the ApplicationHost.config file. In addition, settings that are not delegated cannot be added to Web.config files.

### How to use this configuration reference

The purpose of this configuration reference is to list the various configuration collections, elements, and attributes that are available for IIS 7 and later. Because of IIS's highly-customizable architecture, an element may not be configured unless the feature that consumes the settings that are listed in this reference is also installed. For example, a default installation of IIS 7 does not contain Digest authentication, so adding the settings for Digest authentication to your **ApplicationHost.config** will have no effect or may cause errors until the Digest authentication module is installed.

Each configuration topic in this reference will usually consist of the following sections:

- **Overview** - This section describes the purpose of each configuration element.
- **Compatibility** - This section describes which versions of IIS support each configuration element.
- **Setup Instructions** - This section describes how to install any required features for each configuration element.
- **"How To" Examples** - This section contains one or more examples for configuring each configuration element.
- **Configuration Details** - This section describes the attributes and child elements for each configuration element, and usually contains an XML configuration sample.
- **Code Samples** - This section lists code samples in several languages that illustrate how to configure each configuration element programmatically. Code samples may be presented in six languages: 

    - AppCmd.exe (command-line application)
    - C# .NET
    - Visual Basic .NET
    - JavaScript
    - VBScript
    - PowerShell

### Configuration Reference downloads

- [IIS 7 Download Reference Guide](https://go.microsoft.com/?linkid=9739806)
- [IIS 7.5 Download Reference Guide](https://go.microsoft.com/?linkid=9739807)

### Powershell

For PowerShell support on IIS administration, refer to the [cmdlet reference](https://technet.microsoft.com/en-us/library/ee790599.aspx).