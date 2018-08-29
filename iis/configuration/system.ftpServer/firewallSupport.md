---
title: "FTP Firewall Support &lt;firewallSupport&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;system.ftpServer/firewallSupport&gt; element is used to configure the port range that the FTP service will use for data channel activity whe..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: 3ef78302-f0b5-4ba7-a1f1-adb6768df2af
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.ftpserver/firewallsupport
msc.type: config
---
FTP Firewall Support &lt;firewallSupport&gt;
====================
<a id="001"></a>
## Overview

The `<system.ftpServer/firewallSupport>` element is used to configure the port range that the FTP service will use for data channel activity when when you use the FTP PASV command to negotiate passive connections, which contains IP address and port of the server.

When passive connections are negotiated using the FTP PASV command, the FTP server sends a response which contains IP address and port of the server. By specifying the `lowDataChannelPort` and `highDataChannelPort` attributes, you can direct FTP clients to communicate with your firewall, which should route the client traffic to your FTP server.

The valid range for TCP/IP ports is 1025 through 65535. (Ports from 1 through 1024 are reserved for use by system services.) You can enter a special port range of "0-0" to configure the FTP server to use the Windows TCP/IP ephemeral port range. In early versions of Windows, the TCP/IP ephemeral port range was set to use ports 1025 through 5000. Starting with Windows Vista and Windows Server 2008, the TCP/IP ephemeral port range has been changed to 49152 through 65535. For more information about the ephemeral port range, see the following article in the Microsoft Knowledge Base:

> [929851: The default dynamic port range for TCP/IP has changed in Windows Vista and in Windows Server 2008](https://support.microsoft.com/kb/929851/)


> [!NOTE]
> You can use the [`<ftpServer/firewallSupport>`](../system.applicationhost/sites/site/ftpserver/firewallsupport.md) to configure the per-site external IP address for your firewall; this allows you to route the firewall traffic for each site through a different firewall.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<firewallSupport>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<firewallSupport>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<firewallSupport>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<firewallSupport>` element of the `<system.ftpServer>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<firewallSupport>` element of the `<system.ftpServer>` element was introduced in FTP 7.0, which was a separate download for IIS 7.0. |
| IIS 6.0 | The `<firewallSupport>` element replaces the IIS 6.0 **MSFTPSVC/PassivePortRange** metabase property. |

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
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will need to select     **FTP Extensibility** , in addition to     **FTP Service** .  
    [![](firewallSupport/_static/image2.png)](firewallSupport/_static/image1.png) .
5. Click **Next**, and then on the **Select features** page, click **Next** again.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, and then select **FTP Server**.   
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select     **FTP Extensibility** .   
    [![](firewallSupport/_static/image4.png)](firewallSupport/_static/image3.png)
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
    [![](firewallSupport/_static/image6.png)](firewallSupport/_static/image5.png)
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
    [![](firewallSupport/_static/image8.png)](firewallSupport/_static/image7.png)
5. Click **OK**.

### Windows Server 2008 or Windows Vista

1. Download the installation package from the following URL: 

    - [https://www.iis.net/expand/FTP](https://www.iis.net/downloads/microsoft/ftp)
2. Follow the instructions in the following walkthrough to install the FTP service: 

     - [Installing and Troubleshooting FTP 7](https://go.microsoft.com/fwlink/?LinkId=88547)
 
<a id="004"></a>
## How To

### How to configure the global firewall settings for the FTP service

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
3. In the **Home** pane, double-click the **FTP Firewall Support** feature.
4. In the **Data Channel Port Range** box, use one of the following options to enter a port range for passive data channel connections: 

    - Use [low port]-[high port] for a port range, where each port must be between 1025 and 65535. For example, 5000-6000.
    - Use "0-0" to configure the FTP server to use the Windows TCP/IP ephemeral port range.  
        [![](firewallSupport/_static/image10.png)](firewallSupport/_static/image9.png)
5. In the **External IP Address of Firewall** box, type the IPv4 address of the Internet-facing network adapter of your firewall.
6. In the **Actions** pane, click **Apply**.

For additional information about how to configure the firewall settings for the FTP service, see the following topic on the Microsoft IIS.net Web site:

> **Configuring FTP Firewall Settings**  
> [https://www.iis.net/learn/publish/using-the-ftp-service/configuring-ftp-firewall-settings-in-iis-7](https://docs.microsoft.com/en-us/iis/publish/using-the-ftp-service/configuring-ftp-firewall-settings-in-iis-7)


<a id="005"></a>
## Configuration

The `<firewallSupport>` element is configured at the global level in ApplicationHost.config.

### Attributes

| Attribute | Description |
| --- | --- |
| `lowDataChannelPort` | Optional int attribute.<br><br>Specifies the lowest port for data channel activity for passive data connections.<br><br>The default value is `0`. |
| `highDataChannelPort` | Optional int attribute.<br><br>Specifies the lowest port for data channel activity for passive data connections.<br><br>The default value is `0`. |

### Child Elements

None.

### Configuration Sample

The following sample illustrates several configuration settings in the global `<system.ftpServer>` element for a server. More specifically, the settings in this example demonstrate how to:

- Enable FTP credential caching and specify a time-out of 10 minutes (600 seconds.)
- Configure the low port as 5000 and the high port as 6000 for data channel communications.
- Enable logging and specify that log files will be kept per-site, and that log files will be rotated daily by UTC time.
- Specify a custom FTP provider and specify a custom parameter for that provider.
- Specify global IP restrictions that allow FTP access from local host and deny access to the 169.254.0.0 to 169.254.255.255 block of IP addresses.
- Configure request filtering with the following options: 

    - Block FTP access to the \_vti\_bin virtual directory, which is used with the FrontPage Server Extensions.
    - Block several file types that are associated with executables.
    - Specify 100MB as the maximum file size.
- Add a global authorization rule that allows access for the administrators group.
- Specify that domain name syntax can be used for FTP virtual host names.


[!code-xml[Main](firewallSupport/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples configure the FTP service to use the port range of 5000 to 6000 for data channel activity when passive connections are used.

### AppCmd.exe

[!code-console[Main](firewallSupport/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](firewallSupport/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](firewallSupport/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](firewallSupport/samples/sample5.js)]

### VBScript

[!code-vb[Main](firewallSupport/samples/sample6.vb)]