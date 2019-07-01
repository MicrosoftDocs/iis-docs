---
title: "Default FTP Custom Features &lt;customFeatures&gt;"
author: rick-anderson
description: "Overview The &lt;customFeatures&gt; element is used to specify the collection of FTP providers that will implement custom functionality for FTP sites. Note :..."
ms.date: 09/26/2016
ms.assetid: d7da688b-abf8-4941-8343-48c38528e91c
msc.legacyurl: /configreference/system.applicationhost/sites/sitedefaults/ftpserver/customfeatures
msc.type: config
---
Default FTP Custom Features &lt;customFeatures&gt;
====================
<a id="001"></a>
## Overview

The `<customFeatures>` element is used to specify the collection of FTP providers that will implement custom functionality for FTP sites.

> [!NOTE]
> The providers that are added to this collection can implement custom logging or home directory lookups; custom FTP providers that implement authentication and role lookups are added to the `<ftpServer/security/authentication/customAuthentication>` collection.

> [!NOTE]
> The custom features that are added to the `<customFeatures/providers>` element must be registered in the `<system.ftpServer/providerDefinitions>` collection.

> [!NOTE]
> Support for creating custom feature providers was introduced in FTP 7.5. For additional information about how to create FTP custom feature providers, see the [Developing for FTP 7.5](https://www.iis.net/learn/develop/developing-for-ftp) topic on Microsoft's IIS.net Web site.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<customFeatures>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<customFeatures>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<customFeatures>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<customFeatures>` element of the `<ftpServer>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<customFeatures>` element of the `<ftpServer>` element was introduced in FTP 7.0, which was a separate download for IIS 7.0. |
| IIS 6.0 | The FTP service in IIS 6.0 did not support extensibility. |

> [!NOTE]
> The FTP 7.0 and FTP 7.5 services shipped out-of-band for IIS 7.0, which required downloading and installing the modules from the following URL:

> [https://www.iis.net/expand/FTP](https://www.iis.net/downloads/microsoft/ftp)


With Windows 7 and Windows Server 2008 R2, the FTP 7.5 service ships as a feature for IIS 7.5, so downloading the FTP service is no longer necessary.

<a id="003"></a>
## Setup

To support FTP publishing for your Web server, you must install the FTP service. To do so, use the following steps.

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**.
2. In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**.
3. In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**.
4. On the **Server Roles** page, expand **Web Server (IIS)**, and then select **FTP Server**.  
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will need to select **FTP Extensibility**, in addition to **FTP Service**.  
    [![](index/_static/image2.png)](index/_static/image1.png) .
5. Click **Next**, and then on the **Select features** page, click **Next** again.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, and then select **FTP Server**.   
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select **FTP Extensibility**.   
    [![](index/_static/image4.png)](index/_static/image3.png)
4. Click **OK**.
5. Click **Close**.

### Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, expand **FTP Server**.
5. Select **FTP Service**.  
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select **FTP Extensibility**.  
    [![](index/_static/image6.png)](index/_static/image5.png)
6. Click **Next**.
7. On the **Confirm Installation Selections** page, click **Install**.
8. On the **Results** page, click **Close**.

### Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. Expand **Internet Information Services**, and then **FTP Server**.
4. Select **FTP Service**.  
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select **FTP Extensibility**.   
    [![](index/_static/image8.png)](index/_static/image7.png)
5. Click **OK**.

### Windows Server 2008 or Windows Vista

1. Download the installation package from the following URL: 

    - [https://www.iis.net/expand/FTP](https://www.iis.net/downloads/microsoft/ftp)
- Follow the instructions in the following walkthrough to install the FTP service: 

    - [Installing and Troubleshooting FTP 7](https://go.microsoft.com/fwlink/?LinkId=88547)

<a id="004"></a>
## How To

At this time there is no user interface that enables you to add custom features to a site. See the **Configuration** and **Sample Code** sections of this document for additional information about how to add custom features to an FTP site.

<a id="005"></a>
## Configuration

### Attributes

None.

> [!NOTE]
> An unused attribute named `<impersonationLevel>` was declared in the FTP 7.0 schema, but this was removed from the FTP 7.5 schema and should not be used.

### Child Elements

| Element | Description |
| --- | --- |
| [`providers`](providers/index.md) | Optional element.<br><br>Specifies the default collection of custom FTP features. |

### Configuration Sample

The following configuration sample displays an example `<siteDefaults>` element for a server that defines several of the FTP site defaults.

[!code-xml[Main](index/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code samples illustrate setting several of the FTP site defaults.

### AppCmd.exe

[!code-console[Main](index/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](index/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample5.js)]

### VBScript

[!code-vb[Main](index/samples/sample6.vb)]