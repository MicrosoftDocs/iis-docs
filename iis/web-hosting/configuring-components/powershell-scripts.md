---
title: "C# and PowerShell Scripts Samples"
author: walterov
description: "This article provides a summary of the PowerShell and C# Sample scripts mentioned throughout the Hosting Guidance. They can be used for deployment, configura..."
ms.date: 01/25/2008
ms.assetid: 25568a97-1a8b-4569-a49b-20c752d83e07
msc.legacyurl: /learn/web-hosting/configuring-components/powershell-scripts
msc.type: authoredcontent
---
# C# and PowerShell Scripts Samples

This article provides a summary of the PowerShell and C# Sample scripts mentioned throughout the Hosting Guidance. They can be used for deployment, configuration, migration, and provisioning tasks.

by [Walter Oliver](https://github.com/walterov)

## Deployment Scripts -Shared Hosting

1. [Web Server](https://www.iis.net/community/files/hosting/IISShareHostSetupScripts-v1.zip "Web Server Scripts")  

    These PowerShell scripts will help deploy and configured the Web Server. Notice that these scripts were written and tested using PS 2.0:

    - **runPKGMGT\_IIS.PS1**: runs the "pkgmgt.exe" command tool to install IIS 7.0 with the recommended modules for shared hosting, see [Installing the Web Server Role](../web-server-for-shared-hosting/installing-the-web-server-role.md).

        - The script uses the file "unattended.xml" as its input configuration data, it specifies the IIS modules to install.
        - **Required**: Unattend.xml requires that the version number be set to the current Product version of Windows i.e. version="6.0.6000.16386". This can be found by Right Clicking `C:\Windows\RegEdit.exe` and choosing the details tab. PkgMgr requires this parameter so that it can properly install all desired components
    - **Install\_IISSharedHosting.PS1**: runs all the configuration scripts in accordance to the Shared Hosting guidelines, see [Configuring IIS 7.0 for Shared Hosting](../web-server-for-shared-hosting/index.md).

        - The script uses the IISSettings.xml file as input configuration data. It contains settings for Dynamic Compression and Idle Threshold
        - The Default File setting for the server is controlled through Default\_File\_Config.xml. It contains a list of all Default file to be added or removed. Create as many entries as you'd like. Set activity="ADD" to add or "REMOVE" to remove.
    - **Enable32bitModeWorkerProcess.PS1**: enables the [32-bit mode worker processes](../web-server-for-shared-hosting/32-bit-mode-worker-processes.md) in 64 bit machines.
    - **AppPoolIdentAsAnonymousUser.PS1**: sets the [Application Pool Identity as Anonymous User](../web-server-for-shared-hosting/application-pool-identity-as-anonymous-user.md).
    - **AddRemoveDefaultDoc.PS1**: adds or removes [Default Documents](../web-server-for-shared-hosting/default-documents.md) based on the Default\_Files\_Config.XML input file specification.
    - **ConfigureDynamicIdleThreshold.PS1**: sets [dynamicIdleThreshold](../web-server-for-shared-hosting/dynamicidlethreshold.md) configuration property.
    - **ConfigureDynamicCompression.PS1**: sets the [Dynamic Compression](../web-server-for-shared-hosting/dynamic-compression.md) properties.
    - **HTTPResponseCache.PS1**: shows the [HTTP Response Cache](../web-server-for-shared-hosting/http-response-cache.md).
    - Coming soon: Setting [ASP.NET](../web-server-for-shared-hosting/aspnet-20-35-shared-hosting-configuration.md) medium trust.
2. [File Server](https://www.iis.net/community/files/hosting/FileServerSetupScripts-v1.zip "File Server Scripts")  
  
   These PowerShell scripts will help deploy and configured the File Server. Notice that these scripts were written and tested using PS 2.0:  

    - **InstallFileServer.PS1**: runs all the scripts to install and configure the FileServer Role.

        - Files: FolderPermissions.xml, SharePermissions.xml, DirectoryQuotas\_Settings.xml are populated with sample settings. each should be configured pre-deployment as these settings will vary on a per deployment.
        - DirectoryQuotas\_Settings.xml: Allows you to define as many folders quotas as necessary.
        - FolderPermissions.xml: Allows you to define as many Folders as necessary, and each folder may have 0, 1 or many permissions.
        - SharePermissions.xml: Allows you to define as many shares as necessary (will error if the new share does not correspond to an existing folder). Each share may have 0, 1, or many permissions.
    - **runPKGMGR\_FileServer**: runs the "pkgmgt.exe" command tool to install the File Server role. The script uses the file "unattended.xml" as its input parameter, it specifies the modules to install.
    - **DirectoryQuota.PS1**: sets the directory quota, see [Directory Quotas](../configuring-servers-in-the-windows-web-platform/enabling-directory-quotas.md).
    - **Folder\_Shares\_Permissions.PS1**: sets the folder permissions in accordance to the specification in the "SharePermissions.XML" input file. See [Share and NTFS Permissions](../configuring-servers-in-the-windows-web-platform/configuring-share-and-ntfs-permissions.md).

## Provisioning and Managing

1. [Provisioning Sample in C#](powershell-scripts/_static/powershell-scripts-327-iis7provisioningsample1.zip) is a set of C# samples to perform several common provisioning tasks, See details in the [Provisioning Sample in C#](../../manage/provisioning-and-managing-iis/provisioning-sample-in-c.md) article.
2. [Hosting Services Sample](powershell-scripts/_static/hssample_4-11.zip) is an extensive C# code sample for provisioning Sites, User accounts, SQL db, and others. See details in the [Hosting Services Code Sample](../../manage/provisioning-and-managing-iis/index.md) article.
3. [Code Samples and Scripts](../../manage/provisioning-and-managing-iis/index.md) provides sample code snippets for creating IIS 7.0 Sites and Configuration tasks.
4. [IIS Sites Provisioning PowerShell Scripts](https://www.iis.net/community/files/hosting/ProvisioningScripts%204-7-2008.zip "IIS Sites PowerShell Scripts"). These are 6 PowerShell Scripts to help you automate the provisioning of AppPools, Sites, Applications, Virtual Directories, and Bindings. They use the Microsoft.Web.Administration managed code namespace interfaces to provision these objects. Here is an example for each of them:  

    4.1. **To create any number of AppPools, Sites, Applications, Virtual Directories, and Bindings arranged in accordance to a configuration data file** use Sample\_AppPool\_Site\_AppCreation. This script calls all the others to create each object in accordance to the configuration data found in the ProvisioningConfig.xml XML file.

    Example:

    [!code-console[Main](powershell-scripts/samples/sample1.cmd)]

    Example of a ProvisioningConfig.xml XML file:

    [!code-xml[Main](powershell-scripts/samples/sample2.xml)]

    4.2. **To create AppPools** use CreateIISAppPool PoolName username password. If you do not provide username and password it will use the current user.

    Example:

    [!code-console[Main](powershell-scripts/samples/sample3.cmd)]

    4.3. **To create a Site** use CreateIISSite SiteName PhysicalPath PoolName ID.

    Example:

    [!code-console[Main](powershell-scripts/samples/sample4.cmd)]

    4.4. **To create an Application** on a site use CreateIISApplicationOntoSite PhysicalPath RelativePath SiteName PoolName.

    Example:

    [!code-console[Main](powershell-scripts/samples/sample5.cmd)]

    4.5. **To create a Virtual Directory** for an application use CreateIISVDirOntoApplication ApplicationPhysicalPath PhysicalPath SiteName RelativePath.

    Example:

    [!code-console[Main](powershell-scripts/samples/sample6.cmd)]

    4.6. **To create a Binding for a Site** use CreateIISBindingOntoSite SiteName Port BindingInfo Protocol.

    Example:

    [!code-console[Main](powershell-scripts/samples/sample7.cmd)]
