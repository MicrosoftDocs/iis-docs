---
title: "File Name Extensions for Filtering Rules &lt;appliesTo&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;appliesTo&gt; element of the &lt;filteringRule&gt; element defines a collection of file name extensions to which a request filtering rule ap..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: 082f8653-8f71-4f73-b740-d93b13bcc946
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.webserver/security/requestfiltering/filteringrules/filteringrule/appliesto
msc.type: config
---
File Name Extensions for Filtering Rules &lt;appliesTo&gt;
====================
<a id="001"></a>
## Overview

The `<appliesTo>` element of the `<filteringRule>` element defines a collection of file name extensions to which a request filtering rule applies. The `<appliesTo>` element contains a series of `<add>` elements, each of which specifies a unique file name extension to add to the collection.

> [!NOTE]
> If this collection is empty, the rule applies to all requests.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<appliesTo>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<appliesTo>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<appliesTo>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<appliesTo>` element of the `<filteringRule>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<appliesTo>` element of the `<filteringRule>` element was introduced as an update for IIS 7.0 that is available through [Microsoft Knowledge Base Article 957508](https://support.microsoft.com/kb/957508). |
| IIS 6.0 | The `<filteringRules>` element is roughly analogous to the **RuleList** feature that was added to URLScan 3.0. |

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

### How to add a request filtering rule

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
2. In the **Connections** pane, go to the site, application, or directory for which you want to configure request filtering.
3. In the **Home** pane, double-click **Request Filtering**.
4. In the **Request Filtering** pane, click the **Rules** tab.  
    [![](index/_static/image10.png)](index/_static/image9.png)
5. In the **Actions** pane, click **Add Filtering Rule**.
6. Enter the following information for the filtering rule in the **Add Filtering Rule** dialog: 

    - Enter a friendly name for the filtering rule in the **Name** field.
    - Select **Scan url** if you want the filtering rule to scan the URL stub for the request.
    - Select **Scan query string** if you want the filtering rule to scan the query string for the request.
    - Enter any HTTP headers to scan in the **Scan Headers** collection.
    - Enter the file name extensions to use with the filtering rule in the **Applies To** collection.
    - Enter the collection of strings to deny for the filtering rule in the **Deny Strings** collection.  
        [![](index/_static/image12.png)](index/_static/image11.png)
7. Click **OK** to close the **Add Filtering Rule** dialog.

<a id="005"></a>
## Configuration

The `<appliesTo>` element of the `<filteringRule>` element is configured at the site, application, or directory level.

### Attributes

None.

### Child Elements

| Element | Description |
| --- | --- |
| [`add`](add.md) | Optional element.<br><br>Adds a file name extension to the list of file name extensions for a filtering rule. |
| `clear` | Optional element.<br><br>Clears the list of file name extensions for a filtering rule. |
| `remove` | Optional element.<br><br>Removes a file name extension from the list of file name extensions for a filtering rule. |

### Configuration Sample

The following sample displays a `<requestFiltering>` element that uses the `<denyStrings>`, `<appliesTo>`, and `<scanHeaders>` elements to define a request filtering rule that will prevent image stealing (leeching) for a specific user agent.

[!code-xml[Main](index/samples/sample1.xml)]

The following sample displays a `<requestFiltering>` element that defines a request filtering rule that prevents SQL injection attacks by denying a collection of text strings in query strings that are often used in SQL injection attacks.

[!code-xml[Main](index/samples/sample2.xml)]

<a id="006"></a>
## Sample Code

The following examples demonstrate how to use the `<denyStrings>`, `<appliesTo>`, and `<scanHeaders>` elements to add a request filtering rule for the Default Web Site that will prevent image stealing (leeching) for a specific user agent. Here is the scenario for this example: If you detected that images on your web site were being leeched by a particular user agent, you could create a request filtering rule that denies access to image files for that specific user agent. In this particular example, the request filtering rule will search the HTTP user-agent header for the string "leech-bot," and will deny access to GIF, JPG, and PNG files if the user-agent header contains the search string.

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
