---
title: "Install Windows Server 2008 and Windows Server 2008 R2"
author: rick-anderson
description: "Introduction The Microsoft ® Web Platform is a powerful set of tools, servers, and technologies optimized for building and hosting next-generation Web applic..."
ms.date: 11/15/2009
ms.assetid: 7432a535-a72e-4792-8c8a-51fde740dcf8
msc.legacyurl: /learn/install/installing-iis-7/install-windows-server-2008-and-windows-server-2008-r2
msc.type: authoredcontent
---
# Install Windows Server 2008 and Windows Server 2008 R2

by Tali Smith

## Introduction

The Microsoft® Web Platform is a powerful set of tools, servers, and technologiesoptimized for building and hosting next-generation Web applications and solutions. At the base of the Microsoft Web Platform is Windows Server® 2008, Windows Server® 2008 R2, or another Windows Server® operating system version. Windows Server 2008 R2 comes with Internet Information Services 7.5 (IIS 7.5), a Web server and security-enhanced platform for developing and reliably hosting Web applications and services. Windows Server 2008 comes with IIS 7.0. IIS 7.0 and 7.5 (together known as IIS 7) include a componentized architecture for greater flexibility and control. IIS 7 and above also provides simplified management and powerful diagnostic and troubleshooting capabilities. IIS Manager extensions make it easy to administer local and remote Web servers.

IIS 7 and above, together with the Microsoft® .NET Framework 3.0, provides a comprehensive platform for building applications. Additionally, IIS plays a central role in unifying the Microsoft Web platform technologies—Microsoft® ASP.NET, Windows® Communication Foundation (WCF) Web services, and Windows® SharePoint® Services.

This article describes general procedures for installing Windows Server 2008 or Windows Server 2008 R2; links for more detailed information can be found throughout the article. After installing Windows Server 2008 or Windows Server 2008 R2, you will need to install IIS.

## Operating System Editions

Windows Server 2008 and Windows Server 2008 R2 are available in multiple editions to support the varying server and workload needs of organizations. The four main editions include Windows Server® 2008 R2 Standard, Windows Server® 2008 R2 Enterprise, Windows Server® 2008 R2 Datacenter, and Windows® Web Server 2008 R2 (or Windows Server® 2008 Standard, Windows Server® 2008 Enterprise, Windows Server® 2008 Datacenter, and Windows® Web Server 2008). See [Overview of Editions](https://www.microsoft.com/windowsserver2008/en/us/r2-editions-overview.aspx) for more detailed information about the various editions of Windows Server 2008 R2 and Windows Server 2008.

## Hardware Requirements

***Processor*** *— Processor performance depends not only on the clock frequency of the processor, but also on the number of processor cores and the size of the processor cache. The following are the processor requirements:*

- **Minimum:** 1 GHz (for x86 processors) or 1.4 GHz (for x64 processors)
- **Recommended:** 2 GHz or faster

***RAM*** *— The following are the RAM requirements:*

- **Minimum:** 512 MB
- **Recommended:** 2 GB or more
- **Maximum (32-bit systems):** 4 GB (for Windows Server 2008 Standard) or 64 GB (for Windows Server 2008 Enterprise or Windows Server 2008 Datacenter)
- **Maximum (64-bit systems):** 32 GB (for Windows Server 2008 Standard) or 2 terabyte (for Windows Server 2008 Enterprise, Windows Server 2008 Datacenter, or Windows Server® 2008 for Itanium-Based Systems)

***Disk space requirements*** *—The following are the approximate disk space requirements for the system partition. Itanium-based and x64-based operating systems will vary from these estimates. Additional disk space may be required if you install the system over a network:*

- **Minimum:** 10 GB
- **Recommended:** 40 GB or more

    > [!NOTE]
    > Computers with more than 16 GB of RAM require more disk space for paging, hibernation, and dump files.
- DVD-ROM drive
- Super VGA (800 x 600) or higher-resolution monitor
- Keyboard and mouse (or other compatible pointing device)

See [Hardware and Software Requirements for Installing SQL Server 2008](https://technet.microsoft.com/library/ms143506.aspx) for more information.

## Install Windows Server 2008 R2 or Windows Server 2008

Windows Server 2008 or Windows Server 2008 R2 setup works in several stages: first you are prompted for some basic information, including where you want to install Windows®.

[![](install-windows-server-2008-and-windows-server-2008-r2/_static/image4.jpg)](install-windows-server-2008-and-windows-server-2008-r2/_static/image3.jpg)

###### Figure 1: Provide basic information

Then, the setup procedure copies files and restarts the computer. The setup procedure concludes by presenting the Initial Configuration Tasks menu, which you can use to adjust the server configuration for your specific needs. Detailed instructions can be found at [Installing Windows Server 2008 R2](https://technet.microsoft.com/library/dd379511(WS.10).aspx) or [Installing Windows Server 2008](https://technet.microsoft.com/library/cc755116.aspx).

### Server Core Option

Note that you can choose to perform a Server Core installation—a minimal server installation of the operating system. With the addition of .NET Framework to Server Core in Windows Server 2008 R2, the Server Core installation option is even more appealing for those who want to use a very low footprint server for hosting their applications. For detailed instructions, see the [Server Core Installation Option Getting Started Guide](https://technet.microsoft.com/library/cc753802(WS.10).aspx).

[![](install-windows-server-2008-and-windows-server-2008-r2/_static/image6.jpg)](install-windows-server-2008-and-windows-server-2008-r2/_static/image5.jpg)

###### Figure 2: Server Core option

With the Server Core installation option, the traditional Windows interface is not installed, so you must configure the server from the command prompt. Note that if you use a Server Core installation, you cannot install some modules that rely on the .NET Framework or managed code. For more information, see [Using Server Core](../../manage/working-with-server-core/index.md).

## Configure Windows Server 2008 R2 or Windows Server 2008

After the Windows Server 2008 or Windows Server 2008 R2 setup is finished, log on to the server for the first time, and the Initial Configuration Tasks window automatically opens. You can now configure the new server by using commands in the Initial Configuration Tasks window.

The configuration tasks include setting the administrator password (the default is blank), changing the name of the administrator account to improve the security of your server (the default is "Administrator"), joining the server to an existing domain (the default is "WORKGROUP"), changing the name of the computer (the default is a random-generated name), enabling Remote Desktop for the server, and enabling Windows® Update (the default is off) and Windows® Firewall (the default is on). For more information, see [Windows Server Initial Configuration Tasks](https://technet.microsoft.com/library/cc755215.aspx).

## Links for Further Information

- [Windows Server 2008 R2](https://www.microsoft.com/windowsserver2008/en/us/default.aspx).
- [Optimizing Your Core Infrastructure](https://www.microsoft.com/windowsserver2008/en/us/optimize-infrastructure.aspx).
- [Introduction to Deploying Windows Server 2008.](../../web-hosting/installing-infrastructure-components/introduction-to-deploying-windows-server-2008-r2.md)
- [Installing Windows Server 2008](https://download.microsoft.com/download/e/6/3/e63cf2f6-7f71-450b-8e4a-dace88e99456/readme.htm).
- [Edition Comparison by Server Core Installation Option](https://www.microsoft.com/windowsserver2008/en/us/r2-compare-core-installation.aspx).
