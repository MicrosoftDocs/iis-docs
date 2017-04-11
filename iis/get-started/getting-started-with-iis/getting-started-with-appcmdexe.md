---
title: "Getting Started with AppCmd.exe | Microsoft Docs"
author: leanserver
description: "AppCmd.exe is the single command line tool for managing IIS 7 and above. It exposes all key server management functionality through a set of intuitive manage..."
ms.author: iiscontent
manager: soshir
ms.date: 11/16/2007
ms.topic: article
ms.assetid: 
ms.technology: iis
ms.prod: iis
msc.legacyurl: /learn/get-started/getting-started-with-iis/getting-started-with-appcmdexe
msc.type: authoredcontent
---
Getting Started with AppCmd.exe
====================
by [Mike Volodarsky](https://github.com/leanserver)

## Overview

AppCmd.exe is the single command line tool for managing IIS 7 and above. It exposes all key server management functionality through a set of intuitive management objects that can be manipulated from the command line or from scripts.

AppCmd enables you to easily control the server without using a graphical administration tool and to quickly automate server management tasks without writing code.

Some of the things you can do with AppCmd:

- Create and configure sites, apps, application pools, and virtual directories
- Start and stop sites, and recycle application pools
- List running worker processes, and examine currently executing requests
- Search, manipulate, export, and import IIS and ASP.NET configuration

AppCmd also allows server administrators to build advanced management tasks simply by combining multiple simpler AppCmd.exe commands, or reusing the output of the tool inside another program.

You can also find more AppCmd topics and learn powerful ways to manage your server from command line on my blog, at [http://mvolo.com/blogs/serverside/archive/tags/AppCmd/default.aspx](http://mvolo.com/blogs/serverside/archive/tags/AppCmd/default.aspx).

<a id="HowToUse"></a>

## How to Use AppCmd.exe

The AppCmd.exe command line is built on top of a set of top level server management objects, such as Site and Application. These objects expose methods that can be used to perform various actions on those objects, and object instances expose properties that can be inspected and manipulated.

For example, the Site object provides methods to list, create and delete site instances (these are standard methods that are present on almost all objects), as well as stop and start sites. Each site instance in turn will contain properties, such as site name and site id, that can be inspected, searched for, or set. The output of each command is always a list of object instances.

> [!NOTE]
> AppCmd.exe is located in the %systemroot%\system32\inetsrv\ directory. Because it is not path of the PATH automatically, you need to use the full path to the executable when executing commands like in "%systemroot%\system32\inetsrv\AppCmd.exe list sites". Alternatively, you can manually add the *inetsrv* directory to the path on your machine so that you can access AppCmd.exe directly from any location.

The tool works by executing a command on one of the supported management objects, with optional parameters used to further customize the behavior of the command:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample1.cmd)]

Where **&lt;COMMAND&gt;** is one of the commands supported by **&lt;OBJECT&gt;**. Most objects support this basic set of commands:

- **LIST** Display the objects on the machine. An optional &lt;ID&gt; can specify a unique object to list, or one or more parameters can be specified to match against object properties.
- **ADD** Create a new object with the specified object properties to set during creation.
- **DELETE** Delete the object specified by the &lt;ID&gt;.
- **SET** Set parameters on the object specified by &lt;ID&gt;.

An object will often support additional commands, such as START and STOP for the Site object.

For example, the current set of objects available through AppCmd is (where **&lt;OBJECT&gt;** is one of the management objects supported by the tool)**:** 


| Object | Description |
| --- | --- |
| Site | Administration of virtual sites |
| App | Administration of applications |
| VDir | Administration of virtual directories |
| Apppool | Administration of application pools |
| Config | Administration of general configuration sections |
| Backup | Management of server configuration backups |
| WP | Administration of worker processes |
| Request | Display of active HTTP requests |
| Module | Administration of server modules |
| Trace | Management of server trace logs |


Where **&lt;ID&gt;** is the object-specific identifier for the object instance you want to specify for the command. The format of the identifier is specific to each object type. For example, the Site object uses the site name, the App object uses the application path, and the AppPool object used the application pool name.

