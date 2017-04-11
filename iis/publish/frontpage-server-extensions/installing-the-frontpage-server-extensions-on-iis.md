---
title: "Installing the FrontPage Server Extensions on IIS 7 | Microsoft Docs"
author: rmcmurray
description: "As of December 18, 2010, Microsoft FrontPage Server Extensions (FPSE) 2002 for Windows Vista and Windows Server 2008 RTM is supported by Ready-to-Run Softwar..."
ms.author: iiscontent
manager: soshir
ms.date: 11/22/2007
ms.topic: article
ms.assetid: 
ms.technology: iis-publish
ms.prod: iis
msc.legacyurl: /learn/publish/frontpage-server-extensions/installing-the-frontpage-server-extensions-on-iis
msc.type: authoredcontent
---
Installing the FrontPage Server Extensions on IIS 7
====================
by [Robert McMurray](https://github.com/rmcmurray)

<a id="00"></a>As of December 18, 2010, Microsoft FrontPage Server Extensions (FPSE) 2002 for Windows Vista and Windows Server 2008 RTM is supported by Ready-to-Run Software. For support and servicing, contact [Ready-to-Run Software, Inc](https://go.microsoft.com/fwlink/?LinkId=207112). 

## Introduction

Windows Vista, Windows 7, Windows Server 2008 RTM, and Windows Server 2008 R2 do not provide built-in options to install the FrontPage Server Extensions (FPSE). Microsoft realizes that the FrontPage Server Extensions are essential to many Web hosting companies and developers, and has worked with Ready-to-Run Software, Inc., to release versions of the FrontPage 2002 Server Extensions (FPSE 2002) for IIS 7 and above. These versions of FPSE 2002 are available for x86 (32-bit) and x64 (64-bit) versions of Windows Vista, Windows 7, Windows Server 2008, and Windows Server 2008 R2 as separate download packages, and you can download these versions of FPSE by clicking the following URLs:

- [Microsoft FrontPage 2002 Server Extensions for IIS 7.0](https://www.iis.net/downloads/community/2011/07/frontpage-2002-server-extensions-for-iis-70-on-windows-server-2008-and-windows-vista)
- [RTR FrontPage 2002 Server Extensions for IIS 7.5](https://www.iis.net/downloads/community/2011/07/rtr-frontpage-server-extensions-for-iis-75-on-windows-server-2008-r2-and-windows-7)

### In This Walkthrough

- [FPSE Prerequisites](installing-the-frontpage-server-extensions-on-iis.md#01)
- [Downloading and Installing FPSE](installing-the-frontpage-server-extensions-on-iis.md#02)
- [Extending websites with FPSE](installing-the-frontpage-server-extensions-on-iis.md#03)
- [Removing FPSE from websites](installing-the-frontpage-server-extensions-on-iis.md#04)

### Notes:

- There are two versions of FPSE available for IIS: 

    - Microsoft FrontPage 2002 Server Extensions for IIS 7.0
    - RTR FrontPage 2002 Server Extensions for IIS 7.5
- The IIS versions of the FrontPage 2002 Server Extensions (FPSE 2002) are supported Ready-to-Run Software, Inc. (RTR) More information about RTR is available at the following URL: 

    - [http://www.rtr.com/fpse/](http://www.rtr.com/fpse/)
- The IIS versions of FPSE 2002 introduce no new functionality; they are essentially the same versions of FPSE 2002 that were created for Windows Server 2003, but they have been updated to work on Windows Vista, Windows 7, Windows Server 2008, and Windows Server 2008 R2. By way of additional explanation, FPSE 2002 is part of the Office XP system of products. The Office XP system, including FPSE 2002, left mainstream support on July 11th, 2006, according to the [Office lifecycle policy](https://support.microsoft.com/?pr=lifecycle). Because Microsoft's support policy is to remove software from the Download Center that is no longer supported, FPSE 2002 was removed from the Microsoft Download Center at that time as a separate product. FPSE 2002 continues to be available and supported on Windows Server 2003 through the *Add Windows Components* section of *Add/Remove Programs* in the Windows Control Panel.

<a id="01"></a>

## FPSE Prerequisites

### Supported Platforms

Microsoft FrontPage 2002 Server Extensions for IIS 7.0 is only supported on the following platforms:

- **Windows Server 2008**: 

    - All SKUs
- **Windows Vista**: 

    - Business
    - Enterprise
    - Ultimate
    - Home Premium

RTR FrontPage 2002 Server Extensions for IIS 7.5 is only supported on the following platforms:

- **Windows Server 2008 R2**: 

    - All SKUs
- **Windows 7**: 

    - Professional
    - Enterprise
    - Ultimate
    - Home Premium

### Required Role Services and Features

The following role services and features are required to install the FrontPage 2002 Server Extensions (FPSE 2002) on Windows Vista, Windows 7, Windows Server 2008, and Windows Server 2008 R2. If they are not already installed on your computer when you install FPSE 2002, they will be installed for you automatically. If you do not want these role services and features installed on your computer, you cannot install FPSE 2002.

- **Web Server (IIS) Role Services**: 

    - Web Server 

        - Common HTTP Features 

            - Static Content
            - Default Document
            - Directory Browsing *(See note 1)*
            - HTTP Errors *(See note 1)*
        - Application Development 

            - ISAPI Extensions
            - ISAPI Filters
        - Health and Diagnostics 

            - HTTP Logging *(See note 1)*
            - Request Monitor *(See note 1)*
        - Security 

            - Windows Authentication or Basic Authentication *(See note 2)*
            - Request Filtering
        - Performance 

            - Static Content Compression *(See note 1)*
    - Management Tools 

        - IIS Management Console *(See note 1)*
        - IIS 6 Management Compatibility 

            - IIS 6 Metabase Compatibility
- **Features**: 

    - Windows Process Activation Service 

        - Process Model

**Notes for the above features**:

1. These role services are required to install the FrontPage Server Extensions, but they are optional once installation has completed. After installation is complete, you can use Server Manager to remove one or more of the optional role services if you do not require the functionality that they provide. However, most of these optional role services are useful for configuring and monitoring your Web server.
2. The following authentication method is required by the FrontPage Server Extensions depending on your version of Windows: 

    - Windows Authentication is required for all versions of Windows Server 2008 RTM/R2 and all versions of Windows Vista and Windows 7 *except* Windows Vista Home Premium and Windows 7 Home Premium.
    - Basic Authentication is required for Windows Vista Home Premium and Windows 7 Home Premium.

<a id="02"></a>

## Downloading and Installing FPSE

### Downloading FPSE for Windows Vista or Windows Server 2008 RTM

To install the FrontPage 2002 Server Extensions (FPSE 2002) on Windows Vista or Windows Server 2008 RTM, begin by downloading the installation package from the following URL:

- [Microsoft FrontPage 2002 Server Extensions for IIS 7.0](https://www.iis.net/downloads/community/2011/07/frontpage-2002-server-extensions-for-iis-70-on-windows-server-2008-and-windows-vista)

> [!NOTE]
> This version of the FrontPage Server Extensions is only supported on Windows Server 2008 and Windows Vista.

### Downloading FPSE for Windows 7 or Windows Server 2008 R2

To install the FrontPage 2002 Server Extensions (FPSE 2002) on Windows 7 or Windows Server 2008 R2, begin by downloading the installation package from the following URL:

- [RTR FrontPage 2002 Server Extensions for IIS 7.5](https://www.iis.net/downloads/community/2011/07/rtr-frontpage-server-extensions-for-iis-75-on-windows-server-2008-r2-and-windows-7)

> [!NOTE]
> This version of the FrontPage Server Extensions is only supported on Windows Server 2008 R2 and Windows 7.

### Installing FPSE

After you have downloaded the correct FPSE 2002 installation package, you need to make sure that you install the FrontPage Server Extensions using full administrative permissions. This is best accomplished using one of two methods:

- Log in to your computer using the local "administrator" account, then double-click the installation package to being the installation process.
- If you are logged in using an account with administrative permissions that is not the local "administrator" account, open a command prompt using the "Run as Administrator" option, then use the following command to start the installation process:

    [!code-console[Main](installing-the-frontpage-server-extensions-on-iis/samples/sample1.cmd)]

> [!NOTE]
> The above steps are required because the User Account Control (UAC) security component in the Windows Vista, Windows 7, Windows Server 2008, and Windows Server 2008 R2 operating systems will prevent the FPSE 2002 installation package from installing correctly. For more information about UAC, please see the following documentation:

- [https://go.microsoft.com/fwlink/?LinkId=113664](https://go.microsoft.com/fwlink/?LinkId=113664)

The installation process will first present you with an End-User License Agreement, which you may choose to accept or cancel, but acceptance is required to continue installation. If you accept the terms of the license agreement and click **Next**, if any of the prerequisites are not installed then the installation package will present you with a list of the role services and features that are required to install FPSE 2002. If you do not want these role services and features installed on your computer, click **Cancel** to cancel the installation. If you click **Next**, the installation package will present you with a list of optional role services that are used by some additional FrontPage features. These role services are not required by FPSE 2002, and their descriptions will list which FrontPage features use each role service. After choosing any additional role services, you can click Next and then Install to being the actual installation process.

> [!NOTE]
> Unlike previous versions of the FrontPage Server Extensions, the installation process will only create the "MSSharePointAppPool" application pool and the FrontPage Server Administration website (also called the Microsoft SharePoint Administration website). Therefore no websites will have the FrontPage Server Extensions installed after you have completed the installation process.

<a id="03"></a>

## Extending websites with FPSE

After you set up FrontPage 2002 Server Extensions (FPSE 2002) on your computer, you must extend a website or virtual server with FPSE 2002 before you can open the website using an authoring tool.

You can extend the server one of two ways:

- By using HTML Administration pages.
- By using the install operation with the command-line tools.

> [!NOTE]
> Extending a website does not configure any authentication methods. After installing FPSE 2002 on a website, you will need to configure an authentication method, such as Windows or Basic Authentication, before your users will be able to open or publish to the website.

### Using HTML Administration Pages to Extend a website

To extend a website using HTML Administration pages on Windows, use the following steps:

1. Click **Start**, point to **Programs**, point to **Administrative Tools**, and then click **Microsoft SharePoint Administrator** to open the **Server Administration** page.
2. In the list of virtual servers, click **Extend** next to the virtual server you want to extend.
3. In the **Administrator** box, type the user name for the administrator of the virtual server.
4. Click **Submit**.

> [!NOTE]
> Using the HTML Administration pages gives you the most flexibility in choosing which options you want enabled after you extend your server.

### Using the Command Line to Extend a website

You can extend a website by using the command-line tools, owsadm or owsrmadm. These tools are located in the "%ProgramFiles%\Common Files\Microsoft Shared\Web Server Extensions\50\bin" folder. To extend a website, use the install operation, which takes the following parameters.


| Parameter | Short Form | Description |
| --- | --- | --- |
| Port | -p | The port number. If missing, this parameter defaults to port 80. This value can be a site instance number, such as LM/W3SVC/1. To determine the site instance number to use, see the note below. |
| Username | -u | If your server is part of a domain, the domain name and your user name. For example, MyDomain\MyUserName. |


> [!NOTE]
> To determine which site instance number to use, open the IIS manager and select the "Sites" node in the tree. The ID column in the site list contains the unique identifier for each site, which you would use in the site instance number. For example, if a site has an ID of 3, the site instance number would be LM/W3SVC/3.

The following example shows the syntax for the install operation on Windows:

> [!code-console[Main](installing-the-frontpage-server-extensions-on-iis/samples/sample2.cmd)]


> [!NOTE]
> For a complete list of the parameters required for the install operation and their descriptions, see [Command-line Operations](https://www.microsoft.com/technet/prodtechnol/sppt/sharepnt/proddocs/admindoc/owsl01.mspx).

<a id="04"></a>

## Removing FPSE from websites

You can temporarily or permanently remove FrontPage 2002 Server Extensions on a particular server. To temporarily remove the extensions so you can clean or restore your site, use the **Uninstall** command. In this mode, much of the data about your site is preserved, so you can extend the virtual server again and return to your original configuration.

To permanently remove FrontPage 2002 Server Extensions, use the **Full Uninstall** option. Doing so also removes any other files and folders that FrontPage 2002 Server Extensions installed. All of the data about your site (excluding actual site content) is deleted when you perform a full uninstall, so be sure that is what you want before you use the **Full Uninstall** option.

### Using HTML Administration Pages to Remove

You can use HTML Administration pages to uninstall FrontPage 2002 Server Extensions. To remove FrontPage 2002 Server Extensions from a website:

1. Open the **Server Administration** page.
2. In the list of virtual servers, next to the virtual server you want to uninstall, click **Administration**.
3. Under **Administration**, click **Uninstall FrontPage 2002 Server Extensions**.
4. If you want to uninstall FrontPage 2002 Server Extensions completely, including the metadata about your website, next to **Full Uninstall**, click **Yes**.
5. Click **Uninstall**.

### Using the Command Line to Remove

You can remove the FrontPage 2002 Server Extensions from a website using the command-line tools, owsadm or owsrmadm. These tools are located in the "%CommonProgramFiles%\Microsoft Shared\Web Server Extensions\50\bin" folder. To remove FPSE 2002 from a website, you use the uninstall or fulluninstall operations. The uninstall operation removes FrontPage 2002 Server Extensions from your server. The full uninstall operation also removes the data about your site (excluding actual site content) from your virtual server.

The uninstall and fulluninstall operations take the port parameter. The following example shows the syntax for removing FPSE from a website:

> [!code-console[Main](installing-the-frontpage-server-extensions-on-iis/samples/sample3.cmd)]