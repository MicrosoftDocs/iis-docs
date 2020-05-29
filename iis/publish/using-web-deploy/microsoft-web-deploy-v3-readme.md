---
title: "Microsoft Web Deploy v3 Readme"
author: rick-anderson
description: "The Web Deploy is a tool for simplifying migration, management and deployment of Web applications, sites and servers. It can be used to package a Web site, a..."
ms.date: 04/19/2012
ms.assetid: d8f1e2f1-72d7-43b1-bdcb-ce18170a832a
msc.legacyurl: /learn/publish/using-web-deploy/microsoft-web-deploy-v3-readme
msc.type: authoredcontent
---
# Microsoft Web Deploy v3 Readme

by [Harsh Mittal](https://twitter.com/harshmittal)

## Overview

The Web Deploy is a tool for simplifying migration, management and deployment of Web applications, sites and servers. It can be used to package a Web site, automatically including content, configuration, certificates and databases. It can be used to synchronize between IIS 6.0, IIS 7.x and IIS8.0, or to migrate from IIS 6.0, IIS7.x to IIS 7.x and above. The packages created can be used for versioning, backup or deployment.

## Features

The Web Deploy includes these key features:

**Package Web sites and applications:** Developers or administrators can package the configuration and content of installed Web applications, including SQL databases, and use the packages for storage or redeployment. These packages can then be deployed using the IIS Manager interface without requiring administrative privileges on a remote server.

**Delegate deployment tasks to non-admins.** Server administrators can choose to delegate deployment tasks to users who are not administrators. For example, in both shared hosting and enterprise environments, deploying content and marking a folder as an application can be delegated. More advanced tasks suitable to a dedicated environment, such as allowing a certificate, Web site or GAC'd assembly to be deployed, can also be enabled.

**Simplify deployment for administrators.** Server administrators will find the delegation useful, since deploying a Web application including a GAC'd assembly, certificate and application pool can be time-consuming even with all the permissions required.

**Migration from IIS 6.0 and IIS7:** The migrate operation provides administrators with a way to migrate sites or entire servers from IIS 6.0 to IIS 7 and above, IIS7 to IIS8 including their settings and content. A migration is essentially a way of synchronizing, filtered by migration rules.

**Synchronization of IIS 6.0 / IIS 7/IIS8.0** The sync operation provides administrators with a way to quickly synchronize a site or server and deploy changes to existing sites and servers. A synchronization allows you to synchronize one source with one destination. For example, you can synchronize two directory paths or two web servers. The sync can be performed with local or remote objects.

**Snapshot IIS 7.0 and above** The snapshot, or archive, functionality allows administrators or developers to quickly take an archive of their web site or server for rollback, restore or backup purposes. Automatic snapshot feature also allows web site administrators to self-service some of above tasks.

**Analysis of Dependencies on IIS 6.0 and above** The analyze operation allows administrators to check what components are installed on the source server. In this way, they can determine if features are present that they will need in IIS 7.0 or that require more advanced setup than simply copying files.

**Troubleshooting and Validation.** For validating an operation, the -whatif parameter allows administrators to see what actions would happen when they perform an operation. This is especially useful for performing sync or migration, when they want to validate what changes will be made before performing them. For troubleshooting, the -verbose parameter allows administrators to get rich detail about what operations are being performed, and upon failure, the ability to diagnose the problem.

**Differential Synchronization.** The tool will only synchronize what has changed between the source and the destination.

**Easy Scripting through PowerShell:** Common Web Deploy tasks can be automated using PowerShell cmdlets.

## Installation Notes

### Requirements

The following prerequisites must be fulfilled in order to install the tool:

· You must have .NET 2.0 SP1 or greater installed.

### Downloading and Installing

There are two separate downloadable packages for the tool; you will need to download the appropriate package. You can download the [x86](https://go.microsoft.com/fwlink/?LinkId=249138) or [x64](https://go.microsoft.com/fwlink/?LinkId=249137) versions. 

## Important Issues Fixed in this release:

**Change:** In previous versions of Web Deploy the tempAgent service would always run on port 80. In Web Deploy v3 RC this port can by changed by specifying the new port in the computername argument using the format computername=serverName:####, tempagent=true (where #### is the port number to use)

**Change:** Fixed an issue with Web Deploy where the change counts were not accurate for -whatif operations when using the -useCheckSum option.

**Change**: Web Deploy V3 Automatically disables proxy settings. This was previously an issue for some clients, who were required to open Internet Explorer and disable proxy settings there prior to starting a sync.

**Change**: Added support for IPv6-style bindings in certificate sync logic. Previous versions could not sync IPv6 bindings properly.

**Change**: When syncing a child registry key to a server where the parent registry key does not exist, the parent registry keys up to the child key will now be created (without values) rather than the sync failing. For example, if syncing the registry key HKEY\_LOCAL\_MACHINE\SOFTWARE\MySoft\TestWeb1 where the MySoft key does not exist on the destination machine, the MySoft key will be created on the destination machine allowing the sync will succeed.

**Change:** In some cases Web Deploy publishing removed inherited permissions on root folder of site. Web Deploy V3 fixes this issue.

## Known Issues

**Issue:** Web Deploy v3 upgrade breaks SQLite syncs which were working using Web Deploy v2

The Web Deploy v3 executable default configuration files (msdeploy.exe.config and msdepsvc.exe.config) have been updated from .Net 2.0 to .Net 4.0, which results in this break.

**Workaround:** 

- SQLite has a .Net 4 compatible version. Copying sqlite3.exe from this release in "*%ProgramFiles%*\IIS\Microsoft Web Deploy V3" directory will resolve the issue.
- Change default .Net version for WebDeploy V3 msdeploy.exe.config to .Net 2.0 as shown below

[!code-xml[Main](microsoft-web-deploy-v3-readme/samples/sample1.xml)]

**Issue:** Web Deploy Agent service does not work with local users accounts that are not the Administrator user account, but are members of the Administrators group. ERROR\_USER\_NOT\_ADMIN error is returned.

The Remote Agent Service accepts either built-in Administrator or Domain Administrator credentials **,** any other administrator credentials will not work and will cause this error.

**Workaround:** 

Use built in administrator account or domain user account (part of admin group on the local machine).The Remote Agent Service accepts either built-in Administrator or Domain Administrator credentials. If you have a non-domain setup and want to use account other that built-in administrator, please do following:

- Create a separate user group MSDepSvcUsers on remote computer.
- Crate an local account A on both local &amp; remote computer.
- Add A to MSDepSvcUsers on remote computer.
- Use account A to publish, this will allow you to publish without needing to use built-in admin account.

**Issue:** Some Management Service delegation rules do not work after Web Deploy is upgraded to Web Deploy 3.0

If an IIS 7+ server is using shared configuration, certain delegation rules with runAs identity set to SpecificUser will stop working. This is because the Web Deploy installer and the .\AddDelegationRules.ps1 script creates local machine user accounts and sets them as the runAs identity on certain delegation rules. These user accounts will not be recognized on other machines and thus the rules will not work in shared configuration.  
**Workarounds:** 

· If your delegation rules have already been overwritten, re-create the affected rules manually.

**Issue:** Cannot publish to site created with SetupSiteForPublish.ps1 PowerShell script or configured for Web Deploy publishing through the "Configure for Web Deploy Publishing..." UI

The site creation script as well as the UI to configure Web Deploy for an existing site sets the publishing URL to [https://myserver:8172/msdeploy.axd](https://myserver:8172/msdeploy.axd). This computername is generally reachable within a network. However, it is often not reachable from outside the network, so it should be replaced with a public DNS name.

**Workarounds:** 

- From the script: The script does not warn about this error. Replace the URL with the correct one (as below) in the generated settings file.
- From the UI: enter the public DNS name in the "Specify the URL for the publishing server connection" field e.g. instead of [https://myserver:8172/msdeploy.axd](https://myserver:8172/msdeploy.axd), enter [https://some.publicDnsName.com:8172/msdeploy.axd](https://some.publicdnsname.com:8172/msdeploy.axd)

**Issue**: Package created with Web Deploy V3 Does not work with WebDeploy V2. It results in System.NullReferenceException.

**Workarounds:** 

- Upgrade target computer to Web Deploy v3
- Use Web Deploy V2 to create package.

**Issue**: Web Deploy UI in IIS Manager gives a "Unable to cast object of type" error

If the destination computer has Web Deploy v1.1 installed and the source computer has v2 installed, you may see this error. This is a cross-version incompatibility.

**Workarounds:** 

- Upgrade source computer to Web Deploy v2
- Uninstall all versions of Web Deploy on source computer

**Issue:** If you are syncing an IIS 6.0 machine with lots of sites (causing the metabase to be over 500MB), then the tool may hang and stop responding.  
**Workaround:** 

Create a list of the sites and sync each site individually.

**Issue:** If you are syncing from a machine to a remote machine where the content or shared config is on a third, separate machine (i.e., UNC), then the remote agent will be unable to authenticate properly.  
**Workaround:** 

Either sync manually or use the Web Deployment Handler instead.

**Issue:** If you change shared configuration settings (such as enable or disable shared config), you will need to restart the remote agent afterwards.  
**Workaround:** 

Restart the agent after making a change to shared config.

**Issue:** If you are syncing a Web site where the path is `%systemdrive%\wwwroot` to a destination Web site where the system drive is different (C: instead of D:), then your Web site's path will be expanded at the destination. This means if you have shared config means with different system drives and you rely on the `%systemdrive%` to ensure content works, you may break the site on a machine.  
**Workaround:** 

Add a replace rule to change the path during the sync.

**Issue:** If you try to package to an existing package file, this may not work correctly.  
**Workaround:** 

Use a new name or delete the old package file before creating a new package.

**Issue:** The Microsoft Web Deploy will not move the physical files for Script maps and items referenced in the Web Service Extension Restriction List, unless the files are located in a Web site's content directories. This is because many ISAPIs may not migrate correctly, such as:

- ASP.NET (requires installation).
- WebDAV (which is not included in Windows Server 2008 by default and requires additional installation).
- FrontPage Server Extensions (which is not included in Windows Server 2008 by default and requires additional installation).

**Workaround:** 

Manually include any script maps or files that do not require installation in a manifest file. See the Help for more information about creating manifest files.

**Issue:** Custom trust files referenced in the root level Web.config and Code Access Security (CAS) policy settings will not be moved.   
**Workaround:** 

Manually specify the custom trust file and the CAS policy file, security.config, in a manifest file. See the Help file for more information about creating manifest files.

**Issue:** If you move a site to a server that has a different trust level, you will not receive a warning.   
**Workaround:** 

Please ensure that the trust level is set correctly on the destination machine when doing a site level sync or migrate.

**Issue:** If you have a custom manifest file that is pointing to an invalid source, you may not receive an error.   
**Workaround:** 

If you are not seeing expected output when using a manifest file, try each item individually to see if they are mistyped or invalid.

**Issue:** FTP and SMTP are not included in the default definitions for webserver60.   
**Workaround:** 

If you need to sync these locations, manually sync them using the metakey provider - i.e., metakey=lm/msftpsvc.

**Issue:** Inherited properties are not migrated with an IIS 6.0 site migration. A common example is authentication set at the server level with all sites inheriting this property. When you migrate a single site, it will now inherit the settings of the new destination server. If the destination server settings are not the same, your site could break. This applies to every inherited property, including mime maps, script maps, etc.   
**Workaround:** 

Use the metadataGetInherited flag to copy inherited settings to the site level when you sync or migrate a web site on IIS 6.0. Or ensure the server settings are the same on source and destination servers or manually set the site to use correct settings.

## Troubleshooting Installation Issues

If you encounter any problems during installation, you can run appropriate command listed below for your version of Windows to create a log file that will contain information about the installation process:

msiexec /L msdeployinstall.log /I &lt;path\_to\_msi&gt;

msiexec /L msdeployinstall.log /I &lt;path\_to\_msi&gt;

You can analyze this log file after a failed installation to help determine the cause of the failure.

## For More Information

The following additional resources for the Web Deploy are available on IIS.net:

- [Web Deploy Walkthroughs.](https://go.microsoft.com/?linkid=8100895) Describes how to download and install the Web Deploy, how to use it for sync or migrate operations and more.
- Also, be sure to visit the [Web Deployment Team Blog](https://blogs.iis.net/msdeploy) for tips, tricks and latest information about the tool.
