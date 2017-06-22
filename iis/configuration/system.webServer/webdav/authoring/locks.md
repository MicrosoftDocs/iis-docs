WebDAV Locks &lt;locks&gt;
====================
<a id="001"></a>
## Overview

The `<locks>` element of the `<authoring>` element defines the locking behavior for the WebDAV module. More specifically, the `<locks>` element contains attributes that define whether WebDAV locking is enabled, which lock store to use, and whether locking is required before clients can save changes to files for a server.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<locks>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<locks>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<locks>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<locks>` element of the `<authoring>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<locks>` element of the `<authoring>` element was introduced in WebDAV 7.0, which was a separate download for IIS 7.0. |
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
    [![](locks/_static/image2.png)](locks/_static/image1.png) . - On the **Select features** page, click **Next**. - On the **Confirm installation selections** page, click **Install**. - On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**. - In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**. - Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Common HTTP Features**, and then select **WebDAV Publishing**.  
    [![](locks/_static/image4.png)](locks/_static/image3.png)- Click **OK**.
- Click **Close**.

### Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**. - In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**. - In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**. - On the **Select Role Services** page of the **Add Role Services Wizard**, expand **Common HTTP Features**, select **WebDAV Publishing**, and then click **Next**.   
    [![](locks/_static/image6.png)](locks/_static/image5.png)- On the **Confirm Installation Selections** page, click **Install**. - On the **Results** page, click **Close**.

### Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**. - In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**. - Expand **Internet Information Services**, then **World Wide Web Services**, and then **Common HTTP Features**. - Select **WebDAV Publishing**, and then click **OK**.   
    [![](locks/_static/image8.png)](locks/_static/image7.png)

### Windows Server 2008 or Windows Vista

- Download the installation package from the following URL: 

    - [https://www.iis.net/expand/WebDAV](https://www.iis.net/downloads/microsoft/webdav)
- Follow the instructions in the following walkthrough to install the WebDAV module: 

    - [Installing and Configuring WebDAV on IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=105146)

<a id="004"></a>
## How To

### How to configure WebDAV locking for a Web site

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
3. In the site's **Home** pane, double-click **WebDAV Authoring Rules**.  
    [![](locks/_static/image10.png)](locks/_static/image9.png)
4. When the **WebDAV Authoring Rules** page is displayed, click **WebDAV Settings** in the **Actions** pane.
5. When the **WebDAV Settings** page is displayed, specify the following options in the **Lock Behavior** section:

    - Set **Allow Locks** to **True**.
    - For **Lock Store**, choose **webdav\_simple\_lock** from the drop-down list.
    - Set **Require Lock for Writing** to your desired setting.  
        [![](locks/_static/image12.png)](locks/_static/image11.png)
6. Once you have completed the steps, click **Apply** in the **Actions** pane.

<a id="005"></a>
## Configuration

The `<locks>` element is configurable only at the site level in the ApplicationHost.config file. Any `<locks>` elements at other levels or in Web.config files are ignored.

### Attributes

| Attribute | Description |
| --- | --- |
| `enabled` | Optional **Boolean** attribute. **true** if WebDAV locking is enabled; otherwise, **false**. The default value is `false`. |
| `lockStore` | Optional string attribute. Specifies the name of the provider to use for WebDAV locking. This name must be defined in the [&lt;lockStores&gt;](../../../system.webserver/webdav/globalsettings/lockstores.md) collection. This attribute has no default value. |
| `requireLockForWriting` | Optional **Boolean** attribute. **true** if locks are required for WebDAV authoring; otherwise, **false**. Requiring locks for WebDAV authoring helps to prevent collisions in a multi-source authoring environment. The default value is `false`. |

### Child Elements

None.

### Configuration Sample

The following example lists a sample `<webdav>` element for the Default Web Site. This example clears any existing authoring rules, adds a single rule for the administrators group, enables WebDAV authoring, specifies that hidden files are allowed, enables WebDAV locks and specifies the lock provider, and enables WebDAV properties and specifies the default XML namespace for property mapping.

[!code-xml[Main](locks/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples enable WebDAV locks for the Default Web Site by using the simple lock provider, and configure the site so that locks are not required for WebDAV authoring.

### AppCmd.exe

[!code-console[Main](locks/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](locks/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](locks/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](locks/samples/sample5.js)]

### VBScript

[!code-vb[Main](locks/samples/sample6.vb)]