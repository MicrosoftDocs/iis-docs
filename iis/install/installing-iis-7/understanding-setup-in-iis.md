---
title: "Understanding Setup in IIS 7 | Microsoft Docs"
author: rick-anderson
description: "This article provides an overview of Microsoft Windows Vista ® and Microsoft Server ® 2008 setup technology and a detailed examination of IIS 7.0 and above c..."
ms.author: iiscontent
manager: soshir
ms.date: 11/22/2007
ms.topic: article
ms.assetid: a0767509-ddbb-442f-a5fa-3be040c32148
ms.technology: iis-install
ms.prod: iis
msc.legacyurl: /learn/install/installing-iis-7/understanding-setup-in-iis
msc.type: authoredcontent
---
Understanding Setup in IIS 7
====================
by [Saad Ladki](https://twitter.com/saadladki)

## About This Article

This article provides an overview of Microsoft Windows Vista® and Microsoft Server® 2008 setup technology and a detailed examination of IIS 7.0 and above componentized setup. This information is especially important for those who will need to customize IIS Setup in command line and unattended script scenarios. If you regularly use Sysocmgr.exe in scripts to install IIS 6.0, then you must change those scripts for IIS 7.0 and above in Windows Vista and Windows Server 2008. This whitepaper gives you the background information you need to make these changes.

<a id="aboutiis"></a>

## About IIS 7 and Above

IIS 7 and above is the product name used to refer to the versions of Internet Information Services (IIS) that are included in some editions of Windows Server® 2008, Windows Server® 2008 R2, Windows Vista®, and Windows® 7.

> IIS 7.0 is the Web Server (IIS) role in Windows Server 2008, and the Web server in Windows Vista.
> 
> IIS 7.5 is the Web Server (IIS) role in Windows Server 2008 R2, and the Web server in Windows 7.


<a id="overview"></a>

## Overview of IIS Setup

IIS 7 and above has a completely modular setup design that enables control over the footprint of a Web server. The GUI, command line, and unattended setup options available in IIS make it easy to manage the security and servicing footprint of an IIS Web server.

The new IIS server pipeline architecture provides a high level of component granularity. Because of this granularity, when you install IIS, you can surfaces this granularity in user selectable, installable components. You can also use IIS Setup to customize your installation by selecting from more than 40 IIS features. New to IIS Setup is the ability to install just the feature modules that you require, allowing you to deploy very thin, task-specific servers, as well as lock out functionality in ways never before possible.

<a id="usingwebpi"></a>

## Using the Web Platform Installer (Web PI)

You can use the Web Platform Installer (Web PI) to easily install IIS, as well as other applications that run on IIS. The Web PI is a free, lightweight tool that lets you install IIS and related technologies such as ASP.NET, SQL Server Express, Visual Web Developer, and other popular Web applications. Because the Web PI references and links to the latest versions of available Web Platform offerings, with just a few simple clicks you can download and install any new tools or updates. To learn more about the Web PI and about how to install it, see the [Microsoft Web Platform](https://go.microsoft.com/fwlink/?LinkID=145510) page.

## Windows Server 2008 and Windows Vista Component-Based Setup

OS and optional features installation for Windows Vista and Windows Server 2008 is based on completely new technology. The new setup technology is now driven by a declarative model, with each feature of the operating system defining its own set of components that make up the feature and its dependencies.

Windows Vista and Windows Server 2008 benefit from this new installation infrastructure in several important ways:

- Single binaries base for all versions of Windows Server 2008

    - OS versions are assembled declaratively.
    - Client &amp; Server versions share the same code base.
- Servicing 

    - Dependencies known for all features.
    - Impact of servicing a component is now completely understood.
    - Smaller service packs.
- Security 

    - Reduced attack surface.
    - All binaries are not installed for each OS version.

## Windows Server 2008 and Windows Vista Setup for Optional Features

In Windows Vista and Windows Server 2008, the same component-based setup technology used to install the OS is also used to install optional features such as IIS. Prior to Windows Vista and Windows Server 2008, the Windows setup infrastructure had multiple technologies that were required before you could upgrade, service, and add optional features to the OS. These included:

- Setup.exe to install OS.
- Sysocmgr.exe to install optional features.
- Answers files to install optional features.
- Update.exe to install service packs.
- MSI installer packages.

In Windows Vista and Windows Server 2008, we now have a single component-based setup infrastructure that unifies clean OS installation, servicing of the OS, and installation of optional features. For optional features, this technology now replaces Sysocmgr.exe.

> [!NOTE]
> If you regularly use Sysocmgr.exe directly to install IIS, then you must change those scripts for Windows Vista and Windows Server 2008.

## Security, Servicing and IIS 7.0 and Above Setup Components

With IIS 6.0, the IIS team took the bold step of securing the Web server by default. This meant disabling ISAPI extensions and CGI components from running until the Administrator explicitly enabled those features on the server. In so doing, the potential attack surface changed dramatically between IIS 5.0, where all features were installed and enabled by default, and IIS 6.0, where only static file serving was allowed by default on a clean install of the Web server.

This change in philosophy did create a smaller default attack surface on the Web server, but it was far from perfect. While IIS 6.0 improved in many ways over its predecessor in terms of security, reliability and performance, it was still designed in a relatively monolithic fashion. This meant that while many optional features were disabled on installation, they were still installed and loaded into the Web server. These features also continued to consume CPU and memory and required patching and software updates, even though they were disabled. For example, the CGI feature of IIS 6.0 was always installed, whether or not it was ever used. If a software update for CGI became available, every IIS customer was required to install it, whether it was in use or not.

With IIS 7.0 and above, the IIS team has addressed this situation by making IIS a fully modular Web server, and by designing the setup to take full advantage of this high degree of modularity. With IIS 7.0 and above, not only are unneeded components disabled, but they are not even installed. This allows you to install just the modules for the IIS features that are needed, and only worry about servicing the set of components that you use. This makes it possible to deploy very thin, task-specific servers and to lock out unused functionality in a way never before possible.

<a id="Components"></a>

## IIS 7.0 and Above Components Overview

The following table summarizes all the installable component features of IIS 7.0 and above. The table also groups features into functional areas. These functional areas are used by the setup user interfaces such as Server Manager, as well as by the new command line and scripting tools. Each of the functional areas and feature components are explored in detail in the next section.


| **Setup Menu Items** | **Description** |
| --- | --- |
| **?** | Web Server | Installs the IIS Web Server. Provides support for HTML Web sites and optional support for ASP.NET, Classic ASP, and Web server extensions. |
|  | **?** | Common HTTP Features | Installs support for static Web server content such as HTML &amp; image files, custom errors, and redirection. |
|  |  |  |  | **?** | Static Content | Serves .htm, .html, and image files from a Web site. |
|  |  |  |  | **?** | Default Document | Allows you to specify a default file to be loaded when users do not specify a file in a request URL. |
|  |  |  |  | **?** | Directory Browse | Allow clients to see the contents of a directory on your Web server. |
|  |  |  |  | **?** | HTTP Errors | Installs HTTP Error files. Allows you to customize the error messages returned to clients. |
|  |  |  |  |  | HTTP Redirection | Provides support to redirect client requests to a specific destination. |
|  |  |  | Application Development | Installs support for application development such as ASP.NET, Classic ASP, CGI, and ISAPI extensions. |
|  |  |  |  |  | ASP.NET | Enables your Web server to host ASP.NET applications. |
|  |  |  |  |  | .NET Extensibility | Enables your Web server to host .NET framework-managed module extensions. |
|  |  |  |  |  | ASP | Enables your Web server to host Classic ASP applications. |
|  |  |  |  |  | CGI | Enables support for CGI executables. |
|  |  |  |  |  | ISAPI Extensions | Allows ISAPI extensions to handle client requests. |
|  |  |  |  |  | ISAPI Filters | Allows ISAPI filters to modify Web server behavior. |
|  |  |  |  |  | Server Side Includes | Provides support for .stm, .shtm, and .shtml include files. |
|  |  | **?** | Health &amp; Diagnostics | Enables you to monitor and manage server, site, and application health. |
|  |  |  |  | **?** | HTTP Logging | Enables logging of Web site activity for this server. |
|  |  |  |  |  | Logging Tools | Installs IIS logging tools and scripts. |
|  |  |  |  | **?** | Request Monitor | Monitors server, site, and application health. |
|  |  |  |  |  | Tracing | Enables tracing for ASP.NET applications and failed requests. |
|  |  |  |  |  | Custom Logging | Enables support for custom logging for Web servers, sites, and applications. |
|  |  |  |  |  | ODBC Logging | Enables support for logging to an ODBC-compliant database. |
|  |  |  | Security | Enables additional security protocols to secure servers, sites, applications, vdirs, and files. |
|  |  |  |  |  | Basic Authentication | Requires a valid Windows user name and password for connection. |
|  |  |  |  |  | Windows Authentication | Authenticates clients by using NTLM or Kerberos. |
|  |  |  |  |  | Digest Authentication | Authenticates clients by sending a password hash to a Windows domain controller. |
|  |  |  |  |  | Client Certificate Mapping Authentication | Authenticates client certificates with Active Directory accounts. |
|  |  |  |  |  | IIS Client Certificate Mapping Authentication | Maps client certificates 1-to-1 or many-to-1 to a Windows security identity. |
|  |  |  |  |  | URL Authorization | Authorizes client access to the URLs that comprise a Web application. |
|  |  |  |  |  | Request Filtering | Configures rules to block selected client requests. |
|  |  |  |  |  | IP Security | Allows or denies content access based on IP address or domain name. |
|  |  | **?** | Performance |  |
|  |  |  |  | **?** | Static Content Compression | Compresses static content before returning it to a client. |
|  |  |  |  |  | Dynamic Content Compression | Compresses dynamic content before returning it to a client. |
| **?** | Web Server Management Tools | Installs Web server management console and tools. |
|  |  | **?** | IIS Management Console | Installs Web server Management Console which supports management of local and remote Web servers. |
|  |  |  | IIS Management scripts and Tools | Manages a local Web server with IIS configuration scripts. |
|  |  |  | Management Service | Allows this Web server to be managed remotely from another computer via the Web server Management Console. |
|  |  |  | IIS 6 Management Compatibility | Allows you to use existing IIS 6.0 APIs and scripts to manage this IIS 7.0 and above Web server. |
|  |  |  |  |  | IIS Metabase and IIS 6 configuration compatibility | Installs IIS metabase and compatibility layer to allow metabase calls to interact with the new IIS 7.0 and above configuration store. |
|  |  |  |  |  | IIS 6 WMI Compatibility | Installs IIS 6.0 WMI scripting interfaces. |
|  |  |  |  |  | IIS 6 Scripting Tools | Installs IIS 6.0 configuration scripts. |
|  |  |  |  |  | IIS 6 Management Console | Installs the IIS 6.0 Management Console. Provides support for administration of remote IIS 6.0 servers from this computer. |
|  | FTP Publishing Service | Installs File Transfer Protocol (FTP) Service and FTP management console. Provides support for upload and download of files. |
|  |  |  | FTP Server | Installs FTP Service. |
|  |  |  | FTP Management Console | Installs FTP management console for administration of local and remote FTP servers. |


Key:


|  | Feature is not selected by default. |
| --- | --- |
| **?** | Feature is selected by default but has one or more non-selected sub-features. |
| **?** | Feature is selected by default - all, if any, sub-features are also selected. |


<a id="FeaturePack"></a>

## IIS 7.0 and Above Feature Packages

Installing IIS 7.0 and above via the Server Manager or Windows Features wizards only requires that you check the boxes for each feature that you require. When and if you need to install by using command-line scripts or unattended files, you must know the actual names of the IIS components in the IIS package that represent these features.


- Each IIS selectable feature in the Server Manager user interface corresponds to a specific update name in the IIS Package.
- To install IIS features by using the Pkgmgr.exe command-line tool or by using an OS unattend XML file, you will need to use the IIS feature update names.


### Package Updates

Each of the IIS features shown in the setup maps directly to an IIS package update. The top level IIS update in the package is IIS-WebServerRole. The next level of updates groups the three major feature areas within the IIS-WebServerRole. These are:

- IIS-WebServer
- IIS-WebServerManagementTools
- IIS-FTPPublishingService

Each of these groups contains one or more updates which have installable features.

### IIS-WebServer Updates

All Web server features are arranged in groups under the IIS-WebServer update:

- IIS-CommonHttpFeatures
- IIS-ApplicationDevelopment
- IIS-HealthAndDiagnostics
- IIS-Security
- IIS-Performance

Each of these groups contains one or more updates which have installable features.

### Common HTTP Features Updates

The IIS features grouped under Common HTTP Features provide support for static Web server content such as HTML and image files, custom errors, and redirection. These features are normally always installed with IIS, although you may choose to omit some or all of these features for special purpose configurations.

- IIS-CommonHttpFeatures 

    - IIS-StaticContent
    - IIS-DefaultDocument
    - IIS-DirectoryBrowsing
    - IIS-HttpErrors
    - IIS-HttpRedirect

### Application Development Updates

The Application Development update groups together features that support deployment of Web applications and dynamic content such as ASP.NET applications, Classic ASP applications, and ISAPI extensions and filters. Choose which, if any, of these features to install based on the types of applications you intend to deploy on your Web server.

- IIS-ApplicationDevelopment 

    - IIS-ASPNET
    - IIS-NetFxExtensibility
    - IIS-ASP
    - IIS-CGI
    - IIS-ISAPIExtensions
    - IIS-ISAPIFilter
    - IIS-ServerSideIncludes

### Health and Diagnostics Updates

The Health and Diagnostics updates groups together those features that enable logging, request monitoring, and diagnostics.

- IIS-HealthAndDiagnostics 

    - IIS-HttpLogging
    - IIS-LoggingLibraries
    - IIS-RequestMonitor
    - IIS-HttpTracing
    - IIS-CustomLogging
    - IIS-ODBCLogging

### Security Updates

The Security update groups together all of the authentication, authorization, and filtering features.

- IIS-Security 

    - IIS-BasicAuthentication
    - IIS-WindowsAuthentication
    - IIS-DigestAuthentication
    - IIS-ClientCertificateMappingAuthentication
    - IIS-IISCertificateMappingAuthentication
    - IIS-URLAuthorization
    - IIS-RequestFiltering
    - IIS-IPSecurity

Anonymous authentication is not optionally installable; it is always installed with any Web server features.

### Performance

The Performance update grouping includes the two compression updates for static and dynamic content.

- IIS-Performance 

    - IIS-HttpCompressionStatic
    - IIS-HttpCompressionDynamic

### Management Tools

The Web management tools groups together the IIS 7.0 and above management tools as well as the IIS 6.0 compatibility tools.

- IIS-WebServerManagementTools 

    - IIS-ManagementConsole
    - IIS-ManagementScriptingTools
    - IIS-ManagementService
    - IIS-IIS6ManagementCompatibility 

        - IIS-Metabase
        - IIS-WMICompatibility
        - IIS-LegacyScripts
        - IIS-LegacySnapIn

> [!NOTE]
> If you make use of scripts or applications that use the ABO or ADSI APIs, choose to install features from the IIS-IIS 6.0 ManagementCompatibility group to provide forward compatibility to IIS 7.0 and above for those management tools. At a minimum, you must install the IIS-Metabase update; if your scripts also use the IIS WMI provider, then also install the IIS-WMICompatibility update.

### FTP Publishing Service Updates

This update groups together the FTP server and FTP management console.

- IIS-FTPPublishingService 

    - IIS-FTPServer
    - IIS-FTPManagement

### Windows Process Activation Service Updates

Windows Process Activation Service (WAS) includes all of the necessary infrastructure needed to provide a base level of process activation and management as well as HTTP processing infrastructure.

- WAS-WindowsActivationService 

    - WAS-ProcessModel
    - WAS-NetFxEnvironment
    - WAS-ConfigurationAPI

All features grouped under the IIS-WebServer update depend on the WAS features, which must be installed whenever IIS-WebServer features are selected. When installing IIS from Server Manager or the Vista Windows Features Wizard, you do not have to make any explicit WAS selections.

<a id="Update"></a><a id="UpdateDep"></a>

## Update Dependencies

As you see in [Installing IIS 7.0 and Above on Windows Server 2008](installing-iis-7-and-above-on-windows-server-2008-or-windows-server-2008-r2.md)*,* installing IIS by using the Server Manager Add Roles Wizard also requires installation of WAS.

The Server Manager notifies you and installs required dependencies automatically. When installing package updates via command line or by using Unattend.xml, you will need to explicitly specify these dependencies.

### IIS Dependencies on WAS

All features under the update group IIS-WebServer have dependencies on the WAS features:

- WAS-WindowsActivationService 

    - WAS-ProcessModel
    - WAS-NetFxEnvironment
    - WAS-ConfigurationAPI

These three WAS updates are prerequisites for installing features in the IIS-WebServer update group.

### IIS 7.0 and Above Intra-Dependencies

Some IIS 7.0 and above features have dependencies on other versions of IIS. When installing IIS via user interfaces such as Server Manager, required dependencies are installed automatically. When installing package updates via command line or Unattend.xml, you must explicitly specify these dependencies. The IIS update intra-dependencies are summarized below:


| Update | Depends On |
| --- | --- |
| IIS-WebServer | WAS-ProcessModel– All leaf nodes under IIS-WebServer require this. |
| IIS-ASP | IIS-ISAPIExtensions IIS-RequestFiltering |
| IIS-ASPNET | IIS-DefaultDocument IIS-NetFxExtensibility WAS-NetFxEnvironment IIS-ISAPIExtensions IIS-ISAPIFilter IIS-RequestFiltering |
| IIS-NetFxExtensibility | WAS-NetFxEnvironment IIS-RequestFiltering |
| IIS-ManagementService | IIS-WebServer (Must have at least onechild selected) IIS-ManagementConsole WAS-NetFxEnvironment WAS-ConfigurationAPI |
| IIS-ManagementConsole | WAS-ConfigurationAPI |
| IIS-ManagementScriptingTools | WAS-ConfigurationAPI |
| IIS-LegacyScripts | IIS-Metabase IIS-WMICompatibility |


### IIS 7.0 and Above Parent Group Update Dependencies

Every IIS update has an implicit dependency on its parent group update. For example:

- IIS-StaticContent depends on IIS-CommonHttpFeatures.
- IIS-CommonHttpFeatures depends on IIS-WebServer.
- IIS-WebServer depends on IIS-WebServerRole.

Again, setup UI tools such as Server Manager handle this automatically, but when using command-line tools to install an update, you must also explicitly install all of the parent updates and any additional dependencies. Additional information about update dependencies is in the *Custom Installations* section *.*

<a id="Default"></a>

## Default Install of IIS 7.0 and Above

Each IIS update defines its default install behavior, which is used by setup user interfaces to determine which features are pre-selected. Click **Next** when you install by using a setup user interface. After you click Next, you will get a default install of IIS, which installs the following list of updates:

### IIS-WebServer

- IIS-CommonHttpFeatures
- IIS-StaticContent
- IIS-DefaultDocument
- IIS-DirectoryBrowsing
- IIS-HttpErrors

### IIS-HealthAndDiagnostics

- IIS-HTTPLogging
- IIS-RequestMonitor

### IIS-Performance

- IIS-HttpCompressionStatic

### IIS-WebServerManagementTools

- IIS-ManagementConsole

### WAS-WindowsActivationService

- WAS-ProcessModel
- WAS-ConfigurationAPI

Thus, the IIS default install provides a basic static content server with local administration and Anonymous authentication. For each IIS update installed, the default configuration for that module is added to ApplicationHost.config.

<a id="Upgrade"></a>

## IIS 7.0 and Above Upgrade

Upgrade of previous versions of IIS to IIS 7.0 and above issupported for both the Windows Vista and Windows Server 2008 as detailed below:

- Supported IIS / OS versions for Upgrade to Windows Server 2008 

    - IIS 6.0 on Windows Server 2003 (Not supported in Vista Beta 2)
- Supported IIS / OS versions for Upgrade to Windows Vista

    - IIS 5.1 on Win XP (Supported for Vista Beta 2)

Cross-machine migration of previous IIS versions to IIS 7.0 and above (for example, moving IIS Web sites to a new box) is not supported by Windows Vista or Windows Server 2008. The IIS team expects to provide an IIS migration tool which will allow you to move existing Web sites cross-machine to Windows Vista or Windows Server IIS 7.0 and above.

### Upgrade Steps

Windows Vista and Windows Server 2008 OS upgrade is preconfigured in three distinct phases: detect and gather, installation, and settings application. These steps only apply to OS features and settings. Any file system content not created or owned by Windows remains intact through the upgrade process. Thus, all Web content on the original OS is present after the upgrade.

### Detect &amp; Gather

During OS upgrade to Windows Vista or Windows Server 2008, IIS detection components run on the existing OS before actual OS upgrade begins. If IIS is detected on the existing Windows OS, all metabase and IIS state information is gathered and persisted.

### Installation

The installation phase consists of installing the Windows Vista or Server OS and then installing optional features such as IIS, if they were detected on the original OS. The choice of which IIS updates to install is based on the IIS state information gathered from the original OS.

### Applying Settings

After the OS installation and optional feature installations such as IIS have completed, the state information gathered from the original OS is applied. At this point, the metabase settings from the original IIS (5.0 or 6.0) are translated and updated into the new IIS 7.0 and above config store ApplicationHost.config.

<a id="ComponentsInstall"></a>

## IIS 7.0 and Above Components Installed During Upgrade

During the detect and gather phase, IIS upgrade checks for the presence of key IIS services and files and installs IIS updates per the following table:


| Down-level detection logic | IIS 7 and above Updates installed |
| --- | --- |
| W3SVC installed as a service | IIS-ASP IIS-BasicAuthentication IIS-CGI IIS-ClientCertificateMappingAuthentication IIS-CustomLogging IIS-DefaultDocument IIS-DigestAuthentication IIS-DirectoryBrowsing IIS-HttpCompressionDynamic IIS-HttpCompressionStatic IIS-HttpErrors IIS-HTTPLogging IIS-HttpRedirect IIS-HttpTracing IIS-IISCertificateMappingAuthentication IIS-IPSecurity IIS-ISAPIExtensions IIS-ISAPIFilter IIS-LegacyScripts IIS-LoggingLibraries IIS-ManagementScriptingTools IIS-ManagementService IIS-ODBCLogging IIS-RequestFiltering IIS-RequestMonitor IIS-ServerSideIncludes IIS-StaticContent IIS-URLAuthorization IIS-WindowsAuthentication IIS-WMICompatibility WAS-ConfigurationAPI WAS-NetFxEnvironment WAS-ProcessModel |
| MSFTPSVC installed as a service | IIS-FTPServer |
| INETMGR.EXE present | IIS-FTPManagement IIS-LegacySnapIn IIS-ManagementConsole |
| IISAdmin installed as a service | IIS-Metabase |


The installation of updates during an upgrade is not as granular as is possible in clean IIS installation scenarios, because previous versions of IIS had very limited component granularity. Consequently, almost all Web Server features are installed during an upgrade. You should, therefore, revisit your application dependencies on IIS functionality and uninstall IIS updates which are not needed after an upgrade.

<a id="MethodsInstall"></a>

## Methods of Installing IIS 7.0 and Above

There are four primary methods of IIS installation: Windows Optional Features user interfaces, command-line tool, unattended file, and upgrade. "How To" articles are provided for all scenarios except upgrade.

You must use different Windows user interfaces in Windows Vista and Windows Server 2008:

- In Windows Server 2008, use the Server Manager Tool.
- In Windows Vista (Client), use the Windows Add/Remove Windows Features Wizard.

The command line, unattended file, and upgrade scenarios are available on both Windows Vista and Windows Server 2008 Editions.

<a id="ServerMan"></a>

## Server Manager Tool

The Server Manager Tool provides the setup user interface on Windows Sever 2008 and replaces Manage Your Server in Windows Server 2003. The Server Manager also provides server role management dashboards for each installed role indicating installed state, current status, and management &amp; tasks.

The article [Installing IIS 7.0 and Above on Windows Server 2008](installing-iis-7-and-above-on-windows-server-2008-or-windows-server-2008-r2.md) provides you with a step-by-step walkthrough for installing IIS on Windows Server 2008 by using the new Server Manager tool.

[![](understanding-setup-in-iis/_static/image2.jpg)](understanding-setup-in-iis/_static/image1.jpg)  
Figure 1: Server Manager

<a id="AddRemove"></a>

## Add/Remove Windows Features Wizard

On Windows Vista, optional features are installed when you use the Add/Remove Windows Features Wizard, which is similar in functionality to the Windows XP Add/Remove Windows Components Wizard. The Windows Features Wizard provides the same selectable IIS features as are presented in the Server Manager Tool.

The article [Installing IIS 7.0 and Above on Windows Vista](installing-iis-on-windows-vista-and-windows-7.md) provides a step-by-step walkthrough for installing IIS on Windows Vista.

[![](understanding-setup-in-iis/_static/image4.jpg)](understanding-setup-in-iis/_static/image3.jpg)  
Figure 2: Add/Remove Windows Features Wizard

<a id="CommandLine"></a>

## Command Line Install of IIS

New in Windows Vista and Windows Server 2008 is the Pkgmgr.exe command line tool. Pkgmgr is used to install and uninstall Windows optional features and replaces Sysocmgr.exe. The article [Install IIS 7.0 and Above from the Command Line](installing-iis-from-the-command-line.md) provides a step-by-step walkthrough of installing IIS on Windows Vista or Windows Server 2008 by using the pkgmgr tool.

<a id="CommandUnatt"></a>

## Command Line Unattended Setup

Pkgmgr.exe also can accept input form an unattend.xml file. Use this file to list updates to be installed or uninstalled. The article [Installing IIS 7.0 and Above via Unattended Setup](using-unattended-setup-to-install-iis.md) provides a step-by-step walkthrough of installing IIS on Windows Vista or Windows Server 2008 by using an unattend file and the Pkgmgr tool.

<a id="CustomInstall"></a>

## Custom Installations

Each of the four walkthroughs described in the previous section provide step-by-step instructions for installing all of the IIS features. Installing all IIS features is required if you intend to try some of the other IIS feature walkthroughs on https://www.iis.net, but is not recommended for real-world development or deployment scenarios.

When planning an installation of IIS for your development or deployment environments, you should install only the features required by your applications. Minimizing the IIS components installed in this manner has several benefits:

- Improved performance by reducing the number of pipeline modules that are loaded into memory.
- Improved security by reducing the number of IIS components that require administration.
- Improved security by reducing the number of components that could potentially be exploited.
- Improves your understanding of application dependencies on IIS modules.

<a id="Planning"></a>

## Planning Considerations for Custom Installations

Begin your IIS deployment planning by breaking down required features into three major areas: IIS 6.0 Management Compatibility, Web Management, FTP Server, and Web Server. Each of these is reviewed in the following sections.

### IIS 6.0 Management Compatibility

Previous versions of IIS used APIs and WMI providers to read and write metabase settings. These APIs are not part of the IIS 7.0 and above default installation and must be explicitly selected for install.

If you have scripts or applications that depend on IIS APIs such as ABO or ADSI, or the IIS 6.0 WMI providers, then include the following IIS package updates in your installation:

- IIS-Metabase
- IIS-WMICompatibility

Many of the IIS 6.0 scripts can also be installed by using this update:

- IIS-LegacyScripts

> [!NOTE]
> The IIS 6.0 Management Console that can be installed via the update IIS-LegacySnapIn does not allow you to use the IIS 6.0 MMC Management Console to manage the IIS 7.0 and above Web server. The IIS 6.0 Management Console is provided to allow you to manage IIS 6.0 Web servers hosting Windows Server 2003.

### Web Management

With IIS, you have several choices on how your Web server will be managed. You can choose remote management only, local management only, or install support for both. The local management console is installed by the IIS package update IIS-ManagementConsole. For remote management, you must install the IIS-ManagementService update. The Management Service allows you to connect to an IIS Web server from a Management Console installed on a different machine from your server.

### FTP Server

FTP Server considerations are unchanged from previous versions of IIS. To install only the FTP service, without local management, use the IIS-FTPServer update. To install the local management console for FTP server use the IIS-FTPManagement update.

### Web Server

Here, things become more interesting: the IIS Web Server feature has the highest level of installable granularity of all IIS features. As explained in the previous discussion of IIS package updates, there are five major groupings of features within the Web Server feature area:

- IIS-CommonHttpFeatures – Provides basic support for HTTP static content and error messages.
- IIS-ApplicationDevelopment – Provides support for application extensions of the IIS Web Server.
- IIS-HealthAndDiagnostics – Provides support for logging, runtime status, and request tracing.
- IIS-Security – Provides additional authentication and authorization facilities beyond anonymous authentication.
- IIS-Performance – Provides static and dynamic content compression.

The IIS features within each of these groups were discussed above in the *IIS Package Updates* section *.* You should review your server application needs and choose only those Web Server features that you must have.

### Custom Installation Example

For this example, we consider configuring a hypothetical Web server with the following attributes:

1. Need support for static content but do not want to allow directory browsing.
2. Need support for logging and runtime status.
3. Need support for ASP.NET.
4. Need to support remote management.
5. Need support for Windows authentication.
6. Need support for static and dynamic content compression.

We will also add an additional requirement that the installation be deployable to multiple servers as a script.

Now we use this list of required functionality and the update descriptions in the *IIS Package Updates* section to determine which of the IIS package updates will we need.

### Step 1: Determine Required Updates

For item 1, we need the following updates:

- IIS-StaticContent
- IIS-DefaultDocument
- IIS-HttpErrors
- IIS-HttpRedirect

We also want to insure that IIS-DirectoryBrowsing is not installed (since it is part of a default install, see sec. 4.)

For item 2, we need the following updates:

- IIS-HTTPLogging
- IIS-RequestMonitor

For item 3, we need the IIS-ASPNET update.

For item 4, we need the IIS-ManagementService.

For items 5, we need the IIS-WindowsAuthentication update.

And finally, for item 6, we need the IIS-HttpCompressionStatic and IIS-HttpCompressionDynamic updates.

At this point, we have the information we need in order to use the setup user interface tools and to check the components we need and uncheck the wones we do not require. But since we intend to deploy this Web server configuration to multiple servers, we must create a script that gives us the required package configuration. As discussed in the *IIS Package Updates* section *,* our scripts must explicitly declare any parent and/or feature updates dependencies for feature updates we wish to install.

Taking dependencies one item at a time, the following section describes requred actions for this process.

### Step 2: Determine Parents and Dependencies

For item 1, we need the following parent updates:

- IIS-WebServerRole
- IIS-WebServer
- IIS-CommonHttpFeatures

> [!NOTE]
> All leaf feature updates of the Web Server have the IIS-WebServer and IIS-WebServerRole parents in common.

For item 1, we also see from section *IIS Dependencies on WAS* that we must add the following WAS updates:

- WAS-WindowsActivationService
- WAS-ProcessModel

> [!NOTE]
> All updates under IIS-WebServer share a dependency on these WAS updates.

For item 2, the parent update is: IIS-HealthAndDiagnostics. Both of the above Notes apply here.

For item 3, the parent update is: IIS-ApplicationDevelopment. Both of the above Notes apply here. Looking at the section *IIS Intra-Dependencies,* we see that IIS-ASPNET depends on the following updates:

- IIS-DefaultDocument
- IIS-NetFxExtensibility
- WAS-NetFxEnvironment
- IIS-ISAPIExtensions
- IIS-ISAPIFilter
- IIS-RequestFiltering

For item 4, the parent update is: IIS-WebServerManagementTools. (Neither of the notes above apply here.) The *IIS Intra-Dependencies* section further explains that IIS-ManagementService depends on the following updates.

- IIS-ManagementConsole
- WAS-NetFxEnvironment
- WAS-ConfigurationAPI

For item 5, the parent update is: IIS-Security. (Neither of the notes above apply here.)

For item 6, the parent update is IIS-Performance. (Neither of the notes above apply here.)

### Step 3: Group Updates within Parents

Now we take the list of required updates with their parent and dependencies and group them in the following list, regrouping updates with their parents as necessary. We will also merge in those updates that we want to ensure are not installed, and mark them with an asterisk ('\*'):

- IIS-WebServerRole
- IIS-WebServer
- IIS-CommonHttpFeatures
- IIS-StaticContent
- IIS-DefaultDocument
- IIS-DirectoryBrowsing\*
- IIS-HttpErrors
- IIS-HttpRedirect
- IIS-ApplicationDevelopment
- IIS-ASPNET
- IIS-NetFxExtensibility
- IIS-ISAPIExtensions
- IIS-ISAPIFilter
- IIS-HealthAndDiagnostics
- IIS-HTTPLogging
- IIS-RequestMonitor
- IIS-Security
- IIS-WindowsAuthentication
- IIS-RequestFiltering
- IIS-Performance
- IIS-HttpCompressionStatic
- IIS-HttpCompressionDynamic
- IIS-WebServerManagementTools
- IIS-ManagementConsole
- IIS-ManagementService
- WAS-WindowsActivationService
- WAS-ProcessModel
- WAS-NetFxEnvironment
- WAS-ConfigurationAPI

### Step 4: Put List of Updates in Unattend.xml File

In this step, instead of installing all IIS features, we only install the ones we need for our exercise and set the tag attribute state="**false**" for those updates that are normally installed by default. The resulting Unattend.xml file is shown below.

[!code-xml[Main](understanding-setup-in-iis/samples/sample1.xml)]

<a id="Summary"></a>

## Summary

New in Windows Vista and Windows Server 2008 setup:

- Windows Server 2008 setup is now based on declarative components that use manifests.
- OS versions are assembled from these components.
- Sysocmgr.exe is now replaced by Pkgmgr.exe for optional feature install.
- Same version of IIS is on both Windows Vista and on Windows Server 2008 Editions.
- Secure servers enabled via setup – With IIS, not only are unneeded components disabled, but they are not even installed.

Multiple ways to install IIS 7.0 and above:

- Server – Role Management Tool
- Vista – Add/Remove Windows Features
- Unattend – Unattend.xml file referencing IIS manifests
- Upgrade – In place OS upgrade to IIS

Significant new advantages of component-based setup for IIS:

- IIS uses Windows components to install only the modules you need.
- Installed modules use secured defaults and are locked down.
- IIS presents a reduced attack surface and simplified servicing.

## Related Links

See the following resources for further information:

- [Installing IIS 7.0 and Above on Windows Server 2008](installing-iis-7-and-above-on-windows-server-2008-or-windows-server-2008-r2.md)
- [Installing IIS 7.0 and Above on Windows Vista](installing-iis-on-windows-vista-and-windows-7.md)
- [Installing IIS 7.0 and Above from the Command Line](installing-iis-from-the-command-line.md)
- [Using Unattended Setup to Install with IIS 7.0 and Above](using-unattended-setup-to-install-iis.md)