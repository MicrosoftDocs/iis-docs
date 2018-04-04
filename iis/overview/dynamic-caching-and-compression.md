---
title: "Dynamic Caching and Compression"
author: shirhatti
description: "Speed up your Web site through built-in dynamic caching and enhanced compression."
ms.author: soshir
ms.date: 3/6/2018
ms.topic: article
ms.technology: iis
ms.prod: iis
msc.type: authoredcontent
---
Dynamic Caching and Compression
-------------------------------

Speed up your Web site through built-in dynamic caching and enhanced compression.

IIS provides the fastest performance for static and dynamic Web content through powerful HTTP compression and deeper integration with request serving from the Windows kernel for SSL Web sites and Windows authentication.

## Enhanced Bandwidth Compression

IIS's performance improvements help reduce bandwidth consumption for businesses. Enabled by default, static compression pre-compresses and saves static content like images on disk. When the content is requested by a compression-enabled client (virtually every desktop browsers), IIS serves the pre-compressed content without needing to take the step of compressing the content upon the client’s request. Administrators can also turn on dynamic compression, which compresses a response in real time for ASP.NET, PHP, ASP and other application frameworks. IIS puts additional control in the hands of administration by offering the ability to set compression strength relative to CPU usage.

## Dynamic Output Caching

To further improve performance for dynamic applications, IIS's output cache gives administrators the ability to cache dynamic content (output from an ASP.NET, Classic ASP, PHP or other dynamic pages) in memory, which provides significant performance gains by removing the step of running the script used to generate the dynamic output for each request. Administrators can configure the output cached based on query string values as well as HTTP headers sent from the client to the server. The output cache, along with SSL and Windows authentication, is deeply integrated with Windows kernel mode, providing the fastest possible experience.