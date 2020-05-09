---
title: "Adding Application Pools &lt;add&gt;"
author: rick-anderson
description: "Overview The &lt;add&gt; element of the &lt;applicationPools&gt; element controls the configuration settings for an IIS 7 and later application pool. You cre..."
ms.date: 09/26/2016
ms.assetid: dbd06536-dbca-4367-ae1d-600547c13503
msc.legacyurl: /configreference/system.applicationhost/applicationpools/add
msc.type: config
---
Adding Application Pools &lt;add&gt;
====================
<a id="001"></a>
## Overview

The `<add>` element of the `<applicationPools>` element controls the configuration settings for an IIS 7 and later application pool. You create an `<add>` element in the ApplicationHost.config file for each application pool that you want to run on your IIS server.

The `<add>` element can contain attributes and child elements that configure the pipeline processing mode and the version of the .NET Framework the worker processes in the application pool use for incoming requests. This element also contains child elements that configure application pool identity, performance, and health and recycling application pool settings.

When you create a new application pool on IIS 7 and later, at a minimum you must assign the application pool a unique name. Configure all other properties as needed for the applications that use the application pool.

#### New in IIS 7.5 and later

Starting in IIS 7.5, you can configure an application to start automatically by using the **managedRuntimeLoader**, **CLRConfigFile**, and **startMode** attributes of the `<add>` element. These attributes configure, respectively, the name of the managed DLL that provides runtime loading for your application, the common language runtime configuration file for the application, and the startup type for the application.

