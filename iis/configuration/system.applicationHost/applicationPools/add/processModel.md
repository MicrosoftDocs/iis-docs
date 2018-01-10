---
title: "Process Model Settings for an Application Pool &lt;processModel&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview By using the &lt;processModel&gt; element, you can configure many of the security, performance, health, and reliability features of application pool..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: d2283890-d0be-46e2-9c3a-1b7264e71f52
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.applicationhost/applicationpools/add/processmodel
msc.type: config
---
Process Model Settings for an Application Pool &lt;processModel&gt;
====================
<a id="001"></a>
## Overview

By using the `<processModel>` element, you can configure many of the security, performance, health, and reliability features of application pools on IIS 7 and later. These include the following features:

- Application pool identity, which is the name of the service or user account under which the application pool's worker process runs. This is defined by the **identityType** attribute. By default, starting in IIS 7.5 an application pool runs under the built-in **ApplicationPoolIdentity** account, which is created dynamically by the Windows Process Activation Service (WAS). (In IIS 7.0 the default identity was the **NetworkService** account.) You can change the **identityType** attribute value to the built-in **NetworkService** account, **LocalService** account, the built-in **LocalSystem** account, or a custom account that you create. If you choose a custom account, define the account credentials using the **userName** and **password** attributes. Be aware, however, that the **NetworkService**, **LocalService** and **LocalSystem** accounts have more user rights than the **ApplicationPoolIdentity** account. (**Warning**: It is a serious security risk to run an application pool using high-level user rights.) Additionally, you can use the **logonType** attribute to specify whether the process identity should log on as a batch user or service. (For additional information about logon types, see the [LogonUser Function](https://msdn.microsoft.com/en-us/library/aa378184(VS.85).aspx) topic on Microsoft's MSDN Web site.)
- Web gardening and use of Non-Uniform Memory Access (NUMA) hardware, which you can configure by setting the **maxProcesses** attribute. For Web gardening, see **maxProcesses** to a value greater than one. For use of NUMA hardware, set **maxProcesses** to a value of "0" to specify that IIS runs the same number of worker processes as there are NUMA nodes.
- Idle time-out settings, which allows you to set how long a worker process remains idle before it shuts downs. Edit the **idleTimeout** attribute to configure this setting.
- Health monitoring by enabling pings against the worker process, the maximum time allowed for a worker process to respond to a ping, and the frequency of pings sent to a worker process to monitor its health. Edit the **pingingEnabled**, **pingInterval**, and **pingResponseTime** attributes to configure these settings.
- Worker process shutdown and startup time limits. The first limit is set by the **shutdownTimeLimit** attribute and determines the interval that IIS 7 and later gives a worker process to finish all requests before the WWW service terminates the worker process. The second limit is set by the **startupTimeLimit** attribute and specifies the amount of time IIS 7 and later allows an application pool to start.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<processModel>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `idleTimeoutAction` attribute was added enabling a worker process that is idle for the duration of the `idleTimeout` attribute to be either terminated or suspended, not just terminated. |
| IIS 8.0 | The `setProfileEnvironment` attribute was added enabling the environment to be set based on the user profile for a new process. Values were added for the `maxProcesses` attribute, including support for Non-Uniform Memory Access (NUMA). The `logEventOnProcessModel` attribute was added to specify the action taken in the process is logged. |
| IIS 7.5 | The `<processModel>` element of the `<add>` element was updated in IIS 7.5 to include settings that allow you run applications using the new **ApplicationPoolIdentity** and to specify the login type for the process identity. |
| IIS 7.0 | The `<processModel>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<processModel>` element replaces some of the settings in the IIS 6.0 **IIsApplicationPools** metabase object. |

<a id="003"></a>
## Setup

The `<applicationPools>` collection is included in the default installation of IIS 7 and later.

<a id="004"></a>
## How To

### How to edit process model configuration settings

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
2. In the **Connections** pane, expand the server name, click **Application Pools**, and click the application pool you want to edit.  
    [![](processModel/_static/image2.png)](processModel/_static/image1.png)
3. In the **Actions** pane, click **Advanced Settings...**
4. In the **Advanced Settings** dialog box, click the process model property that you want to edit, and then edit it in the property value section of the dialog box, and then click **OK**. For example, change the **Shutdown Time Limit (seconds)** and **Startup Time Limits (seconds)** to **30**.  
    [![](processModel/_static/image4.png)](processModel/_static/image3.png)

