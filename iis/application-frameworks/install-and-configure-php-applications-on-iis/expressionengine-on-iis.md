---
title: "ExpressionEngine on IIS"
author: rick-anderson
description: "Introduction ExpressionEngine is a flexible, feature-rich content management system that empowers thousands of individuals, organizations, and companies arou..."
ms.date: 01/17/2008
ms.assetid: 80b02fea-6773-499c-a470-733b02c34f79
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-applications-on-iis/expressionengine-on-iis
msc.type: authoredcontent
---
# ExpressionEngine on IIS

by Eric Woersching

## Introduction

ExpressionEngine is a flexible, feature-rich content management system that empowers thousands of individuals, organizations, and companies around the world to easily manage their websites.

For more information about ExpressionEngine, see [http://ExpressionEngine.com/](http://expressionengine.com/).

In this section, we go through the steps that are required to install ExpressionEngine to work with FastCGI extension on IIS 7.0 and above, and Windows Server® 2008. To find out more about FastCGI support in IIS, see [https://www.iis.net/fastcgi](https://www.iis.net/downloads/microsoft/fastcgi-for-iis).

The following steps assume that you have completed the setup and configuration of FastCGI extension and PHP libraries as described in [https://www.iis.net/fastcgi/phpon60](using-fastcgi-to-host-php-applications-on-iis-60.md).

## Download and Unpack ExpressionEngine

First, download the latest stable release of the ExpressionEngine application. For this article, we use ExpressionEngine (EECore1.6.1). Download the full package from the mirror [https://secure.expressionengine.com/download.php?ACT=agreement&amp;id=34](https://secure.expressionengine.com/download.php?ACT=agreement&amp;id=34).

Once you download the package, uncompress it and copy the files and folders to `C:\Inetpub\wwwroot\eecore`.

## Set Up the Database

Before starting the installation procedure for ExpressionEngine, create a database on your server. Also create a user and grant this user db ownership permission to the database. Follow the instructions in the [Setting Up a Database for a PHP Application on IIS](../install-and-configure-php-on-iis/setting-up-a-database-for-a-php-application-on-iis.md) article for a MySQL database. This walkthrough uses the following database information:

- Database Name: 'expressionengine'
- Database User: 'eemsuser'
- Account Password: 'eems'

## Set Up and Configure ExpressionEngine

Installation information and setup information documents are available at [http://expressionengine.com/docs/installation/installation.html](http://expressionengine.com/docs/installation/installation.html).

Follow these steps:

1. Rename the "eecore\System" folder to "eecore\microsoftsystem". This increases security by keeping the directory containing your ExpressionEngine backend files hidden from public access.
2. Delete the following file and directory. They upgrade from the previous version.  

    - Eecore\microsoftsystem /update.php --- Delete this file
    - Eecore\microsoftsystem/updates --- Delete this folder
3. Provide all permissions to the IIS user for the following folders:  

   - images/avatars/uploads/
   - images/captchas/
   - images/member\_photos/
   - images/pm\_attachments/
   - images/signature\_attachments/
   - images/uploads/
   - system/cache/

     [![Screenshot of Permissions for uploads dialog box. Permissions for I I S underscore I U S R S are all selected and allowed.](expressionengine-on-iis/_static/image2.jpg)](expressionengine-on-iis/_static/image1.jpg)

## Run the Installation Script

Inside the root directory, you find a file called install.php. Browse to the install using [http://localhost/eecore/install.php](http://localhost/eecore/install.php). This runs a script which configures your database and sets up the default site. Be sure that you access the file through your webserver and not by loading the file into your web browser locally.

1. Click the "Click Here to begin" button to start installation  
    [![Screenshot of local host web page. Click here to begin button is found near the bottom of the web page.](expressionengine-on-iis/_static/image4.jpg)](expressionengine-on-iis/_static/image3.jpg)
2. Accept the agreement and click Submit.  
    [![Screenshot of the Expressions Engine Installation Wizard. The button next to the text I agree to abide by the license Terms and Conditions as stated above is selected.](expressionengine-on-iis/_static/image6.jpg)](expressionengine-on-iis/_static/image5.jpg)
3. Provide a name for the folder, which you renamed from System. Click Submit.  
    [![Screenshot of the Expressions Engine Installation Wizard. A box for the name of the system folder is shown above the submit button.](expressionengine-on-iis/_static/image8.jpg)](expressionengine-on-iis/_static/image7.jpg)
4. Provide the details of your database: Admin username, password, time zone, etc. Click install ExpressionEngine.  

   - MySQLUserName as: eemsuser
   - MySQLPassword as: eems
   - MySQLDataBase as : expressionengine
   - Admin account user name as : expressionengineadmin
   - And password as : eeadmin

     [![Screenshot of the Expressions Engine Installation Wizard. The Server Settings page is shown.](expressionengine-on-iis/_static/image10.jpg)](expressionengine-on-iis/_static/image9.jpg)

     [![Screenshot of the Expressions Engine Installation Wizard. The Database Settings page is shown.](expressionengine-on-iis/_static/image12.jpg)](expressionengine-on-iis/_static/image11.jpg)

     [![Screenshot of the Expressions Engine Installation Wizard. The Create your admin account page is shown.](expressionengine-on-iis/_static/image14.jpg)](expressionengine-on-iis/_static/image13.jpg)

     [![Screenshot of the Expressions Engine Installation Wizard. The Localization Settings page and Choose your default template design page is shown.](expressionengine-on-iis/_static/image16.jpg)](expressionengine-on-iis/_static/image15.jpg)
5. You see the confirmation screen for a successful installation.  
    [![Screenshot of the Expressions Engine Installation Wizard. The text says that Expression Engine has been successfully installed!](expressionengine-on-iis/_static/image18.jpg)](expressionengine-on-iis/_static/image17.jpg)
6. Login to the Control Panel using the Admin username and password.  
    [![SCreenshot of the Control Panel Login page. The username and password box are shown. The submit button is also shown.](expressionengine-on-iis/_static/image20.jpg)](expressionengine-on-iis/_static/image19.jpg)

The following are some screenshots of ExpressionEngine after it is up and running on IIS.

[![Screenshot of the Expression Engine web page. The home page is shown.](expressionengine-on-iis/_static/image22.jpg)](expressionengine-on-iis/_static/image21.jpg)

[![Screenshot of the Expression Engine web page. The modules tab is displayed and a list of modules is shown.](expressionengine-on-iis/_static/image24.jpg)](expressionengine-on-iis/_static/image23.jpg)

[![Screenshot of the Expression Engine web page. The Default Site Weblog is displayed. Text on Getting Started with Expression Engine is written under the date Monday, December 10, 2007.](expressionengine-on-iis/_static/image26.jpg)](expressionengine-on-iis/_static/image25.jpg)

[![Screenshot of the Expression Engine web page. The Default Site Weblog is displayed.](expressionengine-on-iis/_static/image28.jpg)](expressionengine-on-iis/_static/image27.jpg)

## Getting More Information

To discuss the FastCGI Extension for IIS 6.0, or file bug reports, please use the FastCGI forums:

- [IIS.NET / IIS 6.0 FastCGI forums](https://forums.iis.net/1103.aspx).

To get more information regarding running various PHP applications on IIS refer to:

- [PHP on IIS portal](https://php.iis.net/)
- [PHP community forum](https://forums.iis.net/1102.aspx).
