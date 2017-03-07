---
title: "PowerShell Snap-in: Using the Task-based Cmdlets of the IIS PowerShell Snap-in | Microsoft Docs"
author: rick-anderson
description: "IIS PowerShell Snap-in cmdlets can be grouped into three categories: Cmdlets required by the Provider Hierarchy low-level configuratioin cmdlets Task-based c..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 07/02/2008
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/manage/powershell/powershell-snap-in-using-the-task-based-cmdlets-of-the-iis-powershell-snap-in
msc.type: authoredcontent
---
PowerShell Snap-in: Using the Task-based Cmdlets of the IIS PowerShell Snap-in
====================
by Thomas Deml

## Introduction

IIS PowerShell Snap-in cmdlets can be grouped into three categories:

- Cmdlets required by the Provider Hierarchy
- low-level configuratioin cmdlets
- Task-based cmdlets

This walkthrough introduces the task-based IIS cmdlet and gives some examples how to use them.

### Cmdlets Required by the Provider Hierarchy

IIS decided early on to make IIS configuration available as an hierarchy of Sites, Applications, Virtual Directories and Application Pools. The benefit is that customers can navigate to a location, e.g. a Site or Application, in the hierarchy and set settings in this context. To support a navigation hierarchy certain pre-defined PowerShell cmdlets like New-Item, Set-ItemProperty etc. have to be implemented. The hierarchy and these built-in cmdlets were shipped in Tech Preview 1 in April 2008.

### Low-level Configuration Cmdlets

The IIS configuration system was completely revised in version 7. The new configuration system is fully XML-based, schema-driven and completely extensible. The new IIS FTP Server (FTP7) and many other IIS modules like the URL Rewriter, WebDAV etc. leverage this extensibilty to plug into the IIS configuration system.

This extensibilty makes it hard to ship cmdlets with static arguments. Imagine the case where somebody extends an existing configuration section, for example somebody adds a *myFancyNewBehavior* property to the virtualDirectory configuration section. Without revising the IIS cmdlets fancyNewBehavior setting wouldn't be settable via the PowerShell Snap-in cmdlets.

Technical Preview 1 of the IIS PowerShell Snap-in included only low-level cmdlets that took the total configuration extensibility in account. Every IIS configuration setting (more than 100 configuration sections with collections, enumerations etc.) can be configured using these cmdlets. These low-level cmdlets also work against custom configuration, for example if you extended IIS configuration with your own configuration section.

Here is the list of low-level cmdlets we ship since Tech Preview 1 back in April 2008:


[!code-powershell[Main](powershell-snap-in-using-the-task-based-cmdlets-of-the-iis-powershell-snap-in/samples/sample1.ps1)]


## Task-based Cmdlets

Here comes the exciting news. For day-to-day IIS tasks like creating web-sites, enabled request tracing, adding a handler or a module you probably want to use the task-based cmdlets that come with the IIS PowerShell Snap-in. Here is a list of the task-based cmdlets:

[!code-powershell[Main](powershell-snap-in-using-the-task-based-cmdlets-of-the-iis-powershell-snap-in/samples/sample2.ps1)]

## Help for the Task-based Cmdlets

'Using the built-in help system is the easiest way to find out what cmdlets are available and how to use them. The following command lists all IIS cmdlets.


[!code-powershell[Main](powershell-snap-in-using-the-task-based-cmdlets-of-the-iis-powershell-snap-in/samples/sample3.ps1)]


Another way is to look for -Web prefix we use for all IIS cmdlets. Try this command:


[!code-powershell[Main](powershell-snap-in-using-the-task-based-cmdlets-of-the-iis-powershell-snap-in/samples/sample4.ps1)]


The built-in help system gives you a quick description about an individual cmdlet, about the parameters and arguments it takes and it has examples how to use the cmdlet. Try the following:


[!code-powershell[Main](powershell-snap-in-using-the-task-based-cmdlets-of-the-iis-powershell-snap-in/samples/sample5.ps1)]


To receive the full help about a particular cmdlet you can enter the following:


[!code-powershell[Main](powershell-snap-in-using-the-task-based-cmdlets-of-the-iis-powershell-snap-in/samples/sample6.ps1)]


If you only want to see an example how to use it try the following command:


[!code-powershell[Main](powershell-snap-in-using-the-task-based-cmdlets-of-the-iis-powershell-snap-in/samples/sample7.ps1)]


## End-to-end Example

The power of the task-based cmdlets shows when you use it for an end-to-end scenario. In the following example we will create an new web-site, add some content to the web-site, make some configuration changes, enable Request Tracing and request the new content page.

