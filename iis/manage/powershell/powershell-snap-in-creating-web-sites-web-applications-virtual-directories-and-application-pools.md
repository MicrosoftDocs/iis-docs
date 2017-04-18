---
title: "PowerShell Snap-in: Creating Web-Sites, Web applications, Virtual Directories and Application Pools | Microsoft Docs"
author: thomasdeml
description: "In this walkthrough you will learn how to create Web-Sites, Web Applications, Virtual Directories and Application Pools. Introduction The IIS PowerShell name..."
ms.author: iiscontent
manager: soshir
ms.date: 04/03/2008
ms.topic: article
ms.assetid: 94fc82c2-2697-4bbc-99f0-435a12063638
ms.technology: iis-manage
ms.prod: iis
msc.legacyurl: /learn/manage/powershell/powershell-snap-in-creating-web-sites-web-applications-virtual-directories-and-application-pools
msc.type: authoredcontent
---
PowerShell Snap-in: Creating Web-Sites, Web applications, Virtual Directories and Application Pools
====================
by [Thomas Deml](https://github.com/thomasdeml)

In this walkthrough you will learn how to create Web-Sites, Web Applications, Virtual Directories and Application Pools.

## Introduction

The IIS PowerShell namespace consists of items like Web-Sites, Apps, Virtual Directories and Application Pools. Creating new namespace items and managing them is very easy using the built-in PowerShell cmdlets.

## Creating Web-Sites

If you are familiar with PowerShell you know that the New-Item cmdlet is used to create new items in the various PowerShell namespaces. The command "New-Item c:\TestDirectory" creates a new filesystem directory for example (most people use the "MD" or "MKDIR" alias for New-Item however). New-Item is also used to create new Web-Sites within the IIS PowerShell namespace.

### Parameters

Specifying the name of the directory is the only argument needed when you create a new file system directory. Unfortunately this is not enough when you create a Web-Site. Additional parameters like the file system path and network bindings are needed to create a Web-Site. Here is the command to create a new Web-Site followed by a dir command:

[!code-powershell[Main](powershell-snap-in-creating-web-sites-web-applications-virtual-directories-and-application-pools/samples/sample1.ps1)]

[!code-powershell[Main](powershell-snap-in-creating-web-sites-web-applications-virtual-directories-and-application-pools/samples/sample2.ps1)]

[!code-console[Main](powershell-snap-in-creating-web-sites-web-applications-virtual-directories-and-application-pools/samples/sample3.cmd)]

Using the -physicalPath argument is pretty straightforward. But you might ask yourself why the -bindings argument looks so complex.

The construct used is a hashtable (go [here](https://www.microsoft.com/technet/scriptcenter/resources/pstips/sept07/pstip0914.mspx "PowerShell Hash Tables") to learn more about PowerShell hash tables). Within the hash table key=value pairs indicate the settings that reflect the attributes within the IIS site bindings section:


[!code-xml[Main](powershell-snap-in-creating-web-sites-web-applications-virtual-directories-and-application-pools/samples/sample4.xml)]


Now here is the reason why we use a hash table: IIS configuration is completely extensible (see [here](../../develop/extending-iis-configuration/configuration-extensibility.md "Configuration Extensibility") for more details) with additional sections and attributes. You can imagine that somebody extending the &lt;binding&gt; element with additional attributes. Key value pairs within a hash table provide the flexibility to incorporate these new attributes without having to completely rewrite the IIS PowerShell Snap-in.

Granted, the syntax is a bit complex. We are thinking about wrapping some typical tasks like creating sites with additional functions or scripts in a later Tech Preview.

### Deleting Sites

Here is how you delete the site you just created.


[!code-powershell[Main](powershell-snap-in-creating-web-sites-web-applications-virtual-directories-and-application-pools/samples/sample5.ps1)]


## Creating Web Applications

Creating Web Applications is easier than creating sites. Here we go:


[!code-powershell[Main](powershell-snap-in-creating-web-sites-web-applications-virtual-directories-and-application-pools/samples/sample6.ps1)]


[!code-console[Main](powershell-snap-in-creating-web-sites-web-applications-virtual-directories-and-application-pools/samples/sample7.cmd)]


The only parameter you have to specify is the type (-type) because underneath a Web-Site you might want to create an Applications or a Virtual Directories. By specifying the -type parameter you tell the IIS Snap-in to create an application.

To delete the application you can also use Remove-Item.

## Creating Virtual Directories

To create a Virtual Directory you also use the New-Item cmdlet. Let's create a Virtual Directory underneath the 'Default Web Site' but and a second one underneath the Web Application we created in the previous step.


[!code-powershell[Main](powershell-snap-in-creating-web-sites-web-applications-virtual-directories-and-application-pools/samples/sample8.ps1)]


## Creating Application Pools

But it gets even simpler. Creating a new AppPool only requires the name to be specified.


[!code-powershell[Main](powershell-snap-in-creating-web-sites-web-applications-virtual-directories-and-application-pools/samples/sample9.ps1)]


Simple, wasn't it? Now let's put this together to an end-to-end scenario.

## Putting it all Together

In the following end-to-end scenario we will execute the following step:

1. Create a set of new file system directories for the sites, web applications and virtual directories we will create a little later.
2. Copy some very simple web content into the newly created directories.
3. Create new Application Pool
4. Create a new site, a new application and two new virtual directories and assign them to newly created Application Pool.
5. Request the web content via the web browser.

### Step 1: Create New Directories

We use the New-Item cmdlet to create four new file system directories. Execute the following commands (use 'md' instead of New-Item if you don't want to specify the -type parameter):


[!code-powershell[Main](powershell-snap-in-creating-web-sites-web-applications-virtual-directories-and-application-pools/samples/sample10.ps1)]


### Step 2: Copy Content

Now let's write some simple html content to these directories:


[!code-powershell[Main](powershell-snap-in-creating-web-sites-web-applications-virtual-directories-and-application-pools/samples/sample11.ps1)]


### Step 3: Create New Application Pool

Create the new Application Pool 'DemoAppPool' for the new site if you deleted the one we created in the previous sample.


[!code-powershell[Main](powershell-snap-in-creating-web-sites-web-applications-virtual-directories-and-application-pools/samples/sample12.ps1)]


> [!NOTE]
> The above cmdlet will fail if the WebAdministration module has not been imported. To do so, you can add the following cmdlet as the first step of a script containing the above cmdlet:


[!code-powershell[Main](powershell-snap-in-creating-web-sites-web-applications-virtual-directories-and-application-pools/samples/sample13.ps1)]


### Step 4: Create New Sites, Web Applications and Virtual Directories and Assign to Application Pool

Here comes the beef. We create DemoSite, DemoApp and two Virtual Directories - DemoVirtualDir1 is directly underneath DemoSite and DemoVirtualDir2 is underneath DemoApp. We are assigning DemoSite and DemoApp to DemoAppPool created in the previous step. DemoSite is assigned to port 8080 to not conflict with the 'Default Web Site'


[!code-powershell[Main](powershell-snap-in-creating-web-sites-web-applications-virtual-directories-and-application-pools/samples/sample14.ps1)]


Voila. All that's left is to request the web content.

### Step 5: Request the Web Content

You can of course open the browser and enter [http://localhost:8080/](http://localhost:8080/) and all the other URLs. But it's a PowerShell walkthrough and we'll use PowerShell to do it by using the .NET WebClient classes:


[!code-powershell[Main](powershell-snap-in-creating-web-sites-web-applications-virtual-directories-and-application-pools/samples/sample15.ps1)]

 If you feeling adventurous you can also use Internet Explorer object itself:

[!code-powershell[Main](powershell-snap-in-creating-web-sites-web-applications-virtual-directories-and-application-pools/samples/sample16.ps1)]


## Summary

In this walkthrough you learned how to create Web-Sites, Web Applications, Virtual Directories and Application Pools with PowerShell. Additional PowerShell features were used to build a functional end-to-end scenario.
  
  
[Discuss in IIS Forums](https://forums.iis.net/1151.aspx)