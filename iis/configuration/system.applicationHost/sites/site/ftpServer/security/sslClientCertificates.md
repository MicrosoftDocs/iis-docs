---
title: "FTP SSL Client Certificates &lt;sslClientCertificates&gt;"
author: rick-anderson
description: "Overview The &lt;sslClientCertificates&gt; element specifies the SSL client certificate options for FTP sites. More specifically, this element contains the f..."
ms.date: 09/26/2016
ms.assetid: abe8c0ef-cbd8-4432-89eb-98804985e7ab
msc.legacyurl: /configreference/system.applicationhost/sites/site/ftpserver/security/sslclientcertificates
msc.type: config
---
# FTP SSL Client Certificates &lt;sslClientCertificates&gt;

<a id="001"></a>

## Overview

The `<sslClientCertificates>` element specifies the SSL client certificate options for FTP sites. More specifically, this element contains the following attributes, which are discussed in detail in the configuration section of this topic:

- The `clientCertificatePolicy` attribute specifies whether client certificates will be allowed, required, or ignored.
- The `validationFlags` attribute specifies an FTP site's behavior for checking for certificate revocation.
- The `revocationFreshnessTime` attribute specifies the amount of time that the revocation list is valid.
- The `revocationUrlRetrievalTimeout` attribute specifies the time-out for retrieving certificate revocation information
- The `useActiveDirectoryMapping` attribute specifies whether Active Directory mapping should be allowed for client certificates. Note: This attribute is used in combination with the `<clientCertAuthentication>` element to configure certificate mapping by using Active Directory.

<a id="002"></a>

## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<sslClientCertificates>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<sslClientCertificates>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<sslClientCertificates>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<sslClientCertificates>` element of the `<security>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<sslClientCertificates>` element of the `<security>` element was introduced in FTP 7.0, which was a separate download for IIS 7.0. |
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
    [![](sslClientCertificates/_static/image2.png)](sslClientCertificates/_static/image1.png) .
5. Click **Next**, and then on the **Select features** page, click **Next** again.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, and then select **FTP Server**.   
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select **FTP Extensibility**.   
    [![](sslClientCertificates/_static/image4.png)](sslClientCertificates/_static/image3.png)
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
    [![](sslClientCertificates/_static/image6.png)](sslClientCertificates/_static/image5.png)
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
    [![](sslClientCertificates/_static/image8.png)](sslClientCertificates/_static/image7.png)
5. Click **OK**.

### Windows Server 2008 or Windows Vista

1. Download the installation package from the following URL: 

    - [https://www.iis.net/expand/FTP](https://www.iis.net/downloads/microsoft/ftp)
2. Follow the instructions in the following walkthrough to install the FTP service: 

     - [Installing and Troubleshooting FTP 7](https://go.microsoft.com/fwlink/?LinkId=88547)

<a id="004"></a>

## How To

At this time there is no user interface that enables you to configure the client certificate authentication settings for an FTP site. See the **Configuration** and **Sample Code** sections of this document for additional information about how to configure the client certificate authentication settings custom features to an FTP site.

<a id="005"></a>

## Configuration

The `<sslClientCertificates>` element is configured at the site level.

### Attributes

| Attribute | Description |
| --- | --- |
| `clientCertificatePolicy` | Optional enum attribute.<br><br>Specifies the client certificate policy. <table> <tbody> <tr> <th>Value</th> <th>Description</th></tr> <tr> <th><code>CertIgnore</code></th> <td>Specifies that client certificates will not be negotiated for SSL session.<br><br>The numeric value is <code>0</code>.</td></tr> <tr> <th><code>CertAllow</code></th> <td>Specifies that client certificates will be allowed. If the client chooses to send a certificate, then certificate must be valid and the server must be able to successfully validate it.<br><br>The numeric value is <code>1</code>.</td></tr> <tr> <th><code>CertRequire</code></th> <td>Specifies that client certificates will be required. FTP clients will not be allowed to connect unless they send a valid client certificate to the server.<br><br>The numeric value is <code>2</code>.</td></tr></tbody></table>The default value is `CertIgnore`. |
| `validationFlags` | Optional flags attribute.<br><br>Specifies the flags that affect client certificate validation. <table> <tbody> <tr> <th>Value</th> <th>Description</th></tr> <tr> <th><code>NoRevocationCheck</code></th> <td> <p>Specifies that certificate revocation checks will be skipped.<br><br><strong>Warning</strong>: It is not recommended to skip revocation validation.<br><br>The numeric value is <code>1</code>.</p></td></tr> <tr> <th><code>CertChainRevocationCheckCacheOnly</code></th> <td>Specifies that revocation checking only accesses cached URLs.<br><br>The numeric value is <code>2</code>.</td></tr> <tr> <th><code>CertChainCacheOnlyUrlRetrieval</code></th> <td>Specifies only cached URLs in building a certificate chain. The Internet and intranet are not searched for URL-based objects.<br><br>The numeric value is <code>4</code>.</td></tr> <tr> <th><code>CertNoUsageCheck</code></th> <td>Does not check client certificate for usage flags. Usage check is enabled by default and it is meant to assure that only client certificates that allow "Client authentication" are allowed.<br><br>The numeric value is <code>8</code>.</td></tr></tbody></table>There is no default value. |
| `revocationFreshnessTime` | Optional timeSpan attribute.<br><br>Specifies the amount of time the revocation list is valid.<br><br>The default value is `00:00:00`. |
| `revocationUrlRetrievalTimeout` | Optional timeSpan attribute.<br><br>Specifies the timeout for retrieving certificate revocation information.<br><br>The default value is `00:01:00`. |
| `useActiveDirectoryMapping` | Optional **Boolean** attribute.<br><br>**true** if Active Directory mapping should be allowed for client certificates; otherwise, **false**. Active Directory mapping allows domain users to log on by using a client certificate that is configured in Active Directory.<br><br>**Note:** This feature only allows the SSL layer to attempt to map a client certificate to a user token; the token will not be used automatically. The `<clientCertAuthentication>` element is used to enable the mapped token for use by FTP instead of credentials specified through "**USER**" and "**PASS**" commands.<br><br>The default value is `false`. |

### Child Elements

None.

### Configuration Sample

The following sample displays an FTP site that requires SSL and client certificates for both the data channel and the control channel.

[!code-xml[Main](sslClientCertificates/samples/sample1.xml)]

<a id="006"></a>

## Sample Code

The following examples configure an FTP site so that it requires client certificates and requires SSL for both the data channel and the control channel.

### AppCmd.exe

[!code-console[Main](sslClientCertificates/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C\#

[!code-csharp[Main](sslClientCertificates/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](sslClientCertificates/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](sslClientCertificates/samples/sample5.js)]

### VBScript

[!code-vb[Main](sslClientCertificates/samples/sample6.vb)]
