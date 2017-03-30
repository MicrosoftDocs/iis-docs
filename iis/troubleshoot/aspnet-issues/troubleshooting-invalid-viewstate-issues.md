---
title: "Troubleshooting Invalid viewstate issues | Microsoft Docs"
author: apurvajo
description: "NA This material is provided for informational purposes only. Microsoft makes no warranties, express or implied. Overview View state is a feature in ASP.NET..."
ms.author: iiscontent
manager: soshir
ms.date: 04/09/2012
ms.topic: article
ms.assetid: 
ms.technology: iis-troubleshoot
ms.prod: iis
msc.legacyurl: /learn/troubleshoot/aspnet-issues/troubleshooting-invalid-viewstate-issues
msc.type: authoredcontent
---
Troubleshooting Invalid viewstate issues
====================
by [Apurva Joshi](https://github.com/apurvajo)

#### Tools Used in this Troubleshooter:

- NA

This material is provided for informational purposes only. Microsoft makes no warranties, express or implied.

## Overview

View state is a feature in ASP.NET that allows pages to automatically preserve state without relying on server state (for example, session state). However, issues relating to view state can be difficult to debug. In most cases, when problems with view state occur, you receive the following error message in the Web browser, with little indication of what might be causing the issue:

[!code-unknown[Main](troubleshooting-invalid-viewstate-issues/samples/sample-127564-1.unknown)]

This article describes some techniques that can be used for debugging and for resolving problems with view state.

## Scenarios and Troubleshootings

**Verify that you are not running into issues that have been fixed**

A number of view state issues were fixed with ASP.NET 1.0 hotfixes and service packs, and those fixes are also part of ASP.NET 1.1. Make sure that you have applied the latest fixes before tracking issues that have already been resolved. You can obtain the latest Microsoft .NET Framework updates from the following Microsoft Developer Network (MSDN) Web site:

[https://msdn.microsoft.com/en-us/netframework/aa569276.aspx](https://msdn.microsoft.com/en-us/netframework/aa569276.aspx)

**Set the validationKey attribute if you are running in a Web farm**

In a Web farm, each client request can go to a different machine on every postback. Because of this behavior, you cannot leave the validationKey attribute set to AutoGenerate in the Machine.config file. Instead, you must set the value of the validationKey attribute to a fixed string that is shared by all the machines on the Web farm.

For more information about this issue, click the following article number to view the article in the Microsoft Knowledge Base:

[https://support.microsoft.com/kb/323744](https://support.microsoft.com/kb/323744)

**Do not store dynamically generated types in view state in a Web farm**

When ASP.NET compiles files dynamically, the files are built into assemblies with essentially random names (for example, a file name might be jp395dun.dll). If you are running a Web farm, the same files will be compiled into assemblies with different random names. Normally, this is not a problem because no one makes assumptions on those assembly names. But if you ever put a dynamically compiled type into view state by using binary serialization, the name of the assembly will be included as part of the view state data. When that view state is later sent to a different server in the Web farm, the view state cannot be deserialized because it uses different assembly names.

The best fix to this problem is to avoid using binary serialization. Binary serialization uses many resources even when you do not run into this problem. Instead, limit what you put in view state to a combination of Arrays, Pairs, Triplets, and simple types (for example, strings, int, and other types). System.Web.UI.Pair and System.Web.UI.Triplet are simple wrapper types that the view state engine can efficiently process.

An alternative fix to avoid this problem is to move the types that you are storing in view state into a precompiled assembly, either in your Bin folder or in the Global Assembly Cache. This fix does not address performance, but it guarantees that the assembly has the same name on all computers.

Note If you store complex data types in view state and experience this issue, the call stack information will contain stacks that are similar to the following:

[!code-unknown[Main](troubleshooting-invalid-viewstate-issues/samples/sample-127564-2.unknown)]

**Determine whether the problem is related to the view state MAC feature**

The purpose of the view state machine authentication code (MAC) feature is to make it impossible for clients to send a request that contains a malicious view state. By default, this feature is enabled in the following flag in the Machine.config file.

[!code-unknown[Main](troubleshooting-invalid-viewstate-issues/samples/sample-127564-3.unknown)]

The simplest way to determine whether the issue you are dealing with is related to the MAC feature is to turn off the feature. To do this, change the flag in the Machine.config file to the following code.

[!code-unknown[Main](troubleshooting-invalid-viewstate-issues/samples/sample-127564-4.unknown)]

If you no longer get view state errors, the problem is related to the MAC feature.

> [!IMPORTANT]
> Only turn off the view state MAC feature to help diagnose the problem. You should not keep the view state MAC turned off to work around the issue. If so, you could introduce security holes

In general, Microsoft recommends that you not turn off the view state MAC feature unless you are completely confident that you have either disabled view state for all controls that do not HTML encode their output (for example, DataGrid controls, DataList controls, Label controls, and other controls) or that you are always explicitly setting their values on each request to something known to be safe.

**Determine exactly what exception occurs when you receive the error message**

Unfortunately, the invalid view state error message that is mentioned in the "Overview" section of this article is not very informative. The error message is generally caused by some exception being thrown when the view state is being processed. The problem is that the exception is being consumed, and its details are lost in the error message.

By using a debugger, you can determine the original exception. To do this, you must attach a debugger to the ASP.NET process (Aspnet\_wp.exe or W3wp.exe), and then set it to catch all exceptions. You can even configure Debug Diagnostics 1.2 tool to capture managed exceptions.

**Try storing the view state in the session**

By default, the view state is round-tripped by means of an &lt;INPUT type=hidden&gt; field that is sent to the browser. The browser then sends the field back to the server on the next request. In some cases, this view state can get quite large and be a potential source of problems. Some browsers cannot handle such a large hidden field (and the resulting large request), and the browsers may truncate the view state. Truncating the view state causes a "view state corrupted" error message. This behavior is most likely to occur in simpler browsers. For example, this behavior may occur in a browser on a PDA.

To determine whether you may be running into such an issue, try storing the view state in the session. The following example demonstrates how to do this.

[!code-aspx[Main](troubleshooting-invalid-viewstate-issues/samples/sample5.aspx)]

The following line of code is only needed in ASP.NET 1.0, to work around a bug. In ASP.NET 1.1 plus, it is not necessary.

[!code-html[Main](troubleshooting-invalid-viewstate-issues/samples/sample6.html)]

**Determine whether the problem is caused by worker process recycling**

Consider the following scenario.

- You are running ASP.NET under Microsoft Internet Information Services (IIS) 6.0.
- The application pool is running under an identity other than the Local System account, the Network Service account, or an administrative-level account.
- The validationKey attribute of the &lt;MACHINEKEY&gt; element is set to AutoGenerate in the configuration file.

In this scenario, the following procedure will cause a view state error to occur:

1. A user browses a page.
2. The worker process that hosts the ASP.NET application recycles.
3. The user posts back the page.

The workaround for this scenario is to use an explicit validationKey attribute in the configuration file.

### Other Resources

- [Troubleshooting the "View state is invalid" error with ASP.NET](https://support.microsoft.com/kb/829743)
- [Building Secure ASP.NET Applications: Authentication, Authorization, and Secure Communication](https://msdn.microsoft.com/en-us/library/aa302388.aspx)
- [How to create keys by using Visual C# .NET for use in Forms authentication](https://support.microsoft.com/kb/312906)
  
  
[Discuss in IIS Forums](https://forums.asp.net/22.aspx/1?State+Management)