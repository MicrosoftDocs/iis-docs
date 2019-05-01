---
title: "FTP User Isolation &lt;userIsolation&gt;"
author: rick-anderson
description: "Overview The &lt;userIsolation&gt; element is used to start or restrict FTP clients in specific sections of an FTP site. Depending on the options that are sp..."
ms.date: 09/26/2016
ms.assetid: 5a16156c-bf25-47d7-bca1-0803fd336236
msc.legacyurl: /configreference/system.applicationhost/sites/site/ftpserver/userisolation
msc.type: config
---
FTP User Isolation &lt;userIsolation&gt;
====================
<a id="001"></a>
## Overview

The `<userIsolation>` element is used to start or restrict FTP clients in specific sections of an FTP site. Depending on the options that are specified in the `<userIsolation>` element, server administrators can prevent unauthorized access between users in a shared server environment where a single FTP site is shared between mutiple user accounts.

FTP user isolation was introduced in IIS 6.0, but has been significantly updated in FTP 7.0 and FTP 7.5. All of the previous FTP user isolation features remain available for backward compatibility, but the following options are now possible for the user isolation mode:

> | Mode | Description |
> | --- | --- |
> | None | Specifying this mode in FTP 7.0 and FTP 7.5 will configure user isolation to always start a FTP clients in the root of the FTP site. (This was not possible in IIS 6.0.) Note: If they have sufficient permissions, any FTP user can potentially access the content of any other FTP user within that FTP site. |
> | StartInUsersDirectory | In IIS 6.0, if a directory existed with the same name as a user account and user isolation was disabled, FTP clients would start in the directory for the user name. This is still possible in FTP 7.0 and FTP 7.5 by specifying **StartInUsersDirectory** for the mode. Note: If they have sufficient permissions, any FTP user can potentially access the content of any other FTP user within that FTP site. |
> | IsolateRootDirectoryOnly | In IIS 6.0, it was possible to use global virtual directories if you enabled user isolation and created physical directories for users to start in when they first logged on to the server. If you wanted to share content between a number of FTP users, you could create global virtual directories. This option is still available in FTP 7.0 and FTP 7.5 by specifying **IsolateRootDirectoryOnly** for the mode. |
> | IsolateAllDirectories | When specifying this mode in FTP 7.0 and FTP 7.5, FTP clients will start in a directory that matches the name of their user account when they first logon to the server. By using this mode, you can use virtual directories for each of these accounts; you are no longer required to create a physical directory. (This was not possible in IIS 6.0.) However, if you use this option, you can no longer use global virtual directories. To share a folder between multiple FTP users, you must create a virtual directory to the global path for each user. |
> | ActiveDirectory | When specifying this mode in FTP 7.0 and FTP 7.5, the FTP service will retrieve the user isolation settings from each user's account in their Active Directory settings; this mode works the same as IIS 6.0. |
> | Custom | With FTP 7.5, you can now specify **Custom** for the user isolation mode. This mode allows you to use FTP extensibility to provide custom user isolation by creating a custom FTP provider. |


When using either the **IsolateRootDirectoryOnly** or **IsolateAllDirectories** modes for user isolation, the physical or virtual directory paths must use the following hierarchy:

> | User Account Types | Home Directory Syntax |
> | --- | --- |
> | Anonymous users | %*FtpRoot*%\LocalUser\Public |
> | Local Windows user accounts (Requires Basic authentication) | %*FtpRoot*%\LocalUser\%*UserName*% |
> | Windows domain accounts (Requires Basic authentication) | %*FtpRoot*%\%UserDomain%\%*UserName*% |
> | IIS Manager or ASP.NET custom authentication user accounts | %*FtpRoot*%\LocalUser\%*UserName*% |