Where **[ /parameter:value ]\*** is zero or more parameters for the command. Each command supports a different set of parameters, depending on the object. Typically, commands that search for objects or manipulate object properties will allow any of the object's properties to be specified as a parameter.

The tool itself also supports a number of parameters that affect the general command execution, and are not specific to any of the objects. These are listed in the top-level help page available from "AppCmd.exe /?", and include parameters such as **/text**, **/config**, and **/xml** for controlling tool output, and **/commit** for controlling the location of configuration changes.

<a id="Help"></a>

## Getting Help

AppCmd provides self-describing help that can be used as a reference for all of the supported objects and commands. There are three types of help available as you drill into the task you would like to do.

### General Help

The general help screen shows the objects supported by the tool, as well as generally applicable tool parameters. To display general help:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample2.cmd)]

The first few lines of output are:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample3.cmd)]

### Object Help

The object help screen shows the commands supported by a specific object. To display object help:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample4.cmd)]

where **&lt;OBJECT&gt;** is one of the supported object types. For example, this command-line will display help for the site object:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample5.cmd)]

### Command Help

The command help screen describes the syntax for a specific command and object, including the parameters it supports and examples of common tasks. To display command help:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample6.cmd)]

For example, this command-line will display help for the LIST command of the App object:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample7.cmd)]

<a id="List"></a>

## Finding Objects with the LIST Command

The LIST command is the most versatile command, and is supported by all objects. The purpose of this command is to find instances of the object based on the criteria you specify. The output of this command is a list of object instances, which you can inspect by viewing their properties, export for future re-creation on another machine, or use together with another command to perform actions on them.

### Listing All Objects

The simplest way to use the LIST command is with no parameters, which simply lists all known instances of the object:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample8.cmd)]

For example, to list all sites on the machine, use this command-line:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample9.cmd)]

The output will be similar to:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample10.cmd)]

By default, each object is shown on a single line, specifying its object-specific identifier (such as "Default Web Site") and one or more important properties (such as id, bindings, and state).

### Listing a Specific Object

The LIST command can be used to find an instance of a specific, named object by using a command-line in this form:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample11.cmd)]

For example, use this command-line to find the site with a unique id of "Default Web Site":

[!code-console[Main](getting-started-with-appcmdexe/samples/sample12.cmd)]

### Listing Objects That Satisfy a Query

To find all object instances that match particular criteria, specify one or more parameters that indicate property values of the objects to match. For example, use this command-line to find all sites that are stopped:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample13.cmd)]

You can specify any number of property-value pairs, and the tool will make sure that the returned objects satisfy all of the specified criteria. For example, use this command-line to find sites that are both stopped and configured to not start automatically:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample14.cmd)]

<a id="Manipulating"></a>

## Manipulating Objects with ADD, SET, and DELETE

In addition to LIST, most objects also support ADD, SET, and DELETE commands.

### Adding New Objects

The ADD command creates a new instance of an object. For example, this command-line will create a new Site:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample15.cmd)]

Depending on the object, some parameters will be required in order to set required properties on the new instance, and other properties may be optional. An error will be returned if a required parameter is not specified.

The command help screen indicates which parameters are required. For example, use this command-line to see what parameters are required to add a Site:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample16.cmd)]

Read on for more information on creating sites, applications, virtual directories and application pools with AppCmd.

### Changing Existing Objects

The SET command sets one or more properties on a specified object instance. This command requires the object-specific identifier to be specified. For example, to change the id property of the "Default Web Site", use this command-line:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample17.cmd)]

Use a form of the command help syntax to see what properties can be set on a particular object. For example, to see the properties supported by the Default Web Site use:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample18.cmd)]

### Deleting Objects

The DELETE command deletes an instance of an object. Like SET, this command also requires the object-specific identifier to be specified. For example, use this command-line to delete the site named "MyNewSite":

[!code-console[Main](getting-started-with-appcmdexe/samples/sample19.cmd)]

<a id="Managing"></a>

