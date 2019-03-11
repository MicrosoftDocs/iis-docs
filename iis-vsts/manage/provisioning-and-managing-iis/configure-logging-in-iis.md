---
title: "Configure Logging in IIS"
author: rmcmurray
description: "You can configure logging on your web server or website that records information about HTTP requests and errors. The information in your log can help you tro..."
ms.date: 04/14/2013
ms.assetid: e0838f0d-4ab5-41dc-805d-1cc441450c0f
msc.legacyurl: /learn/manage/provisioning-and-managing-iis/configure-logging-in-iis
msc.type: authoredcontent
---
Configure Logging in IIS
====================
by [Keith Newman and Robert McMurray](https://github.com/rmcmurray)

You can configure logging on your web server or website that records information about HTTP requests and errors. The information in your log can help you troubleshoot or optimize your website.

<a id="00"></a>
## Prerequisites

To get the most from this tutorial, you must have access to a computer that is running one of the following operating systems:

- Windows Server® 2012
- Windows® 8

<a id="01"></a>
## Configure Logging at the Site Level

You can perform this procedure by using the user interface (UI), or by editing configuration files directly.

### To configure logging at the site level by using the UI

1. Open IIS Manager. 

    - For Windows Server 2012, on the **Start** page click the **Server Manager** tile, and then click **OK**. In **Server Manager**, click the **Tools** menu, and then click **Internet Information Services (IIS) Manager**.
    - For Windows 8, on the **Start** page type **Control Panel**, and then click the **Control Panel** icon in the search results. On the **Control Panel** screen, click **System and Security**, click **Administrative Tools**, and then **click Internet Information Services (IIS) Manager**.
2. In the **Connections** tree view, select your website.
3. In **Features View**, double-click **Logging**.
4. On the **Logging** page, in the **Log file** section under **Format**, select one of the following log file formats:

    - **IIS**: to use the Microsoft IIS log file format to log information about a site. This format is handled by HTTP.sys, and is a *fixed* ASCII text-based format, which means that you cannot customize the fields that are logged. Fields are separated by commas, and time is recorded as local time. For more information about the IIS log file format, see [IIS Log File Format (IIS 6.0)](https://go.microsoft.com/fwlink/?LinkId=103792).
    - **NCSA**: to use the National Center for Supercomputing Applications (NCSA) Common log file format to log information about a site. This format is handled by HTTP.sys, and is a *fixed* ASCII text-based format, which means that you cannot customize the fields that are logged. Fields are separated by spaces, and time is recorded as local time with the Coordinated Universal Time (UTC) offset. For more information about the NCSA log file format, see [NCSA Common Log File Format (IIS 6.0)](https://go.microsoft.com/fwlink/?LinkId=103791).
    - **W3C**: to use the centralized W3C log file format to log information about all sites on the server. This format is handled by HTTP.sys, and is a *customizable* ASCII text-based format, which means that you specify the fields that are logged. Specify the fields that are logged on the **W3C Logging Fields** dialog box by clicking **Select Fields** on the **Logging** page. Fields are separated by spaces, and time is recorded in Coordinated Universal Time (UTC). For more information about the W3C log file format, see [W3C Extended Log File Format (IIS 6.0)](https://go.microsoft.com/fwlink/?LinkId=103790).
    - **Custom**: to use a custom format for a custom logging module. When you select this option, the **Logging** page becomes disabled, because custom logging cannot be configured in IIS Manager. For more information about how to use custom log file formats, see [Custom Logging Modules (IIS 6.0)](https://go.microsoft.com/fwlink/?LinkId=103789).
5. Under **Directory**, specify the path where the log file should be stored. The default is `%SystemDrive%\inetpub\logs\LogFiles`. > [!NOTE]
> As a best practice, store log files, such as failed request trace logs, in a directory other than `%systemroot%`.
6. In the **Log File Rollover** section, select one of the following options:

    - **Schedule**: to create new log file that is based on one of the following values:

        - **Hourly**: a new log file is created each hour.
        - **Daily**: a new log file is created each day.
        - **Weekly**: a new log file is created each week.
        - **Monthly**: a new log file is created each month.
    - **Maximum file size (in bytes)**: to create a log file when the file reaches a certain size (in bytes).The minimum file size is 1048576 bytes. If this attribute is set to a value less than 1048576 bytes, the default value is implicitly assumed as 1048576 bytes.
    - **Do not create a new log file**: there is a single log file that continues to grow as information is logged.
7. Select **Use local time for file naming and rollover** to specify that log file naming and time for log file rollover uses the local server time. When this option is not selected, Coordinated Universal Time (UTC) is used. > [!NOTE]
> Regardless of this setting, timestamps in the actual log file will use the time format for the log format that you select from the Format list. For example, NCSA and W3C log file formats use UTC time format for timestamps.
8. Click **Apply** in the **Actions** pane.

<a id="02"></a>
## Configure Per-site Logging at the Server Level

You can perform this procedure by using the user interface (UI), or by editing configuration files directly.

### To configure per-site logging at the server level by using the UI

1. In the **Connections** tree view of IIS Manager, select your web server.
2. In **Features View**, double-click **Logging**.
3. On the **Logging** page under **One log file per site**, select **Site** from the drop-down list. By default, **Site** is selected.
4. On the **Logging** page, in the **Log file** section under **Format**, select one of the following log file formats:

    - **IIS**: to use the Microsoft IIS log file format to log information about a site. This format is handled by HTTP.sys, and is a *fixed* ASCII text-based format, which means that you cannot customize the fields that are logged. Fields are separated by commas, and time is recorded as local time. For more information about the IIS log file format, see [IIS Log File Format (IIS 6.0)](https://go.microsoft.com/fwlink/?LinkId=103792).
    - **NCSA**: to use the National Center for Supercomputing Applications (NCSA) Common log file format to log information about a site. This format is handled by HTTP.sys, and is a *fixed* ASCII text-based format, which means that you cannot customize the fields that are logged. Fields are separated by spaces, and time is recorded as local time with the Coordinated Universal Time (UTC) offset. For more information about the NCSA log file format, see [NCSA Common Log File Format (IIS 6.0)](https://go.microsoft.com/fwlink/?LinkId=103791).
    - **W3C**: to use the centralized W3C log file format to log information about all sites on the server. This format is handled by HTTP.sys, and is a *customizable* ASCII text-based format, which means that you specify the fields that are logged. Specify the fields that are logged on the **W3C Logging Fields** dialog box by clicking **Select Fields** on the **Logging** page. Fields are separated by spaces, and time is recorded in Coordinated Universal Time (UTC). For more information about the W3C log file format, see [W3C Extended Log File Format (IIS 6.0)](https://go.microsoft.com/fwlink/?LinkId=103790).
    - **Custom**: to use a custom format for a custom logging module. When you select this option, the **Logging** page becomes disabled, because custom logging cannot be configured in IIS Manager. For more information about how to use custom log file formats, see [Custom Logging Modules (IIS 6.0)](https://go.microsoft.com/fwlink/?LinkId=103789).
5. Under **Directory**, specify the path where the log file should be stored. The default is `%SystemDrive%\inetpub\logs\LogFiles`. > [!NOTE]
> As a best practice, store log files, such as failed request trace logs, in a directory other than `%systemroot%`.
6. In the **Log File Rollover** section, select one of the following options:

    - **Schedule**: to create new log file that is based on one of the following values:

        - **Hourly**: a new log file is created each hour.
        - **Daily**: a new log file is created each day.
        - **Weekly**: a new log file is created each week.
        - **Monthly**: a new log file is created each month.
    - **Maximum file size (in bytes)**: to create a log file when the file reaches a certain size (in bytes).The minimum file size is 1048576 bytes. If this attribute is set to a value less than 1048576 bytes, the default value is implicitly assumed as 1048576 bytes.
    - **Do not create a new log file**: there is a single log file that continues to grow as information is logged.
7. Select **Use local time for file naming and rollover** to specify that log file naming and time for log file rollover uses the local server time. When this option is not selected, Coordinated Universal Time (UTC) is used. > [!NOTE]
> Regardless of this setting, timestamps in the actual log file will use the time format for the log format that you select from the Format list. For example, NCSA and W3C log file formats use UTC time format for timestamps.
8. Click **Apply** in the **Actions** pane.

<a id="03"></a>
## Configure Per-server Logging at the Server Level

You can perform this procedure by using the user interface (UI), or by editing configuration files directly.

### To configure per-server logging at the server level by using the UI

1. In the **Connections** tree view of IIS Manager, select your web server.
2. In **Features View**, double-click **Logging**.
3. On the **Logging** page, under **One log file per site**, select **Server** from the drop-down list. By default, **Site** is selected.
4. On the **Logging** page, in the **Log file** section under **Format**, select one of the following log file formats:

    - **IIS**: to use the Microsoft IIS log file format to log information about a site. This format is handled by HTTP.sys, and is a *fixed* ASCII text-based format, which means that you cannot customize the fields that are logged. Fields are separated by commas, and time is recorded as local time. For more information about the IIS log file format, see [IIS Log File Format (IIS 6.0)](https://go.microsoft.com/fwlink/?LinkId=103792).
    - **NCSA**: to use the National Center for Supercomputing Applications (NCSA) Common log file format to log information about a site. This format is handled by HTTP.sys, and is a *fixed* ASCII text-based format, which means that you cannot customize the fields that are logged. Fields are separated by spaces, and time is recorded as local time with the Coordinated Universal Time (UTC) offset. For more information about the NCSA log file format, see [NCSA Common Log File Format (IIS 6.0)](https://go.microsoft.com/fwlink/?LinkId=103791).
    - **W3C**: to use the centralized W3C log file format to log information about all sites on the server. This format is handled by HTTP.sys, and is a *customizable* ASCII text-based format, which means that you specify the fields that are logged. Specify the fields that are logged on the **W3C Logging Fields** dialog box by clicking **Select Fields** on the **Logging** page. Fields are separated by spaces, and time is recorded in Coordinated Universal Time (UTC). For more information about the W3C log file format, see [W3C Extended Log File Format (IIS 6.0)](https://go.microsoft.com/fwlink/?LinkId=103790).
    - **Custom**: to use a custom format for a custom logging module. When you select this option, the **Logging** page becomes disabled, because custom logging cannot be configured in IIS Manager. For more information about how to use custom log file formats, see [Custom Logging Modules (IIS 6.0)](https://go.microsoft.com/fwlink/?LinkId=103789).
5. Under **Directory**, specify the path where the log file should be stored. The default is `%SystemDrive%\inetpub\logs\LogFiles`. > [!NOTE]
> As a best practice, store log files, such as failed request trace logs, in a directory other than `%systemroot%`.
6. In the **Log File Rollover** section, select one of the following options:

    - **Schedule**: to create new log file that is based on one of the following values:

        - **Hourly**: a new log file is created each hour.
        - **Daily**: a new log file is created each day.
        - **Weekly**: a new log file is created each week.
        - **Monthly**: a new log file is created each month.
    - **Maximum file size (in bytes)**: to create a log file when the file reaches a certain size (in bytes).The minimum file size is 1048576 bytes. If this attribute is set to a value less than 1048576 bytes, the default value is implicitly assumed as 1048576 bytes.
    - **Do not create a new log file**: there is a single log file that continues to grow as information is logged.
7. Select **Use local time for file naming and rollover** to specify that log file naming and time for log file rollover uses the local server time. When this option is not selected, Coordinated Universal Time (UTC) is used. > [!NOTE]
> Regardless of this setting, timestamps in the actual log file will use the time format for the log format that you select from the Format list. For example, NCSA and W3C log file formats use UTC time format for timestamps.
8. Click **Apply** in the **Actions** pane.

<a id="04"></a>
## Select W3C Fields to Log

You can perform this procedure by using the user interface (UI), or by editing configuration files directly.

### To select W3C fields to log by using the UI

1. In **Features View** of IIS Manager, double-click **Logging**.
2. On the **Logging** page, in the **Log file** section under **Format**, click **Select Fields**.
3. In the **W3C Logging Fields** dialog box, select one or more of the following options:

    - **Date (date)**: the date on which the request occurred.
    - **Time (time)**: the time, in Coordinated Universal Time (UTC), at which the request occurred.
    - **Client IP Address (c-ip)**: the IP address of the client that made the request.
    - **User Name (cs-username)**: the name of the authenticated user who accessed your server. Anonymous users are indicated by a hyphen.
    - **Service Name (s-sitename)**: the site instance number that fulfilled the request.
    - **Server Name (s-computername)**: the name of the server on which the log file entry was generated.
    - **Server IP Address (s-ip)**: the IP address of the server on which the log file entry was generated.
    - **Server Port (s-port)**: the server port number that is configured for the service.
    - **Method (cs-method)**: the requested action, for example, a GET method.
    - **URI Stem (cs-uri-stem)**: the Universal Resource Identifier, or target, of the action.
    - **URI Query (cs-uri-query)**: the query, if any, that the client was trying to perform. A Universal Resource Identifier (URI) query is necessary only for dynamic pages.
    - **Protocol Status (sc-status)**: the HTTP or FTP status code.
    - **Protocol Sub-status (sc-substatus)**: the HTTP or FTP substatus code.
    - **Win32 Status (sc-win32-status)**: the Windows status code.
    - **Bytes Sent (sc-bytes)**: the number of bytes that the server sent.
    - **Bytes Received (cs-bytes)**: the number of bytes that the server received.
    - **Time Taken (time-taken)**: the length of time that the action took in milliseconds.
    - **Protocol Version (cs-version)**: the protocol version that the client used.
    - **Host (cs-host)**: the host name, if any.
    - **User Agent (cs(UserAgent))**: the browser type that the client used.
    - **Cookie (cs(Cookie))**: the content of the cookie sent or received, if any.
    - **Referer (cs(Referer))**: the site that the user last visited. This site provided a link to the current site.
4. Click **Apply** in the **Actions** pane.

<a id="05"></a>
## Configure Log File Rollover Options

You can perform this procedure by using the user interface (UI), or by editing configuration files directly.

### To configure log file rollover options by using the UI

1. In **Features View** of IIS Manager, double-click **Logging**.
2. On the **Logging** page, in the **Log File Rollover** section, select one of the following options:

    - **Schedule**: to create new log file that is based on one of the following values:

        - **Hourly**: a new log file is created each hour.
        - **Daily**: a new log file is created each day.
        - **Weekly**: a new log file is created each week.
        - **Monthly**: a new log file is created each month.
    - **Maximum file size (in bytes)**: to create a log file when the file reaches a certain size (in bytes).The minimum file size is 1048576 bytes. If this attribute is set to a value less than 1048576 bytes, the default value is implicitly assumed as 1048576 bytes.
    - **Do not create a new log file**: This option means that there is a single log file that continues to grow as information is logged. If you use a single log file for your site, it is helpful when you use log parsing utilities, but it also creates larger log files that could affect the overall performance of the server.
3. Select **Use local time for file naming and rollover** to specify that log file naming and time for log file rollover uses the local server time. When this option is not selected, Coordinated Universal Time (UTC) is used. > [!NOTE]
> Regardless of this setting, timestamps in the actual log file will use the time format for the log format that you select from the Format list. For example, NCSA and W3C log file formats use UTC time format for timestamps.
4. Click **Apply** in the **Actions** pane.

## See Also

- [Build an ASP.NET Website on IIS](../../application-frameworks/scenario-build-an-aspnet-website-on-iis/overview-build-an-asp-net-website-on-iis.md)
- [Build a Classic ASP Website on IIS](../../application-frameworks/running-classic-asp-applications-on-iis-7-and-iis-8/scenario-build-a-classic-asp-website-on-iis.md)
- [Build a Static Website on IIS](../creating-websites/scenario-build-a-static-website-on-iis.md)
- [Build a PHP Website on IIS](../../application-frameworks/scenario-build-a-php-website-on-iis/overview-build-a-php-website-on-iis.md)
- [Build an FTP Site on IIS](../../publish/using-the-ftp-service/scenario-build-an-ftp-site-on-iis.md)
- [Build a Web Farm with IIS Servers](../../web-hosting/scenario-build-a-web-farm-with-iis-servers/overview-build-a-web-farm-with-iis-servers.md)
- [Hosting-Friendly Web Server Platform (IIS): Scenario Overview](../../get-started/introduction-to-iis/hosting-friendly-web-server-platform-iis-scenario-overview.md)
