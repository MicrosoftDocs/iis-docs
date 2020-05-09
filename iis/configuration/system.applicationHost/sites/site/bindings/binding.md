---
title: "Binding &lt;binding&gt;"
author: rick-anderson
description: "Overview The &lt;binding&gt; element of the &lt;bindings&gt; element allows you to configure the information required for requests to communicate with a Web..."
ms.date: 09/26/2016
ms.assetid: f8c97dd0-4d70-4990-b407-a4bb7315e1c5
msc.legacyurl: /configreference/system.applicationhost/sites/site/bindings/binding
msc.type: config
---
Binding &lt;binding&gt;
====================
<a id="001"></a>
## Overview

The `<binding>` element of the `<bindings>` element allows you to configure the information required for requests to communicate with a Web site.

You can configure binding information when you create a Web site, or you can edit the binding information after you create the site. Binding information includes the protocol that clients use to communicate with the site, the site's IP address, the port number, and a host header.

The `<binding>` element contains two attributes to configure the binding information: **bindingInformation** and **protocol**. The **bindingInformation** attribute contains the IP address, the port number and, optionally, the host header for the site. The **protocol** attribute defines the protocol to use to communicate with the site.

You can configure the collection of bindings for a site using IIS Manager by selecting the site and using the **Bindings...** or **Advanced Settings...** links in the **Actions** pane or by clicking **Edit Bindings...** on the site's shortcut menu.

IIS 8.0 or later enables you to provide security for Web sites by using the certificates in a centralized certificate store on Windows Server 2012. For more information, see [IIS 8.0 Centralized SSL Certificate Support: SSL Scalability and Manageability](https://docs.microsoft.com/iis/get-started/whats-new-in-iis-8/iis-80-centralized-ssl-certificate-support-ssl-scalability-and-manageability).

The **binding** element enables you to specify the type of binding used for Secure Sockets Layer (SSL) certificates.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<binding>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<binding>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `sslFlags` attribute was added to specify the binding used for Secure Sockets Layer certificates. |
| IIS 7.5 | The `<binding>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<binding>` element of the `<bindings>` collection was introduced in IIS 7.0. |
| IIS 6.0 | The `<bindings>` collection replaces sections of the **ServerBindings** property on the IIS 6.0 **IIsWebServer** metabase object. |

<a id="003"></a>
## Setup

The `<binding>` element is included in the default installation of IIS 7 and later.

### How to install a Centralized Certificate Store

In IIS 8 and later, the certificates in a centralized certificate store can be used to provide security for a Web site. To use this store on your Windows Server 2012 or later Web server, you must install the Centralized SSL Certificate Store role. To do so with IIS already installed, proceed as follows:

1. Press the **Windows key**, and then click **Server Manager**.
2. In **Server Manager**, click **Manage** and then click **Add Roles and Features**.
3. In the **Add Roles and Features** wizard, click through the **Before You Begin** page, select the installation type and then click **Next** on the **Installation Type** page, and select where to install and click **Next** on the **Server Selection** pages.
4. In the **Server Roles** page, ensure that **Web Server (IIS)** is selected, and then expand it. Expand **Web Server**, and then select and expand **Security**.
5. Select **Centralized SSL Certificate Store**, and then click **Next**.
6. On the **Features** page, click **Next**.
7. On the **Confirm Installation Selections** page, click **Install**.
8. On the **Results** page, click **Close**.

<a id="004"></a>
## How To

### How to add binding information to a site

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
2. In the **Connections** pane, expand the server name, expand **Sites**, and then click the Web site on which you want to configure the bindings.
3. In the **Actions** pane, click **Bindings...**
4. In the **Site Bindings** dialog box, click **Add...**  
    [![](binding/_static/image2.png)](binding/_static/image1.png)
5. In the **Add Site Binding** dialog box, add the binding information, and then click **OK**.  
    [![](binding/_static/image4.png)](binding/_static/image3.png)

### How to create a centralized certificate store

1. Press the **Start** button, and then click **Server Manager**. In the Server Manager, click **Tools**, and then click **Internet Information Services (IIS) Manager**.
2. In the **Connections** pane, select the server name.
3. In the **Home** page, under the **Management** area, double-click **Centralized Certificates**.
4. In the **Actions pane**, click **Edit Feature Settings**.
5. Select **Enable Centralized Certificates** and enter a physical path. Enter a user name for the path, enter a password for the path, and confirm the password. Click **OK**.

<a id="005"></a>
## Configuration

You can add `<binding>` elements within the `<bindings>` element for each site in the ApplicationHost.config file. Each site must have at least one HTTP or HTTPS binding to be viewable over the Internet.

### Attributes

| Attribute | Description |
| --- | --- |
| `bindingInformation` | Required string attribute.<br><br>Specifies information to communicate with a site. For example, a Web site binding includes the IP address (or unspecified IP addresses), the port number, and an optional host header used to communicate with the site. |
| `protocol` | Required string attribute.<br><br>Specifies the protocol for communicating with a site. |
| `sslFlags` | Optional uint attribute.<br><br>Specifies the type of binding used for Secure Sockets Layer (SSL) certificates.<br><ul> <li>A value of "0" specifies that the secure connection be made using an IP/Port combination. Only one certificate can be bound to a combination of IP address and the port.</li> <li>A value of "1" specifies that the secure connection be made using the port number and the host name obtained by using Server Name Indication (SNI).</li> <li>A value of "2" specifies that the secure connection be made using the centralized SSL certificate store without requiring a Server Name Indicator.</li> <li>A value of "3" specifies that the secure connection be made using the centralized SSL certificate store while requiring Server Name Indicator</li></ul> Centralized SSL certificate support enables you to create a centralized certificate store that can contain multiple certificate files. You can name the certificate files to correspond to the host names that they contain. This enables you to create a binding that only requires a port, rather than an IP/port or a host name/port combination. When a request comes in, IIS matches the port, determines the host name from the request, and searches the centralized certificate store for a certificate file with a matching name. It uses that certificate. <br><br> With a Server Name Indicator (SNI), the host name is exchanged as part of the SSL handshake. SNI is enabled in the Add Site Binding dialog box when you add a binding with a type of HTTPS. This is especially useful for SSL connections that host multiple servers on a single network address. For more information, see [IIS 8.0 Server Name Indication (SNI): SSL Scalability](https://docs.microsoft.com/iis/get-started/whats-new-in-iis-8/iis-80-server-name-indication-sni-ssl-scalability). <br><br>The sslFlags attribute is only set when the protocol is **https**. The default value is `0`. |

### Child Elements

None.

### Configuration Sample

The following example defines a site named Contoso with two bindings. The first binding is for a hostname of &quot;www.contoso.com&quot; on port 80 for the IP address of 192.168.0.1, and the second binding is for an HTTPS binding for all IP addresses over port 443.

[!code-xml[Main](binding/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples configure a site named Contoso with a hostname of &quot;www.contoso.com&quot; on port 80 for the IP address of 192.168.0.1, and an HTTPS binding for all IP addresses over port 443.

### AppCmd.exe

[!code-console[Main](binding/samples/sample2.cmd)]

Or you can use:

[!code-console[Main](binding/samples/sample3.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C\#

[!code-csharp[Main](binding/samples/sample4.cs)]

### VB.NET

[!code-vb[Main](binding/samples/sample5.vb)]

### JavaScript

[!code-javascript[Main](binding/samples/sample6.js)]

### VBScript

[!code-vb[Main](binding/samples/sample7.vb)]
