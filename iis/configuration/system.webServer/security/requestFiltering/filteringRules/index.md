---
title: "Request Filtering Rules &lt;filteringRules&gt;"
author: rick-anderson
description: "Overview The &lt;filteringRules&gt; element specifies a collection of custom request filtering rules. This element allows administrators to create customized..."
ms.date: 09/26/2016
ms.assetid: af41ce80-db79-4d01-9749-368c2ee16f8e
msc.legacyurl: /configreference/system.webserver/security/requestfiltering/filteringrules
msc.type: config
---
# Request Filtering Rules &lt;filteringRules&gt;

<a id="001"></a>
## Overview

The `<filteringRules>` element specifies a collection of custom request filtering rules. This element allows administrators to create customized filtering rules for their server that extend the basic functionality of the request filtering feature.

Each `<filteringRule>` element specifies a collection of custom attributes and elements that define the request filtering behavior based on user-defined criteria. For example, each request filtering rule may contain the following attributes:

- `denyUnescapedPercent` - This attribute specifies whether request filtering should deny the request if it contains percent symbols that are not escaped.
- `scanAllRaw` - This attribute specifies whether request filtering should scan the raw headers for the strings that are specified in the `denyStrings` element.
- `scanQueryString` - This attribute specifies whether request filtering should scan the query string for the strings that are specified in the `denyStrings` element. If the `unescapeQueryString` attribute of the `<requestFiltering>` element is set to **true**, then two scans will be made of the query string: one scan with the raw query string and a second scan with the query string unescaped.
- `scanUrl` - This attribute specifies whether request filtering should scan the URL for the strings that are specified in the `denyStrings` element.

In addition, each request filtering rule may contain the following child elements:

- [`<appliesTo>`](filteringrule/appliesto/index.md) - Specifies the list of file name extensions to which the request filtering rule applies.

    > [!NOTE]
    > If this section is blank, the rule applies to all requests.

- [`<denyStrings>`](filteringrule/denystrings/index.md) - Specifies the list of strings to deny for the request filtering rule.
- [`<scanHeaders>`](filteringrule/scanheaders/index.md) - Specifies the list of HTTP headers to scan.

> [!NOTE]
> When request filtering blocks an HTTP request because of a filtering rule, IIS 7 will return an HTTP 404 error to the client and log the following HTTP status with a unique substatus that identifies the reason that the request was denied:

| HTTP Substatus | Description |
| --- | --- |
| `404.19` | Denied by filtering rule |

This substatus allows Web administrators to analyze their IIS logs and identify potential threats.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<filteringRules>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<filteringRules>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<filteringRules>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<filteringRules>` element of the `<requestFiltering>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<filteringRules>` element of the `<requestFiltering>` element was introduced as an update for IIS 7.0 that is available through Microsoft Knowledge Base Article 957508 (`https://support.microsoft.com/kb/957508`). |
| IIS 6.0 | The `<filteringRules>` element is roughly analogous to the **RuleList** feature that was added to URLScan 3.0. |

<a id="003"></a>
## Setup

The default installation of IIS 7 and later includes the Request Filtering role service or feature. If the Request Filtering role service or feature is uninstalled, you can reinstall it using the following steps.

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**.
2. In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**.
3. In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**.
4. On the **Server Roles** page, expand **Web Server (IIS)**, expand **Web Server**, expand **Security**, and then select **Request Filtering**. Click **Next**.  
    [![Screenshot shows Web Server and Security pane expanded with Request Filtering selected.](index/_static/image2.png)](index/_static/image1.png) .
5. On the **Select features** page, click **Next**.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Security**, and then select **Request Filtering**.  
    [![Screenshot of World Wide Web Services and Security pane showing Request Filtering highlighted.](index/_static/image4.png)](index/_static/image3.png)
4. Click **OK**.
5. Click **Close**.

### Windows Server 2008 or Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, select **Request Filtering**, and then click **Next**.   
    [![Screenshot displays Select Role Services page in Add Role Services Wizard with Security pane expanded and Request Filtering selected.](index/_static/image6.png)](index/_static/image5.png)
5. On the **Confirm Installation Selections** page, click **Install**.
6. On the **Results** page, click **Close**.

### Windows Vista or Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. Expand **Internet Information Services**, then **World Wide Web Services**, and then **Security**.
4. Select **Request Filtering**, and then click **OK**.   
    [![Screenshot displays Security node expanded in Turn Windows features on or off and Request Filtering selected.](index/_static/image8.png)](index/_static/image7.png)
 
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
    [![Screenshot of Request Filtering pane showing Rules tab. Add Filtering Rule option is displayed in Actions pane.](index/_static/image10.png)](index/_static/image9.png)
5. In the **Actions** pane, click **Add Filtering Rule**.
6. Enter the following information for the filtering rule in the **Add Filtering Rule** dialog: 

    - Enter a friendly name for the filtering rule in the **Name** field.
    - Select **Scan url** if you want the filtering rule to scan the URL stub for the request.
    - Select **Scan query string** if you want the filtering rule to scan the query string for the request.
    - Enter any HTTP headers to scan in the **Scan Headers** collection.
    - Enter the file name extensions to use with the filtering rule in the **Applies To** collection.
    - Enter the collection of strings to deny for the filtering rule in the **Deny Strings** collection.  
        [![Screenshot shows Add Filtering Rule dialog box with Name field, Scan u r l and Scan query string boxes both checked.](index/_static/image12.png)](index/_static/image11.png)
7. Click **OK** to close the **Add Filtering Rule** dialog.

<a id="005"></a>
## Configuration

The `<filteringRules>` element of the `<requestFiltering>` element is configured at the site, application, or directory level.

### Attributes

None.

### Child Elements

| Element | Description |
| --- | --- |
| [`filteringRule`](filteringrule/index.md) | Optional element.<br><br>Adds a rule to the collection of custom request filtering rules. |

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

### C\#

[!code-csharp[Main](index/samples/sample4.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample5.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample6.js)]

### VBScript

[!code-vb[Main](index/samples/sample7.vb)]
