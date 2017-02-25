---
title: "Configuring Step 1: Install IIS and PHP | Microsoft Docs"
author: rick-anderson
description: "In this step of building a PHP website, you install IIS and FastCGI, download and install PHP and the WinCache extension, and upload your PHP application."
ms.author: aspnetcontent
manager: wpickett
ms.date: 04/14/2013
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/application-frameworks/scenario-build-a-php-website-on-iis/configuring-step-1-install-iis-and-php
msc.type: authoredcontent
---
Configuring Step 1: Install IIS and PHP
====================
by Keith Newman and Robert McMurray

In this step of building a PHP website, you install IIS and FastCGI, download and install PHP and the WinCache extension, and upload your PHP application.

The following list shows the tasks required to complete this step:

- [1.1. Install IIS](#11)
- [1.2. Install PHP by using Web PI](#12)
- [1.3. Download and Install PHP Manually](#13)
- [1.4. Add Your PHP Application](#14)

When you are done, make sure that IIS and the PHP are installed, and your PHP application has been added to your website. Then go on to [Step 2: Configure PHP Settings](configuring-step-2-configure-php-settings.md).

<a id="11"></a>
## 1.1. Install IIS

You can use the Web Platform Installer (Web PI) to install IIS, and applications that run on IIS. Web PI installs the latest versions of available Web Platform offerings with just a few simple clicks. Using Web PI, you can download and install any new tools or updates, including PHP. To learn more about the Web PI, see [Learn more and install the Web PI](https://go.microsoft.com/fwlink/?LinkID=145510).

If you do not use Web PI to install IIS, you can install IIS manually. To install IIS manually, use the following steps:

### To install IIS on Windows Server 2012

1. On the **Start** page, click the **Server Manager** tile, and then click **OK**.
2. In **Server Manager**, select **Dashboard**, and click **Add roles and features**.
3. In the **Add Roles and Features Wizard**, on the **Before You Begin** page, click **Next**.
4. On the **Select Installation Type** page, select **Role-based or Feature-based Installation** and click **Next**
5. On the **Select Destination Server** page, select **Select a server from the server pool**, select your server, and click **Next**.
6. On the **Select Server Roles** page, select **Web Server (IIS)**, and then click **Next**.
7. On the **Select Features** page, note the preselected features that are installed by default, and then select **CGI**. This selection also installs FastCGI, which is recommended for PHP applications.
8. Click **Next**.
9. On the **Web Server Role (IIS)** page, click **Next**.
10. On the **Select Role Services** page, note the preselected role services that are installed by default, and then click **Next**. (> [!NOTE]
> You only have to install the IIS 8 default role services for a static-content web server.)
11. On the **Confirm Installation Selections** page, confirm your selections, and then click **Install**.
12. On the **Installation Progress** page, confirm that your installation of the Web Server (IIS) role and required role services completed successfully, and then click **Close**.
13. To verify that IIS installed successfully, type the following into a web browser:

    `http://localhost`

    You should see the default IIS Welcome page.

### To install IIS on Windows 8

1. On the **Start** page, type **Control Panel**, and then click the **Control Panel** icon in the search results.
2. In **Control Panel**, click **Programs**, and then click **Turn Windows features on or off**.
3. In the **Windows Features** dialog box, click **Internet Information Services**, note the preselected features that are installed by default, and then select **CGI**. This selection also installs FastCGI, which is recommended for PHP applications.
4. Click **OK**.
5. To verify that IIS installed successfully, type the following into a web browser:

    `http://localhost`

    You see the default IIS Welcome page.

<a id="12"></a>
## 1.2. Install PHP by using Web PI

The preferred method to install PHP on a Windows or Windows Server computer is to use Web Platform Installer (Web PI).

### To install PHP by using Web PI

1. Open a browser to the following website: [Microsoft Web Platform Installer 3.0](https://www.microsoft.com/web/downloads/platform.aspx).
2. Click **Download It Now**, and then click **Run**.
3. At the top of the **Web Platform Installer** window, click **Products**.
4. Click **Frameworks**, and then select the current version of PHP.
5. Click **Install**. The **Web Platform Installation** page displays the version of PHP and its dependencies that will be installed.
6. Click **I Accept**. Web PI installs the PHP packages.
7. Click **Finish**.

<a id="13"></a>
## 1.3. Download and Install PHP Manually

If you decide to download PHP and install it manually, the procedures in this section guide you the following tasks:

- Download PHP and the WinCache extension.
- Install PHP and WinCache.
- Add the PHP installation folder to the Path environment variable.
- Set up a handler mapping for PHP.
- Add default document entries for PHP.
- Test your PHP installation.

To keep this procedure simple, install the WinCache extension but do not configure it. You will configure and test WinCache in [Step 2: Configure PHP Settings](configuring-step-2-configure-php-settings.md).

### To download and install PHP and WinCache

1. Open your browser to [Windows for PHP Download Page](http://windows.php.net/download/) and download the PHP non-thread-safe zip package.
2. Download the WinCache extension from the [List of Windows Extensions for PHP](http://downloads.php.net/pierre/).
3. Extract all files in the PHP .zip package to a folder of your choice, for example C:\PHP\.
4. Extract the WinCache .zip package to the PHP extensions folder (\ext), for example C:\PHP\ext. The WinCache .zip package contains one file (Php\_wincache.dll).
5. Open **Control Panel**, click **System and Security**, click **System**, and then click **Advanced system settings**.
6. In the **System Properties** window, select the **Advanced** tab, and then click **Environment Variables**.
7. Under **System variables**, select **Path**, and then click **Edit**.
8. Add the path to your PHP installation folder to the end of the **Variable value**, for example **;C:\PHP**. Click **OK**.
9. Open IIS Manager, select the hostname of your computer in the **Connections** panel, and then double-click **Handler Mappings**.
10. In the **Action** panel, click **Add Module Mapping**.
11. In **Request path**, type **\*.php**.
12. From the **Module** menu, select FastCgiModule.
13. In the **Executable** box, type the full path to Php-cgi.exe, for example **C:\PHP\Php-cgi.exe**.
14. In **Name**, type a name for the module mapping, for example **FastCGI**.
15. Click **OK**.
16. Select the hostname of your computer in the **Connections** panel, and double-click **Default Document**.
17. In the **Action** panel, click **Add**. Type **Index.php** in the **Name** box, and then click **OK**.
18. Click **Add** again. Type **Default.php** in the **Name** box, and then click **OK**.

### To test your PHP installation

1. Open a text editor, for example Notepad, as Administrator.
2. In a new file, type the following text: `<?php phpinfo(); ?>`
3. Save the file as **C:\inetpub\wwwroot\Phpinfo.php**.
4. Open a browser and enter the following URL:

    `http://localhost/phpinfo.php`

    A nicely formatted webpage is displayed showing the current PHP settings.

<a id="14"></a>
## 1.4. Add Your PHP Application

Once you have IIS and PHP installed, you can add a PHP application to your web server. This section describes how to set up your PHP application on an IIS web server with PHP installed. It does not explain how to develop a PHP application.

### To add a PHP web application

1. Open IIS Manager. 

    - For Windows Server 2012, on the **Start** page click the **Server Manager** tile, and then click **OK**. On the **Server Manager Dashboard**, click the **Tools** menu, and then click **Internet Information Services (IIS) Manager**.
    - For Windows 8, on the **Start** page type **Control Panel**, and then click the **Control Panel** icon in the search results. On the **Control Panel** screen, click **System and Security**, click **Administrative Tools**, and then **click Internet Information Services (IIS) Manager**.
2. In the **Connections** pane, right-click the **Sites** node in the tree, and then click **Add Website**.
3. In the **Add Website** dialog box, type a friendly name for your website in the **Site name** box.
4. If you want to select a different application pool than the one listed in the **Application Pool** box, click **Select**. In the **Select Application Pool** dialog box, select an application pool from the **Application Pool** list and then click **OK**.
5. In the **Physical path** box, type the physical path of the website's folder, or click the browse button (**...**) to navigate the file system to find the folder.
6. If the physical path that you entered in step 5 is to a remote share, click **Connect as** to specify credentials that have permission to access the path. If you do not use specific credentials, select the **Application user (pass-through authentication)** option in the **Connect As** dialog box.
7. Select the protocol for the website from the **Type** list.
8. The default value in the **IP address** box is **All Unassigned**. If you must specify a static IP address for the website, type the IP address in the **IP address** box.
9. Type a port number in the **Port** text box.
10. Optionally, type a host header name for the website in the **Host Header** box.
11. If you do not have to make any changes to the site, and you want the website to be immediately available, select the **Start Web site immediately** check box.
12. Click **OK**.

## See Also

- [Configure a PHP Website on IIS](configure-a-php-website-on-iis.md)
- [Step 1: Plan IIS Web Server and PHP Installation](planning-step-1-plan-iis-web-server-and-php-installation.md)
- [Step 2: Configure PHP Settings](configuring-step-2-configure-php-settings.md)
- [Step 3: Configure PHP Application Security](configuring-step-3-configure-php-application-security.md)
- [Hosting-Friendly Web Server Platform (IIS): Scenario Overview](../../get-started/introduction-to-iis/hosting-friendly-web-server-platform-iis-scenario-overview.md)