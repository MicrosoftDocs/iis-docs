---
title: "FTP Client Certificate Authentication &lt;clientCertAuthentication&gt;"
author: rick-anderson
description: "Overview The &lt;clientCertAuthentication&gt; element specifies the settings for Client Certificate authentication. This form of Secure Sockets Layer (SSL) a..."
ms.date: 09/26/2016
ms.assetid: fdaced08-8321-4167-9640-7093d6bf2d54
msc.legacyurl: /configreference/system.applicationhost/sites/site/ftpserver/security/authentication/clientcertauthentication
msc.type: config
---
FTP Client Certificate Authentication &lt;clientCertAuthentication&gt;
====================
<a id="001"></a>
## Overview

The `<clientCertAuthentication>` element specifies the settings for Client Certificate authentication. This form of Secure Sockets Layer (SSL) authentication was introduced in FTP 7 and uses client certificates to authenticate FTP clients by mapping to client certificates Windows user accounts.

Client Certificate authentication has the following dependencies:

- For the `<ssl>` element: 

    - The `serverCertHash` attribute must be set to a valid certificate hash.
    - The `controlChannelPolicy` and `dataChannelPolicy` attributes must be configured to allow SSL.
- For the `<sslClientCertificates>` element: 

    - The `clientCertificatePolicy` attribute must be configured to allow SSL certificates.
    - The `useActiveDirectoryMapping` attribute must be set to **true**.

> [!NOTE]
> The FTP service requests Active Directory to validate client certificates, but the validation by Active Directory is performed independently of the FTP service.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<clientCertAuthentication>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<clientCertAuthentication>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<clientCertAuthentication>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<clientCertAuthentication>` element of the `<authentication>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<clientCertAuthentication>` element of the `<authentication>` element was introduced in FTP 7.0, which was a separate download for IIS 7.0. |
| IIS 6.0 | The `<ftpServer>` element and its child elements replace the IIS 6.0 FTP settings that were located in the **LM/MSFTPSVC** metabase path. |

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
    [![](clientCertAuthentication/_static/image2.png)](clientCertAuthentication/_static/image1.png) .
5. Click **Next**, and then on the **Select features** page, click **Next** again.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, and then select **FTP Server**.   
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select **FTP Extensibility**.   
    [![](clientCertAuthentication/_static/image4.png)](clientCertAuthentication/_static/image3.png)
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
    [![](clientCertAuthentication/_static/image6.png)](clientCertAuthentication/_static/image5.png)
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
    [![](clientCertAuthentication/_static/image8.png)](clientCertAuthentication/_static/image7.png)
5. Click **OK**.

### Windows Server 2008 or Windows Vista

1. Download the installation package from the following URL: 

    - [https://www.iis.net/expand/FTP](https://www.iis.net/downloads/microsoft/ftp)
2. Follow the instructions in the following walkthrough to install the FTP service: 

     - [Installing and Troubleshooting FTP 7](https://go.microsoft.com/fwlink/?LinkId=88547)

<a id="004"></a>
## How To

At this time there is no user interface that enables you to configure the Client Certificate authentication settings for an FTP site. See the **Configuration** and **Sample Code** sections of this document for additional information about how to configure the Client Certificate authentication settings for an FTP site.

<a id="005"></a>
## Configuration

The `<clientCertAuthentication>` element is configured at the site level.

### Attributes

| Attribute | Description |
| --- | --- |
| `enabled` | Optional **Boolean** attribute.<br><br>**true** if Client Certificate authentication is enabled; otherwise, **false**.<br><br>The default value is `false`. |

### Child Elements

None.

### Configuration Sample

The following sample displays an FTP server that requires SSL, and uses Client Certificate authentication to map users to Active Directory accounts.

[!code-xml[Main](clientCertAuthentication/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples configure an FTP site so that it disables both Anonymous and Basic authentication and enables Client Certificate authentication.

### AppCmd.exe

[!code-console[Main](clientCertAuthentication/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](clientCertAuthentication/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](clientCertAuthentication/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](clientCertAuthentication/samples/sample5.js)]

### VBScript

[!code-vb[Main](clientCertAuthentication/samples/sample6.vb)]
