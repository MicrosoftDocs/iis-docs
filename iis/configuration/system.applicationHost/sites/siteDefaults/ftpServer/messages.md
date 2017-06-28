---
title: "Default FTP Messages &lt;messages&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;messages&gt; element is used to specify the message that the FTP service will display to FTP clients. The messages that are specified for th..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: 
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.applicationhost/sites/sitedefaults/ftpserver/messages
msc.type: config
---
Default FTP Messages &lt;messages&gt;
====================
<a id="001"></a>
## Overview

The `<messages>` element is used to specify the message that the FTP service will display to FTP clients. The messages that are specified for the `bannerMessage`, `greetingMessage`, and `maxClientsMessage` attributes are displayed when an FTP client connects to an FTP site, and the message that is specified by the `exitMessage` attribute is displayed when an FTP client disconnects from an FTP site.

The `suppressDefaultBanner` attribute can be used in combination with the `bannerMessage` attribute to disguise your FTP server type. If the default banner is suppressed and a banner message has not been specified in the `bannerMessage` attribute, the FTP server will display a blank banner when an FTP client connects to your server.

The `expandVariables` attribute specifies whether to display a specific set of user variables in FTP messages. If this attribute is set to **true**, the FTP service will display user variables in FTP messages; otherwise, all message text will be displayed as entered. The supported user variables are:

> | User Variable | Description |
> | --- | --- |
> | `%BytesReceived%` | The number of bytes sent from the server to the client for the current session. |
> | `%BytesSent%` | The number of bytes sent from the client to the server for the current session. |
> | `%SessionID%` | The unique identifier for the current session. |
> | `%SiteName%` | The name of the FTP site that is hosting the current session. |
> | `%UserName%` | The account name of the currently logged-on user. |


The `allowLocalDetailedErrors` attribute specifies whether to display detailed error messages when the FTP client is connecting to the FTP server on the server itself. These error messages contain detailed information that server administrators can use to troubleshoot issues. If this attribute is set to true, the FTP service will display detailed error messages only to the local host; otherwise, detailed error messages are not displayed.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<messages>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<messages>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<messages>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<messages>` element of the `<ftpServer>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<messages>` element of the `<ftpServer>` element was introduced in FTP 7.0, which was a separate download for IIS 7.0. |
| IIS 6.0 | N/A |

> [!NOTE]
> The FTP 7.0 and FTP 7.5 services shipped out-of-band for IIS 7.0, which required downloading and installing the modules from the following URL:

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
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will need to select     **FTP Extensibility** , in addition to     **FTP Service** .  
    [![](messages/_static/image2.png)](messages/_static/image1.png) .
5. Click **Next**, and then on the **Select features** page, click **Next** again.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, and then select **FTP Server**.   
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select     **FTP Extensibility** .   
    [![](messages/_static/image4.png)](messages/_static/image3.png)
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
    [![](messages/_static/image6.png)](messages/_static/image5.png)
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
    [![](messages/_static/image8.png)](messages/_static/image7.png)
5. Click **OK**.

### Windows Server 2008 or Windows Vista

1. Download the installation package from the following URL: 

    - [https://www.iis.net/expand/FTP](https://www.iis.net/downloads/microsoft/ftp)
- Follow the instructions in the following walkthrough to install the FTP service: 

    - [Installing and Troubleshooting FTP 7](https://go.microsoft.com/fwlink/?LinkId=88547)

<a id="004"></a>
## How To

### How to configure the default customized messages for all FTP sites

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
2. In the **Connections** pane, click the server name.
3. In the server's **Home** pane, double-click the **FTP Messages** feature.  
    [![](messages/_static/image10.png)](messages/_static/image9.png)
4. Configure the following options: 

    - Click to select the **Suppress default banner** option.
    - Click to select the **Support user variables in messages** option.
    - Type "This is my FTP server" for the **Banner** message.
    - Type "Hello %UserName%!" for the **Welcome** message.
    - Type "Goodbye %UserName%!" for the **Exit** message.  
        [![](messages/_static/image12.png)](messages/_static/image11.png)
5. Click **Apply** in the **Actions** pane.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `allowLocalDetailedErrors` | Optional **Boolean** attribute. **true** if detailed error messages should be displayed locally; otherwise, **false**. **Note:** Detailed error messages cannot be displayed remotely. The default value is `true`. |
| `bannerMessage` | Optional string attribute. Specifies the message that is displayed when a client connects to the FTP server. There is no default value. |
| `exitMessage` | Optional string attribute. Specifies the message that is displayed when a client is closing a connection to the FTP server. There is no default value. |
| `expandVariables` | Optional **Boolean** attribute. **true** if user variables should be expanded; otherwise, **false**. The default value is `false`. |
| `greetingMessage` | Optional string attribute. Specifies the message that is displayed after a client has logged in to the FTP server. There is no default value. |
| `maxClientsMessage` | Optional string attribute. Specifies the message that is displayed when a client tries to log in and the maximum number of clients has already been reached on the FTP server. There is no default value. |
| `suppressDefaultBanner` | Optional **Boolean** attribute. **true** if the FTP service should suppress the default "Microsoft FTP Service" banner; otherwise, **false**. The default value is `false`. |

### Child Elements

None.

### Configuration Sample

The following configuration sample displays an example `<messages>` element for a server that defines a custom default banner message and enables local detailed error messages.

[!code-xml[Main](messages/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code samples illustrate setting a custom default banner message and enabling local detailed error messages.

### AppCmd.exe

[!code-console[Main](messages/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](messages/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](messages/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](messages/samples/sample5.js)]

### VBScript

[!code-vb[Main](messages/samples/sample6.vb)]