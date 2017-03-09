---
title: "Microsoft Web Deploy v2: Readme | Microsoft Docs"
author: bilalaslam
description: "Web Deploy v2 Readme Overview The Web Deploy is a tool for simplifying migration, management and deployment of Web applications, sites and servers. It can be..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 01/11/2011
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/publish/using-web-deploy/microsoft-web-deploy-v2-readme
msc.type: authoredcontent
---
Microsoft Web Deploy v2: Readme
====================
by [Bilal Aslam](https://github.com/bilalaslam)

<a id="Overview"></a>

## Overview

The Web Deploy is a tool for simplifying migration, management and deployment of Web applications, sites and servers. It can be used to package a Web site, automatically including content, configuration, certificates and databases. It can be used to synchronize between IIS 6.0 or IIS 7.0, or to migrate from IIS 6.0 to IIS 7.0. The packages created can be used for versioning, backup or deployment.

Please note that IIS 8.0 is only supported with Web Deploy V3.

<a id="Features"></a>

## Features

The Web Deploy includes these key features:

**Package Web sites and applications.** Developers or administrators can package the configuration and content of installed Web applications, including SQL databases, and use the packages for storage or redeployment. These packages can then be deployed using the IIS Manager interface without requiring administrative privileges on a remote server.

**Delegate deployment tasks to non-admins.** Server administrators can now choose to delegate deployment tasks to users who are not administrators. For example, in both shared hosting and enterprise environments, deploying content and marking a folder as an application can be delegated. More advanced tasks suitable to a dedicated environment, such as allowing a certificate, Web site or GAC'd assembly to be deployed, can also be enabled.

**Simplify deployment for administrators.** Server administrators will find the delegation useful, since deploying a Web application including a GAC'd assembly, certificate and application pool can be time-consuming even with all the permissions required.

**Migration from IIS 6.0.** The migrate operation provides administrators with a way to migrate sites or entire servers from IIS 6.0 to IIS 7.0, including their settings and content. A migration is essentially a way of synchronizing, filtered by migration rules.

**Synchronization of IIS 6.0 / IIS 7.0.** The sync operation provides administrators with a way to quickly synchronize a site or server and deploy changes to existing sites and servers. A synchronization allows you to synchronize one source with one destination. For example, you can synchronize two directory paths or two web servers. The sync can be performed with local or remote objects.

**Snapshot IIS 6.0 / IIS 7.0.** The snapshot, or archive, functionality allows administrators or developers to quickly take an archive of their web site or server for rollback, restore or backup purposes.

**Analysis of Dependencies on IIS 6.0 / IIS 7.0.** The analyze operation allows administrators to check what components are installed on the source server. In this way, they can determine if features are present that they will need in IIS 7.0 or that require more advanced setup than simply copying files.

**Troubleshooting and Validation.** For validating an operation, the -whatif parameter allows administrators to see what actions would happen when they perform an operation. This is especially useful for performing sync or migration, when they want to validate what changes will be made before performing them. For troubleshooting, the -verbose parameter allows administrators to get rich detail about what operations are being performed, and upon failure, the ability to diagnose the problem.

**Differential Synchronization.** The tool will only synchronize what has changed between the source and the destination.

<a id="Installation_Notes"></a>

## Installation Notes

<a id="Requirements"></a>

### Requirements

The following prerequisites must be fulfilled in order to install the tool:

- You must have .NET 2.0 SP1 or greater installed.

<a id="Installing"></a>

### Downloading and Installing

There are two separate downloadable packages for the tool; you will need to download the appropriate package:

[https://www.iis.net/download/WebDeploy](https://www.iis.net/downloads/microsoft/web-deploy)

You will need to run the installation package as an administrator. This can be accomplished by one of the following methods:

- Logging in to your server using the actual account named "Administrator".
- Logging on using an account with administrator privileges and opening a command-prompt by right-clicking the **Command Prompt** menu item that is located in the **Accessories** menu for Windows programs and selecting "Run as administrator", then typing the appropriate command listed below for your version of Windows to run the installation:


[!code-unknown[Main](microsoft-web-deploy-v2-readme/samples/sample-127162-1.unknown)]

**Important Note!** By default, setup will offer you the choice of installing the remote service and will use a default remote service URL, http://+:80/MSDEPLOY.

You can set the remote service URL to a custom URL by running setup from the command-line: (where the port and URL are specified, please customize):

[!code-unknown[Main](microsoft-web-deploy-v2-readme/samples/sample-127162-2.unknown)]

<a id="Known_Issues"></a>

## Known Issues

### Issue: Some Management Service delegation rules do not work after Web Deploy is upgraded to Web Deploy 2.0

If an IIS 7+ server is using shared configuration, certain delegation rules with runAs identity set to SpecificUser will stop working. This is because the Web Deploy installer and the .\AddDelegationRules.ps1 script creates local machine user accounts and sets them as the runAs identity on certain delegation rules. These user accounts will not be recognized on other machines and thus the rules will not work in shared configuration.  
**Workarounds:** 

- Do not install Web Deploy 2.0 using the Web Platform Installer. Instead, install it [directly](https://www.iis.net/downloads/microsoft/web-deploy) from the MSI and de-select the Configure for Non-administrator Deployments component
- If your delegation rules have already been overwritten, re-create them manually.

### Issue: Site created with .\SetupSite.ps1 PowerShell script is not browseable

When this script creates a site, it tries to assign it a port number between 8000 and 8200 which is not already taken. It may be the case that no free port is available, in which case the port assigned to this site will not work. Also, possibly, the port assigned to the site may be blocked by a firewall.

**Workarounds:** Manually assign the site a different port from the IIS Manager UI. Also, make sure that the port is not blocked by the firewall e.g. on Windows Server 2008 R2, run this command: "netsh advfirewall firewall add rule name="MySite" dir=in action=allow protocol=TCP localport=8080", where MySite is replaced by the name of your site.

**Issue:** Cannot publish to site created with SetupSiteForPublish.ps1 PowerShell script or configured for Web Deploy publishing through the "Configure for Web Deploy Publishing..." UI

The site creation script as well as the UI to configure Web Deploy for an existing site sets the publishing URL to [https://myserver:8172/msdeploy.axd](https://myserver:8172/msdeploy.axd). This computername is generally reachable within a network. However, it is often not reachable from outside the network, so it should be replaced with a public DNS name.

**Workarounds:** 

- From the script: The script does not warn about this error. Replace the URL with the correct one (as below) in the generated settings file.
- From the UI: enter the public DNS name in the "Specify the URL for the publishing server connection" field e.g. instead of [https://myserver:8172/msdeploy.axd](https://myserver:8172/msdeploy.axd) , enter [https://some.publicDnsName.com:8172/msdeploy.axd](https://some.publicdnsname.com:8172/msdeploy.axd)

### Issue: Web Deploy is consuming 100% CPU time for a few minutes

If the logging level is set too high, Web Deploy will consume 100% CPU when a sync operation is in progress. This can happen if the logging level is set to verbose (4) or information (3).

**Workarounds:** Set the logging level lower:

1. Start the Registry Editor
2. Navigate to HKEY\_LOCAL\_MACHINE\SOFTWARE\Microsoft\IIS Extensions\MSDeploy\2\WMSVCTracing and set it to 1 or 2, as required.
3. Restart the Web Management Service by opening an elevated command prompt and typing "net stop wmsvc" followed by "net start wmsvc"

## Issue: Web Deploy UI in IIS Manager gives a "Unable to cast object of type" error

If the destination computer has Web Deploy v1.1 installed and the source computer has v2 installed, you may see this error. This is a cross-version incompatibility.

**Workarounds:** 

- Upgrade source computer to Web Deploy v2
- Uninstall all versions of Web Deploy on source computer

### Issue: Web Deploy is unable to retrieve the USN number from remote server

The "-incremental" switch, when used with the dirPath provider, returns a USN number to be used with future syncs to allow for incremental sync.   
For example: msdeploy -verb:dump -source:dirpath=c:\Temp –incremental  
Returns: c:\Temp  
Info: The USN number for syncing source path 'c:\Temp' is '2140379512'.  
However, if the source is remote, the USN number doesn't get returned by the operation. This is a known limitation as Web Deploy v2 does not support retrieving a USN number from a remote server.

**Workaround:** Use another tool to retrieve the USN number from the remote server.

**Issue:** If you are syncing an IIS 6.0 machine with lots of sites (causing the metabase to be over 500MB), then the tool may hang and stop responding.  
**Workaround:** Create a list of the sites and sync each site individually.

**Issue:** If you are syncing from a machine to a remote machine where the content or shared config is on a third, separate machine (i.e., UNC), then the remote agent will be unable to authenticate properly.  
**Workaround:** Either sync manually or use the Web Deployment Handler instead.

**Issue:** If you try to package or archive a folder that has a loop of some kind (like you're trying to create the package inside a folder you're packaging), then the tool may crash or hang.  
**Workaround:** Do not sync looped folders.

**Issue:** If you are syncing a web site with over 100 subdirectories (1\2\3\..\100\101) then the tool may hang.  
**Workaround:** Do not sync folder structures that are 120 subdirectories deep.

**Issue:** If you change shared configuration settings (such as enable or disable shared config), you will need to restart the remote agent afterwards.  
**Workaround:** Restart the agent after making a change to shared config.

**Issue:** If you are syncing a Web site where the path is %systemdrive%\wwwroot to a destination Web site where the system drive is different (C: instead of D:), then your Web site's path will be expanded at the destination. This means if you have shared config means with different system drives and you rely on the %systemdrive% to ensure content works, you may break the site on a machine.  
**Workaround:** Add a replace rule to change the path during the sync.

**Issue:** If you are syncing an IIS 6.0 machine with lots of sites (causing the metabase to be over 500MB), then the tool may hang and stop responding.  
**Workaround:** Create a list of the sites and sync each site individually.

**Issue:** If you are syncing a folder marked as an application in IIS 6.0 to an archive or package, sometimes the content will not be automatically gathered.  
**Workaround:** Manually add the content folders to a custom manifest and sync the manifest. See the Help for more information about creating manifest files.

**Issue:** If you try to package to an existing package file, this may not work correctly.  
**Workaround:** Use a new name or delete the old package file before creating a new package.

**Issue:** The Microsoft Web Deploy will not move the physical files for Script maps and items referenced in the Web Service Extension Restriction List, unless the files are located in a Web site's content directories. This is because many ISAPIs may not migrate correctly, such as:

- ASP.NET (requires installation).
- WebDAV (which is not included in Windows Server 2008 by default and requires additional installation).
- FrontPage Server Extensions (which is not included in Windows Server 2008 by default and requires additional installation).

**Workaround:** Workaround: Manually include any script maps or files that do not require installation in a manifest file. See the Help for more information about creating manifest files.

**Issue:** Custom trust files referenced in the root level Web.config and Code Access Security (CAS) policy settings will not be moved.   
**Workaround:** Manually specify the custom trust file and the CAS policy file, security.config, in a manifest file. See the Help file for more information about creating manifest files.

**Issue:** If you move a site to a server that has a different trust level, you will not receive a warning.   
**Workaround:** Please ensure that the trust level is set correctly on the destination machine when doing a site level sync or migrate.

**Issue:** If you have a custom manifest file that is pointing to an invalid source, you may not receive an error.   
**Workaround:** If you are not seeing expected output when using a manifest file, try each item individually to see if they are mistyped or invalid.

**Issue:** FTP and SMTP are not included in the default definitions for webserver60.   
**Workaround:** If you need to sync these locations, manually sync them using the metakey provider - i.e., metakey=lm/msftpsvc.

**Issue:** Inherited properties are not migrated with an IIS 6.0 site migration. A common example is authentication set at the server level with all sites inheriting this property. When you migrate a single site, it will now inherit the settings of the new destination server. If the destination server settings are not the same, your site could break. This applies to every inherited property, including mime maps, script maps, etc.   
**Workaround:** Use the metadataGetInherited flag to copy inherited settings to the site level when you sync or migrate a web site on IIS 6.0. Or ensure the server settings are the same on source and destination servers or manually set the site to use correct settings.

<a id="Troubleshooting"></a>

## Troubleshooting Installation Issues

If you encounter any problems during installation, you can run appropriate command listed below for your version of Windows to create a log file that will contain information about the installation process:

[!code-unknown[Main](microsoft-web-deploy-v2-readme/samples/sample-127162-3.unknown)]

You can analyze this log file after a failed installation to help determine the cause of the failure.

<a id="More_Info"></a>

## For More Information

The following additional resources for the Web Deploy are available on IIS.net:

- [Web Deploy Walkthroughs.](https://go.microsoft.com/?linkid=8100895) Describes how to download and install the Web Deploy, how to use it for sync or migrate operations and more.
- Also, be sure to visit the [Web Deployment Team Blog](https://blogs.iis.net/msdeploy) for tips, tricks and latest information about the tool.

© 2007 – 2011 Microsoft Corporation.