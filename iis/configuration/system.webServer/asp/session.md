---
title: "ASP Session &lt;session&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;session&gt; element of the &lt;asp&gt; element specifies the Active Server Pages (ASP) session state settings. Session state is a means by w..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: 2f2892a9-2155-4c72-ae41-f2f034d64e93
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.webserver/asp/session
msc.type: config
---
ASP Session &lt;session&gt;
====================
<a id="001"></a>
## Overview

The `<session>` element of the `<asp>` element specifies the Active Server Pages (ASP) session state settings. Session state is a means by which Internet Information Services (IIS) 7 stores information about each unique client session. For example, if your Web site has a shopping cart application, the contents of each client's shopping cart can be stored in session state.

You must have memory resources on the server to preserve ASP session state, and the amount of memory that is required varies depending on the amount of information that you are storing in each session. To help regulate the resources that IIS 7 will use, you can specify the settings for session state. For example, the **max** attribute specifies the maximum number of sessions to store, and the **timeout** attribute specifies the duration of each ASP session.

If your applications do not require session state, setting the **allowSessionState** attribute to false will disable ASP session state.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<session>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<session>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<session>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<session>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<session>` element of the `<asp>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<session>` element replaces the following IIS 6.0 metabase properties: <ul> <li><strong>AspAllowSessionState</strong></li> <li><strong>AspKeepSessionIDSecure</strong></li> <li><strong>AspSessionMax</strong></li> <li><strong>AspSessionTimeout</strong></li></ul> |

<a id="003"></a>
## Setup

To support and configure ASP applications on your Web server, you must install the ASP module. To install the ASP module, use the following steps.

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**. - In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**. - In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**. - On the **Server Roles** page, expand **Web Server (IIS)**, expand **Web Server**, expand **Application Development**, and then select **ASP**.  
    [![](session/_static/image2.png)](session/_static/image1.png) . - If the **Add features that are required by ASP?** dialog box appears, click **Add Features**. (This page appears only if you have not already installed the ISAPI Extensions role service on your server.) - On the **Server Roles** page, click **Next**. - On the **Select features** page, click **Next**. - On the **Confirm installation selections** page, click **Install**. - On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Application Development Features**, and then select **ASP**.  
    [![](session/_static/image4.png)](session/_static/image3.png)   
    > [!NOTE]
    > The ISAPI Extensions role will be selected if it has not already been installed.
4. Click **OK**.
5. Click **Close**.

### Windows Server 2008 or Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, select **ASP**.  
    [![](session/_static/image6.png)](session/_static/image5.png)
5. If the **Add role services required by ASP** dialog box appears, click **Add Required Role Services**. (This page appears only if you have not already installed the ISAPI Extensions role service on your server.)  
    [![](session/_static/image8.png)](session/_static/image7.png)
6. On the **Select Role Services** page, click **Next**.
7. On the **Confirm Installation Selections** page, click **Install**.
8. On the **Results** page, click **Close**.

### Windows Vista or Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. Expand **Internet Information Services**, then **World Wide Web Services**, then **Application Development Features**.
4. Select **ASP**, and then click **OK**.   
    [![](session/_static/image10.png)](session/_static/image9.png)
 
<a id="004"></a>
## How To

### How to configure ASP session state settings for a site or application

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
2. In the **Connections** pane, expand the server name, expand **Sites**, and then navigate to the Web site or Web application that you want to configure.
3. In the site or application **Home** pane, double-click **ASP**.  
    [![](session/_static/image12.png)](session/_static/image11.png)
4. In the **ASP** pane, expand the **Session Properties** section and configure your desired settings.  
    [![](session/_static/image14.png)](session/_static/image13.png)
5. Click **Apply** in the **Actions** pane.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `allowSessionState` | Optional Boolean attribute. <br><br>Specifies whether session state persistence for an ASP application is enabled. <br><br>The default value is `true`. |
| `keepSessionIdSecure` | Optional Boolean attribute. <br><br>Specifies whether a session ID is sent as a secure cookie if assigned over a secure session channel. <br><br>The default value is `true`. |
| `max` | Optional uint attribute. <br><br>Specifies the maximum number of concurrent sessions. <br><br>The default value is `4294967295`. |
| `timeout` | Optional timeSpan attribute. <br><br>Specifies the maximum period of time (hh:mm:ss) that a session object is maintained after the last request associated with the object is made. <br><br>The default value is `00:20:00`. |

### Child Elements

None.

### Configuration Sample

The following configuration sample enables ASP session state, sets the maximum number of ASP sessions to 1000, and sets the session time-out to 10 minutes for the Default Web Site.

[!code-xml[Main](session/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code samples enable ASP session state, sets the maximum number of ASP sessions to 1000, and sets the session time-out to 10 minutes for the Default Web Site.

### AppCmd.exe

[!code-console[Main](session/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](session/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](session/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](session/samples/sample5.js)]

### VBScript

[!code-vb[Main](session/samples/sample6.vb)]