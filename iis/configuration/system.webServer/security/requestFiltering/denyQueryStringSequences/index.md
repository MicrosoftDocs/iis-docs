---
title: "Deny Query String Sequences &lt;denyQueryStringSequences&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;denyQueryStringSequences&gt; element contains a collection of &lt;add&gt; elements that specify sequences of query string characters that II..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: a3dacc6a-885d-4d0a-a798-92d3b7fa1977
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.webserver/security/requestfiltering/denyquerystringsequences
msc.type: config
---
Deny Query String Sequences &lt;denyQueryStringSequences&gt;
====================
<a id="001"></a>
## Overview

The `<denyQueryStringSequences>` element contains a collection of [`<add>`](add.md) elements that specify sequences of query string characters that IIS will deny, which helps prevent attacks on the Web server that use the query string to deliver the attack payload.

> [!NOTE]
> You can override the query string sequences in this collection by adding query string sequences to the [`<alwaysAllowedQueryStrings>`](../alwaysallowedquerystrings/index.md) collection.

> [!NOTE]
> When request filtering blocks an HTTP request because of a denied query string sequence, IIS 7 will return an HTTP 404 error to the client and log the following HTTP status with a unique substatus that identifies the reason that the request was denied:

| HTTP Substatus | Description |
| --- | --- |
| `404.18` | Query String Sequence Denied |

This substatus allows Web administrators to analyze their IIS logs and identify potential threats.
 
<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<denyQueryStringSequences>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<denyQueryStringSequences>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<denyQueryStringSequences>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<denyQueryStringSequences>` element of the `<requestFiltering>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<denyQueryStringSequences>` element of the `<requestFiltering>` element was introduced as an update for IIS 7.0 that is available through [Microsoft Knowledge Base Article 957508](https://support.microsoft.com/kb/957508). |
| IIS 6.0 | The `<denyQueryStringSequences>` element is roughly analogous to the **[DenyQueryStringSequences]** section that was added to URLScan 3.0. |

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

### How to deny a query string sequence

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
2. In the Connections pane, go to the connection, site, application, or directory for which you want to modify your request filtering settings.
3. In the **Home** pane, double-click **Request Filtering**.
4. In the **Request Filtering** pane, click the **Query Strings** tab, and then click **Deny Query String...** in the **Actions** pane.
5. In the **Deny Query String** dialog box, enter the query string sequence that you wish to block, and then click **OK**.

<a id="005"></a>
## Configuration

The `<denyQueryStringSequences>` element of the `<requestFiltering>` element is configured at the site, application, or directory level.

### Attributes

None.

### Child Elements

| Element | Description |
| --- | --- |
| [`add`](add.md) | Optional element.<br><br>Adds a query string to the collection of denied query strings. |
| `clear` | Optional element.<br><br>Removes all references to query strings from the collection. |
| `remove` | Optional element.<br><br>Removes a query string from the collection of denied query strings. |

### Configuration Sample

The following sample illustrates a combination of a `<denyQueryStringSequences>` element and an `<alwaysAllowedQueryStrings>` element that will deny any query strings if they contain either of two specific character sequences, but will always allow a specific query string that contains both of those two specific character sequences in a particular order.

[!code-xml[Main](index/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples demonstrate how to add a query string sequence that will be denied on the Default Web Site.

### AppCmd.exe

[!code-console[Main](index/samples/sample2.cmd)]

### PowerShell

[!code-powershell[Main](index/samples/sample7.ps1)]

### C#

[!code-csharp[Main](index/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample5.js)]

### VBScript

[!code-vb[Main](index/samples/sample6.vb)]
