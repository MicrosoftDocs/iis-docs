Default Trace Failed Requests Logging for a Site &lt;traceFailedRequestsLogging&gt;
====================
<a id="001"></a>
## Overview

The `<traceFailedRequestsLogging>` element of the `<siteDefaults>` element sets the failed request tracing options for all sites, such as the directory for failed request tracing log files, the maximum number of failed request tracing log files, and whether failed request tracing is enabled.

> [!NOTE]
> If the `<traceFailedRequestsLogging>` element is configured in both the `<siteDefaults>` section and in the `<site>` section for a specific site, the configuration in the `<site>` section is used for that site.

> [!NOTE]
> The `<traceFailedRequestsLogging>` element specifies the global-level options for failed request tracing, but the &lt;[`system.webServer/tracing/traceFailedRequests`](https://www.iis.net/configreference/system.webserver/tracing/tracefailedrequests)&gt; element specifies failed request tracing rules.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<traceFailedRequestsLogging>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<traceFailedRequestsLogging>` element was not modified in IIS 8.5. |
| IIS 8.0 | The default value for the `maxLogFileSizeKB` attribute was increased. |
| IIS 7.5 | The `<traceFailedRequestsLogging>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<traceFailedRequestsLogging>` element of the `<siteDefaults>` element was introduced in IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

After you finish the default installation of IIS 7 and later, you must install the tracing role service to use failed request tracing. After you install the role service, you still must enable failed request tracing at the site level, application level, or directory level.

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**.
2. In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**.
3. In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**.
4. On the **Server Roles** page, expand **Web Server (IIS)**, expand **Web Server**, expand **Health and Diagnostics**, and then select **Tracing**. Click **Next**.  
    [![](traceFailedRequestsLogging/_static/image2.png)](traceFailedRequestsLogging/_static/image1.png) .
5. On the **Select features** page, click **Next**.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Health and Diagnostics**, and then select **Tracing**.  
    [![](traceFailedRequestsLogging/_static/image4.png)](traceFailedRequestsLogging/_static/image3.png)- Click **OK**.
- Click **Close**.

### Windows Server 2008 or Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, select **Tracing**, and then click **Next**.  
    [![](traceFailedRequestsLogging/_static/image6.png)](traceFailedRequestsLogging/_static/image5.png)
5. On the **Confirm Installation Selections** page, click **Install**.
6. On the **Results** page, click **Close**.

### Windows Vista or Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. Expand **Internet Information Services**, then **World Wide Web Services**, then **Health and Diagnostics**.
4. Select **Tracing**, and then click **OK**.  
    [![](traceFailedRequestsLogging/_static/image8.png)](traceFailedRequestsLogging/_static/image7.png)
 
<a id="004"></a>
## How To

### How to configure the site defaults for a server

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
2. In the **Connections** pane, expand the server name, then click the **Sites** node.
3. In the server's **Sites** pane, click **Set Web Site Defaults...** in the **Actions** pane.  
    [![](traceFailedRequestsLogging/_static/image10.png)](traceFailedRequestsLogging/_static/image9.png)
4. In the **Web Site Defaults** dialog box, specify your default options for all Web sites, and then click **OK**.  
  
    [![](traceFailedRequestsLogging/_static/image12.png)](traceFailedRequestsLogging/_static/image11.png)
 
<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `customActionsEnabled` | Optional Boolean attribute. Specifies whether custom actions are enabled for failed request tracing. The default value is `false`. |
| `directory` | Optional string attribute. Specifies the failed request trace logging directory for a site. The default value is `%SystemDrive%\inetpub\logs\FailedReqLogFiles`. |
| `enabled` | Optional Boolean attribute. Specifies whether failed request trace logging is enabled for a site (**true**) or disabled (**false**). The default value is `false`. |
| `maxLogFiles` | Optional uint attribute. Specifies the maximum number of failed request tracing log files to keep for the site. The default value is `50`. |
| `maxLogFileSizeKB` | Optional uint attribute. Specifies the maximum file size in kilobytes for failed request tracing logs. **Note:** If failed request tracing logs exceed this value, IIS will truncate the logs at the maximum file size and specify LOG\_FILE\_MAX\_SIZE\_TRUNCATE for the trace event. The default value is `1024`. |

### Child Elements

None.

### Configuration Sample

The following configuration sample specifies the default `traceFailedRequestsLogging` options for IIS 7.

[!code-xml[Main](traceFailedRequestsLogging/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code samples configure the default `traceFailedRequestsLogging` options for IIS 7.

### AppCmd.exe

[!code-csharp[Main](traceFailedRequestsLogging/samples/sample2.cs)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](traceFailedRequestsLogging/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](traceFailedRequestsLogging/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](traceFailedRequestsLogging/samples/sample5.js)]

### VBScript

[!code-vb[Main](traceFailedRequestsLogging/samples/sample6.vb)]