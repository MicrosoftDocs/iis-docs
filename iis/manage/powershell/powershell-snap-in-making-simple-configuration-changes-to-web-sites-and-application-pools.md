---
title: "PowerShell Snap-in: Making Simple Configuration Changes to Web-Sites and Application Pools | Microsoft Docs"
author: thomasdeml
description: "In this walkthrough you will learn how to change simple properties of IIS namespace containers like Web-Sites, Web Applications, Virtual Directories and Appl..."
ms.author: iiscontent
manager: soshir
ms.date: 04/14/2008
ms.topic: article
ms.assetid: 369c1f7c-5a4e-42f0-b569-0f8677a86cd6
ms.technology: iis-manage
ms.prod: iis
msc.legacyurl: /learn/manage/powershell/powershell-snap-in-making-simple-configuration-changes-to-web-sites-and-application-pools
msc.type: authoredcontent
---
PowerShell Snap-in: Making Simple Configuration Changes to Web-Sites and Application Pools
====================
by [Thomas Deml](https://github.com/thomasdeml)

In this walkthrough you will learn how to change simple properties of IIS namespace containers like Web-Sites, Web Applications, Virtual Directories and Application Pools by using built-in PowerShell cmdlets. The next walkthrough will cover how to change configuration properties on system.webServer sections and custom sections.

## Introduction

The task of the PowerShell Snap-ins is to offer namespaces that can be managed with a common, built-in PowerShell cmdlets like New-Item, Get-Item, Get-ChildItems, Set-Item, Set-ItemProperty etc.. The built-in cmdlets work against all PowerShell-provided namespaces. New-Item c:\testdir for example allows you to create a new file system directory, but you can also to create a new IIS object like a Web-Site or an Application Pool, for example New-Item IIS:\AppPools\NewAppPool.

In the previous walkthrough we started using the New-item and Get-Item cmdlets. This walkthrough will explore more of the built-in cmdlets.

Often times you might have to change settings on these items after you created them. To do this we are using the built-in cmdlets New-ItemProperty and Set-ItemProperty. We will also have a look how to use Get-Item and Set-Item.

This walkthrough relies on the Web-Site 'Demosite' and its Web Applications and Virtual Directories that we created in the last walkthrough.

## Looking at Configuration Settings

Before we start changing settings we want to look at them first. Here is a command to look at the configuration settings of 'DemoSite'.


[!code-powershell[Main](powershell-snap-in-making-simple-configuration-changes-to-web-sites-and-application-pools/samples/sample1.ps1)]


This gives you a view of the most important properties of the site. There are more settings you might be interested though.

Here is a command that gives you more details:


[!code-powershell[Main](powershell-snap-in-making-simple-configuration-changes-to-web-sites-and-application-pools/samples/sample2.ps1)]


In the example above we are using parenthesis because the Get-ItemProperty call has to be evaluated first before we can print the collection entries. In this case kind of the same thing as in math: (5 + 4) \* 3 will evaluate the 5 + 4 first, then multiply by 3. In this case, the results of Get-ItemProperty command will be evaluated and the resulting IIS configuration object contains a collection that we output to the screen.

You can use the same strategy with other properties or collections like the AppPools processModel section. The following command for example returns a nice DateTime object for the startupTimeLimit of our DemoAppPool:


[!code-powershell[Main](powershell-snap-in-making-simple-configuration-changes-to-web-sites-and-application-pools/samples/sample3.ps1)]


## Changing Site and AppPool Settings

There are two basic ways to make changes.

1. If you are changing a simple property you use Set-ItemProperty.
2. If you are dealing with a collection and you want to add a new collection entry you use New-ItemProperty. In an IIS default install the bindings collection is the only collection used in the IIS namespace.

### Set-ItemProperty and New-ItemProperty

Let's begin by adding an additional binding to our DemoSite:


[!code-powershell[Main](powershell-snap-in-making-simple-configuration-changes-to-web-sites-and-application-pools/samples/sample4.ps1)]


As you can see DemoSite is now also listening on port 8081.

Use the Set-ItemProperty if you want to modify an existing property. Changing the name of the site for example:


[!code-powershell[Main](powershell-snap-in-making-simple-configuration-changes-to-web-sites-and-application-pools/samples/sample5.ps1)]


Let's change it back to the old name:


[!code-powershell[Main](powershell-snap-in-making-simple-configuration-changes-to-web-sites-and-application-pools/samples/sample6.ps1)]


We also want to change the identity our Application Pool runs as. First we have to create a user however. Let's use ADSI to do that


[!code-powershell[Main](powershell-snap-in-making-simple-configuration-changes-to-web-sites-and-application-pools/samples/sample7.ps1)]


Now we are ready to configure the DemoAppPool to run as this user:


[!code-powershell[Main](powershell-snap-in-making-simple-configuration-changes-to-web-sites-and-application-pools/samples/sample8.ps1)]


To be extensible we are using a good old hash table for property names and their values. If you forgot how to use it, here is a [link](https://www.microsoft.com/technet/scriptcenter/resources/pstips/sept07/pstip0914.mspx "Working with hash tables").

### Set-Item and Get-Item

Let's do the same, i.e. assigning a user to an Application Pool, with the set-item/get-item combo. You might like this variant a little better because it allows you to take advantage of command-line completion. To see how this works don't copy and paste the following commands. Enter a couple of characters and use the TAB key to enjoy the advantages of command-line completion:


[!code-powershell[Main](powershell-snap-in-making-simple-configuration-changes-to-web-sites-and-application-pools/samples/sample9.ps1)]


## Summary

In this walkthrough you learned how to use PowerShell-provided cmdlets to manage IIS namespace containers like Sites and Application Pools. You learned how to use hash tables and how to take advantage of command-line completion. In the next walkthrough you will learn how to use IIS Snap-in cmdlets to make configuration changes to IIS configuration settings that are not exposed via the IIS Snap-in namespace.