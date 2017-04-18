---
title: "Planning Step 3: Plan PHP Application Security | Microsoft Docs"
author: rmcmurray
description: "In this phase of Building a PHP website on IIS, consider what PHP configuration settings, web server settings, and PHP application settings you need to stren..."
ms.author: iiscontent
manager: soshir
ms.date: 04/14/2013
ms.topic: article
ms.assetid: 9a259178-7fde-4bda-bd7a-17caf6a0df80
ms.technology: iis-appfx
ms.prod: iis
msc.legacyurl: /learn/application-frameworks/scenario-build-a-php-website-on-iis/planning-step-3-plan-php-application-security
msc.type: authoredcontent
---
Planning Step 3: Plan PHP Application Security
====================
by [Keith Newman and Robert McMurray](https://github.com/rmcmurray)

In this phase of Building a PHP website on IIS, consider what PHP configuration settings, web server settings, and PHP application settings you need to strengthen security.

- [3.1. PHP Configuration Settings for Security](#31)
- [3.2. Web Server and PHP Application Security](#32)

When you are done with these tasks, record your design decisions before going on to [Step 1: Install IIS and PHP](configuring-step-1-install-iis-and-php.md).

<a id="31"></a>
## 3.1. PHP Configuration Settings for Security

The dynamic capabilities of PHP also make it a potential security risk because data is actively fetched, received, and processed from anywhere on the Internet. Attackers may attempt to send in malicious data and scripts and trick your server into fetching malicious scripts and running them. Attackers may also attempt to read and write files on your server to take control of the web site and use it for their own purposes.

You can configure PHP settings to tighten the security of a PHP installation and help protect the website from malicious attacks. The Php.ini file specifies the configuration settings PHP uses when it is running on your website. The Php.ini file determines what PHP scripts are allowed to do and prohibited from doing.

This section describes the configuration settings that help to protect your PHP applications.

### Disable File Handling for Remote URLs

`allow_url_fopen = Off`   
`allow_url_include = Off`

This setting is very important because it prevents URLs from being used in statements such as include(). Setting **allow\_url\_fopen** to &quot;Off&quot; means that only files that reside within your website can be included. You can't include a file from a different server, but neither can other people through Remote File Inclusion (RFI) attacks. In an RFI attack, someone embeds a URL in an HTTP request hoping that your script is tricked into running theirs. A command such as `include("http://website.com/page.php")`, for example, is not allowed to execute.

Include a file from your own site by specifying its path and filename. For example, if you have a URL **include** line, convert it to: `include($_SERVER['DOCUMENT_ROOT'] . '/page.php');`

The code segment `$_SERVER['DOCUMENT_ROOT']` is a superglobal variable set to the root folder of your site. (Note that there is no trailing &quot;/&quot;; you must provide a leading &quot;/&quot; in '/page.php'.)

If you want to include static content from another one of your websites, such as `include('http://myothersite.com/includes/footer.php')`, make a copy of that content in the current site and then include it locally.

### Disable Register\_Globals

`register_globals = Off`

This setting makes it difficult for an attacker to inject code into your script. For example, in `URL http://site.com/index.php?variable=value`, the variable passes into your script with its value set to **value** when **register\_globals** is **On**. When **register\_globals** is **Off**, however, variables do not automatically pass into your script's variable list.

### Restrict File System Read/Write

`open_basedir = "c:\inetpub\"`

This setting restricts PHP scripts from accessing files outside the specified base directory.

### Disable Safe Mode

`safe_mode = Off`   
`safe_mode_gid = Off`

This setting restricts the permissions with which PHP scripts run. Some third-party scripts do not run properly when safe\_mode is set to &quot;On.&quot; Note that beginning with PHP 6 safe\_mode does not exist.

### Limit Script Execution Time

`max_execution_time = 30`   
`max_input_time = 60`

These settings control the number of seconds a script is allowed to run and parse user input. These settings help prevent poorly written scripts from typing up the server.

### Limit Memory Usage and File Size

`memory_limit = 16M`   
`upload_max_filesize = 2M`   
`post_max_size = 8M`   
`max_input_nesting_levels = 64`

These settings help manage memory and input/output efficiently. In addition, they prevent poorly written scripts from hogging memory and handling huge files.

### Configure Error Logging

`display_errors = Off`   
`display_startup_errors = Off` `log_errors = On`   
`error_log = "C:\path\of\your\choice"`

These settings specify that all errors and warnings get logged to your error log text file and specify that none of the errors or warnings get displayed on any web page that is sent out from your server. Errors should not be displayed publicly because they can help someone figure out how to attack your server. Always check your error log when you are testing new code.

### Enable FastCGI Impersonation

`fastcgi.impersonate = 1`

This setting enables IIS to impersonate the security tokens of calling client and define the security context that is used to run the request.

### Disable FastCGI Logging

`fastcgi.logging = 0`

The FastCGI module will fail the request when PHP sends any data on **stderr** by using FastCGI protocol. Disabling FastCGI logging will prevent PHP from sending error information over **stderr**, and generating 500 response codes for the client.

### Hide PHP Presence

`expose_php = Off`

With this setting, the headers that accompany outgoing pages do not reveal that PHP is running or its version.

<a id="32"></a>
## 3.2. Web Server and PHP Application Security

### Isolate Web Applications

One of the most effective ways to improve security for your web application is to isolate it from other applications on your web server. An application pool has its own worker process, which processes requests and runs application code. The worker process has a security identifier (SID). And each application pool has a unique application-pool identity. By default, when you create a web application, a new application pool is also created with the same name as the application. If you keep web applications in separate application pools, you can isolate them from one another.

Web application isolation entails the following:

- Site isolation: Separate different applications into different sites with different application pools.
- Least privilege: Run your worker process as a low privileged identity (virtual application pool identity) that is unique per site.
- Temp isolation: Set up a separate PHP temp folder per site and only give access to appropriate process identity.
- Content isolation: Make sure to set an ACL (access control list) on each site root to allow only access to the appropriate process identity

**Tip**: It is a good idea to host your website and web application content on a drive other than your system drive (C:).

### Enable Per-site PHP Configuration

The FastCGI handler makes it possible to use a different Php.ini file for every application mapping. You can customize your PHP configuration around the specific requirements of your users or your PHP applications, letting you tighten configuration.

### Use Request Filtering

The request filtering module inspects known malicious patterns in the requests and prevents such requests from being serviced if the module determines that the requests may be harmful. For example, this module lets you filter requests that are double escaped, filter requests that use certain HTTP verbs, or block requests to specific folders. You can enforce tighter security policies on your web servers with the request filtering module. For more information about request filtering, see [Configure Request Filtering in IIS](../../manage/configuring-security/configure-request-filtering-in-iis.md).

## See Also

- [Plan a PHP Website on IIS](plan-a-php-website-on-iis.md)
- [Step 1: Install IIS and PHP](configuring-step-1-install-iis-and-php.md)
- [Step 1: Plan IIS Web Server and PHP Installation](planning-step-1-plan-iis-web-server-and-php-installation.md)
- [Step 2: Plan PHP Settings](planning-step-2-plan-php-settings.md)
- [Hosting-Friendly Web Server Platform (IIS): Scenario Overview](../../get-started/introduction-to-iis/hosting-friendly-web-server-platform-iis-scenario-overview.md)