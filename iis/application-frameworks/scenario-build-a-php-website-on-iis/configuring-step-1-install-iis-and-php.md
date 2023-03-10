---
title: "Configuring Step 1: Install IIS and PHP"
author: rmcmurray
description: "In this step of building a PHP website, you install IIS and FastCGI, download and install PHP and the WinCache extension, and upload your PHP application."
ms.date: 04/14/2013
ms.assetid: 73b8ec4b-7af9-482a-9fef-f0b8200926e7
msc.legacyurl: /learn/application-frameworks/scenario-build-a-php-website-on-iis/configuring-step-1-install-iis-and-php
msc.type: authoredcontent
---
# Configuring Step 1: Install IIS and PHP

by Keith Newman and [Robert McMurray](https://github.com/rmcmurray)

In this step of building a PHP website, you install IIS and FastCGI, download and install PHP and the WinCache extension, and upload your PHP application.

When you are done, make sure that IIS and the PHP are installed, and your PHP application has been added to your website. Then go on to [Step 2: Configure PHP Settings](configuring-step-2-configure-php-settings.md).

<a id="11"></a>

## 1.1. Install IIS

To install IIS,  use the following steps:

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
10. On the **Select Role Services** page, note the preselected role services that are installed by default, and then click **Next**.

    > [!NOTE]
    > You only have to install the IIS 8 default role services for a static-content web server.

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

## 1.2. Download and Install PHP Manually

The procedures in this section guide you to install PHP Manually:

- Download PHP and the WinCache extension.
- Install PHP and WinCache.
- Add the PHP installation folder to the Path environment variable.
- Set up a handler mapping for PHP.
- Add default document entries for PHP.
- Test your PHP installation.

To keep this procedure simple, install the WinCache extension but do not configure it. You will configure and test WinCache in [Step 2: Configure PHP Settings](configuring-step-2-configure-php-settings.md).

### To download and install PHP and WinCache

1. Open your browser to [Windows for PHP Download Page](https://windows.php.net/download/) and download the PHP non-thread-safe zip package.
2. Download the WinCache extension from the [List of Windows Extensions for PHP](https://sourceforge.net/projects/wincache/).
3. Extract all files in the PHP .zip package to a folder of your choice, for example `C:\PHP\`.
4. Extract the WinCache .zip package to the PHP extensions folder (\ext), for example `C:\PHP\ext`. The WinCache .zip package contains one file (Php\_wincache.dll).
5. Open **Control Panel**, click **System and Security**, click **System**, and then click **Advanced system settings**.
6. In the **System Properties** window, select the **Advanced** tab, and then click **Environment Variables**.
7. Under **System variables**, select **Path**, and then click **Edit**.
8. Add the path to your PHP installation folder to the end of the **Variable value**, for example `;C:\PHP`. Click **OK**.
9. Open IIS Manager, select the hostname of your computer in the **Connections** panel, and then double-click **Handler Mappings**.
10. In the **Action** panel, click **Add Module Mapping**.
11. In **Request path**, type **\*.php**.
12. From the **Module** menu, select FastCgiModule.
13. In the **Executable** box, type the full path to Php-cgi.exe, for example `C:\PHP\Php-cgi.exe`.
14. In **Name**, type a name for the module mapping, for example **FastCGI**.
15. Click **OK**.
16. Select the hostname of your computer in the **Connections** panel, and double-click **Default Document**.
17. In the **Action** panel, click **Add**. Type **Index.php** in the **Name** box, and then click **OK**.
18. Click **Add** again. Type **Default.php** in the **Name** box, and then click **OK**.

### To test your PHP installation

1. Open a text editor, for example Notepad, as Administrator.
2. In a new file, type the following text: `<?php phpinfo(); ?>`
3. Save the file as `C:\inetpub\wwwroot\Phpinfo.php`.
4. Open a browser and enter the following URL:

    `http://localhost/phpinfo.php`

    A nicely formatted webpage is displayed showing the current PHP settings.

<a id="13"></a>

## 1.3. Add Your PHP Application

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

## See also

- [Configure a PHP Website on IIS](configure-a-php-website-on-iis.md)
- [Step 1: Plan IIS Web Server and PHP Installation](planning-step-1-plan-iis-web-server-and-php-installation.md)
- [Step 2: Configure PHP Settings](configuring-step-2-configure-php-settings.md)
- [Step 3: Configure PHP Application Security](configuring-step-3-configure-php-application-security.md)
- [Hosting-Friendly Web Server Platform (IIS): Scenario Overview](../../get-started/introduction-to-iis/hosting-friendly-web-server-platform-iis-scenario-overview.md)
