---
title: "Bindings &lt;bindings&gt;"
author: rick-anderson
description: "Overview The &lt;bindings&gt; element configures binding information for an IIS 7 or later Web site. It can also define the default bindings for all sites on..."
ms.date: 09/26/2016
ms.assetid: be783951-68b0-4534-b5d7-0c2623646c1c
msc.legacyurl: /configreference/system.applicationhost/sites/site/bindings
msc.type: config
---
# Bindings &lt;bindings&gt;

<a id="001"></a>
## Overview

The `<bindings>` element configures binding information for an IIS 7 or later Web site. It can also define the default bindings for all sites on the Web server if it is included in the `<siteDefaults>` element.

This element can contain a collection of `<binding>` elements. Each element in the collection defines a separate set of binding information that a request can use to contact the Web site. For example, if your site requires users to contact it using both the HTTP protocol and the HTTPS protocol, you must define a binding for each protocol.

You can also use `<clear />` element in the `<bindings>` element to override binding defaults inherited from the server level `<siteDefaults>` element.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<bindings>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<bindings>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<bindings>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<bindings>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<bindings>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<bindings>` collection replaces sections of the **ServerBindings** property on the IIS 6.0 **IIsWebServer** metabase object. |

<a id="003"></a>
## Setup

The `<bindings>` element is included in the default installation of IIS 7 or later.

<a id="004"></a>
## How To

### How to add binding information to a site

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
2. In the **Connections** pane, expand the server name, expand **Sites**, and then click the Web site on which you want to configure the bindings.
3. In the **Actions** pane, click **Bindings...**
4. In the **Site Bindings** dialog box, click **Add...**  
    [![](index/_static/image2.png)](index/_static/image1.png)
5. In the **Add Site Binding** dialog box, add the binding information, and then click **OK**.  
    [![](index/_static/image4.png)](index/_static/image3.png)

<a id="005"></a>
## Configuration

You can add a `<bindings>` element for each site in the ApplicationHost.config file, which can contain a collection of individual `<binding>` elements that define the individual protocol bindings for the site. Each site will need at least one HTTP or HTTPS binding to be viewable over the Internet.

You can also use `<clear />` element in the `<bindings>` element to override binding defaults inherited from the server level `<siteDefaults>` element.

### Attributes

None.

### Child Elements

| Element | Description |
| --- | --- |
| [`binding`](binding.md) | Optional element.<br><br>Configures a binding in the parent site. |
| `clear` | Optional element.<br><br>Clears references to default settings that are inherited from the parent level of the configuration. |

### Configuration Sample

The following example defines a site named Contoso with two bindings. The first binding is for a hostname of &quot;www.contoso.com&quot; on port 80 for the IP address of 192.168.0.1, and the second binding is for an HTTPS binding for all IP addresses over port 443.

[!code-xml[Main](index/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples configure a site named Contoso with a hostname of &quot;www.contoso.com&quot; on port 80 for the IP address of 192.168.0.1, and an HTTPS binding for all IP addresses over port 443.

### AppCmd.exe

[!code-console[Main](index/samples/sample2.cmd)]

Or you can use:

[!code-console[Main](index/samples/sample3.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C\#

[!code-csharp[Main](index/samples/sample4.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample5.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample6.js)]

### VBScript

[!code-vb[Main](index/samples/sample7.vb)]
