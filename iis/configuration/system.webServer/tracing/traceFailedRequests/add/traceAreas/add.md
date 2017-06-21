Adding Trace Areas &lt;add&gt;
====================
<a id="001"></a>
## Overview

Each `<add>` element in the `<traceAreas>` collection defines the trace provider to use for failed request tracing, the provider-specific areas to enable, and the verbosity level of events to include in the trace.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<add>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<add>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<add>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<add>` element in the `<traceAreas>` collection was introduced in IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

After you finish the default installation of IIS 7 and later, you must install the tracing role service to use failed request tracing. After you install the role service, you still must enable failed request tracing at the site level, application level, or directory level.

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**.
2. In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**.
3. In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**.
4. On the **Server Roles** page, expand **Web Server (IIS)**, expand **Web Server**, expand **Health and Diagnostics**, and then select **Tracing**. Click **Next**.  
    [![](add/_static/image2.png)](add/_static/image1.png) .
5. On the **Select features** page, click **Next**.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Health and Diagnostics**, and then select **Tracing**.  
    [![](add/_static/image4.png)](add/_static/image3.png)- Click **OK**.
- Click **Close**.

### Windows Server 2008 or Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, select **Tracing**, and then click **Next**.  
    [![](add/_static/image6.png)](add/_static/image5.png)
5. On the **Confirm Installation Selections** page, click **Install**.
6. On the **Results** page, click **Close**.

### Windows Vista or Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. Expand **Internet Information Services**, then **World Wide Web Services**, then **Health and Diagnostics**.
4. Select **Tracing**, and then click **OK**.  
    [![](add/_static/image8.png)](add/_static/image7.png)
 
<a id="004"></a>
## How To

### How to enable tracing

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
2. In the **Connections** pane, select the server connection, site, application, or directory for which you want to configure failed request tracing.
3. In the **Actions** pane, click **Failed Request Tracing...**  
    [![](add/_static/image10.png)](add/_static/image9.png)
4. In the **Edit Web Site Failed Request Tracing Settings** dialog box, select the **Enable** check box to enable tracing, leave the default value or type a new directory where you want to store failed request log files in the **Directory** box, type the number of failed request trace files you want to store in the **Maximum number of trace files** box, and then click **OK**.  
    [![](add/_static/image12.png)](add/_static/image11.png)

### How to configure failure definitions

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
2. In the **Connections** pane, go to the connection, site, application, or directory for which you want to configure failed request tracing.
3. In the **Home** pane, double-click **Failed Request Tracing Rules**.  
    [![](add/_static/image14.png)](add/_static/image13.png)
4. In the **Actions** pane, click **Add...**
5. On the **Specify Content to Trace** page of the **Add Failed Request Tracing Rule** Wizard, select the content type you want to trace, and then click **Next**.  
    [![](add/_static/image16.png)](add/_static/image15.png)
6. On the **Define Trace Conditions** page, select the conditions you want to trace, and then click **Next**. Trace conditions can include any combination of status codes, a time limit that a request should take, or the event severity. If you specify all conditions, the first condition that is met generates the failed request trace log file.  
    [![](add/_static/image18.png)](add/_static/image17.png)
7. On the **Select Trace Providers** page, select one or more of the trace providers under **Providers**.  
    [![](add/_static/image20.png)](add/_static/image19.png)
8. On the **Select Trace Providers** page, select one or more of the verbosity levels under **Verbosity**.  
    [![](add/_static/image22.png)](add/_static/image21.png)
9. If you selected the **ASPNET** or **WWW Server** trace provider in step 8, select one or more functional areas for the provider to trace under **Areas** of the **Select Trace Providers** page.
10. Click **Finish**.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `areas` | Optional string attribute. Specifies a comma-delimited list, without spaces, that contains the content areas to trace for a given provider. - When the provider attribute is set to "ASPNET," the possible values are "Infrastructure," "Module," "Page," and "AppServices." - When the provider attribute is set to "WWW server," the possible values are "Authentication," "Security," "Filter," "StaticFile," "CGI," "Compression," "Cache," "RequestNotifications," and "All." |
| `provider` | Required string attribute. Specifies which trace provider to use when tracing requests by name. |
| `verbosity` | Optional enum attribute. Specifies the amount and type of information that is saved to the trace log. The verbosity attribute can be one of the following possible values. The default is `Verbose`. | Value | Description | | --- | --- | | `General` | Returns information that provides context for the request activity, for example, a GENERAL\_REQUEST\_START event that logs the URL and the verb for the request. The numeric value is `0`. | | `CriticalError` | Provides information about actions that can cause a process to exit. The numeric value is `1`. | | `Error` | Provides information about components that experience an error and cannot continue to process requests. These errors usually indicate a server-side problem. The numeric value is `2`. | | `Warning` | Provides information about components that experience an error but that can continue to process the request. The numeric value is `3`. | | `Information` | Provides general information about requests. The numeric value is `4`. | | `Verbose` | Provides detailed information about requests. The numeric value is `5`. | |

### Child Elements

None.

### Configuration Sample

The following configuration example configures tracing at the server level in the ApplicationHost.config file. It sets tracing for all .aspx files, uses the `<traceAreas>` element to set the **ASPNET** provider and trace against all ASP.NET areas, which are **Infrastructure**, **Module**, **Page** and **AppServices**. The sample also uses the **verbosity** attribute to set the amount of information returned to the tracing file to **warning**. Lastly, the sample uses the `<failureDefinitions>` element to trace only requests that generate a HTTP 404 status code.

[!code-xml[Main](add/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples enable verbose failed request tracing for HTTP 500 errors in ASP.NET content on all requests to \*.aspx pages.

### AppCmd.exe

[!code-console[Main](add/samples/sample2.cmd)]

### C#

[!code-csharp[Main](add/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](add/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](add/samples/sample5.js)]

### VBScript

[!code-vb[Main](add/samples/sample6.vb)]