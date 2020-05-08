---
title: "New Features Introduced in IIS 10.0"
description: "This article discusses several of the new features which were introduced in Internet Information Services (IIS) which shipped with Windows 10 and Windows Ser..."
ms.date: 11/22/2016
ms.assetid: 6bbabad1-8ad9-4f64-893b-b375115cd7a9
msc.legacyurl: /learn/get-started/whats-new-in-iis-10/new-features-introduced-in-iis-100
msc.type: authoredcontent
---
# New Features Introduced in IIS 10.0

by [Sourabh Shirhatti](https://github.com/shirhatti)

> IIS 10.0 is the latest version of Internet Information Services (IIS) which shipped with Windows 10 and Windows Server 2016. This article describes the new functionality of IIS on Windows 10 and Windows Server 2016 and provides links to resources to learn more about these features.

## HTTP/2

IIS 10.0 adds support for the HTTP/2 protocol, which allows for numerous enhancements over HTTP 1.1 and results in an efficient reuse of connections and a reduction in latency. HTTP/2 support was added to Windows Server 2016 and Windows 10 as part of the kernel-mode device driver, HTTP.sys, and all your existing IIS 10.0 websites can benefit from this. (The latest versions of most modern browsers already support HTTP/2 over TLS so you may already be using HTTP/2.)

Learn more: [HTTP/2 on IIS](http2-on-iis.md)

## IIS on Nano Server

Nano Server is a new headless, 64-bit-only installation option for Windows 10 and Windows Server 2016 which installs &quot;just enough OS&quot; thereby resulting in a smaller footprint. Nano Server provides higher density, increased uptime, and a smaller attack surface making it suitable for running web workloads. You can currently run [ASP.NET Core](https://docs.microsoft.com/aspnet/core/tutorials/nano-server), [Apache Tomcat](https://blogs.iis.net/jeonghwan/running-tomcat-with-iis-on-nano-server), and [PHP](https://blogs.iis.net/jeonghwan/running-wordpress-with-iis-and-wincache-on-nano-server) workloads on IIS on Nano Server, in addition to using it as an reverse proxy to any HTTP listener via the [HttpPlatformHandler module](https://www.iis.net/downloads/microsoft/httpplatformhandler).

Learn more: [Introducing IIS on Nano Server](introducing-iis-on-nano-server.md)

## IIS in Containers

Windows Server 2016 and Windows 10 with the Anniversary Update add support for containers which are isolated, resource controlled, and portable operating environments. Windows Server 2016 and Windows 10 support two different container runtimes with a different degree of isolation: Windows containers achieve isolation through process and namespace isolation, while Hyper-V containers achieve isolation through lightweight virtual machines. IIS 10.0 runs in both container runtimes as well as on both base OS images, Server Core and Nano Server, allowing you to choose the best Windows container environment for your web workloads.

Get started with [IIS base images available on Docker Hub](https://hub.docker.com/r/microsoft/iis/) or follow this tutorial to [deploy an ASP.NET MVC application to IIS running inside a container](https://docs.microsoft.com/dotnet/articles/framework/docker/aspnetmvc).

## Managing IIS

With the advent of Nano Server and Windows Containers, IIS now provides a better management story for all environments running (including those without a GUI).

### Microsoft IIS Administration ([https://manage.iis.net](https://manage.iis.net))

Microsoft IIS Administration is a REST API which allows you to configure and monitor your IIS instance, and it is an [open-source project that is under active development on GitHub](https://github.com/Microsoft/IIS.Administration). With this API users can take advantage of the new IIS Web Manager that is available at [https://manage.iis.net](https://manage.iis.net). This browser based application consumes the IIS Administration API to provide a familiar management experience. Microsoft IIS Administration supports IIS 7.5 and above.

Learn more: [Microsoft IIS Administration Preview](https://blogs.iis.net/adminapi/microsoft-iis-administration-api-preview) or [watch the Channel 9 video](https://channel9.msdn.com/Blogs/Seth-Juarez/Microsoft-IIS-Administration-A-new-way-to-manage-IIS).

### IIS Administration PowerShell cmdlets

IIS 10.0 adds a new, simplified PowerShell module for managing IIS which scales better and offers superior pipelining support than existing WebAdministration cmdlets. The new module gives you direct access to the ServerManager object allowing for greater control over the configuration system.

Learn more with [IISAdministration PowerShell Cmdlets](iisadministration-powershell-cmdlets.md) or look at [how to achieve some common configuration tasks using IIS Administration](https://blogs.iis.net/jeonghwan/how-to-use-iisadministration-powershell-cmdlets-to-configure-iis-configuration-settings).

## Wildcard Host Headers

IIS 10.0 adds support for Wildcard Host Headers; you can now set up bindings to serve requests for any subdomain within a given domain.

Learn more: [Wildcard Host Header Support](wildcard-host-header-support.md)

## IIS Thread Pool Ideal CPU Optimization for NUMA hardware

IIS 10.0 provides better performance on NUMA hardware through the IIS thread pool ideal CPU optimization.

Learn more: [IIS Thread Pool Ideal CPU Optimization for NUMA hardware](thread-pool-ideal-cpu-numa-optimization.md)
