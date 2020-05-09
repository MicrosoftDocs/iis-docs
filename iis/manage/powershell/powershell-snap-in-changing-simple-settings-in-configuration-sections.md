---
title: "PowerShell Snap-in: Changing Simple Settings in Configuration Sections"
author: thomasdeml
description: "In the previous walkthrough you learned how to manage IIS namespace containers like Sites, Application Pools, Applications and Virtual Directories. In this w..."
ms.date: 04/14/2008
ms.assetid: 02a930f1-b082-40c7-892f-0e0749e94de9
msc.legacyurl: /learn/manage/powershell/powershell-snap-in-changing-simple-settings-in-configuration-sections
msc.type: authoredcontent
---
PowerShell Snap-in: Changing Simple Settings in Configuration Sections
====================
by [Thomas Deml](https://github.com/thomasdeml)

In the previous walkthrough you learned how to manage IIS namespace containers like Sites, Application Pools, Applications and Virtual Directories.

In this walkthrough we will manage configuration settings that are not exposed via the IIS namespace.

## Introduction

There are several cmdlets that allow you to change IIS settings not configurable via the IIS namespace, i.e. you can't use built-in cmdlets to modify them. You have to use IIS provided cmdlets instead. This walkthrough relies on the site, applications and virtual directories we created in previous walkthroughs.

## Get-WebConfiguration and Get-WebConfigurationProperty

Get-WebConfiguration and Get-WebConfigurationProperty allow you to get IIS configuration sections. They are very similar to Get-Item and Get-ItemProperty. Where Get-Item\* only works against namespace containers (Sites, Apps, AppPools, VDirs) Get-WebConfiguration\* will work against any IIS configuration section.

### Querying Configuration Settings

Let's have a look what settings for the directoryBrowse section are enabled on the DemoApp application we created previously. First we navigate to the DemoApp folder and then we query the authentication settings in this folder. Here is how you do it:

[!code-powershell[Main](powershell-snap-in-changing-simple-settings-in-configuration-sections/samples/sample1.ps1)]

 In the next example we are using the -filter parameter to specify the configuration section we are interested in and the -name parameter to specify which property we want to look at. If you want to see the settings of a section that is not the current location you can use the -PSPath property on top of that. Here is an example how you would query for the directory browsing settings on the Default Web Site: 

[!code-powershell[Main](powershell-snap-in-changing-simple-settings-in-configuration-sections/samples/sample2.ps1)]

### Using Set-WebConfigurationProperty

Changing the setting is as simple as:

### Dealing with Locked Sections

Here is a problem. Authentication sections are usually locked, i.e. they can't be written to a web.config file but have to be written to the central applicationhost.config file instead. Using the above command to enable WindowsAuthentication would fail with a locking violation:

[!code-powershell[Main](powershell-snap-in-changing-simple-settings-in-configuration-sections/samples/sample3.ps1)]

What you have to do here is to use the -PSPath and -location parameter. The following command will enable Windows Authentication for application DemoApp. The configuration is written to applicationhost.config however using a location tag. Click [here](../managing-your-configuration-settings/understanding-iis-configuration-delegation.md "Configuration Delegation and Locking") to find more information on locking and location tags.

[!code-powershell[Main](powershell-snap-in-changing-simple-settings-in-configuration-sections/samples/sample4.ps1)]

You don't have to specify locations when querying the configuration however. The regular Get-WebConfigurationProperty command will show you that the setting is enabled.

[!code-powershell[Main](powershell-snap-in-changing-simple-settings-in-configuration-sections/samples/sample5.ps1)]

### Get-WebConfiguration vs. Get-WebConfigurationProperty

The same applies as Get-Item vs. Get-ItemProperty in the previous example. Get-WebConfiguration gets the whole section instead of only a property. This allows you to store the section to a variable, make modifications to the section properties and save the section back via Set-WebConfiguration. And you get the benefit of command completion.

Here is an example. Don't just copy and paste. Explore the properties of the windowsAuthentication section. Type $winAuth. and hit the &lt;TAB&gt; key to iterate through the available properties and functions.

[!code-powershell[Main](powershell-snap-in-changing-simple-settings-in-configuration-sections/samples/sample6.ps1)]

### Add-WebConfiguration

Add-WebConfiguration is a cmdlet that you want to use if you have to add something to an IIS configuration collection. Handlers, modules, default document settings and some other examples where IIS uses a collection to store multiple values.

Here is an example on how to add a new default document to the DemoApp default document collection:

[!code-powershell[Main](powershell-snap-in-changing-simple-settings-in-configuration-sections/samples/sample7.ps1)]

The example uses the additional parameter -at. This allows you to specify where in the collection you want to add the new value. 0 is at the beginning; -1 specifies the end.

## Summary

In this walkthrough you learned how to use the IIS provided web configuration cmdlets. You learned how to query for configuration settings, how to configure settings using location tags, how to take advantage of command-line completion and how to add entries to collections.

In the next walkthrough you will learn how to accomplish some complex configuration tasks using advanced IIS Provider features like globbing and XPath.
