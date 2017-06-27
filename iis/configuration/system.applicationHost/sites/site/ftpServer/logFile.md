---
title: "FTP Log Files &lt;logFile&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;logFile&gt; element is used to configure the activity logging options for an FTP site. For example, you can enable or disable logging, speci..."
ms.author: iiscontent
manager: soshir
ms.date: 9/26/2016 12:00:00 AM
ms.topic: article
ms.assetid: 
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.applicationhost/sites/site/ftpserver/logfile
msc.type: config
---
FTP Log Files &lt;logFile&gt;
====================
<a id="001"></a>
## Overview

The `<logFile>` element is used to configure the activity logging options for an FTP site.

For example, you can enable or disable logging, specify the categories of information to store in the log file, and change the directory where the log file is stored. You can also use the `<logFile>` element to control how often IIS creates a new log file based either on log file size or time interval and the maximum size (in bytes) that a log file can become.

> [!NOTE]
> Unlike Web sites that can use the IIS, NCSA, or W3C format for log files, the FTP 7 service only stores log files in W3C format.

You can define the categories of information that IIS logs by editing the **logExtFileFlags** attribute. The default values are `Date`, `Time`, `ClientIP`, `UserName`, `ServerIP`, `Method`, `UriStem`, `FtpStatus`, `Win32Status`, `FtpSubStatus`, `ServerPort`, `Session`, and `FullPath`.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<logFile>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<logFile>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<logFile>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<logFile>` element of the `<ftpServer>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<logFile>` element of the `<ftpServer>` element was introduced in FTP 7.0, which was a separate download for IIS 7.0. |
| IIS 6.0 | N/A |

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
    [![](logFile/_static/image2.png)](logFile/_static/image1.png) .
5. Click **Next**, and then on the **Select features** page, click **Next** again.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, and then select **FTP Server**.   
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select     **FTP Extensibility** .   
    [![](logFile/_static/image4.png)](logFile/_static/image3.png)
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
    [![](logFile/_static/image6.png)](logFile/_static/image5.png)
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
    [![](logFile/_static/image8.png)](logFile/_static/image7.png)
5. Click **OK**.

### Windows Server 2008 or Windows Vista

1. Download the installation package from the following URL: 

    - [https://www.iis.net/expand/FTP](https://www.iis.net/downloads/microsoft/ftp)
- Follow the instructions in the following walkthrough to install the FTP service: 

    - [Installing and Troubleshooting FTP 7](https://go.microsoft.com/fwlink/?LinkId=88547)

<a id="004"></a>
## How To

### How to configure logging options for an FTP site

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
2. In the **Connections** pane, expand the server name, and then go to the site where you want to configure logging.
3. In the **Home** pane, double-click **FTP Logging**.  
    [![](logFile/_static/image10.png)](logFile/_static/image9.png) - In the **Log File Rollover** section, click **Select W3C Fields...**
- Select the fields for your log files, then click **OK**.  
    [![](logFile/_static/image12.png)](logFile/_static/image11.png)
- Under **Directory**, specify the path where the log file should be stored. The default is *%SystemDrive%*\inetpub\logs\LogFiles.
- In the **Log File Rollover** section, specify the following options: 

    - **Schedule**: to create new log file that are based on one of the following values: 

        - **Hourly**: a new log file is created each hour.
        - **Daily**: a new log file is created each day.
        - **Weekly**: a new log file is created each week.
        - **Monthly**: a new log file is created each month.
    - **Maximum file size (in bytes)**: to create a new log file when the file reaches a certain size (in bytes). The minimum file size is 1048576 bytes. If this attribute is set to a value less than 1048576 bytes, the default value is implicitly assumed as 1048576 bytes.
    - **Do not create a new log file**: there is a single log file that will continue to grow as information is logged.
    - Select **Use local time for file naming and rollover** to specify that log file naming and time for log file rollover uses the local server time. When this is not selected, Coordinated Universal Time (UTC) is used.  
        [![](logFile/_static/image14.png)](logFile/_static/image13.png)
- Click **Apply** in the **Actions** pane.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `directory` | Optional string attribute. Specifies the logging directory, where the log file and logging-related support files are stored. The default value is `%SystemDrive%\inetpub\logs\LogFiles`. |
| `enabled` | Optional Boolean attribute. **true** if logging is enabled; otherwise **false**. The default value is `true`. |
| `localTimeRollover` | Optional Boolean attribute. **true** if the a new log file is created based on local time; otherwise, **false** for Coordinated Universal Time (UTC), which was previously called Greenwich Mean Time (GMT). <br><br>**Note:** Regardless of the setting, the time stamp for each W3C Extended Logging log record is UTC-based. The default value is `false`. |
| `logExtFileFlags` | Optional flags attribute. Specifies the categories of information that are written to either the log file (when you use W3C Extended log file format) or to the ODBC data source during logging events for a site. The **logExtFileFlags** attribute can be one or more of the following values. If you specify more than one value, separate them with a comma (,). The default values are `Date`, `Time`, `ClientIP`, `UserName`, `ServerIP`, `Method`, `UriStem`, `FtpStatus`, `Win32Status`, `FtpSubStatus`, `ServerPort`, `Session`, and `FullPath`. | Value | Description | | --- | --- | | `BytesRecv` | Log the number of bytes that the server received. The numeric value is `8192`. | | `BytesSent` | Log the number of bytes that the server sent. The numeric value is `4096`. | | `ClientIP` | Log the IP address of the client that made the request. The numeric value is `4`. | | `ClientPort` | Log the port of the client that made the request. The numeric value is `33554432`. | | `ComputerName` | Log the name of the server on which the log file entry was generated. The numeric value is `32`. | | `Date` | Log the date on which the activity occurred. The numeric value is `1`. | | `FtpStatus` | Log the FTP status code. The numeric value is `1024`. | | `FtpSubStatus` | Log the sub-status code of the FTP error. The numeric value is `2097152`. | | `FullPath` | Log the full relative path. <br><br>**Note:** This may be different URI that the client requested, which is logged by setting the `UriStem` flag. The numeric value is `8388608`. | | `Host` | Log the virtual host name, if there is one. The numeric value is `1048576`. | | `Info` | Log extended debugging information, if there is any. The numeric value is `16777216`. | | `Method` | Log the requested action. For example, **USER** , **PASS**, etc. The numeric value is `128`. | | `ServerIP` | Log the IP address of the server on which the log file entry was generated. The numeric value is `64`. | | `ServerPort` | Log the server port number that is configured for the site. The numeric value is `32768`. | | `Session` | Log the unique identifier for the FTP session. This is useful for analyzing session activity in your logs. The numeric value is `4194304`. | | `SiteName` | Log the Internet service name and instance number for the site. The numeric value is `16`. | | `Time` | Log the time in Coordinated Universal Time (UTC), at which the activity occurred. The numeric value is `2`. | | `TimeTaken` | Log the length of time taken for a request to be completed. The time taken is recorded in milliseconds. The numeric value is `16384`. | | `UriStem` | Log the Universal Resource Identifier (URI) stem information, which is the target of the action. <br><br>**Note:** This shows the URI steam exactly as the client requested, which may not be the full relative path. For the full relative path, use the `FullPath` flag. The numeric value is `256`. | | `UserName` | Log the name of the authenticated user who accessed your server. Anonymous users are indicated by a hyphen. The numeric value is `8`. | | `Win32Status` | Log the Windows status code. The numeric value is `2048`. | |
| `period` | Optional enum attribute. Specifies how often the FTP service creates a new log file. The `period` attribute can be one of the following possible values. The default value is `Daily`. | Value | Description | | --- | --- | | `Daily` | Create a new log file daily. The numeric value is `1`. | | `Hourly` | Create a new log file hourly. The numeric value is `4`. | | `MaxSize` | Create a new log file when a maximum size is reached. The maximum size is specified in the truncateSize attribute. The numeric value is `0`. | | `Monthly` | Create a new log file monthly. The numeric value is `3`. | | `Weekly` | Create a new log file weekly. The numeric value is `2`. | |
| `selectiveLogging` | Optional flags attribute. Specifies the verbosity for FTP logging. The default value is `LogSuccessful,LogError,LogInfrastructure`. | Value | Description | | --- | --- | | `LogError` | Specifies that errors will be logged. The amount of data actually logged also depends on the setting of `LogInfrastructure` flag. The numeric value is `2`. | | `LogInfrastructure` | Specifies that all FTP commands and low-level data channel activity will be logged. For example, the logs will contain entries for DataChannelOpened, DataChannelClosed, PORT/EPRT, PASV/EPSV, if the `LogInfrastructure` flag is set. The numeric value is `4`. | | `LogSuccessful` | Specifies that successful activity will be logged. The amount of data actually logged also depends on the setting of `LogInfrastructure` flag. The numeric value is `1`. | |
| `truncateSize` | Optional int64 attribute. Specifies the maximum size of the log file (in bytes) after which to create a new log file. This value is only applicable when `MaxSize` is chosen for the `period` attribute. The minimum file size is 1,048,576 bytes. If this attribute is set to a value less than 1,048,576 bytes, the default value is implicitly assumed as 1,048,576 bytes. The default value is `20971520`. |

### Child Elements

None.

### Configuration Sample

The following configuration example shows an FTP with custom logging options that specify that infrastructure commands will not be logged, log files will be rotated on a daily basis, and the additional debugging option has been added to the default fields.

[!code-xml[Main](logFile/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples illustrate enabling logging for an FTP site, configuring the log file directory for an FTP site for a specific path, and specifying daily log file recycling.

### AppCmd.exe

[!code-console[Main](logFile/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](logFile/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](logFile/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](logFile/samples/sample5.js)]

### VBScript

[!code-vb[Main](logFile/samples/sample6.vb)]