## Managing Backups

AppCmd allows you to create and restore backups of global server configuration. You can use this to recover from unwanted changes to server configuration, and return to known-good server state. It is a good idea to create a backup before changing server configuration, or installing a component that changes it. Each backup contains the copy of the current ApplicationHost.config root configuration file, as well as other related server-wide state including FTP configuration and the IIS Administration Tool configuration.

To create a backup, use the ADD command of the Backup object:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample20.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample21.cmd)]

This created a backup with an auto-generated name that represents the date and time of backup.

A specific name for the backup can be specified like this:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample22.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample23.cmd)]

You can display a list of available backups using the LIST command of the Backup object:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample24.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample25.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample26.cmd)]

Finally, to restore a backup use the RESTORE command with name of the backup:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample27.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample28.cmd)]

Restoring a backup stops the server and restores global configuration to its state at the time the backup was created.

In Windows Server® 2008 and Windows Vista SP1, AppCmd will also be capable of working with periodic configuration backups made by the configuration history service. These backups will show up in the AppCmd list of backups and will be available to restore the same way as backups you made manually through the tool.

To learn more about managing configuration backups with AppCmd, see [http://mvolo.com/blogs/serverside/archive/2007/03/18/Most-Important-AppCmd-Commands\_3A00\_-Backing-up-and-restoring-IIS7-configuration.aspx](http://mvolo.com/blogs/serverside/archive/2007/03/18/Most-Important-AppCmd-Commands_3A00_-Backing-up-and-restoring-IIS7-configuration.aspx).

<a id="Working"></a>

## Working with Sites, Applications, Virtual Directories, and Application Pools

Creating and managing sites, applications, and virtual directories are the most common tasks administrators face. IIS 7 and above uses a stricter containment hierarchy than previous versions that works like this:

1. **Web Site** A Web site receives requests on particular binding endpoints defined by IP addresses and host headers. For example, this url represents a Web site bound to port 81: http://www.mysite.com:81  
 A Web site contains one or more applications.
2. **Application** An application is represented by its virtual path within a Web site's url namespace. For example, an application with a virtual path of "/app1" may be represented by this url: http://www.mysite.com:81/app1  
 An application belongs to one application pool.  
 An application contains one or more virtual directories.
3. **Virtual Directory** A virtual directory is represented by its virtual path within an application's url namespace. For example, a virtual directory with a virtual path of "/vdir1" may be represented by this url: http://www.mysite.com:81/app1/vdir1  
 A virtual directory maps to a physical location on disk.

This hierarchy is in contrast to IIS 6.0 where a Web site can contain a mix of virtual directories and applications, and applications are just specially marked virtual directories.

**Application Pool** An application pool specifies a group of settings for the worker processes that perform request processing for the applications in that application pool. Application pools are not part of the site-app-vdir hierarchy. Each application specifies which application pool it will run in, or it runs in the default application pool. The application pool defines a number of worker process settings, such as the version of the CLR loaded by it, the .NET integration mode, the account under which the worker process runs, and process recycle settings.

By default, IIS 7 and above are installed with a Web site named "Default Web Site" that listens on port 80 with no IP address nor host header restrictions. This Web site has a root application, and that application has a root virtual directory. There is also an application pool named "DefaultAppPool" which is used by all new applications by default.

This command-line will list all Sites, including the Default Web Site:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample29.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample30.cmd)]

Let's examine the applications that belong to the Default Web Site by specifying the site.name property when listing Apps:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample31.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample32.cmd)]

A similar command will list the virtual directories inside the "Default Web Site/" application by specifying the app.name property when listing Vdirs:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample33.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample34.cmd)]

Finally, let's examine the application pools:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample35.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample36.cmd)]

### Creating Sites, Applications, Virtual Directories, and Application Pools

Now, we will create a new Web site named "MySite", with site id of 2 that listens on port 81 for all IP addresses and host headers:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample37.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample38.cmd)]

