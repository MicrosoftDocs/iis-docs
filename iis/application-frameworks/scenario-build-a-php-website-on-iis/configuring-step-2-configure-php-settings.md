---
title: "Configuring Step 2: Configure PHP Settings | Microsoft Docs"
author: rmcmurray
description: "In this step of building a PHP website on IIS, you configure the WinCache PHP extension, configure PHP settings, and download and configure any other PHP ext..."
ms.author: iiscontent
manager: soshir
ms.date: 04/14/2013
ms.topic: article
ms.assetid: 599f2304-e4d7-4185-a972-15c5eabf915b
ms.technology: iis-appfx
ms.prod: iis
msc.legacyurl: /learn/application-frameworks/scenario-build-a-php-website-on-iis/configuring-step-2-configure-php-settings
msc.type: authoredcontent
---
Configuring Step 2: Configure PHP Settings
====================
by [Keith Newman and Robert McMurray](https://github.com/rmcmurray)

In this step of building a PHP website on IIS, you configure the WinCache PHP extension, configure PHP settings, and download and configure any other PHP extensions that your application requires.

When you complete these tasks, continue to [Step 3: Configure PHP Application Security](configuring-step-3-configure-php-application-security.md).

<a id="21"></a>
## 2.1. Configure WinCache

Before you perform this procedure, you should download in install PHP and WinCache as described in [1.2 Download and Install PHP](configuring-step-1-install-iis-and-php.md#12). For more information about WinCache, see [2.1. Plan WinCache Configuration](planning-step-2-plan-php-settings.md#21).

### To configure the WinCache PHP extension

1. In Windows Explorer, open your PHP installation folder, for example `C:\PHP`.
2. Choose either the **php.ini - development** or **php.ini - production** file, and rename it **php.ini**.
3. In a text editor, open the php.ini file and added the following line at the end of the file: `extension = php_wincache.dll`.
4. Save and close the php.ini file.
5. Recycle the IIS Application Pools for PHP to pick up the configuration changes.

### To view WinCache configuration and other PHP settings

1. Open a text editor.
2. In a new file, type the following text: `<?php phpinfo(); ?>`
3. Save the file as `c:\inetpub\wwwroot\phpinfo.php`.
4. Open a browser and enter the following URL:

    `http://localhost/phpinfo.php`

    A nicely formatted web page is displayed showing the current PHP settings. The WinCache settings appear in a section called **wincache**.

**Warning**: Delete the phpinfo.php file when it's no longer needed.

<a id="22"></a>
## 2.2. Configure Other PHP Settings

The following procedure explains how to configure PHP settings in the php.ini file. For more information about PHP settings, see [2.2. Plan other PHP settings](planning-step-2-plan-php-settings.md#22).

### To configure a PHP setting

1. In Windows Explorer, open your PHP installation folder, for example `C:\PHP`.
2. In a text editor, open the php.ini file.
3. Search the file for the setting you want to change. 

    If the setting is commented out (line begins with a semicolon [;]), delete the semicolon and set the value. If you can't find the setting, add the line to the end of the file.
4. Save and close the php.ini file.
5. Recycle the IIS Application Pools for PHP to pick up the configuration changes.

<a id="23"></a>
## 2.3. Configure PHP Extensions

The following procedure shows how to download and install a PHP extension. For information about PHP extensions, see [2.3 Plan PHP Extensions](planning-step-2-plan-php-settings.md#23).

### To configure a PHP extension

1. Download the PHP extension you want from the [list of Windows extensions for PHP](http://downloads.php.net/pierre/).
2. Extract the extension zip package to the PHP extensions folder (\ext), for example `C:\PHP\ext`.
3. In Windows Explorer, open your PHP installation folder, for example `C:\PHP`.
4. In a text editor, open the php.ini file.
5. Search the file for the extension you want to configure. If the extension is commented out (line begins with a semicolon [;]), delete the semicolon. If you can't find the extension, add it to the end of the file. A line that adds an extension is in the form: `extension = extension_name.dll`. For example: `extension = php_soap.dll`.
6. Save and close the php.ini file.
7. Recycle the IIS Application Pools for PHP to pick up the configuration changes.

## See Also

- [Configure a PHP Website on IIS](configure-a-php-website-on-iis.md)
- [Step 2: Plan PHP Settings](planning-step-2-plan-php-settings.md)
- [Step 1: Install IIS and PHP](configuring-step-1-install-iis-and-php.md)
- [Step 3: Configure PHP Application Security](configuring-step-3-configure-php-application-security.md)
- [Hosting-Friendly Web Server Platform (IIS): Scenario Overview](../../get-started/introduction-to-iis/hosting-friendly-web-server-platform-iis-scenario-overview.md)