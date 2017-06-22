Default FTP Site-level Settings &lt;ftpServer&gt;
====================
<a id="001"></a>
## Overview

The `<ftpServer>` element of the `<siteDefaults>` element specifies the default settings for FTP features for all FTP sites.

In IIS 6.0, the settings for the FTP service were stored in a separate section of the metabase than Web sites. In IIS 7 and later, FTP settings are stored in the ApplicationHost.config file within the same `<site>` and `<siteDefaults>` elements that store the settings for Web sites. Because of this, settings that are specified in the `<ftpServer>` element cannot be delegated, nor can they be specified within `<location>` elements.

> [!NOTE]
> Additional FTP settings are stored in the [`<system.ftpServer>`](../../../../system.ftpserver/index.md) section of the ApplicationHost.config file, and these settings are specified within `<location>` elements.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<ftpServer>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<ftpServer>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<ftpServer>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<ftpServer>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<ftpServer>` element was introduced in FTP 7.0, which was a separate download for IIS 7.0. |
| IIS 6.0 | The `<ftpServer>` element and its child elements replace the IIS 6.0 FTP settings that were located in the **LM/MSFTPSVC** metabase path. |

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
    [![](index/_static/image2.png)](index/_static/image1.png) .
5. Click **Next**, and then on the **Select features** page, click **Next** again.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, and then select **FTP Server**.   
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select     **FTP Extensibility** .   
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
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select     **FTP Extensibility** .  
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
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select     **FTP Extensibility** .   
    [![](index/_static/image8.png)](index/_static/image7.png)
5. Click **OK**.

### Windows Server 2008 or Windows Vista

1. Download the installation package from the following URL: 

    - [https://www.iis.net/expand/FTP](https://www.iis.net/downloads/microsoft/ftp)
- Follow the instructions in the following walkthrough to install the FTP service: 

    - [Installing and Troubleshooting FTP 7](https://go.microsoft.com/fwlink/?LinkId=88547)

<a id="004"></a>
## How To

### How to enable or disable the default FTP Anonymous authentication settings

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
3. In the server's **Home** pane, double-click the **FTP Authentication** feature.
4. On the **FTP Authentication** page, select **Anonymous Authentication**.  
    [![](index/_static/image10.png)](index/_static/image9.png)
5. In the **Actions** pane, click **Enable** to enable Anonymous authentication or click **Disable** to disable Anonymous authentication.

* * *

### How to enable or disable the default FTP Basic authentication settings

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
3. In the server's **Home** pane, double-click the **FTP Authentication** feature.
4. On the **FTP Authentication** page, select **Basic Authentication**.  
    [![](index/_static/image12.png)](index/_static/image11.png)
5. In the **Actions** pane, click **Enable** to enable Basic authentication or click **Disable** to disable Basic authentication.

<a id="005"></a>
## Configuration

The default `<ftpServer>` element is configured at the `<siteDefaults>` level.

### Attributes

| Attribute | Description |
| --- | --- |
| `allowUTF8` | Optional **Boolean** attribute. **true** if UTF8 is enabled; otherwise, **false**. The default value is `true`. |
| `serverAutoStart` | Optional **Boolean** attribute. **true** if IIS should start FTP sites automatically when the FTP service is started; otherwise, **false**. The default value is `true`. |

### Child Elements

| Element | Description |
| --- | --- |
| [`connections`](connections.md) | Optional element. Specifies the default connection-specific settings for FTP sites. |
| [`security`](security/index.md) | Optional element. Specifies the default security-related settings for FTP sites. |
| [`customFeatures`](customfeatures/index.md) | Optional element. Specifies the default collection of custom FTP providers that were developed by using FTP extensibility. |
| [`messages`](messages.md) | Optional element. Specifies the default connection-related messages that FTP sites will display to FTP clients. |
| [`fileHandling`](filehandling.md) | Optional element. Specifies the default file-handling settings for FTP sites. |
| [`firewallSupport`](firewallsupport.md) | Optional element. Specifies the default settings for FTP sites that are required for FTP connections that are made through a firewall. |
| [`userIsolation`](userisolation/index.md) | Optional element. Specifies the default home directory lookup behavior for FTP connections. For example, users can be restricted to a home directory that is based on their login name. |
| [`directoryBrowse`](directorybrowse.md) | Optional element. Specifies the default directory listing options for FTP sites. These settings affect how the FTP service will display directory listings to FTP clients. |
| [`logFile`](logfile.md) | Optional element. Specifies the default ogging options for FTP sites. |

### Configuration Sample

The following configuration sample displays an example `<siteDefaults>` element for a server that defines several of the FTP site defaults.

[!code-xml[Main](index/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code samples illustrate setting several of the FTP site defaults.

### AppCmd.exe

[!code-console[Main](index/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](index/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample5.js)]

### VBScript

[!code-vb[Main](index/samples/sample6.vb)]