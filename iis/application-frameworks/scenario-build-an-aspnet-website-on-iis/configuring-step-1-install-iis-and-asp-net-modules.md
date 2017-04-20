---
title: "Configuring Step 1: Install IIS and ASP.NET Modules | Microsoft Docs"
author: rmcmurray
description: ""
ms.author: iiscontent
manager: soshir
ms.date: 04/14/2013
ms.topic: article
ms.assetid: a7b92024-7976-4485-9140-11ded05a0829
ms.technology: iis-appfx
ms.prod: iis
msc.legacyurl: /learn/application-frameworks/scenario-build-an-aspnet-website-on-iis/configuring-step-1-install-iis-and-asp-net-modules
msc.type: authoredcontent
---
Configuring Step 1: Install IIS and ASP.NET Modules
====================
by [Keith Newman and Robert McMurray](https://github.com/rmcmurray)

The first step in building an ASP.NET website on IIS 8 is to install IIS along with the ASP.NET modules. Then add your ASP.NET application files to IIS.

When you are done, make sure that IIS and the ASP.NET modules are installed, and your ASP.NET application has been added to your website. Then go on to [Step 2: Configure ASP.NET Settings](configuring-step-2-configure-asp-net-settings.md).

<a id="11"></a>
## Installing IIS and ASP.NET Modules

This section describes how to install IIS and the modules that support ASP.NET applications in any of the following ways:

- Install IIS on Windows Server® 2012 using the IIS Manager UI.
- Install IIS on Windows® 8 using the IIS Manager UI.
- Install IIS using the command line.

> [!IMPORTANT]
> To install IIS on either Windows Server 2012 or Windows 8, you must sign on as a member of the Administrators group.

If you prefer, you could use the Web Platform Installer (Web PI) to install IIS and third-party applications that run on IIS. Because the Web PI installs the latest versions of available Web Platform offerings, with just a few simple clicks you can download and install any new tools or updates. To learn more about the Web PI, see [Learn more and install the Web PI](https://go.microsoft.com/fwlink/?LinkID=145510).

If you support web applications written using ASP.NET 2 to 3.5, install .NET 3.5 before installing IIS and ASP.NET modules.

### To install .NET 3.5 on Windows Server 2012 or Windows 8

1. On the **Start** screen, right-click the **Command Prompt** tile, and then click **Run as administrator**.
2. At the command prompt, type the following: **dism /online /enable-feature /featurename:netfx3**
3. Wait for the command to complete. It could take several minutes.
4. Close the command prompt window.

### To install IIS and ASP.NET modules on Windows Server 2012 using the UI

1. On the **Start** page, click the **Server Manager** tile, and then click **OK**.
2. In **Server Manager**, select **Dashboard**, and click **Add roles and features**.
3. In the **Add Roles and Features Wizard**, on the **Before you begin** page, click **Next**.
4. On the **Select installation type** page, select Role-based or feature-based installation, and click **Next**.
5. On the **Select destination server** page, select **Select a server from the server pool**, select your server, and click **Next**.
6. On the **Select server roles** page, select **Web Server (IIS)**, and click **Next**.
7. On the **Select features** page, click **Next**.
8. On the **Web Server Role (IIS)** page, click **Next**.
9. On the **Select role services** page, note the preselected role services that are installed by default, expand the **Application Development** node, and then select **ASP.NET 4.5**. (If you installed **.NET 3.5**, select **ASP.NET 3.5** also.)
10. On the **Summary of Features to Install** page, confirm your selections, and then click **Install**.
11. In the **Add features that are required for ASP.NET 4.5?** box, click **Add Features**. The following additional features are added:

    - **.NET Extensibility 4.5**
    - **ISAPI Extensions**
    - **ISAPI Filters**
    - **.NET Extensibility 3.5** (If **ASP.NET 3.5** was selected)
12. Click **Next**.
13. On the **Confirm installation selections** page, click **Install**.
14. On the **Installation progress** page, confirm that your installation of the Web Server (IIS) role and required role services completed successfully, and then click **Close**.
15. To verify that IIS installed successfully, type the following into a web browser:

    `http://localhost`

    The default IIS Welcome page is displayed.

### To install IIS and ASP.NET modules on Windows 8 by using the UI

1. On the **Start** page, click the **Control Panel** tile.
2. In **Control Panel**, click **Programs**, and then click **Turn Windows features on or off**.
3. In the **Windows Features** dialog box, click **Internet Information Services** to install the default features.
4. Expand the **Application Development Features** node and click **ASP.NET 4.5** to add the features that support ASP.NET. (If you installed **.NET 3.5**, select **ASP.NET 3.5** also.) The following additional features are automatically selected:

    - **.NET Extensibility 4.5**
    - **ISAPI Extensions**
    - **ISAPI Filters**
    - **.NET Extensibility 3.5** (If **ASP.NET 3.5** was selected)
5. Click **OK** to close the **Windows Features** dialog box.
6. To verify that IIS installed successfully, type the following into a web browser:

    `http://localhost`

    The default IIS Welcome page is displayed.

### To install IIS and ASP.NET modules by using the command line

Type the following command at a Command Prompt or into a script:

`Start /w pkgmgr /iu:IIS-WebServerRole;IIS-WebServer;IIS-CommonHttpFeatures;IIS-StaticContent;IIS-DefaultDocument;IIS-DirectoryBrowsing;IIS-HttpErrors;IIS-ApplicationDevelopment;IIS-ASPNET;IIS-NetFxExtensibility;IIS-ISAPIExtensions;IIS-ISAPIFilter;IIS-HealthAndDiagnostics;IIS-HttpLogging;IIS-LoggingLibraries;IIS-RequestMonitor;IIS-Security;IIS-RequestFiltering;IIS-HttpCompressionStatic;IIS-WebServerManagementTools;IIS-ManagementConsole;WAS-WindowsActivationService;WAS-ProcessModel;WAS-NetFxEnvironment;WAS-ConfigurationAPI`

<a id="12"></a>
## Adding the ASP.NET Application

This section describes how to add your ASP.NET application to your website in the following ways:

- Adding an ASP.NET Application with the IIS Manager UI
- Adding an ASP.NET application with the command line

In [Plan an ASP.NET Website on IIS](plan-an-asp-net-website-on-iis.md), you made the following decisions:

- Alias string that becomes part of the application root URL.
- Application pool to run the application in.
- Physical path to the application files on the server.

### To add an ASP.NET application by using the UI

1. Open IIS Manager.

    - For Windows Server 2012, on the **Start** page click the **Server Manager** tile, and then click **OK**. In **Server Manager**, click the **Tools** menu, and then click **Internet Information Services (IIS) Manager**.
    - For Windows 8, on the **Start** page type **Control Panel**, and then click the **Control Panel** icon in the search results. On the **Control Panel** screen, click **System and Security**, click **Administrative Tools**, and then **click Internet Information Services (IIS) Manager**.
2. In the **Connections** pane, expand the **Sites** node.
3. Right-click the site for which you want to create an application, and click **Add Application**.
4. In the **Alias** text box, type a value for the application URL, such as **marketing**. This value is used to access the application in a URL.
5. Click **Select** if you want to select a different application pool than the one listed in the **Application pool** box. In the **Select Application Pool** dialog box, select an application pool from the **Application pool** list and then click **OK**.
6. In the **Physical path** text box, type the physical path of the application's folder, or click the browse button (**...**) to navigate the file system to find the folder.
7. Optionally, click **Connect as** to specify credentials that have permission to access the physical path. If you do not use specific credentials, select the **Application user (pass-through authentication)** option on the **Connect As** dialog box.
8. Optionally, click **Test Settings** to verify the settings that you specified for the application.
9. Click **OK**.

### To add an ASP.NET application by using the command line

To add an application to a site, use the following syntax:

`appcmd add app /site.name:string /path:string /physicalPath:string`

The variable `site.name:string` is the name of the website to which you want to add the application. The variable `path:string` is the virtual path of the application, such as `/application`, and `physicalPath:string` is the physical path of the application content in the file system.

For example, to add an application named **marketing** to a site named **contoso**, with content at `c:\application`, type the following at the command prompt, and then press ENTER:

`appcmd add app /site.name:contoso /path:/marketing /physicalPath:c:\application`

## See Also

- [Step 2: Configure ASP.NET Settings](configuring-step-2-configure-asp-net-settings.md)
- [Configure an ASP.NET Website on IIS](configure-an-asp-net-website-on-iis.md)
- [Build an ASP.NET Website on IIS](overview-build-an-asp-net-website-on-iis.md)
- [Step 1: Plan IIS Web Server and ASP.NET Modules Installation](planning-step-1-plan-iis-web-server-and-asp-net-modules-installation.md)