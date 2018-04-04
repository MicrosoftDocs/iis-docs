---
title: "Enhanced Server Protection"
author: shirhatti
description: "IIS maximizes Web server security by default with minimal Web server footprint and automatic application isolation."
ms.author: soshir
ms.date: 3/6/2018
ms.topic: article
ms.technology: iis
ms.prod: iis
msc.type: authoredcontent
---
Enhanced Server Protection
--------------------------

IIS maximizes Web server security by default with minimal Web server footprint and automatic application isolation.

## Minimize Web Server Footprint

Administrators can depend on IIS for more secure hosting of Web applications. IIS has been redesigned from the ground up to incorporate a modular architecture that enables administrators to customize their Web servers by selectively installing or removing modules. Administrators can install only the features that address the needs of the business while eliminating the server performance reductions and security risks that come with running unused server functionality. Administrators can easily minimize the attack and servicing surface, as well as shrink the process memory footprint. Only the modules required to run IIS as a static image server are installed by default in IIS. The default installation allows the IT administrator to start from the most secure base, adding on modules only as needed by the applications and services hosted on the Web server.

## Windows Server Core Support

To further limit security exposure administrators can choose to install a minimal environment with the Server Core installation option of Windows Server 2008. Server Core omits graphical services and most libraries, in favor of a stripped-down, command-line driven system. Server Core can be administered locally via the IIS command-line utility AppCmd, or remotely by using WMI. Because Server Core has a select number of roles, it can improve security and reduce the footprint of the operating system. With fewer files installed and running on the server, there are fewer attack vectors exposed to the network; therefore, there is less of an attack surface. Administrators can install just the specific services needed for a given server, keeping the exposure risk to an absolute minimum.

## Automatic Web site isolation

IIS offers greater application isolation by giving worker processes a completely unique identity and sandboxed configuration by default, further reducing security risks. IIS includes automatic application pool isolation and can sandbox thousands of Web sites on a single server. This allows each Web site to run in its own memory space with an automatically generated, unique identity, which helps to ensure applications are not affected by other failures or security breaches of applications running on the same server. This capability enables organizations to consolidate more Web sites onto fewer servers, and increases security and reliability for all Web sites running on a shared host.