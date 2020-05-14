---
title: "Always Allowed URLs &lt;alwaysAllowedUrls&gt;"
author: rick-anderson
description: "Overview The &lt;alwaysAllowedUrls&gt; element contains a collection of &lt;add&gt; elements that specify URLs that request filtering will allow, which overr..."
ms.date: 09/26/2016
ms.assetid: 3aadfcda-7027-4b2f-b05e-4688348f157e
msc.legacyurl: /configreference/system.webserver/security/requestfiltering/alwaysallowedurls
msc.type: config
---
Always Allowed URLs &lt;alwaysAllowedUrls&gt;
====================
<a id="001"></a>
## Overview

The `<alwaysAllowedUrls>` element contains a collection of [`<add>`](add.md) elements that specify URLs that request filtering will allow, which override the values in the [`<denyUrlSequences>`](../denyurlsequences/index.md) collection.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<alwaysAllowedUrls>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<alwaysAllowedUrls>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<alwaysAllowedUrls>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<alwaysAllowedUrls>` element of the `<requestFiltering>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<alwaysAllowedUrls>` element of the `<requestFiltering>` element was introduced as an update for IIS 7.0 that is available through [Microsoft Knowledge Base Article 957508](https://support.microsoft.com/kb/957508). |
| IIS 6.0 | The `<alwaysAllowedUrls>` element is roughly analogous to the **[AlwaysAllowedUrls]** section that was added to URLScan 3.0. |

<a id="003"></a>
## Setup

The default installation of IIS 7 and later includes the Request Filtering role service or feature. If the Request Filtering role service or feature is uninstalled, you can reinstall it using the following steps.

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**.
2. In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**.
3. In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**.
4. On the **Server Roles** page, expand **Web Server (IIS)**, expand **Web Server**, expand **Security**, and then select **Request Filtering**. Click **Next**.  
    [![](index/_static/image2.png)](index/_static/image1.png) .
5. On the **Select features** page, click **Next**.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Security**, and then select **Request Filtering**.  
    [![](index/_static/image4.png)](index/_static/image3.png)
4. Click **OK**.
5. Click **Close**.

### Windows Server 2008 or Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, select **Request Filtering**, and then click **Next**.
    [![](index/_static/image6.png)](index/_static/image5.png)
5. On the **Confirm Installation Selections** page, click **Install**.
6. On the **Results** page, click **Close**.

### Windows Vista or Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. Expand **Internet Information Services**, then **World Wide Web Services**, and then **Security**.
4. Select **Request Filtering**, and then click **OK**.
    [![](index/_static/image8.png)](index/_static/image7.png)

<a id="004"></a>
## How To

### How to always allow a URL

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
2. In the Connections pane, go to the connection, site, application, or directory for which you want to modify your request filtering settings.
3. In the **Home** pane, double-click **Request Filtering**.
4. In the **Request Filtering** pane, click the **URL** tab, then click **Allow URL...** in the **Actions** pane.
5. In the **Allow URL** dialog box, enter the URL that you wish to allow, and then click **OK**.

<a id="005"></a>
## Configuration

The `<alwaysAllowedUrls>` element of the `<requestFiltering>` element is configured at the site, application, or directory level.

### Attributes

None.

### Child Elements

| Element | Description |
| --- | --- |
| [`add`](add.md) | Optional element.<br><br>Adds a URL to the collection of URLs that request filtering will always allow. |
| `clear` | Optional element.<br><br>Clears the collection of URLs that request filtering will always allow. |
| `remove` | Optional element.<br><br>Removes a URL from the collection of URLs that request filtering will always allow. |

### Configuration Sample

The following sample illustrates a combination of a `<denyUrlSequences>` element and an `<alwaysAllowedUrls>` element that will deny any URLs if they contain either of two specific character sequences, but will always allow a specific URL that contains both of those two specific character sequences in a particular order.

[!code-xml[Main](index/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples demonstrate how to add a URL that will always be allowed on the Default Web Site.

### AppCmd.exe

[!code-console[Main](index/samples/sample2.cmd)]

### PowerShell

[!code-powershell[Main](index/samples/sample7.ps1)]

### C\#

[!code-csharp[Main](index/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample5.js)]

### VBScript

[!code-vb[Main](index/samples/sample6.vb)]
