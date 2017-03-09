---
title: "Using Dynamic IP Restrictions | Microsoft Docs"
author: naziml
description: "The Dynamic IP Restrictions (DIPR) module for IIS 7.0 and above provides protection against denial of service and brute force attacks on web servers and web..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 02/16/2009
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/manage/configuring-security/using-dynamic-ip-restrictions
msc.type: authoredcontent
---
Using Dynamic IP Restrictions
====================
by [Nazim Lala](https://github.com/naziml)

## Introduction

The Dynamic IP Restrictions (DIPR) module for IIS 7.0 and above provides protection against denial of service and brute force attacks on web servers and web sites. To provide this protection, the module temporarily blocks IP addresses of HTTP clients that make an unusually high number of concurrent requests or that make a large number of requests over small period of time.

## Features

The Dynamic IP Restrictions module includes these key features:

- **Blocking of IP addresses based on number of concurrent requests** - If an HTTP client exceeds the number of concurrent requests allowed, that client's IP address gets temporarily blocked.
- **Blocking of IP address based on number of requests over a period of time** - If an HTTP client exceeds the number of requests made over a specified time interval, that client's IP address gets temporarily blocked.
- **Allow list of IP addresses that will not be blocked -** You can add a list of the IP addresses of clients you want to exclude from being blocked by the module regardless of other configuration.
- **Various deny actions** - You can specify which response to return to an HTTP client for which the IP address is blocked. The module can return status codes 403 and 404 or just terminate the HTTP connection and not return any response.
- **Support for web servers behind a proxy** - If your web server is behind a proxy, you can configure the module to use the client IP address from an X-Forwarded-For header.
- **IPv6** - the module provides full support for IPv6 addresses.

## Installing the DIPR module

You can use the Web Platform Installer (Web PI) to install the Dynamic IP Restrictions module, or you can download it from the download page.

### Getting Dynamic IP Restrictions

[Dynamic IP Restrictions download page](https://www.iis.net/downloads/microsoft/dynamic-ip-restrictions)   
  

### Prerequisites

You must have one of the following operating systems.

- Windows Server 2008
- Windows Vista SP1
- Windows Server 2008 R2
- Windows 7

### Uninstall the Beta version of the DIPR module

If you are using the **first** **Beta** release of the DIPR module, you must uninstall it before you install the Release Candidate, or an error will occur and the installation will fail. Make sure you back up your configuration before uninstalling the Beta version.  
  
If you are using the **Beta 2** release of the DIPR module you can upgrade directly to the final release. Your configuration settings will be preserved. 

## Configuring Dynamic IP Restrictions

The Dynamic IP Restrictions can be configured by using either IIS Manager, IIS configuration APIs or by using command line tool **appcmd**.

To access Dynamic IP Restriction settings in IIS Manager follow these steps:

1. Open IIS Manager
2. In the left-hand side tree view select server node if you want to configure server-wide settings, or select a site node to configure site-specific settings.
3. In the Features View click "Dynamic IP Restrictions"  
    ![](using-dynamic-ip-restrictions/_static/image1.jpg)
4. In the "Dynamic IP Restrictions" main page you can enable and specify the configuration for any of the features. To add an IP address to the Allow list you can click on the "Show Allowed Addresses" link on the right:  
    ![](using-dynamic-ip-restrictions/_static/image3.jpg)
5. Selecting the "Show Allowed Addresses" link above will bring up a window as shown below where you can see all the IP addresses that are allowed to bypass Dynamic IP Restriction validation. You can add more IP addresses to the list by selecting the "Add Allow Entry" link on the right.  
    ![](using-dynamic-ip-restrictions/_static/image5.jpg)

### Blocking of IP address based on number of concurrent requests

When using this option, the server will allow any client's IP address to make only a configurable number of concurrent requests. Any additional requests that exceed the specified limit will be denied.

A simple way to test this feature is to set the maximum number of concurrent requests to 2 by either using UI or by executing appcmd command:

[!code-console[Main](using-dynamic-ip-restrictions/samples/sample1.cmd)]

In the root folder of your web site create a file test.aspx and paste the following content into it:

[!code-aspx[Main](using-dynamic-ip-restrictions/samples/sample2.aspx)]

This ASP.NET page for 3 seconds before returning any response. Save the file and then open web browser, request `http://localhost/test.aspx` and then continuously hit F5 to refresh the browser. This will result in browser making more than 2 concurrent requests so as a result you will see the 403 - Forbidden error from server:

[![](using-dynamic-ip-restrictions/_static/image9.png)](using-dynamic-ip-restrictions/_static/image7.png)

> [!IMPORTANT]
> When configuring number of concurrent requests for a real web application, thoroughly test the limit that you pick to ensure that valid HTTP clients do not get blocked. This is especially important for Rich Internet Applications that have AJAX enabled web pages and serve media content.

### Blocking of IP addresses based on number of requests over time

When using this option the server will deny requests from any HTTP client's IP address that makes more than configurable number of requests over a period of time. The IP address will remain blocked until the number of requests within a time period drops below the configured limit.

To test this feature set the "Maximum number of requests" to 5 and "Time period" to 5000 by using either IIS Manager or by executing appcmd command:


[!code-console[Main](using-dynamic-ip-restrictions/samples/sample3.cmd)]


Open web browser, request `http://localhost/welcome.png` and then hit F5 to continuously refresh the page. This will generate more than 5 requests over 5 seconds so as a result you will see server responding with 403 - Forbidden status code:

[![](using-dynamic-ip-restrictions/_static/image13.png)](using-dynamic-ip-restrictions/_static/image11.png)

If you wait for another 5 seconds when all the previous requests have executed and then make a request, the request will succeed.

> [!IMPORTANT]
> When configuring number of allowed requests over time for a real web application, thoroughly test the limits that you pick to ensure that valid HTTP clients do not get blocked. This is especially important for Rich Internet Applications that have AJAX enabled web pages and serve media content.

### Deny Actions

The module can be configured to perform the following actions when denying requests for IP addresses:

- Send 403 (Forbidden) response to the client;
- Send 404 (File not found) response to the client;
- Abort request by closing the HTTP connection, without sending any response to the client.

### Support for web servers behind proxy

If your web servers are behind a firewall or proxy machine, then the client IP for all requests might show up as the IP of the proxy or firewall server. This would hamper the ability for Dynamic IP Restriction module to be useful. Most of such servers however add an X-Forwarded-For header in the HTTP request that contains the original client's IP address. Selecting the "Proxy" mode checkbox in the main Dynamic IP Restrictions configuration page will check for client IP address in this header first.
  
  
[Discuss in IIS Forums](https://forums.iis.net/1043.aspx)