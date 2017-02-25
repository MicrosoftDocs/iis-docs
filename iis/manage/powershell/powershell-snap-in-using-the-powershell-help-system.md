---
title: "PowerShell Snap-in: Using the PowerShell Help System | Microsoft Docs"
author: rick-anderson
description: "In this walkthrough you will learn how you can get help on how to use the IIS PowerShell Snap-in. Introduction The IIS PowerShell Snap-in uses two types of c..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 04/14/2008
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/manage/powershell/powershell-snap-in-using-the-powershell-help-system
msc.type: authoredcontent
---
PowerShell Snap-in: Using the PowerShell Help System
====================
by Thomas Deml

In this walkthrough you will learn how you can get help on how to use the IIS PowerShell Snap-in.

## Introduction

The IIS PowerShell Snap-in uses two types of cmdlets.

1. Built-in cmdlets like New-Item, Get-ChildItems or Set-ItemProperty, are implemented in every namespace (the file system for example) and also work with the IIS PowerShell Snap-in. These built-in cmdlets apply to containers that are exposed in the IIS hierarchy: Sites, Application Pools, Web Applications and Virtual Directories.
2. IIS PowerShell Snap-in specific cmdlets like Get-WebConfiguration, Set-WebConfigurationProperty or Get-WebItemState are only applicable to IIS. These cmdlets have to be used to manage feature configuration or run-time state. Examples for feature configuration are defaultDocument configuration, compression settings, modules and handlers configuration etc. Run-time state examples are the state of Application Pools and Sites.

## Help for Built-in Cmdlets

Getting help for these two types of cmdlets is different. To get help on how the built-in cmdlets can be used in the IIS:\ namespace you have to use the following command:


[!code-powershell[Main](powershell-snap-in-using-the-powershell-help-system/samples/sample1.ps1)]


The output of this command will give you a detailed overview on how built-in cmdlets can be used in the IIS namespace. It shows you the syntax and what additional parameters need to be specified. And finally it will display a large set of examples that will help you to get familiar with these cmdlets.

## Help for IIS-specific Cmdlets

If you want to get help for IIS-specific cmdlets you have to use the following command:


[!code-powershell[Main](powershell-snap-in-using-the-powershell-help-system/samples/sample2.ps1)]


Examples:


[!code-powershell[Main](powershell-snap-in-using-the-powershell-help-system/samples/sample3.ps1)]

You can execute the following command to retrieve a list of the cmdlets IIS provides:

[!code-unknown[Main](powershell-snap-in-using-the-powershell-help-system/samples/sample-127214-4.unknown)]


## Summary

In this walkthrough you learned how to use the PowerShell help system to get more information on how to use built-in cmdlets in the IIS namespace, but also on how to use IIS-specific cmdlets.
  
  
[Discuss in IIS Forums](https://forums.iis.net/1151.aspx)