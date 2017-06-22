FTP Central Logging Options &lt;centralLogFile&gt;
====================
<a id="001"></a>
## Overview

The `<centralLogFile>` element specifies the settings for the central log file, which is used when you specify **centralLogFileMode** for the `centralLogFileMode` attribute of the [`<system.ftpServer/log>`](../../system.ftpserver/log.md) element. When you specify central logging, a single log file will be kept for all of your FTP sites.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<centralLogFile>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<centralLogFile>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<centralLogFile>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<centralLogFile>` element of the `<log>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<centralLogFile>` element of the `<log>` element was introduced in FTP 7.0, which was a separate download for IIS 7.0. |
| IIS 6.0 | The `<system.ftpServer>` element and its child elements replace the IIS 6.0 FTP settings that were located in the **LM/MSFTPSVC** metabase path. |

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
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will need to select     **FTP Extensibility** , in addition to     **FTP Service** .  
    [![](centralLogFile/_static/image2.png)](centralLogFile/_static/image1.png) .
5. Click **Next**, and then on the **Select features** page, click **Next** again.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, and then select **FTP Server**.   
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select     **FTP Extensibility** .   
    [![](centralLogFile/_static/image4.png)](centralLogFile/_static/image3.png)
4. Click **OK**.
5. Click **Close**.

### Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, expand **FTP Server**.
5. Select **FTP Service**.  
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select     **FTP Extensibility** .  
    [![](centralLogFile/_static/image6.png)](centralLogFile/_static/image5.png)
6. Click **Next**.
7. On the **Confirm Installation Selections** page, click **Install**.
8. On the **Results** page, click **Close**.

### Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. Expand **Internet Information Services**, and then **FTP Server**.
4. Select **FTP Service**.  
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select     **FTP Extensibility** .   
    [![](centralLogFile/_static/image8.png)](centralLogFile/_static/image7.png)
5. Click **OK**.

### Windows Server 2008 or Windows Vista

1. Download the installation package from the following URL: 

    - [https://www.iis.net/expand/FTP](https://www.iis.net/downloads/microsoft/ftp)
- Follow the instructions in the following walkthrough to install the FTP service: 

    - [Installing and Troubleshooting FTP 7](https://go.microsoft.com/fwlink/?LinkId=88547)
 
<a id="004"></a>
## How To

### How to configure site-level or server-level logging for the FTP service

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
3. In the **Home** pane, double-click the **FTP Logging** feature.  
    [![](centralLogFile/_static/image10.png)](centralLogFile/_static/image9.png)
4. In the **One log file per** drop-down list, choose one of the following options: 

    - Choose **Site** to specify that each FTP site will write to individual log files.
    - Choose **Server** to specify a single log file for all of your FTP sites.  
        [![](centralLogFile/_static/image12.png)](centralLogFile/_static/image11.png)
5. In the **Actions** pane, click **Apply**.
 
<a id="005"></a>
## Configuration

The `<centralLogFile>` element is configured at the global level in ApplicationHost.config.

| Attribute | Description |
| --- | --- |
| `directory` | Optional string attribute. Specifies the logging directory, where the log file and logging-related support files are stored. The default value is `%SystemDrive%\inetpub\logs\LogFiles`. |
| `enabled` | Optional **Boolean** attribute. **true** if logging is enabled; otherwise **false**. The default value is `true`. |
| `localTimeRollover` | Optional **Boolean** attribute. **true** if a new log file is created based on local time; otherwise, **false** for Coordinated Universal Time (UTC), which was previously called Greenwich Mean Time (GMT). <br><br>**Note:** Regardless of the setting, the time stamp for each W3C Extended Logging log record is UTC-based. The default value is `false`. |
| `logExtFileFlags` | Optional flags attribute. Specifies the categories of information that are written to either the log file (when you use W3C Extended log file format) or to the ODBC data source during logging events for a site. The **logExtFileFlags** attribute can be one or more of the following values. If you specify more than one value, separate them with a comma (,). The default values are `Date`, `Time`, `ClientIP`, `UserName`, `ServerIP`, `Method`, `UriStem`, `FtpStatus`, `Win32Status`, `FtpSubStatus`, `ServerPort`, `Session`, and `FullPath`. | Value | Description | | --- | --- | | `BytesRecv` | Log the number of bytes that the server received. The numeric value is `8192`. | | `BytesSent` | Log the number of bytes that the server sent. The numeric value is `4096`. | | `ClientIP` | Log the IP address of the client that made the request. The numeric value is `4`. | | `ClientPort` | Log the port of the client that made the request. The numeric value is `33554432`. | | `ComputerName` | Log the name of the server on which the log file entry was generated. The numeric value is `32`. | | `Date` | Log the date on which the activity occurred. The numeric value is `1`. | | `FtpStatus` | Log the FTP status code. The numeric value is `1024`. | | `FtpSubStatus` | Log the sub-status code of the FTP error. The numeric value is `2097152`. | | `FullPath` | Log the full relative path. <br><br>**Note:** This may be different from the URI that the client requested, which is logged by setting the `UriStem` flag. The numeric value is `8388608`. | | `Host` | Log the virtual host name, if there is one. The numeric value is `1048576`. | | `Info` | Log extended debugging information, if there is any. The numeric value is `16777216`. | | `Method` | Log the requested action. For example, **USER** , **PASS**, etc. The numeric value is `128`. | | `ServerIP` | Log the IP address of the server on which the log file entry was generated. The numeric value is `64`. | | `ServerPort` | Log the server port number that is configured for the site. The numeric value is `32768`. | | `Session` | Log the unique identifier for the FTP session. This is useful for analyzing session activity in your logs. The numeric value is `4194304`. | | `SiteName` | Log the Internet service name and instance number for the site. The numeric value is `16`. | | `Time` | Log the time in Coordinated Universal Time (UTC), at which the activity occurred. The numeric value is `2`. | | `TimeTaken` | Log the length of time taken for a request to be completed. The time taken is recorded in milliseconds. The numeric value is `16384`. | | `UriStem` | Log the Universal Resource Identifier (URI) stem information, which is the target of the action. <br><br>**Note:** This shows the URI stem exactly as the client requested, which may not be the full relative path. For the full relative path, use the `FullPath` flag. The numeric value is `256`. | | `UserName` | Log the name of the authenticated user who accessed your server. Anonymous users are indicated by a hyphen. The numeric value is `8`. | | `Win32Status` | Log the Windows status code. The numeric value is `2048`. | |
| `period` | Optional enum attribute. Specifies how often the FTP service creates a new log file. The `period` attribute can be one of the following possible values. The default value is `Daily`. | Value | Description | | --- | --- | | `Daily` | Create a new log file daily. The numeric value is `1`. | | `Hourly` | Create a new log file hourly. The numeric value is `4`. | | `MaxSize` | Create a new log file when a maximum size is reached. The maximum size is specified in the truncateSize attribute. The numeric value is `0`. | | `Monthly` | Create a new log file monthly. The numeric value is `3`. | | `Weekly` | Create a new log file weekly. The numeric value is `2`. | |
| `selectiveLogging` | Optional flags attribute. Specifies the verbosity for FTP logging. The default value is `LogSuccessful,LogError,LogInfrastructure`. | Value | Description | | --- | --- | | `LogError` | Specifies that errors will be logged. The amount of data actually logged also depends on the setting of `LogInfrastructure` flag. The numeric value is `2`. | | `LogInfrastructure` | Specifies that all FTP commands and low-level data channel activity will be logged. For example, if the `LogInfrastructure` flag is set then the logs will contain entries for DataChannelOpened, DataChannelClosed, PORT/EPRT, and PASV/EPSV. The numeric value is `4`. | | `LogSuccessful` | Specifies that successful activity will be logged. The amount of data actually logged also depends on the setting of `LogInfrastructure` flag. The numeric value is `1`. | |
| `truncateSize` | Optional int64 attribute. Specifies the maximum size of the log file (in bytes) after which to create a new log file. This value is only applicable when `MaxSize` is chosen for the `period` attribute. The minimum file size is 1,048,576 bytes. If this attribute is set to a value less than 1,048,576 bytes, the default value is implicitly assumed as 1,048,576 bytes. The default value is `20971520`. |

### Child Elements

None.

### Configuration Sample

The following configuration example enables central file logging for the FTP service.

[!code-xml[Main](centralLogFile/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples enable central file logging for the FTP service.

### AppCmd.exe

[!code-console[Main](centralLogFile/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](centralLogFile/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](centralLogFile/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](centralLogFile/samples/sample5.js)]

### VBScript

[!code-vb[Main](centralLogFile/samples/sample6.vb)]