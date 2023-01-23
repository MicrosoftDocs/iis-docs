---
title: "Compatibility and Feature Requirements for Windows Vista"
author: tobint
description: "Internet Information Services 7.0 (IIS 7.0) and above is the Web server platform for the Windows Vista™ operating system. IIS 7.0 and above introduces many c..."
ms.date: 11/22/2007
ms.assetid: 5b18facf-650f-43ef-b78a-df8a9bebed75
msc.legacyurl: /learn/install/installing-iis-7/compatibility-and-feature-requirements-for-windows-vista
msc.type: authoredcontent
---
# Compatibility and Feature Requirements for Windows Vista

by [Tobin Titus](https://github.com/tobint)

## Introduction

Internet Information Services 7.0 (IIS 7.0) and above is the Web server platform for the Windows Vista™ operating system. IIS 7.0 and above introduces many changes from earlier versions of IIS. These changes can affect the way users interact with IIS either because innovations (some causing breaking changes) may not be obvious to the user or because IIS 7.0 and above have eliminated features that users of earlier versions may expect to find.

<a id="Breaking"></a>

## Breaking Changes in IIS 7.0 and Above

This section describes the known breaking changes in IIS 7.0 and above.

### Migrating Applications or Tools That Require the Metabase

Previous versions of IIS used the metabase to configure Web servers and sites, whereas IIS 7.0 and above use an XML configuration file to configure these settings. Although the metabase is no longer used to configure IIS 7.0 and above, a metabase compatibility feature is available to make IIS 7.0 and above compatible with APIs that relied on the metabase. This feature supports the Admin Base Objects (ABO) interface (also known as IMSAdminBase), Active Directory Service Interfaces (ADSI), and the WMI providers that were built on top of ABO in IIS 6.0.

By default, IIS 7.0 and above does not install the metabase compatibility feature. For more information on how to install the metabase compatibility feature, see [Configuration Compatibility](https://go.microsoft.com/fwlink/?LinkId=78483) on IIS.NET.

### Metabase Compatibility Considerations

You should be aware of the following metabase-related issues:

- IIS 7.0 and above use a new configuration scheme to store and save settings.
- The metabase is not part of this new configuration scheme.
- The metabase compatibility feature provides basic access to the new configuration store via the existing metabase APIs and tools, including ADSI and WMI.
- Some features from previous versions of IIS are not supported.

For more information, see Compatibility Limitations at IIS.NET.

<a id="InstallIssues"></a>

## IIS 7.0 and Above Installation Issues

The default installation for IIS 7.0 and above have changed significantly. Automated installations have also changed.

### Default Windows Vista Installation

IIS is not installed on Windows Vista by default. The default installation of IIS 7.0 and above provides a minimum-footprint Web server that supports Anonymous authentication and serves static files. Additional features and functionality, such as those that add support for Web development, for example, can explicitly be selected during setup.

For more information about installing IIS on Windows Vista, see [Install IIS 7.0 and Above on Windows Vista](installing-iis-on-windows-vista-and-windows-7.md) at IIS.NET. For a complete list of features for each addition of Windows Vista, see the [IIS 7.0 and Above Features and Vista Editions](iis-features-and-vista-editions.md) article on IIS.net.

### Automated Installation of IIS

For more information about automated install, see [Using Unattend Setup to Install IIS 7.0 and Above](using-unattended-setup-to-install-iis.md) at IIS.NET and [Windows Automated Installation Kit (WAIK) User's Guide for Windows Vista](https://go.microsoft.com/fwlink/?LinkId=63893) at the Microsoft Web site.

### Changing the Location of Web Root During Installation

IIS 7.0 and above setup does not re-target the \inetpub folder, which is always be installed in %SysDrive%\inetpub. After installing IIS you can, of course, move \inetpub and change the default Web site to point to that new location.

<a id="Migrating"></a>

## Migrating ASP.NET Applications to IIS 7.0 and Above

IIS 7.0 and above integrates the ASP.NET runtime extensibility model with the core Web server. This integration enables developers to extend the IIS server by using the power of ASP.NET 2.0 and the .NET Framework, instead of using the less robust IIS C++ APIs. Existing ASP.NET applications also immediately benefit from tighter integration by being able to use existing ASP.NET features such as Forms Authentication, Roles, and Output Caching for all kinds of content.

For more information about the ASP.NET integration in IIS and about migrating existing applications, see ASP.NET Integration with IIS 7.0 and Above on IIS.NET. For more information about breaking changes associated with ASP.NET, see [Upgrading ASP.NET Applications to IIS 7: Configuring Applications After Upgrade and Differences Between IIS 7.0 Integrated Mode and ISAPI Mode](https://go.microsoft.com/fwlink/?LinkId=77939) on the ASP.NET site.

<a id="Using"></a>

## Using the IIS 6.0 MMC Snap-in with IIS 7.0 and Above

The IIS 6.0 MMC snap-in, IIS 6.0 Manager, is available on Windows Vista. Use IIS 6.0 Manager for remote management of IIS 6.0 Web servers or sites from an IIS 7.0 and above Web server. You cannot use IIS 6.0 Manager or IIS 7.0 and above Manager for remote administration of IIS 7.0 and above Web servers or sites.

You must use IIS 6.0 Manager to manage FTP sites on both remote IIS 6.0 servers and Windows Vista. The IIS 7.0 and above MMC snap-in does not include an FTP management feature.

## Existing MMC Snap-ins for IIS 6.0

Existing MMC snap-ins do not work with the IIS 7.0 and above Server Manager. For example, in IIS 7.0 and above you cannot use the ASP.NET snap-in extension introduced in IIS 6.0. Fortunately, the IIS 7.0 and above administration tool lets you configure most ASP.NET settings through the user interface.

For more information about how you can extend the IIS 7.0 and above user interface, see [Creating a Simple UI Module](https://go.microsoft.com/fwlink/?LinkId=78491) and [IIS 7.0 and Above End-to-End Extensibility Example](https://go.microsoft.com/fwlink/?LinkId=78492) on IIS.NET.

<a id="ASP"></a>

## ASP and Microsoft Access Database Failures

Applications that use ASP and a Microsoft Access database will fail when you upgrade to Windows Vista. You will see the following error message:

**Microsoft JET Database Engine error '80004005'**  
**Unspecified error**

This failure is often a permission issue caused when the process identity cannot access the temporary directory. In IIS 6.0, all worker processes used `C:\Windows\Temp` as the temporary directory, regardless of the configuration of the process identity. In fact, because none of the worker processes in IIS 6.0 used their user profiles, Windows allowed all users access to this directory.

This configuration forced the default behavior to be such that all application pools share the same temporary directory. IIS 7.0 and above offers a better solution to this potential security problem by loading the user profile for all application pools. Also by default, the temporary directory now in use is not writeable by anyone other than the process identity, which is NetworkService.

To resolve this issue, change the discretionary access control list (DACL) on the NetworkService temporary directory to allow users access. This change gives you the benefit of loading a user profile while you separate temporary directories by application pool.

[!code-console[Main](compatibility-and-feature-requirements-for-windows-vista/samples/sample1.cmd)]

These commands allow every user to create files and directories (WD = Write to Directory, AD = Add Directory, X = Execute, S = Synchronize). The user who creates these files and directories is the "CREATOR OWNER."

The "CREATOR OWNER" access control entry (ACE) allows this user all levels of permissions with this file. Other users cannot access these files or directories because they are not the "CREATOR OWNER."

An additional workaround for this security problem is to disable the loadUserProfile setting on a per-application pool basis. Because loadUserProfile is a Boolean property on an AppPool section, you can easily configure this setting (for defaultAppPool) by using the following command:

[!code-console[Main](compatibility-and-feature-requirements-for-windows-vista/samples/sample2.cmd)]

<a id="URL"></a>

## URL Authorization

IIS and ASP.NET have used various schemes for authorization using URLs. One of these implementations is discontinued and there are important differences between the remaining two implementations.

IIS 6.0 URL authorization was implemented as an ISAPI extension. IIS 7.0 and above does not support this implementation. Read more about [IIS 6.0 URL Authorization](/iis/get-started/whats-new-in-iis-7/changes-in-security-between-iis-60-and-iis-7-and-above#ssl) on the Microsoft TechNet site.

By default, ASP.NET uses an implementation of URL Authorization that applies only to managed content. By removing the managedHandler precondition from the urlauthorization module, you can make it apply for all content, but there may be a performance penalty. Read more about [ASP.NET URL Authorization](/previous-versions/aspnet/wce3kxhd(v=vs.100)) on the MSDN site.

By default, IIS 7.0 and above uses an implementation of URL Authorization that applies to all content. This is the recommended URL Authorization implementation in IIS 7.0 and above. Read more about [configuring IIS URL Authorization rules](https://go.microsoft.com/fwlink/?LinkId=78496) on the Microsoft TechNet site.

<a id="FrontPageNot"></a>

## FrontPage Server Extensions Not Supported

At this time, FrontPage Server Extensions (FPSE) are not supported on Windows Vista. If you use FPSE to upload files to a Web server, consider using FTP with IIS 7.0 or above.

If you do upgrade from Microsoft Windows XP® to Windows Vista, and you already have FPSE installed, IIS 7.0 and above disables the World Wide Web Publishing Service (W3SVC). For more information, see [Upgrading Microsoft Windows XP to Windows Vista](../../manage/configuring-security/using-encryption-to-protect-passwords.md) later in this document.

## WebDAV Not Supported

At this time, Web Distributed Authoring and Versioning (WebDAV) is not supported on Windows Vista. If you use WebDAV to upload files to a Web server, consider using FTP with IIS 7.0 or above.

## NNTP Not Supported

NNTP is not supported on Windows Vista.

<a id="NoWizard"></a>

## There Is No Wizard for Manipulating Certificate Trust Lists

You cannot use the IIS 7.0 and above user interface to create a Certificate Trust List (CTL). Follow these steps to create a CTL with IIS 7.0 or above.

1. Use MakeCTL.exe to create the CTL. For more information on MakeCTL.exe, see the [MakeCTL](https://msdn.microsoft.com/library/aa386969.aspx) page on the MSDN site.  
  
   The MakeCTL.exe tool is part of the [.NET Framework SDK Version 1.1](https://go.microsoft.com/fwlink/?LinkId=50870). Once you install the SDK, MakeCTL.exe appears in the following location:  

    [!code-console[Main](compatibility-and-feature-requirements-for-windows-vista/samples/sample3.cmd)]
2. After you create the CTL, you must run AdsUtil.vbs to assign the CTL identifier to the name used in MakeCTL.exe.   

    [!code-console[Main](compatibility-and-feature-requirements-for-windows-vista/samples/sample4.cmd)]

   where *\<Name of CTL>* is the friendly name for the CTL used in MakeCTL.exe.
3. Run adsUtil.vbs to set the SslCtlStoreName.  

    [!code-console[Main](compatibility-and-feature-requirements-for-windows-vista/samples/sample5.cmd)]
4. After you have run AdsUtil.vbs, stop Web services by using the following command:  

    [!code-console[Main](compatibility-and-feature-requirements-for-windows-vista/samples/sample6.cmd)]
5. Restart the WS3SVC service by using the following command:  

    [!code-console[Main](compatibility-and-feature-requirements-for-windows-vista/samples/sample7.cmd)]

<a id="DigestNot"></a>

## Digest Authentication Not Supported with Windows 2000 Server Domain Controllers

Use Digest authentication only if the Windows domain controller is Microsoft Windows Server® 2003 or the Microsoft Windows Server® 2008 operating system.

IIS 6.0 introduced Advanced Digest authentication, which does not work with a Microsoft Windows® 2000 server domain controller. This is now the only implementation of Digest authentication available in IIS 7.0 and above.

IIS 5.x required a component called sub-authentication (iissuba.dll) for its implementation of Digest authentication. In previous versions of IIS, sub-authentication enabled IIS to manage passwords, which posed a security risk. For this reason, sub-authentication is not supported in IIS 7.0 or above.

<a id="ConvlogNot"></a>

## Convlog.exe Not Supported

This tool is discontinued. Consider creating a simple LogParser script that converts log files to the NCSA log file format. For more information, see [Converting W3C log files to NCSA format](https://go.microsoft.com/fwlink/?LinkId=78516).

## Content Rating User Interface No Longer Supported

The content rating system enables server administrators to rate content based on the amount of violence, sex, nudity, and foul language found in a site's content. This rating inserted a response header into the HTTP response, indicating the level of these types of content. Although the content rating user interface is no longer available, you can insert these response headers manually by using the HTTP Response Headers feature.

Although there is no IIS 7.0 and above UI for HTTP Response Headers, you can still use this feature by directly editing the XML configuration file, using WMI or Appcmd.exe. For more information about HTTP Response Headers, see [IIS 7.0 Beta: Configuring HTTP Response Headers in IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=78497) on the Microsoft TechCenter site.

<a id="ClusterAdmin"></a>

## IIS Cluster Administration Tool Extension

The support for clustering IIS 4.0 and IIS 5.x by using the IIS Cluster Administration Tool Extension (iisclex4.dll) is discontinued. You will not be able to administer IIS 4.0 and IIS 5.x by using the Cluster Administration Tool. IIS 7.0 and above continues to ship two scripts (Clusweb.vbs and Clusftp.vbs) that can be plugged into the Cluster Administration Tool to monitor changes to the FTP and W3SVC services. Consider using Microsoft Windows Server 2003 to manage clusters.

## SSINC EXEC CMD Command

The SSINC EXEC CMD commands let you run an arbitrary command-line path from a Web page. In IIS 6.0, you had to edit the registry to enable this feature. However, in IIS 7.0 and above the registry key that enabled this feature has been removed. Use ASP.NET, ASP, or CGI to run command-line paths from a Web page.

<a id="PassportNo"></a>

## Passport Network Credentials No Longer Supported

Passport Network credentials is a cookies-based authentication service. Support for Passport Network credentials is no longer built into IIS. For more information, see the Passport Network documentation located at `http://www.passport.com`. To access the documentation, you must register and get Passport Network credentials.

## Internet Data Connector (HTTPODBC.DLL) Not Supported

Internet Data Connector is a Web server extension that enables applications to query Open Database Connectivity (ODBC) databases. Use ASP.NET or ASP to query ODBC databases.

<a id="MetabaseAcct"></a>

## Metabase Account Recreation

In the past, IIS re-created accounts for anonymous users (IUSR\_*computername*) and worker processes (IWAM\_*computername*), if they did not exist during startup of the IISAdmin service. This presents a potential security issue. IIS 7.0 and above uses accounts which cannot be deleted so there is no reason to continue support of account re-creation.

## IISRESET

IISrestart no longer supports computer restarts.

<a id="VBSTool"></a>

## IIS\*.VBS Command-line Tools

In IIS 6.0, these tools appeared in systemroot\system32. In IIS 7.0 and above, however, the following tools are now obsolete:

- Iisapp.vbs
- Iiscnfg.vbs
- Iisftp.vbs
- Iisftpdr.vbs
- Iisback.vbs
- Iisrepl.vbs
- Iisvdir.vbs
- Iisweb.vbs

Appcmd.exe is the primary command-line tool for IIS 7.0 and above. For more information about Appcmd.exe, see [Overview of Command Line Administration - Appcmd.exe](https://go.microsoft.com/fwlink/?LinkId=78510) on IIS.NET.

<a id="Pause"></a>

## Pause Web Sites

IIS 5.x allowed users to pause a Web site. A new feature in Windows Vista allows users to pause, or stop, a Web site in the same manner, so the pause function is no longer included in IIS 7.0 or above.

<a id="WebSharing"></a>

## Web Sharing Extension

The Web Sharing Extension allowed customers to create virtual directories from Windows Explorer in IIS 6.0. This feature has been deprecated.

## Server-side Image Maps

Server-side image maps support image mapping for client browsers earlier than Internet Explorer 3. Server-side images are no longer supported.

## ASP Content Rotator and Nextlink

These features are deprecated and are no longer available.

<a id="FeaturesOnly"></a>

## Features That Are Configurable Only by Using XML Configuration Files

Most of the issues listed below involve features have no IIS 7.0 or above user interface (UI). Even if there is no IIS 7.0 or above UI for a particular feature, you can still configure it; typically this is done by manually editing the XML configuration files.

| New or updated feature | New way to work with this feature |
| --- | --- |
| Client Certificate Mapping | Although this feature is not in the IIS 7.0 or above UI, you can still use this feature by directly editing the XML configuration file, using WMI or Appcmd.exe. For more information about Client Certificate Mapping, see [IIS 7.0 Beta: Configure Client Certificate Mapping Authentication](https://go.microsoft.com/fwlink/?LinkId=78498) at the Microsoft TechCenter site. |
| FTP | Although there is no IIS 7.0 or above UI for FTP, you can use the IIS 6.0 MMC for managing FTP on Windows Vista. For more information about FTP, see [IIS 7.0 Beta: Set Up FTP in IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=78499) at the Microsoft TechCenter site. |
| IP and Domain Restrictions | Although this feature is not in the IIS 7.0 or above UI, you can still use this feature by directly editing the XML configuration file, using WMI or Appcmd.exe. For more information about IP and Domain Restrictions, see [IIS 7.0 Beta: Configuring Content Access Based on IP Address and Domain Name](https://go.microsoft.com/fwlink/?LinkId=78571) at the Microsoft TechCenter site. |
| URLScan | Instead of URLScan, consider using Request Filtering to block expressions. Although there is no IIS 7.0 or above UI for URLScan, you can still use this feature by directly editing the XML configuration file, or using Appcmd.exe. For more information about Request Filtering, see [IIS 7.0 Beta: Filter HTTP Requests in IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=78501) at the Microsoft TechCenter site. Although Request Filtering deprecates URLScan and does not make it obsolete, the installer for URLScan version 2.5 does not work on Windows Vista. To work around this issue, copy Urlscan.dll and Urlscan.ini to the Web server that is running IIS 7.0 or above and then set up Urlscan.dll as a global ISAPI filter in IIS. |
| Logging | Although there is no IIS 7.0 or above UI for configuring logging, you can still use this feature by directly editing the XML configuration file, using WMI or Appcmd.exe. For more information about configuring logging, see [IIS 7.0 Beta: Configuring Logging in IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=78502) at the Microsoft TechCenter site. |
| HTTP Compression | Although this feature is not in the IIS 7.0 or above UI, you can still use this feature by directly editing the XML configuration file, using WMI or Appcmd.exe. For more information about configuring HTTP compression, see [IIS 7.0 Beta: Configuring HTTP Compression in IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=78503) at the Microsoft TechCenter site. |
| Redirection | Although there is no IIS 7.0 or above UI for configuring redirection, you can still use this feature by directly editing the XML configuration file, using WMI or Appcmd.exe. For more information about configuring redirection, see [IIS 7.0 Beta: Configuring Redirection in IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=78504) at the Microsoft TechCenter site. |
| Document footers | Although there is no IIS 7.0 or above UI for creating document footers, you can still use this feature by directly editing the XML configuration file, using WMI or Appcmd.exe to change certain attributes for the staticContent element. For more information about Creating document footers, see [IIS 7.0 Beta: Configuring MIME Types in IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=78364) at the Microsoft TechCenter site. |
| HTTP Response Headers | Although this feature is not in the IIS 7.0 or above UI, you can still use this feature by directly editing the XML configuration file, using WMI or Appcmd.exe. For more information about HTTP response headers, see [IIS 7.0 Beta: Configuring HTTP Response Headers in IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=78497) at the Microsoft TechCenter site. |
| Ordering ISAPI Filters | There is an IIS 7.0 and above UI for adding and removing ISAPI filters, but you cannot use it to order ISAPI filters. You can order ISAPI filters by directly editing the XML configuration file. For more information about how to configure ISAPI filters, see [IIS 7.0 Beta: Configuring ISAPI Filters in IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=78505) at the Microsoft TechCenter site. |

<a id="Upgrading"></a>

## Upgrading Microsoft Windows XP to Windows Vista

When upgrading from Microsoft Windows XP to Windows Vista or from one Windows Vista SKU to another SKU, it is possible that data from the previous installation of IIS can be lost or copied incorrectly. If this happens, no error message appears, but certain IIS features may not function correctly. For this reason, we recommend backing up IIS configurations before upgrading your operating system.

Once the upgrade is complete, investigate the log files to determine whether there were any errors during setup. You can find the logs here: 

[!code-console[Main](compatibility-and-feature-requirements-for-windows-vista/samples/sample8.cmd)]

[!code-console[Main](compatibility-and-feature-requirements-for-windows-vista/samples/sample9.cmd)]

### IIS 7.0 and Above Web Services Disabled on Upgrade

There are two issues that could cause IIS 7.0 and above setup to disable the World Wide Web Publishing Service (W3SVC) or the FTP Publishing Service (MSFTPSVC).

### Front Page Server Extensions Installed

If you upgrade from Microsoft Windows XP to Windows Vista with Front Page Server Extensions (FPSE) installed, IIS 7.0 and above setup disables W3SVC. This prevents unintended access to files where FrontPage stores metadata for your Web site. IIS 7.0 and above does not remove any files or folders from your Web site during an upgrade. You must manually remove or secure these files before you enable the Web service.

For more information about how to accomplish this task, see [IIS 7.0 and above is disabled on upgrade when the FrontPage Server Extensions were installed](../../publish/frontpage-server-extensions/upgrade-issues-with-frontpage-server-extensions.md) on IIS.NET.

### IIS 7.0 and above Lockdown Tool Never Installed

If you are upgrading from Microsoft Windows XP to Windows Vista without previously having installed any version of the IIS Lockdown Tool, IIS setup disables W3SVC and MSFTPSVC. This prevents unintentionally running a Web server that uses configurations that are not secure. During an upgrade, IIS 7.0 and above maintains all previous IIS configurations and settings. This can result in a Web server that is less secure than a Web server that uses the default Windows Vista configurations.

Before you enable these services, inspect your server default settings for possible security issues. In particular, pay attention to any ISAPI extensions you may have migrated but do not need any more.

<a id="EnableW3"></a>

## To Enable W3SVC or MSFTPSVC

After you have dealt with the issues mentioned above, you must enable any IIS 7.0 and above services that were disabled on upgrade.

To enable services, follow these steps:

1. From the **Start** menu, click **Control Panel**.
2. In **Control Panel**, click **Administrative Tools** and then click **Services**.
3. In the Services MMC, right-click the service and select **Start**.

### IIS 6.0 Management Console Not Installed

If you upgrade from Microsoft Windows XP to Windows Vista and you previously had the IIS 6.0 Management console installed but W3SVC was not detected during installation, IIS 7.0 and above setup does not install any IIS management console.

Presumably, you were using this computer to remotely manage an IIS 6.0 Web server. To install the IIS 6.0 Management console, use Control Panel in Windows Vista to turn on the **IIS 6.0 Management Console**.

### FTP Server Removed

If you upgrade from Microsoft Windows XP to Windows Vista and you previously had FTP installed but W3SVC was not detected during installation, IIS 7.0 and above setup does not install FTP. Your previous FTP server is un-installed. Your FTP configuration is lost.

If you want to use this computer as an FTP server, you must re-install the FTP service. To install the FTP server, use Control Panel in Windows Vista to turn on the **FTP Publishing Service**.

<a id="AppIso"></a>

## Application Isolation Migration

IIS setup automatically migrates IIS 5.x applications to run in Worker Process Isolation Mode, which uses more conservative settings than did previous versions of IIS. After the migration, there is some potential for problems with access. To resolve these problems, grant the process identity more NTFS privileges than it previously had, for objects like files or directories.

The process identity used depends upon the level of isolation previously being used in IIS5.x.

- **IIS 5.x Application Protection setting of Low**: Your migrated application would appear in an application pool named AppPool\_Low using the Network Service process identity. Previously this application ran as LocalSystem, a process identity with much higher privileges.
- **IIS5.x Application Protection setting of Medium**: Your migrated application would appear in an application pool named AppPool\_Medium using the process identity of whatever account was stored in the WAMUserName for the first migrated application that ran with the setting of Medium. By default, the process identity was set to the IWAM\_*computername*, but users could change this account. Therefore, if the account was changed, the application pool used whatever account was being used.
- **IIS5.x Application Protection setting of High**: Your migrated application would appear in an application pool named AppPool\_*applicationName*, where *applicationName* is the value for AppFriendlyName of your application. The process identity used for this application pool is whatever account was stored in the WAMUserName for the first migrated application that ran with the setting of High. By default, the process identity was set to the IWAM\_*computername*, but users could change this account. Therefore, if the account was changed, the application pool used whatever account was being used. Migrated applications with a setting of High are each migrated into their own application pool.
