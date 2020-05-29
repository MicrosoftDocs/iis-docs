---
title: "Accessing Configuration Sections Using Microsoft.Web.Administration (MWA)"
author: rick-anderson
description: "Abstract This article shows how configuration sections in the IIS configuration files (applicationHost.config and web.config) can be accessed programmaticall..."
ms.date: 11/23/2007
ms.assetid: 4845970c-5a5f-435e-b44c-9bc2637f3262
msc.legacyurl: /learn/manage/scripting/accessing-configuration-sections-using-microsoftwebadministration-mwa
msc.type: authoredcontent
---
# Accessing Configuration Sections Using Microsoft.Web.Administration (MWA)

by [Saad Ladki](https://twitter.com/saadladki)

## Abstract

This article shows how configuration sections in the IIS configuration files (applicationHost.config and web.config) can be accessed programmatically using the Microsoft.Web.Administration APIs. It deals with more complex sections that have nested elements and collections. There are examples using the real IIS configuration sections defined in the IIS\_schema.xml file. This article show how these sections can be accessed and manipulated in a generic way using the base classes provided by Microsoft.Web.Administration and also by using strongly-typed classes to represent these sections.

## Introduction

This article provides examples of programmatic access to the IIS configuration sections using the Microsoft.Web.Administration APIs. This deals with sections that have nested elements (system.webServer/asp) and collections (system.webServer/security/isapiCgiRestriction). The first section shows how these sections can be manipulated using the generic base classes provided by Microsoft.Web.Administration and the second section gives examples of how strongly typed wrapper classes representing these sections are used.

## Schema for Sections with Nested Elements and Collections

#### Sections with nested elements

An example of a section that has nested elements is the system.webServer/asp section. The "session" element is defined within the "asp" section. The schema for this section is as shown below. There are other properties in the schema and other nested elements which are not shown in the example.

[!code-xml[Main](accessing-configuration-sections-using-microsoftwebadministration-mwa/samples/sample1.xml)]

### Sections with a collection

A section having a collection of elements indexed by a key is the system.webServer/security/isapiCgiRestriction section. The schema for the section is as shown.

[!code-xml[Main](accessing-configuration-sections-using-microsoftwebadministration-mwa/samples/sample2.xml)]

## Generic Access to the Sections

Microsoft.Web.Administration provides several generic base classes which represents different components in the configuration system.

- **Configuration:** represents a single configuration file (applicationHost.config or the web.config files for sites and applications)
- **ConfigurationElement:** a generic entity used to represent an element in a configuration file. This is the base class for configuration sections, collection entries, nested elements in a section, etc.
- **ConfigurationAttribute:** represents a property within a ConfigurationElement
- **ConfigurationSection:** derives from ConfigurationElement and represents a section defined in the IIS schema files. Used to access the various properties of a section.
- **ConfigurationElementCollection:** A collection class comprising of ConfigurationElements. Also derives from ConfigurationElement.

The example below shows how the nested elements can be accessed in the system.webServer/asp section.

[!code-csharp[Main](accessing-configuration-sections-using-microsoftwebadministration-mwa/samples/sample3.cs)]

The ServerManager class is the entry point to access the various server settings. We set the properties in the applicationHost.config files, but these properties can also be accessed and changed in the web.config files of individual sites and applications. The CommitChanges call saves the changed settings.

The next example shows how to iterate through elements in a collection and add elements to it.

[!code-csharp[Main](accessing-configuration-sections-using-microsoftwebadministration-mwa/samples/sample4.cs)]

## Strongly Typed Classes to Access the Sections

Strongly typed classes derived from the generic base classes can be written in order to make accessing properties easier and more intuitive. This is especially useful when you might have to access the same section many times for different operations. These classes also ensure that you have compile time checking for property types. They avoid the tedious calls to methods like GetChildElement and GetAttributeValue.

The example below shows the wrapper for the system.webServer/asp section and the "session" element for that section. All the properties in that section are not included in this snippet.

[!code-csharp[Main](accessing-configuration-sections-using-microsoftwebadministration-mwa/samples/sample5.cs)]

The GetChildElement call in the above example is used to access a nested element in a configuration element (a section, collection element etc.). Calling base[...] wraps the GetAttributeValue and SetAttributeValue classes which retrieves and sets the values for those attributes.

The next example shows how the properties in a nested element can be accessed in a strongly typed manner.

[!code-csharp[Main](accessing-configuration-sections-using-microsoftwebadministration-mwa/samples/sample6.cs)]

Observe the call to config.GetSection which takes a section path and also the type of section you want to create. By default calls to config.GetSection create a ConfigurationSection and in order to get an instance of a strongly typed wrapper you need to pass in a type.

Here is an example of how to create strongly typed classes for a section which has a collection. This example uses the system.webServer/security/isapiCgiRestriction section. This snippet does not include all the properties that are present on this section.

[!code-csharp[Main](accessing-configuration-sections-using-microsoftwebadministration-mwa/samples/sample7.cs)]

The GetCollection method of the base class (ConfigurationElement) is used to access the default collection for that element.

The next example shows the strongly typed classes for the collection itself and the elements in the collection.

[!code-csharp[Main](accessing-configuration-sections-using-microsoftwebadministration-mwa/samples/sample8.cs)]

For the strongly typed collection class it is very useful to be able to index into the collection using the collection key, which in this case is the "path" attribute. The parameter to the Add method takes the required properties for that element. In this case the Add could have only taken the "path" attribute and then the "allowed" attribute would then have its default value.

Here is an example using these strongly typed classes to iterate through the entries in a collection and to add an element to it.

[!code-csharp[Main](accessing-configuration-sections-using-microsoftwebadministration-mwa/samples/sample9.cs)]
