---
title: "Application Pools &lt;applicationPools&gt;"
author: rick-anderson
description: "Overview The &lt;applicationPools&gt; element contains configuration settings for all application pools running on your Internet Information Services (IIS) 7..."
ms.date: 09/26/2016
ms.assetid: 85970b4d-9702-4af0-a154-0303230616c9
msc.legacyurl: /configreference/system.applicationhost/applicationpools
msc.type: config
---
Application Pools &lt;applicationPools&gt;
====================
<a id="001"></a>
## Overview

The `<applicationPools>` element contains configuration settings for all application pools running on your Internet Information Services (IIS) 7 or later server. An application pool defines a group of one or more worker processes, configured with common settings that serve requests to one or more applications that are assigned to that application pool. Because application pools allow a set of Web applications to share one or more similarly configured worker processes, they provide a convenient way to isolate a set of Web applications from other Web applications on the server computer. Process boundaries separate each worker process; therefore, application problems in one application pool do not affect Web sites or applications in other application pools. Application pools significantly increase both the reliability and manageability of your Web infrastructure.

You can choose to use the default application pool provided by IIS on install, or you can create your own application pool. You can run as many application pools on your IIS 7 and later server as you need, though this can affect server performance. Application pools can contain one or more worker processes. Each worker process represents work being done for a Web site, Web application, or Web service. You can create a Web garden by enabling multiple worker processes to run in a single application pool.

In IIS 7 and later, each application pool uses one of two .NET integration modes for running ASP.NET applications: **Integrated** or **Classic**. The .NET integration mode defined for the application pool determines how IIS processes an incoming request to the sites, applications and Web services that run in that application pool.

- **Integrated** mode allows IIS to process requests in the application pool by using the IIS 7 and later integrated pipeline. This allows ASP.NET modules to participate in IIS request processing regardless of the type of resource requested. Using integrated mode makes available features of the ASP.NET 2.0 request pipeline available to requests for static content, as well as ASP, PHP and other content types. By default, IIS 7 and later application pools run in this mode.
- **Classic** mode uses the IIS 6.0 processing pipeline for hosting ASP.NET applications. In this mode, requests are processed initially through IIS 7 and later modules, and ASP.NET requests are further processed by the aspnet\_isapi.dll. The ASP.NET processing pipeline is separate from the IIS 7 and later processing pipeline, and the ASP.NET request processing pipeline features are not available to other resource types. This also means that an ASP.NET request must pass through authentication and authorization modules in both process models. While this is not as efficient as Integrated mode, it does allow you to run applications developed using ASP.NET version 1.1 on an IIS 7 and later server without modifying the application to run in Integrated mode.

#### New in IIS 7.5 and later

Starting in IIS 7.5, you can configure an application to start automatically by using the **managedRuntimeLoader**, **CLRConfigFile**, and **startMode** attributes of the `<add>` element. These attributes configure, respectively, the name of the managed DLL that provides runtime loading for your application, the common language runtime configuration file for the application, and the startup type for the application.

Also new in IIS 7.5 and later is a new `ApplicationPoolIdentity` type for the **identityType** attribute of the [`<processModel>`](add/processmodel.md) element. This new identity type is now the default process identity for applications, and makes it possible to set the security for your content areas to allow access for a specific application pool. To do so, you would set your security using the name of an application pool by using syntax like "IIS AppPool\DefaultAppPool." This identity is created dynamically, thereby dramatically reducing the surface attack area of your server.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<applicationPools>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<applicationPools>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<applicationPools>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<add>` element of the `<applicationPools>` element was updated in IIS 7.5 to include attributes that allow you to preload applications by using the **managedRuntimeLoader**, **CLRConfigFile**, and **startMode** attributes, and to run applications using the new **ApplicationPoolIdentity**. |
| IIS 7.0 | The `<applicationPools>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<applicationPools>` element replaces the IIS 6.0 **IIsApplicationPools** metabase object. |

<a id="003"></a>
## Setup

The `<applicationPools>` collection is included in the default installation of IIS 7 and later.

<a id="004"></a>
## How To

### How to create a new application pool

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
2. In the **Connections** pane, expand the server name, and then click **Application Pools**.
3. In the **Actions** pane, click **Add Application Pool...**.
4. In the **Add Application Pool** dialog box, enter the name of the application pool in the **Name:** box, in the **.NET Framework version:** drop-down list select the .NET Framework version your site or application uses, in the **Managed pipeline mode:** drop-down list select **Integrated** or **Classic**, and then click **OK**.  
    [![](index/_static/image2.png)](index/_static/image1.png)

### How to configure the application pool for an existing site or application

1. In the **Connections** pane, expand **Sites**, and then navigate to the Web site or application you want to add to the application pool.
2. In the **Actions** pane, click **Advanced Settings...**
3. In the **General** section of the **Advanced Settings** dialog box, click the **Application Pool** entry, and then click the ellipses button.  
    [![](index/_static/image4.png)](index/_static/image3.png)
4. In the **Select Application Pool** dialog box, select the application pool from the **Application pool:** drop-down box, click **OK**, and then click **OK** again.  
    [![](index/_static/image6.png)](index/_static/image5.png)

<a id="005"></a>
## Configuration

The `<applicationPools>` element contains a collection of `<add>` elements. Each element in the collection configures an application pool running on IIS 7 and later. At a minimum, each `<add>` element contains a **name** attribute that identifies the application pool to GUI and command-line management tools. The `<add>` element contains child elements that configure the process model, CPU, and recycling settings for the application pool.

The `<applicationPools>` element also contains the `<applicationPoolDefaults>` element, which defines default settings for all application pools on the IIS 7 and later server. To change default application pool settings across the server, you can edit the `<applicationPoolDefaults>` element. When you create a new application pool, the configuration settings for that application pool override the defaults set in the `<applicationPoolDefaults>` element.

### Attributes

None.

### Child Elements

| Element | Description |
| --- | --- |
| [`add`](add/index.md) | Adds an application pool to the applicationPools section. |
| [`applicationPoolDefaults`](applicationpooldefaults/index.md) | Required string attribute. <br><br>Configures the default settings for all application pools in an applicationPools section. |

### Configuration Sample

The following configuration sample uses the application pool `<add>` and `<applicationPools>` elements to define the standard application pools and defaults for IIS.

[!code-xml[Main](index/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples add an application pool named Contoso, and set the managed pipeline mode to Integrated.

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
