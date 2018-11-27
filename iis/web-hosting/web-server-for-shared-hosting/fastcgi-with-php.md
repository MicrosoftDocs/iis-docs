---
title: "FastCGI with PHP | Microsoft Docs"
author: ruslany
description: "Overview The FastCGI support in IIS enables popular application frameworks that support FastCGI protocol to be hosted on the IIS web server in a high-perform..."
ms.author: iiscontent
manager: soshir
ms.date: 12/01/2007
ms.topic: article
ms.assetid: b9580403-5f10-4397-a8d0-daa76abd8379
ms.technology: iis-hosting
ms.prod: iis
msc.legacyurl: /learn/web-hosting/web-server-for-shared-hosting/fastcgi-with-php
msc.type: authoredcontent
---
FastCGI with PHP
====================
by [Ruslan Yakushev](https://github.com/ruslany)

## Overview

The FastCGI support in IIS enables popular application frameworks that support FastCGI protocol to be hosted on the IIS web server in a high-performance and reliable way. FastCGI provides a high-performance alternative to the Common Gateway Interface (CGI), a standard way of interfacing external applications with Web servers that has been supported as part of the IIS feature-set since the very first release.

CGI programs are executables launched by the web server for each request in order to process the request and generate dynamic responses that are sent back to the client. Because many of these frameworks do not support multi-threaded execution, CGI enables them to execute reliably on IIS by executing exactly one request per process. Unfortunately, it provides poor performance due to the high cost of starting and shutting down a process for each request.

FastCGI addresses the performance issues inherent to CGI by providing a mechanism to reuse a single process over and over again for many requests. Additionally, FastCGI maintains compatibility with non-thread-safe libraries by providing a pool of reusable processes and ensuring that each process will only handle one request at a time.

<a id="Enabling"></a>

## Enabling FastCGI Support in IIS 7.0

**To enable FastCGI on IIS 7.0**

- Add CGI role service by going to Server Manager -&gt; Roles -&gt; Add Role Services. This enables both CGI and FastCGI services.

[![](fastcgi-with-php/_static/image5.png)](fastcgi-with-php/_static/image3.png)

### 

<a id="Install"></a>

## Install and Configure PHP

It is recommended to use a non-thread safe build of PHP with IIS 7.0 FastCGI. Non-thread safe build of PHP provides significant performance gains over the standard build by not doing any thread-safety checks, which are not necessary, since FastCGI ensures a single threaded execution environment.

> [!NOTE]
> There is no installer package for non-thread safe build of PHP.

1. Download the latest non-thread safe binaries of PHP from [http://www.php.net/downloads.php](http://www.php.net/downloads.php).

2. Unpack the files to a directory of your choice (e.g. `C:\PHP`). Rename the php.ini-recommended to php.ini.

3. Open php.ini file, then uncomment and modify settings as follows:

> a. Set fastcgi.impersonate = 1. FastCGI under IIS supports the ability to impersonate security tokens of the calling client. This allows IIS to define the security context that the request runs under.


> b. Set cgi.fix\_pathinfo=1. cgi.fix\_pathinfo provides \*real\* PATH\_INFO/PATH\_TRANSLATED support for CGI. PHP's previous behavior was to set PATH\_TRANSLATED to SCRIPT\_FILENAME, and to not care what PATH\_INFO is. For more information on PATH\_INFO, see the cgi specs. Setting this to 1 will cause PHP CGI to fix it's paths to conform to the spec


> c. Set cgi.force\_redirect = 0.


> d. Set open\_basedir to point to a folder or network path where the content of the web site(s) is located.


4. To test if the PHP installation is successful, run the following from the command line prompt:


[!code-console[Main](fastcgi-with-php/samples/sample1.cmd)]


If PHP was installed correctly and all its dependencies are available on the machine, then this command will output the current PHP configuration information.

<a id="Configure"></a>

## Configure IIS 7.0 to Handle PHP Requests

In order for IIS 7.0 to host PHP applications, it is necessary to add a handler mapping that tells IIS to pass all requests for PHP files to PHP application framework via FastCGI protocol.

**To add a handler mapping at a server level**

1. Open IIS Manager and then select and open "Handler Mappings" at the server level:

[![](fastcgi-with-php/_static/image8.png)](fastcgi-with-php/_static/image7.png)

2. Select "Add Module Mapping" action and specify the configurations settings as below:  
  
[![](fastcgi-with-php/_static/image10.png)](fastcgi-with-php/_static/image9.png)

1. - Request path: **\*.php**
    - Module: **FastCgiModule**
    - Executable: `C:\[Path to your PHP installation]\php-cgi.exe`
    - Name: **PHP via FastCGI**

3. Click OK. The dialog box appears asking if you want to create a FastCGI application for this executable. Click Yes.

4. Test that the handler mapping works correctly by creating a phpinfo.php file in the `C:\inetpub\wwwroot` folder that contains the following:  
&lt;?php phpinfo(); ?&gt;.

5. Open a browser and navigate to [http://localhost/phpinfo.php](http://localhost/phpinfo.php). If everything was setup correctly, then you see the standard PHP information page.

Alternatively, the above mentioned steps can be completed by using command line tool appcmd.

1. To create the FastCGI application process pool, run the following command:


[!code-console[Main](fastcgi-with-php/samples/sample2.cmd)]


2. After that, create the handler mapping:


[!code-console[Main](fastcgi-with-php/samples/sample3.cmd)]


> [!NOTE]
> If you are using a PHP version 4.X, instead of php-cgi.exe, you can use php.exe.

<a id="Best"></a>

## Best Practices for Configuring FastCGI and PHP

### Security Isolation for PHP Web Sites

The recommendation for isolating PHP web sites in a shared hosting environment is consistent with all general security isolation recommendations for IIS 7.0. In particular, it is recommended to:

- Use one application pool per web site
- Use user account as an identity for application pool
- Configure anonymous user identity to use the application pool identity
- Ensure that FastCGI impersonation is enabled in php.ini file (fastcgi.impersonate=1)

For more details about security isolation in shared hosting environment, refer to [Isolating Sites with Application Pools](../../manage/creating-websites/provisioning-iis-7-sites-for-shared-hosting.md#Isolating "Isolating Sites with Application Pools").

### PHP Process Recycling Behavior

Make sure that FastCGI always recycles php-cgi.exe processes before the native PHP recycling kicks in. The FastCGI process recycling behavior is controlled by the configuration property instanceMaxRequests. This property specifies how many requests FastCGI process will process before recycling. PHP also has a similar process recycling functionality that is controlled by an environment variable PHP\_FCGI\_MAX\_REQUESTS. By setting instanceMaxRequests to be smaller or equal to PHP\_FCGI\_MAX\_REQUESTS, you can ensure that native PHP process recycling logic will never kick in.

To set these configuration properties use the following commands:

[!code-console[Main](fastcgi-with-php/samples/sample4.cmd)]
   

[!code-console[Main](fastcgi-with-php/samples/sample5.cmd)]

> [!NOTE]
> If those parameters have not been set, then the following default settings are used: instanceMaxRequests = 200, PHP\_FCGI\_MAX\_REQUESTS = 500 (on most PHP builds).

### PHP Versioning

Many PHP applications may rely on functions or features available only in certain versions of PHP.

It is a common requirement in a shared hosting environment to support multiple versions of PHP on the same server. IIS 7.0 FastCGI handler fully supports running multiple versions of PHP on the same web server. For example, let's assume that on your web server you plan to support PHP 4.4.8, PHP 5.2.1 and PHP 5.2.5 non-thread safe. To enable that, you must place corresponding PHP binaries in separate folders on files system (e.g. `C:\php448\`, `C:\php521\` and `C:\php525nts`) and then create the FastCGI application process pools for each version:


[!code-console[Main](fastcgi-with-php/samples/sample6.cmd)]


Now, if you have 3 web sites (site1, site2, site3), where each site needs to use a different PHP version, you can define handler mappings on each of those sites to reference a corresponding FastCGI application process pool.

> [!NOTE]
> Each FastCGI process pool is uniquely identified by a combination of fullPath and arguments properties.

[!code-console[Main](fastcgi-with-php/samples/sample7.cmd)]

### PHP Security Recommendations

The following recommendations describe how to tighten security of PHP in shared hosting environment. To make the recommended changes locate and open php.ini file and edit it as described below:

1. Disable remote URL's for file handling functions:

    - Set allow\_url\_fopen=Off
    - Set allow\_url\_include=Off
2. Disable register\_globals:

    - register\_globals=Off
3. Restrict where PHP can read and write on a file system, e.g.:

    - open\_basedir="c:\inetpub\"
4. Disable safe mode:

    - safe\_mode=Off
    - safe\_mode\_gid=Off
5. Limit script execution time:

    - max\_execution\_time=30
    - max\_input\_time=60
6. Limit memory usage and file sizes:

    - memory\_limit=16M
    - upload\_max\_filesize=2M
    - post\_max\_size=8M
    - max\_input\_nesting\_levels=64
7. Configure error messages and logging:

    - display\_errors=Off
    - log\_errors=On
    - error\_log="C:\path\of\your\choice"
8. Hide presence of PHP:

    - expose\_php=Off

<a id="Per-site"></a>

## Enabling per-site PHP configuration

Very often it may be necessary to allow customers to override the PHP configuration values specified in php.ini. For example, if customer installs a popular PHP application then this application may require certain PHP settings to be modified in order to function correctly. The section describes the recommended way of enabling per-site PHP configuration . Note that this recommendation was discovered and validated by Radney Jasmin with hosting provider [GoDaddy.com](http://www.godaddy.com/) who now offers PHP hosting on Windows Server 2008 via FastCGI.

### Per-site PHP process pools

When each web site has its own application pool (which is a recommended practice for shared hosting on IIS 7.0), it is possible to associate a dedicated FastCGI process pool with each web site. A FastCGI process pool is uniquely identified by the combination of **fullPath** and **arguments** attributes. So, if it is necessary to create several FastCGI process pools for the same process executable, such as php-cgi.exe, the **arguments** attribute can be used to make process pools unique. In addition, with php-cgi.exe processes the command line switch "-d" can be used to define an INI entry for PHP process. This switch can be used to set some fake PHP setting that makes the arguments string unique.

For example, if there are two web sites "website1" and "website2" that need to have their own set of PHP settings, the FastCGI process pools can be defined as follows:


[!code-xml[Main](fastcgi-with-php/samples/sample8.xml)]


Then website1 can have the PHP handler mapping as follows:


[!code-xml[Main](fastcgi-with-php/samples/sample9.xml)]


and website2 can have the PHP handler mapping as follows:


[!code-xml[Main](fastcgi-with-php/samples/sample10.xml)]


### Specifying php.ini location

When PHP process starts it determines the location of configuration php.ini file by using various settings. [The PHP documentation](http://www.php.net/manual/en/configuration.php) provides detailed description of the PHP start up process. Note that one of the places where PHP process searches for php.ini location is the PHPRC environment variable. If PHP process finds a php.ini file in the path specified in this environment variable then it will use it, otherwise it will revert to default location of php.ini. This environment variable can be used to allow hosting customers to use their own versions of php.ini files.

For example if there are two websites: website1 and website2; located at the following file paths: `C:\WebSites\website1` and `C:\WebSites\website2` then the php-cgi.exe process pools in `<fastCgi>` section of applicationHost.config can be configured as below:


[!code-xml[Main](fastcgi-with-php/samples/sample11.xml)]


This way owner of website1 can place their own version of php.ini into the `C:\WebSites\website1`, while the owner of website2 can use their own version of php.ini located in `C:\WebSites\website2`. This configuration also ensures that if there is no php.ini found in location specified by PHPRC environment variable then PHP will fall back to using the default php.ini file located in the same folder where php-cgi.exe is located.

<a id="Rewrite"></a>

## Providing URL rewriting functionality for PHP applicaitons

Majority of popular PHP applications rely on the URL rewriting functionality in web servers to enable user friendly and search engine friendly URL's. IIS7 will provide URL rewriting capabilities via [URL rewrite module](../../extensions/url-rewrite-module/using-the-url-rewrite-module.md "URL rewrite module"), which is currently available as a [technical preview](https://www.iis.net/downloads/microsoft/url-rewrite "URL Rewrite TP"), There is no URL rewriting support provided for IIS versions earlier than 7.0 so the most commonly used options today for enabling URL rewriting on IIS 5.0, IIS 5.1 and IIS 6.0 are the following products:

- [ISAPI\_Rewrite](https://www.iis.net/downloads?tabid=34&g=6&i=1599 "ISAPI_Rewrite download") developed by [Helicon Tech](http://www.helicontech.com/ "Helicon Tech"). ISAPI\_Rewrite is a flexible, rule-base URL manipulation mechanism for IIS that closely matches the functionality and feature set of Apache mod\_rewrite. In fact, the latest version of ISAPI\_Rewrite is fully compatible with Apache mod\_rewrite syntax, which means that rewrite rules in .htaccess files, which are included with or generated by PHP applications, will work with ISAPI\_Rewrite without any modifications.
- [Ionics Isapi Rewrite Filter](https://archive.codeplex.com/?p=IIRF "IIRF") (IIRF), is an open source URL rewriting ISAPI filter that is easy to use and has a set of good features. It works on IIS 5.0, 5.1, 6.0, and 7.0. You can download the binaries as well as source code for the IIRF from the [codeplex](https://archive.codeplex.com/?p=IIRF "archived Codeplex project").