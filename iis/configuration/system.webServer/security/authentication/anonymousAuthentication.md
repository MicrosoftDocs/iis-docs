---
title: "Anonymous Authentication &lt;anonymousAuthentication&gt;"
author: rick-anderson
description: "Overview The &lt;anonymousAuthentication&gt; element controls how Internet Information Services (IIS) 7 processes requests from anonymous users. You can modi..."
ms.date: 09/26/2016
ms.assetid: e4e575b6-9269-4e4b-b194-ed910b36da2f
msc.legacyurl: /configreference/system.webserver/security/authentication/anonymousauthentication
msc.type: config
---
# Anonymous Authentication &lt;anonymousAuthentication&gt;

<a id="001"></a>
## Overview

The `<anonymousAuthentication>` element controls how Internet Information Services (IIS) 7 processes requests from anonymous users. You can modify the `<anonymousAuthentication>` element to disable Anonymous authentication, or you can configure Internet Information Services (IIS) to use a custom user account to process anonymous requests.

Anonymous authentication gives users access to the public areas of your Web or FTP site without prompting them for a user name or password. By default, the IUSR account, which was introduced in IIS 7.0 and replaces the IIS 6.0 IUSR\_computername account, is used to allow anonymous access. An application is a grouping of files that delivers content or provides services over protocols, such as HTTP. When you create an application in IIS, the application's path becomes part of the site's URL.

By default, IIS 7 uses Anonymous authentication. You must disable Anonymous authentication for any Web site, Web application, or Web service for which you want to enable other authentication methods such as Basic or Windows authentication.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<anonymousAuthentication>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<anonymousAuthentication>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<anonymousAuthentication>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<anonymousAuthentication>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<anonymousAuthentication>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<anonymousAuthentication>` element replaces the IIS 6.0 **AuthFlags**, **AnonymousUserName**, and **AnonymousUserPassword** metabase properties. |

<a id="003"></a>
## Setup

The `<anonymousAuthentication>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

### How to disable anonymous authentication

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
2. In the **Connections** pane, expand the server name, expand **Sites**, and go to the level in the hierarchy pane that you want to configure, and then click the Web site or Web application.
3. Scroll to the **Security** section in the **Home** pane, and then double-click **Authentication**.
4. In the **Authentication** pane, select **Anonymous Authentication**, and then click **Disable** in the **Actions** pane.  
    ![](anonymousAuthentication/_static/image1.png)

### How to change anonymous authentication credentials from the IUSR account

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
2. In the **Connections** pane, expand the server name, expand **Sites**, and navigate to the level in the hierarchy pane that you want to configure, and then click the Web site or Web application.
3. Scroll to the **Security** section in the **Home** pane, and then double-click **Authentication**.
4. In the **Authentication** pane, select **Anonymous Authentication**, and then click **Edit...** in the **Actions** pane.
5. In the **Edit Anonymous Authentication Credentials** dialog box, do one of the following:

    - Select **Application pool identity** to use the identity set for the application pool, and then click **OK**.  
        ![](anonymousAuthentication/_static/image3.png)
    - Click **Set...**, and then in the **Set Credentials** dialog box, enter the user name for the account in the **User name** box, enter the password for the account in the **Password** and **Confirm password** boxes, click **OK**, and then click **OK** again.  
        ![](anonymousAuthentication/_static/image5.png)

    > [!NOTE]
    > If you use this procedure, only grant the new account minimal privileges on the IIS server computer.

<a id="005"></a>
## Configuration

The `<anonymousAuthentication>` element is configurable at the site and application level in the Web.config file.

### Attributes

| Attribute | Description |
| --- | --- |
| `enabled` | Optional Boolean attribute.<br><br>Specifies whether Anonymous authentication is enabled. <br><br>The default value is `true`. |
| `logonMethod` | Optional enum attribute.<br><br>The **logonMethod** attribute can be one of the following possible values. The default is `ClearText`. <table> <tbody> <tr> <th>Value</th> <th>Description</th></tr> <tr> <th><code>Batch</code></th> <td>This logon type is intended for batch servers, where processes may be executing on behalf of a user without that user's direct intervention.<br><br>The numeric value is <code>1</code>.</td></tr> <tr> <th><code>ClearText</code></th> <td>This logon type preserves the name and password in the authentication package, which allows the server to make connections to other network servers while impersonating the client.<br><br>The numeric value is <code>3</code>.</td></tr> <tr> <th><code>Interactive</code></th> <td>This logon type is intended for users who will be using the computer interactively.<br><br>The numeric value is <code>0</code>.</td></tr> <tr> <th><code>Network</code></th> <td>This logon type is intended for high performance servers to authenticate plaintext passwords. Credentials are not cached for this logon type.<br><br>The numeric value is <code>2</code>.</td></tr></tbody></table> |
| `password` | Optional String attribute.<br><br>Specifies the password for Anonymous authentication. <br><br>**Note:** To avoid storing unencrypted password strings in configuration files, always use AppCmd.exe or IIS Manager to enter passwords. If you use these management tools, the password strings will be encrypted automatically before they are written to the XML configuration files. This provides better password security than storing unencrypted passwords. |
| `username` | Optional String attribute.<br><br>Specifies the username for Anonymous authentication. If you leave this value blank (that is, username=""), Anonymous authentication uses the application pool identity to authenticate anonymous users.<br><br>The default value is `IUSR`. |

### Child Elements

None.

### Configuration Sample

The following configuration example configures anonymous authentication for an IIS 7 Web site or Web application to use a local account on the Web server. (IIS 7 automatically uses AES encryption to encrypt the password.)

[!code-xml[Main](anonymousAuthentication/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples enable anonymous authentication and change the default username and password used for anonymous authentication to an account named **IUSR** and a password of **P\@ssw0rd**.

### AppCmd.exe

[!code-console[Main](anonymousAuthentication/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](anonymousAuthentication/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](anonymousAuthentication/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](anonymousAuthentication/samples/sample5.js)]

### VBScript

[!code-vb[Main](anonymousAuthentication/samples/sample6.vb)]
