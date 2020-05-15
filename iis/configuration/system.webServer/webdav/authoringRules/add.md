---
title: "Adding WebDAV Authoring Rules &lt;add&gt;"
author: rick-anderson
description: "Overview The &lt;add&gt; element of the &lt;authoringRules&gt; element specifies the access permissions for users or groups for specific content types for a..."
ms.date: 09/26/2016
ms.assetid: 240dc172-5731-4212-b47e-9835f2842ec3
msc.legacyurl: /configreference/system.webserver/webdav/authoringrules/add
msc.type: config
---
# Adding WebDAV Authoring Rules &lt;add&gt;

<a id="001"></a>

## Overview

The `<add>` element of the [`<authoringRules>`](index.md) element specifies the access permissions for users or groups for specific content types for a unique authoring rule.

Authoring rules can be defined per-URI within a Web site, and specifies the WebDAV authoring permissions for that URI space. The permissions in this element are inherited, so child URIs will have the same permissions as a parent URI, provided that the child URI does not have unique permissions defined.

<a id="002"></a>

## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<add>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<add>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<add>` element of the `<authoringRules>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<add>` element of the `<authoringRules>` element was introduced in WebDAV 7.0, which was a separate download for IIS 7.0. |
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
    ![](add/_static/image1.png)
5. On the **Select features** page, click **Next**.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Common HTTP Features**, and then select **WebDAV Publishing**.  
    ![](add/_static/image3.png)
4. Click **OK**.
5. Click **Close**.

### Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, expand **Common HTTP Features**, select **WebDAV Publishing**, and then click **Next**.   
    ![](add/_static/image5.png)
5. On the **Confirm Installation Selections** page, click **Install**.
6. On the **Results** page, click **Close**.

### Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. Expand **Internet Information Services**, then **World Wide Web Services**, and then **Common HTTP Features**.
4. Select **WebDAV Publishing**, and then click **OK**.   
    ![](add/_static/image7.png)

### Windows Server 2008 or Windows Vista

- Download the installation package from the following URL: 

    - [https://www.iis.net/expand/WebDAV](https://www.iis.net/downloads/microsoft/webdav)
- Follow the instructions in the following walkthrough to install the WebDAV module: 

    - [Installing and Configuring WebDAV on IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=105146)

<a id="004"></a>

## How To

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
    ![](add/_static/image9.png)
4. In the **Actions** pane, click **Add Authoring Rule...**  
    ![](add/_static/image11.png)
5. In the **Add Authoring Rule** dialog, specify the following options: 

    - **Allow access to**: Specify whether the authoring rule should apply to all content types, or specify specific content types to allow.
    - **Allow access to this content to**: Specify whether the authoring rule should apply to all users, to specific groups or roles, or to specific users.
    - **Permissions**: Specify whether the authoring rule should allow **Read**, **Write**, or **Source** access for the specified content types and users.  
        ![](add/_static/image13.png)
6. Click **OK**.

<a id="005"></a>

## Configuration

The `<authoringRules>` element is configurable per-URI in the ApplicationHost.config file. Settings can be stored globally, at the site level, or per folder. The `<authoringRules>` element cannot be delegated, so any `<authoringRules>` elements in Web.config files are ignored.

### Attributes

| Attribute | Description |
| --- | --- |
| `access` | Optional flags attribute.<br><br>Specifies the access settings for the authoring rule. These values combined with a logical OR operation, so "None, Read" = "Read."<br><br>**Note:** `Source` access allows a WebDAV client to request the contents of a script-mapped file, such as an ASP.NET or PHP file, as opposed to the processed output of the file. <table> <tbody> <tr> <th>Value</th> <th>Description</th></tr> <tr> <th><code>None</code></th> <td>No authoring is allowed.<br><br>The numeric value is <code>0</code>.</td></tr> <tr> <th><code>Read</code></th> <td>Read access is allowed.<br><br>The numeric value is <code>1</code>.</td></tr> <tr> <th><code>Write</code></th> <td>Write access is allowed.<br><br>The numeric value is <code>2</code>.</td></tr> <tr> <th><code>Source</code></th> <td>Access to source code is allowed.<br><br>The numeric value is <code>16</code>.</td></tr></tbody></table>The default value is `None`. |
| `path` | Optional string attribute.<br><br>Specifies the file name or the file name extension for which the authoring rule applies. For example, "\*.aspx", "\*.php", etc. In addition, the following special identifiers have been defined. <table> <tbody> <tr> <th>Value</th> <th>Description</th></tr> <tr> <th><code>*</code></th> <td>Specifies that the rule will apply to all content.</td></tr></tbody></table>There is no default value. |
| `roles` | Optional string attribute.<br><br>Specifies roles or groups for an authorization rule. Multiple roles can be added in a comma-separated list.<br><br>There is no default value. |
| `users` | Optional string attribute.<br><br>Specifies users for an authorization rule. Multiple users can be added in a comma-separated list. In addition, the following special identifiers have been defined. <table> <tbody> <tr> <th>Value</th> <th>Description</th></tr> <tr> <th><code>*</code></th> <td>Specifies that the rule will apply to all users.</td></tr> <tr> <th><code>?</code></th> <td>Specifies that the rule will apply to anonymous users.</td></tr></tbody></table>There is no default value. |

### Child Elements

None.

### Configuration Sample

The following example lists a sample `<webdav>` element for the Default Web Site. This example clears any existing authoring rules, adds a single rule for the administrators group, enables WebDAV authoring, specifies that hidden files are allowed, enables WebDAV locks and specifies the lock provider, and enables WebDAV properties and specifies the default XML namespace for property mapping.

[!code-xml[Main](add/samples/sample1.xml)]

<a id="006"></a>

## Sample Code

The following examples configure WebDAV authoring rules so that WebDAV clients can publish files that are not listed in the IIS MIME map, and add a single authoring rule that grants Read, Write, and Source access to the *administrators* group.

### AppCmd.exe

[!code-console[Main](add/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C\#

[!code-csharp[Main](add/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](add/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](add/samples/sample5.js)]

### VBScript

[!code-vb[Main](add/samples/sample6.vb)]
