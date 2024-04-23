---
title: "Deep Dive into IIS Configuration with IIS 7 and IIS 8"
author: tobint
description: "The configuration system in IIS 7 and above is significantly different than in previous versions of IIS, and builds on top of some (but not all) of the conce..."
ms.date: 11/22/2007
ms.assetid: a41dfdbd-d0c5-498c-bea1-e35801834170
msc.legacyurl: /learn/get-started/planning-your-iis-architecture/deep-dive-into-iis-configuration-with-iis-7-and-iis-8
msc.type: authoredcontent
---
# Deep Dive into IIS Configuration with IIS 7 and IIS 8

by [Tobin Titus](https://github.com/tobint)

## Introduction

The configuration system in IIS 7 and above is significantly different than in previous versions of IIS, and builds on top of some (but not all) of the concepts of the .NET framework configuration system. Its scope spans across the entire web server platform (IIS, ASP.NET) and serves as the core of the IIS administration "stack". This document walks through the design and architecture of the configuration system, and introduces the programmable interface to the system at the lowest-level, native-code, entry point.

There are very few "moving parts" at runtime that implement the configuration system. The configuration system is implemented as a library that runs in-proc in the client application, and interacts with a persistent store on-disk. The store is simply a file, or a set of files, on the file system. The format of the files is XML. Users can edit the files manually at any time, if they choose to, and changes are automatically picked up by the system. There are no proprietary models for doing standard operations like protecting the settings, backing them up, moving them around, or even extending the system with new settings. The system relies heavily on the file system, to simplify tasks such as deploying configuration for web applications and services.

> [!NOTE]
> There is no centralized configuration service as in previous versions of IIS. This allows for a significant performance improvement when reading large chunks of data from the store, especially at startup, since there is no inter-process communication and buffer-copy that needs to occur.

Out of the box, after installing IIS, there are several consumers of configuration:

- WAS (Windows Activation Service): Reads global defaults for application pools, sites, and other settings.
- Web server core and modules in the worker processes: When activated to process a request, read configuration settings that control their behavior.
- WMI provider: The IIS scripting interface provider is using the configuration system internally to get and set settings.
- AppCmd.exe: The IIS command-line tool is using the configuration system internally to get and set settings.
- UI: The IIS administration framework is using the configuration system internally to get and set settings.
- Legacy: Applications and scripts that use interfaces such as ABO, ADSI and the IIS 6.0 WMI provider, use the configuration system indirectly, via a component that maps the legacy ABO APIs and model to the new configuration model. The state always persists into the new configuration system.

There are several interfaces that provide access to the configuration settings:

| Interface | Access To |
| --- | --- |
| Manual editing of the files using a text editor, or maybe via a script. | All configuration files, if file ACLs permit. |
| Configuration APIs in native-code and managed-code. | All configuration files, if file ACLs permit. |
| Higher-level abstractions on top of configuration system such as the IIS WMI scripting provider, UI, or appcmd.exe tool. | All configuration files, if file ACLs and UI delegation policy permit. |
| Legacy IIS interfaces such as ABO, ADSI, IIS 6.0 WMI provider. | Only the root IIS configuration file, and only the legacy (IIS 6.0) settings. .NET framework settings and IIS 7.0 and above settings are not exposed to these interfaces. |
| Legacy .NET framework interfaces such as System.Configuration. | Only the .NET framework 2.0 configuration settings in machine.config and web.config files. |

<a id="ConfigLevels"></a>

## Configuration Levels

Every level of the URL namespace may have associated configuration. Configuration for a given level inherits down to child levels, unless specifically overridden by a child level. A simple way to achieve per-URL configuration is by using web.config files, in the physical file-system folders that are mapped to the virtual paths. At the root level (the computer level), separate files should be used, depending on the configuration section group (which will be defined later in the document; for now think about it as the name of the XML element containing the configuration):

| Section Group | Description | Root File |
| --- | --- | --- |
| system.applicationHost | Windows Activation System: process model | system32\inetsrv\config\applicationhost.config |
| system.webServer | IIS: web server | system32\inetsrv\config\applicationhost.config |
| system.web | ASP.NET | Windows\microsoft.net\framework\v2.0.50727\config\web.config |
| system.\* | Other .NET framework | Windows\microsoft.net\framework\v2.0.50727\config\machine.config |
| [Microsoft other] | Microsoft other | Windows\microsoft.net\framework\v2.0.50727\config\machine.config |
| [custom] | 3rd party | Either machine.config or root web.config or applicationHost.config, up to 3rd-party / customer |

Sometimes web.config files are not desired, or cannot be used. Examples:

- Security: Occasionally, machine administrators want to be able to control the configuration everywhere on the server. With web.config in the content directories, site-level administrators (or application developers) who have write access to these directories, can xcopy (or FTP over, or otherwise modify) the web.config files, violating the desired policy.
- Remote change notifications: The content directory is on a remote (UNC) share, and using web.config creates performance, scalability or other issues. For example, some non-Windows back end file systems do not support file change notifications the way Windows expects. Another example: the system maintains open connections to many remote directories in order to monitor changes to the file, and it consumes too many resources on the server, leading to performance problems.
- Single point of administration: For ease of configuration management, discoverability and troubleshooting, the machine administrator would like one file at the root level to contain all the configuration for all levels of the hierarchy. In reality there will be 3 files at the global level: machine.config and root web.config for .NET framework configuration settings, and applicationHost.config for IIS configuration settings. This is far more contained than simply letting every level in the hierarchy to have its own web.config file.
- Shared configuration: Multiple virtual paths that point to the same physical folder, share the same web.config that is in that folder. Obviously, this web.config file cannot be used to specify different configuration for the different paths.
- File-specific configuration: Web.config files apply on the entire folder, i.e. on all the files in that folder. In order to specify a different configuration for a particular file, another method should be used.

The alternative to web.config files across the configuration hierarchy is location tags, which is the subject of the next section.

### Location Tags

Location tags are used to specify path-specific configuration as an alternative to having a web.config file in the folder mapped to that virtual path. The location tag for a path is set in a parent level in the configuration hierarchy, and is considered to be at that parent level. This is important when it comes to locking semantics and what level can specify what sections.

The main attribute on location tags is "path". The values can be:

- "." (or ""): Meaning the current level. Typical location paths are set at the global level, and so "." means the global level; however, they can be set anywhere in the configuration file hierarchy. This is also the default value, if "path" is not set.
- "sitename": The root application of a specific site.
- "sitename/application": A specific application of a specific site.
- "sitename/application/vdir": A specific virtual directory of a specific application of a specific site.
- "sitename/application/vdir/physicaldir: A specific physical directory. The path could be more complex, in the form "sitename/app/vdir/p1/p2/p3".
- "sitename/application/vdir/file.ext": A specific file. The path could be more complex, in the form of "sitename/app/vdir/p1/p2/file.ext", or less complex, in the form of "sitename/app/file.ext" or "sitename/file.ext".

Multiple location tags can exist in a single configuration file, but they cannot reference the same path (unless they reference different sections). They can, however, reference child paths, such that each location tag references a child path of another location tag. The order of location tags is of no importance to the configuration system but it is of importance to the readability of the file by human users.

[!code-xml[Main](deep-dive-into-iis-configuration-with-iis-7-and-iis-8/samples/sample1.xml)]

<a id="Organization"></a>

## Organization of Settings

Within a configuration file, the settings are organized in a structured manner, based on a unit called "section". Configuration section is a group of logically-related settings that can be deployed as a whole, or unregister from the system as a whole, and are typically consumed by one server module.

In other words, almost every runtime module that runs in the worker process, has a corresponding configuration section for it. Configuration section is also the unit of extensibility: adding new settings to the configuration schema is done by adding one or more sections to it.

Sections cannot be nested. Architecturally, they are independent of each other (in most cases), which means they do not cross reference.

The sections are further grouped into logically-related collections, called "section groups". Section groups are not the unit of deployment, or registration, or any other substantial operation (e.g. locking, encryption). They do not have settings in them. Their purpose is to further structure the organization of settings, and avoid a long flat list of configuration sections.

They are used to build hierarchy of settings, so they do have relationships between them (parent/child). In other words, section groups can be nested. A given section always belongs to one section group only, and cannot contain other section (or section groups). A given section group may belong to a parent section group, and may contain zero or more child section groups. It typically contains more than one section, otherwise there would not be a good reason to have it in the first place (however, customers can extend the schema by creating their own section groups that have one section only, for whatever reason).

Here is an example that demonstrates sections and section groups:

[!code-xml[Main](deep-dive-into-iis-configuration-with-iis-7-and-iis-8/samples/sample2.xml)]

Every section has a name. The short name is the name of the section itself, and the long name is the full name including all the containing section groups. For example, the full name for "windowsAuthentication" is "system.webServer/security/authentication/windowsAuthentication". This hierarchical organization allows for future sections (and section groups) with the same name, but under different section groups.

<a id="OrganizationMap"></a>

## Organization &lt;==&gt; XML Mapping

The persistence format of configuration is XML; therefore, it is useful to describe the mappings between configuration organizational units and XML terminology. Sections groups and sections are XML elements. Within a section, the settings are organized into smaller units that closely follow the XML terminology:

| Configuration unit | XML Terminology | Description |
| --- | --- | --- |
| Configuration element | XML element | contains other child units; does not have a value. |
| Configuration collection | XML element | private case of element: contains a group of elements in the form of add/remove/clear. |
| Configuration property | XML attribute | Contains only a value; does not contain child units. |

Heres an example from applicationHost.config:

[!code-xml[Main](deep-dive-into-iis-configuration-with-iis-7-and-iis-8/samples/sample3.xml)]

<a id="Schema"></a>

## Schema

The configuration system is driven off of a declarative schema at its core. This is different than IIS 6.0, for example, where the real schema was hard-coded and not used by ABO, and the ADSI provider (which is a higher-level interface on top of ABO) had its own schema that customers could extend. This is also very different from the architecture of the .NET framework v2.0 configuration system, where the "schema" for settings was mostly coded into individual classes that implemented the logic of for handling their respective section (these classes were called "section handlers"). Declarative schema also means that extending the system is a matter of adding declarations, not code, to the system (again, unlike the .NET framework approach).

The configuration schema spans multiple files, which reside in a well-known location: system32\inetsrv\config\schema\. By default, only machine administrators have access to this folder. Customers or third-parties can add schema files for their custom sections by copying them into that directory. The configuration system will pick them up automatically when it starts up, in the process of the caller to configuration. If the configuration system is already running, it will not pick up changes to the schema files, or new files.

Do not edit the IIS or other schema files that are installed into this directory, as errors may result in corrupted schema and inability of the server to start up.

> [!NOTE]
> There is no high-level programmatic interface to get and set schema files, short of traditional file access API and XML parsing/editing. It is always recommended to backup sensitive state like the schema folder, before making any changes to it.

Three files make up the unified schema of the web server platform:

- IIS\_schema.xml: covers the Windows Activation System and IIS web server settings in the `<system.applicationHost>` and `<system.webServer>` section groups.
- ASPNET\_schema.xml: covers the ASP.NET settings in the `<system.web>` section group.
- FX\_schema.xml: covers other .NET framework settings in various section groups.

<a id="OrgSchema"></a>

## Organization of Schema Declarations

Within the schema file, the organization is based on the unit of sections. Sections are defined by their full name, including containing section groups. Section groups are not defined per se; they are used as part of the section name to indicate the hierarchy structure. Every section schema declaration specifies names, types and default values for settings of the section. It also specifies the structure within the section: sub-elements, collections, properties.

We will review one example here, annotated with XML comments to point things out; it is highly recommended to read the "[ApplicationHost.config Walkthrough](introduction-to-applicationhostconfig.md)" document to understand in more details how the schema system works, and review the schema for every IIS section.

Example:

[!code-xml[Main](deep-dive-into-iis-configuration-with-iis-7-and-iis-8/samples/sample4.xml)]

<a id="AddSchema"></a>

## Additional Schema Information in &lt;configSections&gt;

Not all the required schema information is in the schema XML files. Some of it is in a special section called `<configSections>`, which resides in the configuration files themselves. This is consistent with the .NET framework configuration system. By default, `<configSections>` exists in machine.config and applicationHost.config; but customers may add it to any web.config file, to define their custom sections. These sections will be defined for that level in the namespace and downward.

> [!NOTE]
> Customers and third parties should not attempt to change schema information for the built-in sections, either in the inetsrv\config\schema\ folder or in machine.config and applicationHost.config. This may yield to undesirable behavior for these sections.

The content of `<configSections>`:

- Defines the sections that are "registered" with the system
- Defines the hierarchy of section groups.
- Does ***not** define properties or elements within sections.

Some additional metadata is defined for sections:

- **Type**: Required attribute. This is the managed-code section handler type; useful only in the context of .NET framework configuration system accessing the section (the System.Configuration classes). The definition is for a strong type, i.e. it includes the assembly name, version, culture and key.
- **OverrideModeDefault**: Optional attribute. If missing, the default is "Allow". This is the default lockdown state of the section, i.e. whether it is locked down to the level in which it is defined, or alternatively can be overridden by lower levels of the configuration hierarchy. If it is "Deny", then lower web.config files cannot override its settings (in other words: it is locked down to this level). Most of the IIS web server sections are locked down, but not all. Most of the .NET framework sections are not locked down, because they are considered application-level settings. If the value is "Allow", then lower levels may override the settings.
- **AllowDefinition**: Optional attribute. If missing, the default is "Everywhere". This is the level of the hierarchy in which the section can be set. If it is "MachineOnly", then it can be set only in applicationHost.config or machine.config. If it is "MachineToRootWeb", then it can be set either in the files defined above for "MachineOnly", or in the root web.config file in the .NET framework configuration folder (this value makes sense only for .NET framework sections). If it is "MachineToApplication", then it can be set either in the files defined above for "MachineToRootWeb", or in the web.config file in the application root folder. If it is "Everywhere", then it can be set in any configuration file, including in folders mapped to virtual directories that are not application roots, and in child physical directories underneath them.

Heres a simplified snippet from applicationHost.config:

[!code-xml[Main](deep-dive-into-iis-configuration-with-iis-7-and-iis-8/samples/sample5.xml)]

<a id="Locking"></a>

## Locking

Location tags are often used for locking or unlocking entire sections. More granular locking, of elements and attributes inside sections, is also supported by the configuration system but it is not directly related to location tags.

Unlocking can only be done at the level where the lock was defined. In other words, a configuration level can never unlock what was locked by parent levels. For example, the section is not locked by default, so these location tags in applicationHost.config will lock it down for two specific sites:

[!code-xml[Main](deep-dive-into-iis-configuration-with-iis-7-and-iis-8/samples/sample6.xml)]

In the example above, the first location tag simply locks down the section for MySite, with whatever values already defined for it. The second location tag changes the values (by enabling the section, clearing the files collection and adding exactly one element to it), and also locks it down for YourSite. This means that at the YourSite level (web.config), the default document feature is always turned on and it cannot be turned off, and the only default document honored is default.aspx.

The above example, with small changes, can be set in low-level web.config files, and not only in applicationHost.config. Any level of the configuration hierarchy can lock configuration (for paths under it, this is why small changes are needed in the example to reflect a different value for the path).

Location tags with the same sections can span multiple levels of the hierarchy, just like web.config files can. They are evaluated according to the inheritance rules. We will not specify here exactly how location tags are evaluated relative to web.config files underneath them in the hierarchy, because the algorithm may be confusing to human users trying to create a clear hierarchy of inheritance and sometimes locked configuration. For such reasons, location tags may sometimes turn out to be confusing or more advanced than simply using web.config files. However, as stated earlier in the Architecture section, there are good reasons to use location tags in some cases.

The locking in the example above was done using the overrideMode attribute. The values are:

- "Allow": Unlock the sections specified in the location tag.
- "Deny": Lock the sections specified in the location tag.
- "Inherit": This is the default value if none is specified. The configuration system will evaluate the lockdown state for sections specified in the location tag, by walking the inheritance hierarchy and figuring out parent definitions for overrideMode, all the way up to the section schema definition of overrideModeDefault. The value gets ultimately resolved by the overrideModeDefault value, because it is either specified in the schema information or the default is used: "Allow".

The system also supports a legacy attribute for locking sections in location tags: allowOverride. This attribute was used in the .NET framework configuration system, prior to overrideMode. It is mapped to overrideMode semantics as follows:

| allowOverride value | overrideMode equivalent value | Description |
| --- | --- | --- |
| true | Allow | Unlock specified sections |
| false | Deny | Lock specified sections |
| [not set] | Inherit | Resolve by walking the inheritance hierarchy |

The allowOverride model had some limitation and complexities, which we will not describe here. Therefore the new, and recommended, model, is overrideMode.

A location tag cannot specify both allowOverride and overrideMode. It is considered illegal configuration, which will fail at runtime with a proper error.

<a id="Unlocking"></a>

## Unlocking

This example shows how to unlock the section. Since it is locked at the applicationHost.config level, it can only be unlocked at that level.

[!code-xml[Main](deep-dive-into-iis-configuration-with-iis-7-and-iis-8/samples/sample7.xml)]

There are cases where it is useful to unlock sections for a specific path only and to keep them locked for all other paths. The following example builds atop the previous one, and shows how to unlock the section for two specific sites only; for all other sites it will remain locked.

[!code-xml[Main](deep-dive-into-iis-configuration-with-iis-7-and-iis-8/samples/sample8.xml)]

For each "exception" path that needs unlocking, there needs to be a different location tag.

Complications can occur when there is a conflict between locking and unlocking. Consider this example:

[!code-xml[Main](deep-dive-into-iis-configuration-with-iis-7-and-iis-8/samples/sample9.xml)]

The conflict is between the applicationHost.config level, which unlocks the section specifically for MySite/shopping, and the web.config at the root of MySite, which locks the sections for the site. This may happen when different people are managing the configuration for these different levels of the hierarchy. In such a case, the configuration system will treat this as illegal configuration and will fail with a proper error.

<a id="Summary"></a>

## Summary

This document outlined the design and architecture of the IIS configuration system. It explained how to achieve delegated administration of configuration settings using the hierarchy of configuration levels and distributed web.config files; it covered the integration points, including limitations, between the IIS and the .NET framework configuration systems; it explained the concept of tags and in what circumstances they should be preferred over configuration files; it then introduced the reader to basic configuration locking, at the section level. It is recommended to read the "[How To Lock Configuration](../planning-for-security/how-to-use-locking-in-iis-configuration.md)" document to gain a deeper understanding of configuration locking, including granular locking within sections.

The document also covered the organization of settings within configuration files, and explained the concepts of sections, section groups, elements, attributes, collections, enums and flags.

Last, the document covered the schema system and how it works; this is useful to know when extending the system with custom settings. It is recommend to read the "[How To Extend Configuration](../../develop/extending-iis-configuration/index.md)" document for more details and specific instructions about adding custom configuration sections to the system, and producing code to consume them.
