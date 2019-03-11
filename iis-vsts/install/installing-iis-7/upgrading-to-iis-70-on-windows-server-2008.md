---
title: "Upgrading to IIS 7.0 on Windows Server 2008"
author: rick-anderson
description: "You can move Web sites and applications to Internet Information Services (IIS) 7.0 and above in two ways: upgrading and installing. Upgrading is installing t..."
ms.date: 03/11/2008
ms.assetid: c85152ef-d9ea-47b1-a705-46a9ce1c2edc
msc.legacyurl: /learn/install/installing-iis-7/upgrading-to-iis-70-on-windows-server-2008
msc.type: authoredcontent
---
Upgrading to IIS 7.0 on Windows Server 2008
====================
by IIS Team

You can move Web sites and applications to Internet Information Services (IIS) 7.0 and above in two ways: upgrading and installing. Upgrading is installing the Microsoft Windows Server 2008 or above operating system and IIS 7.0 or above on an existing server that is running the Windows Server 2003 operating system and IIS 6.0. Migrating, on the other hand, is installing Microsoft Windows Server 2008 or above and IIS 7.0 or above on a new server and then moving, or reinstalling, existing Web sites and applications on that server. This document outlines the steps to take in planning an upgrade to Microsoft Windows Server 2008 and IIS 7.0.

Click [here](https://go.microsoft.com/fwlink/?LinkId=111601) to see the article in TechNet.

Other articles on this subject include:

## Overview of Upgrading to IIS 7.0 on Windows Server® 2008

The IIS modular architecture is designed to enable the IT professional to customize exactly which features are installed and running on the Web server. IIS is now divided into more than 40 feature modules that can be independently installed on the box. This modularization significantly reduces the potential attack surface, lowers the footprint requirements, and minimizes patching and security risks.

Click [here](https://go.microsoft.com/fwlink/?LinkId=111602) to see the article in TechNet.

## Preparing to Upgrade to IIS 7.0

IIS 7.0 and above introduces many changes from earlier versions of IIS. These changes can affect the way users interact with IIS. This document explains considerations for users who will upgrade from an earlier version of IIS to IIS 7.0.

Click [here](https://go.microsoft.com/fwlink/?LinkId=111603) to see the article in TechNet.

## Performing the Upgrade to IIS 7.0

The upgrade to IIS 7.0 is part of the upgrade to Microsoft Windows Server 2008. After your Windows server has been upgraded to Microsoft Windows Server 2008, you must use the Server Manager tool to add the Web Server role.

Click [here](https://go.microsoft.com/fwlink/?LinkId=111604) to see the article in TechNet.

## Remove Unnecessary Components

After an upgrade, you should consider removing any unnecessary IIS modules to match the functionality required by your Web applications. Because of the way that IIS 6.0 components were installed, the IIS upgrade process may have installed modules that are no longer needed.

Click [here](https://go.microsoft.com/fwlink/?LinkId=111605) to see the article in TechNet.

## Additional Resources for Upgrading to IIS 7.0

These resources contain additional information about how to upgrade to IIS 7.0 on Microsoft Windows Server 2008.

Click [here](https://go.microsoft.com/fwlink/?LinkId=111606) to see the article in TechNet.