---
title: "PowerShell Snap-in: Navigating the IIS Snap-in Namespace"
author: thomasdeml
description: "Everybody is familiar on how the file system is organized. File systems are hierarchical namespaces, comprised of directories that contain files and other di..."
ms.date: 04/14/2008
ms.assetid: 92e66c6b-c614-4db7-a46e-800da9f4047c
msc.legacyurl: /learn/manage/powershell/powershell-snap-in-navigating-the-iis-snap-in-namespace
msc.type: authoredcontent
---
PowerShell Snap-in: Navigating the IIS Snap-in Namespace
====================
by [Thomas Deml](https://github.com/thomasdeml)

Everybody is familiar on how the file system is organized. File systems are hierarchical namespaces, comprised of directories that contain files and other directories. PowerShell Snap-in leverage this familarity with the file system and allow other data stores to be exposed as an hierarchical namespace. Like the root of a file system drive is usually `C:\` the root of the IIS configuration system is "IIS:\".

Underneath the root "IIS:\" drive you will find "Sites" and Application Pools - "AppPools" in short.

## Organization of the IIS Snap-in Namespace

Here is the structure of the IIS PowerShell Snap-in namespace. The following containers cannot be deleted or moved.

- IIS:\

    - Sites

        - Site Collection

            - Applications and Virtual Directories
    - AppPools

        - WorkerProcesses
    - SslBindings

Note: if Worker Processes are started you will find PowerShell Process objects in the Worker Process collection. This Process collection is augmented with Request and AppDomain objects. This allows you to query IIS Worker Processes for currently executing requests and running Application Domains.

Now let's try it out.

## Task 1 - Getting Familiar with the IIS Provider Namespace

#### 1.1. Start the IIS PowerShell Management Console

Click on the Start Menu - select "All Programs" - "IIS 7.0 Extensions" - "IIS PowerShell Management Console". The prompt of the new PowerShell command window is set to "IIS:\" - the root of the IIS Provider namespace.

#### 1.2. Navigate the Namespace

Type "dir" and notice that Sites and AppPools are the only two directories underneath the root.

[!code-powershell[Main](powershell-snap-in-navigating-the-iis-snap-in-namespace/samples/sample1.ps1)]

[!code-console[Main](powershell-snap-in-navigating-the-iis-snap-in-namespace/samples/sample2.cmd)]

As the next step we want to change into the Sites directory. You can do that with the following commands:

[!code-powershell[Main](powershell-snap-in-navigating-the-iis-snap-in-namespace/samples/sample3.ps1)]

If you are adventurous you will notice that typing cd Si&lt;tab&gt; will give you command-line completion.

Now try this:

#### 1.2 Some more Navigation

Now try the following:

[!code-powershell[Main](powershell-snap-in-navigating-the-iis-snap-in-namespace/samples/sample4.ps1)]

The first time we are trying a PowerShell cmdlet instead of using good old DOS commands like CD or DIR. If you want to effectively work with the IIS PowerShell Snap-in it is a good idea to get familiar with these commands.

Get-Item for example, is a command that allows you to get details about the item at the specified location. In our case we get details for the 'Default Web Site' (if you want to save some typing try 'get-item D&lt;tab&gt;' and the command-line will be automatically completed by PowerShell). We pipe the output of Get-Item to the Select-Object cmdlet and it displays all configuration settings of the 'Default Web Site'.

## Summary

This walkthrough gave you a quick introduction in how the IIS Snap-in namespace is organized. You also learned some basic command to find your way around in the IIS namespace.
