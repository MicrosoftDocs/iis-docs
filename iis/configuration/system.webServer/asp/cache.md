---
title: "ASP Cache &lt;cache&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;cache&gt; element of the &lt;asp&gt; element specifies the following Active Server Pages (ASP) cache settings for Internet Information Servi..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: 
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.webserver/asp/cache
msc.type: config
---
ASP Cache &lt;cache&gt;
====================
<a id="001"></a>
## Overview

The `<cache>` element of the `<asp>` element specifies the following Active Server Pages (ASP) cache settings for Internet Information Services (IIS) 7, which can control the performance behavior for ASP:

- The **diskTemplateCacheDirectory** attribute contains the name of the directory that ASP uses to store compiled ASP templates to disk after overflow of the in-memory cache. If the default directory is changed, you need to ensure that the identity of the processes running ASP has been assigned full control rights to the new directory.
- The **enableTypelibCache** attribute specifies whether type libraries are cached on the server.
- The value of the **maxDiskTemplateCacheFiles** attribute specifies the maximum number of compiled ASP templates that can be stored. (The directory that stores the compiled templates is configured by the **diskTemplateCacheDirectory** attribute.)
- The **scriptFileCacheSize** attribute specifies the number of precompiled script files to cache. If set to 0, no script files are cached. If set to 4294967295, all script files requested are cached. This attribute is used to tune performance, depending on the amount of available memory and the amount of script file traffic.
- The **scriptEngineCacheMax** attribute specifies the maximum number of scripting engines that ASP pages will keep cached in memory.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<cache>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<cache>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<cache>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<cache>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<cache>` element of the `<asp>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<cache>` element replaces the following IIS 6.0 metabase properties: - **AspDiskTemplateCacheDirectory** - **AspEnableTypelibCache** - **AspMaxDiskTemplateCacheFiles** - **AspScriptEngineCacheMax** - **AspScriptFileCacheSize** |

<a id="003"></a>
## Setup

To support and configure ASP applications on your Web server, you must install the ASP module. To install the ASP module, use the following steps.

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**. - In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**. - In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**. - On the **Server Roles** page, expand **Web Server (IIS)**, expand **Web Server**, expand **Application Development**, and then select **ASP**.  
    [![](cache/_static/image2.png)](cache/_static/image1.png) . - If the **Add features that are required by ASP?** dialog box appears, click **Add Features**. (This page appears only if you have not already installed the ISAPI Extensions role service on your server.) - On the **Server Roles** page, click **Next**. - On the **Select features** page, click **Next**. - On the **Confirm installation selections** page, click **Install**. - On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Application Development Features**, and then select **ASP**.  
    [![](cache/_static/image4.png)](cache/_static/image3.png)   
    > [!NOTE]
    > The ISAPI Extensions role will be selected if it has not already been installed.
4. Click **OK**.
5. Click **Close**.

### Windows Server 2008 or Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, select **ASP**.  
    [![](cache/_static/image6.png)](cache/_static/image5.png)
5. If the **Add role services required by ASP** dialog box appears, click **Add Required Role Services**. (This page appears only if you have not already installed the ISAPI Extensions role service on your server.)  
    [![](cache/_static/image8.png)](cache/_static/image7.png)
6. On the **Select Role Services** page, click **Next**.
7. On the **Confirm Installation Selections** page, click **Install**.
8. On the **Results** page, click **Close**.

### Windows Vista or Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. Expand **Internet Information Services**, then **World Wide Web Services**, then **Application Development Features**.
4. Select **ASP**, and then click **OK**.   
    [![](cache/_static/image10.png)](cache/_static/image9.png)
 
<a id="004"></a>
## How To

### How to configure the ASP cache settings for a server

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
2. In the **Connections** pane, highlight the name of your server.
3. In the server's **Home** pane, double-click **ASP**.  
    [![](cache/_static/image12.png)](cache/_static/image11.png)
4. In the **ASP** pane, expand the **Caching Properties** section, configure your desired settings, then click **Apply** in the **Actions** pane.  
    [![](cache/_static/image14.png)](cache/_static/image13.png)

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `diskTemplateCacheDirectory` | Optional string attribute. Specifies the name of the directory where ASP stores compiled ASP templates when the in-memory cache overflows. The default value is `%SystemDrive%\inetpub\temp\ASP Compiled Templates`. |
| `enableTypelibCache` | Optional Boolean attribute. Specifies whether type libraries are cached. The default value is `true` . |
| `maxDiskTemplateCacheFiles` | Optional uint attribute. Specifies the maximum number of compiled ASP templates that can be stored. This value is an integer in the range from 0 to 2147483647. The default value is `2000`. |
| `scriptEngineCacheMax` | Optional uint attribute. Specifies the maximum number of scripting engines that ASP pages will keep cached in memory. This value is an integer in the range from 0 to 2147483647. The default value is `250`. |
| `scriptFileCacheSize` | Optional uint attribute. Specifies the number of precompiled script files to cache. If set to 0, no script files are cached. If set to 4294967295, all script files requested are cached. This attribute is used to tune performance, depending on the amount of available memory and the amount of script file traffic. The default value is `500`. |

### Child Elements

None.

### Configuration Sample

The following configuration sample sets the directory for the ASP template cache, the maximum number of compiled ASP templates that can be stored to 400, the number of precompiled script files to cache to 1000, and the maximum number of scripting engines that ASP pages will keep cached in memory to 500.

[!code-xml[Main](cache/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code samples set the directory for the ASP template cache, the maximum number of compiled ASP templates that can be stored to 400, the number of precompiled script files to cache to 1000, and the maximum number of scripting engines that ASP pages will keep cached in memory to 500.

### AppCmd.exe

[!code-console[Main](cache/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](cache/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](cache/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](cache/samples/sample5.js)]

### VBScript

[!code-vb[Main](cache/samples/sample6.vb)]