---
title: "WebDAV &lt;webdav&gt;"
author: rick-anderson
description: "Overview The &lt;webdav&gt; element contains the settings that configure Web Distributed Authoring and Versioning (WebDAV) for Internet Information Services..."
ms.date: 09/26/2016
ms.assetid: a21925ef-db5a-47fd-a931-16c3bb223128
msc.legacyurl: /configreference/system.webserver/webdav
msc.type: config
---
WebDAV &lt;webdav&gt;
====================
<a id="001"></a>
## Overview

The `<webdav>` element contains the settings that configure Web Distributed Authoring and Versioning (WebDAV) for Internet Information Services (IIS) 7. WebDAV is an Internet-based open standard that enables editing Web sites over HTTP and HTTPS connections. WebDAV yields several advantages over the File Transfer Protocol (FTP), the most notable advantages are more security options and the ability to use a single TCP port for all communication.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<webdav>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<webdav>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<webdav>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<webdav>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<webdav>` element was introduced in WebDAV 7.0, which was a separate download for IIS 7.0. |
| IIS 6.0 | N/A |

> [!NOTE]
> The WebDAV 7.0 and WebDAV 7.5 modules shipped out-of-band for IIS 7.0, which required downloading and installing the modules from the following URL:
>
> [https://www.iis.net/expand/WebDAV](https://www.iis.net/downloads/microsoft/webdav)

With Windows 7 and Windows Server 2008 R2, the WebDAV 7.5 module ships as a feature for IIS 7.5, so downloading WebDAV is no longer necessary.

<a id="003"></a>
## Setup

To support WebDAV publishing for your Web server, you must install the WebDAV module. To do so, use the following steps.

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**.
2. In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**.
3. In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**.
4. On the **Server Roles** page, expand **Web Server (IIS)**, expand **Web Server**, expand **Common HTTP Features**, and then select **WebDAV Publishing**. Click **Next**.  
    ![](index/_static/image1.png)
5. On the **Select features** page, click **Next**.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Common HTTP Features**, and then select **WebDAV Publishing**.  
    ![](index/_static/image3.png)
4. Click **OK**.
5. Click **Close**.

### Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, expand **Common HTTP Features**, select **WebDAV Publishing**, and then click **Next**.  
    ![](index/_static/image5.png)
5. On the **Confirm Installation Selections** page, click **Install**.
6. On the **Results** page, click **Close**.

### Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. Expand **Internet Information Services**, then **World Wide Web Services**, and then **Common HTTP Features**.
4. Select **WebDAV Publishing**, and then click **OK**.  
    ![](index/_static/image7.png)

### Windows Server 2008 or Windows Vista

- Download the installation package from the following URL:

  - [https://www.iis.net/expand/WebDAV](https://www.iis.net/downloads/microsoft/webdav)
- Follow the instructions in the following walkthrough to install the WebDAV module:

  - [Installing and Configuring WebDAV on IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=105146)

<a id="004"></a>
## How To

### How to enable WebDAV publishing

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
2. In the **Connections** pane, expand the server name, and then go to the site, application, or directory where you want to enable WebDAV publishing.
3. In the **Home** pane, double-click **WebDAV Authoring Rules**.  
    ![](index/_static/image9.png)
4. In the **Actions** pane, click **Enable WebDAV**.  
    ![](index/_static/image11.png)

> [!NOTE]
> Once you have enabled WebDAV publishing, you will need to add authoring rules before users or groups can publish content to your server. For more information about how to create authoring rules, see the [`authoringRules`](authoringrules/index.md) topic.

* * *

### How to add WebDAV authoring rules

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
2. In the **Connections** pane, expand the server name, and then go to the site, application, or directory where you want to enable directory browsing.
3. In the **Home** pane, double-click **WebDAV Authoring Rules**.  
    ![](index/_static/image13.png)
4. In the **Actions** pane, click **Add Authoring Rule...**  
    ![](index/_static/image15.png)
5. In the **Add Authoring Rule** dialog, specify the following options:

    - **Allow access to**: Specify whether the authoring rule should apply to all content types, or specify specific content types to allow.
    - **Allow access to this content to**: Specify whether the authoring rule should apply to all users, to specific groups or roles, or to specific users.
    - **Permissions**: Specify whether the authoring rule should allow **Read**, **Write**, or **Source** access for the specified content types and users.  
        ![](index/_static/image17.png)
6. Click **OK**.

<a id="005"></a>
## Configuration

The `<webdav>` element is configurable at the global, site, and directory level in the ApplicationHost.config file. WebDAV settings in Web.config files are ignored.

### Attributes

None.

### Child Elements

| Element | Description |
| --- | --- |
| [`authoring`](authoring/index.md) | Optional element.<br><br>Specifies the configuration settings for WebDAV authoring. |
| [`authoringRules`](authoringrules/index.md) | Optional element.<br><br>Specifies the authoring rules for WebDAV publishing. These rules specify the content types and authoring permissions for users or groups. |
| [`globalSettings`](globalsettings/index.md) | Optional element. Specifies the global settings for the WebDAV module. |

### Configuration Sample

The following example lists a sample `<webdav>` element for the Default Web Site. This example clears any existing authoring rules, adds a single rule for the administrators group, enables WebDAV authoring, specifies that hidden files are allowed, enables WebDAV locks and specifies the lock provider, and enables WebDAV properties and specifies the default XML namespace for property mapping.

[!code-xml[Main](index/samples/sample1.xml)]

The following example lists a sample `<globalSettings>` element for a WebDAV server. This example defines the built-in simple providers for locks and properties, and enables WebDAV locks for the server.

[!code-xml[Main](index/samples/sample2.xml)]

<a id="006"></a>
## Sample Code

The following examples enable WebDAV authoring for the Default Web Site, and configure the site so that SSL is not required for WebDAV authoring.

### AppCmd.exe

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

* * *

The following examples configure WebDAV authoring rules so that WebDAV clients can publish files that are not listed in the IIS MIME map, and add a single authoring rule that grants Read, Write, and Source access to the *administrators* group.

### AppCmd.exe

[!code-console[Main](index/samples/sample8.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C\#

[!code-csharp[Main](index/samples/sample9.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample10.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample11.js)]

### VBScript

[!code-vb[Main](index/samples/sample12.vb)]