The **name** parameters must be specified to create a Web site. The id parameter is optional, and will cause AppCmd to generate the next available site id for the new site if omitted. We also specify the **bindings** and **physicalPath** parameters, which are explained below. You can also specify additional properties to set their values.

The **bindings** property uses the format of **protocol/bindingInformation**, where bindingInformation is specific to the protocol. For HTTP, it is in the format of **IP:PORT:HOSTHEADER**. You can specify multiple bindings by using a comma to separate each definition.

We also specified a **physicalPath** property for the site. While a Web site itself does not have a physical path, this short form is used to conveniently create a Web site with a root application and a root virtual directory mapped to the specified physical path.

If you do not specify a physical path, the Web site will be created with no applications; an application and virtual directory will need to be created for it explicitly.

Let's go ahead and add another application to the Web site:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample39.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample40.cmd)]

This created a new application with virtual path "/app1" belonging to the site we created above, with a root virtual directory pointing to "C:\inetpub\mysite\app1". The required **path** parameter specifies the virtual path of the new application, and the required **site.name** parameter specifies the site to which the application will belong. The optional **physicalPath** parameter is a shortcut, much like in the Site case, that creates a root virtual directory together with the application.

If you do not specify the **physicalPath** parameter, or would like to add another virtual directory to the application, use a command-line like this:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample41.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample42.cmd)]

This created a new virtual directory with virtual path "/vdir1" belonging to the application we created above and pointing to "C:\inetpub\mysite\app1\vdir1". The required **path** parameter specifies the virtual path of the new virtual directory, and the required **app.name** parameter specifies the application to which the virtual directory will belong. The **physicalPath** parameter specifies the physical location of the virtual directory.

Finally, let's create a new application pool:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample43.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample44.cmd)]

This created a new application pool named "MyAppPool".

To learn more about sites, applications, and virtual directories in IIS 7 and above, and the options you have in creating them with AppCmd, see [Creating IIS7 and Above Sites, Applications and Virtual directories](http://mvolo.com/blogs/serverside/archive/2007/07/12/Creating-IIS7-sites_2C00_-applications_2C00_-and-virtual-directories.aspx).

### Configuring Sites, Applications, Virtual Directories, and Application Pools

Previously, we added a new Web site, complete with a few applications and virtual directories. Now, we will use AppCmd to modify some of their properties. All AppCmd objects support the same standard syntax for setting properties:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample45.cmd)]

First, let's display the applications available on the machine:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample46.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample47.cmd)]

Notice the two applications we created earlier under the Web site "MySite". Both of these applications are set to use the DefaultAppPool application pool. Let's change the applicationPool property of the "MySite/" root application to use the new application pool we created earlier named "MyAppPool":

[!code-console[Main](getting-started-with-appcmdexe/samples/sample48.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample49.cmd)]

This changed the value of the applicationPool property of the "MySite/" application to the new value, effectively moving the application to the new application pool.

The reason we moved the application to the new application pool is so that we can change some of the runtime parameters of the worker process within which this application will run. To do that, we will change some of the properties on the "MyAppPool" application pool. Before changing property values, it if often useful to first display the available properties and their current values. We can do that by listing our application in detailed view:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample50.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample51.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample52.cmd)]

Notice the number of properties on the application pool object; the full output is not shown here.

We are interested in changing the **managedRuntimeVersion** property to "v1.1" in order to run our applications in this application pool with ASP.NET v1.1. Here is the command-line to do that:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample53.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample54.cmd)]

You can see from the List output above that there are numerous properties available on the application pool object, and some of the properties are nested within a configuration sub-element. For example, process options are nested below the "processModel" sub-element.

If you want to set a nested property, address it with element path notation like this:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample55.cmd)]

<a id="Other"></a>

## Other Configuration Elements

In addition to manipulating configuration properties with the top-level AppCmd objects, you can set configuration properties on any configuration section, including the ones associated with the top-level AppCmd objects. This is covered later in the section named "Working with Configuration".

### Inspecting Server State

AppCmd provides functionality for inspecting various aspects of the runtime state of the server, including:

