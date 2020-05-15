---
title: "Adding Initialization Page <add> &lt;add&gt;"
author: rick-anderson
description: "Overview The &lt;add&gt; element under the &lt;applicationInitialization&gt; element specifies the application to be initialized upon application restart. To..."
ms.date: 09/26/2016
ms.assetid: 3260fd7d-7dd2-466b-bd30-b18c0b6c5cde
msc.legacyurl: /configreference/system.webserver/applicationinitialization/add
msc.type: config
---
# Adding Initialization Page <add> &lt;add&gt;

<a id="001"></a>

## Overview

The `<add>` element under the `<applicationInitialization>` element specifies the application to be initialized upon application restart. To perform the application initialization process, IIS sends a fake request to the application to prompt the initialization. Multiple application URLs can be specified by using multiple &lt;add&gt; tags. These applications are not served to a requester. The page specified by the remapManagedRequestsTo attribute in the `<applicationInitialization>` element will be served to the customer.

<a id="002"></a>

## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<add>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<add>` element was introduced in IIS 8.0. |
| IIS 7.5 | N/A |
| IIS 7.0 | N/A |
| IIS 6.0 | N/A |

<a id="003"></a>

## Setup

To support application initialization on your Web server, you must install the Application Initialization role or feature.

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**.
2. In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**.
3. In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**.
4. On the **Server Roles** page, expand **Web Server (IIS)**, expand **Web Server**, expand **Application Development**, and then select **Application Initialization**. Click **Next**.  
    [![](add/_static/image2.png)](add/_static/image1.png) .
5. On the **Select Features** page, click **Next**.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Application Development Features**, and then select **Application Initialization**.  
    [![](add/_static/image4.png)](add/_static/image3.png)
4. Click **OK**.
5. Click **Close**.

<a id="004"></a>

## How To

### How to configure application initialization

1. Open **Internet Information Services (IIS) Manager**: 

    - If you are using Windows Server 2012 or later: 

        - On the taskbar, click **Server Manager**, click **Tools**, and then click **Internet Information Services (IIS) Manager**.
    - If you are using Windows 8 or later: 

        - Hold down the **Windows** key, press the letter **X**, and then click **Control Panel**.
        - Click **Administrative Tools**, and then double-click **Internet Information Services (IIS) Manager**.
2. In the **Connections** pane, select the server, or expand the server, expand **Sites**, and then select a site.
3. In the **Home** pane, double-click the **Configuration Editor** feature.
4. If you selected a site, select **&lt;site name&gt; Web.config** in the **From** text box, and then select **system.webServer/applicationInitialization** in the **Section** text box.
5. If you selected the server, select **system.webServer/applicationInitialization** in the **Section** text box.  
  
    [![](add/_static/image6.png)](add/_static/image5.png)
6. To specify the name of a static file to be returned during initialization, set **remapManagedRequestsTo** to the name of the file.
7. If you do not want to load managed modules, set **skipManagedModules** to **true**.
8. To specify that the initialization process is initiated automatically whenever an application restart occurs, set **doAppInitAfterRestart** to **true**.
9. To specify the application or applications to be initialized upon application restart, click the **(Collection)** line and then click the ellipsis.
10. In the Collection Editor, to add an application to be initialized, click **Add**, click **hostName**, and then set hostName to the name of the host. Click **initializationPage** and set it to a URL for the application. Close the dialog box.  
  
    [![](add/_static/image8.png)](add/_static/image7.png)
11. Click **Apply** in the **Actions** pane.

<a id="005"></a>

## Configuration

The `<add>` element of the `<applicationInitialization>` element is configured at the server, site, or application level.

### Attributes

| Attribute | Description |
| --- | --- |
| `initializationPage` | Required string attribute.<br><br>Specifies the URL of an application to be initialized upon application restart. <br><br>The default value is `""`. |
| `hostName` | Optional string attribute.<br><br>A host name to be used with the application URL provided in the initializationPage attribute.<br><br>The default value is `""`. |

### Child Elements

None.

### Configuration Sample

The following sample shows configuration of application initialization.

[!code-xml[Main](add/samples/sample1.xml)]

<a id="006"></a>

## Sample Code

The following examples configure **&lt;applicationInitialization&gt;** for a site.

### AppCmd.exe

[!code-console[Main](add/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when using AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C\#

[!code-csharp[Main](add/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](add/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](add/samples/sample5.js)]
  
### VBScript

[!code-vb[Main](add/samples/sample6.vb)]

### PowerShell

[!code-powershell[Main](add/samples/sample7.ps1)]
