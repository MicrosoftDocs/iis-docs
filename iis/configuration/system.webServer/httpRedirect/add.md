---
title: "Adding HTTP Wildcard Redirects &lt;add&gt;"
author: rick-anderson
description: "Overview The &lt;add&gt; element of the &lt;httpRedirect&gt; element adds a wildcard redirection rule to the collection of redirection rules. Wildcard rules..."
ms.date: 09/26/2016
ms.assetid: aff43891-7336-4f40-910b-fd6eedbb4906
msc.legacyurl: /configreference/system.webserver/httpredirect/add
msc.type: config
---
# Adding HTTP Wildcard Redirects &lt;add&gt;

<a id="001"></a>

## Overview

The `<add>` element of the `<httpRedirect>` element adds a wildcard redirection rule to the collection of redirection rules. Wildcard rules allow you to add redirection rules for groups of content. For example, if you have removed all of your \*.asp pages after migrating an application to .NET pages that are using \*.aspx file name extensions, you could add a wildcard redirection rule that redirects all of the \*.asp requests for your old ASP-based application to the home page of your Web site.

> [!NOTE]
> If you add wildcard redirection rules, you must remove the default destination value in the `<httpRedirect>` section in order for the wildcard rules to work.

<a id="002"></a>

## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<add>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<add>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<add>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<add>` element of the `<httpRedirect>` element was introduced in IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>

## Setup

HTTP Redirection is not available on the default installation of IIS 7 and later. To install it, use the following steps.

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**.
2. In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**.
3. In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**.
4. On the **Server Roles** page, expand **Web Server (IIS)**, expand **Web Server**, expand **Common HTTP Features**, and then select **HTTP Redirection**. Click **Next**.  
    [![](add/_static/image2.png)](add/_static/image1.png) .
5. On the **Select features** page, click **Next**.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Common HTTP Features**, and then select **HTTP Redirection**.  
    [![](add/_static/image4.png)](add/_static/image3.png)
4. Click **OK**.
5. Click **Close**.

### Windows Server 2008 or Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, expand **Common Http Features**, select **HTTP Redirection**, and then click **Next**.  
    [![](add/_static/image6.png)](add/_static/image5.png)
5. On the **Confirm Installation Selections** page, click **Install**.
6. On the **Results** page, click **Close**.

### Windows Vista or Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. Expand **Internet Information Services**, then **World Wide Web Services**, then **Common Http Features**.
4. Select **HTTP Redirection**, and then click **OK**.  
    [![](add/_static/image8.png)](add/_static/image7.png)
 
<a id="004"></a>

## How To

There is no user interface for adding wildcard HTTP redirects for IIS 7. For examples of how to add `<add>` elements to the `<httpRedirect>` element programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>

## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `destination` | Required string attribute.<br><br>Specifies a location to which to redirect requests that match the related wildcard value. |
| `wildcard` | Required string attribute.<br><br>Specifies a unique wildcard value to which requests are compared. A request is then redirected to the specified destination if the request matches the wildcard value. |

### Child Elements

None.

### Configuration Sample

The following configuration sample adds a wildcard redirection entry that redirects all requests for ASP files to the home page of your Web site.

> [!NOTE]
> This example is useful if you have removed all ASP-based applications from your Web site and you wanted client requests for the old applications to be redirected to the root of your Web site rather than receiving an **HTTP 404 Not Found** response.

[!code-xml[Main](add/samples/sample1.xml)]

<a id="006"></a>

## Sample Code

The following code samples adds a wildcard redirection entry that redirects all requests for ASP files to the home page of your Web site.

> [!NOTE]
> This example is useful if you have removed all ASP-based applications from your Web site and you wanted client requests for the old applications to be redirected to the root of your Web site rather than receiving an **HTTP 404 Not Found** response.

### AppCmd.exe

[!code-console[Main](add/samples/sample2.cmd)]

### C\#

[!code-csharp[Main](add/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](add/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](add/samples/sample5.js)]

### VBScript

[!code-vb[Main](add/samples/sample6.vb)]
