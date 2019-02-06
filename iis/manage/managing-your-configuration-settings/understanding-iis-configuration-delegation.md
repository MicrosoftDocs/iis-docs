---
title: "Understanding IIS 7.0 Configuration Delegation"
author: rick-anderson
description: "IIS introduces a brand-new file-based configuration system for its seventh product release. This new system emphasizes a data-driven system suited for an ent..."
ms.date: 11/23/2007
ms.assetid: 30473846-d74b-42b7-ab51-40b7849eb9cb
msc.legacyurl: /learn/manage/managing-your-configuration-settings/understanding-iis-configuration-delegation
msc.type: authoredcontent
---
Understanding IIS 7.0 Configuration Delegation
====================
by [Saad Ladki](https://twitter.com/saadladki)

## Introduction

IIS introduces a brand-new file-based configuration system for its seventh product release. This new system emphasizes a data-driven system suited for an entire web platform where technologies like ASP.NET, Indigo and even third-party components can both use and extend this configuration store to house any site or application property.

The system is based on XML files defined in a simple and clear format with a similar syntax to ASP.NET web.config files. These configuration files hold settings in logical groupings and any change to the files is immediately reflected on the site or application whose properties are being modified.

This new system also provides a delegated administration experience in which: administrators may allow site and application owners to modify specific settings; and, the impact of these changes is confined to the specific site or application in question. This model introduces the concept of *self-contained applications* where both content and configuration settings are housed in the site or application directory and can be x-copy deployed from one machine to another.

<a id="01"></a>

## Configuration Files and Configuration Schema

IIS 7.0 and above has a central configuration file named *applicationHost.config* located in `%WINDIR%\System32\InetSrv\Config\`. This file replaces the metabase.xml file that IIS 6.0 used for its configuration store. This new configuration system is very simple, file-based, and yet very powerful. There is no configuration service, since IISADMIN is not required. Each worker process has an instance of a configuration reader component and fetches the configuration from the files directly.

Also, there is no in-memory representation of configuration. Once a change is issued to a file, it is picked up immediately by the worker process and reflected on the given site, application or virtual directory.

The applicationHost.config file houses global settings for the different features and components of IIS and other web technologies. Any property set in this file will apply to all sites, applications, and virtual directories in the machine.

The configuration reader that IIS uses understands the format, syntax and correct naming of each configuration section, element and attribute because they are defined in a schema file. The schema for configuration is defined in files located in the `%WINDIR%\System32\InetSrv\Config\Schema\` directory. Upon instantiating the configuration system, the worker process reads the schema to memory and this helps the system understand properties that are available to be set and its format. At a minimum, *IIS\_schema.xml*, *ASPNET\_schema.xml,* and *FX\_schema.xml* files are located in this directory and define the structure of configuration for sections that apply to IIS, ASP.NET and the .NET Framework features respectively.

The schema defines several aspects of configuration and its sections, like the naming of sections and properties, the expected types for values, the range of these values or if any of them are unique or required. Also, it defines the default value that a specific attribute will take. In the given case where a property is not defined in applicationHost.config, its value is taken from the default setting that was stated in the schema file.

In addition to this central file, applicationHost.config, several *web.config* files can appear at any level of the URL hierarchy. These files can appear at the site, application, virtual directory or even physical path levels. These files define properties whose values override the global settings defined in applicationHost.config. However, these changes are only applicable at the scope to which the file appears, i.e. for the given site, application, virtual directory or physical path to where the web.config file resides.

<a id="02"></a>

## Configuration Hierarchy and Effective Configuration

Besides applicationHost.config, IIS uses ASP.NET, which relies on both the *machine.config* and the *root web.config* files. The machine.config file defines the properties that are required for all Framework features. The root web.config file defines the global settings for properties defined for all ASP.NET web applications. These two files are analogous to applicationHost.config of IIS. The three files exist because the .NET Framework and IIS version separately. There can be multiple versions of the Framework installed in a given Windows Server system that has a single version of IIS.

Therefore, a configuration hierarchy is defined and calculated for the configuration settings of the system. The hierarchy starts at machine.config, then progresses to the root web.config file, followed by applicationHost.config. From then on, any optional web.config file that is located at the site, application or virtual directory level is added and applied to the hierarchy. At the end, the properties inherit from parent to child file from machine.config down to the last web.config file (if any) and the effective configuration is calculated for a given path.

The inheritance behavior is done by default. Any setting at a lower level in the hierarchy overrides a parent setting defined in a file above the current level. However, going further down the hierarchy, the scope of configuration is more limited. Where as the machine.config, root web.config and applicationHost.config files' settings apply to everything in the system, optional web.config files' settings only apply to the current location and below (whether it is a site, application or virtual directory).

<a id="03"></a>

## Configuration Sections

Within a configuration file, there are possible settings that can be read and set. The settings are grouped in a structured manner. Multiple settings that are similar or applicable to a specific feature (i.e. ASP, authentication, ISAPI, etc.) are grouped together in logical unit blocks called *configuration sections*. Each configuration section can include other configuration sections within them, but most commonly define elements, collections or attributes.

A configuration element is an XML element that defines multiple configuration attributes. A configuration collection is a special case of a configuration element that contains a list of elements defined with the add/remove/clear configuration directives. Finally, configuration attributes are leaf configuration settings that represent XML attributes.

The following snippet shows the settings for the *&lt;defaultDocument&gt;* section. The *enabled* word is an attribute where the *files* word is an element that includes a listing of other elements defined by the *add* directive and a series of attributes.

[!code-xml[Main](understanding-iis-configuration-delegation/samples/sample1.xml)]

This configuration section has an associated schema. The following snippet shows the schema for the &lt;defaultDocument&gt; section in the file IIS\_schema.xml. The schema defines the name of the section and the namespace it appears in (in this case, *system.webServer*). Also, the schema describes the attributes and elements and for each the name, type, default values and other interesting data.

[!code-xml[Main](understanding-iis-configuration-delegation/samples/sample2.xml)]

<a id="04"></a>

## A Special Section: &lt;configSections&gt;

The `<configSections>` configuration section is a special section defined in applicationHost.config. It is used as a registry point for the configuration sections of the IIS server. This section is where the current configuration sections that are available in the system are registered. In the given case that the configuration system is extended and a custom section is added to the server, it must be registered by adding an element entry to this section.

The following snippet shows the `<configSections>` entry for the &lt;defaultDocument&gt; section. Other entries have been omitted for the sake of clarity. The interesting part of the `<configSections>` is the section group entry that defines the namespace of each section--in this case *system.webServer* and the value of the overrideModeDefault attribute, which for this section is "Allow". Since allowDefinition is not declared, it is taken from schema and the default value is "Everywhere".

[!code-xml[Main](understanding-iis-configuration-delegation/samples/sample3.xml)]

Besides defining a section and its section group, there are two key attributes that are defined: *overrideModeDefault* and *allowDefinition*.

The overrideModeDefault attribute is an optional attribute that defines the locked state of a section. Its available values are either *Allow* or *Deny*. The default value is "Allow". All IIS sections that are related to any performance, security or critical aspect of the server are locked with this attribute set to "Deny". If the overrideModeDefault attribute is set to "Deny", then any configuration files at a lower level (i.e. web.config files) that set a value for a property for the specific configuration section are not able to take effect and override the global values. This incurs in a lock violation and an error occurs.

The allowDefinition attribute is another optional attribute that defines the level of the hierarchy in which the section can be defined and properties can be set. If its value is *MachineOnly*, then the section can be set only in applicationHost.config or machine.config. If its value is *MachineToRootWeb*, then the section can be set either in the MachineOnly files or also in the root web.config. If its value is *MachineToApplication*, then the section can be either set in all the previous three files or also in web.config files in the application root folder. And lastly, if its value is *Everywhere* (which is the default) it can be set in any configuration file, whether the ones that affect configuration globally or in web.config files that apply to a given site, application or virtual directory.

<a id="05"></a>

## The Concept of Location

Any setting specified in a given file of the configuration hierarchy applies to that level and below with the possibility of being overridden by child files. However, there is the option to specify and apply configuration settings to certain paths under the current configuration file by using the *location* tag with a path attribute. If the configuration file is applicationHost.config, location tags can include a path ranging from all sites, applications and virtual directories in the system to a specific site, application, virtual directory or file. The location tag can also be specified in web.config files and it can include any relative path for paths underneath the current site, application or virtual directory.

The following snippet shows how to specify a configuration property to be applicable to the Developer Site only. This can also be achieved via a web.config file in the site content. The effective configuration for the Developer Site will be the list of entries for the files collection in applicationHost.config plus the location path and any web.config file for the site.

[!code-xml[Main](understanding-iis-configuration-delegation/samples/sample4.xml)]

If no path is declared, which is equivalent to specifying a dot (.), then the path is understood to be from this level and below to all child paths. Doing this in applicationHost.config is specifying configuration for the global level too.

An attribute that can be defined in a location tag is the *overrideMode*. Like overrideModeDefault, this specifies if the given configuration section referenced and properties set in the current location tag can be edited and overridden at lower levels of the hierarchy.

<a id="06"></a>

## Locking and Unlocking a Section

The initial concept of locking a section via the overrideModeDefault tag in the `<configSections>` section can be taken and extended to be more fine-grained. By allowing a section to be overridden at the `<configSections>` level, the section is opened up and its values can be overridden by anyone in the system via web.config files at any level of the URL namespace. However, this may pose a serious security risk and may cause negative effects to the availability or performance of the system. Via location tags, one can use the overrideMode attribute and specify the locking state of a section and constrain it for a given path.

The following snippet shows how to unlock the `<windowsAuthentication>` section for all sites, applications and virtual directories in the system. This is done by setting "Allow" in the overrideModeDefault attribute. The disadvantage of this approach is that it unlocks a section for everyone and anyone is able to override the settings at their site or application level via web.config files.

[!code-xml[Main](understanding-iis-configuration-delegation/samples/sample5.xml)]

The following snippet shows how to achieve the same thing, unlocking the `<windowsAuthentication>` section, but only for the AdministratorSite so that properties for that section can be modified via web.config files at the site AdministratorSite level. The other sites in the system have the default behavior of a locked `<windowsAuthentication>` section. This is accomplished via the overrideMode attribute.

[!code-xml[Main](understanding-iis-configuration-delegation/samples/sample6.xml)]

The opposite behavior can be achieved, which is locking a section for a specific site whereas the rest of the system is able to edit it. For example, &lt;defaultDocument&gt; is a section that has the overrideModeDefault attribute set to "Allow" in the `<configSections>` section, but via a location tag, we can lock this section for the Basic Site. The following snippets shows how to accomplish this while also setting so that the only value accepted by the system as the default page for the server to show as the home page is titled *basic.htm*. The clear directive nulls any inherited values from above levels in the configuration hierarchy, which in this case is the global listing of files from applicationHost.config.

[!code-xml[Main](understanding-iis-configuration-delegation/samples/sample7.xml)]

<a id="07"></a>

## Granular Locking

Opening up a section via a location tag is an effective way to unlock a section and all its properties for the owner of the site or application of the specified path. This is in effect an all-or-nothing approach on letting site and application owners have unlimited access to a section. However, sometimes administrators want specific control over certain properties in a section and desire control over certain value. Others can be delegated. This is where granular locking comes in.

Granular locking is a grouping of specific attributes that can be set on elements or other attributes. Granular locking can declare whether paths below the current one can modify the configuration values. Values can be read, but if locks are set, they cannot be edited or even declared. Do not edit values whose locks are set, as this will result in configuration locking violation errors.

The first attribute in the granular locking grouping is *lockAttributes*. The lockAttributes defines a comma-separated list of attributes that are locked for paths below the current configuration level. It also accepts an asterisk (\*) as its value, which means that all attributes are locked. At this point, the configuration section can be read in child level paths and even the locked attributes, but editing protected ones results in errors.

The following snippet shows how to lock the enabled state of the &lt;defaultDocument&gt; section for the Developer Site. If the owner of the Developer Site disables the default document feature or even declares the property with the same value as what it is stated in the location tag, a lock violation occurs.

[!code-xml[Main](understanding-iis-configuration-delegation/samples/sample8.xml)]

The second attribute in the granular locking grouping is *lockElements*. The lockElements defines a comma-separated list of elements that are locked for paths below the current configuration level. Like lockAttributes, It also accepts an asterisk (\*) as its value, which means that all elements are locked. This is very useful for configuration sections that have multiple elements or collections and need to be protected for child level paths. Again, editing any of the locked values results in errors.

The following snippet shows how to lock the files collection for the Developer Site. This leaves it to the site owner to decide whether or not the default document feature is enabled or not; but, if enabled, it cannot modify the global values and inherits what the machine administrator stated in applicationHost.config.

[!code-xml[Main](understanding-iis-configuration-delegation/samples/sample9.xml)]

The lockElement example is also useful within collections to lock the *directives* of such collection. The directives are the key words like *add, remove, clear* of a collection. By locking the directives, an administrator can fine-tune whether a collection listing is available for adding or removing certain or all elements.

The following snippet shows how to lock the removal and clearing of current entries in the files collection. The site owner can add new entries to the files collection if needed. If the site owner specifies a clear tag or tries to remove an entry, a lock violation occurs.

[!code-xml[Main](understanding-iis-configuration-delegation/samples/sample10.xml)]

There is also a *lockItem* attribute. This locks an attribute and works at the XML attribute level. The following snippet shows how the site administrator is able to do anything she wants to do, like add, or remove entries in the collection, except modify the basic.htm entry in the files collection.

[!code-xml[Main](understanding-iis-configuration-delegation/samples/sample11.xml)]

<a id="08"></a>

## Summary

This document outlined a basic overview on the configuration system, its files, schema and delegation capabilities. It also discussed the configuration hierarchy and effective configuration. The article also presented an introduction to configuration sections and its structure of elements and attributes. It exemplified the concept of location, locking and granular locking.

Overall, IIS introduces and new file-based configuration system with capabilities for either having all configuration in a central configuration file or distributed via web.config files where site and application administrators are able to modify properties that apply to their applications and content. With the distributed configuration model the concept of *self-contained applications* where both content and configuration settings are housed in the site or application directory and can be *x-copy* *deployed* from one machine to another is enabled.