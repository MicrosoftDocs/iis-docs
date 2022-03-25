---
title: "Adding FTP File Name Extensions &lt;add&gt;"
author: rick-anderson
description: "Overview The &lt;add&gt; element of the &lt;fileExtensions&gt; collection specifies a unique file name extension to add to the collection of file name extens..."
ms.date: 09/26/2016
ms.assetid: dd78d5b9-7ed8-4d2c-b6bf-321a46226311
msc.legacyurl: /configreference/system.ftpserver/security/requestfiltering/fileextensions/add
msc.type: config
---
# Adding FTP File Name Extensions &lt;add&gt;

<a id="001"></a>
## Overview

The `<add>` element of the `<fileExtensions>` collection specifies a unique file name extension to add to the collection of file name extensions for FTP 7.

> [!NOTE]
> When request filtering blocks an FTP request because of a denied file name extension, FTP 7 will return an FTP error to the client and log the following unique substatus that identifies the reason that the request was denied:

| FTP Substatus | Description |
| --- | --- |
| `11` | File name extension was denied based on request filtering rules |

This substatus allows FTP administrators to analyze their IIS logs and identify potential threats.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<add>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<add>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<add>` element of the `<fileExtensions>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<add>` element of the `<fileExtensions>` element was introduced in FTP 7.0, which was a separate download for IIS 7.0. |
| IIS 6.0 | The FTP service in IIS 6.0 did not support request filtering. |

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
    [![Screenshot that shows F T P Extensibility for Windows Server 2012.](add/_static/image2.png)](add/_static/image1.png) .
5. Click **Next**, and then on the **Select features** page, click **Next** again.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, and then select **FTP Server**.   
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select **FTP Extensibility**.   
    [![Screenshot that shows F T P Extensibility for Windows 8.](add/_static/image4.png)](add/_static/image3.png)
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
    [![Screenshot that shows F T P Extensibility for Windows Server 2008.](add/_static/image6.png)](add/_static/image5.png)
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
    [![Screenshot that shows F T P Extensibility for Windows 7.](add/_static/image8.png)](add/_static/image7.png)
5. Click **OK**.

### Windows Server 2008 or Windows Vista

1. Download the installation package from the following URL: 

    - [https://www.iis.net/expand/FTP](https://www.iis.net/downloads/microsoft/ftp)
2. Follow the instructions in the following walkthrough to install the FTP service: 

     - [Installing and Troubleshooting FTP 7](https://go.microsoft.com/fwlink/?LinkId=88547)
 
<a id="004"></a>
## How To

> [!NOTE]
> FTP Request Filtering did not have a user interface in the FTP 7.0 release; the FTP Request Filtering UI was added in the FTP 7.5 release.

### How to deny FTP access to a specific file name extension

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
4. In the **FTP Request Filtering** pane, click the **File Name Extensions** tab.  
    [![Screenshot that shows F T P Request Filtering pane.](add/_static/image10.png)](add/_static/image9.png)
5. Click **Deny File Name Extension...** in the **Actions** pane.
6. In the **Deny File Name Extension** dialog box, enter the file name extension that you wish to block. For example, to prevent access to files with a file name extension of .inc, you would enter "inc" in the dialog box.  
    [![Screenshot that shows Deny File Name Extension dialog box. Inc is entered in the File name extension box.](add/_static/image12.png)](add/_static/image11.png)
7. Click **OK**.

<a id="005"></a>
## Configuration

The `<add>` element of the `<fileExtensions>` collection is configured at the global, site or URL level.

### Attributes

| Attribute | Description |
| --- | --- |
| `allowed` | Required **Boolean** attribute.<br><br>Specifies whether the file name extension is allowed or denied. Setting this attribute to **true** allows the Web server to process requests associated with this type of file; setting this attribute to **false** prevents the Web server from processing requests.<br><br>The default value is `true`. |
| `fileExtension` | Required string attribute.<br><br>Specifies the name of the file name extension to allow or deny.<br><br>There is no default value. |

### Child Elements

None.

### Configuration Sample

The following sample illustrates several security-related configuration settings in the `<system.ftpServer>` element for an FTP site. More specifically, the `<location>` settings in this example demonstrate how to:

- Specify an FTP authorization rule for read and write access for the administrators group.
- Specify FTP request filtering options that deny \*.exe, \*.bat, and \*.cmd files.
- Specify FTP request limits for a maximum content length of 1000000 bytes and a maximum URL length of 1024 bytes.
- Block FTP access to the \_vti\_bin virtual directory, which is used with the FrontPage Server Extensions.
- Specify FTP IP filtering options that allow access from 127.0.0.1 and deny access from the 169.254.0.0/255.255.0.0 range of IP addresses.

[!code-xml[Main](add/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples specify FTP request filtering options that deny \*.exe, \*.com, \*.bat, and \*.cmd files.

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
