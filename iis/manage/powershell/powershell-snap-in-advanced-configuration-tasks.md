---
title: "PowerShell Snap-in: Advanced Configuration Tasks"
author: thomasdeml
description: "In this walkthrough you will learn how to accomplish some advanced configuration tasks using XPath queries and wildcards. Introduction The previous walkthrou..."
ms.date: 04/14/2008
ms.assetid: 27fd5104-49f1-463f-ad33-effa4b3b4e45
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

[!code-powershell[Main](powershell-snap-in-advanced-configuration-tasks/samples/sample1.ps1)]

And another one. Here all the handler mappings that will get executed by ASPNET\_ISAPI.DLL:

[!code-powershell[Main](powershell-snap-in-advanced-configuration-tasks/samples/sample2.ps1)]

Let's suppose you don't like the .aspx extension for your ASP.Net files too much and you want to change all IIS handler mappings from \*.aspx to \*.mspx. Can it be shorter than this?

[!code-powershell[Main](powershell-snap-in-advanced-configuration-tasks/samples/sample3.ps1)]

Let's look if the changes were set:

[!code-console[Main](powershell-snap-in-advanced-configuration-tasks/samples/sample4.cmd)]

Now how about looking at the configuration file itself. We can use the get-item cmdlet that we explored in a previous walkthrough.

[!code-powershell[Main](powershell-snap-in-advanced-configuration-tasks/samples/sample5.ps1)]

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