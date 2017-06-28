---
title: "Adding Default Document Files &lt;add&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;add&gt; element of the &lt;defaultDocument&gt; collection specifies a unique file name to add to the list of default documents in the &lt;fi..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: 
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.webserver/defaultdocument/files/add
msc.type: config
---
Adding Default Document Files &lt;add&gt;
====================
<a id="001"></a>
## Overview

The `<add>` element of the `<defaultDocument>` collection specifies a unique file name to add to the list of default documents in the `<files>` element.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<add>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<add>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<add>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<add>` element of the `<defaultDocument>` collection was introduced in IIS 7.0. |
| IIS 6.0 | The `<defaultDocument>` collection replaces the IIS 6.0 **DefaultDoc** property and the **EnableDefaultDoc** value of the **DirBrowseFlags** property on the **IIsWebService** metabase object. |

<a id="003"></a>
## Setup

The `<add>` element of the `<defaultDocument>` collection is included in the default installation of IIS 7.

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
    [![](add/_static/image2.png)](add/_static/image1.png)
4. In the **Actions** pane, click **Add...**
5. In the **Add Default Document** dialog box, type the name of the default document that you want to add in the **Name** box, and then click **OK**.  
    [![](add/_static/image4.png)](add/_static/image3.png)
6. If necessary, in the **Actions** pane, select a default document in the list, and then click **Move Up** or **Move Down** to define the order in which IIS should search through the default document list.
7. In the **Default Document** alert box, click **Yes** to decline configuration inheritance from a parent configuration level, or click **No** or **Cancel** to cancel the change in default document order.  
    [![](add/_static/image6.png)](add/_static/image5.png)
8. If necessary, click **Remove** in the **Actions** pane to remove any file names that you do not want to use as default documents.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `name` | Optional string attribute.<br><br>Specifies a file name of Web content that can be used as a default document. The value must be unique in the files collection, and it can be a file name or a relative path. |

### Child Elements

None.

### Configuration Sample

The following configuration example, when included in a Web.config file for a site or application, enables default documents for the site or application. It then adds the file name &quot;Home.html&quot; to the list of the site's or application's default documents.

[!code-xml[Main](add/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples enable default documents on a Web site named Contoso then add a file named Home.html to the list of default documents for the site.

### AppCmd.exe

[!code-console[Main](add/samples/sample2.cmd)]

### C#

[!code-csharp[Main](add/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](add/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](add/samples/sample5.js)]

### VBScript

[!code-vb[Main](add/samples/sample6.vb)]