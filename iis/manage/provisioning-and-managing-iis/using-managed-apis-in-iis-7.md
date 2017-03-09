---
title: "Using Managed APIs in IIS 7 | Microsoft Docs"
author: walterov
description: "IIS 7 provides a comprehensive managed-code management application programming interface (API) that allows complete manipulation of the XML configuration fil..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 12/22/2007
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/manage/provisioning-and-managing-iis/using-managed-apis-in-iis-7
msc.type: authoredcontent
---
Using Managed APIs in IIS 7
====================
by [Walter Oliver](https://github.com/walterov)

## Introduction

IIS 7 provides a comprehensive managed-code management application programming interface (API) that allows complete manipulation of the XML configuration files and convenience access to server objects. This article introduces you to the new management API used to modify server configuration and administer server objects.

IIS 7 includes Microsoft.Web.Administration, which is a new a management API for the web server that enables editing configuration through complete manipulation of the XML configuration files and also provides convenience objects to manage the server, its properties and state. The configuration editing aspect of the API provides programmatic access to read and write configuration properties in the IIS configuration file hierarchy and specific configuration files. The object management aspect of this API provides a series of top-level administration objects for direct management of the server (i.e. sites, application pools, worker processes, etc).

## Classes and Objects

The management classes reside in the Microsoft.Web.Administration namespace. The classes provide a weakly-typed interface to access configuration sections and convenience objects with properties and methods representing attributes of the configuration (like the path of a virtual directory) or actions to take on the object (like recycling an application pool).

The ServerManager is the factory class that contains a set of server convenience objects to which properties and methods are available to use in a strongly-typed way. ServerManager is the main entry point for managing the server. Managing the server could be done via other cumbersome routes (accessing raw configuration XML or calling state APIs), but through these objects, managing the server is seamless.

The most common set of objects are available to use via the server manager include:

- Applications
- Virtual directories
- Sites
- Worker processes
- Application domains

### Diagram

The following shows the main objects (excluding Configuration related classes).

[![](using-managed-apis-in-iis-7/_static/image3.jpg)](using-managed-apis-in-iis-7/_static/image1.jpg)

The ServerManager class also provides methods for obtaining different configurations, such as web.config, and administration.config, etc., and returns as Configuration class, which allows you to navigate the different XML entities to manage various configuration settings.

Since Microsoft.Web.Administration APIs only expose certain key entities as strongly typed objects such as Site, ApplicationPool and Application to manage other configuration settings, you must use weakly typed configuration objects, i.e. ConfigurationElement, ConfigurationSection and so forth. [This sample](provisioning-sample-in-c.md#CreateFTPsite "Provisioning FTP Site") illustrates it when provisioning an FTP site, which is not exposed as a strongly typed object.