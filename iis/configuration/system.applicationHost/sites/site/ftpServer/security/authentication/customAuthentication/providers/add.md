---
title: "Adding FTP Custom Authentication Providers &lt;add&gt;"
author: rick-anderson
description: "Overview The &lt;add&gt; element adds a provider to the collection of custom authentication providers. When custom authentication providers are added to FTP..."
ms.date: 09/26/2016
ms.assetid: 10e0f013-3e66-43d0-8ad2-1ffc0a79631e
msc.legacyurl: /configreference/system.applicationhost/sites/site/ftpserver/security/authentication/customauthentication/providers/add
msc.type: config
---
Adding FTP Custom Authentication Providers &lt;add&gt;
====================
<a id="001"></a>
## Overview

The `<add>` element adds a provider to the collection of custom authentication providers.

When custom authentication providers are added to FTP sites, the FTP service will attempt to authenticate a user with each custom authentication provider that is enabled in the order that the providers are specified in the FTP configuration settings. In the event that the user cannot be authenticated by using any of the custom authentication providers, the FTP service will attempt to Basic authentication, if it is enabled, to authenticate the user.

The main advantage of using custom authentication providers is that user accounts do not have to be created on your server or domain. This improves your network's security.

> [!NOTE]
> FTP 7.0 and FTP 7.5 ship with two custom authentication providers:

