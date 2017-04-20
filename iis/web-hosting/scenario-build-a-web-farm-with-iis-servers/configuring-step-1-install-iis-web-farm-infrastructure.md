---
title: "Configuring Step 1: Install IIS Web Farm Infrastructure | Microsoft Docs"
author: rmcmurray
description: "The first step in installing and configuring an IIS 8 web farm is to install IIS on the web servers and load balancing server. Then install Application Reque..."
ms.author: iiscontent
manager: soshir
ms.date: 04/14/2013
ms.topic: article
ms.assetid: 6be6921e-6d3d-4b1a-94be-a0e6785ee576
ms.technology: iis-hosting
ms.prod: iis
msc.legacyurl: /learn/web-hosting/scenario-build-a-web-farm-with-iis-servers/configuring-step-1-install-iis-web-farm-infrastructure
msc.type: authoredcontent
---
Configuring Step 1: Install IIS Web Farm Infrastructure
====================
by [Keith Newman and Robert McMurray](https://github.com/rmcmurray)

The first step in installing and configuring an IIS 8 web farm is to install IIS on the web servers and load balancing server. Then install Application Request Routing (ARR) on the load balancing server. Finally, set up your website on one of the web servers. The goal of this step is to get the software you need installed on your servers. You configure your web farm later in the process.

When you are done with these tasks, record your design decisions before going on to [Step 2: Configure IIS Web Farm Servers](configuring-step-2-configure-iis-web-farm-servers.md).

<a id="11"></a>
## 1.1. Install IIS with Appropriate Modules

Install IIS on all servers in your web farm except your back-end file servers (content server and certificate store server). The ARR server requires only a default install of IIS with **Centralized SLL Certificate Support**. All of the web servers require you to install IIS and all IIS modules that support the types of web applications you intend to run.

### To install IIS on an ARR server

1. On the **Start** page, click the **Server Manager** tile, and then click **OK**.
2. In **Server Manager**, select **Dashboard**, and click **Add roles and features**.
3. In the **Add Roles and Features Wizard**, on the **Before You Begin** page, click **Next**.
4. On the **Select Installation Type** page, select **Role-based or Feature-based Installation** and click **Next**
5. On the **Select Destination Server** page, select **Select a server from the server pool**, select the name of your computer, and click **Next**.
6. On the **Select Server Roles** page, select **Web Server (IIS)**, and then click **Next**.
7. On the **Select Features** page, notice the preselected features, and then click **Next**.
8. On the **Web Server Role (IIS)** page, click **Next**.
9. On the **Select Features** page, note the preselected features that are installed by default, and then select **Centralized SSL Certificate Support** under the **Security** node.
10. Click **Next**.
11. On the **Confirm Installation Selections** page, confirm your selections, and then click **Install**.
12. On the **Installation Progress** page, confirm that your installation of the Web Server (IIS) role and required role services completed successfully, and then click **Close**.
13. To verify that IIS installed successfully, enter the following into a web browser:

    `http://localhost`

    You see the default IIS Welcome page.

### To install IIS and IIS modules on web servers

1. On the **Start** page, click the **Server Manager** tile, and then click **OK**.
2. In **Server Manager**, select **Dashboard**, and click **Add roles and features**.
3. In the **Add Roles and Features Wizard**, on the **Before You Begin** page, click **Next**.
4. On the **Select Installation Type** page, select **Role-based or Feature-based Installation** and click **Next**
5. On the **Select Destination Server** page, select **Select a server from the server pool**, select your server, and click **Next**.
6. On the **Select Server Roles** page, select **Web Server (IIS)**, and then click **Next**.
7. On the **Select Features** page, note the preselected features that are installed by default, and then select additional role services for the type of web applications you plan to support. (**Caution**: Install only the role services your websites require. This practice increases your website security.)
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

<a id="12"></a>
## 1.2 Install ARR for Load Balancing

Once you have a default installation of IIS on a server, you can use [Web Platform Installer](https://www.microsoft.com/web/downloads/platform.aspx) to install the current version of Application Request Routing (ARR).

### To install ARR load balancing and its dependencies

1. Open a browser to the [Application Request Routing](https://www.iis.net/downloads/microsoft/application-request-routing) website, and click the **Install** button.
2. Click **Allow**, and then click **Yes**.
3. In the **Web Platform Installer** window, click **Install**.
4. Look over the components to be installed, and then click **I Accept**.

    When the installer completes the installation, it displays and summary showing what was installed.
5. Click **Finish**, and then click **Exit**.

<a id="13"></a>
## 1.3 Set up Your Website on One Web Server

Before you proceed to the next step, set up and test your web application on one of your web servers. This will make configuring shared configuration and shared content much easier.

If you need help configuring your website on your web server, refer to one of the following IIS scenarios:

1. [Build a Static Website on IIS](../../manage/creating-websites/scenario-build-a-static-website-on-iis.md)
2. [Build a Classic ASP Website on IIS](../../application-frameworks/running-classic-asp-applications-on-iis-7-and-iis-8/scenario-build-a-classic-asp-website-on-iis.md)
3. [Build an ASP.NET Website on IIS](../../application-frameworks/scenario-build-an-aspnet-website-on-iis/overview-build-an-asp-net-website-on-iis.md)
4. [Build a PHP Website on IIS](../../application-frameworks/scenario-build-a-php-website-on-iis/overview-build-a-php-website-on-iis.md)
5. [Build an FTP Site on IIS](../../publish/using-the-ftp-service/scenario-build-an-ftp-site-on-iis.md)

## See Also

- [Step 2: Configure IIS Web Farm Servers](configuring-step-2-configure-iis-web-farm-servers.md)
- [Step 4: Plan SSL Central Certificate Store](planning-step-4-plan-ssl-central-certificate-store.md)
- [Configure a Web Farm with IIS Servers](configure-a-web-farm-with-iis-servers.md)
- [Build a Web Farm with IIS Server](overview-build-a-web-farm-with-iis-servers.md)
- [Hosting-Friendly Web Server Platform (IIS): Scenario Overview](../../get-started/introduction-to-iis/hosting-friendly-web-server-platform-iis-scenario-overview.md)