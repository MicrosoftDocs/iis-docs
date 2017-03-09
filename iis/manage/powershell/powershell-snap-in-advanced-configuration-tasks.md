---
title: "PowerShell Snap-in: Advanced Configuration Tasks | Microsoft Docs"
author: thomasdeml
description: "In this walkthrough you will learn how to accomplish some advanced configuration tasks using XPath queries and wildcards. Introduction The previous walkthrou..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 04/14/2008
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/manage/powershell/powershell-snap-in-advanced-configuration-tasks
msc.type: authoredcontent
---
PowerShell Snap-in: Advanced Configuration Tasks
====================
by [Thomas Deml](https://github.com/thomasdeml)

In this walkthrough you will learn how to accomplish some advanced configuration tasks using XPath queries and wildcards.

## Introduction

The previous walkthrough introduced you to the \*-WebConfiguration and \*-WebConfigurationProperty cmdlets. There is more to these cmdlets than meets the eye. The -filter parameter is not just a way to specify a configuration section. It is an XPath query and in this walkthrough we'll explore how to take advantage of it. There are also some nice ways you can use wilcards with the \*-WebConfiguration\* commands.

This walkthrough uses the sites, applications and virtual directories created in previous examples.

## Using XPath Queries

Here is a simple example that shows you how to use wilcards with the Get-WebConfigurationProperty cmdlet:


[!code-unknown[Main](powershell-snap-in-advanced-configuration-tasks/samples/sample-127218-1.unknown)]


And another one. Here all the handler mappings that will get executed by ASPNET\_ISAPI.DLL:


[!code-unknown[Main](powershell-snap-in-advanced-configuration-tasks/samples/sample-127218-2.unknown)]


Let's suppose you don't like the .aspx extension for your ASP.Net files too much and you want to change all IIS handler mappings from \*.aspx to \*.mspx. Can it be shorter than this?


[!code-unknown[Main](powershell-snap-in-advanced-configuration-tasks/samples/sample-127218-3.unknown)]


Let's look if the changes were set:


[!code-unknown[Main](powershell-snap-in-advanced-configuration-tasks/samples/sample-127218-4.unknown)]


Now how about looking at the configuration file itself. We can use the get-item cmdlet that we explored in a previous walkthrough.


[!code-xml[Main](powershell-snap-in-advanced-configuration-tasks/samples/sample5.xml)]


You can see that the configuration system removed the old handlers and replaced them with new handlers that are now mapped to \*.mspx.

## Discovering IIS Configuration

It's great if you know what you want to configure. But what if you don't. Here are a few helpers.

Showing available IIS configuration sections


[!code-powershell[Main](powershell-snap-in-advanced-configuration-tasks/samples/sample6.ps1)]


Showing the properties you can configure on a particular section:


[!code-powershell[Main](powershell-snap-in-advanced-configuration-tasks/samples/sample7.ps1)]


Putting the two together, i.e. showing all sections with their properties.


[!code-powershell[Main](powershell-snap-in-advanced-configuration-tasks/samples/sample8.ps1)]


We will probably pack these commands into some functions at a later Tech Preview but this is what you get for now :).

## Summary

In this walkthrough you learned how to accomplish complex IIS configuration tasks by using wildcards and XPath queries. The next walkthrough will discuss how to discover state and run-time data.
  
  
[Discuss in IIS Forums](https://forums.iis.net/1151.aspx)