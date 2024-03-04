---
title: "IIS 7.5 Express Readme"
description: "Overview Installation Using IIS 7.5 Express Supported Platforms and Architectures Changes to IIS 7.5 Express Known Issues and Limitations."
ms.date: 02/26/2012
ms.assetid: 0bf2cd97-4f8d-4b4e-b291-1d9256032a3b
msc.legacyurl: /learn/extensions/introduction-to-iis-express/iis-75-express-readme
msc.type: authoredcontent
---
# IIS 7.5 Express Readme

by [Vaidy Gopalakrishnan](https://github.com/vaidyg)

<a id="Overview"></a>

## Overview

Internet Information Services (IIS) 7.5 Express is a free, simple and self-contained version of IIS that is optimized for developers. IIS Express makes it easy to use the most current version of IIS to develop and test websites. It has all the core capabilities of IIS 7 and above as well as additional features to ease website development including:

- It doesn't run as a service or require administrative privileges to perform most tasks
- It works well with ASP.NET and PHP applications
- Multiple users of IIS Express can work independently on the same computer

<a id="Installation"></a>

## Installation

You can install IIS 7.5 Express through the [Microsoft Download Center](https://www.microsoft.com/download/).

<a id="UsingIISExpress"></a>

## Using IIS 7.5 Express

You will most likely need an Integrated Development Environment to build web applications over IIS 7.5 Express. Microsoft WebMatrix provides a simple and integrated user experience for building both ASP.NET and PHP websites using IIS 7.5 Express. You can use IIS 7.5 Express with Visual Studio 2010 SP1 Beta to build and test web applications instead of the built-in ASP.NET Development Web Server (also known as Cassini). It is also possible to [run IIS 7.5 Express using the command line.](../using-iis-express/running-iis-express-from-the-command-line.md)

<a id="SupportedPlatforms"></a>

## Supported Platforms and Architectures

IIS 7.5 Express supports the following Windows editions.

- Windows 7
- Windows Server 2008
- Windows Server 2008 R2
- Windows Vista SP1 or later
- Windows XP SP3
- Windows Server 2003 SP2

Both 32-bit and 64-bit systems are supported, however only a 32-bit build of IIS 7.5 Express exists.

<a id="Changes"></a>

## Changes to IIS 7.5 Express

The 7.5.1190 version of IIS 7.5 Express that was released in March, 2012, contains several bug fixes from the original 7.5.1070 version of IIS 7.5 Express that was released in April, 2011, but no new features were introduced.

<a id="KnownIssues"></a>

## Known Issues and Limitations

### Issue: Cannot run IIS Express using the /path command line option after installation

Running iisexpress.exe with the /path option results in the error: *Temp configuration file settings error. The system cannot find the file specified*. This is due to a bug where the *redirection.config* file isn't being setup correctly.  
  
**Workaround**:Running iisexpress.exe without any arguments once will setup a copy of *redirection.config* under the user profile directory. You will then be able to successfully run iisexpress.exe with the /path option.

### Issue: WCF applications fail after .NET 3.5 is installed

The default *applicationhost.config* file for IIS 7.5 Express needs to be different depending on whether or not .NET 3.5 is installed. If .NET 3.5 is missing when IIS 7.5 Express is installed, the default *applicationhost.config* file will include handlers for.NET 4.0 only. Subsequently installing .NET 3.5 can lead to problems since the default *applicationhost.config* hasn't been updated.  
  
**Workaround**: The IIS 7.5 Express installation folder includes a *WCF35Setup.js* script that is designed to solve this problem. Running this script from a command prompt will refresh the default *applicationhost.config* file to work with .NET 3.5.

### Limitation: IIS 7.5 Express doesn't honor library settings in Windows 7

IIS 7.5 Express only understands the default documents folder in Windows 7. It doesn't support non-default document folders and will continue to utilize the default documents folder for configuration files, log files and other settings.  
  
**Workaround**: None

### Limitation: Stopping IIS 7.5 Express from WebMatrix or Visual Studio 2010 SP1 Beta will abort any running websites

Stopping IIS 7.5 Express from WebMatrix or Visual Studio 2010 SP1 Beta won't cleanly shutdown any running applications.  
  
**Workaround**: Shutdown IIS Express instances from the system tray application to cleanly terminate any running websites.

### Issue: On Windows Server 2003, IIS Express does not start for a non-administrative user

On Windows Server 2003, when you launch a page or start IIS Express, IIS Express does not start. For Web pages, an error is displayed that indicates that the application has been started by a non-administrative user.  
  
**Workaround**: Run IIS 7.5 Express as an administrative user. For more details, see the following KnowledgeBase article:  
An application that is started by a non-administrative user cannot listen to the HTTP traffic of the computer on which the application is running in Windows Vista, Windows Server 2003, or Windows XP. (`https://support.microsoft.com/kb/939786`)

### Issue: When you install IIS 7.5 Express, a registry key may be left in Wow6432Node

When you install IIS 7.5 Express from your system, the registry key for IIS 7.5 Express may be left under the `HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\IISExpress` path.  
  
**Workaround**: Remove the orphaned IIS 7.5 Express registry key:

1. Open the Windows **Registry Editor**.
2. Locate the following registry key:

    [!code-console[Main](iis-75-express-readme/samples/sample1.cmd)]
3. Right-click the `7.5` registry key and click **Delete**.
4. Click **Yes** when prompted to delete the key.
5. Close the Windows **Registry Editor**.

<a id="Information"></a>

## For More Information

You can learn more about IIS 7.5 Express and related products using the following links:

- IIS.net
- Microsoft.com/web
