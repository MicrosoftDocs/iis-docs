---
title: "IIS 8.0 Express Readme | Microsoft Docs"
author: rmcmurray
description: "Overview Installation Supported Platforms and Architectures Changes to IIS 8.0 Express Known Issues and Limitations For More Information Overview Internet In..."
ms.author: iiscontent
manager: soshir
ms.date: 05/01/2012
ms.topic: article
ms.assetid: 
ms.technology: iis-extensions
ms.prod: iis
msc.legacyurl: /learn/extensions/introduction-to-iis-express/iis-80-express-readme
msc.type: authoredcontent
---
IIS 8.0 Express Readme
====================
by [Robert McMurray](https://github.com/rmcmurray)

<a id="Overview"></a>

## Overview

Internet Information Services (IIS) 8.0 Express is a free, simple and self-contained version of IIS that is optimized for developers. IIS 8.0 Express makes it easy to use the most current version of IIS to develop and test websites in development tools like Visual Studio and WebMatrix. IIS 8.0 Express has all the core capabilities of IIS 8 and above as well as additional features to ease website development including:

- IIS 8.0 Express doesn't run as a service or require administrative privileges to perform most tasks
- IIS 8.0 Express works well with ASP.NET and PHP applications
- Multiple users of IIS 8.0 Express can work independently on the same computer

<a id="Installation"></a>

## Installation

You can install IIS 8.0 Express through the [Microsoft Download Center](https://www.microsoft.com/en-us/download/) by using the following URL:

- **IIS 8.0 Express**: [https://www.microsoft.com/en-us/download/details.aspx?id=34679](https://www.microsoft.com/en-us/download/details.aspx?id=34679)

#### Upgrading from IIS 7.5 Express

If you already have IIS 7.5 Express installed when you install IIS 8.0 Express, the setup program will replace your IIS 7.5 Express installation with IIS 8.0 Express. Having IIS 7.5 Express and IIS 8.0 Express installed at the same time is not supported.

When you install IIS 8.0 Express on a 64-bit system, both the 32-bit and 64-bit versions of IIS 8.0 Express will be installed respectively in the "%ProgramFiles(x86)%\IIS Express" and "%ProgramFiles%\IIS Express" folders.

<a id="SupportedPlatforms"></a>

## Supported Platforms and Architectures

IIS 8.0 Express is supported on the following operating systems:

- Supported Native Platforms 

    - Windows 8 Client (Intel/AMD) 32-bit/64-bit
    - Windows Server 2012 (Intel/AMD) 64-bit
- Supported Down-level Platforms 

    - Windows 7 (x86 and x64)
    - Windows Server 2008 R2 (x86 and x64)
    - Windows Vista SP1 and later (x86 and x64)
    - Windows Server 2008 (x86 and x64)

IIS 8.0 Express is not supported on the following operating systems:

- Windows Server 2003
- Windows XP

For these unsupported operating systems, you can continue to use IIS 7.5 Express.

<a id="Changes"></a>

## Changes to IIS 8.0 Express

### New Features

IIS 8.0 Express supports the following new features:

- ***X64 Support***

    - IIS 8.0 Express supports both 32-bit and 64-bit architectures.
- ***Shared Features with IIS 8.0***

    - IIS 8.0 Express shares a great number of features with the full version of IIS; for example, IIS 8.0 Express uses many of the same binaries, configuration files, and error codes as the full version of IIS, so migrating projects between your development environment and your production environment should be easier than ever.
- ***Changing the User Home Directory***

    - IIS 8.0 Express supports changing the user's home directory, which is mapped to the %IIS\_USER\_HOME% variable in configuration. By default this path is located at %UserProfile%\Documents\IISExpress, but users can change this by setting a CustomUserHome registry property in HKCU\Software\Microsoft\IISExpress, or by specifying the "/userhome" parameter when launching iisexpress.exe.
- ***WebSocket Support***

    - IIS 8.0 Express supports writing WebSocket applications. For more information, see the [WebSocket](https://go.microsoft.com/fwlink/p/?LinkID=227812) protocol specification or the [System.Net.WebSockets Namespace](https://msdn.microsoft.com/en-us/library/hh159285) topic on Microsoft's MSDN website.
- ***AppCmd Support for editing multiple configuration files***

    - The AppCmd utility now supports a "/AppHostConfig" parameter, which makes it possible to use AppCmd to edit multiple ApplicationHost.config files and not just the primary configuration file.  
  
 For example, the following commands will create a website in a custom ApplicationHost.config file:  

        [!code-console[Main](iis-80-express-readme/samples/sample1.cmd)]
  
 Once you have added the website with the above commands, you can start it with the following command:  
        `iisexpress.exe /config:C:\Temp\IISExpress\config\ApplicationHost.config /site:www.fabrikam.com`

<a id="KnownIssues"></a>

## Known Issues and Limitations

#### Windows Server 2012 and Windows 8 features that do not work on Down-Level Operating Systems

There are a few features which require architecture that is specific to Windows Server 2012 and Windows 8 Client that will not work down-level when you install IIS 8.0 Express on earlier operating systems:

- Server Name Indication (SNI)
- Central Certificate Store
- WebSocket Functionality

#### Changes to the HTTP Substatus Codes

IIS 8.0 Express now shares the same set of HTTP status and substatus codes; this change was made so that developers would find it easier to troubleshoot problems by using IIS 8.0 Express or the full version of IIS on their web server. The following list contains the HTTP substatus codes that were included with IIS 7.5 Express that have been modified or deprecated:

- HTTP 404.20 - This was the error that was returned when no default document was defined: 

    - IIS 8.0 Express returns an HTTP 403 *Access Forbidden* error when no default document is defined.
    - IIS 8.0 Express returns an HTTP 404.20 error for *Too Many URL Segments*.
- HTTP 404.21 - This error code was returned when PHP was not installed; this has been removed from IIS 8.0 Express.
- HTTP 404.22 - This error code was returned when ASP.NET was not installed; this has been removed from IIS 8.0 Express.
- HTTP 404.23 - This error code was returned when ASP.NET web pages were not installed; this has been removed from IIS 8.0 Express.


#### Errors when using .NET Framework 3.5 and earlier with IIS 8.0 Express Release Candidate on Windows Server 2012 and Windows 8 Client

There is a known application compatibility issue when you are using IIS 8.0 Express Release Candidate on Windows Server 2012 and Windows 8 Client if you are using .NET Framework 3.5 and earlier versions. This issue is resolved for the final release of IIS 8.0 Express, but a workaround is to install the standard version of IIS on the system where you are running the IIS 8.0 Express Release Candidate. (Note: IIS does not have to be running; you just need to install a basic installation of IIS to resolve the compatibility issue.)

<a id="Information"></a>

## More Information

You can learn more about IIS 8.0 Express and related products using the following links:

- IIS.net
- [Microsoft.com/web](https://www.microsoft.com/web)
  
  
[Discuss in IIS Forums](https://forums.iis.net/1166.aspx)