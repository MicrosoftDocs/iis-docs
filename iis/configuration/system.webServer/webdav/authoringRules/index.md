WebDAV Authoring Rules &lt;authoringRules&gt;
====================
<a id="001"></a>
## Overview

The `<authoringRules>` element can be defined per-URI within a Web site, and specifies the WebDAV authoring permissions for that URI space. The permissions in this element are inherited, so child URIs will have the same permissions as a parent URI, provided that the child URI does not have unique permissions defined.

The element contains a series of [`<add>`](add.md) elements that define the individual authoring rules, which contain the access permissions for users or groups for specific content types.

WebDAV authoring rules may seem somewhat analogous to authorization settings that are found in the [`<authorization>`](../security/authorization/index.md) element, but are stored separately so that IIS maintains two different sets of authorization: one for regular HTTP (non-WebDAV) requests and the other for WebDAV requests.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<authoringRules>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<authoringRules>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<authoringRules>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<authoringRules>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<authoringRules>` element was introduced in WebDAV 7.0, which was a separate download for IIS 7.0. |
| IIS 6.0 | N/A |

> [!NOTE]
> The WebDAV 7.0 and WebDAV 7.5 modules shipped out-of-band for IIS 7.0, which required downloading and installing the modules from the following URL:

> [https://www.iis.net/expand/WebDAV](https://www.iis.net/downloads/microsoft/webdav)


With Windows 7 and Windows Server 2008 R2, the WebDAV 7.5 module ships as a feature for IIS 7.5, so downloading WebDAV is no longer necessary.

<a id="003"></a>
## Setup

To support WebDAV publishing for your Web server, you must install the WebDAV module. To do so, use the following steps.

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**. - In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**. - In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**. - On the **Server Roles** page, expand **Web Server (IIS)**, expand **Web Server**, expand **Common HTTP Features**, and then select **WebDAV Publishing**. Click **Next**.  
    [![](index/_static/image2.png)](index/_static/image1.png) . - On the **Select features** page, click **Next**. - On the **Confirm installation selections** page, click **Install**. - On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**. - In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**. - Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Common HTTP Features**, and then select **WebDAV Publishing**.  
    [![](index/_static/image4.png)](index/_static/image3.png)- Click **OK**.
- Click **Close**.

### Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**. - In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**. - In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**. - On the **Select Role Services** page of the **Add Role Services Wizard**, expand **Common HTTP Features**, select **WebDAV Publishing**, and then click **Next**.   
    [![](index/_static/image6.png)](index/_static/image5.png)- On the **Confirm Installation Selections** page, click **Install**. - On the **Results** page, click **Close**.

### Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**. - In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**. - Expand **Internet Information Services**, then **World Wide Web Services**, and then **Common HTTP Features**. - Select **WebDAV Publishing**, and then click **OK**.   
    [![](index/_static/image8.png)](index/_static/image7.png)

### Windows Server 2008 or Windows Vista

- Download the installation package from the following URL: 

    - [https://www.iis.net/expand/WebDAV](https://www.iis.net/downloads/microsoft/webdav)
- Follow the instructions in the following walkthrough to install the WebDAV module: 

    - [Installing and Configuring WebDAV on IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=105146)

<a id="004"></a>
## How To

### How to add WebDAV authoring rules

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
2. In the **Connections** pane, expand the server name, and then go to the site, application, or directory where you want to enable directory browsing.
3. In the **Home** pane, double-click **WebDAV Authoring Rules**.  
    [![](index/_static/image10.png)](index/_static/image9.png)
4. In the **Actions** pane, click **Add Authoring Rule...**  
    [![](index/_static/image12.png)](index/_static/image11.png)
5. In the **Add Authoring Rule** dialog, specify the following options: 

    - **Allow access to**: Specify whether the authoring rule should apply to all content types, or specify specific content types to allow.
    - **Allow access to this content to**: Specify whether the authoring rule should apply to all users, to specific groups or roles, or to specific users.
    - **Permissions**: Specify whether the authoring rule should allow **Read**, **Write**, or **Source** access for the specified content types and users.  
        [![](index/_static/image14.png)](index/_static/image13.png)
6. Click **OK**.

<a id="005"></a>
## Configuration

The `<authoringRules>` element is configurable per-URI in the ApplicationHost.config file. Settings can be stored globally, at the site level, or per folder. The `<authoringRules>` element cannot be delegated, so any `<authoringRules>` elements in Web.config files are ignored.

### Attributes

| Attribute | Description |
| --- | --- |
| `defaultAccess` | Optional flags attribute. Specifies the default access settings for WebDAV authoring. These values combined with a logical OR operation, so "None, Read" = "Read." <br><br>**Note:** `Source` access allows a WebDAV client to request the contents of a script-mapped file, such as an ASP.NET or PHP file, as opposed to the processed output of the file. The default value is `None`. | Value | Description | | --- | --- | | `None` | No authoring is allowed. The numeric value is `0`. | | `Read` | Read access is allowed. The numeric value is `1`. | | `Write` | Write access is allowed. The numeric value is `2`. | | `Source` | Access to source code is allowed. The numeric value is `16`. | |
| `allowNonMimeMapFiles` | Optional **Boolean** attribute. **true** if WebDAV requests should be allowed for files that are not defined in the MIME map; otherwise, **false**. For example, files that are script-mapped are not defined in the MIME map, but Web authors may still need to edit these files, which are not allowed in IIS requests by default. When set to **true**, the WebDAV module will accept requests for files that are not included in the MIME map. When set to **false**, the module will require that all files are found in the MIME map and return a "404.3 - MIME map policy prevents this request" error for any request that does not match the MIME list. The default value is `false`. |
| `defaultMimeType` | Optional string attribute. Specifies the default MIME type for files that do not have an explicit MIME type defined. The default value is `application/octet-stream`. |

### Child Elements

| Element | Description |
| --- | --- |
| [`add`](add.md) | Optional element. Adds an authoring rule to the collection of authoring rules. |
| `clear` | Optional element. Clears the collection of authoring rules. |
| `remove` | Optional element. Removes an authoring rule from the collection of authoring rules. |

### Configuration Sample

The following example lists a sample `<webdav>` element for the Default Web Site. This example clears any existing authoring rules, adds a single rule for the administrators group, enables WebDAV authoring, specifies that hidden files are allowed, enables WebDAV locks and specifies the lock provider, and enables WebDAV properties and specifies the default XML namespace for property mapping.

[!code-xml[Main](index/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples configure WebDAV authoring rules so that WebDAV clients can publish files that are not listed in the IIS MIME map, and add a single authoring rule that grants Read, Write, and Source access to the *administrators* group.

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