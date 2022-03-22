---
title: "Windows Authentication &lt;windowsAuthentication&gt;"
author: rick-anderson
description: "Overview The &lt;windowsAuthentication&gt; element defines configuration settings for the Internet Information Services (IIS) 7 Windows authentication module..."
ms.date: 09/26/2016
ms.assetid: 0d453336-cfb0-401f-a04b-ff67da721b96
msc.legacyurl: /configreference/system.webserver/security/authentication/windowsauthentication
msc.type: config
---
# Windows Authentication &lt;windowsAuthentication&gt;

<a id="001"></a>
## Overview

The `<windowsAuthentication>` element defines configuration settings for the Internet Information Services (IIS) 7 Windows authentication module. You can use Windows authentication when your IIS 7 server runs on a corporate network that is using Microsoft Active Directory service domain identities or other Windows accounts to identify users. Because of this, you can use Windows authentication whether or not your server is a member of an Active Directory domain.

Windows authentication (formerly named NTLM, and also referred to as Windows NT Challenge/Response authentication) is a secure form of authentication because the user name and password are hashed before being sent across the network. When you enable Windows authentication, the client browser sends a strongly hashed version of the password in a cryptographic exchange with your Web server.

Windows authentication supports two authentication protocols, Kerberos and NTLM, which are defined in the `<providers>` element. When you install and enable Windows authentication on IIS 7, the default protocol is Kerberos. The `<windowsAuthentication>` element can also contain a **useKernelMode** attribute that configures whether to use the kernel mode authentication feature that is new to Windows Server 2008.

Windows authentication is best suited for an intranet environment for the following reasons:

- Client computers and Web servers are in the same domain.
- Administrators can make sure that every client browser is Internet Explorer 2.0 or later.
- HTTP proxy connections, which are not supported by NTLM, are not required.
- Kerberos version 5 requires a connection to Active Directory, which is not feasible in an Internet environment.

#### New in IIS 7.5

The [`<extendedProtection>`](extendedprotection/index.md) element was introduced in IIS 7.5, which allows you to configure the settings for the new extended protection features that have been integrated into Windows authentication.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<windowsAuthentication>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<windowsAuthentication>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<windowsAuthentication>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<extendedProtection>` element was added in IIS 7.5. |
| IIS 7.0 | The `<windowsAuthentication>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<windowsAuthentication>` element replaces portions of the IIS 6.0 **AuthType** and **AuthFlags** metabase properties. |

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
    [![Screenshot of the Server Roles page with the Windows Authentication option being highlighted.](index/_static/image2.png)](index/_static/image1.png) .
5. On the **Select features** page, click **Next**.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Security**, and then select **Windows Authentication**.  
    [![Screenshot of the Internet Information Services folder's contained folders, with the Windows Authentication folder being highlighted.](index/_static/image4.png)](index/_static/image3.png)
4. Click **OK**.
5. Click **Close**.

### Windows Server 2008 or Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, select **Windows Authentication**, and then click **Next**.   
    [![Screenshot of the Select Role Services page with the Windows Authentication option being highlighted.](index/_static/image6.png)](index/_static/image5.png)
5. On the **Confirm Installation Selections** page, click **Install**.
6. On the **Results** page, click **Close**.

### Windows Vista or Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. Expand **Internet Information Services**, then **World Wide Web Services**, then **Security**.
4. Select **Windows Authentication**, and then click **OK**.   
    [![Screenshot of the expandable Internet Information Services folder with the Windows Authentication folder being highlighted.](index/_static/image8.png)](index/_static/image7.png)
 
<a id="004"></a>
## How To

### How to enable Windows authentication for a Web site, Web application, or Web service

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
2. In the **Connections** pane, expand the server name, expand **Sites**, and then the site, application, or Web service for which you want to enable Windows authentication.
3. Scroll to the **Security** section in the **Home** pane, and then double-click **Authentication**.
4. In the **Authentication** pane, select **Windows Authentication**, and then click **Enable** in the **Actions** pane.   
    [![Screenshot of the Authentication pane.](index/_static/image10.png)](index/_static/image9.png)

* * *

### How to enable Extended Protection for Windows authentication

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
2. In the **Connections** pane, expand the server name, expand **Sites**, and then the site, application, or Web service for which you want to enable Extended Protection for Windows authentication.
3. Scroll to the **Security** section in the **Home** pane, and then double-click **Authentication**.
4. In the **Authentication** pane, select **Windows Authentication**.
5. Click **Enable** in the **Actions** pane.  
    [![Screenshot of the Authentication pane and its Group by field.](index/_static/image12.png)](index/_static/image11.png)
6. Click **Advanced Settings** in the **Actions** pane.
7. When the **Advanced Settings** dialog box appears, select one of the following options in the **Extended Protection** drop-down menu: 

    - Select **Accept** if you want to enable extended protection while providing down-level support for clients that do not support extended protection.
    - Select **Required** if you want to enable extended protection without providing down-level support.  
        [![Screenshot of the Advanced Settings dialog box with the Extended Protection field's Accept option being highlighted.](index/_static/image14.png)](index/_static/image13.png)
8. Click OK to close the **Advanced Settings** dialog box.

<a id="005"></a>
## Configuration

The `<windowsAuthentication>` element is configurable at the site, application, or virtual directory level in the ApplicationHost.config file.

### Attributes

| Attribute | Description |
| --- | --- |
| `authPersistNonNTLM` | Optional **Boolean** attribute. <br><br>Specifies whether IIS automatically reauthenticates every non-NTLM (for example, Kerberos) request, even those on the same connection. **False** enables multiple authentications for the same connections. <br><br>**Note:** A setting of **true** means that the client will be authenticated only once on the same connection. IIS will cache a token or ticket on the server for a TCP session that stays established.<br><br>The default is `false`. |
| `authPersistSingleRequest` | Optional **Boolean** attribute.<br><br>Setting this flag to **true** specifies that authentication persists only for a single request on a connection. IIS resets the authentication at the end of each request, and forces reauthentication on the next request of the session.<br><br>The default value is `false`. |
| `enabled` | Required **Boolean** attribute.<br><br>Specifies whether Windows authentication is enabled. <br><br>The default value is `false`. |
| `useKernelMode` | Optional **Boolean** attribute. <br><br>Specifies whether Windows authentication is done in kernel mode. **True** specifies that Windows authentication uses kernel mode. <br><br>Kernel-mode authentication may improve authentication performance and prevent authentication problems with application pools that are configured to use a custom identity. <br><br>As a best practice, do not disable this setting if you use Kerberos authentication and have a custom identity on the application pool.<br><br>The default is `true`. |

### Child Elements

| Element | Description |
| --- | --- |
| [`extendedProtection`](extendedprotection/index.md) | Optional element.<br><br>Specifies extended protection options for Windows authentication.<br><br>**Note:** This element was added in IIS 7.5. |
| [`providers`](providers/index.md) | Optional element.<br><br>Specifies security support providers used for Windows authentication. |

### Configuration Sample

The following default `<windowsAuthentication>` element is configured at the root ApplicationHost.config file in IIS 7.0, and disables Windows authentication by default. It also defines the two Windows authentication providers for IIS 7.0.

[!code-xml[Main](index/samples/sample2.xml)]

The following example enables Windows authentication and disables Anonymous authentication for a Web site named Contoso.

[!code-xml[Main](index/samples/sample3.xml)]
 
<a id="006"></a>
## Sample Code

The following examples disable Anonymous authentication for a site named Contoso, then enable Windows authentication for the site.

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
