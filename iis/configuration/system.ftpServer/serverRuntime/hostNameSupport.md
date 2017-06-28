---
title: "FTP Host Name Support &lt;hostNameSupport&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;hostNameSupport&gt; element specifies domain name syntax is supported for virtual host names. FTP virtual host names were introduced in FTP..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: 
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.ftpserver/serverruntime/hostnamesupport
msc.type: config
---
FTP Host Name Support &lt;hostNameSupport&gt;
====================
<a id="001"></a>
## Overview

The `<hostNameSupport>` element specifies domain name syntax is supported for virtual host names.

FTP virtual host names were introduced in FTP 7.0, and an FTP virtual host name is specified as part of a binding in the same way that you specify HTTP host header names. For example, you might specify the bindings by using host names like "**www.contoso.com**" or "**www.fabrikam.com**" for the HTTP bindings and "**ftp.contoso.com**" or "**ftp.fabrikam.com**" for the FTP bindings. HTTP provides a way to pass the host name in the headers that are passed between the client and server, but FTP currently does not provide this same functionality. Because of this FTP limitation, the virtual host name is used as part of the user name during the login process. By default, an FTP client would need to specify its login credentials by using the pipe (vertical line) character with syntax like "**ftp.contoso.com|username**" or "**ftp.fabrikam.com|username**". By setting the `useDomainNameAsHostName` attribute to **true**, you can specify the virtual host and user name by using domain name syntax; this lets you use a backslash character instead of the pipe (vertical line) character; so the syntax would look like "**ftp.contoso.com\username**" or "**ftp.fabrikam.com\username**".

> [!NOTE]
> Both FTP 7.0 and FTP 7.5 support the proposed FTP HOST command, which does not require that you use the virtual host name as part of the user name.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<hostNameSupport>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<hostNameSupport>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<hostNameSupport>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<hostNameSupport>` element of the `<system.ftpServer>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<hostNameSupport>` element of the `<system.ftpServer>` element was introduced in FTP 7.5, which was a separate download for IIS 7.0. |
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
    [![](hostNameSupport/_static/image2.png)](hostNameSupport/_static/image1.png) .
5. Click **Next**, and then on the **Select features** page, click **Next** again.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, and then select **FTP Server**.   
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select     **FTP Extensibility** .   
    [![](hostNameSupport/_static/image4.png)](hostNameSupport/_static/image3.png)
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
    [![](hostNameSupport/_static/image6.png)](hostNameSupport/_static/image5.png)
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
    [![](hostNameSupport/_static/image8.png)](hostNameSupport/_static/image7.png)
5. Click **OK**.

### Windows Server 2008 or Windows Vista

1. Download the installation package from the following URL: 

    - [https://www.iis.net/expand/FTP](https://www.iis.net/downloads/microsoft/ftp)
- Follow the instructions in the following walkthrough to install the FTP service: 

    - [Installing and Troubleshooting FTP 7](https://go.microsoft.com/fwlink/?LinkId=88547)
 
<a id="004"></a>
## How To

### How to configure domain name syntax for virtual host names

> [!NOTE]
> There is no direct user interface that lets you configure the `<hostNameSupport>` element; therefore the following steps will use the IIS Configuration Editor feature.

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
3. In the **Home** pane, double-click the **Configuration Editor** feature.
4. In the **Section** drop-down menu, expand **sytem.ftpServer**, and then click **serverRuntime**.
5. Expand **hostNameSupport** in the list view.  
    [![](hostNameSupport/_static/image10.png)](hostNameSupport/_static/image9.png)
6. Choose **True** or **False** in the drop-down list for the **useDomainNameAsHostName** attribute.
7. In the **Actions** pane, click **Apply**.

> [!NOTE]
> This section contains information about how to modify your IIS settings by using the IIS Configuration Editor. Incorrectly editing your IIS configuration settings can severely damage your IIS installation. Therefore, make sure that you follow these steps carefully. For added security, you should back up your IIS configuration settings before you use the IIS Configuration Editor to make any modifications. For more information about how to back up your IIS configuration settings and how to use the IIS Configuration Editor, see the following topics:

- **How to Back Up an IIS 7 Configuration**  
    [https://technet.microsoft.com/en-us/library/dd819406.aspx](https://technet.microsoft.com/en-us/library/dd819406.aspx)
- **Configuration Editor Page**  
    [https://technet.microsoft.com/en-us/library/dd569081.aspx](https://technet.microsoft.com/en-us/library/dd569081.aspx)
 
<a id="005"></a>
## Configuration

The `<hostNameSupport>` element of the `<serverRuntime>` element is configured at the global level in ApplicationHost.config.

### Attributes

| Attribute | Description |
| --- | --- |
| `useDomainNameAsHostName` | Optional **Boolean** attribute. **true** if domain name syntax is supported for virtual host names; otherwise, **false**. The default value is `false`. |

### Child Elements

None.

### Configuration Sample

The following sample displays a `<serverRuntime>` element that configures the server allow domain name syntax for virtual host names.

[!code-xml[Main](hostNameSupport/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples configure the `<serverRuntime>` element for an FTP server to allow domain name syntax for FTP virtual host names.

### AppCmd.exe

[!code-console[Main](hostNameSupport/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](hostNameSupport/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](hostNameSupport/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](hostNameSupport/samples/sample5.js)]

### VBScript

[!code-vb[Main](hostNameSupport/samples/sample6.vb)]