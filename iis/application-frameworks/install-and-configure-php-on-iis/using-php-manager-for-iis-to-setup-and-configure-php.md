---
title: "Using PHP Manager for IIS to setup and configure PHP"
author: ruslany
description: "From the Downloads page select the installation package that is appropriate for your target machine. Download and run the installer, which will install and r..."
ms.date: 6/1/2020
ms.assetid: 9e07564f-3c41-4d22-ba76-3daaf0847db9
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-on-iis/using-php-manager-for-iis-to-setup-and-configure-php
msc.type: authoredcontent
---

# Using PHP Manager for IIS to setup and configure PHP

by [Ruslan Yakushev](https://github.com/ruslany), [Lex Li](https://github.com/lextm)

PHP Manager is not a Microsoft-owned or supported product.
### Installation

From the [Downloads](https://github.com/phpmanager/phpmanager/releases) page select the installation package that is appropriate for your target machine. Download and run the installer, which will install and register PHP Manager's binaries with IIS. Note that only IIS versions 7.0 and above are supported. After installation is complete, launch the IIS Manager and find the "PHP Manager" feature:

![](http://www.phpmanager.xyz/latest/_images/phpmanager.png)

When opened, the "PHP Manager" feature provides a configuration overview for the PHP installation that is registered with IIS and is currently active. If no PHP is registered with IIS, then the only action that can be performed is the registation of a new PHP version.

### Registering PHP with IIS

To register a new PHP version with IIS, first you need to download the zip archive with PHP binaries from [http://windows.php.net/](http://windows.php.net/) and then extract the files from it into a folder of your choice. Note that you can also install PHP by using [Web Platform Installer](https://php.iis.net/) or the Windows installer from [http://windows.php.net/](http://windows.php.net/) - the PHP Manager can be used to manage those PHP installations as well.

Click on "**Register new PHP version**" task and then provide the full path to the location of the main php executable file: **php-cgi.exe**:

![](http://www.phpmanager.xyz/latest/_images/register.png)

After clicking OK the new PHP version will be registered with IIS and will become active. This means that all the sites on this IIS server by default will use this PHP version.

### Validating existing PHP installations and fixing configuration issues

In order for PHP to run properly on IIS there is a set of recommended settings that need to be configured in IIS and PHP. PHP Manager checks if all of the recommended settings are configured correctly. If some settings are not configured properly then you can use PHP Manager to fix those settings.

When some configuration settings are configured incorrectly you will see a warning message when you open PHP Manager:

![](http://www.phpmanager.xyz/latest/_images/warning.png)

After clicking on "View Recommendations" link you can see all the configuration issues that exist in your PHP installation. You can review each issue description and the recommended corrective action. You can also select which configuration issues you want to be fixed:

![](http://www.phpmanager.xyz/latest/_images/fixed.png)

### Switching between PHP versions

After multiple PHP versions have been registered with IIS, you can use PHP Manager to easily switch between the versions on a server and site level. This means that you can configure some IIS sites to use one PHP version, while other sites use different version.

![](http://www.phpmanager.xyz/latest/_images/switch.png)

### Checking phpinfo() output

phpinfo() function in PHP provides very detailed information about all aspects of PHP runtime configuration. To check the phpinfo() output from within PHP Manager use the "**Check phpinfo()**" task.

![](http://www.phpmanager.xyz/latest/_images/phpinfo.png)

### Configuring Error Reporting

You can use PHP Manager to configure error reporting level in PHP. If IIS is used on a development machine then you may want to use verbose error reporting in order to see all the errors, warnings and notices from your PHP application right away. If IIS is used as a production server, then error reporting level is less verbose and errors are logged in a log file, but never communicated to HTTP client.

![](http://www.phpmanager.xyz/latest/_images/error.png)

### Configuring Runtime Limits

Various timeouts and limits can be configured in the "**PHP Runtime Limits**" page:

![](http://www.phpmanager.xyz/latest/_images/limits.png)

### Configuring All PHP Settings

All existing PHP settings can be added, removed and modified in the "**PHP Settings**" page.

![](http://www.phpmanager.xyz/latest/_images/settings.png)

### Enabling or Disabling PHP Extensions

PHP extensions can be enabled or disabled in the "**PHP Extensions**" page:

![](http://www.phpmanager.xyz/latest/_images/extentions.png)
