---
title: "Adding Caching Profiles &lt;add&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;add&gt; element of the &lt;profiles&gt; element adds an output caching profile to the collection of output caching profiles. Compatibility V..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: 
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.webserver/caching/profiles/add
msc.type: config
---
Adding Caching Profiles &lt;add&gt;
====================
<a id="001"></a>
## Overview

The `<add>` element of the `<profiles>` element adds an output caching profile to the collection of output caching profiles.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<add>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<add>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<add>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<add>` element of the `<profiles>` element was introduced in IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

The `<add>` element of the `<profiles>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

### How to configure page output caching

1. Open **Internet Information Services (IIS) Manager**: 

    - If you are using Windows Server 2012 or Windows Server 2012 R2: 

        - On the taskbar, click **Server Manager**, click **Tools**, and then click **Internet Information Services (IIS) Manager**.
    - If you are using Windows 8 or Windows 8.1: 

        - Hold down the **Windows** key, press the letter **X**, and then click **Control Panel**.
        - Click **Administrative Tools**, and then double-click **Internet Information Services (IIS) Manager**.
    - If you are using Windows Server 2008 or Windows Server 2008 R2: 

        - On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Internet Information Services (IIS) Manager**.
    - If you are using Windows Vista or Windows 7: 

        - On the taskbar, click **Start**, and then click **Control Panel**.
        - Double-click **Administrative Tools**, and then double-click **Internet Information Services (IIS) Manager**.
2. In the **Connections** pane, go to the connection, site, application, or directory for which you want to configure page output caching.
3. In the **Home** pane, scroll to **Output Caching**, and then double-click **Output Caching**.  
    [![](add/_static/image2.png)](add/_static/image1.png)
4. In the **Actions** pane, click **Add...**
5. In the **Add Cache Rule** dialog box, type the file name extension you want to cache in the **File name extension** box, and then select the **User-mode caching** option, the **Kernel-mode caching** option, or both.
6. Select the options that you want to use for caching, and then click **OK**.  
    [![](add/_static/image4.png)](add/_static/image3.png)

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `duration` | Optional timeSpan attribute. Specifies the time (in seconds) that the page or user control is cached The default is `00:00:30`. |
| `extension` | Required string attribute. Specifies the file name extension for the files you want to cache. |
| `kernelCachePolicy` | Optional enum attribute. Configures the kernel caching policy. The **kernelCachePolicy** attribute can be one of the following values. The default is `DontCache`. | Value | Description | | --- | --- | | `DontCache` | Content is not cached. The numeric value is `0`. | | `CacheUntilChange` | Content is only cached until the content changes. The numeric value is `1`. | | `CacheForTimePeriod` | Content is cached for the length of time specified by the duration attribute. The numeric value is `2`. | | `DisableCache` | The cache is disabled and no caching will occur. The numeric value is `3`. | |
| `location` | Optional enum attribute. Specifies the valid values for controlling the location of the output-cached HTTP response for a resource. The **location** attribute can be one of the following possible values. The default is `Server`. | Value | Description | | --- | --- | | `Any` | The output cache can be located on the browser client (where the request originated), on a proxy server (or any other server) participating in the request, or on the server where the request was processed. The numeric value is `0`. | | `Client` | The output cache is located on the browser client where the request originated. The numeric value is `1`. | | `Downstream` | The output cache can be stored in any HTTP 1.1 cache-capable devices other than the origin server. This includes proxy servers and the client that made the request. The numeric value is `2`. | | `Server` | The output cache is located on the Web server where the request was processed. The numeric value is `3`. | | `None` | The output cache is disabled for the requested page. The numeric value is `4`. | | `ServerAndClient` | The output cache can be stored only at the origin server or at the requesting client. Proxy servers are not allowed to cache the response. The numeric value is `5`. | |
| `policy` | Optional enum attribute. Configures the output caching policy. The **policy** attribute can be one of the following possible values. The default is `DontCache`. | Value | Description | | --- | --- | | `DontCache` | Content is not cached. The numeric value is `0`. | | `CacheUntilChange` | Content is only cached until the content changes. The numeric value is `1`. | | `CacheForTimePeriod` | Content is cached for the length of time specified by the duration attribute. The numeric value is `2`. | | `DisableCache` | The cache is disabled and no caching will occur. The numeric value is `3`. | |
| `varyByHeaders` | Optional string attribute. Specifies a semicolon-separated list of HTTP headers used to vary the output cache. When this attribute is set to multiple headers, the output cache contains a different version of the requested document for each combination of specified headers. |
| `varyByQueryString` | Optional string attribute. Specifies a semicolon-separated list of strings used to vary the output cache. By default, these strings correspond to a query string value sent with **GET** method attributes, or a parameter sent by using the **POST** method. When this attribute is set to multiple parameters, the output cache contains a different version of the requested document for each combination of specified parameters. Possible values include none, an asterisk (**\***), and any valid query string or **POST** parameter name. |

### Child Elements

None.

### Configuration Sample

The following configuration example enables user-mode caching and kernel-mode caching, both of which are enabled by default in IIS 7.0. It also uses the `<add>` element contained by the `<profiles>` element to enable output caching for files with the .asp file name extension. It also uses the **policy** attribute to output cache the page until it changes; it does the same for kernel caching using the **kernelCachePolicy** attribute.

[!code-xml[Main](add/samples/sample1.xml)]

The following code example sets the maximum output cache size to 1 gigabyte and sets the maximum size of a response that can be stored in the output cache to 512 kilobytes.

[!code-xml[Main](add/samples/sample2.xml)]

<a id="006"></a>
## Sample Code

The following examples configure page output caching for files with the .asp file name extension, and configure IIS to cache in user mode and kernel mode until ASP files change.

### AppCmd.exe

[!code-console[Main](add/samples/sample3.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](add/samples/sample4.cs)]

### VB.NET

[!code-vb[Main](add/samples/sample5.vb)]

### JavaScript

[!code-javascript[Main](add/samples/sample6.js)]

### VBScript

[!code-vb[Main](add/samples/sample7.vb)]