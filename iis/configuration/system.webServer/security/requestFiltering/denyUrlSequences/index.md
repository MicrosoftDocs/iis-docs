---
title: "Deny URL Sequences &lt;denyUrlSequences&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;denyUrlSequences&gt; element contains a collection of &lt;add&gt; elements that specify sequences of URL characters that IIS will deny, whic..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: 2da3c74f-ccfb-4b54-91c2-d3ce9d2cee58
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.webserver/security/requestfiltering/denyurlsequences
msc.type: config
---
Deny URL Sequences &lt;denyUrlSequences&gt;
====================
<a id="001"></a>
## Overview

The `<denyUrlSequences>` element contains a collection of [`<add>`](add.md) elements that specify sequences of URL characters that IIS will deny, which helps prevent URL-based attacks on the Web server.

For example, using two periods in a URL ("..") will instruct a server to process the URL in the next higher directory, but it may also indicate that an attacker is trying to gain access to areas outside of the content area. Blocking that pattern of characters will remove this chance of an attacker being able to exploit this URL sequence.

> [!NOTE]
> When request filtering blocks an HTTP request because of a denied URL sequence, IIS 7 will return an HTTP 404 error to the client and log the following HTTP status with a unique substatus that identifies the reason that the request was denied:

| HTTP Substatus | Description |
| --- | --- |
| `404.5` | URL Sequence Denied |

This substatus allows Web administrators to analyze their IIS logs and identify potential threats.

> [!NOTE]
> Beginning in IIS 7.5, you can override the URL sequences in the `<denyUrlSequences>` collection by adding URL sequences to the [`<alwaysAllowedUrls>`](../alwaysallowedurls/index.md) collection.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<denyUrlSequences>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<denyUrlSequences>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<denyUrlSequences>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<denyUrlSequences>` element was not modified in IIS 7.5.<br><br>**Note:** IIS 7.5 allows you to override the URL sequences in the `<denyUrlSequences>` element by adding URL sequences to the [`<alwaysAllowedUrls>`](../alwaysallowedurls/index.md) collection. |
| IIS 7.0 | The `<denyUrlSequences>` element of the `<requestFiltering>` collection was introduced in IIS 7.0. |
| IIS 6.0 | The `<denyUrlSequences>` element replaces the IIS 6.0 UrlScan **[DenyUrlSequences]** features. |

<a id="003"></a>
## Setup

The default installation of IIS 7 and later includes the Request Filtering role service or feature. If the Request Filtering role service or feature is uninstalled, you can reinstall it using the following steps.

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**.
2. In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**.
3. In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**.
4. On the **Server Roles** page, expand **Web Server (IIS)**, expand **Web Server**, expand **Security**, and then select **Request Filtering**. Click **Next**.  
    [![](index/_static/image2.png)](index/_static/image1.png) .
5. On the **Select features** page, click **Next**.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Security**, and then select **Request Filtering**.  
    [![](index/_static/image4.png)](index/_static/image3.png)
4. Click **OK**.
5. Click **Close**.

### Windows Server 2008 or Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, select **Request Filtering**, and then click **Next**.   
    [![](index/_static/image6.png)](index/_static/image5.png)
5. On the **Confirm Installation Selections** page, click **Install**.
6. On the **Results** page, click **Close**.

### Windows Vista or Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. Expand **Internet Information Services**, then **World Wide Web Services**, and then **Security**.
4. Select **Request Filtering**, and then click **OK**.   
    [![](index/_static/image8.png)](index/_static/image7.png)
 
<a id="004"></a>
## How To

**Note for IIS 7.0 users**: Some of the steps in this section may require that you install the Microsoft Administration Pack for IIS 7.0, which includes a user interface for request filtering. To install the Microsoft Administration Pack for IIS 7.0, please see the following URL:

- [https://www.iis.net/expand/AdministrationPack](https://www.iis.net/downloads/microsoft/administration-pack)
 
### How to deny a URL sequence

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
    [![](index/_static/image10.png)](index/_static/image9.png)
4. In the **Request Filtering** pane, click the **Deny URL Sequences** tab, and then click **Add URL Sequence...** in the **Actions** pane.   
    [![](index/_static/image12.png)](index/_static/image11.png)
5. In the **Add Deny Sequence** dialog box, enter the URL sequence that you wish to block, and then click **OK**.   
    [![](index/_static/image14.png)](index/_static/image13.png)  
 For example, to prevent directory transversal on your server, you would enter two periods ("..") in the dialog box.
 
<a id="005"></a>
## Configuration

The `<denyUrlSequences>` element of the `<requestFiltering>` element is configured at the site, application, or directory level.

### Attributes

None.

### Child Elements

| Element | Description |
| --- | --- |
| [`add`](add.md) | Optional element. <br><br>Adds a sequence to the collection of denied URL sequences. |
| `clear` | Optional element. <br><br>Removes all references to sequences from the `<denyUrlSequences>` collection. |
| `remove` | Optional element. <br><br>Removes a reference to a sequence from the `<denyUrlSequences>` collection. |

### Configuration Sample

The following example Web.config file will deny access to three URL sequences. The first sequence prevents directory transversal, the second sequence prevents access to alternate data streams, and the third sequence prevents backslashes from being used in URLs.

[!code-xml[Main](index/samples/sample1.xml)]

The following sample illustrates a combination of a `<denyUrlSequences>` element and an `<alwaysAllowedUrls>` element that will deny any URLs if they contain either of two specific character sequences, but will always allow a specific URL that contains both of those two specific character sequences in a particular order.

[!code-xml[Main](index/samples/sample2.xml)]
 
<a id="006"></a>
## Sample Code

The following code samples demonstrate how to deny access to three URL sequences for the Default Web Site: directory transversals (".."), alternate data streams (":"), and backslashes ("\").

### AppCmd.exe

[!code-console[Main](index/samples/sample3.cmd)]

### PowerShell

[!code-powershell[Main](index/samples/sample8.ps1)]

### C#

[!code-csharp[Main](index/samples/sample4.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample5.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample6.js)]

### VBScript

[!code-vb[Main](index/samples/sample7.vb)]
