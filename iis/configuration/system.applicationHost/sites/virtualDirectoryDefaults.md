---
title: "Virtual Directory Defaults for All Sites &lt;virtualDirectoryDefaults&gt;"
author: rick-anderson
description: "Overview The &lt;virtualDirectoryDefaults&gt; element of the &lt;sites&gt; element specifies default settings for all virtual directories on the server. The..."
ms.date: 09/26/2016
ms.assetid: 2c69e201-3575-4745-9712-75be6affd344
msc.legacyurl: /configreference/system.applicationhost/sites/virtualdirectorydefaults
msc.type: config
---
Virtual Directory Defaults for All Sites &lt;virtualDirectoryDefaults&gt;
====================
<a id="001"></a>
## Overview

The `<virtualDirectoryDefaults>` element of the `<sites>` element specifies default settings for all virtual directories on the server. The `<virtualDirectoryDefaults>` element is useful for defining the common attributes that you want all virtual directories on your server to implicitly share when they do not have explicitly-defined attributes.

> [!NOTE]
> If the same attribute or child element is configured in both the `<virtualDirectoryDefaults>` section and in the `<virtualDirectory>` section for a specific virtual directory, the configuration in the `<virtualDirectory>` section is used for that virtual directory.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<virtualDirectoryDefaults>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<virtualDirectoryDefaults>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<virtualDirectoryDefaults>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<virtualDirectoryDefaults>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<virtualDirectoryDefaults>` element of the `<sites>` element was introduced in IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

The `<virtualDirectoryDefaults>` element of the `<sites>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

### How to configure the default virtual directory credentials for a server

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
2. In the **Connections** pane, expand the server name, then click the **Sites** node.
3. In the server's **Sites** pane, click **Set Web Site Defaults...** in the **Actions** pane.  
    [![](virtualDirectoryDefaults/_static/image2.png)](virtualDirectoryDefaults/_static/image1.png)
4. In the **Web Site Defaults** dialog box, specify your default virtual directory credentials for all Web sites, and then click **OK**.  
    [![](virtualDirectoryDefaults/_static/image4.png)](virtualDirectoryDefaults/_static/image3.png)

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `allowSubDirConfig` | Optional Boolean attribute. <br><br>Specifies whether IIS looks for Web.config files in content directories lower in the directory hierarchy than the current level (**true**) or does not look for Web.config files in content directories lower than the current level (**false**). <br><br>The default value is `true`. |
| `logonMethod` | Optional enum attribute. <br><br>Specifies the default logon method for all virtual directories on the server. <br><br>The **logonMethod** attribute can have one of the following possible values. The default is `ClearText`. <table> <tbody> <tr> <th>Value</th> <th>Description</th></tr> <tr> <th><code>Batch</code></th> <td>This logon type is intended for batch servers, where processes may be executing on behalf of a user without that user's direct intervention. <br><br>The numeric value is <code>1</code>.</td></tr> <tr> <th><code>ClearText</code></th> <td>This logon type preserves the name and password in the authentication package. This allows the server to make connections to other network servers while impersonating the client. <br><br>The numeric value is <code>3</code>.</td></tr> <tr> <th><code>Interactive</code></th> <td>This logon type is intended for users who will be using the computer interactively.<br><br>The numeric value is <code>0</code>.</td></tr> <tr> <th><code>Network</code></th> <td>This logon type is intended for high performance servers that authenticate plaintext passwords. Credentials are not cached for this logon type. <br><br>The numeric value is <code>2</code>.</td></tr></tbody></table>For more information about these values, see [LogonUser](https://msdn.microsoft.com/library/aa378184.aspx) on the MSDN site. |
| `password` | Optional string attribute. <br><br>Specifies the password associated with the user name. <br><br>**Note:** To avoid storing unencrypted password strings in configuration files, always use AppCmd.exe or IIS Manager to enter passwords. If you use these management tools, the password strings will be encrypted automatically before they are written to the XML configuration files. This provides better password security than storing unencrypted passwords. |
| `path` | Optional string attribute. <br><br>Specifies the default virtual path of all virtual directories on the server. |
| `physicalPath` | Optional string attribute. <br><br>Specifies the default physical path of all virtual directories on the server. |
| `userName` | Optional string attribute. <br><br>Specifies the default user name of an account that can access configuration files and content for all virtual directories on the server. |

### Child Elements

None.

### Configuration Sample

The following configuration sample specifies the default logon method for all virtual directories on the server.

[!code-xml[Main](virtualDirectoryDefaults/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code samples specify the default logon method for all virtual directories on the server.

### AppCmd.exe

[!code-console[Main](virtualDirectoryDefaults/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C\#

[!code-csharp[Main](virtualDirectoryDefaults/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](virtualDirectoryDefaults/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](virtualDirectoryDefaults/samples/sample5.js)]

### VBScript

[!code-vb[Main](virtualDirectoryDefaults/samples/sample6.vb)]