### How to configure IIS for use with Non-Uniform Memory Access (NUMA) hardware

1. Open **Internet Information Services (IIS) Manager**: 

    - If you are using Windows Server 2012 or later: 

        - On the taskbar, click **Server Manager**, click **Tools**, and then click **Internet Information Services (IIS) Manager**.
    - If you are using Windows 8 or later: 

        - Hold down the **Windows** key, press the letter **X**, and then click **Control Panel**.
        - Click **Administrative Tools**, and then double-click **Internet Information Services (IIS) Manager**.
2. In the **Connections** pane, expand the server name, and then click **Application Pools**.
3. In the **Application Pools** pane, select the pool that you want to configure for NUMA.
4. In the **Actions** pane, select **Advanced Settings**.
5. Under **Process Model** pane, set **Maximum Worker Processes** to `0`.  
  
    [![](processModel/_static/image6.png)](processModel/_static/image5.png)

### How to configure the idle timeout action

1. Open **Internet Information Services (IIS) Manager**: 

    - If you are using Windows Server 2012 R2: 

        - On the taskbar, click **Server Manager**, click **Tools**, and then click **Internet Information Services (IIS) Manager**.
    - If you are using Windows 8.1: 

        - Hold down the **Windows** key, press the letter **X**, and then click **Control Panel**.
        - Click **Administrative Tools**, and then double-click **Internet Information Services (IIS) Manager**.
2. In the **Connections** pane, double-click the server name, double-click **Application Pools**, and then select the application pool to configure.
3. In the **Actions** pane, click **Advanced Settings**.
4. In the **Process Model** section of the **Advanced Settings** dialog box, for **idleTimeoutAction**, select **Terminate** or **Suspend**.
5. Click **OK**.  
  
    [![](processModel/_static/image8.png)](processModel/_static/image7.png)

<a id="005"></a>
## Configuration

You configure the `<processModel>` element at the server level in the ApplicationHost.config file.

### Attributes

