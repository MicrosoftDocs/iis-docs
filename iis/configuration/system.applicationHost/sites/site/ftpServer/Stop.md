---
title: "FTP Site Stop Method &lt;Stop&gt;"
author: rick-anderson
description: "Overview The &lt;Stop&gt; of the &lt;ftpServer&gt; element stops the FTP site that &lt;ftpServer&gt; applies to. The run-time state for the FTP site can be d..."
ms.date: 09/26/2016
ms.assetid: ce4cb80f-ec43-47a9-8296-c71e0256b41a
msc.legacyurl: /configreference/system.applicationhost/sites/site/ftpserver/stop
msc.type: config
---
# FTP Site Stop Method &lt;Stop&gt;

<a id="001"></a>
## Overview

The `<Stop>` of the `<ftpServer>` element stops the FTP site that `<ftpServer>` applies to. The run-time state for the FTP site can be determined by the value of the state attribute.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<ftpServer>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<ftpServer>` element that includes the `<Stop>` method was not modified in IIS 8.5. |
| IIS 8.0 | The `<ftpServer>` element that includes the `<Stop>` method was not modified in IIS 8.0. |
| IIS 7.5 | The `<ftpServer>` element that includes the `<Stop>` method shipped as a feature of IIS 7.5. |
| IIS 7.0 | The `<ftpServer>` element that includes the `<Stop>` method was introduced in FTP 7.0, which was a separate download for IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

To support FTP publishing for your Web server, you must install the FTP service. To do so, use the following steps.

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**.
2. In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**.
3. In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**.
4. On the **Server Roles** page, expand **Web Server (IIS)**, and then select **FTP Server**.  
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will need to select **FTP Extensibility**, in addition to **FTP Service**.  
    [![](Stop/_static/image2.png)](Stop/_static/image1.png) .
5. Click **Next**, and then on the **Select features** page, click **Next** again.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, and then select **FTP Server**.   
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select **FTP Extensibility**.   
    [![](Stop/_static/image4.png)](Stop/_static/image3.png)
4. Click **OK**.
5. Click **Close**.

### Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, expand **FTP Server**.
5. Select **FTP Service**.  
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select **FTP Extensibility**.  
    [![](Stop/_static/image6.png)](Stop/_static/image5.png)
6. Click **Next**.
7. On the **Confirm Installation Selections** page, click **Install**.
8. On the **Results** page, click **Close**.

### Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. Expand **Internet Information Services**, and then **FTP Server**.
4. Select **FTP Service**.  
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select **FTP Extensibility**.   
    [![](Stop/_static/image8.png)](Stop/_static/image7.png)
5. Click **OK**.

### Windows Server 2008 or Windows Vista

1. Download the installation package from the following URL: 

    - [https://www.iis.net/expand/FTP](https://www.iis.net/downloads/microsoft/ftp)
2. Follow the instructions in the following walkthrough to install the FTP service: 

     - [Installing and Troubleshooting FTP 7](https://go.microsoft.com/fwlink/?LinkId=88547)

<a id="004"></a>
## How To

### How to stop an FTP site

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
2. In the **Connections** pane, expand the server name, expand the **Sites** node, and then click the name of the FTP site.
3. In the **Manage Website** section of the **Actions** pane, click **Stop**.

<a id="005"></a>
## Configuration

The site-specific `<ftpServer>` element is configured at the site-level.

### Attributes

Not applicable.

### Child Elements

Not applicable.

<a id="006"></a>
## Sample Code

The following examples enable you to stop an FTP site programmatically.

### C\#

[!code-csharp[Main](Stop/samples/sample1.cs)]

### VB.NET

[!code-vb[Main](Stop/samples/sample2.vb)]

### JavaScript

[!code-javascript[Main](Stop/samples/sample3.js)]

### VBScript

[!code-vb[Main](Stop/samples/sample4.vb)]