- site state
- application pool state
- active server worker processes
- currently executing requests

In addition, some objects provide commands that allow you to control their runtime state, such as the STOP command of the Site object and RECYCLE command of the AppPool object.

### Inspecting Site and Application Pool State

The state of sites and application pools is reported from the **state** property of each object. When listing sites or application pools, the state is displayed in the default output. For example:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample56.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample57.cmd)]

The state property can also be used to search for sites or application pools that are in a specific state. For example, to find all started application pools:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample58.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample59.cmd)]

### Inspecting Running Worker Processes

You can use the WP (worker process) object to list running worker processes:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample60.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample61.cmd)]

Each WP object has an **apppool.name** property, which allows you to list all of the running worker processes for a particular application pool:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample62.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample63.cmd)]

### Inspecting Currently Executing Requests

The Request object allows you to inspect the currently executing requests on the server:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample64.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample65.cmd)]

The list can be restricted to the requests of a particular site, application pool, worker process, or url by using the appropriate property to filter the results. Here are some examples:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample66.cmd)]

<a id="WorkingConfig"></a>

## Working with Configuration

IIS 7 and above feature an XML-based hierarchical configuration system similar to the ASP.NET configuration system that stores server configuration in schematized XML sections. The configuration can be located at the server level ApplicationHost.config file, or placed in distributed Web.config configuration files within your application hierarchy.

AppCmd allows full inspection and editing of the configuration hierarchy from command-line via its Config object. In addition, AppCmd provides other useful functions such as clearing configuration, locking and unlocking it, and searching it.

### Viewing Configuration

AppCmd works with configuration at the level of configuration sections. Each configuration section typically describes a server feature, and may contain one or more sub-elements and collections.

Configuration can be set for an arbitrary url namespace, such as for a site, application, or url. Configuration settings set at a higher level are inherited by all lower levels unless they are specifically overridden at lower levels.

To display effective configuration for particular url level, use the LIST command of the Config object as follows:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample67.cmd)]

Where **&lt;URL&gt;** is the configuration path at which the effective configuration should be read, such as "Default Web Site/" or "Default Web Site/app1/hello.html". If not specified, it defaults to server level.

To learn more about the IIS configuration hierarchy and how to build IIS configuration paths for use with AppCmd and other tools, see [Anatomy of an IIS7 and Above Configuration Path](http://mvolo.com/blogs/serverside/archive/2007/07/21/Anatomy-of-an-IIS7-configuration-path.aspx).

The **section** parameter specifies the configuration section you would like to read. If not specified, all configuration sections effective at the URL level will be displayed. For example, this command-line displays all effective configuration for the root application of the Default Web Site:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample68.cmd)]

To list a specific section, use a command-line like this:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample69.cmd)]

[!code-aspx[Main](getting-started-with-appcmdexe/samples/sample70.aspx)]

By default, AppCmd displays only configuration that is explicitly set. If you would like to display the effective configuration including inherited or default values, specify the **/config:\*** parameter:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample71.cmd)]

To display a list of available configuration sections, use this command-line:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample72.cmd)]

### Editing Configuration Properties

In AppCmd, each configuration section is exposed as an instance of a configuration object that exposes properties that represent the underlying configuration section. Use the SET command of the Config object to change these properties. The syntax is:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample73.cmd)]

**&lt;URL&gt;** is optional; it specifies at what configuration path the change should apply. It omitted, changes will be applied at the server level, to be inherited by all URLs.

The **section** parameter is required; it indicates the section that is being edited.

For example, to set the **appAllowClientDebug** property of the **ASP** section for the http://localhost/app1 url:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample74.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample75.cmd)]

To set configuration properties nested within sub-elements of the configuration section, use this element path notation:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample76.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample77.cmd)]

Specify more than one property in a single command-line to make multiple edits within the same configuration section.

To display all of the properties that can be set on a particular configuration section, use this command-line:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample78.cmd)]

