---
title: "Umbraco"
author: simtan
description: "Umbraco is an open source content management system (CMS) built on the Microsoft ASP.NET Framework. For more information about Umbraco, refer to the Umbraco..."
ms.date: 03/10/2011
ms.assetid: ab653acc-610e-4d26-b828-2d56a6927814
msc.legacyurl: /learn/publish/deploying-application-packages/umbraco
msc.type: authoredcontent
---
# Umbraco

by [Simon Tan](https://github.com/simtan)

## Introduction

Umbraco is an open source content management system (CMS) built on the Microsoft ASP.NET Framework. For more information about Umbraco, refer to the [Umbraco](http://www.umbraco.org/ "Umbraco") Web site. For step-by-step instructions for installing Umbraco in an IIS environment, see the *Procedure* section of this topic.

## Requirements

For information about technical requirements for your IIS environment, refer to [Install Server Components](../../web-hosting/joining-the-web-hosting-gallery/install-server-components.md).

## Procedure

### Step 1. Install the application in an IIS test environment.

To install the application, you can use Web Platform Installer or WebMatrix. These procedures are described in this step.

#### Web Platform Installer

The Microsoft Web Platform Installer 2.0 (Web PI) is a free tool that allows you to easily install and run the most popular free web applications for blogging, content management and more with the built-in Windows Web Application Gallery. For more information about Web PI, refer to the [Microsoft Web Platform Installer 2.0](https://www.microsoft.com/web/downloads/platform.aspx) Web site.

To use Web PI to install this application, complete these steps:

1. From the Windows Start menu, click **Programs**, and then click **Web Platform Installer**.  
  
   The Web Platform Installation window appears.  
    ![Screenshot of the Web Platform Installer wizard's Web Applications tab.](umbraco/_static/image1.jpg)
2. Click the **Web Applications** tab, select the **Umbraco CMS** check box, and click **Install**.  
  
    ![Screenshot of the Web Platform with the Umbraco C M S option being selected.](umbraco/_static/image3.jpg)
3. Select the **Umbraco CMS** check box, and click **I Accept**.  
  
    ![Screenshot of the Web Platform Installation screen showing the Mixed Mode Authentication option being selected.](umbraco/_static/image5.jpg)
4. Select **Mixed Mode Authentication**, enter a password, and click **Continue**. 

    Once the preinstallation steps complete, the site information window appears.  
   ![Screenshot of the Enter your site information screen, showing various pre installation steps.](umbraco/_static/image7.jpg)
5. In the Web Site list, click **New Web Site**.
6. Enter an application name in the application name field.
7. Enter a web site name in the Web Site Name field.
8. Enter a physical path in the Physical path field.
9. In the IP address list, click **All Unassigned**, and enter **80** in the Port field.
10. Enter a host name in the Host Name field, and click **Continue**.  
  
    The application information window appears.  
    ![Screenshot of the Enter application information window.](umbraco/_static/image9.jpg)
11. In the Choose your database list, click **SQL Server**.
12. In the Create a new or use an existing database list, click **Create new database**.
13. Enter a database administrator user name in the Database Admin Username field.
14. Enter a password in the Database Admin Password field.
15. Click **Continue**.  
  
    Once the installation process completes, the final installation window appears.  
    ![Screenshot of the Web Platform Installation window stating that Launch Umbraco C M S has been successfully installed.](umbraco/_static/image11.jpg)
16. Click **Finish**.  
  
    The Umbraco Configuration Wizard appears. From this window, you can configure the Umbraco application and view additional information about the Umbraco application.  
    ![Screenshot of the Umbraco Configuration Wizard.](umbraco/_static/image13.jpg)

#### WebMatrix

WebMatrix is a free, easy way to customize and build Web sites from popular open-source applications, such as WordPress, Drupal, and Joomla. In addition, you can build sites from the ground up using ASP.NET, PHP, HTML and a number of other leading technologies. For more information about WebMatrix, refer to the [WebMatrix](https://www.microsoft.com/web/webmatrix/) Web site.

To use WebMatrix to install this application, complete these steps:

1. Launch WebMatrix.  
  
   The WebMatrix home page appears.  
    ![Screenshot of the Microsoft WebMatrix home page.](umbraco/_static/image15.jpg)
2. Click **Site from Web Gallery**.  
  
   The Site from Web Gallery page appears.  
    ![Screenshot of the Site from Web Gallery page.](umbraco/_static/image17.jpg)
3. Click **Umbraco CMS**, and then click **Next**.  
  
   The Accept EULA page appears.  
    ![Screenshot of the Accept E U L A page, showing an Umbraco C M S downloadable file.](umbraco/_static/image19.jpg)
4. Click **I Accept** to agree to the end-user license agreement.  
  
   The Application Parameters page appears.  
    ![Screenshot of the Application Parameters page.](umbraco/_static/image21.jpg)
5. Enter information appropriate to your environment, and click **Next**.   
  
   WebMatrix installs the Umbraco software on your local computer. This page appears once installation is complete.  
    ![Screenshot of the Site from Web Gallery page showing that Umbraco C M S has been installed.](umbraco/_static/image23.jpg)
6. Click **OK**.  
  
   The Publishing Settings page appears.  
    ![Screenshot of the Publishing Settings page.](umbraco/_static/image25.jpg)
7. Add your hosting provide and domain-specific information, and click **Validate Connection**.
8. If the connection was successful, click **Apply**, and then click **Publish**.  
  
   The Publish Preview page appears.  
    ![Screenshot of the Publish Preview page, showing the Change Files and Databases sections.](umbraco/_static/image27.jpg)
9. Click **Continue**. 

    Once publishing is complete, the Deployment Details dialog box appears.  
   ![Screenshot of the Deployment Details dialog box.](umbraco/_static/image29.jpg)
10. Click **OK**.  
  
The Umbraco Configuration Wizard appears. From this window, you can configure the Umbraco application and view additional information about the Umbraco application.  
![Screenshot of the Umbraco Configuration Wizard, reading Thank you for choosing umbraco.](umbraco/_static/image31.jpg)

### Step 2. Build the application package from the IIS site.

To build the application package from the IIS site, complete the steps described in [Export a Package through IIS Manager](../using-web-deploy/export-a-package-through-iis-manager.md).

### Step 3. Install the application on the target server.

To install the application on the target server, complete the steps described in [Import a Package through IIS Manager](../using-web-deploy/import-a-package-through-iis-manager.md).
