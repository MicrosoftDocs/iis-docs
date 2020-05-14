---
title: "Default Document &lt;defaultDocument&gt;"
author: rick-anderson
description: "Overview The &lt;defaultDocument&gt; element allows you to enable or disable default document behavior for your Web site or application. This element contain..."
ms.date: 09/26/2016
ms.assetid: 49fde6c2-4b6b-499d-8eb0-fd2cba88cf24
msc.legacyurl: /configreference/system.webserver/defaultdocument
msc.type: config
---
Default Document &lt;defaultDocument&gt;
====================
<a id="001"></a>
## Overview

The `<defaultDocument>` element allows you to enable or disable default document behavior for your Web site or application. This element contains a `<files>` child element, which contains a collection of `<add>` elements. Each `<add>` element defines the default documents that the site or application will return to a client browser when the site receives a request to the root directory.

The `<defaultDocument>` element can also contain one or more `<remove>` elements. Each `<remove>` element removes a specific default document file inherited from a higher-level configuration file on the Internet Information Services (IIS) 7 server. You can also use the `<clear>` element to remove all default document settings defined higher in the configuration hierarchy.

Default documents are enabled by default, and IIS 7 defines the following default document files in the ApplicationHost.config file as server-wide defaults:

- Default.htm
- Default.asp
- Index.htm
- Index.html
- Iisstart.htm

(If you install ASP.NET on your Web server, the installation process will add the Default.aspx file to this list.)

By default, when a request arrives for your site's or application's root directory, IIS 7 sends a response to the browser based on the file names you defined in the `<defaultDocument>` element. IIS attempts to return the correct files in the order that they appear in the `<defaultDocument>` element. If the Default.htm file exists, IIS sends it to the client browser. If the Default.htm file does not exist, IIS attempts to send the Default.asp file to the browser, and if the Default.asp file does not exist, IIS attempts to send the Index.htm file to the browser. IIS continues in this manner until it attempts to send each default document file to the client browser.

> [!NOTE]
> If you order this list of default documents correctly, you can improve the performance of IIS. For example, if you intended to use Index.php for the home page in all the folders of your Web site and you add Index.php to the bottom of the list of default documents, IIS will have to check for each of the default documents in the list before attempting to return Index.php to the client browser. Depending on the number of folders in your Web site and the number of client browser requests, this may impact your performance.

If you disable default documents but have enabled directory browsing, IIS returns a directory listing when a request for the root directory arrives from a browser. If you disable both default documents and directory browsing, IIS sends an "HTTP 404 File Does Not Exist" error to the browser.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<defaultDocument>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<defaultDocument>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<defaultDocument>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<defaultDocument>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<defaultDocument>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<defaultDocument>` element replaces the IIS 6.0 **DefaultDoc** property and the **EnableDefaultDoc** value of the **DirBrowseFlags** property on the **IIsWebService** metabase object. |

<a id="003"></a>
## Setup

The `<defaultDocument>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

### How to add a default document for an application or site

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
2. In the **Connections** pane, expand the server name, expand **Sites**, and then navigate to the Web site or application where you want to configure default documents.
3. In the **Home** pane, double-click **Default Document**.  
    [![](index/_static/image2.png)](index/_static/image1.png)
4. In the **Actions** pane, click **Add...**
5. In the **Add Default Document** dialog box, type the name of the default document that you want to add in the **Name** box, and then click **OK**.  
    [![](index/_static/image4.png)](index/_static/image3.png)
6. If necessary, in the **Actions** pane, select a default document in the list, and then click **Move Up** or **Move Down** to define the order in which IIS should search through the default document list.
7. In the **Default Document** alert box, click **Yes** to decline configuration inheritance from a parent configuration level, or click **No** or **Cancel** to cancel the change in default document order.  
    [![](index/_static/image6.png)](index/_static/image5.png)
8. If necessary, click **Remove** in the **Actions** pane to remove any file names that you do not want to use as default documents.

<a id="005"></a>
## Configuration

You can change the order in which IIS processes default documents by changing the order of `<add>` elements in the `<defaultDocument>` element.

You can configure the `<defaultDocument>` element at the server level in the ApplicationHost.config file and at the site, application, or URL level in the appropriate Web.config file.

### Attributes

| Attribute | Description |
| --- | --- |
| `enabled` | Optional Boolean attribute.<br><br>Specifies that default documents are enabled.<br><br>The default value is `true`. |

### Child Elements

| Element | Description |
| --- | --- |
| [`files`](files/index.md) | Optional element. <br><br>Specifies a list of file names that can be returned as default documents. |

### Configuration Sample

The following configuration example, when included in a Web.config file for a site or application, enables default documents for the site or application. It then adds the file name &quot;Home.html&quot; to the list of the site's or application's default documents.

[!code-xml[Main](index/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples enable default documents on a Web site named Contoso then add a file named Home.html to the list of default documents for the site.

### AppCmd.exe

[!code-console[Main](index/samples/sample2.cmd)]

### C\#

[!code-csharp[Main](index/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample5.js)]

### VBScript

[!code-vb[Main](index/samples/sample6.vb)]