**NOTE** that the asp section is locked by default, so executing these commands will return a lock violation error. You can either unlock this section first, set the configuration at the server level by omitting the&lt;URL&gt;, or commit them to the server level location tag by using /commit:apphost. See **controlling location of configuration** further in the article.

### Editing Configuration Collections

AppCmd also provides support for editing configuration collections. A configuration collection can contain multiple elements — for example, the **system.webServer/modules** configuration section contains a list of module configuration elements specifying the modules executed by the server.

To set a property on a collection element, specify the particular collection element to edit by using a collection indexer expression within the element path notation. The collection indexer expression uses key values to identify a specific collection element. The indexer has the following format:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample79.cmd)]

The number of keys required to uniquely identify an element depends on the collection. Most collections require only one key.

For example, in order to set the type property on the collection element with the key name property equal to "FormsAuthentication", use this command-line:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample80.cmd)]

To add a new collection element, prefix the element path notation with a plus sign, **+**. Within the collection indexer expression, provide the values for each key property. Additional, non-key properties may also be included within the collection indexer expression. For example, this will add a new module collection element:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample81.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample82.cmd)]

### Controlling Location of Configuration

The configuration system is hierarchical, allowing configuration settings to be written at multiple levels ranging from the server-level ApplicationHost.config file to distributed Web.config files that can be present at the site, application, or virtual directory levels.

When the configuration is written at a particular level, it is inherited by all URLs at that level and lower. For example, configuration set in the Web.config configuration file at the root of the site in inherited by all URLs of the site.

By default, AppCmd will write configuration at the level at which it is being set. For example, if you are setting configuration for the "Default Web Site/", it will be written in a Web.config file at the root of that site.

However, it is possible to write configuration at a higher level, and only apply it to a particular subset of URLs below by using a *location* construct. For example, the application Web.config can contain configuration that is applied to only a single directory within that application. AppCmd provides this capability through its **commit** parameter.

The commit parameter can be set to one of the following:

- (omitted) — default; write configuration at the level for which it is set
- **url** — same as default; write configuration at the level for which it is set
- **site** — write configuration in the Web.config at the site root of the url for which it is set
- **app** — write configuration in the Web.config at the app root of the url for which it is set
- **apphost** — write configuration at the server level, in the applicationHost.config file
- **&lt;PATH&gt;** — write configuration at the specified config path

For example, this command-line turns directory browsing off for an application, and writes that configuration within the Web.config file of the site root:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample83.cmd)]

To learn more about IIS configuration paths and controlling the location of configuration, see [Anatomy of the IIS7 and above configuration path](http://mvolo.com/blogs/serverside/archive/2007/07/21/Anatomy-of-an-IIS7-configuration-path.aspx).

### Locking and Unlocking Configuration

The configuration system allows configuration sections to be locked at a particular level, preventing their properties from being overridden at lower levels. This can be used to prevent applications from changing settings that the server administrator wishes to enforce.

By default, most of the IIS configuration sections are locked at the server level. In order to configure these sections at lower levels, they need to be unlocked. AppCmd provides the UNLOCK command for this purpose:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample84.cmd)]

Use the LOCK command to lock a section:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample85.cmd)]

Note that if you lock a configuration section, all applications that may have already configured that section at a lower level will experience a lock violation error when they try to access the configuration section.

### Searching Configuration

AppCmd can search the distributed configuration hierarchy for all locations that set particular configuration properties or property values. The configuration search feature can be used to pinpoint locations where a particular feature is being enabled, or to insure compliance with a particular configuration requirement.

To search the server for all locations that define configuration, you can use the SEARCH command with no arguments:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample86.cmd)]

To search all locations under a particular configuration path, such as all configuration locations for a particular site, include the path on the command-line:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample87.cmd)]

To search for locations that configure a particular configuration section:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample88.cmd)]

To search for locations that set a particular property, include the property name:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample89.cmd)]

And finally, to search for locations that set a property to a specific value:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample90.cmd)]

<a id="WorkingTool"></a>

## Working with Tool Output

Earlier, we mentioned that the output of the LIST command is a list of object instances. AppCmd offers different output modes that allow control over the level of detail displayed about each object.

