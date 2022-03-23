---
title: "Sites &lt;sites&gt;"
author: rick-anderson
description: "Overview The &lt;sites&gt; section group contains configuration settings for all sites on an IIS 7 server. The &lt;sites&gt; element contains a collection of..."
ms.date: 09/26/2016
ms.assetid: d0f95664-c290-4a46-b89f-4fc757b93202
msc.legacyurl: /configreference/system.applicationhost/sites
msc.type: config
---
# Sites &lt;sites&gt;

<a id="001"></a>
## Overview

The `<sites>` section group contains configuration settings for all sites on an IIS 7 server. The `<sites>` element contains a collection of `<site>` elements. When you create a new Web site, IIS adds a `<site>` element to the collection.

Each `<site>` element contains configuration settings for a separate Web site hosted on your IIS 7 installation. For example, the Default Web Site and its settings are defined in a `<site>` element that is located between the opening and closing tags of the `<sites>` element; configuration elements for any additional site that you create are also located there.

The `<sites>` section group can also contain the `<siteDefaults>`, `<applicationDefaults>`, and `<virtualDirectoryDefaults>` elements. The `<siteDefaults>` element defines default configuration settings for any site running on the server, the `<applicationDefaults>` element defines default configuration settings for any application running on the server, and the `<virtualDirectoryDefaults>` element defines default configuration settings for any virtual directory running on the server.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<sites>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<sites>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<sites>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<sites>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<sites>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<sites>` collection replaces the IIS 6.0 **IIsWebServer** metabase object. |

<a id="003"></a>
## Setup

The `<sites>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

When you configure a new Web site on IIS 7, you must assign the Web site a site name and a physical path. There are also a number of optional configuration settings you can set. If you plan to continue to use the Default Web Site on your IIS 7 server, you must alter the binding information for the new site. You can do this by changing either the port or entering a host name for the new Web site.

### How to create a new Web site

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
2. In the **Connections** pane, expand the server name, and then click **Sites**.
3. In the **Actions** pane, click **Add Web Site...**
4. In the **Add Web Site** dialog box, at a minimum, enter information in the **Site name** and **Physical path** text boxes and choose whether you want to enter information in the **Host name** text box or change the number in the **Port** box.  
    [![Screenshot of the Add Web Site dialog box showing the Site Name and Physical path fields.](index/_static/image2.png)](index/_static/image1.png)
5. On IIS Manager click the refresh button to verify that the site has started.

<a id="005"></a>
## Configuration

You configure the `<sites>` element at the server level in the ApplicationHost.config file.

### Attributes

None.

### Child Elements

| Element | Description |
| --- | --- |
| [`applicationDefaults`](applicationdefaults.md) | Optional element.<br><br>Specifies default settings for all applications on the server. |
| [`site`](site/index.md) | Optional element.<br><br>Specifies configuration settings for a site. |
| [`siteDefaults`](sitedefaults/index.md) | Optional element.<br><br>Specifies default settings for all sites on the server. |
| [`virtualDirectoryDefaults`](virtualdirectorydefaults.md) | Optional element.<br><br>Specifies default settings for all virtual directories on the server. |

### Configuration Sample

The following default `<sites>` element is configured in the root ApplicationHost.config file in IIS 7.

[!code-xml[Main](index/samples/sample1.xml)]

### Compatibility

In combination with the `<site>` element, the `<sites>` element replaces the IIS 6.0 **IIsWebServer** metabase property.

<a id="006"></a>
## Sample Code

The following examples create a new Web site named Contoso with an ID of 2, and sets a binding for the HTTP protocol over port 80 with a host header of &quot;www.contoso.com&quot;. The physical path for the new Web site is C:\Inetpub\www.contoso.com\wwwroot.

### AppCmd.exe

[!code-console[Main](index/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C\#

[!code-csharp[Main](index/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample5.js)]

### VBScript

[!code-vb[Main](index/samples/sample6.vb)]
