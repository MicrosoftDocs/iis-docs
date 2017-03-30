---
title: "Planning Step 2: Plan IIS Web Farm Configuration | Microsoft Docs"
author: rmcmurray
description: "In the second phase of planning a web farm, determine what is needed to configure shared content and shared configuration. In addition, learn how to add web..."
ms.author: iiscontent
manager: soshir
ms.date: 04/14/2013
ms.topic: article
ms.assetid: 
ms.technology: iis-hosting
ms.prod: iis
msc.legacyurl: /learn/web-hosting/scenario-build-a-web-farm-with-iis-servers/planning-step-2-plan-iis-web-farm-configuration
msc.type: authoredcontent
---
Planning Step 2: Plan IIS Web Farm Configuration
====================
by [Keith Newman and Robert McMurray](https://github.com/rmcmurray)

In the second phase of planning a web farm, determine what is needed to configure shared content and shared configuration. In addition, learn how to add web servers to your farm.

The following list shows the tasks required to complete this step:

- [2.1. Plan for Shared Content](#21)
- [2.2. Plan for Shared Configuration](#22)
- [2.3 Plan to Add Web Servers](#23)

When you are done with these tasks, record your design decisions before going on to [Step 3: Plan IIS Web Farm Load Balancing](planning-step-3-plan-iis-web-farm-load-balancing.md).

<a id="21"></a>
## 2.1. Plan for Shared Content

Network shared content uses a back-end file server to manage website content. All web servers point to a shared folder on the file server over a UNC path. To reduce the risk of failure, the file server is often mirrored to another server with some method of failover provided. For information about failover clusters, see [Failover Clustering](https://technet.microsoft.com/en-us/library/hh831579).

To configure shared content, you first set up the shared folder on the file server. Create a custom user for each application pool and assign that user to the shared folder. You can create local users and groups as long as the same username and password is assigned to each web server.

If your web farm supports ASP.NET applications, use the Code Access Security Policy tool (Caspol.exe) to grant ASP.NET approval for the UNC path. With the Caspol tool, you can grant full trust to the UNC path on your web server. The tool resides on your server at one of the following locations:

- 64-bit systems: %windir%\Microsoft.NET\Framework64\v4.030319
- 32-bit systems: %windir%\Microsoft.NET\Framework\v4.030319

Run the tool by using either a system command prompt, a PowerShell command prompt, or a Visual Studio command prompt. For more information, see [Step 2: Configure IIS Web Farm Servers](configuring-step-2-configure-iis-web-farm-servers.md).

<a id="22"></a>
## 2.2. Plan for Shared Configuration

Shared configuration is an IIS feature that helps support homogeneous web farms where all web servers share the same configuration. By using a UNC share, any changes to a master configuration file propagate across different servers without extra tools or programmatic support.

You enable shared configuration in two steps by using the IIS Manager.

1. Export the configuration files to a shared folder on the back-end file server.
2. Point IIS to the UNC path for that shared folder.

<a id="23"></a>
## 2.3 Plan to Add Web Servers

To add web servers to you farm, first use IIS Manager to set up shared configuration by pointing to the configuration UNC path. When you restart IIS Manager, the shared site or sites will be listed. If your web farm supports ASP.NET applications, run the Caspol tool on the new server.

## See Also

- [Step 3: Plan IIS Web Farm Load Balancing](planning-step-3-plan-iis-web-farm-load-balancing.md)
- [Step 1: Plan IIS Web Farm Infrastructure](planning-step-1-plan-iis-web-farm-infrastructure.md)
- [Step 2: Configure IIS Web Farm Servers](configuring-step-2-configure-iis-web-farm-servers.md)
- [Plan a Web Farm with IIS Servers](plan-a-web-farm-with-iis-servers.md)
- [Build a Web Farm with IIS Servers](overview-build-a-web-farm-with-iis-servers.md)
- [Hosting-Friendly Web Server Platform (IIS): Scenario Overview](../../get-started/introduction-to-iis/hosting-friendly-web-server-platform-iis-scenario-overview.md)