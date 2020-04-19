---
title: "Planning Step 2: Plan PHP Settings"
author: rmcmurray
description: "In this phase of building your PHP website, plan to set up the WinCache PHP extension, determine what configuration settings you require for PHP, and what PH..."
ms.date: 04/14/2013
ms.assetid: 5baccb6d-183b-4b1b-839f-4db5a32acbd9
msc.legacyurl: /learn/application-frameworks/scenario-build-a-php-website-on-iis/planning-step-2-plan-php-settings
msc.type: authoredcontent
---
Planning Step 2: Plan PHP Settings
====================
by [Keith Newman and Robert McMurray](https://github.com/rmcmurray)

In this phase of building your PHP website, plan to set up the WinCache PHP extension, determine what configuration settings you require for PHP, and what PHP extensions your application requires.

When you are done with these tasks, record your design decisions before going on to [Step 3: Plan PHP Application Security](planning-step-3-plan-php-application-security.md).

<a id="21"></a>
## 2.1. Plan WinCache Configuration

WinCache is a PHP extension that accelerates PHP applications, which run on Windows and Windows Server. For the most installations, the WinCache extension must be added to the php.ini file and no other configuration is required. However, if you want more control, WinCache offers many configuration settings. You can see a full list of setting in the [WinCache Runtime Configuration](http://us2.php.net/manual/en/wincache.configuration.php) page.

<a id="22"></a>
## 2.2. Plan Other PHP Settings

Configuration and environmental settings for PHP are contained within the Php.ini, which is located in the PHP folder that you create during installation, for example `C:\PHP`. The following sections contain a number of settings for the Php.ini file that help PHP work better with Windows.

### Required Settings

- **extension\_dir = &lt;PATH TO EXTENSIONS&gt;**: The extension\_dir points to the directory where the PHP extensions are stored. The path can be fully qualified (for example, `C:\PHP\ext`) or relative (for example, .\ext). Extensions that are specified lower in the Php.ini file are located in the extension\_dir. If the extensions specified are not in the extension\_dir, then PHP displays a warning message at the start of script execution, and the application may show errors because of the missing functionality.
- **extension = xxxxxx.dll**: For each extension enabled, a corresponding extension= directive that tells PHP which extensions in the extension\_dir to load at startup time is necessary.
- **log\_errors = On**: PHP errors can also go through the PHP error logging facility. This can be used to send errors to a file or to a service (for example, syslog) and works with the error\_log directive described below. When running under IIS, log\_errors must be enabled with a valid error\_log. Otherwise, FastCGI considers any startup
- **error\_log = &lt;path\_to\_error\_log\_file&gt;**: The error\_log must specify the fully qualified, or relative, path to the file where the PHP error log is stored. This file must be writable for the IIS service. The most common places for this file are in various temporary directories (for example, `C:\inetpub\temp\php-errors.log`). That puts the log in a place that IIS can use and keeps the log close to where PHP applications are running.
- **cgi.force\_redirect = 0**: This directive is required for running under IIS. It is a directory security facility that is required by many other web servers. However, enabling it under IIS causes the PHP engine to fail on Windows.
- **cgi.fix\_pathinfo = 1**: This setting lets PHP access real path information per the CGI specification. The IIS FastCGI implementation needs this extension set.
- **fastcgi.impersonate = 1**: FastCGI under IIS supports the ability to impersonate security tokens of the calling client. This setting allows IIS to define the security context that the request runs under.
- **fastcgi.logging = 0**: FastCGI logging should be disabled when you use PHP with IIS. If it is left enabled, then any messages of any class are treated by FastCGI as error conditions, which causes IIS to generate an HTTP 500 exception.

### Optional Settings

- **max\_execution\_time = ##**: This directive sets the maximum amount of time that can be taken executing any given script. The default is 30 seconds. Some applications need more time to process batch operations (for example, Gallery2 loading multiple images from a remote location). However, setting the execution time higher than 300 seconds is not advised because there are often other parts of the connection that cannot support such a long execution time.
- **memory\_limit = ###M**: The amount of memory available for the PHP process (in MB). The default is 128 MB, which is sufficient for most PHP applications.
- **display\_errors = Off**: This directive determines whether to include any error messages in the stream that it returns to the web server. If turned on, PHP sends the classes of errors that are defined with the error\_reporting directive back to IIS as part of the error stream. Many of the open-source applications bypass error reporting by executing commands prefaced with @. This setting allows the applications to control error handling.
- **Mail functions**: PHP is configured by default to send outbound mail through an SMTP server that is located on the same system as the web server. Most Windows installations usually have the web and mail servers on separate systems.

<a id="23"></a>
## 2.3. Plan PHP Extensions

It is important to determine which extensions are required by the applications you intend to run, and then to limit the installed extensions to those extensions only. For example, a typical open-source PHP application might require the following types of extensions:

- **Database Extensions**: Open-source applications that use MySQL for a database engine use either the php\_mysql or the php\_mysqli extension. For new development work, either of these extensions work well. Consider using the PDO versions of the MySQL driver. PDO is a PHP extension that provides a data-access abstraction layer that can be used with various databases. Microsoft provides PHP drivers for SQL server that you can download. To learn more about PHP drivers for SQL Server, see [Microsoft Drivers for PHP for SQL Server](http://sqlsrvphp.codeplex.com/).
- **Image Handling Extensions**: Open-source applications that enable work with images use the GD2 extension - php\_gd2, which has several application programming interfaces (APIs) for basic image manipulation. Some applications use the [ImageMagick](http://www.imagemagick.org/script/index.php) application and libraries. There is also a php\_exif library for working with the extended information that modern digital cameras store within the images.
- **Internationalization and Localization Extensions**: The two most commonly used extensions for i18n and l10n are php\_mbstring (Multi-Byte String) and php\_gettext (Native Language Support). Many of the open-source applications use one or both of these extensions.
- **Web Services Extensions**: Choose the web services extensions based on the services desired. For PHP, the SOAP extension is widely used. The XML-RPC extension is often used with SOAP and other services.

To view the entire list of PHP extensions available for applications that run on Windows platforms, see the complete [list of Windows extensions for PHP](http://downloads.php.net/pierre/).

## See Also

- [Plan a PHP Website on IIS](plan-a-php-website-on-iis.md)
- [Step 2: Configure PHP Settings](configuring-step-2-configure-php-settings.md)
- [Step 1: Plan IIS Web Server and PHP Installation](planning-step-1-plan-iis-web-server-and-php-installation.md)
- [Step 3: Plan PHP Application Security](planning-step-3-plan-php-application-security.md)
- [Hosting-Friendly Web Server Platform (IIS): Scenario Overview](../../get-started/introduction-to-iis/hosting-friendly-web-server-platform-iis-scenario-overview.md)
