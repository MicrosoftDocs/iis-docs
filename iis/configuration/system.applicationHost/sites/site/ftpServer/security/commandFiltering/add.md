Adding FTP Command Filtering Entries &lt;add&gt;
====================
<a id="001"></a>
## Overview

The `<add>` element adds a unique entry to the collection of FTP commands that the FTP service will allow or deny.

> [!NOTE]
> Special attention must be applied when configuring which FTP commands to allow or deny, and whether to deny unlisted commands. For example, denying many commands like USER, PASS, PASV, PORT, etc., will make it impossible for your FTP site to function. Likewise, denying unlisted commands by default will probably be too restrictive and many FTP clients will be unable to access your FTP site.

The collection in the `<commandFiltering>` element is related to the [`<requestFiltering>`](https://www.iis.net/configreference/system.ftpserver/security/requestfiltering) settings; however, while request filtering applies for files and directories and can be configured per URL, the settings under the `<commandFiltering>` element apply the protocol-level of processing and can only be configured at the site level.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<add>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<add>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<add>` element of the `<commandFiltering>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<add>` element of the `<commandFiltering>` element was introduced in FTP 7.0, which was a separate download for IIS 7.0. |
| IIS 6.0 | The FTP service in IIS 6.0 did not support command filtering. |

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
    [![](add/_static/image2.png)](add/_static/image1.png) .
5. Click **Next**, and then on the **Select features** page, click **Next** again.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, and then select **FTP Server**.   
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select     **FTP Extensibility** .   
    [![](add/_static/image4.png)](add/_static/image3.png)
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
    [![](add/_static/image6.png)](add/_static/image5.png)
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
    [![](add/_static/image8.png)](add/_static/image7.png)
5. Click **OK**.

### Windows Server 2008 or Windows Vista

1. Download the installation package from the following URL: 

    - [https://www.iis.net/expand/FTP](https://www.iis.net/downloads/microsoft/ftp)
- Follow the instructions in the following walkthrough to install the FTP service: 

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
    [![](add/_static/image10.png)](add/_static/image9.png)
5. Click **Deny Command...** in the **Actions** pane.
6. Enter an FTP command to deny. For example: 

    - Many FTP clients do not send or need the **SYST** command, which may reveal information about your operating system.
    - FTP 7.0 and FTP 7.5 do not implement the **ACCT** command, so it may be blocked safely.
7. Click **OK**.  
    [![](add/_static/image12.png)](add/_static/image11.png)

<a id="005"></a>
## Configuration

The `<add>` element is configured at the site level.

### Attributes

| Attribute | Description |
| --- | --- |
| `command` | Required unique string attribute. Specifies the FTP command for the rule. There is no default value. |
| `allowed` | Required **Boolean** attribute. **true** if the command is allowed; otherwise, **false**. There is no default value. |

### Child Elements

None.

### Configuration Sample

The following sample illustrates several configuration settings in the `<ftpServer>` element for an FTP site. More specifically, the `<site>` settings in this example demonstrate how to:

- Create an FTP site and add the binding for the FTP protocol on port 21.
- Configure the FTP SSL options to allow secure access on both the control and data channel using a certificate.
- Disable Anonymous authentication and enable Basic authentication for FTP.
- Deny access for FTP **SYST** command.
- Specify the UNIX directory listing format.
- Configure the logging options.
- Specify a customized welcome message and enable local detailed error messages.
- Specify that users will start in a home directory that is based on their login name, but only if that directory exists.


[!code-xml[Main](add/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples configure the Default Web Site to allow unlisted FTP commands and to deny the SYST command.

### AppCmd.exe

[!code-console[Main](add/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](add/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](add/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](add/samples/sample5.js)]

### VBScript

[!code-vb[Main](add/samples/sample6.vb)]