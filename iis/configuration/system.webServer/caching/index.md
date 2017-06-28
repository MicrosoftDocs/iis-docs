---
title: "Caching &lt;caching&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;caching&gt; element allows you to enable or disable page output caching for an Internet Information Services (IIS) 7 application. This eleme..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: 
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.webserver/caching
msc.type: config
---
Caching &lt;caching&gt;
====================
<a id="001"></a>
## Overview

The `<caching>` element allows you to enable or disable page output caching for an Internet Information Services (IIS) 7 application. This element also allows you to configure whether IIS caches page output in user mode, kernel mode, or both and what, if any, output caching limits you want to impose.

The `<caching>` element also contains a `<profiles>` element that contains a collection of output cache settings that you can apply to ASP.NET pages.

Page output caching stores a response of a dynamic page, such as an ASP page or an ASP.NET page, in memory after a browser requests it. When subsequent requests arrive for the page, the server sends the cached response instead of re-processing the page. The ASP.NET page output cache is separate from the IIS 7 output cache. In applications that use the Integrated ASP.NET mode, the ASP.NET page output cache can be used programmatically for any content-type, much like the IIS 7 output cache.

Page output caching reduces server load and response time. Output caching works best with pages that are semi-dynamic, such as an ASP.NET page that is dependent on a database table that does not change often.

Output caching is unnecessary for static files, such as HTML, JPG, or GIF files, and can cause more memory overhead for dynamic ASP.NET or PHP pages that read from a database that changes frequently.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<caching>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<caching>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<caching>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<caching>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<caching>` element was introduced in IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

The `<caching>` element is included in the default installation of IIS 7.

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
    [![](index/_static/image2.png)](index/_static/image1.png)
4. In the **Actions** pane, click **Add...**
5. In the **Add Cache Rule** dialog box, type the file name extension you want to cache in the **File name extension** box, and then select the **User-mode caching** option, the **Kernel-mode caching** option, or both.
6. Select the options that you want to use for caching, and then click **OK**.  
    [![](index/_static/image4.png)](index/_static/image3.png)

<a id="005"></a>
## Configuration

You can configure the `<caching>` element at the server level in the ApplicationHost.config file or at the site, application, or at the directory level in a Web.config file.

### Attributes

| Attribute | Description |
| --- | --- |
| `enabled` | Optional Boolean attribute.<br><br>Specifies whether page output caching is enabled.<br><br>The default value is `true`. |
| `enableKernelCache` | Optional Boolean attribute.<br><br>Specifies whether kernel caching is enabled.<br><br>The default value is `true`. |
| `maxCacheSize` | Optional uint attribute.<br><br>Specifies the maximum size of the output cache.<br><br>**Note:** This setting is effective only at the level of the ApplicationHost.config file. If you set this property at a lower level, it will have no effect.<br><br>The default value is `0`. |
| `maxResponseSize` | Optional uint attribute.<br><br>Specifies the maximum response size that can be cached.<br><br>**Note:** This setting is effective only at the level of the ApplicationHost.config file. If you set this property at a lower level, it will have no effect.<br><br>The default value is `262144`. |

### Child Elements

| Element | Description |
| --- | --- |
| [`profiles`](profiles/index.md) | Optional element.<br><br>Contains a group of output cache settings that can be applied to ASP.NET pages. |

### Configuration Sample

The following configuration example enables user-mode caching and kernel-mode caching, both of which are enabled by default in IIS 7.0. It also uses the `<add>` element contained by the `<profiles>` element to enable output caching for files with the .asp file name extension. It also uses the **policy** attribute to output cache the page until it changes; it does the same for kernel caching using the **kernelCachePolicy** attribute.

[!code-xml[Main](index/samples/sample1.xml)]

The following code example sets the maximum output cache size to 1 gigabyte and sets the maximum size of a response that can be stored in the output cache to 512 kilobytes.

[!code-xml[Main](index/samples/sample2.xml)]

<a id="006"></a>
## Sample Code

The following examples configure page output caching for files with the .asp file name extension, and configure IIS to cache in user mode and kernel mode until ASP files change.

### AppCmd.exe

[!code-console[Main](index/samples/sample3.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](index/samples/sample4.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample5.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample6.js)]

### VBScript

[!code-vb[Main](index/samples/sample7.vb)]