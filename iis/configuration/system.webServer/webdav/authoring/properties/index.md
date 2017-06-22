WebDAV Properties &lt;properties&gt;
====================
<a id="001"></a>
## Overview

The `<properties>` element of the `<authoring>` element defines the locking behavior for the WebDAV module. More specifically, the `<properties>` element contains attributes that define whether custom WebDAV properties are enabled, whether anonymous or infinite property requests are allowed, and may contain a series of [`<add>`](add.md) elements that define mappings for XML namespaces to property store providers.

> [!NOTE]
> WebDAV defines two types of properties:

- "Live" properties: These properties exist in the underlying file system. For example, the file name and file size. These properties are always supported.
- "Dead" properties: These properties are user-defined and are stored in a property store. For example, the author of a document or the template that was used.

In order to use "dead" properties, you must set the `allowCustomProperties` of the `<properties>` element to **true**, and define a mapping for an XML namespace to property provider from the list of property providers that are defined in the [&lt;propertyStores&gt;](../globalsettings/propertystores/index.md) collection.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<properties>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<properties>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<properties>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<properties>` element of the `<authoring>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<properties>` element of the `<authoring>` element was introduced in WebDAV 7.0, which was a separate download for IIS 7.0. |
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

### How to configure WebDAV properties for a Web site

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
3. In the site's **Home** pane, double-click **WebDAV Authoring Rules**.  
    [![](index/_static/image10.png)](index/_static/image9.png)
4. When the **WebDAV Authoring Rules** page is displayed, click **WebDAV Settings** in the **Actions** pane.  
    [![](index/_static/image12.png)](index/_static/image11.png)
5. When the **WebDAV Settings** page is displayed, specify the following options in the **Property Behavior** section: 

    - Set **Allow anonymous property queries** to **False**.
    - Set **Allow custom properties** to **True**.
    - Set **Allow property queries with infinite depth** to **False**.
  
    [![](index/_static/image14.png)](index/_static/image13.png)
6. Click the ellipsis (**...**) button to launch the Namespace Collection Editor.   
    [![](index/_static/image16.png)](index/_static/image15.png)
7. Click **Add** and then choose **webdav\_simple\_prop** from the drop-down list
8. Specify "\*" for the XmlNameSpace and then click **OK**.
9. Once you have completed the previous steps, click **Apply** in the **Actions** pane.

<a id="005"></a>
## Configuration

The `<properties>` element is configurable only at the site level in the ApplicationHost.config file. Any `<properties>` elements at other levels or in Web.config files are ignored.

### Attributes

| Attribute | Description |
| --- | --- |
| `allowAnonymousPropfind` | Optional **Boolean** attribute. **true** if anonymous WebDAV property requests are allowed; otherwise, **false**. **Important**: Most WebDAV verbs require authentication; however, anonymous WebDAV property requests may be allowed for backwards-compatibility for some WebDAV clients. Unless there is a specific requirement for your environment, anonymous WebDAV property requests should always be disabled because they introduce the chance of information disclosure for a Web site. For example, an anonymous WebDAV client can retrieve a list of files in your application. The default value is `false`. |
| `allowInfinitePropfindDepth` | Optional **Boolean** attribute. **true** if infinite-depth WebDAV property requests are allowed; otherwise, **false**. **Important**: Allowing infinite-depth WebDAV property requests is strongly discouraged due to the amount of CPU time that may be required to fullfill an infinite-depth WebDAV property request. This could even lead to a denial of service for your application. Unless there is a specific requirement for your environment, infinite-depth WebDAV property requests should always be disabled. The default value is `false`. |
| `allowCustomProperties` | Optional **Boolean** attribute. **true** if custom WebDAV properties are allowed; otherwise, **false**. <br><br>**Note:** Custom WebDAV properties are also known as "dead" properties. <br><br>**Note:** If `allowCustomProperties` is set to **true** but no property stores are defined or there are no XML namespace to property store mappings, no custom properties can be stored. The default value is `true`. |

### Child Elements

| Element | Description |
| --- | --- |
| [`add`](add.md) | Optional element. Adds a mapping for an XML namespace to a property provider. |
| `clear` | Optional element. Clears all the existing namespace mappings. |
| `remove` | Optional element. Removes a mapping from the list of XML namespaces to property providers. |

### Configuration Sample

The following example lists a sample `<webdav>` element for the Default Web Site. This example clears any existing authoring rules, adds a single rule for the administrators group, enables WebDAV authoring, specifies that hidden files are allowed, enables WebDAV locks and specifies the lock provider, and enables WebDAV properties and specifies the default XML namespace for property mapping.

[!code-xml[Main](index/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples configure the WebDAV property settings so that both anonymous and infinite depth property queries are disabled, and enable custom properties with the default XML namespace mapped to the built-in *webdav\_simple\_prop* provider.

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