---
title: "Metabase Compatibility with IIS 7 and Above"
author: rick-anderson
description: "The configuration system in IIS 7 and above is compatible with legacy configuration interfaces at the API level. It supports the Admin Base Objects (ABO) int..."
ms.date: 11/22/2007
ms.assetid: ad50cddc-9c90-4044-b7b4-65fc7d548d69
msc.legacyurl: /learn/manage/managing-your-configuration-settings/metabase-compatibility-with-iis-7-and-above
msc.type: authoredcontent
---
Metabase Compatibility with IIS 7 and Above
====================
by [Saad Ladki](https://twitter.com/saadladki)

## Introduction

The configuration system in IIS 7 and above is compatible with legacy configuration interfaces at the API level. It supports the Admin Base Objects (ABO) interface, also known as IMSAdminBase, as well as the ADSI and WMI providers that were built on top of ABO in IIS 6.0. Existing applications and scripts can still call into those programmatic interfaces on IIS 7.0 and above and continue to work, as long as the Metabase Compatibility component of IIS is installed

> [!NOTE]
> By default, this component is not installed.

<a id="Installing"></a>

## Installing Metabase Compatibility Support

You can find this component in setup under Internet Information Services-&gt;Web Management Tools -&gt; IIS 6.0 Management Capability Feature.

This component is not installed by default because IIS is not initially set up to use it. The legacy interfaces have some limitations and are not ideal for working with distributed configuration files (see Limitations section below); therefore it is recommended that over time, and especially when opening up the configuration system for more and more delegation (i.e. more and more web.config files with IIS settings in them are present on the system), customers will consider porting legacy scripts and applications over to the new system and its interfaces.

It is also recommended that new scripts and applications be developed using the new interfaces, so they work ideally with the new system, and can have access to the new properties, concepts and structure of the configuration system.

When all of the legacy scripts and applications are ported to the new interfaces, it is recommended to uninstall the Metabase Compatibility feature.

<a id="How"></a>

## How Metabase Compatability Works

The Metabase Compatibility feature runs inside the Metabase service (IISADMIN). It intercepts all method calls to ABO. If the information in the method call is related to the web server configuration, it is mapped to the new system. If it is related to FTP, or SMTP, or NNTP configuration, then it follows the regular logic of the Metabase system and ends up in the Metabase file.

Note that even custom properties that are under the web server configuration are mapped to (and persisted in) the new system.

The mapping decision is based on the Metabase node in question. Web server configuration is typically under LM/W3SVC, including custom properties, with some few additions like Mime Maps.

Mapping is done to translate back and forth between the ABO view back and the new system view. For example, the new system has a concept of applications, under each site and above all virtual directories. The legacy system handles applications differently: they are simply virtual directories with a special property to mark them as applications (AppIsolated, or AppRoot).

When calling ABO to write web server configuration, the Metabase Compatibility component will persist the data in applicationHost.config. This is referred to as "write-through", because the information is not kept in-memory. When calling ABO to read web server configuration, the Metabase Compatibility component will read it from applicationHost.config. This is referred to as "read-through", because the information is again not fetched from memory.

Incomplete data that is not ready for consumption by the server runtime is persisted into a special section in applicationHost.config, called customMetadata. This section is used as a persistent store for the Metabase Compatibility feature, and customers should never modify its content. An example of incomplete data is when the legacy script set the site id but not the site bindings. In IIS 6.0, such a call would have created an invalid site object in configuration. In IIS 7.0 and above, it is kept in the section, which is not consumed by the server. If a subsequent call is made to set the site bindings, then the site object is considered complete, and persisted in its entirety to the section, where it will be picked up by the server runtime. Temporary data will be removed from at that point, so the user will not need to cleanup leftovers from the system. If such a subsequent call is not made, then the server runtime will never see this invalid site, but legacy scripts will have it in the ABO view, just like they did in IIS 6.0. From the legacy script perspective, the system is fully compatible here with IIS 6.0.

Custom web server properties that are set via legacy scripts and applications are always persisted into the section. They can be retrieved via the legacy interface just like in IIS 6.0, so the system is fully compatible. Obviously, this is very different from the recommended way to extend the IIS configuration system, hence another reason to consider porting such applications, over time, to use new interfaces and new features offered by the IIS 7.0 and above configuration system.

<a id="Other"></a>

## Other Metabase Configuration Data

Note that FTP, SMTP and NNTP configuration is still persisted in the Metabase system and was not ported over to the new IIS configuration systems. The configuration settings for those can still be managed via legacy programmatic interfaces and direct editing of the metabase.xml file.

### Overview

Most operations on Metabase keys and properties work seamlessly and the user is presented with these legacy concepts and names and not the new IIS concepts like configuration sections and named properties (ABO continues to work with property IDs; ADSI continues to work with the legacy property names).

Legacy users can still use the ADSI schema and even extend it like they used to on IIS 6.0.

### XML File compatibility

The web server configuration, including custom configuration that extends the web server, is persisted into system32\inetsrv\applicationHost.config, and not metabase.xml. Therefore the legacy support is at the API level, and not at the file format level (and this is also why some legacy features are not supported). The legacy interface caller will get the "ABO view" of configuration just like it did on IIS 6.0, and not the new file format or naming or concepts.

One implication is that concepts like Metabase ACLs, are not supported. This is because they are tightly related to the Metabase file format. The IIS configuration system is leveraging standard file ACLs on the configuration files. The system is not providing mapping between Metabase ACLs and standard file ACLs.

Features like history files, backup/restore and import/export work differently because they rely on the new configuration system. ABO calls to backup configuration will therefore be ignored.

<a id="Legacy"></a>

## Legacy Metabase Features

Configuration auditing was added to IIS 6.0 in Windows Server® 2003 Service Pack 1. It is not currently supported by IIS 7.0 or above, because the new configuration system is architected very differently (e.g. IIS 7.0 and above use in-proc configuration system, IIS 6.0 is using a dedicated NT service that is encapsulated from user code in other processes).

### Legacy Metabase Properties

Only legacy properties are supported. IIS 7.0 and above configuration properties are not returned to the legacy user, and neither do .NET framework configuration properties.

### Mapping Limitations

The mapping algorithm needs to take care of differences between the IIS 6.0 and IIS 7.0 and above configuration systems. For example, IIS 6.0 did not require sites to have names ("server comments"); and if they were given names, there was no requirement to have these names be unique. In IIS 7.0 and above, every site must have a unique name. So mapping the old ServerComment property to the new Name property is not trivial. The mapping algorithm forces names to be unique per site because that's a requirement of the IIS 7.0 and above configuration system; it does so by adding numbers to the server comments to create uniqueness. The end result is that the value that is actually set for the server comment is different than the one specified by the script.

### Distributed Configuration

Only applicationHost.config is supported by the Metabase Compatibility feature. Configuration in web.config files is not returned to the legacy user. Location tags are used in applicationHost.config to support per-URL configuration.