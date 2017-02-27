---
title: "Using FastCGI to Host PHP Applications on IIS 7 | Microsoft Docs"
author: rick-anderson
description: "This article describes how to configure the FastCGI module and PHP to host PHP applications on IIS 7 and above. IMPORTANT : This article provides instruction..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 12/05/2007
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-applications-on-iis/using-fastcgi-to-host-php-applications-on-iis
msc.type: authoredcontent
---
Using FastCGI to Host PHP Applications on IIS 7
====================
by Ruslan Yakushev

This article describes how to configure the FastCGI module and PHP to host PHP applications on IIS 7 and above.

![](using-fastcgi-to-host-php-applications-on-iis/_static/image1.gif)**IMPORTANT**: This article provides instructions on how to install and use the FastCGI component on Windows Server 2008 and Windows Vista **SP1**. SP1 is **required** on Windows Vista.

<a id="Overview"></a>

## Overview

The FastCGI module in IIS enables popular application frameworks that support the FastCGI protocol to be hosted on the IIS Web server in a high performance and reliable way. FastCGI provides a high-performance alternative to the Common Gateway Interface (CGI), which is a standard way of interfacing external applications with Web servers that has been a part of the supported IIS feature set since the first release.

CGI programs are executable files that are launched by the Web server for each request to process the request and generate dynamic responses that are then sent back to the client. Because many of these frameworks do not support multi-threaded execution, CGI enables them to execute reliably on IIS by executing exactly one request per process. Unfortunately, it provides poor performance due to the high cost of starting and shutting down a process for each request.

FastCGI addresses the performance issues that are inherent in CGI by providing a mechanism to reuse a single process over and over again for many requests. Additionally, FastCGI maintains compatibility with non-thread-safe libraries by providing a pool of reusable processes and ensuring that each process handles only one request at a time.

<a id="EnableFastCGI"></a>

## Enable FastCGI Support in IIS

<a id="Windows_Server_2008:_"></a>

### Windows Server 2008

Go to **Server Manager** -&gt; **Roles** -&gt; **Add Role Services**. On the **Select Role Services** page, select the **CGI** check box. This enables both the CGI and FastCGI services.

[![](using-fastcgi-to-host-php-applications-on-iis/_static/image2.png)](using-fastcgi-to-host-php-applications-on-iis/_static/image1.png)

<a id="Windows_Vista_SP1"></a>

### Windows Vista SP1

Go to **Control Panel** -&gt; **Programs and Features** -&gt; **Turn Windows features on or off**. In the **Windows Features** dialog box, select the **CGI** check box. This enables both the CGI and FastCGI services.

[![](using-fastcgi-to-host-php-applications-on-iis/_static/image5.png)](using-fastcgi-to-host-php-applications-on-iis/_static/image3.png)

<a id="Update_for_FastCGI_module"></a>

### ![](using-fastcgi-to-host-php-applications-on-iis/_static/image2.gif)IMPORTANT: Install the Update for the FastCGI Module

The update for the IIS FastCGI module fixes several known compatibility issues with popular PHP applications. Install the update from one of the following locations:

