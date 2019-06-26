---
title: "Troubleshooting Problems with Microsoft Web Platform Installer"
author: rick-anderson
description: "Introduction Microsoft ® Web Platform Installer (Web PI) makes it simple to download and install the latest Microsoft ® Web Platform components, including In..."
ms.date: 03/18/2009
ms.assetid: 5379a674-41f0-49d9-b744-cf5abd92749a
msc.legacyurl: /learn/troubleshoot/web-platform-installer-issues/troubleshooting-problems-with-microsoft-web-platform-installer
msc.type: authoredcontent
---
# Troubleshooting Problems with Microsoft Web Platform Installer

by IIS Team

## Introduction

Microsoft® Web Platform Installer (Web PI) makes it simple to download and install the latest Microsoft® Web Platform components, including Internet Information Services (IIS), Microsoft® SQL Server® 2008/R2 Express, Microsoft® ASP.NET Model View Controller (MVC3) and Microsoft® Visual Web Developer 2008/SP1 Express Edition. Web PI also installs popular Web applications such as WordPress, DasBlog, or Silverstripe. This article presents some troubleshooting advice for issues that may arise with Microsoft Web PI.

Web PI runs on the following operating systems:

- Windows Server® 2008 and Windows Server® 2008 R2
- Windows® XP Professional Edition Service Pack 3
- Windows Server® 2003 SP2
- Windows Vista® SP 1
- Windows® 7

Note that while it is possible to install Web PI on Windows® XP Home Edition, this operating system version does not include IIS; Web PI is therefore not supported on Windows XP Home Edition.

Web PI tasks can be divided into three phases:

- **Launch phase.** Web PI retrieves the most current product catalog and compares the catalog components with the currently installed products.
- **Product selection phase.**  
 Web PI checks dependencies of the products selected to install and builds the list of dependent products that need to be installed.
- **Installation phase.**

Web PI installs products using one of three technologies:

