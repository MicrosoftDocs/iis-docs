Deny by Failure <denyByFailure>
====================
<a id="001"></a>
## Overview

The `<denyByFailure>` element configures the FTP service to deny access to the FTP service based upon how many times an FTP client fails to authenticate within a time period. When the number of failed login attempts has been reached, the FTP connection will be closed forcibly, and the client IP address will be blocked from accessing the FTP service for the duration of the time period (as set by the entryExpiration attribute). Denying access by the failure rate can only be enabled for the server, not for individual sites.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<denyByFailure>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<denyByFailure>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<denyByFailure>` element was introduced in IIS 8.0. |
| IIS 7.5 | N/A |
| IIS 7.0 | N/A |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

To support denying access through authentication on your FTP server, you must install the FTP Service role service.

### Windows Server 2012

1. Press the **Windows logo key**, and then click **Server Manager**.
2. In **Server Manager**, click **Manage** and then click **Add Roles and Features**.
3. In the **Add Roles and Features** wizard: 

    - On the **Before You Begin** page, click **Next**.
    - On the **Installation Type** page, select the installation type, and then click **Next**.
    - On the **Server Selection** page, select the appropriate server, and then click **Next**.
    - On the **Server Roles** page, ensure that **Web Server (IIS)** is selected, and then expand it.
    - Expand **FTP Server**, then select both **FTP Service** and **FTP Extensibility**, and then click **Next**.
    - On the **Features** page, click **Next**.
    - On the **Confirm Installation Selections** page, click **Install**.
    - On the **Results** page, click **Close**.

### Windows 8

1. Open the Windows Control Panel.
2. In the Windows Control Panel, open **Programs and Features**.
3. In **Programs and Features**, click **Turn Windows features on or off**.
4. In the **Windows Features** dialog box, expand **Internet Information Services**, and then expand **FTP Server**.
5. Under **FTP Server**, select **FTP Service** and **FTP Extensibility**, and then click **OK**.

<a id="004"></a>
## How To

### How to deny access to the FTP server based upon the logon failure rate

1. Open **Internet Information Services (IIS) Manager**: 

    - If you are using Windows Server 2012 or later: 

        - On the taskbar, click **Server Manager**, click **Tools**, and then click **Internet Information Services (IIS) Manager**.
    - If you are using Windows 8 or later: 

        - Hold down the **Windows** key, press the letter **X**, and then click **Control Panel**.
        - Click **Administrative Tools**, and then double-click **Internet Information Services (IIS) Manager**.
2. In the **Connections** pane, select the server.
3. In the **Home** pane, double-click the **FTP Logon Attempt Restrictions** feature.  
  
    [![](denyByFailure/_static/image2.png)](denyByFailure/_static/image1.png)
4. In the **FTP Logon Attempt Restrictions** dialog box, click **Enable** to enable the restrictions, and then enter the maximum number of failures and the time frame in which those failures will prompt access to the FTP service to be denied.
5. Click **Write to the log only** to log that the condition has been met, but not to block logon attempts.
6. Click **Apply** in the **Actions** pane.

<a id="005"></a>
## Configuration

The `<denyByFailure>` element is configured at the server level.

### Attributes

| Attribute | Description |
| --- | --- |
| `enabled` | Optional Boolean attribute. Enables the FTP service to deny access based upon the failure rate. The default value is `False`. |
| `maxFailure` | Optional uint attribute. Specifies the number of failures in the specific time span that will prompt access to the FTP service to be denied. The default value is `4`. |
| `entryExpiration` | Optional TimeSpan attribute. Specifies the period of time in which a specified number of failures will prompt access to the FTP service to be denied. The default value is `00:00:30`. |
| `loggingOnlyMode` | Optional Boolean attribute. Specifies that access will not be denied because of the failure rate, but that the event will be logged. The default value is `False`. |

### Child Elements

None.

### Configuration Sample

The following sample configures a `<denyByFailure>` element.

[!code-xml[Main](denyByFailure/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code samples configure denying access to the FTP server based upon the logon failure rate.

### AppCmd.exe

[!code-console[Main](denyByFailure/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when using AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.
  

### C#

[!code-csharp[Main](denyByFailure/samples/sample3.cs)]
  

### VB.NET

[!code-vb[Main](denyByFailure/samples/sample4.vb)]
  

### JavaScript

[!code-javascript[Main](denyByFailure/samples/sample5.js)]
  

### VBScript

[!code-vb[Main](denyByFailure/samples/sample6.vb)]
  

### PowerShell

[!code-ps[Main](denyByFailure/samples/sample-0-7.unknown)]

[!code-console[Main](denyByFailure/samples/sample8.cmd)]