- [Update for Windows Server 2008](https://www.microsoft.com/downloads/info.aspx?na=22&amp;p=1&amp;SrcDisplayLang=en&amp;SrcCategoryId=&amp;SrcFamilyId=&amp;u=%2fdownloads%2fdetails.aspx%3fFamilyID%3dd0343911-1775-4aef-8c99-5f13862ac386%26DisplayLang%3den "Update for Windows Server 2008")
- [Update for Windows Server 2008 x64 Edition](https://www.microsoft.com/downloads/info.aspx?na=22&amp;p=3&amp;SrcDisplayLang=en&amp;SrcCategoryId=&amp;SrcFamilyId=&amp;u=%2fdownloads%2fdetails.aspx%3fFamilyID%3d70278393-3291-4aa1-870b-0e9b0907bddf%26DisplayLang%3den "Update for Windows Server 2008 x64 Edition")
- [Update for Windows Server 2008 for Itanium-based Systems](https://www.microsoft.com/downloads/info.aspx?na=22&amp;p=5&amp;SrcDisplayLang=en&amp;SrcCategoryId=&amp;SrcFamilyId=&amp;u=%2fdownloads%2fdetails.aspx%3fFamilyID%3d98e06637-0f00-45d5-83c5-ed1b41fd6a7b%26DisplayLang%3den "Update for Windows Server 2008 for Itanium-based Systems")
- [Update for Windows Vista SP1](https://www.microsoft.com/downloads/info.aspx?na=22&amp;p=2&amp;SrcDisplayLang=en&amp;SrcCategoryId=&amp;SrcFamilyId=&amp;u=%2fdownloads%2fdetails.aspx%3fFamilyID%3d19600729-8470-4956-a276-200450d814bd%26DisplayLang%3den "Update for Windows Vista")
- [Update for Windows Vista SP1 for x64 based Systems](https://www.microsoft.com/downloads/info.aspx?na=22&amp;p=4&amp;SrcDisplayLang=en&amp;SrcCategoryId=&amp;SrcFamilyId=&amp;u=%2fdownloads%2fdetails.aspx%3fFamilyID%3dc7066c3b-dcf7-4441-87bc-f7dcb51067d0%26DisplayLang%3den "Update for Windows Vista for x64 based Systems")

<a id="Install_Administration_Pack_for_IIS_7.0"></a>

### Install the Administration Pack for IIS

> [!NOTE]
> This step is optional.

Among other useful features, the Administration Pack for IIS has a convenient user interface for configuring FastCGI settings. The Administration Pack can be installed from the following locations:

- [Administration Pack for IIS 7 and Above - x86](https://www.iis.net/downloads?tabid=34&i=1682&g=6)
- [Administration Pack for IIS 7 and Above - x64](https://www.iis.net/downloads?tabid=34&i=1683&g=6)

<a id="InstallPHP"></a>

## Install and Configure PHP

It is recommended that you use a non-thread safe build of PHP with IIS FastCGI. A non-thread safe build of PHP provides significant performance gains over the standard build by not doing any thread-safety checks, which are not necessary, since FastCGI ensures a single threaded execution environment.

**To install PHP:** 

1. Download the latest non-thread safe zip package with binaries of PHP: [http://www.php.net/downloads.php](http://www.php.net/downloads.php).
2. Unpack the files to the directory of your choice (e.g. C:\PHP). Rename the php.ini-recommended file to php.ini.
3. Open the php.ini file. Uncomment and modify the settings as follows: 

    - Set **fastcgi.impersonate = 1**. FastCGI under IIS supports the ability to impersonate security tokens of the calling client. This allows IIS to define the security context that the request runs under.
    - Set **cgi.fix\_pathinfo=1**. cgi.fix\_pathinfo provides \*real\* PATH\_INFO/PATH\_TRANSLATED support for CGI. Previously, PHP behavior was to set PATH\_TRANSLATED to SCRIPT\_FILENAME, and to not define PATH\_INFO. For more information about PATH\_INFO, see the cgi specifications. Setting this value to 1 will cause PHP CGI to fix its paths to conform to the specifications.
    - Set **cgi.force\_redirect** = 0.
    - Set **open\_basedir** to point to the folder or network path where the content of the Web site(s) is located.
    - Set **extension\_dir** to point to the location where the PHP extensions are located. Typically, for PHP 5.2.X the value would be set as **extension\_dir = "./ext"**
    - Enable the required PHP extension by un-commenting the corresponding lines, for example:   
  
 extension=php\_mssql.dll  
 extension=php\_mysql.dll
4. Open a command prompt, and run the following command to verify that PHP installed successfully:

[!code-console[Main](using-fastcgi-to-host-php-applications-on-iis/samples/sample1.cmd)]

If PHP installed correctly and all its dependencies are available on the machine, this command will output the current PHP configuration information.

<a id="Configure_handler_mapping"></a>

## Configure IIS to Handle PHP Requests

For IIS to host PHP applications, you must add a handler mapping that tells IIS to pass all PHP-specific requests to the PHP application framework by using the FastCGI protocol.

<a id="Using_IIS_Manager_"></a>

### Configure IIS to handle PHP requests by using IIS Manager

1. Open IIS Manager. At the server level, double-click **Handler Mappings**.

[![](using-fastcgi-to-host-php-applications-on-iis/_static/image2.jpg)](using-fastcgi-to-host-php-applications-on-iis/_static/image1.jpg)

2. In the **Actions** pane, click **Add Module Mapping...**. In the **Add Module Mapping** dialog box, specify the configuration settings as follows:

- Request path: **\*.php**
- Module: **FastCgiModule**
- Executable: **"C:\[Path to your PHP installation]\php-cgi.exe"**
- Name: **PHP via FastCGI**

3. Click **OK**.

[![](using-fastcgi-to-host-php-applications-on-iis/_static/image7.png)](using-fastcgi-to-host-php-applications-on-iis/_static/image6.png)

4. In the **Add Module Mapping** confirmation dialog box that asks if you want to create a FastCGI application for this executable, click **Yes**.

[![](using-fastcgi-to-host-php-applications-on-iis/_static/image4.jpg)](using-fastcgi-to-host-php-applications-on-iis/_static/image3.jpg)

5. Test that the handler mapping works correctly by creating a phpinfo.php file in the C:\inetpub\wwwroot folder that contains the following code:


[!code-unknown[Main](using-fastcgi-to-host-php-applications-on-iis/samples/sample-127404-2.unknown)]


6. Open a browser and navigate to http://localhost/phpinfo.php. If everything was setup correctly, you will see the standard PHP information page.

[![](using-fastcgi-to-host-php-applications-on-iis/_static/image9.png)](using-fastcgi-to-host-php-applications-on-iis/_static/image8.png)

**NOTE**: If you do not see **FastCgiModule** in the **Modules:** list, the module is either not registered or not enabled. To check if the FastCGI module is registered, open the IIS configuration file that is located at %*windir*%\windows\system32\config\applicationHost.config and check that the following line is present in the &lt;globalModules&gt; section:


[!code-xml[Main](using-fastcgi-to-host-php-applications-on-iis/samples/sample3.xml)]


In the same file, also check that the FastCGI module is added to the &lt;modules&gt; section:


[!code-xml[Main](using-fastcgi-to-host-php-applications-on-iis/samples/sample4.xml)]

<a id="Using_command_line"></a>

### Configure IIS to handle PHP requests by using the command line

Alternatively, you can complete the steps above by using the command line tool A **ppCmd**.

1. Create the FastCGI application process pool by running the following command:


[!code-console[Main](using-fastcgi-to-host-php-applications-on-iis/samples/sample5.cmd)]


2. Create the handler mapping by running the following command:


[!code-console[Main](using-fastcgi-to-host-php-applications-on-iis/samples/sample6.cmd)]


> [!NOTE]
> If you are using PHP version 4.X, you can use php.exe instead of php-cgi.exe.

<a id="BestPractices"></a>

## Best Practices for Configuring FastCGI and PHP

This [download](https://download.microsoft.com/download/A/2/F/A2F199C0-672E-44E6-BF1D-878E233C3F08/hostingPHPonIIS7.zip "Hosting PHP") contains a summary presentation on Best Practices for hosting PHP in a shared hosting environment.

<a id="Security_Isolation"></a>

### Security Isolation for PHP Web Sites

The recommendation for isolating PHP Web sites in a shared hosting environment is consistent with all general security isolation recommendations for IIS. In particular, it is recommended to:

- Use one application pool per Web site
- Use a dedicated user account as an identity for the application pool
- Configure an anonymous user identity to use the application pool identity
- Ensure that FastCGI impersonation is enabled in the php.ini file (fastcgi.impersonate=1)

For more details about security isolation in a shared hosting environment, see [Ensure Security Isolation for Web Sites](../../manage/configuring-security/ensure-security-isolation-for-web-sites.md "Ensure Security Isolation for Web Sites").

<a id="PHP_Recycling_Behavior"></a>

### PHP Process Recycling Behavior

Ensure that FastCGI always recycles the php-cgi.exe processes before the native PHP recycling kicks in. The FastCGI process recycling behavior is controlled by the configuration property **instanceMaxRequests**. This property specifies how many requests the FastCGI process will process before recycling. PHP also has a similar process recycling functionality that is controlled by the environment variable **PHP\_FCGI\_MAX\_REQUESTS**. By setting **instanceMaxRequests** to be less than or equal to **PHP\_FCGI\_MAX\_REQUESTS**, you can ensure that the native PHP process recycling logic will never kick in.

The FastCGI settings can be configured either by using IIS Manager or by using the command line tool A **ppCmd**.

#### Configure FastCGI recycling settings by using IIS Manager

1. Ensure that the [Administration Pack for IIS](using-fastcgi-to-host-php-applications-on-iis.md#Install_Administration_Pack_for_IIS_7.0) is installed on your server. Open IIS Manager. On the server level, double-click **FastCGI Settings**.

[![](using-fastcgi-to-host-php-applications-on-iis/_static/image11.png)](using-fastcgi-to-host-php-applications-on-iis/_static/image10.png)

2. Select the FastCGI application that you want to configure. In the **Actions** pane, click **Edit...**.

[![](using-fastcgi-to-host-php-applications-on-iis/_static/image13.png)](using-fastcgi-to-host-php-applications-on-iis/_static/image12.png)

3. In the **Edit FastCGI Application** dialog box, set the **InstanceMaxRequests** to **10000**. Next to the **EnvironmentVariables** setting, click the Browse (**...**) button.

[![](using-fastcgi-to-host-php-applications-on-iis/_static/image15.png)](using-fastcgi-to-host-php-applications-on-iis/_static/image14.png)

4. In the **EnvironmentVariables Collection Editor** dialog box, add the **PHP\_FCGI\_MAX\_REQUESTS** environment variable and set its value to **10000**.

[![](using-fastcgi-to-host-php-applications-on-iis/_static/image17.png)](using-fastcgi-to-host-php-applications-on-iis/_static/image16.png)

> [!NOTE]
> If you do not configure these settings, the following default settings will be used: **instanceMaxRequests** = 200, **PHP\_FCGI\_MAX\_REQUESTS** = 500 (on most PHP builds).

#### Configure FastCGI recycling settings by using the command line

Configure the recycling behavior of FastCGI and PHP by using **AppCmd** by running the following commands:


[!code-console[Main](using-fastcgi-to-host-php-applications-on-iis/samples/sample7.cmd)]

<a id="PHP_Versioning"></a>

### PHP Versioning

Many PHP applications rely on functions or features that are available only in certain versions of PHP. If these types of applications are to be hosted on the same server, different PHP versions must be enabled and running side-by-side. The IIS FastCGI handler fully supports running multiple versions of PHP on the same Web server.

For example, assume that on your Web server you plan to support PHP 4.4.8, PHP 5.2.1, and PHP 5.2.5 non-thread safe. To enable that configuration, you must place corresponding PHP binaries in separate folders on the file system (e.g. C:\php448\, C:\php521\ and C:\php525nts) and then create FastCGI application process pools for each version:


[!code-console[Main](using-fastcgi-to-host-php-applications-on-iis/samples/sample8.cmd)]


If you have three Web sites (site1, site2, site3) and each site must use a different PHP version, you can now define handler mappings on each of those sites to reference a corresponding FastCGI application process pool.

> [!NOTE]
> Each FastCGI process pool is uniquely identified by a combination of fullPath and arguments properties.


[!code-console[Main](using-fastcgi-to-host-php-applications-on-iis/samples/sample9.cmd)]

<a id="PHP_Security_Recommendations_"></a>

### PHP Security Recommendations

The following settings can be used to tighten the security of a PHP installation. To make the recommended changes, locate and open the php.ini file and edit the configuration settings as described below:

| Setting | Description |
| --- | --- |
| allow\_url\_fopen=Off allow\_url\_include=Off | Disable remote URLs for file handling functions, which may cause code injection vulnerabilities. |
| register\_globals=Off | Disable register\_globals. |
| open\_basedir="c:\inetpub\" | Restrict where PHP processes can read and write on a file system. |
| safe\_mode=Off safe\_mode\_gid=Off | Disable safe mode. |
| max\_execution\_time=30 max\_input\_time=60 | Limit script execution time. |
| memory\_limit=16M upload\_max\_filesize=2M post\_max\_size=8M max\_input\_nesting\_levels=64 | Limit memory usage and file sizes. |
| display\_errors=Off log\_errors=On error\_log="C:\path\of\your\choice" | Configure error messages and logging. |
| fastcgi.logging=0 | The IIS FastCGI module will fail the request when PHP sends any data on stderr by using the FastCGI protocol. Disable FastCGI logging to prevent PHP from sending error information over stderr and generating 500 response codes for the client. |
| expose\_php=Off | Hide the presence of PHP. |

<a id="Per-site_PHP_configuration"></a>

## Enabling per-site PHP configuration

This section describes the recommended way of enabling per-site PHP configuration. This recommendation was discovered and validated by Radney Jasmin with hosting provider [GoDaddy.com](http://www.godaddy.com/) who now offers PHP hosting on Windows Server 2008 by using FastCGI.

### Per-site PHP Process Pools

When each Web site has its own application pool, which is a recommended practice on IIS, it is possible to associate a dedicated FastCGI process pool with each Web site. A FastCGI process pool is uniquely identified by the combination of **fullPath** and **arguments** attributes. If you need to create several FastCGI process pools for the same process executable, such as php-cgi.exe, you can use the **arguments** attribute to distinguish the process pool definitions. With php-cgi.exe processes, you can also use the command line switch "-d" to define an INI entry for a PHP process. You can use this switch to set a PHP setting that makes the arguments string unique.

For example, if there are two Web sites "website1" and "website2" that must have their own set of PHP settings, the FastCGI process pools can be defined as follows:


[!code-xml[Main](using-fastcgi-to-host-php-applications-on-iis/samples/sample10.xml)]


In this example the PHP setting **open\_basedir** is used to distinguish between the process pool definitions. The setting also enforces that the PHP executable for each process pool can perform file operations only within the root folder of the corresponding Web site.

Then website1 can have the PHP handler mapping as follows:


[!code-xml[Main](using-fastcgi-to-host-php-applications-on-iis/samples/sample11.xml)]


and website2 can have the PHP handler mapping as follows:


[!code-xml[Main](using-fastcgi-to-host-php-applications-on-iis/samples/sample12.xml)]


### Specifying php.ini location

When the PHP process starts, it determines the location of the configuration php.ini file by using various settings. [The PHP documentation](http://www.php.net/manual/en/configuration.php) provides a detailed description of the PHP startup process. One of the places where the PHP process searches for the php.ini location is the PHPRC environment variable. If the PHP process finds a php.ini file in the path that is specified in this environment variable, it will use it; otherwise, the PHP process will revert to using the default location of the php.ini file. This environment variable can be used to allow hosting customers to use their own versions of php.ini files.

For example if there are two Web sites "website1" and "website2" that are located at the following file paths: C:\WebSites\website1 and C:\WebSites\website2, you can configure the php-cgi.exe process pools in the &lt;fastCgi&gt; section of the applicationHost.config file as follows:


[!code-xml[Main](using-fastcgi-to-host-php-applications-on-iis/samples/sample13.xml)]


This way website1 can have its own version of the php.ini file that is located in the C:\WebSites\website1, while website2 can have its own version of the php.ini file that is located in C:\WebSites\website2. This configuration also ensures that if a php.ini file cannot be found in the location that is specified by the PHPRC environment variable, then PHP will use the default php.ini file that is located in the same folder where the php-cgi.exe is located.

<a id="Rewrite"></a>

## Provide URL Rewriting Functionality for PHP Applications

The majority of popular PHP applications rely on the URL rewriting functionality in Web servers to enable user-friendly and search engine-friendly URLs. IIS provide URL rewriting capabilities by using the [URL rewrite module](../../extensions/url-rewrite-module/using-the-url-rewrite-module.md "URL rewrite module").

For more information about how to use the URL Rewrite module, see the following articles:

- [Microsoft URL Rewrite Module Walkthroughs.](https://go.microsoft.com/fwlink/?linkid=120200&amp;clcid=0x409) Describes how to use the URL Rewrite module.
- [Microsoft URL Rewrite Module configuration reference.](https://go.microsoft.com/fwlink/?linkid=120201&amp;clcid=0x409) Explains the functionality of the module and provides descriptions of all the configuration options.
- Configuring popular PHP applications to work with the URL Rewrite module: 

    - [WordPress](install-wordpress-on-iis.md)
    - [MediaWiki](mediawiki-on-iis.md)
    - [b2Evolution](b2evolution-on-iis.md)
    - [Mambo](mambo-on-iis.md)
    - [Drupal](install-drupal-on-iis.md)

<a id="Related_resources_"></a>

## Related resources

For more information regarding hosting PHP applications on IIS refer to the following resources:

- Popular PHP applications on IIS
- [Configuring FastCGI extension for IIS 6.0](../install-and-configure-php-on-iis/configuring-the-fastcgi-extension-for-iis-60.md)
- [Using FastCGI extension to host PHP on IIS 6.0](using-fastcgi-to-host-php-applications-on-iis-60.md)
- [Installing FastCGI support on Windows Server 2008 Core](../install-and-configure-php-on-iis/install-php-and-fastcgi-support-on-server-core.md)
  
  
[Discuss in IIS Forums](https://forums.iis.net/1102.aspx)