### Default Output

Let's take LIST Sites as an example. By default, AppCmd uses a compact output format:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample91.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample92.cmd)]

In this output format, each object instance is on one line, specifying the object type (SITE), and the object's identifier ("Default Web Site"). Several common or important properties are generally also output (id, bindings, and state for the Site object).

### Detailed Output

Most objects support significantly more properties than are presented in the default output. To display all of the object properties, specify the text:\* parameter. The properties of each instance will be displayed in a hierarchical tree format:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample93.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample94.cmd)]

In the example above, the output has been abbreviated — the actual output includes many more properties.

### Output for Working With Other Command-line Tools

AppCmd provides an output mode that displays only a specific property of each object instance. Specify the name of the property to display with the **text:&lt;PROPERTY&gt;** parameter. For example, this command will return all of the virtual directory instances available, displaying only the **physicalPath** property of each:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample95.cmd)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample96.cmd)]

You can, of course, display any of the valid property of the object-type being listed.

It is sometimes desireable to use the output of AppCmd with existing command line tools and shell commands, such as the FOR command and FINDSTR.EXE. These tools often work best when each data item of interest is located on a separate line.

As an example, imagine a command-line that produces a directory listing of each IIS virtual directory. The command-line needs to acquire a list of physical paths from each of the virtual directories of interest, and then execute a DIR command on each of those paths using the FOR command to loop though them:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample97.cmd)]

### Configuration Output

Many of the objects contain configuration data that comes directly from the associated configuration sections. The Config object is the main example of that, and serves as a direct wrapper over the IIS configuration system — each object instance returned by the Config object is a configuration section. Other objects, such as Site, also contain configuration information as part of the object properties.

If you would like to display the configuration information for the returned objects in the raw XML format of the configuration system, you can use the **config** parameter. For example, to display the XML configuration information for the site object, use a command-line like this:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample98.cmd)]

[!code-xml[Main](getting-started-with-appcmdexe/samples/sample99.xml)]

[!code-console[Main](getting-started-with-appcmdexe/samples/sample100.cmd)]

### XML Output

The tool also supports its own XML output format, which generates well-formed XML result sets for the objects returned from the command execution. This enables some exciting capabilities that distinguish AppCmd from any previous command line tools provided by the IIS team.

- **Building complex management tasks**. The main purpose of this ability is to enable the result sets generated by AppCmd to be input to another AppCmd command. This enables you to quickly execute complex management tasks without writing application code.
- **Performing batch operations efficiently**. Executing the tool a large number of times when performing a large number of operations (for example creating 10,000 sites) may be slow due to the overhead of process creation and initialization for each operation. Instead, a single tool command can execute over input data contained within an XML data set, dramatically reducing the execution time of processing the input data.
- **Exporting data to other tools**. The XML format enables the data sets generated by AppCmd to be used with other tools in order to process, store, or provide reporting. For example, AppCmd data can be used with XSLT transforms to general HTML management reports, imported into SQL Server 2005 for further analysis, or loaded by ADO.NET for programmatic processing.

For example, to output the list of sites in XML mode:

[!code-console[Main](getting-started-with-appcmdexe/samples/sample101.cmd)]

To learn more about the piping feature, and how to leverage it for powerful command line management, see [http://mvolo.com/blogs/serverside/archive/2007/06/19/Do-complex-IIS-management-tasks-easily-with-AppCmd-command-piping.aspx](http://mvolo.com/blogs/serverside/archive/2007/06/19/Do-complex-IIS-management-tasks-easily-with-AppCmd-command-piping.aspx).

<a id="Summary"></a>

## Summary

In this overview, we familiarized you with all the different powerful commands available using the IIS 7 and above Command-Line utility, AppCmd.exe.

You can also find more AppCmd topics and learn powerful ways to manage your server from command line on my blog, at [http://mvolo.com/blogs/serverside/archive/tags/AppCmd/default.aspx](http://mvolo.com/blogs/serverside/archive/tags/AppCmd/default.aspx).