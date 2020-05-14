---
title: "Default FTP Command Filtering Settings &lt;commandFiltering&gt;"
author: rick-anderson
description: "Overview The &lt;commandFiltering&gt; element specifies a collection of FTP commands that the FTP service will allow or deny. The &lt;commandFiltering&gt; el..."
ms.date: 09/26/2016
ms.assetid: 12408f8c-7458-408a-9bd2-fdd2c459911d
msc.legacyurl: /configreference/system.applicationhost/sites/sitedefaults/ftpserver/security/commandfiltering
msc.type: config
---
Default FTP Command Filtering Settings &lt;commandFiltering&gt;
====================
<a id="001"></a>
## Overview

The `<commandFiltering>` element specifies a collection of FTP commands that the FTP service will allow or deny. The `<commandFiltering>` element contains a collection of `<add>` statements that individually specify whether to allow or deny a specific FTP command.

> [!NOTE]
> Special attention must be applied when configuring which FTP commands to allow or deny, and whether to deny unlisted commands. For example, denying many commands like USER, PASS, PASV, PORT, etc., will make it impossible for your FTP site to function. Likewise, denying unlisted commands by default will probably be too restrictive and many FTP clients will be unable to access your FTP site.

The collection in the `<commandFiltering>` element is related to the [`<requestFiltering>`](../../../../../../system.ftpserver/security/requestfiltering/index.md) settings; however, while request filtering applies for files and directories and can be configured per URL, the settings under the `<commandFiltering>` element apply the protocol-level of processing and can only be configured at the site level.

Additional attributes for the `<commandFiltering>` element are `maxCommandLine` and `allowUnlisted`. Respectively, these configure the maximum command line length and whether to allow unlisted commands.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<commandFiltering>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<commandFiltering>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<commandFiltering>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<commandFiltering>` element of the `<security>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<commandFiltering>` element of the `<security>` element was introduced in FTP 7.0, which was a separate download for IIS 7.0. |
| IIS 6.0 | The FTP service in IIS 6.0 did not support command filtering. |

> [!NOTE]
> The FTP 7.0 and FTP 7.5 services shipped out-of-band for IIS 7.0, which required downloading and installing the modules from the following URL:
>
> [https://www.iis.net/expand/FTP](https://www.iis.net/downloads/microsoft/ftp)

With Windows 7 and Windows Server 2008 R2, the FTP 7.5 service ships as a feature for IIS 7.5, so downloading the FTP service is no longer necessary.

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
    [![](index/_static/image2.png)](index/_static/image1.png) .
5. Click **Next**, and then on the **Select features** page, click **Next** again.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, and then select **FTP Server**.
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select **FTP Extensibility**.
    [![](index/_static/image4.png)](index/_static/image3.png)
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
    [![](index/_static/image6.png)](index/_static/image5.png)
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
    [![](index/_static/image8.png)](index/_static/image7.png)
5. Click **OK**.

### Windows Server 2008 or Windows Vista

1. Download the installation package from the following URL:

    - [https://www.iis.net/expand/FTP](https://www.iis.net/downloads/microsoft/ftp)
2. Follow the instructions in the following walkthrough to install the FTP service:

     - [Installing and Troubleshooting FTP 7](https://go.microsoft.com/fwlink/?LinkId=88547)

<a id="004"></a>
## How To

### How to deny an FTP command for an FTP site by using command filtering

> [!NOTE]
> The following steps use the FTP Request Filtering user interface, which was introduced in FTP 7.5; these steps will not work if you are using FTP 7.0.

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
2. In the **Connections** pane, expand the server name, expand the **Sites** node, and then click the name of the site.
3. In the site's **Home** pane, double-click the **FTP Request Filtering** feature.
4. Click the **Commands** tab.  
    [![](index/_static/image10.png)](index/_static/image9.png)
5. Click **Deny Command...** in the **Actions** pane.
6. Enter an FTP command to deny. For example:

    - Many FTP clients do not send or need the **SYST** command, which may reveal information about your operating system.
    - FTP 7.0 and FTP 7.5 do not implement the **ACCT** command, so it may be blocked safely.
7. Click **OK**.  
    [![](index/_static/image12.png)](index/_static/image11.png)

<a id="005"></a>
## Configuration

The `<commandFiltering>` element is configured at the site level.

### Attributes

| Attribute | Description |
| --- | --- |
| `maxCommandLine` | Optional uint attribute.<br><br>Specifies the maximum command line length. It includes the command and parameters. Lines longer than the configured limit will not be processed.<br><br>The default value is `4096`. |
| `allowUnlisted` | Optional **Boolean** attribute.<br><br>Specifies whether to allow unlisted commands.<br><br>The default value is `true`. |

### Child Elements

| Element | Description |
| --- | --- |
| [`add`](add.md) | Optional element.<br><br>Adds an entry to the collection of FTP commands. |
| `clear` | Optional element.<br><br>Clears the collection of FTP commands. |
| `remove` | Optional element.<br><br>Removes an entry from the collection of FTP commands. |

### Configuration Sample

The following configuration sample displays an example &lt;siteDefaults&gt; element for a server that disables the SYST command by default. The SYST command returns the host operating system of the FTP server.

[!code-xml[Main](index/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code samples demonstrate how to configure the FTP service to deny the SYST command by default. The SYST command returns the host operating system of the FTP server.

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
