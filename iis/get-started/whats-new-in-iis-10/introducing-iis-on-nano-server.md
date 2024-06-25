---
title: Introducing IIS on Nano Server
author: davidso
description: Introduces IIS on Nano Server and outlines compatibility, outlines the purpose of Nano servers and the process of installing and connecting servers.
ms.date: 09/16/2016
ms.assetid: 85331f22-aa25-4837-a6b7-cecdc5400012
msc.legacyurl: /learn/get-started/whats-new-in-iis-10/introducing-iis-on-nano-server
msc.type: authoredcontent
---
# Introducing IIS on Nano Server

by [David So](https://github.com/davidso)

## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The features described in this article were introduced in IIS 10.0 |
| IIS 8.5 and earlier | The features described in this article were not supported prior to IIS 10.0 |

## Nano Server

Nano Server is an exciting new installation option in Windows Server 2016.

Here's a quote from the [Get Started with Nano Server Guide](https://technet.microsoft.com/library/mt126167.aspx) that summarizes Nano Server pretty well :

*&quot;Nano Server is a remotely administered server operating system optimized for private clouds and datacenters. It is similar to Windows Server in Server Core mode, but significantly smaller, has no local logon capability, and only supports 64-bit applications, tools, and agents. It takes up far less disk space, sets up significantly faster, and requires far fewer updates and restarts than Windows Server. When it does restart, it restarts much faster.&quot;*

So Nano is much smaller on disk. Faster. Less reboots. Uses less memory. What's not to like? :)

## IIS on Nano Server

With the release of Windows Server 2016, we are pleased to announce that IIS is now available as a role in Nano Server, for everyone to try out. With smaller memory and dramatically smaller disk footprint, web workloads are particularly suited to running on Nano Server, especially for high density hosting.

### Getting started

- Start with the '[Getting Started with Nano Server](https://technet.microsoft.com/library/mt126167.aspx)' steps
- The IIS Nano documentation can be found at [https://technet.microsoft.com/library/mt627783.aspx](https://technet.microsoft.com/library/mt627783.aspx)

  - You can also get to it via the tree menu on the left hand side of the 'Getting started with Nano Server'
- The specifics of how to install IIS on Nano can be found in the link above.

But essentially, the most common way of creating a Nano Server vhd(x) is via the New-NanoServerImage cmdlet.

To enable IIS, we just pass in `Microsoft-NanoServer-IIS-Package` as an argument to the Packages parameter. e.g.

[!code-powershell[Main](introducing-iis-on-nano-server/samples/sample1.ps1?highlight=1)]

### Key Differences between IIS on Nano and Regular Server

#### Installation

We have made a lot of changes in IIS for Nano to support both online and offline install. By 'online' we mean when the machine is 'running' (we don't mean online in the network connectivity sense) and by 'offline' we mean when the machine is not running.

Historically and on regular Server, IIS can only be installed online (machine running). When preparing a machine with IIS you would typically follow a sequence such as:

1. Install OS
2. Wait for install to complete
3. Enable IIS Role
4. Wait for IIS role to complete
5. Configure settings - e.g. authentication settings, modules, Asp.Net

With Nano Server, setup can be provisioned offline, therefore dramatically simplifying and speeding up steps 1 through 4 above.

When using New-NanoServerImage to create a vhd(x) with Microsoft-NanoServer-IIS-Package we configure a default working install of IIS

- IIS Services installed (e.g. WAS, W3SVC)
- A default set of IIS sub-features enabled, such as Default Document, Static content, HTTP logging etc. 

  - Refer to [chart](https://technet.microsoft.com/library/mt627783.aspx) for which sub-features are enabled by default.
- Firewall rule enabled for default 80/443 ports

It becomes extremely fast to provision new web server machines when using the generated vhd(x) image that has IIS already baked-in. On my office desktop machine, I was able to create new VMs, do offline specialization, boot up and be serving web requests all in about 25 seconds. Trying to do the same with Server Core would've taken many times that.

#### Configuration

Configuring IIS sub-features such as authentication and logging is currently still an online only step (same as regular Server).

On regular server, IIS sub-features can be enabled/disabled through DISM commands, such as `dism /online /enable-feature /all /featurename:IIS-WindowsAuthentication`.

In the Windows Server 2016 Technical Preview, configuring IIS sub-features through DISM was not available and required more work, (hence the Technical Preview....) This is definitely an area where we're looking at improving.

For now, PowerShell commands can be used to enable/disable the appropriate modules, or you can edit applicationHost.config. See [IIS Nano docs](https://technet.microsoft.com/library/mt627783.aspx) for more information.

The chart there also shows the available IIS sub-features in Nano as of the latest Technical Preview. The ones \* just show what's enabled by default (without the \* are still available, but just need to be enabled).

### Supported Frameworks

#### ASP.NET Core

The most notable difference between Nano and regular Server is that Nano targets Asp.Net Core (formerly known as Asp.Net 5). Classic Asp will not run on Nano and neither will full .Net Framework applications such as Asp.Net &lt;=4.

Here's my [blog posting on how to get an Asp.Net Core application running with IIS on Nano](https://blogs.iis.net/davidso/nano/aspnet).

#### Java

Java applications can be hosted on IIS via [HttpPlatformHandler](https://www.iis.net/downloads/microsoft/httpplatformhandler).

My co-worker Jeong Hwan has a blog post here on [how to get Java working with IIS on Nano](https://blogs.iis.net/jeonghwan/running-tomcat-with-iis-on-nano-server)


#### Others

Supporting ASP.NET Core and Java on IIS Nano is a great start though we do have plans to get additional platforms supported. The [HttpPlatformHandler](https://www.iis.net/downloads/microsoft/httpplatformhandler) is a general purpose module for managing and sending requests to http listeners, so there could well be more platforms that can run well on Nano that we haven't tested and so haven't listed.

If you do try this (e.g. with Ruby or Node) and get it working let us know!

### Management

Nano Server is a 'headless' OS - there is no GUI on the server itself. PowerShell is front and center of the Nano management experience. Of course this means you will be able to manage IIS on Nano using our IIS PowerShell cmdlets.

I should clarify that as of IIS 10.0 there are 2 IIS PowerShell modules:

- The older WebAdministration module
- The [new IISAdministration module](https://blogs.iis.net/bariscaglar/iisadministration-powershell-cmdlets-new-feature-in-windows-10-server-2016)

Nano Server is a clean server platform for the future and so we currently have no plans to include the older legacy WebAdministration module at this time. Instead we will provide the new IISAdministration module.

In addition to PowerShell (IISAdministration), using appcmd.exe to manage IIS is also an option.
