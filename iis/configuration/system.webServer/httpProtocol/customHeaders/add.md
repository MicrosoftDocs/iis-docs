---
title: "Adding Custom Headers &lt;add&gt;"
author: rick-anderson
description: "Overview The &lt;add&gt; element of the &lt;customHeaders&gt; element specifies a custom HTTP header that Internet Information Services (IIS) 7 will return i..."
ms.date: 09/26/2016
ms.assetid: 6d2d4bb9-4185-4c5c-ba3e-4fe8b2d047f7
msc.legacyurl: /configreference/system.webserver/httpprotocol/customheaders/add
msc.type: config
---
Adding Custom Headers &lt;add&gt;
====================
<a id="001"></a>
## Overview

The `<add>` element of the `<customHeaders>` element specifies a custom HTTP header that Internet Information Services (IIS) 7 will return in HTTP responses from the Web server.

> [!NOTE]
> HTTP headers are name and value pairs that are returned in responses from a Web server. Custom response headers are sent to the client together with the default HTTP header. Unlike redirect response headers, which are returned in responses only when redirection occurs, custom response headers are returned in every response.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<add>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<add>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<add>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<add>` element of the `<customHeaders>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<customHeaders>` element replaces the IIS 6.0 **HttpCustomHeaders** metabase object. |

<a id="003"></a>
## Setup

The `<add>` element of the `<customHeaders>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

### How to set custom HTTP headers for a Web site or application

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
2. In the **Connections** pane, go to the site, application, or directory for which you want to set a custom HTTP header.
3. In the **Home** pane, double-click **HTTP Response Headers**.  
    [![](add/_static/image2.png)](add/_static/image1.png)
4. In the **HTTP Response Headers** pane, click **Add...** in the **Actions** pane.  
    [![](add/_static/image4.png)](add/_static/image3.png)
5. In the **Add Custom HTTP Response Header** dialog box, set the name and value for your custom header, and then click **OK**.  
    [![](add/_static/image6.png)](add/_static/image5.png)

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `name` | Required string attribute. <br><br>Specifies a field name for the custom response header. In a response, a field name precedes the related field value. |
| `Value` | Optional string attribute. <br><br>Specifies a field value for the custom response header. In a response, a field value follows the related field name. |

### Child Elements

None.

### Configuration Sample

The following configuration sample sets a custom HTTP header and value.

[!code-xml[Main](add/samples/sample1.xml)]

> [!NOTE]
> The following default `<httpProtocol>` element is configured in the ApplicationHost.config file in IIS 7.

[!code-xml[Main](add/samples/sample2.xml)]

<a id="006"></a>
## Sample Code

The following code samples set a custom HTTP header and value.

### AppCmd.exe

[!code-console[Main](add/samples/sample3.cmd)]

### C#

[!code-csharp[Main](add/samples/sample4.cs)]

### VB.NET

[!code-vb[Main](add/samples/sample5.vb)]

### JavaScript

[!code-javascript[Main](add/samples/sample6.js)]

### VBScript

[!code-vb[Main](add/samples/sample7.vb)]