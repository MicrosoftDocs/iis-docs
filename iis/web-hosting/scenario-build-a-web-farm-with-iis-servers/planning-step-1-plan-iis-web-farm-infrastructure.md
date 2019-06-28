---
title: "Planning Step 1: Plan IIS Web Farm Infrastructure"
author: rmcmurray
description: "The first step in planning your web farm is to decide its infrastructure. What server configuration do you want? What technologies do you employ? How do you..."
ms.date: 04/14/2013
ms.assetid: 221ec127-06e9-42a4-8673-cf1033de480c
msc.legacyurl: /learn/web-hosting/scenario-build-a-web-farm-with-iis-servers/planning-step-1-plan-iis-web-farm-infrastructure
msc.type: authoredcontent
---
# Planning Step 1: Plan IIS Web Farm Infrastructure

by [Keith Newman and Robert McMurray](https://github.com/rmcmurray)

The first step in planning your web farm is to decide its infrastructure. What server configuration do you want? What technologies do you employ? How do you perform load balancing? Does your site need SSL security?

This topic presents the information you need to create a high-level plan for your web farm. It selects a simple web farm configuration and shows the types of servers that are required. In addition, this topic explains how Application Request Routing (ARR) provides load balancing for the web farm.

When you are done with these tasks, record your design decisions before going on to [Step 2: Plan IIS Web Farm Configuration](planning-step-2-plan-iis-web-farm-configuration.md).

<a id="11"></a>
## 1.1. Decide on Web Farm Infrastructure

There are many ways to design the infrastructure of a web farm. This discussion looks briefly at two common infrastructures-local content and shared network content. It compares advantages and disadvantages of both designs, and selects one for this scenario.

### Local Content Infrastructure

The local content infrastructure requires that each web server keeps the content locally. A way must be provided to push the content to all nodes of the web farm.

#### Advantages

- Local content provides isolation between servers. If one server goes down, other servers are not affected.
- Local content requires fewer computers, because it does not need a back-end content file server.
- You can easily take a web server off line for testing or troubleshooting.

#### Disadvantages

- Content must be replicated between servers. A common way to handle content replication is by using Distributed File System Replication (DFSR). However, DFSR requires access to a domain server.
- If the website writes to a disk, the data is not available to other servers until it is replicated.
- Each server must have a complete copy of all content. For large websites, the cost of content storage can be high.

### Shared Network Content Infrastructure

Shared network content configures all web servers point to a central location (for example, a back-end file server) that contains the website content.

#### Advantages

- Shared network content is relatively simple to configure and is a good starting point for individuals who are new to web farms or to Microsoft web farm technologies.
- Content written to disk is immediately available on all servers.
- Adding additional servers to the farms is relatively easy. You simply point to the content UNC path.
- Only a few copies of the website files need to be kept. Hard disks on the web servers need contain only the operating system.

#### Disadvantages

- The back-end file server is a single point of failure. This problem can be minimized by mirroring the file server and providing a means of failover control.
- Network bandwidth can become a limiting factor for a busy web farm.
- File locking issues might arise as multiple servers use the same files.

### The Infrastructure Chosen for This Scenario

This scenario uses the shared network content infrastructure. It describes and demonstrates shared content, shared configuration, software load balancing, centralized SSL certificates, and application deployment techniques.

This web farm infrastructure requires you to configure the following servers:

- One Application Request Routing (ARR) server for load balancing. This server requires a default installation of IIS web server. For more information about ARR, see [Step 3: Plan IIS Web Farm Load Balancing](planning-step-3-plan-iis-web-farm-load-balancing.md).
- Two or more web servers. These servers require you to install IIS web server and the IIS modules required to support your website.
- One file server for content and configuration sharing. Set up this server with shared folders for configuration file and website content.
- One file server for the SSL central certificate store. For more information about central certificate store, see [Step 4: Plan SSL Central Certificate Store](planning-step-4-plan-ssl-central-certificate-store.md).

<a id="12"></a>
## 1.2. Use ARR for Load Balancing

Microsoft Application Request Routing (ARR) is a proxy-based routing module that forwards HTTP requests to content servers based on HTTP headers, server variables, and load balance algorithms. For more information about ARR, see [Step 3: Plan IIS Web Farm Load Balancing](planning-step-3-plan-iis-web-farm-load-balancing.md).

The easiest way to install ARR and its dependencies is with [Web Platform Installer](https://www.microsoft.com/web/downloads/platform.aspx).

To configure ARR load balancing, you need the IP address for all of your servers. To find an IP address, use the Ipconfig.exe command-line tool.

<a id="13"></a>
## 1.3. Start with a Functional Website

The easiest way to configure your web farm is to start by getting your website working on one server. If you need help configuring your website, refer to one or more of the following IIS scenarios:

1. [Build a Static Website on IIS](../../manage/creating-websites/scenario-build-a-static-website-on-iis.md)
2. [Build a Classic ASP Website on IIS](../../application-frameworks/running-classic-asp-applications-on-iis-7-and-iis-8/scenario-build-a-classic-asp-website-on-iis.md)
3. [Build an ASP.NET Website on IIS](../../application-frameworks/scenario-build-an-aspnet-website-on-iis/overview-build-an-asp-net-website-on-iis.md)
4. [Build a PHP Website on IIS](../../application-frameworks/scenario-build-a-php-website-on-iis/overview-build-a-php-website-on-iis.md)
5. [Build an FTP Site on IIS](../../publish/using-the-ftp-service/scenario-build-an-ftp-site-on-iis.md)

> [!NOTE]
> To keep this scenario simple, it is assumed that your web farm servers only one site. However, you can set up multiple sites with little difficulty.

## See Also

- [Step 2: Plan IIS Web Farm Configuration](planning-step-2-plan-iis-web-farm-configuration.md)
- [Step 1: Install IIS Web Farm Infrastructure](configuring-step-1-install-iis-web-farm-infrastructure.md)
- [Plan a Web Farm with IIS Servers](plan-a-web-farm-with-iis-servers.md)
- [Build a Web Farm with IIS Servers](overview-build-a-web-farm-with-iis-servers.md)
- [Hosting-Friendly Web Server Platform (IIS): Scenario Overview](../../get-started/introduction-to-iis/hosting-friendly-web-server-platform-iis-scenario-overview.md)
