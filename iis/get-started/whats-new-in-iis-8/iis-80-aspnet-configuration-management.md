---
title: "IIS 8.0 ASP.NET Configuration Management"
author: rick-anderson
description: "Version Notes IIS 8.0 IIS management tools have been updated for ASP.net 4.5 in IIS 8.0. IIS 7.5 IIS management tools have not been updated for ASP.net 4.5 i..."
ms.date: 02/29/2012
ms.assetid: 89aa2e9e-c896-41a6-9260-ad00bf7b23a1
msc.legacyurl: /learn/get-started/whats-new-in-iis-8/iis-80-aspnet-configuration-management
msc.type: authoredcontent
---
# IIS 8.0 ASP.NET Configuration Management

by Won Yoo

### Compatibility

| Version | Notes |
| --- | --- |
| IIS 8.0 | IIS management tools have been updated for ASP.net 4.5 in IIS 8.0. |
| IIS 7.5 | IIS management tools have not been updated for ASP.net 4.5 in IIS 7.5. |
| IIS 7.0 | IIS management tools have not been updated for ASP.net 4.0 in IIS 7.0 |

<a id="TOC301270280"></a>

## Problem

Windows Server 2012 includes .NET Framework 4.5 by default, as well as optional installation of the .NET 3.5 Framework. Developers and administrators frequently need to run both ASP.net 3.5 and ASP.net 4.5 web applications and therefore they also need the ability to manage them both appropriately.

<a id="TOC301270281"></a>

## Solution

IIS 8.0 supports managing both ASP.NET 3.5 and ASP.NET 4.5 applications using both the graphical IIS Manager tool as well as IIS' command-line management tools.

Both graphical and command line IIS management tools operate in a version-specific manner when reading or writing configuration information for ASP.NET applications. For example, ASP.NET administration modules running in the IIS Server Manager will display configuration options applicable for the specific ASP.NET version used by an application.

<a id="TOC301258517"></a>

## Step by Step Instructions

#### Prerequisites:

The concepts demonstrated in this walkthrough require a Windows Server 2012 machine with all of the following installed: IIS 8.0, ASP.NET 3.5, and ASP.NET 4.5.

Prior to this walkthrough, readers should have already completed the companion walkthrough: [Using ASP.NET 3.5 and ASP.NET 4.5 on IIS 8.0](iis-80-using-aspnet-35-and-aspnet-45.md). That document walks readers through installing all three features, as well as sample applications for both versions of ASP.NET.

#### Workarounds for known bugs:

There are no known bugs for this feature at this time.

<a id="TOC301270283"></a>

### Displaying ASP.NET Administration Modules

Start the IIS Manager UI and expand the treeview on the left-hand side of the window so that the "Default Web Site" and its children are both showing:

[![Screenshot of the I I S Manager U I. The navigation tree is on the left pane. Default Web Site is selected. The icons dot net Roles, dot net Users, and Providers are highlighted.](iis-80-aspnet-configuration-management/_static/image3.png)](iis-80-aspnet-configuration-management/_static/image1.png)

The right-hand portion of the IIS Manager UI shows the administrative modules available for managing the ASP.NET application highlighted in the treeview. In this case since **Default Web Site** is selected, and by default this website supports ASP.NET 4.5, the IIS Manager displays 15 different ASP.NET-specific administration modules. The icons shown above in red outlining are the three administration modules that are only available for use with ASP.NET 4.5 applications.

You can see the high-level differences between managing ASP.NET 3.5 and ASP.NET 4.5 application in the IIS Manager below. Since the "example35" application is configured for ASP.NET 3.5, only 12 ASP.NET-specific administration modules are available:

[![Screenshot of the I I S Manager UI dialog box. In the left pane, example thirty five is selected.](iis-80-aspnet-configuration-management/_static/image7.png)](iis-80-aspnet-configuration-management/_static/image5.png)

As noted above, the IIS Manager in IIS 8.0 supports three additional administration modules when managing ASP.NET 4.5:

- **Providers**: This administration module supports centralized management of pluggable persistence providers for ASP.NET 4.5's Membership, Role Manager and Profile feature.
- **.NET Users**: Interactive UI-based creation, deletion and modification of Membership users for ASP.NET 4.5 applications.
- **.NET Roles**: UI-based creation/deletion of roles, as well as integration with the ".NET Users" module for adding and removing users to/from roles. As with the previous two administration modules, the ".NET Roles" module is used to manage ASP.NET 4.5 applications

<a id="TOC301270284"></a>

### Managing ASP.NET Compilation Settings

Many of the administration modules that exist for both ASP.NET 3.5 and ASP.NET 4.5 expose the same functionality. However as some ASP.NET features evolve over time additional configuration options are added in newer .NET Framework versions. The ASP.NET administration modules in the IIS Manager support this by dynamically changing the options they display depending on the version of the ASP.NET application being managed.