<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<userIsolation>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<userIsolation>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<userIsolation>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<userIsolation>` element of the `<ftpServer>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<userIsolation>` element of the `<ftpServer>` element was introduced in FTP 7.0, which was a separate download for IIS 7.0. |
| IIS 6.0 | N/A |

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
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will need to select     **FTP Extensibility** , in addition to     **FTP Service** .  
    [![](index/_static/image2.png)](index/_static/image1.png) .
5. Click **Next**, and then on the **Select features** page, click **Next** again.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, and then select **FTP Server**.   
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select     **FTP Extensibility** .   
    [![](index/_static/image4.png)](index/_static/image3.png)
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
    [![](index/_static/image6.png)](index/_static/image5.png)
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
    [![](index/_static/image8.png)](index/_static/image7.png)
5. Click **OK**.

### Windows Server 2008 or Windows Vista

1. Download the installation package from the following URL: 

    - [https://www.iis.net/expand/FTP](https://www.iis.net/downloads/microsoft/ftp)
2. Follow the instructions in the following walkthrough to install the FTP service: 

     - [Installing and Troubleshooting FTP 7](https://go.microsoft.com/fwlink/?LinkId=88547)

<a id="004"></a>
## How To

### How to isolate users in virtual directories

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
2. In the **Connections** pane, expand the server name, expand the **Sites** node, then click the name of the site.
3. In the site's **Home** pane, double-click **FTP User Isolation**.  
    [![](index/_static/image10.png)](index/_static/image9.png)
4. On the **FTP User Isolation** page, under **Isolate users. Restrict users to the following directory:** , select **User name directory (disable global virtual directories)**.  
    [![](index/_static/image12.png)](index/_static/image11.png)
5. In the **Actions** pane, click **Apply**.

* * *

### How to isolate users using Active Directory

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
3. In the site's **Home** pane, double-click **FTP User Isolation**.  
    [![](index/_static/image14.png)](index/_static/image13.png)
4. On the **FTP User Isolation** page, under **Isolate users. Restrict users to the following directory:** , select **FTP home directory configured in Active Directory** and then click **Set**.  
    [![](index/_static/image16.png)](index/_static/image15.png)
5. In the **Set Credentials** dialog box, enter a user name and password in the **User name** and **Password** boxes. Enter the password again in the **Confirm Password** box, and then click **OK**.
6. In the **Actions** pane, click **Apply**.

For additional information about how to set up the Active Directory, see the "Isolate Users Using Active Directory Mode" section in the [Hosting Multiple FTP Sites with FTP User Isolation (IIS 6.0)](https://go.microsoft.com/fwlink/?LinkId=99787) topic.

<a id="005"></a>
## Configuration

The `<userIsolation>` element is configured at the site level.

### Attributes

| Attribute | Description |
| --- | --- |
| `mode` | Optional enum attribute.<br><br>Specifies the user isolation mode. <table> <tbody> <tr> <th>Name</th> <th>Description</th></tr> <tr> <th><code>StartInUsersDirectory</code></th> <td>Specifies that user isolation should not be used, but start a session in user's directory if it exists.<br><br>The numeric value is <code>0</code>.</td></tr> <tr> <th><code>IsolateRootDirectoryOnly</code></th> <td> <p>Specifies that user isolation should isolate only the root directory. Users' home directories must be physical directories, and global virtual directories can still be used.<br><br>The numeric value is <code>1</code>.</p></td></tr> <tr> <th><code>ActiveDirectory</code></th> <td>Isolates users based on Active Directory settings.<br><br>The numeric value is <code>2</code>.</td></tr> <tr> <th><code>IsolateAllDirectories</code></th> <td> <p>Specifies that user isolation should isolate all directories. User's home directories can be either physical directories or virtual directories, but global virtual directories are ignored; all virtual directories must be explicitly created under each user's home path.<br><br>The numeric value is <code>3</code>.</p></td></tr> <tr> <th><code>None</code></th> <td>Specifies that no user isolation should not be used.<br><br>The numeric value is <code>4</code>.</td></tr> <tr> <th><code>Custom</code></th> <td>Specifies that a custom FTP provider will implement the user isolation.<br><br>The numeric value is <code>5</code>.</td></tr></tbody></table>The default value is `None`. |

### Child Elements

| Element | Description |
| --- | --- |
| [`activeDirectory`](activedirectory.md) | Optional element.<br><br>Specifies the connection credentials and time-out for communicating with an Active Directory server. |

### Configuration Sample

The following sample displays a `<userIsolation>` element for an FTP site that configures the FTP service to use Active Directory for user isolation that site, and configures the credentials for the connection to the Active Directory server.

[!code-xml[Main](index/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples configure Active Directory user isolation for an FTP site.

### AppCmd.exe

[!code-console[Main](index/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](index/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample5.js)]

### VBScript

[!code-vb[Main](index/samples/sample6.vb)]