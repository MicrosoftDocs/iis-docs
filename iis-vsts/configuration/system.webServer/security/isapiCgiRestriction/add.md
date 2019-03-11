---
title: "Adding ISAPI/CGI Restrictions &lt;add&gt;"
author: rick-anderson
description: "Overview The &lt;add&gt; element in the &lt;isapiCgiRestriction&gt; collection allows you to specify individual Common Gateway Interface (CGI) and Internet S..."
ms.date: 09/26/2016
ms.assetid: 615cec3b-1b28-4282-b0e2-349cd6a95149
msc.legacyurl: /configreference/system.webserver/security/isapicgirestriction/add
msc.type: config
---
Adding ISAPI/CGI Restrictions &lt;add&gt;
====================
<a id="001"></a>
## Overview

The `<add>` element in the `<isapiCgiRestriction>` collection allows you to specify individual Common Gateway Interface (CGI) and Internet Server Application Programming Interface (ISAPI) applications that can run on Internet Information Services (IIS) 7.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<add>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<add>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<add>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<add>` element of the `<isapiCgiRestriction>` collection was introduced in IIS 7.0. |
| IIS 6.0 | The `<isapiCgiRestriction>` collection replaces the **WebSvcExtRestrictionList** property of the IIS 6.0 **IIsWebService** metabase object. |

<a id="003"></a>
## Setup

The `<isapiCgiRestriction>` collection is available only after you install the CGI or ISAPI Extensions modules on your IIS 7 and later server. You cannot install it independent of those features.

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**.
2. In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**.
3. In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**.
4. On the **Server Roles** page, expand **Web Server (IIS)**, expand **Web Server**, expand **Application Deelopment**, and then select **CGI** or **ISAPI Extensions**. Click **Next**.  
    [![](add/_static/image2.png)](add/_static/image1.png) .
5. On the **Select features** page, click **Next**.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Application Development Features**, and then select **CGI** or **ISAPI Extensions**.  
    [![](add/_static/image4.png)](add/_static/image3.png)
4. Click **OK**.
5. Click **Close**.

### Windows Server 2008 or Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, select **CGI** or **ISAPI Extensions**.  
    [![](add/_static/image6.png)](add/_static/image5.png)
5. If the **Add role services** dialog appears, click **Add Required Role Services**. (This page appears only if you have not already installed any prerequisite role services on your server.)
6. On the **Select Role Services** page, click **Next**.
7. On the **Confirm Installation Selections** page, click **Install**.
8. On the **Results** page, click **Close**.

### Windows Vista or Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. In the Windows Features dialog box, expand **Internet Information Services**, then **World Wide Web Services**, then **Application Development Features**.
4. Select **CGI** or **ISAPI Extensions**, and then click **OK**.  
    [![](add/_static/image8.png)](add/_static/image7.png)
 
<a id="004"></a>
## How To

### How to add an ISAPI or CGI restriction

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
2. In the **Connections** pane, click the server name.
3. In the **Home** pane, double-click **ISAPI and CGI Restrictions**.  
    [![](add/_static/image10.png)](add/_static/image9.png)
4. In the **Actions** pane, click **Add...**
5. In the **Add ISAPI or CGI Restriction** dialog box, type the path to the binary you want to add in the **ISAPI or CGI path** box, type the description of the binary in the **Description** box, select the **Allow extension path option to execute** check box to allow the binary to run on the server, and then click **OK**.  
    [![](add/_static/image12.png)](add/_static/image11.png)

<a id="005"></a>
## Configuration

The `<isapiCgiRestriction>` collection can only be configured at the server level in the ApplicationHost.config file.

### Attributes

| Attribute | Description |
| --- | --- |
| `allowed` | Required Boolean attribute. <br><br>Specifies whether the restriction allows or denies a CGI or ISAPI module to run on the server. <br><br>See the Default Configuration section below for the complete list of default values. |
| Description | Optional string attribute. <br><br>Specifies the friendly description of the group associated with this groupID. <br><br>See the Default Configuration section below for the complete list of default values. |
| `groupId` | Optional string attribute. <br><br>Specifies the groupID of the application that has a dependency on an extension restriction. <br><br>See the Default Configuration section below for the complete list of default values. |
| `path` | Required string attribute. <br><br>Specifies the path to the CGI or ISAPI module in the file system of the server. <br><br>See the Default Configuration section below for the complete list of default values. |

### Child Elements

None.

### Configuration Sample

The following configuration example is the `<isapiCgiRestriction>` element configuration for IIS 7.0 after you install ASP and ASP.NET version 2.0.

[!code-xml[Main](add/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples add an ISAPI/CGI restriction for a custom ISAPI extension that is located in the content folder for a Web site that is located in C:\Inetpub\www.contoso.com\wwwroot. The examples specify the name, path, and group of the ISAPI extension, and enable the extension.

### AppCmd.exe

[!code-console[Main](add/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](add/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](add/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](add/samples/sample5.js)]

### VBScript

[!code-vb[Main](add/samples/sample6.vb)]