Below is a screenshot of .NET Compilation for ASP.NET 3.5:

[![Screenshot of the dot NET Compilation for A S P dot NET three dot five. The Display and Friendly Names columns are shown.](iis-80-aspnet-configuration-management/_static/image11.png)](iis-80-aspnet-configuration-management/_static/image9.png)

And below is the corresponding configuration for ASP.NET 4.5. You will see the configuration options have expanded to include new ASP.NET 4.5 capabilities:

[![Screenshot of the dot NET Compilation for A S P dot NET three dot five. Enable J I T Profiling and Enable Prefetch behaviors are highlighted.](iis-80-aspnet-configuration-management/_static/image15.png)](iis-80-aspnet-configuration-management/_static/image13.png)

The two new options available in ASP.NET 4.5 applications are:

- **Enable JIT Profiling**: By default ASP.NET 4.5 will work with the CLR's JIT compilation to enable background compilation of speculative JIT execution paths using additional CPU cores.
- **Enable Prefetch**: An ASP.NET 4.5 feature available only on Windows Server 2012 that integrates the ASP.NET 4.5 compilation system with the Windows Server 8 Superfetch service. When both the Superfetch service and ASP.NET Prefetch option are enabled, Windows Server 2012 will profile ASP.NET compilation during the startup of web applications in order to dynamically optimize disk performance when loading managed assemblies.

<a id="TOC301270285"></a>

### Managing ASP.NET Machine Key Settings

Below is a screenshot of Machine Key for ASP.NET 3.5. The "Validation method" or "Encryption method" dropdowns display the supported hashing and encryption algorithms used by various security features in ASP.NET 3.5: (Note: in the picture below the dropdowns are arranged horizontally so both sets of options can be shown.)

[![Screenshot of the Machine Key dialog box. the S H A one Validation Method is selected. The Auto Encryption method is selected.](iis-80-aspnet-configuration-management/_static/image19.png)](iis-80-aspnet-configuration-management/_static/image17.png)

And below is the corresponding configuration for ASP.NET 4.5.

[![Screenshot of the Machine Key dialog box. The H M A C S H A two five six, the H M A C S H A three eight four, and the H M A C S H A five one two are highlighted.](iis-80-aspnet-configuration-management/_static/image23.png)](iis-80-aspnet-configuration-management/_static/image21.png)

In ASP.NET 4.5 the same set of encryption algorithms are available (AES was available as far back as .NET 2.0). However, in ASP.NET 4.5, the built-in support for hashing algorithms has been expanded to include the SHA-2 family of keyed hash algorithms (HMACSHA256, HMACSHA384, and HMACSHA512).

<a id="TOC301270286"></a>

### Managing ASP.NET Pages and Controls

Below is a screenshot of Pages and Controls for ASP.NET 3.5. The administration module will display a subset of commonly used configuration options for ASP.NET 3.5 applications:

[![Screenshot of the Pages and Controls page for A S P dot NET three dot five. The Buffer behavior is highlighted.](iis-80-aspnet-configuration-management/_static/image27.png)](iis-80-aspnet-configuration-management/_static/image25.png)

And below is the corresponding configuration for ASP.NET 4.5. The options available in the "Behavior" portion have expanded to include new settings for ASP.NET 4.5:

[![Screenshot of the Pages and Controls page. The Client I D Mode and Control Rendering Compatibility Version Behaviors are highlighted.](iis-80-aspnet-configuration-management/_static/image31.png)](iis-80-aspnet-configuration-management/_static/image29.png)

As ASP.NET progresses through different versions, there are continual modifications to the HTML, Javascript and CSS emitted by various features and controls. However existing applications may expect specific formats for rendered output. ASP.NET 4.5 can be configured to support older rendering formats using the new settings exposed in the "Pages and Controls" administration module:

- **ClientID Mode**: Defaults to the new setting of "Predictable" which results in stable identifiers being emitted for the "id" attribute on rendered HTML elements. This setting can be changed to "AutoID" to mimic the ID generation behavior used in previous releases of ASP.NET.
- **Control Rendering Compatibility Version**: As the name of this setting suggests, this controls which version of rendered HTML/Javascript/CSS output is used by various ASP.NET controls. This property can be set to "3.5", in which case ASP.NET 4.5 will emit output that matches the format created by ASP.NET 3.5.

<a id="TOC301258518"></a>

## Summary

IIS 8.0 supports running both ASP.NET 3.5 and ASP.NET 4.5 applications on the same machine using different application pools to host each .NET Framework version. To support administering both types of ASP.NET applications, IIS 8.0's management tools (both UI and command-line) also support managing multiple ASP.NET versions. Furthermore the IIS 8.0 Server Manager UI dynamically displays appropriate management options depending on which version of ASP.NET application is being managed.
