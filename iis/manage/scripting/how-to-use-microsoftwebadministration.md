---
title: "How to Use Microsoft.Web.Administration"
author: rick-anderson
description: "IIS 7.0 and above provide a comprehensive managed-code management application programming interface (API) that allows complete manipulation of the XML config..."
ms.date: 11/23/2007
ms.assetid: bc52610c-38d1-425f-83ed-78e2e99ae33a
msc.legacyurl: /learn/manage/scripting/how-to-use-microsoftwebadministration
msc.type: authoredcontent
---
How to Use Microsoft.Web.Administration
====================
by [Saad Ladki](https://twitter.com/saadladki)

## Introduction

IIS 7.0 and above provide a comprehensive managed-code management application programming interface (API) that allows complete manipulation of the XML configuration files and convenience access to server objects. This document walks you through using the new management API to modify server configuration and administer server objects.

IIS includes Microsoft.Web.Administration, which is a new a management API for the web server that enables editing configuration through complete manipulation of the XML configuration files. It also provides convenience objects to manage the server, its properties and state. The configuration editing aspect of the API provides programmatic access to read and write configuration properties in the IIS configuration file hierarchy and specific configuration files. The object management aspect of this API provides a series of top-level administration objects for direct management of the server (i.e. sites, application pools, worker processes, etc).

The management classes reside in the Microsoft.Web.Administration namespace. The classes provide a weakly-typed interface to access configuration sections and convenience objects with properties and methods representing attributes of the configuration (like the path of a virtual directory) or actions to take on the object (like recycling an application pool).

## Create a New Site

The following code creates a site titled "Racing Cars Site" with its root application and root virtual directory. It also sets the site to use the HTTP protocol at port 80 and defines the physical path at d:\inetput\wwwroot\racing.


[!code-csharp[Main](how-to-use-microsoftwebadministration/samples/sample1.cs)]


The ServerManager is the factory class that contains a set of server convenience objects to which properties and methods are available to use in a strongly-type way. It is the main entry point for managing the server. Managing the server could have been done via other cumbersome routes (accessing raw configuration XML or calling state APIs), but through these objects managing the server is seamless. The most common set of objects are available to use via the server manager include: applications, virtual directories, sites, worker processes and application domains.


[!code-console[Main](how-to-use-microsoftwebadministration/samples/sample2.cmd)]


The sites object enables access to a sites properties and applications. It also contains methods to add a site to the system or get the total site count. The add method also defines the name of the site, the root virtual directory path, and the port number as integer. Also note that this call is being instantiated as a Site object, mySite, to which then we could act upon the newly created site by modifying its properties directly.


[!code-console[Main](how-to-use-microsoftwebadministration/samples/sample3.cmd)]


The convenience objects make modifying properties easy. By accessing the properties from the mySite object, one can set the auto-start property of the site to "true" directly without knowing any specific XML attribute or element concepts.


[!code-console[Main](how-to-use-microsoftwebadministration/samples/sample4.cmd)]


Also, a different route that could have been taken to modify the auto-start property is to not instantiate a site object. Instead, fetch the site once it is created and modify its properties directly. The management object uses the concept of indexers to search for specific objects by keys such as name or index without having to incur in expensive calls to list the entire object set. By defining the name one can get the specific object and act upon it.


[!code-console[Main](how-to-use-microsoftwebadministration/samples/sample5.cmd)]


In order to update, the commit changes call executes the transaction to serialize configuration, if any has changed, to disk.


[!code-console[Main](how-to-use-microsoftwebadministration/samples/sample6.cmd)]


Executing the code above generates the following output in applicationHost.config within the section. Instead of manipulating the XML directly and working at the element and attribute level, using the server manager objects provides a convenient way to manage the web server.


[!code-xml[Main](how-to-use-microsoftwebadministration/samples/sample7.xml)]


## Create a New Application Pool

The following code modifies the existing "Racing Cars Site" and changes its name and the physical path at d:\inetput\wwwroot\racing. It also creates a new application pool, defines some properties, set the racing site to use this pool and finally recycles it.


[!code-csharp[Main](how-to-use-microsoftwebadministration/samples/sample8.cs)]


Instead of indexing to fetch the site, you can instantiate a site object and set the reference to it. Once the reference is set, you can call the methods for the site object, in this case name, to rename the site directly.


[!code-console[Main](how-to-use-microsoftwebadministration/samples/sample9.cmd)]


Here is another use of the indexers to get the root application and then the root directory and set the physical path on it.


[!code-console[Main](how-to-use-microsoftwebadministration/samples/sample10.cmd)]


Besides the site object, we have the application pool object that provides a convenient way to get and set configuration properties, as well as act on state methods and data. A new application pool is created and then immediately the site is put on that application pool.


[!code-console[Main](how-to-use-microsoftwebadministration/samples/sample11.cmd)]


Like the server manager site object, the server manager application pool object allows you to create the application pool object and set the reference to it. You can also get and set properties and call on methods.

Once the application pool configuration data is serialized to the file via the update call, you can execute the recycle method on it. This recycle call is not necessary, since the application pool will simply be created and there is no need. But this illustrates that action can be taken in objects that have been created only after they are serialized to disk and the server can fetch this configuration and act upon it.


[!code-console[Main](how-to-use-microsoftwebadministration/samples/sample12.cmd)]


Executing the code above generates the following output in applicationHost.config within the section. Instead of manipulating the XML directly and working at the element and attribute level, using the server manager objects provides a convenient way to manage the web server.


[!code-xml[Main](how-to-use-microsoftwebadministration/samples/sample13.xml)]


Also, the following changes happen to the section:


[!code-xml[Main](how-to-use-microsoftwebadministration/samples/sample14.xml)]


## Set Configuration in Site Root web.config

The following code sets the "enabled" attribute of the section to false for site "Default Web Site".


[!code-csharp[Main](how-to-use-microsoftwebadministration/samples/sample15.cs)]


The configuration is a class that provides access to configuration sections in the system. Based on the different calls to get configuration, you could access applicationHost.config, web.config, administration.config or any other configuration file. The GetWebConfiguration call specifically gets a web.config file for the given site – Default Web Site - and the specific path – root.


[!code-console[Main](how-to-use-microsoftwebadministration/samples/sample16.cmd)]


Once the web.config file is acquired (if it does not exist, is created), the call to get a section is made. We are looking for the section in order to disable it. Even if the web.config file does not exist (or if it does exist, but there is no section set explicitly), there is still effective configuration applied to the site level. This is the configuration that will be overridden.


[!code-console[Main](how-to-use-microsoftwebadministration/samples/sample17.cmd)]


By using methods on the section object, you can get the enabled attribute and then set its value via the value method. Only after calling the commit changes method in the server manager will the changes be serialized and persisted to disk and immediately be picked up by the server. If there are multiple instances of configuration objects, calling commit changes on the server manager will persist all objects to disk.


[!code-console[Main](how-to-use-microsoftwebadministration/samples/sample18.cmd)]


Another option to get and set attribute information from a section is via the use of indexers. The following line of code can be used after getting the section object in order to set the enabled attribute value.


[!code-console[Main](how-to-use-microsoftwebadministration/samples/sample19.cmd)]


The end result is configuration set on the web.config file of the site specified.

## Set Configuration For a Site in applicationHost.config

The following code sets the "enabled" attribute of the section to false for site "Default Web Site".


[!code-csharp[Main](how-to-use-microsoftwebadministration/samples/sample20.cs)]


This code is effectively the same as the previous task; the only difference is the configuration manager call to get the applicationHost.config file via GetApplicationHostconfiguration.

> [!NOTE]
> The get section call is the one that specifies both the section that will be read and/or modified as well as the location path for it.


[!code-console[Main](how-to-use-microsoftwebadministration/samples/sample21.cmd)]


The end result is configuration set on the applicationHost.config file applicable to the site specified via a location tag.