- ASP.NET Membership authentication: This uses an ASP.NET membership database to validate user names and passwords. For more information, see the [Configuring FTP with .NET Membership Authentication](https://docs.microsoft.com/iis/publish/using-the-ftp-service/configuring-ftp-with-net-membership-authentication-in-iis-7) topic on Microsoft's IIS.net Web site.
- IIS Manager authentication: This uses the IIS management user store to validate user names and passwords. For more information, see the [Configure FTP with IIS 7.0 Manager Authentication](https://docs.microsoft.com/iis/publish/using-the-ftp-service/configure-ftp-with-iis-manager-authentication-in-iis-7) topic Microsoft's IIS.net Web site.

> [!NOTE]
> The custom authentication providers that are added to the `<customAuthentication/providers>` element must be registered in the [`<system.ftpServer/providerDefinitions>`](../../../../../../../../system.ftpserver/providerdefinitions/index.md) collection.

> [!NOTE]
> Support for creating custom authentication providers was introduced in FTP 7.5. For additional information about how to create custom authentication providers, see the [Developing for FTP 7.5](https://www.iis.net/learn/develop/developing-for-ftp) section of Microsoft's [www.iis.net/learn](https://www.iis.net/learn) Web site.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<add>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<add>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<add>` element of the `<providers>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<add>` element of the `<providers>` element was introduced in FTP 7.0, which was a separate download for IIS 7.0. |
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
    [![](add/_static/image2.png)](add/_static/image1.png) .
5. Click **Next**, and then on the **Select features** page, click **Next** again.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, and then select **FTP Server**.   
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select **FTP Extensibility**.   
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
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select **FTP Extensibility**.  
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
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select **FTP Extensibility**.   
    [![](add/_static/image8.png)](add/_static/image7.png)
5. Click **OK**.

### Windows Server 2008 or Windows Vista

1. Download the installation package from the following URL: 

    - [https://www.iis.net/expand/FTP](https://www.iis.net/downloads/microsoft/ftp)
2. Follow the instructions in the following walkthrough to install the FTP service: 

     - [Installing and Troubleshooting FTP 7](https://go.microsoft.com/fwlink/?LinkId=88547)

<a id="004"></a>
## How To

### How to enable IIS Manager authentication for an FTP site

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
3. In the site's **Home** pane, double-click the **FTP Authentication** feature.
4. When the **FTP Authentication** page displays, click **Custom Providers...** in the **Actions** pane.  
    [![](add/_static/image10.png)](add/_static/image9.png)
5. When the **Custom Providers** dialog box displays, click to select **IIS Manager Authentication**. Click **OK**.  
    [![](add/_static/image12.png)](add/_static/image11.png)
6. Your **FTP Authentication** page should now show **IIS Manager Authentication** enabled.  
    [![](add/_static/image14.png)](add/_static/image13.png)
7. If desired, you can disable **Basic Authentication** or **Anonymous Authentication** by highlighting either mode and clicking **Disable** in the **Actions** pane.

For additional information about how to configure IIS Manager authentication for FTP, see the [Configure FTP with IIS 7.0 Manager Authentication](https://docs.microsoft.com/iis/publish/using-the-ftp-service/configure-ftp-with-iis-manager-authentication-in-iis-7) topic on Microsoft's [www.iis.net/learn](https://www.iis.net/learn) Web site.

* * *

### How to add a managed-code custom authentication provider for an FTP site

> [!NOTE]
> These steps assume that a custom FTP authentication provider has already been installed and registered on your server's Global Assembly Cache (GAC.) For more information about how to register managed assemblies, see the [Global Assembly Cache Tool (Gacutil.exe)](https://msdn.microsoft.com/library/ex0ss12c(VS.80).aspx) topic on Microsoft the MSDN Web site.

1. Determine the assembly information for the extensibility provider: 

    - In Windows Explorer, open your "C:\Windows\assembly" path, where C: is your operating system drive.
    - Locate the assembly. For example, **FtpAuthenticationDemo**.
    - Right-click the assembly, and then click **Properties**.
    - Copy the **Culture** value. For example, **Neutral**.
    - Copy the **Version** number. For example, **1.0.0.0**.
    - Copy the **Public Key Token** value. For example, **426f62526f636b73**.
    - Click **Cancel**.
2. Add the extensibility provider to the global list of FTP authentication providers: 

    - Open **Internet Information Services (IIS) Manager**.
    - Click your computer name in the **Connections** pane.
    - Double-click **FTP Authentication** in the main window.  
        [![](add/_static/image16.png)](add/_static/image15.png)
    - Click **Custom Providers...** in the **Actions** pane.
    - Click **Register**.  
        [![](add/_static/image18.png)](add/_static/image17.png)
    - Enter a friendly name for the custom authentication provider in the **Name** box. For example, **FtpAuthenticationDemo**.
    - Click **Managed Provider (.NET)**.  
        [![](add/_static/image20.png)](add/_static/image19.png)
    - Enter the assembly information for the extensibility provider using the information that you copied earlier. For example:  
        **FtpAuthentication.FtpAuthDemo, FtpAuthenticationDemo, version=1.0.0.0, Culture=neutral, PublicKeyToken=426f62526f636b73**
    - Click **OK**.
    - Clear the check box for the custom authentication provider in the providers list.
    - Click **OK**.
3. Add the custom authentication provider for an FTP site: 

    - Open an FTP site in **Internet Information Services (IIS) Manager**.
    - Double-click **FTP Authentication** in the main window.
    - Click **Custom Providers...** in the **Actions** pane.
    - Check to select and enable the custom authentication provider in the providers list.
    - Click **OK**.

<a id="005"></a>
## Configuration

The `<add>` element of the `<providers>` element is configured at the site level.

### Attributes

| Attribute | Description |
| --- | --- |
| `name` | Required string attribute.<br><br>Specifies the friendly name of the custom authentication provider.<br><br>There is no default value. |
| `enabled` | Optional **Boolean** attribute.<br><br>**true** if the custom authentication provider is enabled; otherwise, **false**.<br><br>The default value is `true`. |

### Child Elements

None.

### Configuration Sample

The following sample displays an FTP site with a `<customAuthentication>` element that enables a custom authentication provider that is named *FtpAuthenticationDemo* and disables the built-in authentication providers.

[!code-xml[Main](add/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples add a custom authentication provider to an FTP site and enable it.

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
