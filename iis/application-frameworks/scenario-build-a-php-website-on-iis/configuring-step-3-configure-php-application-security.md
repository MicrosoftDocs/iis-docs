---
title: "Configuring Step 3: Configure PHP Application Security | Microsoft Docs"
author: rmcmurray
description: "In this last step in building a PHP website on IIS, you configure PHP settings, web server settings, and PHP application settings that improve your website s..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 04/14/2013
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/application-frameworks/scenario-build-a-php-website-on-iis/configuring-step-3-configure-php-application-security
msc.type: authoredcontent
---
Configuring Step 3: Configure PHP Application Security
====================
by [Keith Newman and Robert McMurray](https://github.com/rmcmurray)

In this last step in building a PHP website on IIS, you configure PHP settings, web server settings, and PHP application settings that improve your website security.

- [3.1. Configure PHP Settings for Security](#31)
- [3.2. Configure Web Server and PHP Application Security](#32)

<a id="31"></a>
## 3.1. Configure PHP Settings for Security

The following procedure shows you how to configure PHP settings in the php.ini file. For information about security-related PHP settings, see [3.1. PHP Configuration Settings for Security](planning-step-3-plan-php-application-security.md#31).

### To configure a PHP setting for security

1. In Windows Explorer, open your PHP installation folder, for example **C:\PHP**.
2. In a text editor, open the php.ini file.
3. Search the file for the setting you want to change. 

    If the setting is commented out (line begins with a semicolon [;]), delete the semicolon and set the value. If you can't find the setting, add the line to the end of the file.
4. Save and close the php.ini file.
5. Recycle the IIS Application Pools for PHP to pick up the configuration changes.

<a id="32"></a>
## 3.2. Configure Web Server and PHP Application Security

This section shows how to configure several web server and application settings for IIS. These settings include isolating web applications, enabling per-site PHP configurations, and using request filtering. For more information about web server and PHP application security settings, see [3.2. Web Server and PHP Application Security](planning-step-3-plan-php-application-security.md#32).

### Isolate Web Applications

Implement the following recommendations to isolate websites and web applications on your server.

- Use one application pool per website or web application.
- Limit access to site folders and files to the application pool identity.
- Set up a separate PHP temp folder per site and only give access to the application pool identity.
- Make sure to set an ACL (access control list) on each site root to allow only access to the application pool identity.

If you have more than one application per application pool, consider creating enough application pools and moving some of the applications to the new pools.

#### To create an application pool

1. Open IIS Manager.
2. In the **Connections** pane, click **Application Pools**.
3. In the **Actions** pane, click **Add Application Pool**.
4. In the **Name** box, type a unique name for the application pool.
5. Under **.NET Framework version**, select **No Managed Code**.
6. Select the **Managed pipeline mode**. The **Integrated** mode is recommended.
7. Click **OK**.

#### To move an application to another application pool

1. Open IIS Manager.
2. In the **Connections** page, select the website or web application you want to move.
3. In the **Actions** pane, click **Basic Settings**.
4. On the **Edit Site** dialog, click **Select** to open the **Select Application Pool** dialog, and then select the application pool from the **Application pool** menu.
5. Click **OK** to close the **Select Application Pool** dialog, and click **OK** to close the **Edit Site** menu.

#### To add an application pool identity to a folder or file ACL

1. Open Windows Explorer and navigate to the folder or file.
2. Right click the folder or file, and then click **Properties**.
3. Select the **Security** tab, and then click **Edit**.
4. Click **Add**, click **Locations**, and select your server as the location to search.
5. In the **Enter the object names to select** box, type **IIS APPPOOL\applicationPoolName**, where *applicationPoolName* is the application pool identity.
6. Click **OK**, click **OK**, and click **OK** again to close the dialogs.

### Enable Per-site PHP Configuration

When you have multiple PHP applications on an IIS web server, you can improve security by configuring a PHP process pool and a php.ini file for each application. This section explains how to configure process pools and multiple pnp.ini files by using an **applicationHost.config** file.

#### Per-site PHP Process Pools

When each website has its own application pool, which is a recommended practice on IIS, it is possible to associate a dedicated FastCGI process pool with each website. This association is done in the **fastCgi** section of the **applicationHost.config** file. A FastCGI process pool is uniquely identified by the combination of **fullPath** and **arguments** attributes of the **application** element. To create several FastCGI process pools for the same process executable, such as php-cgi.exe, use the **arguments** attribute to distinguish the process pool definitions. With php-cgi.exe processes, use the command line switch &quot;-d&quot; to define an INI entry for a PHP process. And use this switch to set a PHP setting that makes the arguments string unique.

For example, if there are two Web sites &quot;website1&quot; and &quot;website2&quot; that must have their own set of PHP settings, define the FastCGI process pools as follows:

[!code-xml[Main](configuring-step-3-configure-php-application-security/samples/sample1.xml)]

In this example the PHP setting `open_basedir` is used to distinguish between the process pool definitions. The setting also enforces that the PHP executable for each process pool can perform file operations only within the root folder of the corresponding website.

Therefore, the PHP handler mapping for website1 is as follows:

[!code-xml[Main](configuring-step-3-configure-php-application-security/samples/sample2.xml)]

And the handler mapping for website2 is as follows:

[!code-xml[Main](configuring-step-3-configure-php-application-security/samples/sample3.xml)]

#### Specifying Php.ini Location

When the PHP process starts, it determines the location of the configuration php.ini file by using various settings. The [PHP documentation](http://www.php.net/manual/en/configuration.php) provides a detailed description of the PHP startup process. One of the places where the PHP process searches for the php.ini location is the PHPRC environment variable. If the PHP process finds a php.ini file in the path that is specified in this environment variable, it will use it. Otherwise, the PHP process will revert to using the default location of the php.ini file. This environment variable can be used to allow hosting customers to use their own versions of php.ini files.

For example, if there are two websites, &quot;website1&quot; and &quot;website2,&quot; that are located at the following file paths: `C:\WebSites\website1` and `C:\WebSites\website2`, you can configure the php-cgi.exe process pools in the **fastCgi** section of the **applicationHost.config** file as follows:

[!code-xml[Main](configuring-step-3-configure-php-application-security/samples/sample4.xml)]

This way website1 can have its own version of the php.ini file that is located in the `C:\WebSites\website1`, while website2 can have its own version of the php.ini file that is located in `C:\WebSites\website2`. This configuration also ensures that if a php.ini file cannot be found in the location that is specified by the PHPRC environment variable, then PHP will use the default php.ini file that is located in the same folder where the php-cgi.exe is located.

### Use Request Filtering

For information about how to configure request filtering, see [Configure Request Filtering in IIS](../../manage/configuring-security/configure-request-filtering-in-iis.md).

## See Also

- [Configure a PHP Website on IIS](configure-a-php-website-on-iis.md)
- [Step 3: Plan PHP Application Security](planning-step-3-plan-php-application-security.md)
- [Step 1: Install IIS and PHP](configuring-step-1-install-iis-and-php.md)
- [Step 2: Configure PHP Settings](configuring-step-2-configure-php-settings.md)
- [Hosting-Friendly Web Server Platform (IIS): Scenario Overview](../../get-started/introduction-to-iis/hosting-friendly-web-server-platform-iis-scenario-overview.md)