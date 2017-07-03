---
title: "FTP Site Flush Log Method &lt;FlushLog&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;FlushLog&gt; method forces all entries in the FTP log buffer to be written from the buffer into the log file, emptying the buffer. &lt;Flush..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: a3b9e138-a9fb-4b7b-ba30-1bb1a53615b5
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.applicationhost/sites/site/ftpserver/flushlog
msc.type: config
---
FTP Site Flush Log Method &lt;FlushLog&gt;
====================
<a id="001"></a>
## Overview

The `<FlushLog>` method forces all entries in the FTP log buffer to be written from the buffer into the log file, emptying the buffer. `<FlushLog>` works at the FTP site level.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<ftpServer>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<ftpServer>` element that includes the `<FlushLog>` method was not modified in IIS 8.5. |
| IIS 8.0 | The `<ftpServer>` element that includes the `<FlushLog>` method was not modified in IIS 8.0. |
| IIS 7.5 | The `<ftpServer>` element that includes the `<FlushLog>` method shipped as a feature of IIS 7.5. |
| IIS 7.0 | The `<ftpServer>` element that includes the `<FlushLog>` method was introduced in FTP 7.0, which was a separate download for IIS 7.0. |
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
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will need to select     **FTP Extensibility** , in addition to     **FTP Service** .  
    [![](FlushLog/_static/image2.png)](FlushLog/_static/image1.png) .
5. Click **Next**, and then on the **Select features** page, click **Next** again.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, and then select **FTP Server**.   
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select     **FTP Extensibility** .   
    [![](FlushLog/_static/image4.png)](FlushLog/_static/image3.png)
4. Click **OK**.
5. Click **Close**.

### Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, expand **FTP Server**.
5. Select **FTP Service**.  
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select     **FTP Extensibility** .  
    [![](FlushLog/_static/image6.png)](FlushLog/_static/image5.png)
6. Click **Next**.
7. On the **Confirm Installation Selections** page, click **Install**.
8. On the **Results** page, click **Close**.

### Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. Expand **Internet Information Services**, and then **FTP Server**.
4. Select **FTP Service**.  
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select     **FTP Extensibility** .   
    [![](FlushLog/_static/image8.png)](FlushLog/_static/image7.png)
5. Click **OK**.

### Windows Server 2008 or Windows Vista

1. Download the installation package from the following URL: 

    - [https://www.iis.net/expand/FTP](https://www.iis.net/downloads/microsoft/ftp)
- Follow the instructions in the following walkthrough to install the FTP service: 

    - [Installing and Troubleshooting FTP 7](https://go.microsoft.com/fwlink/?LinkId=88547)

<a id="004"></a>
## How To

### How to flush the log buffer

There is no control in the IIS Manager that calls the `<FlushLog>` method. You can call the method programmatically using the sample code that is provided below

<a id="005"></a>
## Configuration

The `<ftpServer>` is configured at the site level.

### Attributes

Not applicable.

### Child Elements

Not applicable.

<a id="006"></a>
## Sample Code

The following examples enable you to flush the log buffers for an FTP site programmatically.

### C#

[!code-csharp[Main](FlushLog/samples/sample1.cs)]

### VB.NET

[!code-vb[Main](FlushLog/samples/sample2.vb)]

### JavaScript

[!code-javascript[Main](FlushLog/samples/sample3.js)]

### VBScript

[!code-vb[Main](FlushLog/samples/sample4.vb)]