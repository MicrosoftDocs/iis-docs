---
title: "Adding HTTP Errors &lt;error&gt;"
author: rick-anderson
description: "Overview The &lt;error&gt; element of the &lt;httpErrors&gt; collection adds a unique error mapping to the HTTP errors collection. Compatibility Version Note..."
ms.date: 09/26/2016
ms.assetid: a369f4a0-5c78-4829-b79f-f6f469f4e6f0
msc.legacyurl: /configreference/system.webserver/httperrors/error
msc.type: config
---
# Adding HTTP Errors &lt;error&gt;

## Overview

The `<error>` element of the `<httpErrors>` collection adds a unique error mapping to the HTTP errors collection.

## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<error>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<error>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<error>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<error>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<error>` element of the `<httpErrors>` collection was introduced in IIS 7.0. |
| IIS 6.0 | The `<httpErrors>` collection replaces the IIS 6.0 **HttpErrors** section of the **IIsWebService** metabase object. |

## Setup

The `<error>` element of the `<httpErrors>` collection is included in the default installation of IIS 7.

## How To

### How to add a custom error page

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
2. In the **Connections** pane, expand the server name, expand **Sites**, and then navigate to the Web site or application that you want to configure custom error pages for.
3. In the **Home** pane, double-click **Error Pages**.  
    [![](error/_static/image2.png)](error/_static/image1.png)
4. In the **Actions** pane, click **Add...**
5. In the **Add Custom Error Page** dialog box, under **Status code**, type the number of the HTTP status code for which you want to create a custom error message.  
    [![](error/_static/image4.png)](error/_static/image3.png)
6. In the **Response Action** section, do one of the following:

    - Select **Insert content from static file into the error response** to serve static content, for example, an .html file, for the custom error.
    - Select **Execute a URL on this site** to serve dynamic content, for example, an .asp file for the custom error.
    - Select **Respond with a 302 redirect** to redirect client browsers to a different URL that contains the custom error file.
7. In the **File path** text box, type the path of the custom error page if you chose **Insert content from static file into the error response** or the URL of the custom error page if you use either the **Execute a URL on this site** or **Respond with a 302 redirect**, and then click **OK**.  
  
    > [!NOTE]
    > If you select **Execute a URL on this site**, the path must be a relative path. If you select **Respond with a 302 redirect**, the URL must be an absolute URL.
    
    > [!NOTE]
    > The following HTTP errors can't be customized: 400, 403.9, 411, 414, 500, 500.11, 500.14, 500.15, 501, 503, and 505. 

## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `path` | Required string attribute.<br><br>Specifies the file path or URL that is served in response to the HTTP error specified by the **statusCode** and **subStatusCode** attributes. If you choose the File response mode, you specify the path of the custom error page. If you choose the **ExecuteURL** response mode, the path has to be a server relative URL (for example, /404.htm). If you choose the **Redirect** response mode, you have to enter an absolute URL (for example, `www.contoso.com/404.htm`). |
| `prefixLanguageFilePath` | Optional string attribute.<br><br>Specifies the initial path segment when generating the path for a custom error. This segment appears before the language-specific portion of the custom error path. For example, in the path C:\Inetpub\Custerr\en-us\404.htm, C:\Inetpub\Custerr is the **prefixLanguageFilePath**. |
| `responseMode` | Optional enum attribute.<br><br>Specifies how custom error content is returned.<br><br>The **responseMode** attribute can be one of the following possible values. The default is `File`. <table> <tbody> <tr> <th>Value</th> <th>Description</th></tr> <tr> <th><code>File</code></th> <td>Serves static content, for example, a .html file for the custom error.<br><br>If <strong>responseMode</strong> is set to <strong>File</strong>, the path attribute value has to be a file path.<br><br>The numeric value is <code>0</code>. </td></tr> <tr> <th><code>ExecuteURL</code></th> <td>Serves dynamic content (for example, an .asp file) specified in the path attribute for the custom error.<br><br>If <strong>responseMode</strong> is set to <strong>ExecuteURL</strong>, the path value has to be a server relative URL.<br><br>The numeric value is <code>1</code>. </td></tr> <tr> <th><code>Redirect</code></th> <td>Redirects client browsers to a the URL specified in the path attribute that contains the custom error file.<br><br>If <strong>responseMode</strong> is set to <strong>Redirect</strong>, the path value has to be an absolute URL.<br><br>The numeric value is <code>2</code>.</td></tr></tbody></table> |
| `statusCode` | Required uint attribute.<br><br>Specifies the number of the HTTP status code for which you want to create a custom error message. Acceptable values are in the range from 400 through 999. |
| `subStatusCode` | Optional int attribute. <br><br>Specifies the number of the HTTP substatus code for which you want to create a custom error message. Acceptable values are in the range from -1 through 999.<br><br>The default value is `-1`. |

### Child Elements

None.

### Configuration Sample

The following configuration example, when included in the Web.config file for a Web site or application, uses the **errorMode** attribute to only allow detailed error messages to appear on the local computer. It also uses the **defaultResponseMode** attribute to set the response mode for the site or application. The sample then removes the inherited error message for the 500 status code. Next, it sets the **prefixLanguageFilePath** attribute to the directory where IIS should search of a new custom error page, and sets the **path** attribute to 500.htm, the file that contains the custom error message.

[!code-xml[Main](error/samples/sample1.xml)]

## Sample Code

The following examples adds a new file for all status code 404 errors with a substatus of 5, which IIS returns for &quot;URL Sequence Denied&quot; errors. In these examples, the prefix path is set to &quot;%SystemDrive%\inetpub\custerr&quot;, and the file name is specified as &quot;404.5.htm&quot;.

### AppCmd.exe

[!code-console[Main](error/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C\#

[!code-csharp[Main](error/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](error/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](error/samples/sample5.js)]

### VBScript

[!code-vb[Main](error/samples/sample6.vb)]
