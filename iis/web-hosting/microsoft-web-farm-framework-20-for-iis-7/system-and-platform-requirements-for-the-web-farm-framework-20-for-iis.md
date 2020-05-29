---
title: "System and Platform Requirements for the Web Farm Framework 2.0 for IIS 7"
author: rick-anderson
description: "This article describes the system and platform requirements for setting up Web Farm Framework 2.0 for IIS 7 and above in order to create and manage a server..."
ms.date: 07/21/2010
ms.assetid: 11305912-4c7a-499f-8b0a-ccff66e97a28
msc.legacyurl: /learn/web-hosting/microsoft-web-farm-framework-20-for-iis-7/system-and-platform-requirements-for-the-web-farm-framework-20-for-iis
msc.type: authoredcontent
---
# System and Platform Requirements for the Web Farm Framework 2.0 for IIS 7

by Randall DuBois

This article describes the system and platform requirements for setting up Web Farm Framework 2.0 for IIS 7 and above in order to create and manage a server farm.

> [!NOTE]
> The hardware requirements for Web Farm Framework 2.0 are the same as the requirements for the operating system on which you are installing it.

## Platform Requirements

Each computer that will participate in a server farm must have the following:

- Windows Server 2008 or Windows Server 2008 R2 installed.
- The .NET Framework 2.0 or later installed.
- One of the following accounts:
    - A local administrator account with the same name and password as an administrator account on each computer that will participate in the server farm.
    - A domain account in the local Administrators group that is also in the local Administrators group on each computer that will participate in the server farm.
- A network connection that is accessible by the other servers that will participate in the server farm.

## Provisioning Requirements

To provision your server farm, you first set up a primary server, and then Web Farm Framework duplicates that setup on each secondary server. The following requirements must be met.

- A single computer can not be part of multiple farms. (e.g. Primary in one farm, secondary in another farm). Only exception is controller, which can control multiple farms.
- Each computer that will be a secondary server in the server farm must have the same architecture as the primary server. If the primary server is a 32-bit computer, each secondary server must also be a 32-bit computer. If the primary server is a 64-bit computer, the secondary servers must also be 64-bit
- Each computer that will be secondary server in the server farm must have the same operating system and service pack as the primary server
- It is not supported to use Shared Configuration on Primary or Secondary machines.

## Controller Server Requirements

The Controller server must have the following:

- Windows Vista with SP1, Windows 7, Windows Server 2008 with SP1, or Windows Server R2 installed.
- The Microsoft Web Platform Installer V3 (Web PI v3) installed. To download Web PI, see [Web Platform Installer](https://www.microsoft.com/web/downloads/platform.aspx "Web Platform Installer").
- IIS installed (IIS 7.0, IIS 7.5 or above). If you do not have IIS installed, you can use the Web PI to install it.
- The Microsoft Web Deploy v2 module for IIS. If Web Deploy is not installed on the computer, it will automatically be installed by the Web PI with the Web Farm Framework as a required dependency.

> [!NOTE]
> Controller Server needs to be a dedicated computer, separate from Primary and Secondary servers. Single computer can not serve both Controller and Primary or both Controller and Secondary.

## Firewall Exceptions

The following programs and features must be allowed to communicate through your firewall in order for the Web Farm Framework components to communicate with the servers in your server farm:

- Core Networking
- Remote Administration

If you are using Windows Firewall, follow these steps to allow these programs.

1. In the Windows Control Panel, do one of the following: 

    - On Windows Server 2008 R2, if **View by Category** is selected, click **System and Security**, and then on the **System and Security** page click **Allow a program through Windows Firewall**.
    - On Windows Server 2008, if Control Panel home is selected, click **Security**, and then on the **Security** page click **Allow a program through Windows Firewall**.
    - If Icon View is selected (Windows Server 2008 R2), click **Windows Firewall**, and then click **Allow a program or feature through Windows Firewall**.
    - If Classic View is selected (Windows Server 2008), click **Windows Firewall**, and then click **Allow a program through Windows Firewall**.
2. On the **Allowed Programs** page, click **Change Settings**.
3. Select **Core Networking,** **Remote Administration** and **File and Printer Sharing** and then click **OK**.  
  
   The program must be allowed to communicate on the domain. You can optionally select other networks.

![](system-and-platform-requirements-for-the-web-farm-framework-20-for-iis/_static/image1.png)
