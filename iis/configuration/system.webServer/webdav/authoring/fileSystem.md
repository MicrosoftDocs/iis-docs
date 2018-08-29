---
title: "WebDAV File System &lt;fileSystem&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;fileSystem&gt; element of the &lt;authoring&gt; element specifies how the WebDAV module interacts with the underlying file system. More spec..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: 5c844139-1366-4177-af23-d998aa0f9024
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.webserver/webdav/authoring/filesystem
msc.type: config
---
WebDAV File System &lt;fileSystem&gt;
====================
<a id="001"></a>
## Overview

The `<fileSystem>` element of the `<authoring>` element specifies how the WebDAV module interacts with the underlying file system. More specifically, the `<fileSystem>` element contains attributes that define whether file operations should be transactional, and whether hidden files or virtual directories will be returned in property requests, which are commonly used for directory listings.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<fileSystem>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<fileSystem>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<fileSystem>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<fileSystem>` element of the `<authoring>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<fileSystem>` element of the `<authoring>` element was introduced in WebDAV 7.0, which was a separate download for IIS 7.0. |
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

1. On the taskbar, click **Server Manager**. - In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**. - In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**. - On the **Server Roles** page, expand **Web Server (IIS)**, expand **Web Server**, expand **Common HTTP Features**, and then select **WebDAV Publishing**. Click **Next**.  
    [![](fileSystem/_static/image2.png)](fileSystem/_static/image1.png) . - On the **Select features** page, click **Next**. - On the **Confirm installation selections** page, click **Install**. - On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**. - In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**. - Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Common HTTP Features**, and then select **WebDAV Publishing**.  
    [![](fileSystem/_static/image4.png)](fileSystem/_static/image3.png)- Click **OK**.
2. Click **Close**.

### Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**. - In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**. - In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**. - On the **Select Role Services** page of the **Add Role Services Wizard**, expand **Common HTTP Features**, select **WebDAV Publishing**, and then click **Next**.   
    [![](fileSystem/_static/image6.png)](fileSystem/_static/image5.png)- On the **Confirm Installation Selections** page, click **Install**. - On the **Results** page, click **Close**.

### Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**. - In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**. - Expand **Internet Information Services**, then **World Wide Web Services**, and then **Common HTTP Features**. - Select **WebDAV Publishing**, and then click **OK**.   
    [![](fileSystem/_static/image8.png)](fileSystem/_static/image7.png)

### Windows Server 2008 or Windows Vista

- Download the installation package from the following URL: 

    - [https://www.iis.net/expand/WebDAV](https://www.iis.net/downloads/microsoft/webdav)
- Follow the instructions in the following walkthrough to install the WebDAV module: 

    - [Installing and Configuring WebDAV on IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=105146)

<a id="004"></a>
## How To

### How to allow hidden files to be listed in WebDAV responses

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
    [![](fileSystem/_static/image10.png)](fileSystem/_static/image9.png)
4. In the **Actions** pane, click **WebDAV Settings...**
5. In the **WebDAV Settings** pane, choose select **True** for **Allow Hidden Files to be Listed** if you want properties for hidden files to be returned in property responses; otherwise, choose **False**.  
    [![](fileSystem/_static/image12.png)](fileSystem/_static/image11.png)
6. Click **Apply** in the **Actions** pane.

<a id="005"></a>
## Configuration

The `<fileSystem>` element is configurable only at the site level in the ApplicationHost.config file. Any `<fileSystem>` elements at other levels or in Web.config files are ignored.

### Attributes

| Attribute | Description |
| --- | --- |
| `allowHiddenFiles` | Optional **Boolean** attribute. **true** if WebDAV will display hidden files in the responses to property requests; otherwise, **false**. <br><br> **Note:** Even though files may be hidden from property requests, they can still be requested directly. For example, if you hid the Web.config file for your Web site, it would not be displayed in directory listings, but you could still open the file in a WebDAV-based editor if you knew that the path existed. The default value is `false`. |
| `useTransactionalIo` | Optional **Boolean** attribute. The `useTransactionalIo` attribute specifies whether file operations should be transactional. For example, transactional processing helps to define what a server's behavior should be if a client sends a MOVE request for a series of files and the destination runs out of storage space before the entire operation has completed. With transactional processing enabled, the entire operation should fail. When transactional processing is disabled, the operation will only partially succeed and files will be distributed between the source and destination. <br><br> When set to **false**, the WebDAV module will not enforce any form of transactional processing. When set to **true**, the WebDAV module will enforce transactional processing by failing the operation if the base file system cannot transactions. The default value is `false`. |
| `hideChildVirtualDirectories` | Optional **Boolean** attribute.<br><br>**true** if virtual directories are hidden from WebDAV requests; otherwise, **false**.<br><br>**Note:** This attribute was added in WebDAV 7.5 and IIS 7.5.<br><br>The default value is `false`. |

### Child Elements

None.

### Configuration Sample

The following example lists a sample `<webdav>` element for the Default Web Site. This example clears any existing authoring rules, adds a single rule for the administrators group, enables WebDAV authoring, specifies that hidden files are allowed, enables WebDAV locks and specifies the lock provider, and enables WebDAV properties and specifies the default XML namespace for property mapping.

[!code-xml[Main](fileSystem/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples configure the WebDAV file system settings so that hidden files and virtual directories will be returned in property query responses.

### AppCmd.exe

[!code-console[Main](fileSystem/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](fileSystem/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](fileSystem/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](fileSystem/samples/sample5.js)]

### VBScript

[!code-vb[Main](fileSystem/samples/sample6.vb)]