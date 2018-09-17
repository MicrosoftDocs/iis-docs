---
title: "Adding Hidden Segments &lt;add&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;add&gt; element of the &lt;hiddenSegments&gt; collection specifies a unique URL segment to add to the collection of hidden segments for Inte..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: 8ac7f527-f52b-42d6-b28b-6c54e1a394c5
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.webserver/security/requestfiltering/hiddensegments/add
msc.type: config
---
Adding Hidden Segments &lt;add&gt;
====================
<a id="001"></a>
## Overview

The `<add>` element of the `<hiddenSegments>` collection specifies a unique URL segment to add to the collection of hidden segments for Internet Information Services (IIS) 7.

> [!NOTE]
> When request filtering blocks an HTTP request because of a hidden URL segment, IIS 7 will return an HTTP 404 error to the client and log the following HTTP status with a unique substatus that identifies the reason that the request was denied:

| HTTP Substatus | Description |
| --- | --- |
| `404.8` | Hidden Namespace |

This substatus allows Web administrators to analyze their IIS logs and identify potential threats.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<add>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<add>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<hiddenSegments>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<add>` element of the `<hiddenSegments>` collection was introduced in IIS 7.0. |
| IIS 6.0 | The `<hiddenSegments>` element replaces the IIS 6.0 UrlScan **[DenyUrlSequences]** features. |

<a id="003"></a>
## Setup

The default installation of IIS 7 and later includes the Request Filtering role service or feature. If the Request Filtering role service or feature is uninstalled, you can reinstall it using the following steps.

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**.
2. In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**.
3. In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**.
4. On the **Server Roles** page, expand **Web Server (IIS)**, expand **Web Server**, expand **Security**, and then select **Request Filtering**. Click **Next**.  
    [![](add/_static/image2.png)](add/_static/image1.png) .
5. On the **Select features** page, click **Next**.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Security**, and then select **Request Filtering**.  
    [![](add/_static/image4.png)](add/_static/image3.png)
4. Click **OK**.
5. Click **Close**.

### Windows Server 2008 or Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, select **Request Filtering**, and then click **Next**.   
    [![](add/_static/image6.png)](add/_static/image5.png)
5. On the **Confirm Installation Selections** page, click **Install**.
6. On the **Results** page, click **Close**.

### Windows Vista or Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. Expand **Internet Information Services**, then **World Wide Web Services**, and then **Security**.
4. Select **Request Filtering**, and then click **OK**.   
    [![](add/_static/image8.png)](add/_static/image7.png)
 
<a id="004"></a>
## How To

**Note for IIS 7.0 users**: Some of the steps in this section may require that you install the Microsoft Administration Pack for IIS 7.0, which includes a user interface for request filtering. To install the Microsoft Administration Pack for IIS 7.0, please see the following URL:

- [https://www.iis.net/expand/AdministrationPack](https://www.iis.net/downloads/microsoft/administration-pack)
 
### How to add a hidden segment

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
2. In the **Connections** pane, go to the connection, site, application, or directory for which you want to modify your request filtering settings.
3. In the **Home** pane, double-click **Request Filtering**.   
    [![](add/_static/image10.png)](add/_static/image9.png)
4. In the **Request Filtering** pane, click the **Hidden Segments** tab, and then click **Add Hidden Segment...** in the **Actions** pane.   
    [![](add/_static/image12.png)](add/_static/image11.png)
5. In the **Add Hidden Segment** dialog box, enter the relative path that you want to hide, and then click **OK**.   
    [![](add/_static/image14.png)](add/_static/image13.png)
 
<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `segment` | Required string attribute. <br><br>Specifies part of the file system that should never be served to clients. <br><br>See the Default Configuration section later in this topic for the complete list of default values. |

### Child Elements

None.

### Configuration Sample

The following example Web.config file will configure two options: it will configure IIS to deny access to requests for the &quot;\_private&quot; folder, and it will configure request filtering to allow WebDAV access to hidden segments.

[!code-xml[Main](add/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code samples will configure two options: they will configure IIS to deny access to requests for the &quot;\_private&quot; folder in the &quot;Default Web Site&quot;, and they will configure request filtering to allow WebDAV access to hidden segments.

### AppCmd.exe

[!code-console[Main](add/samples/sample2.cmd)]

### PowerShell

[!code-powershell[Main](add/samples/sample7.ps1)]

### C#

[!code-csharp[Main](add/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](add/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](add/samples/sample5.js)]

### VBScript

[!code-vb[Main](add/samples/sample6.vb)]