- To install Windows® operating system components (for example, IIS), Web PI uses Windows operating system [tools and interfaces](https://technet.microsoft.com/en-us/library/cc776554(WS.10).aspx) such as [PKGMGR](https://technet.microsoft.com/en-us/library/cc749302(WS.10).aspx).
- To install non-operating system platform components, (for example, SQL Server 2008/R2 Express) Web PI uses the Windows® Installer technology (also known as MSI).
- To install Web applications (for example, WordPress, Silverstripe, or DasBlog), Web PI uses the Microsoft® Web Deployment Tool.

## Recent Issues

(Posted: July 25, 2011)

#### Issues with Visual Web Developer 2010 / Visual Studio 2010 SP1 install

Users have reported issues where, after installing VWD 2010/SP1 or VS 2010/SP1, that WebPI still shows the bundle as being available for install. This is due to issues with the detection logic (discoveryHints in WebPI terms) that need revisions. If you perform an installation of VWD 2010/SP1 or VS 2010/SP1 and *everything shows as successfully installed* after the process is complete, then there is no additional work on your part. You can currently safely ignore the option to "install" the bundle again

## General Troubleshooting Best Practices

To assist the Web Platform Team in debugging issues with your installation attempt, please post the logs to the forums. We've created a post that gives additional details on which log files to post: You can read about it here: [https://forums.iis.net/t/1178550.aspx](https://forums.iis.net/t/1178550.aspx)

## Troubleshooting During the Launch Phase

The most common issues during the Web PI launch phase involve connectivity. Web PI downloads the newest product catalog from a Microsoft Web site. If this fails, an error message such as the following appears:

[![](troubleshooting-problems-with-microsoft-web-platform-installer/_static/image3.jpg)](troubleshooting-problems-with-microsoft-web-platform-installer/_static/image2.jpg)

###### Figure 1: Unable to download Web Platform error message

**Behind Proxy** If the computer is behind a proxy, ensure that the proxy settings for Windows® Internet Explorer® are set correctly and retry accessing the URL through Internet Explorer and then through Web PI  
**Behind Firewalls** In the case where third-party firewalls are installed on the computer, try disabling them before launching Web PI. You can also add exceptions for WebpiLauncher.exe and WebPlatformInstaller.exe to the firewall settings.If the issue is not resolved yet, It should be possible to fix the problem by following the steps described in [How to troubleshoot network connectivity problems in Internet Explorer](https://support.microsoft.com/kb/936211 "How to troubleshoot network connectivity problems in Internet Explorer").

If the URL can be accessed in Internet Explorer but not via Web PI, use Fiddler, a Web debugger that monitors which HTTP requests are made from a computer. Fiddler can be downloaded from [Introducing Fiddler](http://www.fiddlertool.com/fiddler/ "Fiddler Web Debugger").

## Troubleshooting During the Installation Phase

Web PI installs components and applications "silently" (without displaying a user interface), and install failures are written to log files. There are many log files because of the large number of supported setup technologies and platforms.

The setup technologies can be categorized as:

- Operating system components
- Products installed with the Windows Installer (MSI) technology
- Web applications using the Microsoft Web Deployment Tool deployment technology

### Operating system components

Operating system components, such as IIS, are installed with Windows setup technologies. The locations for the setup log files are described in the following paragraphs.

**Windows Vista, Windows 7, Windows Server 2008, and Windows Server 2008 R2**

Operating system components on Windows Vista, Windows 7, Windows Server 2008, and Windows Server 2008 R2 use component-based setup. The log file for operating system components is stored in the `%windir%\logs\cbs` directory. You can open it with the command:


[!code-console[Main](troubleshooting-problems-with-microsoft-web-platform-installer/samples/sample1.cmd)]


For more information, see [Optional Component Setup Log Diagnoser](https://technet.microsoft.com/en-us/library/cc732334.aspx).

IIS 7.0 (Windows Vista and Windows Server 2008) and IIS 7.5 (Windows 7 and Windows Server 2008 R2) setup generates a separate setup log file, located in the `%windir%` directory. You can open this log file with the command:


[!code-console[Main](troubleshooting-problems-with-microsoft-web-platform-installer/samples/sample2.cmd)]


**Windows XP and Windows Server 2003**

Windows XP and Windows Server 2003 setup log files are stored in the `%systemroot%` directory. You can open the Windows setup log file with the name setuperr.log with the command:


[!code-console[Main](troubleshooting-problems-with-microsoft-web-platform-installer/samples/sample3.cmd)]


The IIS setup log file is called iis6.log or iis51.log. You can open it with the command:


[!code-console[Main](troubleshooting-problems-with-microsoft-web-platform-installer/samples/sample4.cmd)]


### Products installed using Windows Installer (MSI) technology

You can use the [Windows Installer technology](https://msdn.microsoft.com/library/aa371366(VS.85).aspx) for Web platform components such as Microsoft® SQL Server® and Visual Web Developer 2008 Express Edition. To look at the logs, open Internet Explorer and type the following into the address bar:


[!code-console[Main](troubleshooting-problems-with-microsoft-web-platform-installer/samples/sample5.cmd)]


Web PI also displays a link to the log file that failed in the summary screen; see the [detailed description of Windows Installer error codes](https://msdn.microsoft.com/library/aa372835(VS.85).aspx).

### Products installed using the Microsoft Web Deployment Tool technology

The Web Deployment Tool offers a way for Web applications to join the Web PI ecosystem by adding a few manifest files to an existing compressed file (Zip) package. Web PI calls the Web Deployment Tool and installs the Web application on an IIS Web site. The Web Deployment Tool technology is used for all Web applications found in the Windows Web App Gallery. Note that the Web Deployment Tool logs all its information into a file named x86\_msdeploy.txt (32-bit system) or x64\_msdeploy.txt (64-bit system).

## Known Issues

Following are some known issues:

**Web PI cannot install additional IIS components if shared configuration is enabled**.   
If IIS is configured for "Shared Configuration," Web PI cannot install most additional IIS components. For more information, see the support article "[You cannot install or uninstall a component in IIS 7.0](https://support.microsoft.com/kb/954856)."

#### Issues during application installation using Web PI:

- **Web PI does not automatically create physical directories when an application is installed to a new site**.   
 Create the directory manually or use the ‘...' button next to the physical path text box to create a new folder.
- **Web PI requires password fields to be filled in and does not allow them to be empty**.   
 If an application allows an empty password, the password does not work when the application is installed in Web PI.

#### Issues with Microsoft SQL Server during application installation:

- **Applications do not work without SQL "Mixed mode authentication."**   
  For most Web applications, SQL Server user accounts are required in order to access a database. If only integrated or Windows authentication for SQL Server are selected, you cannot install some of the applications in the gallery.
- **SQL Server passwords are not accepted if they do not meet strength requirements**.   
  However, Web PI does not validate passwords for strength or for other criteria. The failure to create an account with a weak password occurs during application installation, and the installation fails. Use a [strong password](https://msdn.microsoft.com/library/ms161959.aspx) according to the SQL Server policy.
- **SQL Server user names cannot be longer than 16 characters**.   
  However, Web PI does not validate user fields for length or other criteria. The failure to create an account with a user name that is more than 16-characters long happens during application installation, and the installation fails. Use a user name that is no more than 16-characters long.
- **Other Microsoft SQL Server issues.** Check the SQL Server log files in the following directory for more information:  
  %programfiles%\microsoft sql server\100\setup bootstrap\log   
  More details about how to trouble shoot SQL issues can be found at [https://support.microsoft.com/kb/955396](https://support.microsoft.com/kb/955396)
- **Custom Installation of SQL Server**  
  For customers needing customization for their SQL Server install outside of Web PI, please check this guide <https://blogs.msdn.com/sqlexpress/archive/2009/06/15/installing-sql-server-2008-guidance.aspx>.

**Issues with Visual Web Developer installation:** 

- The following link is a troubleshooting guide for failures during Visual Web Developer Installations <https://blogs.msdn.com/astebner/archive/2007/07/31/4156781.aspx>.

## Additional Troubleshooting Tools, Tips, and Tricks

The following information contains some additional useful tips and tricks for solving problems you might encounter when installing parts of the Microsoft Web Platform stack with Web PI.

**Web PI Installer files**

The WebPI installer files can be downloaded directly - please see the following [post](https://forums.iis.net/t/1178551.aspx) on where to get the files

### Fiddler

Web PI downloads its product catalog and the product packages through HTTP requests. [Fiddler](http://www.fiddler2.com/fiddler2/) is a Web debugger that can help determine if these requests succeed and if the requested resources are still available. Fiddler monitors all HTTP requests that are made from the Windows-based computer that runs Web PI.

### Process Monitor

[Process Monitor](https://technet.microsoft.com/en-us/sysinternals/bb896645.aspx) is an advanced monitoring tool for Windows that shows real-time file system, registry, and process/thread activity. In the Web PI case Process Monitor can be used to monitor the activity of install programs.

### Windows Event Log

Windows has a central repository for errors, informational messages, and warnings called the Windows Event Log. Though sometimes overlooked, Event Log often provides the solution to many problems and is worth exploring. To open the Windows Event Log, type the following at the command prompt or in the Run menu:

[!code-console[Main](troubleshooting-problems-with-microsoft-web-platform-installer/samples/sample6.cmd)]

### Web PI Tracing

Web PI has an additional built-in tracing mechanism. It can be activated by saving the following configuration file as webplatforminstaller.exe.config in the %programfiles%\Microsoft\Web Platform Installer directory.

[!code-html[Main](troubleshooting-problems-with-microsoft-web-platform-installer/samples/sample7.html)]

The trace file called WebPI.log file is also written to the %programfiles%\Microsoft\Web Platform Installer directory.

### Cleaning the Web PI Cache

Web PI is caching the product catalog and other files to optimize startup time. If the product catalog seems to be outdated or if incorrect data is displayed in Web PI, delete the cache with:

[!code-console[Main](troubleshooting-problems-with-microsoft-web-platform-installer/samples/sample8.cmd)]

## Additional Help

If you have exhausted the troubleshooting tips and tricks in this article and are still having problems, visit the Web Platform Installer forum at <https://forums.iis.net/1155.aspx>.
