---
title: "Deploying Updates with WSUS 3.0"
author: walterov
description: "Microsoft Windows Server® Update Services 3.0 (WSUS 3.0) enables IT administrators to deploy the latest Microsoft product updates to computers running Micros..."
ms.date: 12/04/2007
ms.assetid: 7fe15677-3d20-49ce-a46c-72f20b2b4c78
msc.legacyurl: /learn/web-hosting/installing-infrastructure-components/deploying-updates-with-wsus-30
msc.type: authoredcontent
---
Deploying Updates with WSUS 3.0
====================
by [Walter Oliver](https://github.com/walterov)

## Overview

Microsoft Windows Server® Update Services 3.0 (WSUS 3.0) enables IT administrators to deploy the latest Microsoft product updates to computers running Microsoft Windows Server® 2003, Windows Server® 2008, Windows VistaTM, Microsoft Windows® XP with Service Pack 2, and Windows 2000 with Service Pack 4 operating systems. By using WSUS, administrators can fully manage the distribution of updates that are released through Microsoft Update to computers in their network.

WSUS provides a management infrastructure consisting of the following:

1. **Microsoft Update**. The Microsoft Web site that distributes updates of Microsoft products.

1. **Windows Server Update Services server**. This component is installed on a Windows Server 2003 SP1 or Windows Server 2008 server inside the hoster firewall. The WSUS server allows administrators to manage and distribute updates through the WSUS 3.0 Administration console, which can be installed on any Windows computer in the domain. In addition, a WSUS server can be the update source for other WSUS servers within the organization. At least one WSUS server in the network must connect to Microsoft Update to get available update information. The administrator can determine, based on network security and configuration, whether or not other servers should connect directly to Microsoft Update.

1. **Automatic Updates**. This component is built into the Windows Server 2008, Windows Vista, Windows Server 2003, Windows XP, and Windows 2000 SP4 operating systems. Automatic Updates enables both server and client computers to receive updates from Microsoft Update or from a WSUS server.

For a Step-by-Step Guide to getting started with WSUS 3.0, deployment scenarios, and processes (including unattended command line), visit [http://technet2.microsoft.com/windowsserver/en/library/912b37d7-021e-4c95-b317-49dd15b4611c1033.mspx?mfr=true](http://technet2.microsoft.com/windowsserver/en/library/912b37d7-021e-4c95-b317-49dd15b4611c1033.mspx?mfr=true).

## Software Requirements for Installing WSUS 3.0 on Windows Server 2008

To install WSUS 3.0 on Windows Server 2008, you must have the following installed on your computer. If any of these updates require restarting the server when installation is completed, restart your server before installing WSUS 3.0.

Ensure that the following components are enabled:

- Microsoft Internet Information Services (IIS) 7.0 or above
- Windows Authentication
- ASP.NET
- 6.0 Management Compatibility
- IIS Metabase Compatibility
- Microsoft Report Viewer Redistributable 2005. To download this software, go to the Download Center ([https://go.microsoft.com/fwlink/?LinkID=70410](https://go.microsoft.com/fwlink/?LinkID=70410)).
- Microsoft SQL ServerTM 2005 Service Pack 1. To download this software, go to the Download Center ([https://go.microsoft.com/fwlink/?LinkID=66143](https://go.microsoft.com/fwlink/?LinkID=66143)).
- The .NET Framework 2.0 and BITS 2.0 update are available on Windows Server 2008 as part of the operating system.

For a complete description of WSUS 3.0 Software Requirements (Console, Automatic Updates, and Permissions) visit, [http://technet2.microsoft.com/windowsserver/en/library/912b37d7-021e-4c95-b317-49dd15b4611c1033.mspx?mfr=true](http://technet2.microsoft.com/windowsserver/en/library/912b37d7-021e-4c95-b317-49dd15b4611c1033.mspx?mfr=true).

## Preparing the WSUS 3.0 Deployment

The first step in deploying WSUS 3.0 is to design the server configuration. For a detailed process guide on how to prepare and deploy WSUS 3.0, refer to: [http://technet2.microsoft.com/windowsserver/en/library/912b37d7-021e-4c95-b317-49dd15b4611c1033.mspx?mfr=true](http://technet2.microsoft.com/windowsserver/en/library/912b37d7-021e-4c95-b317-49dd15b4611c1033.mspx?mfr=true).

The following topics in the guide describe various aspects of deployment design-from a simple configuration with a single server to a configuration with multiple WSUS servers. Some of the considerations to take into account are connection bandwidth (for both Internet connections and LAN or WAN connections), network configuration, and different language requirements.

**To prepare the WSUS 3.0 deployment refer to:** 

- [Choose a Type of WSUS Deployment](http://technet2.microsoft.com/WindowsServer/en/library/12b665bc-07fa-4a4e-aed8-f970efe80c4c1033.mspx)
- [Choose a WSUS Management Style](http://technet2.microsoft.com/WindowsServer/en/library/98d5664a-2f6b-4ccf-b440-b71b7d5dec3e1033.mspx)
- [Choose the Database Used for WSUS 3.0](http://technet2.microsoft.com/WindowsServer/en/library/6f51cae4-4b1e-4a4b-81ef-cc92dd3644fd1033.mspx)
- [Determine Where to Store WSUS Updates](http://technet2.microsoft.com/WindowsServer/en/library/aa4d106e-830e-4074-8675-bc52b2ada0941033.mspx)
- [Determine Bandwidth Options to Use](http://technet2.microsoft.com/WindowsServer/en/library/f47b494b-fbf5-4bf8-a5c9-c31221a3dfdb1033.mspx)
- [Determine WSUS Capacity Requirements](http://technet2.microsoft.com/WindowsServer/en/library/92170771-83e7-47bb-abbc-7d93ee5d78671033.mspx)