### Step 1: Creating a new web-site

Enter the following commands:


[!code-unknown[Main](powershell-snap-in-using-the-task-based-cmdlets-of-the-iis-powershell-snap-in/samples/sample-127221-8.unknown)]


This creates a new physical directory for our new site.


[!code-unknown[Main](powershell-snap-in-using-the-task-based-cmdlets-of-the-iis-powershell-snap-in/samples/sample-127221-9.unknown)]


The line above creates a new web site pointing to the newly created directory and listening on port 81.

### Step 2: Adding content to the site

The following commands will navigate the IIS namespace and create a new content file.


[!code-unknown[Main](powershell-snap-in-using-the-task-based-cmdlets-of-the-iis-powershell-snap-in/samples/sample-127221-10.unknown)]


The command above navigates to the MyNewWebSite node in the IIS namespace.


[!code-unknown[Main](powershell-snap-in-using-the-task-based-cmdlets-of-the-iis-powershell-snap-in/samples/sample-127221-11.unknown)]


The above command lists all the contents of the new web site. It won't show anything because there is no content.


[!code-unknown[Main](powershell-snap-in-using-the-task-based-cmdlets-of-the-iis-powershell-snap-in/samples/sample-127221-12.unknown)]


The above command opens notepad and allows you to edit test.htm. Instead of having to remember where the physical path of your web site. Enter some text, e.g. "Hello World" and save the file in notepad.

[!code-unknown[Main](powershell-snap-in-using-the-task-based-cmdlets-of-the-iis-powershell-snap-in/samples/sample-127221-13.unknown)]

If you enter the dir command again it will show you the newly created file test.htm.

[!code-unknown[Main](powershell-snap-in-using-the-task-based-cmdlets-of-the-iis-powershell-snap-in/samples/sample-127221-14.unknown)]

The above command will make a HTTP request to the newly created web site and return the content you entered into notepad.

### Step 3: Enabling Request Tracing

**IMPORTANT: For this example to work the IIS Tracing feature needs to be enabled.** On Windows Vista open the Control Panel, click "Programs", select "Turn Windows features on or off". Find and select "Tracing" under "Internet Information Services", "World Wide Web Services", "Health and Diagnostics" and click "OK".

As a last step we are enabling Request Tracing. Web Request Tracing is an IIS feature which allows you to get a detailed log of what happened during a request was executing. This feature is extrememly valuable for a lot of troubleshooting scenarios. To enable Web Request Tracing we just need to run another location-aware cmldet called Enable-WebRequestTracing.

[!code-unknown[Main](powershell-snap-in-using-the-task-based-cmdlets-of-the-iis-powershell-snap-in/samples/sample-127221-15.unknown)]

Now let's look into the web.config file what configuration got written by the Enable-WebRequestTracing cmdlet. We do this by using the Get-WebConfigFile cmdlet which is also location-aware:

[!code-unknown[Main](powershell-snap-in-using-the-task-based-cmdlets-of-the-iis-powershell-snap-in/samples/sample-127221-16.unknown)]

The configuration looks like this:

**Contents of web.config file**


[!code-xml[Main](powershell-snap-in-using-the-task-based-cmdlets-of-the-iis-powershell-snap-in/samples/sample17.xml)]


The important configuration is the failureDefinitions rule. By default a trace file is generated when the error code is between 200 and 500 or when the request takes longer than 30 seconds. Let's issue a request that generates a response in the 200-500 error range by executing the following command:

[!code-unknown[Main](powershell-snap-in-using-the-task-based-cmdlets-of-the-iis-powershell-snap-in/samples/sample-127221-18.unknown)]

A request to a non-existing resource generates a 404 error. To look at the trace file you have to navigate to the following location:

[!code-unknown[Main](powershell-snap-in-using-the-task-based-cmdlets-of-the-iis-powershell-snap-in/samples/sample-127221-19.unknown)]

Now you can look at the trace file by opening the xml file in Internet Explorer:

[!code-unknown[Main](powershell-snap-in-using-the-task-based-cmdlets-of-the-iis-powershell-snap-in/samples/sample-127221-20.unknown)]

## Summary

The new task-based cmdlets will give Administrators an easy way to accomplish day-to-day IIS task with PowerShell. The cmdlets offer location-awareness and intuitive syntax and help.

The low-level IIS cmdlets shipped since Tech Preview 1 will still allow more advanced IIS Administration tasks.
  
  
[Discuss in IIS Forums](https://forums.iis.net/1151.aspx)