| Attribute | Description |
| --- | --- |
| `identityType` | Optional enum attribute.<br><br>Specifies the account identity under which the application pool runs.<br><br>**Note:** Starting in IIS 7.5 the default value is ApplicationPoolIdentity. (In IIS 7.0 the default value was `NetworkService`.)<br><br>The **identityType** attribute can be one of the following possible values; the default is `NetworkService`.<br><br><table> <tbody> <tr> <th>Value</th> <th>Description</th></tr> <tr> <th><code>ApplicationPoolIdentity</code></th> <td>Specifies that the application pool runs under the dynamically-created application pool identity account. Starting in IIS 7.5, <code>ApplicationPoolIdentity</code> is the default identity under which to run application pools. (In IIS 7.0 the default identity was <code>NetworkService</code>.)<br><br>When an application pool runs under the <code>ApplicationPoolIdentity</code> account, the application pool accesses resources as the "IIS AppPool\&lt;AppPool&gt;" identity. For example, for the "DefaultAppPool", the identity is "IIS AppPool\DefaultAppPool". This identity allows administrators to specify permissions that pertain only to the identity under which the application pool is running, thereby increasing server security.<br><br>The numeric value is <code>4</code>.</td></tr> <tr> <th><code>LocalService</code></th> <td>Specifies that the application pool runs under the built-in <strong>LocalService</strong> account, which has the same user rights as <strong>NetworkService</strong>.<br><br>When an application pool runs under the <strong>LocalService</strong> account, the application pool presents anonymous credentials on the network.<br><br><strong>Note: </strong>Running an application pool under an account that has high-level user rights is a serious security risk.<br><br>The numeric value is <code>1</code>.</td></tr> <tr> <th><code>LocalSystem</code></th> <td>Specifies that the application pool runs under the built-in <strong>LocalSystem</strong> account, which has extensive privileges on the local computer and acts as the computer on the network.<br><br><strong>Note: </strong>Running an application pool under an account that has high-level user rights is a serious security risk.<br><br>The numeric value is <code>0</code>.</td></tr> <tr> <th><code>NetworkService</code></th> <td>Specifies that the application pool runs under the built-in <strong>NetworkService</strong> account. In IIS 7.0 this was the default identity under which to run application pools; in IIS 7.5 default was changed to <code>ApplicationPoolIdentity</code>.<br><br>When an application pool runs under the <strong>NetworkService</strong> account, the application pool accesses network resources as the computer account.<br><br>The numeric value is <code>2</code>.</td></tr> <tr> <th><code>SpecificUser</code></th> <td>Specifies that the application pool runs under a custom identity, which is configured by using the <strong>userName</strong> and <strong>password</strong> attributes.<br><br><strong>Note: </strong>To avoid storing unencrypted password strings in configuration files, always use AppCmd.exe or IIS Manager to enter passwords. If you use these management tools, the password strings will be encrypted automatically before they are written to the XML configuration files. This provides better password security than storing unencrypted passwords.<br><br><strong>Note: </strong>Managed service accounts can be used to enable services and tasks to share their own domain accounts and to enable automatic password management, eliminating the need for an administrator to manually administer passwords. For more information, see <a href="https://technet.microsoft.com/en-us/library/hh831451.aspx" target="_blank">What's New for Managed Service Accounts</a>.<br><br>The numeric value is <code>3</code>.</td></tr></tbody></table> |
| `idleTimeout` | Optional timeSpan attribute.<br><br>Specifies how long (in minutes) a worker process should run idle if no new requests are received and the worker process is not processing requests. After the allocated time passes, the worker process should request that it be shut down by the WWW service.<br><br>The default value is `00:20:00`. <br><br>To disable the idle timeout feature, set this value to `00:00:00`.|
| `idleTimeoutAction` | Optional enum attribute.<br><br>Specifies the action to perform when the idle timeout duration has been reached. Before IIS 8.5, a worker process that was idle for the duration of the `idleTimeout` attribute would be terminated. After IIS 8.5, you have the choice of terminating a worker process that reaches the `idleTimeout` limit, or suspending it by moving it from memory to disk. Suspending a process will likely take less time and consume less memory than terminating it.<br><br>You can configure an idle timeout action of suspend with the fake request of application initialization (see [`applicationInitialization`](../../../system.webserver/applicationinitialization/index.md).<br><br>The `idleTimeoutAction` attribute can have the following possible values. The default value is `Terminate`. <table> <tbody> <tr> <th>Value</th> <th>Description</th></tr> <tr> <th><code>Terminate</code></th> <td>Terminates an idle worker process. This requires a longer startup period when the site is subsequently accessed by a user and the worker process is started.<br><br>The numeric value is <code>0</code>.</td></tr> <tr> <th><code>Suspend</code></th> <td>Suspends an idle worker process. This leaves the worker process alive, but moved from memory to disk, reducing the system resources consumed. When a request subsequently comes in, the memory manager loads the page files that are required for the request from disk to memory, likely making the worker process available more quickly than if it had been previously terminated.<br><br>The numeric value is <code>1</code>.</td></tr></tbody></table> |
| `loadUserProfile` | Optional Boolean attribute.<br><br>Specifies whether IIS loads the user profile for the application pool identity. Setting this value to **false** causes IIS to revert to IIS 6.0 behavior. IIS 6.0 does not load the user profile for an application pool identity.<br><br>The default value is `false`. |
| `logEventOnProcessModel` | Optional flags attribute.<br><br>Specifies which action taken in the process gets logged to the Event Viewer. In IIS 8.0, the only action that applies is the idle timeout action, in which the process is terminated because it was idle for the idleTimeout period.<br><br>Flag name equals `IdleTimeout`. Value is `1`.<br><br>The default value is `IdleTimeout`. |
| `logonType` | Optional enum attribute.<br><br>Specifies the logon type for the process identity. (For additional information about logon types, see the [LogonUser Function](https://msdn.microsoft.com/en-us/library/aa378184(VS.85).aspx) topic on Microsoft's MSDN Web site.)<br><br>**Note:** This attribute was introduced in IIS 7.5.<br><br>The `logonType` attribute can be one of the following possible values; the default is `LogonBatch`.<br><table> <tbody> <tr> <th>Value</th> <th>Description</th></tr> <tr> <th><code>LogonBatch</code></th> <td>Specifies that the application pool identity should logon as a batch user.<br><br>The numeric value is <code>0</code>.</td></tr> <tr> <th><code>LogonService</code></th> <td>Specifies that the application pool identity should logon as a service.<br><br>The numeric value is <code>1</code>.</td></tr></tbody></table> |
| `manualGroupMembership` | Optional Boolean attribute.<br><br>Specifies whether the IIS\_IUSRS group Security Identifier (SID) is added to the worker process token. When **false**, IIS automatically uses an application pool identity as though it were a member of the built-in IIS\_IUSRS group, which has access to necessary file and system resources. When **true**, an application pool identity must be explicitly added to all resources that a worker process requires at runtime.<br><br>The default value is `false`. |
| `maxProcesses` | Optional uint attribute.<br><br>Indicates the maximum number of worker processes that would be used for the application pool. <ul> <li>A value of "1" indicates a maximum of a single worker process for the application pool. This would be the setting on a server that does not have NUMA nodes. <li>A value of "2" or more indicates a Web garden that uses multiple worker processes for an application pool (if necessary). <li>A value of "0" specifies that IIS runs the same number of worker processes as there are Non-Uniform Memory Access (NUMA) nodes. IIS identifies the number of NUMA nodes that are available on the hardware and starts the same number of worker processes. For example, if you have four NUMA nodes, it will use a maximum of four worker processes for that application pool. In this example, setting maxProcesses to a value of "0" or "4" would have the same result.</li></li></li></ul>The default value is `1`. |
| `password` | Optional string attribute.<br><br>Specifies the password associated with the **userName** attribute. This attribute is only necessary when the value of **identityType** is **SpecificUser**.<br><br>**Note:** To avoid storing unencrypted password strings in configuration files, always use AppCmd.exe or IIS Manager to enter passwords. If you use these management tools, the password strings will be encrypted automatically before they are written to the XML configuration files. This provides better password security than storing unencrypted passwords. |
| `pingingEnabled` | Optional Boolean attribute.<br><br>Specifies whether pinging is enabled for the worker process.<br><br>The default value is `true`. |
| `pingInterval` | Optional timeSpan attribute.<br><br>Specifies the time between health-monitoring pings that the WWW service sends to a worker process.<br><br>The default value is `00:00:30` (30 seconds). |
| `pingResponseTime` | Optional timeSpan attribute.<br><br>Specifies the time that a worker process is given to respond to a health-monitoring ping. After the time limit is exceeded, the WWW service terminates the worker process.<br><br>The default value is `00:01:30` (1 minute 30 seconds). |
| `setProfileEnvironment` | Optional Boolean attribute.<br><br>When setProfileEnvironment is set to `True`, WAS creates an environment block to pass to CreateProcessAsUser when creating a worker process. This ensures that the environment is set based on the user profile for the new process.<br><br>The default value is `True`. |
| `shutdownTimeLimit` | Optional timeSpan attribute.<br><br>Specifies the time that the W3SVC service waits after it initiated a recycle. If the worker process does not shut down within the **shutdownTimeLimit**, it will be terminated by the W3SVC service.<br><br>The default value is `00:01:30` (1 minute 30 seconds). |
| `startupTimeLimit` | Optional timeSpan attribute.<br><br>Specifies the time that IIS waits for an application pool to start. If the application pool does not startup within the **startupTimeLimit**, the worker process is terminated and the rapid-fail protection count is incremented.<br><br>The default value is `00:01:30` (1 minute 30 seconds). |
| `userName` | Optional string attribute.<br><br>Specifies the identity under which the application pool runs when the **identityType** is **SpecificUser**. |

### Child Elements

None.

### Configuration Sample

The following configuration sample uses the application pool `<add>` element to create a new application pool named Contoso. The `<recycling>` element configures logging for application pool restarts, the `<periodicRestart>` element configures when the application pool restarts, and the `<processModel>` element configures the **shutdownTimeLimit** and **startupTimeLimit** attributes for shutting down and starting the worker processes in the application pool for 30 seconds each. If these time limits are exceeded, IIS terminates the worker process.

[!code-xml[Main](processModel/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples change the **processModel.shutdownTimeLimit** and **processModule.startupTimeLimit** property values to 30 seconds each for an application pool named Contoso.

### AppCmd.exe

[!code-console[Main](processModel/samples/sample2.cmd)]

You can also use the following syntax:

[!code-console[Main](processModel/samples/sample3.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](processModel/samples/sample4.cs)]

### VB.NET

[!code-vb[Main](processModel/samples/sample5.vb)]

### JavaScript

[!code-javascript[Main](processModel/samples/sample6.js)]

### VBScript

[!code-vb[Main](processModel/samples/sample7.vb)]
