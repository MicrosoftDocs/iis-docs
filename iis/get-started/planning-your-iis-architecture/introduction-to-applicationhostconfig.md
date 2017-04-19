---
title: "Introduction to ApplicationHost.config | Microsoft Docs"
author: tobint
description: "ApplicationHost.config is the root file of the configuration system when you are using IIS 7 and above. It includes definitions of all sites, applications, v..."
ms.author: iiscontent
manager: soshir
ms.date: 11/22/2007
ms.topic: article
ms.assetid: d7c82bfe-0754-4a3f-8518-1215b4fd6dfd
ms.technology: iis
ms.prod: iis
msc.legacyurl: /learn/get-started/planning-your-iis-architecture/introduction-to-applicationhostconfig
msc.type: authoredcontent
---
Introduction to ApplicationHost.config
====================
by [Tobin Titus](https://github.com/tobint)

## Introduction

ApplicationHost.config is the root file of the configuration system when you are using IIS 7 and above. It includes definitions of all sites, applications, virtual directories and application pools, as well as global defaults for the web server settings (similar to machine.config and the root web.config for .NET Framework settings).

It is also special in that it is the only IIS configuration file available when the web server is installed (however, users can still add web.config files if they want to). It includes a special section (called configSections) for registering all IIS and Windows Activation System (WAS) sections (machine.config has the same concept for .NET Framework sections). It has definitions for locking-down most IIS sections to the global level, so that by default they cannot be overridden by lower-level web.config files in the hierarchy.

The location of the file is currently in the system32\inetsrv directory, but this is expected to change after beta2 to system32\inetsrv\config. This document walks through all the sections, in the order they appear in the file, and explains them one by one. The most complex section is *system.webServer*, so it is recommended for the reader to not skip reading the description for that section in particular.

Note the following:

1. This document specifies the content of each configuration section, as appears in applicationHost.config. By design, many of the sections are empty or not complete (only some of their content appears in the XML). The rest of the values are taken from the schema defaults. This is done to avoid too much information and cluttering of the file, and in order to keep it reasonably readable.

    - For full schema reference, including default values for all properties in every section, their valid ranges, etc., refer to `%windir%\system32\inetsrv\config\schema\IIS\_Schema.xml` (for IIS settings), or `ASPNET\_Schema.xml` (for ASP.NET settings), or FX\_Schema.xml (for other .NET Framework settings).
    - For convenience, chunks of these files are included in this document in the appropriate sections so the reader can understand which properties are available, what the default values are, etc., for each section. See the additional note below about how to read schema information.
2. Make a backup of the file before making any changes to it.

<a id="HowTo"></a>

## How to Read Config Schema

As noted above, this document contains snippets of schema information for each section, so the reader can discover what properties are available and what their default values and valid ranges are. The snippets are taken directly from the configuration schema file for IIS settings: `%windir%\system32\inetsrv\config\schema\IIS\_Schema.xml`. This section explains how to read schema information.

The schema for each configuration section is defined in a XML element. There is no schema definition for section groups. The following format is used here to explain how to read the schema:

[!code-xml[Main](introduction-to-applicationhostconfig/samples/sample1.xml)]

`&lt;attribute-name&gt;` is the name of the configuration attribute, as appears in XML. Every attribute must have a name.

`&lt;default-value&gt;` is the value used by default, if no other value is specified in the XML for the attribute. Not all attributes have default values (for example, site name). In this case, the syntax will be "".

`&lt;metadata&gt;` contains several items:

- The runtime type of the attribute. This is one of "bool", "enum", "flags", "int", "int64", "String", "timeSpan". Every attribute must have a type.
- "bool" is "true" or "false".
- "enum" is a set of possible values, where only one of them can be set for the attribute. Every such value has a numerical value and a friendly name. The syntax is using the character "|" as a delimiter between the friendly names: value1|value2|…|valueN.
- "flags" is similar to "enum", except that combinations of values are allowed. Therefore the numerical values should be in multiples of 2, so they can be ORed together to form combinations. The syntax is identical to "enum": value1|value2|…|valueN.
- "int" is a 32 bit integer.
- "int64" is a 64 bit integer.
- "String" is a character string.
- "timeSpan" is a representation of a time unit, similar to the managed-code type TimeSpan. It can be persisted as a number (representing seconds, or minutes); or as a formatted string in the form of "[dd:]hh:mm:ss". The "[dd:]" element represents an optional number of days. The other elements represent numbers of hours, minutes and seconds, respectively. The "timeSpanFormat" attribute specifies which format should be used: number of seconds, number of minutes, or a formatted string.
- Required attributes are marked "Required". It means that a value for them must be set in the XML. For example, site name is a required attribute (every site must have a name in IIS 7.0 and above).

`&lt;description&gt;` is a short description of the attribute.

<a id="Section"></a>

## Section Schema

The &lt;sectionSchema&gt; XML element is the base unit of schema information. All other schema information is specified within it. It has one attribute directly in it ("name"), and then the rest of the schema is in sub-elements within it:


[!code-xml[Main](introduction-to-applicationhostconfig/samples/sample2.xml)]

<a id="Attribute"></a>

## Attribute Schema

Every attribute is defined in a corresponding &lt;attribute&gt; XML element in the schema. The &lt;attribute&gt; element may be in the &lt;sectionSchema&gt; element directly (if the attribute is in the section scope); or in the element (if the attribute is in a sub-element within the section); or in the &lt;collection&gt; element (if the attribute is in a collection within the section).

An attribute schema must specify a name and a runtime type for the attribute. It may mark the attribute as required. It may mark the attribute as the unique key (if inside a collection), or as part of a collection key (together with other attributes). It may specify a default value for the attribute. It may mark the attribute for automatic encryption on-disk. It may specify if the word "Infinite" is allowed as a value for the attribute (only for numeric types such as int and in64, and for timeSpan). It may specify the timespan format (seconds, minutes or formatted string) for timespan attributes. It may specify validation rules for the attributes (see Attribute Validation section below in this document).

[!code-xml[Main](introduction-to-applicationhostconfig/samples/sample3.xml)]

<a id="Element"></a>

## Element Schema

Every element is defined in a corresponding &lt;element&gt; XML element in the schema. Elements can be nested. An element is simply a container for other attributes, or sub-elements. It must have a name and it may serve as a container of default values for collection elements (for example, siteDefaults holds the default values for sites in the &lt;sites&gt; collection).

<a id="Collection"></a>

## Collection Schema

Every collection is defined in a corresponding &lt;collection&gt; XML element in the schema. Collections contain multiple elements, which can be added and removed from them individually. Typically the collection directive names are "add", "remove" and "clear", but some collections use different names for clarity (for example, the collection is using "site" instead of "add").

This is done by specifying values for addElement, removeElement and clearElement in the collection schema. If a collection directive is missing from the schema, the collection will not support it. The collection schema may specify the name of a default element that will be used as a container of default values for collection elements (this complements isCollectionDefault in the element schema).

For example, the collection is using siteDefaults as the default element. Most collections append elements as they merge configuration files down the namespace, but some may specify mergeAppend="false" in the schema to have a prepend behavior. For example, consider two levels of configuration: applicationHost.config and web.config in a site. In applicationHost.config:


[!code-xml[Main](introduction-to-applicationhostconfig/samples/sample4.xml)]


In web.config:

[!code-xml[Main](introduction-to-applicationhostconfig/samples/sample5.xml)]

If the collection appends, its merged (effective) configuration at the site level will be:

[!code-xml[Main](introduction-to-applicationhostconfig/samples/sample6.xml)]

However, if it prepends, it will be:

[!code-xml[Main](introduction-to-applicationhostconfig/samples/sample7.xml)]

Some collections may allow duplicate entries by specifying allowDuplicates="true" in their schema. This is mostly done to support legacy collections in the .NET framework (in machine.config).

Some collections may allow additional attributes in them, beyond those specified in the schema. This is done by specifying allowUnrecognizedAttributes="true" in their schema. It is mostly done to support provider-based collections in the .NET framework. 

[!code-xml[Main](introduction-to-applicationhostconfig/samples/sample8.xml)]

<a id="Enum"></a>

## Enum Schema

Every attribute of type "enum" must define its enum values in a corresponding &lt;enum&gt; XML element in the schema. Every value must have a friendly name and a numerical value.


[!code-xml[Main](introduction-to-applicationhostconfig/samples/sample9.xml)]

<a id="Flags"></a>

## Flags Schema

Every attribute of type "flags" must define its flag values in a corresponding XML element in the schema. Every flag must have a friendly name and a numerical value that can be ORed together with other values to form combinations; therefore, the value should be in multiples of 2.


[!code-xml[Main](introduction-to-applicationhostconfig/samples/sample10.xml)]

<a id="Attribute"></a>

## Attribute Validation

Attribute validation is done when parsing the XML to get a section from the file, and when calling the configuration API to set values. If validation fails, it fails the desired operation (getting the section or setting the invalid value).

Each attribute may associate one validator for its value. This is done by specifying the appropriate validator name in the validationType, and additional parameters in the validationParameter in the attribute schema.

The system supports these validators:

### ApplicationPoolName validator

This validator fails on these characters: |&lt;&gt;&amp;\" 

[!code-console[Main](introduction-to-applicationhostconfig/samples/sample11.cmd)]


### IntegerRange validator

This validator fails if value is outside [inside] range, in integers. 

[!code-console[Main](introduction-to-applicationhostconfig/samples/sample12.cmd)]


### NonEmptyString validator

This validator fails if string value is set. 

[!code-console[Main](introduction-to-applicationhostconfig/samples/sample13.cmd)]


### SiteName validator

This validator fails on these characters: /\.? 

[!code-console[Main](introduction-to-applicationhostconfig/samples/sample14.cmd)]


### TimeSpanRange validator

This validator fails if value is outside [inside] range, in seconds. 

[!code-console[Main](introduction-to-applicationhostconfig/samples/sample15.cmd)]


### TrimWhiteSpace validator

This validator fails if white space is set at start or end of value. 

[!code-console[Main](introduction-to-applicationhostconfig/samples/sample16.cmd)]

<a id="XML"></a>

## XML Header

Every configuration file is an XML file and may optionally include the following line as the first line:

[!code-xml[Main](introduction-to-applicationhostconfig/samples/sample17.xml)]

In addition, it must include all its content within an XML &lt;configuration&gt; tags:

[!code-xml[Main](introduction-to-applicationhostconfig/samples/sample18.xml)]

ApplicationHost.config includes the above lines in it. The rest of this document walks through the rest of the sections in the file.

<a id="ConfigSection"></a>

## &lt;configSections&gt; Section

This is the very first section in the file. It contains a list of all other sections in the file. This is the point of registration for the sections (for example, to unregister a section from the system, remove its line from this section – no need to remove its schema file from the config\schema directory).

Note that other configuration files may have a section as well, at the very top of the file. This may be useful to register sections at levels lower than the global level. These sections will be registered for that scope of the namespace only. Web.config files can only add sections to the system; they cannot redefine sections that were registered in parent levels, and they cannot remove (unregister) sections.

The sections are structured by their hierarchy of containing section groups. Each section registration specifies the section name; the managed-code type of the section handler (this has no meaning in this file and will get removed after beta2 – it is used only by System.Configuration, so it will still exist in machine.config and web.config files); the allowDefinition level, if differs from the default; and the overrideModeDefault (this attribute is used to lockdown most IIS sections in this file).

> [!NOTE]
> Section is the basic unit of deployment, registration, locking, searching and containment of configuration settings. Every section belongs to one section group ("immediate parent"). Section group is a container of logically-related sections, and is used solely for purposes of structured hierarchy. No operations can be done on section groups. Section groups cannot have configuration settings directly (the settings belong to sections). Section groups may be nested; section cannot.

<a id="Schema"></a>

## Schema

[!code-xml[Main](introduction-to-applicationhostconfig/samples/sample19.xml)]

<a id="Locking"></a>

## Locking

Most IIS sections are locked down by default, using overrideModeDefault="Deny" in the section. The recommended way to unlock sections is by using tags, as follows:

[!code-aspx[Main](introduction-to-applicationhostconfig/samples/sample20.aspx)]

The above location tag unlocks the section for the default web site only. To unlock it for all sites, specify this in applicationHost.config:

[!code-aspx[Main](introduction-to-applicationhostconfig/samples/sample21.aspx)]

> [!NOTE]
> path="." and path="" have the same effect. They refer to the current level in the hierarchy.