---
title: "FTP Request Limits &lt;requestLimits&gt;"
author: rick-anderson
description: "Overview The &lt;requestLimits&gt; element specifies limits on FTP requests that are processed by the FTP server. These limits include the maximum size of a..."
ms.date: 09/26/2016
ms.assetid: 9f1e9e24-057a-4558-97b7-9edb2b8fa646
msc.legacyurl: /configreference/system.ftpserver/security/requestfiltering/requestlimits
msc.type: config
---
# FTP Request Limits &lt;requestLimits&gt;

The `<requestLimits>` element specifies limits on FTP requests that are processed by the FTP server. These limits include the maximum size of a request and the maximum length for a command sequence.

> [!NOTE]
> When request filtering blocks an FTP request because an FTP request exceeds the request limits, FTP 7 will return an FTP error to the client and log one of the following FTP substatuses that identifies the reason that the request was denied:
>
> | FTP Substatus | Description |
> | --- | --- |
> | `12` | Path is too long based on request filtering rules. |
> | `51` | Command filtering rules denied the access. |
>
> These substatuses allow FTP administrators to analyze their IIS logs and identify potential threats.

<a id="002"></a>

## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<requestLimits>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<requestLimits>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<requestLimits>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<requestLimits>` element of the `<requestFiltering>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<requestLimits>` element of the `<requestFiltering>` element was introduced in FTP 7.0, which was a separate download for IIS 7.0. |
| IIS 6.0 | The FTP service in IIS 6.0 did not support request filtering. |

> [!NOTE]
> The FTP 7.0 and FTP 7.5 services shipped out-of-band for IIS 7.0, which required downloading and installing the modules from the following URL:
>
> <https://www.iis.net/downloads/microsoft/ftp>

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
    > [![Image of Web Server I I S and F T P Server nodes expanded and F T P Extensibility highlighted.](requestLimits/_static/image2.png)](requestLimits/_static/image1.png)

5. Click **Next**, and then on the **Select features** page, click **Next** again.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, and then select **FTP Server**.
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select **FTP Extensibility**.
    > [![Screenshot of Internet Information Services and F T P Server pane expanded with F T P Extensibility highlighted.](requestLimits/_static/image4.png)](requestLimits/_static/image3.png)

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
    > [![Screenshot of Select Role Services page with F T P Server pane expanded and F T P Service selected.](requestLimits/_static/image6.png)](requestLimits/_static/image5.png)

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
    > [![Image of Internet Information Services and F T P Server node expanded with F T P Service and F T P Extensibility selected.](requestLimits/_static/image8.png)](requestLimits/_static/image7.png)

5. Click **OK**.

### Windows Server 2008 or Windows Vista

1. Download the installation package from the following URL:

   <https://www.iis.net/downloads/microsoft/ftp>

2. Follow the instructions in the following walkthrough to install the FTP service:

   [Installing and Troubleshooting FTP 7](https://go.microsoft.com/fwlink/?LinkId=88547)

<a id="004"></a>

## How To

> [!NOTE]
> FTP Request Filtering did not have a user interface in the FTP 7.0 release; the FTP Request Filtering UI was added in the FTP 7.5 release.

### How to edit the request filtering feature settings and request limits

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
2. In the **Connections** pane, go to the site or directory for which you want to modify your request filtering settings.
3. In the **Home** pane, double-click **FTP Request Filtering**.
4. Click **Edit Feature Settings** in the **Actions** pane.

    [![Image of F T P Request Filtering page displaying Edit Feature Settings in Actions pane.](requestLimits/_static/image10.png)](requestLimits/_static/image9.png)

5. Specify your options. For example, you could make the following changes:

   - Change the maximum URL length to 2KB by specifying 2048.
   - Change the maximum command length to 1KB by specifying 1024.

   > [!NOTE]
   > It is recommended that you do not clear the **Allow unlisted commands** check box.  
   > [![Image of Edit F T P Request Filtering Settings dialog box showing Allow unlisted commands and Allow high bit characters both selected.](requestLimits/_static/image12.png)](requestLimits/_static/image11.png)

6. Click **OK**.

<a id="005"></a>

## Configuration

The `<requestLimits>` element of the `<requestFiltering>` element is configured at the global, site or URL level.

### Attributes

| Attribute | Description |
| --- | --- |
| `maxAllowedContentLength` | Optional int64 attribute.<br><br>Specifies the maximum length of content in a request, in bytes.<br><br>The default value is `0` (unlimited). |
| `maxUrl` | Optional uint attribute.<br><br>Specifies the maximum length of the request, in bytes.<br><br>**Note:** This value must be between 32 and 32768.<br><br>The default value is `4096`. |

### Child Elements

None.

### Configuration Sample

The following sample illustrates several security-related configuration settings in the `<system.ftpServer>` element for an FTP site. More specifically, the `<location>` settings in this example demonstrate how to:

- Specify an FTP authorization rule for read and write access for the administrators group.
- Specify FTP request filtering options that deny \*.exe, \*.bat, and \*.cmd files.
- Specify FTP request limits for a maximum content length of 1000000 bytes and a maximum URL length of 1024 bytes.
- Block FTP access to the \_vti\_bin virtual directory, which is used with the FrontPage Server Extensions.
- Specify FTP IP filtering options that allow access from 127.0.0.1 and deny access from the 169.254.0.0/255.255.0.0 range of IP addresses.

[!code-xml[Main](requestLimits/samples/sample1.xml)]

<a id="006"></a>

## Sample Code

The following examples specify FTP request limits for a maximum content length of 1000000 bytes and maximum URL length of 1024 bytes.

### AppCmd.exe

[!code-console[Main](requestLimits/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C\#

[!code-csharp[Main](requestLimits/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](requestLimits/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](requestLimits/samples/sample5.js)]

### VBScript

[!code-vb[Main](requestLimits/samples/sample6.vb)]
