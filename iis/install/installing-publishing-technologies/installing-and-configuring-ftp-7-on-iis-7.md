---
title: "Installing and Configuring FTP 7 on IIS 7"
author: rmcmurray
description: "Version Notes IIS 7.5 The FTP 7.5 service ships as a feature for IIS 7.5 in Windows 7 and Windows Server 2008 R2. IIS 7.0 The FTP 7.0 and FTP 7.5 services we..."
ms.date: 12/06/2007
ms.assetid: 1d813d22-e411-4a5a-a0f1-689421b498ae
msc.legacyurl: /learn/install/installing-publishing-technologies/installing-and-configuring-ftp-7-on-iis-7
msc.type: authoredcontent
---
# Installing and Configuring FTP 7 on IIS 7

by [Robert McMurray](https://github.com/rmcmurray)

## Compatibility

| Version | Notes |
| --- | --- |
| IIS 7.5 | The FTP 7.5 service ships as a feature for IIS 7.5 in Windows 7 and Windows Server 2008 R2. |
| IIS 7.0 | The FTP 7.0 and FTP 7.5 services were shipped out-of-band for IIS 7.0, which required downloading and installing the service from the following URL: <https://www.iis.net/downloads/microsoft/ftp>. |

## Introduction

Microsoft rewrote the FTP service for Windows Server® 2008 and above. This updated FTP service incorporates many new features that enable web authors to publish content better than before, and offers web administrators more security and deployment options.

- **Integration with IIS**: IIS has a new administration interface and configuration store, and the new FTP service is tightly integrated with this design. The old IIS 6.0 metabase is gone, and the updated configuration store based on the .NET XML-based \*.config format took its place. In addition, IIS has an updated administration tool, and the new FTP server plugs seamlessly into that paradigm.
- **Support for new Internet standards**: One of the most significant features in the updated FTP server is support for FTP over SSL. The FTP server also supports other Internet improvements such as UTF8 and IPv6.
- **Shared hosting improvements**: By fully integrating into IIS, the updated FTP server makes it possible to host FTP and Web content from the same site by simply adding an FTP binding to an existing Web site. In addition, the FTP server has virtual host name support, making it possible to host multiple FTP sites on the same IP address. The FTP server also has improved user isolation, making it possible to isolate users through per-user virtual directories.
- **Custom authentication providers**: The updated FTP server supports authentication using non-Windows accounts for IIS Managers and .NET Membership.
- **Improved logging support**: FTP logging was enhanced to include all FTP-related traffic, unique tracking for FTP sessions, FTP sub-statuses, additional detail fields in FTP logs, and much more.
- **New supportability features**: IIS has the option to display detailed error messages for local users, and the FTP server supports this by providing detailed error responses when logging on locally to an FTP server. The FTP server also logs detailed information using Event Tracing for Windows (ETW), which provides additional detailed information for troubleshooting.
- **Extensible feature set**: FTP supports extensibility that allows you to extend the built-in functionality that ships with the FTP service. More specifically, there is support for creating your own authentication and authorization providers. You can also create providers for custom FTP logging and for determining the home directory information for your FTP users.

Additional information about new features in FTP 7.5 is available in the [What's New for Microsoft and FTP 7.5?](../../get-started/whats-new-in-iis-7/what39s-new-for-microsoft-and-ftp-in-iis-7.md) article.

This document will walk you through installing the new FTP service and troubleshooting installation issues.

<a id="01"></a>

## Installing FTP for IIS 7.5

### IIS 7.5 for Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, expand **FTP Server**.
5. Select **FTP Service**.

    > [!NOTE]
    > To support ASP.NET Membership or IIS Manager authentication for the FTP service, you will also need to select **FTP Extensibility**.

6. Click **Next**.
7. On the **Confirm Installation Selections** page, click **Install**.
8. On the **Results** page, click **Close**.

### IIS 7.5 for Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. Expand **Internet Information Services**, then **FTP Server**.
4. Select **FTP Service**.

    > [!NOTE]
    > To support ASP.NET Membership or IIS Manager authentication for the FTP service, you will also need to select **FTP Extensibility**.

5. Click **OK**.

<a id="02"></a>

## Installing FTP for IIS 7.0

### Prerequisites

The following items are required to complete the procedures in this section:

1. You must be using Windows Server 2008.
2. Internet Information Services 7.0 must be installed.
3. If you are going to manage the new FTP server by using the IIS 7.0 user interface, the administration tool will need to be installed.
4. You must install the new FTP server as an administrator. (See the **Downloading and Installing** section for more.)
5. IIS 7.0 supports a shared configuration environment, which must be disabled on each server in a web farm before installing the new FTP server for each node. **Note:** Shared configuration can be re-enabled after the FTP server had been installed.
6. The FTP server that is shipped on the Windows Server 2008 DVD must be uninstalled before installing the new FTP server.

### Downloading the right version for your server

There are two separate downloadable packages for the new FTP server; you will need to download the appropriate package for your version of Windows Server 2008:

- **32-bit Installation Package**:

  - [FTP 7.5 for IIS 7.0 (x86)](https://go.microsoft.com/fwlink/?LinkID=143196)
- **64-bit Installation Package**:

  - [FTP 7.5 for IIS 7.0 (x64)](https://go.microsoft.com/fwlink/?LinkID=143197)

### Launching the installation package

You will need to run the installation package as an administrator. This can be accomplished by one of the following methods:

1. Logging in to your server using the actual account named "Administrator", then browsing to the download pages listed above or double-clicking the download package if you have saved it to your server.
2. Logging on using an account with administrator privileges and opening a command-prompt by right-clicking the Command Prompt menu item that is located in the Accessories menu for Windows programs and selecting "Run as administrator", then typing the appropriate command listed below for your version of Windows to run the installation:

    - **32-bit Windows Versions**:

        - msiexec /i FTP 7\_x86\_75.msi
    - **64-bit Windows Versions**:

        - msiexec /i FTP 7\_x64\_75.msi

> [!NOTE]
> One of the above steps is required because the User Account Control (UAC) security component in the Windows Vista and Windows Server 2008 operating systems prevents access to your applicationHost.config file. For more information about UAC, see [User Account Control](https://go.microsoft.com/fwlink/?LinkId=113664).

The following steps walk you through all of the required settings to add FTP publishing for the Default Web Site.

### Walking through the installation process

1. When the installation package opens, you should see the following screen. Click **Next** to continue.  
    ![Screenshot that shows the welcome page of the Setup Wizard.](installing-and-configuring-ftp-7-on-iis-7/_static/image1.jpg)
2. On the next screen, click the **I accept** check box if you agree to the license terms, and then click **Next**.  
    ![Screenshot that shows the end-user license agreement.](installing-and-configuring-ftp-7-on-iis-7/_static/image5.jpg)
3. The following screen lists the installation options. Choose which options you want installed from the list, and then click **Next**.

    - **Common files**: this option includes the schema file. When installing in a shared server environment, each server in the web farm will need to have this option installed.
    - **FTP Publishing Service**: this option includes the core components of the FTP service. This option is required for the FTP service to be installed on the server.
    - **Managed Code Support**: this is an optional component, but features that use managed extensibility require this option before using them, such as ASP.NET and IIS manager authentication. **Note:** This feature cannot be installed on Windows Server 2008 Core.
    - **Administration Features**: this option installs the FTP 7 management user interface. This requires the IIS 7.0 manager and .NET framework 2.0 to be installed. **Note:** This feature cannot be installed on Windows Server 2008 Core.  
        ![Screenshot that shows the Custom Setup page of the Setup Wizard.](installing-and-configuring-ftp-7-on-iis-7/_static/image9.jpg)
4. On the following screen, click **Install** to begin installing the options that you chose on the previous screen.  
    ![Screenshot that shows the Ready to install page of the Setup Wizard.](installing-and-configuring-ftp-7-on-iis-7/_static/image13.jpg)
5. When installation has completed, click **Read notes** to view the FTP README file, or click **Finish** to close the installation dialog.  
    ![Screenshot that shows the Completed the Setup Wizard page.](installing-and-configuring-ftp-7-on-iis-7/_static/image17.jpg)

> [!NOTE]
> If an error occurs during installation, you will see an error dialog. Refer to the **Troubleshooting Installation Issues** section of this document for more information.

### Troubleshooting Installation Issues

When the installation of FTP 7 fails for some reason, you should see a dialog with a button called "Installation log". Clicking the "Installation log" button will open the MSI installation log that was created during the installation. You can also manually enable installation logging by running the appropriate command listed below for your version of Windows. This will create a log file that will contain information about the installation process:

- **32-bit Windows Versions**:

  - msiexec /L FTP 7.log /I FTP 7\_x86\_75.msi
- **64-bit Windows Versions**:

  - msiexec /L FTP 7.log /I FTP 7\_x64\_75.msi

You can analyze this log file after a failed installation to help determine the cause of the failure.

Clicking the "Online information" button on the error dialog will launch the "Installing and Troubleshooting FTP 7.5" document in your web browser.

> [!NOTE]
> If you attempt to install the downloaded package on an unsupported platform, the following dialog will be displayed:

![Screenshot that shows the warning that appears if you try to install the package on an unsupported platform.](installing-and-configuring-ftp-7-on-iis-7/_static/image3.png)

<a id="03"></a>

## Known Issues in This Release

The following issues are known to exist in this release:

1. While Web-based features can be delegated to remote managers and added to web.config files using the IIS configuration infrastructure, FTP features cannot be delegated or stored in web.config files.
2. The icon of a combined Web/FTP site may be marked with a question mark even though the site is currently started with no error. This occurs when a site has a mixture of HTTP/FTP bindings.
3. After adding an FTP publishing to a Web site, clicking the site's node in the tree view of the IIS management tool may not display the FTP icons. To work around this issue, use one of the following:

    - Hit F5 to refresh the IIS management tool.
    - Click on the Sites node, then double-click on the site name.
    - Close and re-open the IIS management tool.
4. When you add a custom provider in the site defaults, it shows up under each site. However, if you attempt to remove or modify the settings for a custom provider at the site-level, IIS creates an empty &lt;providers /&gt; section for the site, but the resulting configuration for each site does not change. For example, if the custom provider is enabled in the site defaults, you cannot disable it at the site-level. To work around this problem, open your applicationHost.config file as an administrator and add a &lt;clear/&gt; element to the list of custom authentication providers, the manually add the custom provider to your settings. For example, in order to add the IIS Manager custom authentication provider, you would add settings like the following example:  

    [!code-xml[Main](installing-and-configuring-ftp-7-on-iis-7/samples/sample1.xml)]
5. The following issues are specific to the IIS 7.0 release:

    - The FTP service that is shipped on the Windows Server 2008 DVD should not be installed after the new FTP service has been installed. The old FTP service does not detect that the new FTP service has been installed, and running both FTP services at the same may cause port conflicts.
    - IIS 7 can be uninstalled after the new FTP service has been installed, and this will cause the new FTP service to fail. If IIS is reinstalled, new copies of the IIS configuration files will be created and the new FTP service will continue to fail because the configuration information for the new FTP service is no longer in the IIS configuration files. To fix this problem, re-run the setup for the new FTP service and choose "Repair".

<a id="04"></a>

## Getting Started with FTP 7.5

In order to help get started using the new FTP server, the following walkthroughs have been published:

- **Working with FTP Sites**:

  - [Creating a New FTP Site](https://go.microsoft.com/fwlink/?LinkId=89115)
  - [Add FTP publishing to an existing Web site](https://go.microsoft.com/fwlink/?LinkId=89116)
- **Configuring Security Features**:

  - [Configure FTP over SSL](https://go.microsoft.com/fwlink/?LinkId=89117)
  - [Configure FTP User Isolation](https://go.microsoft.com/fwlink/?LinkId=89118)
  - [Configure FTP Firewall Settings](https://go.microsoft.com/fwlink/?LinkId=100090)
  - [Configure IIS Manager Authentication](https://go.microsoft.com/fwlink/?LinkId=100142)
- **Advanced Administrative Features**:

  - [Configure FTP virtual host names](https://go.microsoft.com/fwlink/?LinkId=89119)
  - [Using FSRM Folder Quotas with FTP](https://go.microsoft.com/fwlink/?LinkId=100092)

In addition to these documents, the help file for the new FTP server contains a great deal of information regarding the use and administration of the new FTP server. To open the help file, open one of the FTP features in the IIS manager and click the "Help" item in the "Actions" pane.
