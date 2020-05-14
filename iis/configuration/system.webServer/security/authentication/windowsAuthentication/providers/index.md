---
title: "Windows Authentication Providers &lt;providers&gt;"
author: rick-anderson
description: "Overview The &lt;providers&gt; collection of the &lt;windowsAuthentication&gt; element defines the list of authentication providers that are used with the In..."
ms.date: 09/26/2016
ms.assetid: 2f564d8e-2f32-4dc3-91d5-26c4c0f6863e
msc.legacyurl: /configreference/system.webserver/security/authentication/windowsauthentication/providers
msc.type: config
---
# Windows Authentication Providers &lt;providers&gt;

<a id="001"></a>
## Overview

The `<providers>` collection of the `<windowsAuthentication>` element defines the list of authentication providers that are used with the Internet Information Services (IIS) 7 Windows authentication module. This list of providers cannot be extended, and by default it contains only two entries:

- **Negotiate** - This provider will attempt to use Kerberos for authentication if it is available.
- **NTLM** - This provider will attempt to use Windows NT LAN Manager for authentication.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<providers>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<providers>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<providers>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<providers>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<providers>` element of the `<windowsAuthentication>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<providers>` collection replaces the IIS 6.0 **NTAuthenticationProviders** metabase property. |

<a id="003"></a>
## Setup

The default installation of IIS 7 and later does not include the Windows authentication role service. To use Windows authentication on IIS, you must install the role service, disable Anonymous authentication for your Web site or application, and then enable Windows authentication for the site or application.

> [!NOTE]
> After you install the role service, IIS 7 commits the following configuration settings to the ApplicationHost.config file.

[!code-xml[Main](index/samples/sample1.xml)]

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**.
2. In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**.
3. In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**.
4. On the **Server Roles** page, expand **Web Server (IIS)**, expand **Web Server**, expand **Security**, and then select **Windows Authentication**. Click **Next**.  
    [![](index/_static/image2.png)](index/_static/image1.png) .
5. On the **Select features** page, click **Next**.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Security**, and then select **Windows Authentication**.  
    [![](index/_static/image4.png)](index/_static/image3.png)
4. Click **OK**.
5. Click **Close**.

### Windows Server 2008 or Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, select **Windows Authentication**, and then click **Next**.   
    [![](index/_static/image6.png)](index/_static/image5.png)
5. On the **Confirm Installation Selections** page, click **Install**.
6. On the **Results** page, click **Close**.

### Windows Vista or Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. Expand **Internet Information Services**, then **World Wide Web Services**, then **Security**.
4. Select **Windows Authentication**, and then click **OK**.   
    [![](index/_static/image8.png)](index/_static/image7.png)
 
<a id="004"></a>
## How To

There is no user interface for Windows authentication providers for IIS 7. For examples of how to modify the list of Windows authentication providers programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>
## Configuration

### Attributes

None.

### Child Elements

| Element | Description |
| --- | --- |
| [`add`](add.md) | Optional element.<br><br>Adds a security provider to the collection of providers. Windows authentication requires at least one provider. |
| `remove` | Optional element.<br><br>Removes a reference to a security provider from the providers collection. |
| `clear` | Optional element.<br><br>Removes all references to providers from the provider collection. |

### Configuration Sample

The following default `<windowsAuthentication>` element is configured at the root ApplicationHost.config file in IIS 7.0, and disables Windows authentication by default. It also defines the two Windows authentication providers for IIS 7.0.

[!code-xml[Main](index/samples/sample2.xml)]

The following example enables Windows authentication and disables Anonymous authentication for a Web site named Contoso.

[!code-xml[Main](index/samples/sample3.xml)]
 
<a id="006"></a>
## Sample Code

The following code examples will enable Windows authentication and remove the Negotiate provider for a site named Contoso.

### AppCmd.exe

[!code-console[Main](index/samples/sample4.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C\#

[!code-csharp[Main](index/samples/sample5.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample6.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample7.js)]

### VBScript

[!code-vb[Main](index/samples/sample8.vb)]