Also new in IIS 7.5 and later is a new `ApplicationPoolIdentity` type for the **identityType** attribute of the [`<processModel>`](processmodel.md) element. This new identity type is now the default process identity for applications, and makes it possible to set the security for your content areas to allow access for a specific application pool. To do so, you would set your security using the name of an application pool by using syntax like "IIS AppPool\DefaultAppPool." This identity is created dynamically, thereby dramatically reducing the surface attack area of your server.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<add>` element was not modified in IIS 8.5. |
| IIS 8.0 | The default value of the `managedRuntimeVersion` attribute was changed to `""`, and `v4.0` was added as a value for `managedRuntimeVersion`. |
| IIS 7.5 | The `<add>` element of the `<applicationPools>` element was updated in IIS 7.5 to include attributes that allow you to preload applications. |
| IIS 7.0 | The `<add>` element of the `<applicationPools>` collection was introduced in IIS 7.0. |
| IIS 6.0 | The `<applicationPools>` collection replaces portions of the IIS 6.0 **IIsApplicationPools** metabase property. |

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

The `<add>` element of the `<applicationPools>` collection is configurable at the server level in the ApplicationHost.config file.

### Attributes

| Attribute | Description |
| --- | --- |
| `autoStart` | Optional Boolean attribute.<br><br>When **true**, indicates to the World Wide Web Publishing Service (W3SVC) that the application pool should be automatically started when it is created or when IIS is started.<br><br>The default value is `true`. |
| `CLRConfigFile` | Optional string value.<br><br>Specifies the .NET configuration file for the application pool.<br><br>**Note:** This attribute was added in IIS 7.5.<br><br>There is no default value. |
| `enable32BitAppOnWin64` | Optional Boolean attribute.<br><br>When **true**, enables a 32-bit application to run on a computer that runs a 64-bit version of Windows.<br><br>The default value is `false`. |
| `enableConfigurationOverride` | Optional Boolean attribute.<br><br>When **true**, indicates that delegated settings in Web.config files will processed for applications within this application pool. When **false**, all settings in Web.config files will be ignored for this application pool.<br><br>The default value is `true`. |
| `managedPipelineMode` | Optional enum attribute.<br><br>Specifies the request-processing mode that is used to process requests for managed content.<br><br>The **managedPipelineMode** attribute can be one of the following possible values. <table> <tbody> <tr> <th>Value</th> <th>Description</th></tr> <tr> <th><code>Classic</code></th> <td>Specifies that the application pool use separate IIS and ASP.NET request-processing pipelines, which works with ASP.NET 1.1 applications, and ASP.NET 2.0 or later applications that do not work in Integrated mode.<br><br>The numeric value is <code>1</code>.</td></tr> <tr> <th><code>Integrated</code></th> <td>Specifies that the application pool use the integrated IIS and ASP.NET request-processing pipeline, which works with only ASP.NET 2.0 or later applications.<br><br>The numeric value is <code>0</code>.</td></tr></tbody></table> The default is `Integrated`. |
| `managedRuntimeLoader` | Optional string attribute.<br><br>Specifies the managed loader to use for pre-loading the application pool.<br><br>**Note:** This attribute was added in IIS 7.5.<br><br>The default value is **webengine4.dll**. |
| `managedRuntimeVersion` | Optional string attribute.<br><br>Specifies the CLR version to be used by the application pool.<br><br>The **managedRuntimeVersion** attribute can be one of the following possible values. <table> <tbody> <tr> <th>Value</th> <th>Description</th></tr> <tr> <th><code>v1.1</code></th> <td>Specifies that the application pool use the CLR version 1.1.</td></tr> <tr> <th><code>v2.0</code></th> <td>Specifies that the application pool use the CLR version 2.0, which can be .NET Framework version 2.0, 3.0, or 3.5.</td></tr> <tr> <th><code>v4.0</code></th> <td>Specifies that the application pool use the CLR version 4.0, which can be .NET Framework version 4.0 or 4.5.</td></tr></tbody></table>The default value is `""`. |
| `name` | Required string attribute.<br><br>Specifies a unique name for an application pool on the server. |
| `passAnonymousToken` | Optional Boolean attribute.<br><br>If **true**, the Windows Process Activation Service (WAS) creates and passes a token for the built-in IUSR anonymous user account to the Anonymous authentication module. The Anonymous authentication module uses the token to impersonate the built-in account. When **PassAnonymousToken** is **false**, the token will not be passed.<br><br>**Note:** The IUSR anonymous user account replaces the IIS\_MachineName anonymous account. The IUSR account can be used by IIS or other applications. It does not have any privileges assigned to it during setup.<br><br>The default value is `true`. |
| `queueLength` | Optional uint attribute.<br><br>Indicates to HTTP.sys how many requests to queue for an application pool before rejecting future requests. The default value is `1000`.<br><br>When the value set for this property is exceeded, IIS rejects subsequent requests with a 503 error. If the **loadBalancerCapabilities** setting is **true**, the connection is closed instead of rejecting requests with a 503. For more information about **loadBalancerCapabilities**, see [Failure Settings for an Application Pool](failure.md). |
| `startMode` | Optional enum value.<br><br>Specifies the startup type for the application pool.<br><br>**Note:** This attribute was added in IIS 7.5.<br><br>The **startMode** attribute can be one of the following possible values. <table> <tbody> <tr> <th>Value</th> <th>Description</th></tr> <tr> <th><code>AlwaysRunning</code></th> <td>Specifies that the Windows Process Activation Service (WAS) will always start the application pool. This behavior allows an application to load the operating environment before any serving any HTTP requests, which reduces the start-up processing for initial HTTP requests for the application.<br><br>The numeric value is <code>1</code>.</td></tr> <tr> <th><code>OnDemand</code></th> <td>Specifies that the Windows Process Activation Service (WAS) will start the application pool when an HTTP request is made for an application that is hosted in the application pool. This behavior resembles the WAS behavior in previous versions of IIS.<br><br>The numeric value is <code>0</code>.</td></tr></tbody></table> The default value is `OnDemand`. |

### Child Elements

| Element | Description |
| --- | --- |
| [`cpu`](cpu.md) | Configures CPU affinity and CPU actions. |
| [`environmentVariables`](environmentvariables/index.md) | Configures a collection of environment variables to pass to worker processes. |
| [`failure`](failure.md) | Configures actions to take when an application pool fails. |
| [`processModel`](processmodel.md) | Configures process management attributes for an application pool. |
| [`recycling`](recycling/index.md) | Configures application pool recycling. |

### Configuration Sample

The following configuration sample uses the application pool `<add>` element to create a new application pool named Contoso. The `<recycling>` element configures logging for application pool restarts, the `<periodicRestart>` element configures when the application pool restarts, and the `<processModel>` element configures the **shutdownTimeLimit** and **startupTimeLimit** attributes for shutting down and starting the worker processes in the application pool for 30 seconds each. If these time limits are exceeded, IIS terminates the worker process.

[!code-xml[Main](index/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code examples add an application pool named Contoso to your IIS 7 and later server, then set the application pool to daily recycle at 3:00 A.M.

### AppCmd.exe

[!code-console[Main](index/samples/sample2.cmd)]

You can also use the following syntax:

[!code-console[Main](index/samples/sample3.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C\#

[!code-csharp[Main](index/samples/sample4.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample5.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample6.js)]

### VBScript

[!code-vb[Main](index/samples/sample7.vb)]
