---
title: "Getting Started with Configuration in IIS 7 and Above"
author: tobint
description: "The configuration system in IIS 7 and above is based on distributed, clear-text, XML files that hold the configuration settings for the entire web server pla..."
ms.date: 11/22/2007
ms.assetid: b0c1dfad-6256-4c38-969d-88e5e4d2855a
msc.legacyurl: /learn/get-started/planning-your-iis-architecture/getting-started-with-configuration-in-iis-7-and-above
msc.type: authoredcontent
---
Getting Started with Configuration in IIS 7 and Above
====================
by [Tobin Titus](https://github.com/tobint)

## Abstract

The configuration system in IIS 7 and above is based on distributed, clear-text, XML files that hold the configuration settings for the entire web server platform, including IIS, ASP.NET and other components, and may optionally be set at the content directories together with the web content. Different levels of the configuration hierarchy may be delegated by the machine administrator to other users, such as the site administrator or the application developer. Secure defaults and out-of-the-box lockdown limit write-access to configuration settings to the machine administrator only; however, sophisticated and granular locking features enable safe unlocking and delegation of management of specific configuration settings to more users, for their scope of the web namespace. The system is backward compatible, at the API level, with previous versions of IIS, and at the XML level, with previous versions of the .NET framework. This document gives a general overview of the new configuration system.

<a id="Intro"></a>

## Introduction

The configuration system in IIS is based on distributed, clear-text, XML files that hold the configuration settings for the entire web server platform, including IIS, ASP.NET and other components, and may optionally be set at the content directories together with the web content. Different levels of the configuration hierarchy may be delegated by the machine administrator to other users, such as the site administrator or the application developer. Secure defaults and out-of-the-box lockdown limit write-access to configuration settings to the machine administrator only; however, sophisticated and granular locking features enable safe unlocking and delegation of management of specific configuration settings to more users, for their scope of the web namespace. The system is backward compatible, at the API level, with previous versions of IIS, and at the XML level, with previous versions of the .NET framework.

The new configuration system is designed to be:

- **Simple**: All the state is in files; No proprietary store is used; No in-memory configuration database that is the real master of the configuration state (unlike the IISADMIN service in IIS 6.0); The schema is data-driven and is 100% declarative and discoverable.

- **Low-TCO**: Configuration can be xcopied together with web content; Optional delegated administration eliminates involvement of the machine administrator in every configuration change; Unification of configuration settings and model across IIS, ASP.NET and the rest of the web server platform provides one-stop-shop for managing the server using same set of tools and APIs (for example, web.config files may contain both IIS and ASP.NET settings, and there's one place across both to control features such as authentication, authorization, custom errors); backup, restore, security management (ACLs) are based on standard file-system tools and processes.

- **Secure**: When IIS gets installed, the configuration state is in one file that's protected for machine-administrator access only; No delegation is enabled by default; No sensitive information (such as passwords) is stored by default; When sensitive information needs to be written to the configuration files, it is automatically being encrypted on-disk; Per-application configuration can be sand-boxed and isolated in a dedicated file (protected by file-system ACL) such that other applications cannot share nor read the settings.

- **Extensible**: Adding to the schema is simply a matter of dropping an XML file to the schemas folder; No need to call APIs or run tools in order to extend the schema; The settings are organized in logically-related blocks called 'sections' (exactly like in the .NET framework configuration), and adding new sections is easy (no need to write any code – unlike in the .NET framework configuration); Reading custom section settings from a server module or application is simple and straight-forward.

- **Compatible**: Existing IIS applications can continue to call interfaces like Admin Base Objects (ABO), the IIS ADSI provider and the IIS 6.0 WMI provider; Existing .NET framework applications can continue to call interfaces such as System.Configuration and System.Web.Configuration; Users who are familiar with the XML format of machine.config and web.config will continue to experience the same format and syntax in these files, plus they will be able to manually edit IIS settings that follow the same format and model; Users who are familiar with the IIS Metabase property names will find the same names for properties in the new IIS 7.0 and above configuration files.

<a id="Clean"></a>

## Clean Schema

Here is an example that demonstrates the schema for configuration.

It shows how authentication settings are organized in IIS 6, and in IIS 7.0 and above.

> [!NOTE]
> Readers who are not familiar with the IIS 6.0 concepts can simply ignore the comparison to IIS 6.0 and just read the IIS 7.0 and above concepts and benefits.

We will first compare the way configuration is persisted in the file, and then we will take a look at the schema definition.

In the configuration file itself:

[!code-csharp[Main](getting-started-with-configuration-in-iis-7-and-above/samples/sample1.cs)]

Key takeaways:

- **IIS 6.0** is using a very long, "flat", list of properties. There is no hierarchy or grouping of properties. It's difficult to search configuration settings amongst hundreds of settings in the same list. **IIS 7.0** and above uses a hierarchy of sections and section groups, and sub-elements within the sections. It is easy to lookup authentication settings, by searching for them in the authentication section group, or in a specific authentication section.
- **IIS 6.0** is using flags to set authentication schemes. **IIS 7.0** and above uses a section per authentication schema, with enabled="true|false" on each. Additional settings that are relevant for only some authentication schemes, can be set only in the relevant sections (for example, username and password can be set only for anonymous authentication).
- **IIS 6.0** is using paths inside the Metabase file to specify the configuration level (service, virtual directory, physical directory). Configuration for the entire server is in one file. **IIS 7.0** and above uses one file by default, but users can leverage distributed web.config files in the content directories, that specify configuration settings for their scope.
- **IIS 6.0** is using long property names in an attempt to have self-describing configuration settings. This is trying to improve readability of the file and help the user understand what the property does. **IIS 7.0** and above uses short names but they are always in the context of a specific section, or even sub-element with in the section.
- **IIS 6.0** is using multi-sz (comma-delimited elements in one string property), and flags, to handle multiple element values, like NTAuthenticationProviders. **IIS 7.0** and above uses collections, with simple add/remove/clear syntax, exactly like the .NET framework configuration. This allows lower-levels of the hierarchy to add (or remove) only the element they need, instead of duplicating the entire data with (or without) the said element. It also provides greater readability of the file (which translates to less human errors when directly editing it).

In the schema file:

[!code-csharp[Main](getting-started-with-configuration-in-iis-7-and-above/samples/sample2.cs)]

Key takeaways:

- **IIS 6.0** is using IDs (numbers) to identify settings. **IIS 7.0** and above uses friendly strings to name settings.
- **IIS 6.0** is using non-intuitive concepts such as UserType and terminology such as InternalName. **IIS 7.0** and above uses friendly names that make sense to humans readers, and not only applications.

<a id="ConfigFile"></a>

## Configuration File Hierarchy

The "master" state for configuration is always the configuration files (unlike in IIS 6.0, where it was the in-memory configuration database, which was flushed to disk periodically).

At the root (or global) level, there are two separate files:

- system32\inetsrv\config\applicationHost.config: Holds the global defaults for web server (IIS) settings.
- \windows\microsoft.net\framework\v2.0.50727\config\machine.config: Holds the global defaults for the .NET framework settings, including some of the ASP.NET ones (the rest of them are in the web.config at the same folder, which is sometimes called the root web.config)

The reason there are two separate files still is because the two technologies version differently (schedule-wise and product-wise). IIS is part of Windows and the .NET framework may version independently, as part of Visual Studio releases.

In the web content directories, there may be optional web.config files that control the behavior for their level of the hierarchy and downwards. They could be local or remote (if the content directory is on a UNC share, for example). They may contain IIS, ASP.NET or any other .NET framework configuration settings that can be specified at their level. By default there are no web.config files.

In terms of inheritance hierarchy, the root file is machine.config, then web.config at the same directory (referred to as root web.config), then applicationHost.config, then the optional web.config files along the namespace.

### Configuration include files

In some cases it is useful to have the web.config file include some other .config file. This can be done by using the configSource attribute. Currently it is limited to point to relative physical paths in sub-directories, for security reasons (i.e. file A can only include file B if B is in physical subdirectory of A). Here's a basic example that shows how to use configSource:

[!code-xml[Main](getting-started-with-configuration-in-iis-7-and-above/samples/sample3.xml)]

In this example, the customer wanted to move the content of the staticContent section to a separate file, in order to have a shorter, more readable, applicationHost.config.

Note that when configuration settings change in a .config file, the server will automatically pick up the changes and act on them. The customer should not worry about recycling applications or application pools or the entire server (the server itself may recycle application pools, for example, depending on what configuration settings changed).

<a id="Organization"></a>

## Organization of Settings

Within a configuration file (i.e. for a given level of the hierarchy), the settings are organized in a structured manner, and not as a flat list. The basic unit of deployment, registration and extensibility is the configuration section. A section is contained within a section group, that may in turn be contained in a parent section group. Sections themselves are not nested. Section groups are.

Here's an example from applicationHost.config:

[!code-xml[Main](getting-started-with-configuration-in-iis-7-and-above/samples/sample4.xml)]

Configuration settings always belong to a specific section.

Section groups only exist for better structuring; they don't have settings directly in them, only sections.

Within a section, the structure is as follows:

- Configuration element: Contains configuration settings and potentially other configuration elements. Represented as an XML element. Sections are also elements.
- Configuration collection: A private case of configuration element, which contains a list of configuration elements, in the form of add/remove/clear (which are called collection directives). Represented as an XML element with &lt;add&gt;, &lt;remove&gt;, &lt;clear&gt; sub-elements.
- Configuration property: this is a [leaf] configuration setting. Represented as an XML attribute.

Here's an example from applicationHost.config:

[!code-xml[Main](getting-started-with-configuration-in-iis-7-and-above/samples/sample5.xml)]

By default, applicationHost.config contains two main section groups: system.applicationHost and system.webServer. It also contains a section called &lt;configSections&gt;, which is somewhat special in that it is used internally by the configuration system to register all other sections.

By default, machine.config contains several section groups. The ASP.NET settings are in the system.web section group.

<a id="Location"></a>

## Location Tags Vs. Configuration Files

In many cases it is desired to avoid web.config files in the content directories, but still have per-URL configuration that overrides the global defaults. For example: the administrator wants to specify that a specific site must use some authentication scheme, and the site administrators (and application developers on that site) must not be able to turn it off.

The easiest way to achieve this is by using location tags. This is a mechanism to specify configuration for a specific path, without having a web.config in the folder mapped to the virtual path.

This example shows how a location tag is used within applicationHost.config:

[!code-xml[Main](getting-started-with-configuration-in-iis-7-and-above/samples/sample6.xml)]

Location tags can be used to specify configuration for the global level (path="."), for a site, or for a specific path inside a site. There can be multiple location tags in a file. Location tags can be in any .config file, not only applicationHost.config or machine.config.

Location tags can also be used for locking and unlocking sections. More details on this in the configuration locking lab.

In some cases, there is no alternative for using location tags:

- Two or more virtual paths mapped to same physical folder. Obviously, if the two virtual paths have different configuration, it cannot be specified in a web.config file because it is shared.
- File-specific configuration. There is no web.config file for files; only for the entire folder.

<a id="Summary"></a>

## Summary

This document provided an initial, high-level, overview of the configuration system in IIS 7.0 and above. It highlighted the cleaner schema format; the distributed nature of the configuration system and how it enables delegation of configuration settings to the site owner or application developer; the structured organization of settings in configuration files; and the integration between IIS and ASP.NET configuration systems.

For more information, it is recommended to review the rest of the configuration documents, and in particular, the Configuration Intrinsics document, which goes into more low-level details about the system, including its design and architecture.
